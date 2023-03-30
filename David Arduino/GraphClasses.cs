using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace David_Arduino
{
    public class HitDataPoint
    {
        private TimeSpan time; //Time Of Hit
        private float force; //Force Of Hit
        private float accel; //Acceleration Of Hit

        public TimeSpan GetTime() //Return Time of Hit
        {
            return time;
        }

        public void SetTime(TimeSpan time) //Set Time of Hit
        {
            this.time = time;
        }

        public float GetForce() //Return Force of Hit
        {
            return force;
        }

        public void SetForce(float force) //Set Force of Hit
        {
            this.force = force;
        }

        public float GetAccel() //Get Acceleration of Hit
        {
            return accel;
        }

        public void SetAccel(float accel) //Set Acceleration of Hit
        {
            this.accel = accel;
        }
    }
}
