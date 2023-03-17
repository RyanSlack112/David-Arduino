using System;
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

        public Data_Functions() 
        {
            port = new SerialPort("0x68", 9600);
            acceleration = 0;
            force = 0;
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

        private float calcAccel(float accel_x, float accel_y, float accel_z)
        {
            accel_z -= gravity;
            float accel = (float)Math.Sqrt(accel_x * accel_x + accel_y * accel_y + accel_z * accel_z);
            return accel;
        }

        private float calcForce(float accel, float mass)
        {
            float force = accel * mass;
            return force;
        }

        public float getArduinoOutput()
        {
            float x = 0;
            float y = 0;
            float z = 0;
            try
            {
                if(port.IsOpen)
                {
                    string data = port.ReadLine();
                    string[] values = data.Split(',');
                    if(values.Length > 3) 
                    {
                        x = float.Parse(values[0]);
                        y = float.Parse(values[1]);
                        z = float.Parse(values[2]);
                    }
                    acceleration = calcAccel(x, y, z);
                    force = calcForce(acceleration, mass);
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
