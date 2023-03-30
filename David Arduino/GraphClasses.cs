using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace David_Arduino
{
    public class HitDataPoint
    {
        private TimeSpan time;
        private float force;
        private float accel;

        public TimeSpan GetTime()
        {
            return time;
        }

        public void SetTime(TimeSpan time)
        {
            this.time = time;
        }

        public float GetForce()
        {
            return force;
        }

        public void SetForce(float force)
        {
            this.force = force;
        }

        public float GetAccel()
        {
            return accel;
        }

        public void SetAccel(float accel)
        {
            this.accel = accel;
        }
    }
}
