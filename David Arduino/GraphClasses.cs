using MaterialSkin;
using System;
using System.Drawing;
using System.Windows.Forms.DataVisualization.Charting;

namespace David_Arduino
{
    public class GraphFunctions
    {
        public static void ChangeGraphColours(Chart chart)
        {
            MaterialSkinManager skinManager = MaterialSkinManager.Instance;//Material Skin Manager Instance

            switch (skinManager.Theme)
            {
                case MaterialSkinManager.Themes.LIGHT: //Light Theme turns Text Black
                    chart.ChartAreas[0].AxisX.TitleForeColor = Color.Black;
                    chart.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.Black;
                    chart.ChartAreas[0].AxisY.TitleForeColor = Color.Black;
                    chart.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.Black;
                    break;
                case MaterialSkinManager.Themes.DARK: //Dark Theme turns Text White
                    chart.ChartAreas[0].AxisX.TitleForeColor = Color.White;
                    chart.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.White;
                    chart.ChartAreas[0].AxisY.TitleForeColor = Color.White;
                    chart.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.White;
                    break;
                default:
                    break;
            }
        }
    }

    public class HitDataPoint
    {
        private TimeSpan time; //Time Of Hit
        private float force; //Force Of Hit
        private float accel; //Acceleration Of Hit

        public TimeSpan GetTime() { return time; } //Return Time of Hit

        public void SetTime(TimeSpan time) { this.time = time; } //Set Time of Hit

        public float GetForce() { return force; } //Return Force of Hit

        public void SetForce(float force) { this.force = force; } //Set Force of Hit

        public float GetAccel() { return accel; } //Get Acceleration of Hit

        public void SetAccel(float accel) { this.accel = accel; } //Set Acceleration of Hit
    }

    public class HitCounterDataPoint
    {

    }

    public class HitCounterSessionData
    {
        private TimeSpan startTime;
        private TimeSpan endTime;
        private int amountOfHits;

        public TimeSpan GetStartTime() { return startTime; }
        public void SetStartTime(TimeSpan startTime) { this.startTime = startTime; }
        public TimeSpan GetEndTime() { return endTime; }
        public void SetEndTime(TimeSpan endTime) { this.endTime = endTime; }
        public int GetAmountOfHits() { return amountOfHits; }
        public void SetAmountOfHits(int amountOfHits) { this.amountOfHits = amountOfHits; }
    }

    public class ControlDataPoint
    {

    }
}
