using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Threading;
using System.IO;
using System.Web.UI.Design;

namespace David_Arduino
{
    internal class Data_Functions
    {
        private const float gravity = 9.8f; //Constant of Gravity
        private float mass = 17.4f; //Mass of the bag
        public SerialPort port; //Serial Port to interact with the Arduino
        private string portName; //Port Name
        private float acceleration; //Acceleration Variable
        private float force; //Force Variable
        MainForm _mainForm; //Main Form Object
        DBFunctions dbFunctions; //Data Base Functions Object
        List<HitData> hitDataList; //List of HitData Objects for Graph
        string username; //Signed in Username
        bool deviceConnected;

        public Data_Functions(MainForm mainForm, DBFunctions dbFunctions, string username) //Constructor
        {
            try
            {
                portName = GetDefaultPort();
                port = CreatePort(portName);
                deviceConnected = true;
            }
            catch(ArgumentException)
            {
                deviceConnected = false;
                MessageBox.Show("There is no Device Connected.\r\nPlease Connect a Device before continuing.", "Device Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            /*
             * Default Values
             */
            acceleration = 0;
            force = 0;
            _mainForm = mainForm;
            this.dbFunctions = dbFunctions;
            hitDataList = new List<HitData>();
            this.username = username;
            GetPortNames();
            _mainForm.SetCurrentPortText(portName);
        }

        public SerialPort CreatePort(string portName)
        {
            if(String.IsNullOrEmpty(portName))
            {
                throw new ArgumentException();
            }
            SerialPort port = new SerialPort(portName, 9600, Parity.None, 8, StopBits.One); //Intialize Port
            return port;
        }

        private string GetDefaultPort()
        {
            string[] ports = SerialPort.GetPortNames();

            if(ports.Length > 0)
            {
                string defaultPort = ports[0];
                return defaultPort;
            }
            else
            {
                return null;
            }
        }

        /*
         * Programmatically Assign Portname(TODO)
         */
        private void GetPortNames()
        {
            string[] ports = SerialPort.GetPortNames();
            foreach (string _port in ports)
            {
             _mainForm.SetPortsComboBox(_port);
            }
        }

        public void SetPort(SerialPort port) { this.port = port; }

        public void OpenPort() { port.Open(); } //Opens Port to Arduino

        public void ClosePort() { port.Close(); } //Closes Port to Arduino

        public void DeletePort() { port.Dispose(); }

        public float GetMass() { return mass; } //Mass Getter

        public void SetMass(float mass) { this.mass = mass; } //Mass Setter

        public float GetAccel() { return acceleration; } //Acceleration Getter

        public float GetForce() { return force; } //Force Getter

        public bool CheckDeviceConnection()
        {
            if(deviceConnected)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /*
         * Calculates the Acceleration from the X, Y, Z inputs from Accelerometer
         */
        private float CalcAccel(float accel_x, float accel_y, float accel_z)
        {
            accel_z -= gravity;
            float accel = (float)Math.Sqrt(accel_x * accel_x + accel_y * accel_y + accel_z * accel_z);
            return accel;
        }

        /*
         * Calculates the Force using the Acceleration from the Accelerometer
         * and Mass defined within the program
         */
        private float CalcForce(float accel, float mass)
        {
            float force = accel * mass;
            return force;
        }

        /*
         * Check if ComboBox needs to be checked on other thread than current
         * If so, complete check on other thread then pass Text to ChangeMainLabel Function
         * Otherwise, check what option is checked in ComboBox and pass appropriate Text to ChangeMainLabel Function
         */
        private void CheckComboBox(float force, float acceleration)
        {
            if(_mainForm.GetMainComboBox().InvokeRequired)
            {
                string comboBoxText = (string)_mainForm.GetMainComboBox().Invoke(new Func<string>(() => _mainForm.GetComboUnitText()));
                if (comboBoxText == "Acceleration") //Check if Acceleration is Checked
                {
                    string accel = acceleration.ToString("N2") + " m/s" + '\u00B2';
                    ChangeMainLabel(accel.Trim());
                }
                else if (comboBoxText == "Force") //Check if Force is Checked
                {
                    string forceText = force.ToString("N2") + " N";
                    ChangeMainLabel(forceText.Trim()); //Display the value of the acceleration on Screen
                }
            }
            else
            {
                if (_mainForm.GetComboUnitText() == "Acceleration") //Check if Acceleration is Checked
                {
                    string accel = acceleration.ToString("N2") + " m/s" + '\u00B2';
                    ChangeMainLabel(accel.Trim());
                }
                else if (_mainForm.GetComboUnitText() == "Force") //Check if Force is Checked
                {
                    string forceText = force.ToString("N2") + " N";
                    ChangeMainLabel(forceText.Trim());
                }
            }
            
        }

        /*
         * Check if the Main Label needs to be changed on a different thread than current
         * If so, complete the Change of Label Text on other thread
         * Otherwise Change Label Text
         */
        private void ChangeMainLabel(string labelText)
        {
            if(_mainForm.GetMainLabel().InvokeRequired)
            {
                _mainForm.GetMainLabel().Invoke(new Action<string>(ChangeMainLabel), labelText);
            }
            else
            {
                _mainForm.SetOutputLabel(labelText); //Display the value of the acceleration on Screen
            }
        }

        /*
         * Add the List of Hit Data Values to the Database
         */
        public void AddHitData()
        {
            foreach(HitData hitData in hitDataList)
            {
                dbFunctions.AddToHitData(hitData);
            }
        }

        /*
         * Populates the X, Y and Z values from the Arduino data and performs calculations
         * of Acceleration and Force.
         */
        public void GetArduinoOutput(string username)
        {
            /*
             * Default Values
             */
            float x = 0;
            float y = 0;
            float z = 0;
            try
            {
                if (port.IsOpen)
                {
                    port.NewLine = "\r\n";
                    string data = port.ReadLine(); //Data from the Arduino
                    string[] values = data.Split(','); //Split the String from the Arduino using comma as seperation char
                    
                    /*
                    * If greater than 3 values after splitting use the first 3 elements to
                    * populate the X, Y and Z values.
                    */
                    if(values.Length > 2) 
                    {
                        x = float.Parse(values[0]);
                        y = float.Parse(values[1]);
                        z = float.Parse(values[2]);
                        acceleration = CalcAccel(x, y, z); //Calculate Acceleration
                        force = CalcForce(acceleration, mass); //Calculate Force

                        if(force > 60)
                        {
                            DateTime dateTime = DateTime.Now;
                            HitData hitData = new HitData(username, dateTime, force, acceleration);
                            hitDataList.Add(hitData);
                            CheckComboBox(force, acceleration);
                        }
                        else
                        {
                            CheckComboBox(0, 0);
                        }
                    }
                }
            }
            catch (TimeoutException) 
            {
                force = 0;
                acceleration = 0;
                MessageBox.Show("Timeout Exception");
            }
            catch (FormatException)
            {
                force = 0;
                acceleration = 0;
                MessageBox.Show("Format Exception");
            }
            catch (IOException ex)
            {
                if (ex.InnerException is InvalidOperationException)
                {
                    // The serial port was closed
                }
            }
        }

        /*
         * Retrieves the hit data from the Database to populate the Data Points
         * Return the List of the Data Points
         * Map the List of Data Points to the Graph
         */
        public void GenerateMainGraph()
        {
            string day = _mainForm.GetGraphMainDate(); //Return the Day selected in the Graph Main View
            List<HitDataPoint> hitDataPoints = dbFunctions.GetHitDataFromDb(username, day); //Return a List of Data Points according to Signed in User and Day selected.
            
            _mainForm.MapHitDataSeries(hitDataPoints); //Map the List of Data Points to the Graph.
        }

        /*
         * Retrieves the control data from the Database to populate the Data Points
         * Return the List of the Data Points
         * Map the List of Data Points to the Graph
         */
        public void GenerateControlGraph()
        {
            string day = _mainForm.GetGraphControlDate();
            List<ControlDataPoint> controlDataPoints = dbFunctions.GetControlDataFromDb(username, day);

            _mainForm.MapControlDataSeries(controlDataPoints);
        }

        /*
         * Retrieves the control data from the Database to populate the Data Points
         * Return the List of the Data Points
         * Map the List of Data Points to the Graph
         */
        public void GenerateHitCounterGraph()
        {
            //string day = _mainForm.GetGraphHitCounterDate();
            //List<HitCounterDataPoint> hitCounterDataPoints = dbFunctions.GetHitCounterDataFromDb(username, day);

            //_mainForm.MapHitCounterDataSeries(hitCounterDataPoints);
        }

        public static List<string> GetSessionList(List<HitCounterSessionData> sessions)
        {
            List<string> sessionTexts = new List<string>();
            foreach (HitCounterSessionData session in sessions)
            {
                string sessionText = session.GetStartTime().ToString(@"hh\:mm") + " - " + session.GetEndTime().ToString(@"hh\:mm");
                sessionTexts.Add(sessionText);
            }
            
            return sessionTexts;
        }

        public static TimeSpan GetDuration(TimeSpan start, TimeSpan end)
        {
            TimeSpan duration = start - end;
            return duration;
        }
    }
}