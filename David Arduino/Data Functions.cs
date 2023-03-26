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
        MainForm _mainForm;

        public Data_Functions(MainForm mainForm) //Constructor
        {
            //portName = getPortName();
            port = new SerialPort("COM3", 9600, Parity.None, 8, StopBits.One); //Intialize Port

            /*
             * Default Values
             */
            acceleration = 0;
            force = 0;
            _mainForm = mainForm;
        }

        private string getPortName()
        {
            string portStr = "COM3";
            string[] ports = SerialPort.GetPortNames();
            foreach (string _port in ports)
            {
                if (_port.Contains("Arduino") || _port.StartsWith("COM"))
                {
                    Console.WriteLine(_port);
                    portStr = _port;
                    return portStr;
                }            
            }
            return portStr;
        }

        public void openPort() //Opens Port to Arduino
        { 
            port.Open();
        }

        public void closePort() //Closes Port to Arduino
        {
            port.Close();
        }

        public float getMass() //Mass Getter
        {
            return mass;
        }

        public void setMass(float mass) //Mass Setter
        {
            this.mass = mass;
        }

        public float getAccel() //Acceleration Getter
        {
            return acceleration; 
        }

        public float getForce() //Force Getter
        {
            return force;
        }

        /*
         * Calculates the Acceleration from the X, Y, Z inputs from Accelerometer
         */
        private float calcAccel(float accel_x, float accel_y, float accel_z)
        {
            accel_z -= gravity;
            float accel = (float)Math.Sqrt(accel_x * accel_x + accel_y * accel_y + accel_z * accel_z);
            return accel;
        }

        /*
         * Calculates the Force using the Acceleration from the Accelerometer
         * and Mass defined within the program
         */
        private float calcForce(float accel, float mass)
        {
            float force = accel * mass;
            return force;
        }

        private void checkComboBox(float force, float acceleration)
        {
            if(_mainForm.getMainComboBox().InvokeRequired)
            {
                string comboBoxText = (string)_mainForm.getMainComboBox().Invoke(new Func<string>(() => _mainForm.getComboUnitText()));
                if (comboBoxText == "Acceleration") //Check if Acceleration is Checked
                {
                    changeMainLabel(acceleration.ToString("N2") + " m/s^2");
                }
                else if (comboBoxText == "Force") //Check if Acceleration is Checked
                {
                    changeMainLabel(force.ToString("N2") + " N"); //Display the value of the acceleration on Screen
                }
            }
            else
            {
                if (_mainForm.getComboUnitText() == "Acceleration")
                {
                    string accel = acceleration.ToString("N2") + " m/s^2";
                    changeMainLabel(accel.Trim());
                }
                else if (_mainForm.getComboUnitText() == "Force")
                {
                    string forceText = force.ToString("N2") + " N";
                    changeMainLabel(forceText.Trim());
                }
            }
            
        }

        private void changeMainLabel(string labelText)
        {
            if(_mainForm.getMainLabel().InvokeRequired)
            {
                _mainForm.getMainLabel().Invoke(new Action<string>(changeMainLabel), labelText);
            }
            else
            {
                _mainForm.setOutputLabel(labelText); //Display the value of the acceleration on Screen
            }
        }

        public void TestLabel()
        {

            while(_mainForm.isRunning)
            {
                Random rnd = new Random();
                int testVal = rnd.Next();
                Thread.Sleep(1000);
                changeMainLabel(testVal.ToString());
            }
        }

        /*
         * Populates the X, Y and Z values from the Arduino data and performs calculations
         * of Acceleration and Force.
         */
        public void getArduinoOutput()
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
                        acceleration = calcAccel(x, y, z); //Calculate Acceleration
                        force = calcForce(acceleration, mass); //Calculate Force
                        checkComboBox(force, acceleration);
                    }
                    
                    
                    //changeMainLabel(data.Trim());
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
    }
}
