﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace David_Arduino
{
    public class HitData
    {
        private string username;
        private DateTime dateTime;
        private float force;
        private float acceleration;

        public HitData(string username, DateTime dateTime, float force, float acceleration)
        {
            this.username = username;
            this.dateTime = dateTime;
            this.force = force;
            this.acceleration = acceleration;
        }

        public string getUsername() { return username; }

        public string getDate() { return dateTime.ToString("yyyy-MM-dd"); }

        public string getTime() { return dateTime.ToString("HH:mm:ss:fff"); }

        public float getForce() { return force; }

        public float getAcceleration() { return acceleration; }
    }

    public class HitCounterData
    {
        string username;
        DateTime dateTime;

        public HitCounterData(string username, DateTime dateTime)
        {
            this.username = username;
            this.dateTime = dateTime;
        }

        public string getUsername() { return username; }

        public string getDate() { return dateTime.ToString("yyyy-MM-dd"); }

        public string getTime() { return dateTime.ToString("HH:mm:ss:fff"); }
    }

    public class ControlData
    {
        string username;
        DateTime dateTime;

        public ControlData(string username, DateTime dateTime)
        {
            this.username = username;
            this.dateTime = dateTime;
        }

        public string getUsername() { return username; }

        public string getDate() { return dateTime.ToString("yyyy-MM-dd"); }

        public string getTime() { return dateTime.ToString("HH:mm:ss:fff"); }
    }
}
