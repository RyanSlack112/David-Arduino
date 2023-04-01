using MaterialSkin;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace David_Arduino
{
    public class GraphFunctions
    {
        public static void ChangeGraphColours(Chart chart)
        {
            MaterialSkinManager skinManager = MaterialSkinManager.Instance;
            if (skinManager.Theme == MaterialSkinManager.Themes.DARK)
            {
                chart.ChartAreas[0].AxisX.TitleForeColor = Color.White;
                chart.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.White;
                chart.ChartAreas[0].AxisY.TitleForeColor = Color.White;
                chart.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.White;
            }
            else if (skinManager.Theme == MaterialSkinManager.Themes.LIGHT)
            {
                chart.ChartAreas[0].AxisX.TitleForeColor = Color.Black;
                chart.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.Black;
                chart.ChartAreas[0].AxisY.TitleForeColor = Color.Black;
                chart.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.Black;
            }
        }
    }

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

    public class ControlDataPoint
    {

    }
}
