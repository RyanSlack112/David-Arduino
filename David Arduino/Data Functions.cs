using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;  

namespace David_Arduino
{
    internal class Data_Functions
    {
        private const float gravity = 9.8f; //Constant of Gravity
        private float mass = 17.4f; //Mass of the bag
        public SerialPort port; //Serial Port to interact with the Arduino
        private float acceleration; //Acceleration Variable
        private float force; //Force Variable
        MainForm mainForm;

        public Data_Functions() //Constructor
        {
            port = new SerialPort("COM4", 9600); //Intialize Port
            /*
             * Default Values
             */
            acceleration = 0;
            force = 0;
            mainForm = (MainForm)Application.OpenForms.Cast<Form>().FirstOrDefault(x => x.Name == "MainForm");
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

        /*
         * Populates the X, Y and Z values from the Arduino data and performs calculations
         * of Acceleration and Force.
         */
        public float getArduinoOutput()
        {
            /*
             * Default Values
             */
            float x = 0;
            float y = 0;
            float z = 0;
            try
            {
                if(port.IsOpen)
                {
                    string data = port.ReadLine(); //Data from the Arduino
                    string[] values = data.Split(','); //Split the String from the Arduino using comma as seperation char
                    /*
                     * If greater than 3 values after splitting use the first 3 elements to
                     * populate the X, Y and Z values.
                     */
                    if(values.Length > 3) 
                    {
                        x = float.Parse(values[0]);
                        y = float.Parse(values[1]);
                        z = float.Parse(values[2]);
                    }
                    acceleration = calcAccel(x, y, z); //Calculate Acceleration
                    if(mainForm.getComboUnitText() == "Acceleration")
                    {
                        mainForm.setOutputLabel(acceleration.ToString() + " m/s^2");
                    }
                    force = calcForce(acceleration, mass); //Calculate Force
                    if(mainForm.getComboUnitText() == "Force")
                    {
                        mainForm.setOutputLabel(force.ToString() + " N");
                    }
                }
            }
            catch (TimeoutException) 
            {
                force = 0;
            }
            catch (FormatException)
            {
                force = 0;
            }
            return force;
        }
    }
}
