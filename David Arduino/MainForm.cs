using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.Design;
using System.Windows.Forms;


namespace David_Arduino
{
    public partial class MainForm : MaterialForm
    {
        Data_Functions dFunc;
        MaterialSkinManager skinManager = MaterialSkinManager.Instance;
        public MainForm()
        {
            InitializeComponent();
            dFunc = new Data_Functions(); //Arduino Data and Connection Object
            /*
             * Material Skin Initialization Code
             */
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            
        }

        

        private void btnClose_Click(object sender, EventArgs e)
        {
            if(dFunc.port.IsOpen) //Before Closing checks if port is closed
            {
                dFunc.port.Close(); //Closes Arduino Port
            }
            Close(); //Closes Program
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                dFunc.openPort(); //Opens port to Arduino and connects
                /*
                 * Button Visibility and Enabling Changes
                 */
                btnStart.Enabled = false;
                btnStart.Visible = false;
                btnStop.Enabled = true;
                btnStop.Visible = true;
            }
            catch (IOException)
            {
                MessageBox.Show("Please Connect The Arduino Before Proceeding", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            /*
             * Button Visibility and Enabling Changes
             */
            btnStop.Enabled = false;
            btnStop.Visible = false;
            btnStart.Enabled = true;
            btnStart.Visible = true;

            dFunc.closePort(); //Closes port to the Arduino
        }

        private void btnSettingsClose_Click(object sender, EventArgs e)
        {
            if (dFunc.port.IsOpen) //Before Closing checks if port is closed
            {
                dFunc.port.Close();//Closes Arduino Port
            }
            Close(); //Closes Program
        }

        private void btnGraphClose_Click(object sender, EventArgs e)
        {
            if (dFunc.port.IsOpen) //Before Closing checks if port is closed
            {
                dFunc.port.Close(); //Closes Arduino Port
            }
            Close(); //Closes Program
        }

        private void btnStatsClose_Click(object sender, EventArgs e)
        {
            if (dFunc.port.IsOpen) //Before Closing checks if port is closed
            {
                dFunc.port.Close(); //Closes Arduino Port
            }
            Close(); //Closes Program
        }

        private void btnLight_Click(object sender, EventArgs e)
        {
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT; //Changes Material Skin Theme to Light
        }

        private void btnDark_Click(object sender, EventArgs e)
        {
            skinManager.Theme = MaterialSkinManager.Themes.DARK; //Changes Material Skin Theme to Dark
        }

        /*
         * Changes the Title Text of the program depending on the selected Tab
         */
        private void Tabs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabs.SelectedTab == tabMain)
            {
                this.Text = "Main Page";
            }
            else if (tabs.SelectedTab == tabGraph) 
            {
                this.Text = "Graph View";
            }
            else if (tabs.SelectedTab == tabStatistics)
            {
                this.Text = "Statistics";
            }
            else if (tabs.SelectedTab == tabSettings)
            {
                this.Text = "Settings";
            }
        }

        /*
         * Checks the connection of the Arduino
         */
        private void btnCheck_Click(object sender, EventArgs e)
        {
            try
            {
                dFunc.openPort(); //Opens Arduino Port
                MessageBox.Show("The Arduino is connected", "Connection Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dFunc.port.Close(); //Closes Arduino Port
            }
            catch (IOException) //Exception if Arduino is not connected
            {
                MessageBox.Show("The Arduino is not connected", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
