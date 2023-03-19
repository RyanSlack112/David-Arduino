using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.SqlServer.Server;
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
using System.Media;


namespace David_Arduino
{
    public partial class MainForm : MaterialForm
    {
        Data_Functions dFunc;
        MaterialSkinManager skinManager = MaterialSkinManager.Instance;
        bool isRunning;

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

        public string getOutputLabelText() //Output Label Getter
        {
            return lblOutput.Text;
        }

        public void setOutputLabel(string outputText) //Output Label Setter
        {
            lblOutput.Text = outputText;
        }

        public string getComboUnitText() //Returns the value of the combo box on the page
        {
            return cmbUnit.SelectedItem.ToString();
        }

        private void startRunning()
        {
            Task readArduinoThread = new Task(() => //Create a new Thread to run the loop
            {
                while (isRunning) //Continuously Read the Data from the Arduino
                {
                    dFunc.getArduinoOutput();
                }
            });
            readArduinoThread.Start(); //Start the Thread
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

                /*
                 * Enable the reading of the Data from the Arduino
                 */
                isRunning = true;
                startRunning(); //Start reading from the Arduino
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

            isRunning = false; //Stop the Loop and stop the reading of the data from the Arduino
            dFunc.closePort(); //Closes port to the Arduino
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (dFunc.port.IsOpen) //Before Closing checks if port is closed
            {
                dFunc.port.Close(); //Closes Arduino Port
            }
            Close(); //Closes Program
        }

        private void btnHitCounterClose_Click(object sender, EventArgs e)
        {
            if (dFunc.port.IsOpen) //Before Closing checks if port is closed
            {
                dFunc.port.Close(); //Closes Arduino Port
            }
            Close(); //Closes Program
        }

        private void btnControlClose_Click(object sender, EventArgs e)
        {
            if (dFunc.port.IsOpen) //Before Closing checks if port is closed
            {
                dFunc.port.Close(); //Closes Arduino Port
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

        private void btnSettingsClose_Click(object sender, EventArgs e)
        {
            if (dFunc.port.IsOpen) //Before Closing checks if port is closed
            {
                dFunc.port.Close();//Closes Arduino Port
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
            else if(tabs.SelectedTab == tabHitCounter)
            {
                this.Text = "Hit Counter";
            }
            else if(tabs.SelectedTab == tabControl)
            {
                this.Text = "Control";
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

        private void btnTest_Click(object sender, EventArgs e)
        {
            setOutputLabel(getComboUnitText());
        }

        private void btnChangeMass_Click(object sender, EventArgs e)
        {
            try
            {
                float newMass = float.Parse(txtMassInput.Text); //Take the input from the Mass Input Textbox
                dFunc.setMass(newMass); //Set the new Mass
                MessageBox.Show("Mass Changed Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information); //Display a MessageBox indicating the successful changing of the Mass
            }
            catch (FormatException) //Invalid Input
            {
                MessageBox.Show("Please input a number in Kilograms", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTestMass_Click(object sender, EventArgs e)
        {
            setOutputLabel(dFunc.getMass().ToString());
        }

        private void btnHitCounterStart_Click(object sender, EventArgs e)
        {
            btnHitCounterStart.Enabled = false;
            btnHitCounterStart.Visible = false;
            btnHitCounterStop.Enabled = true;
            btnHitCounterStop.Visible = true;
        }

        private void btnHitCounterStop_Click(object sender, EventArgs e)
        {
            btnHitCounterStart.Enabled = true;
            btnHitCounterStart.Visible = true;
            btnHitCounterStop.Enabled = false;
            btnHitCounterStop.Visible = false;
        }

        private void btnControlStart_Click(object sender, EventArgs e)
        {
            btnControlStart.Enabled = false;
            btnControlStart.Visible = false;
            btnControlStop.Enabled = true;
            btnControlStop.Visible = true;
        }

        private void btnControlStop_Click(object sender, EventArgs e)
        {
            btnControlStart.Enabled = true;
            btnControlStart.Visible = true;
            btnControlStop.Enabled = false;
            btnControlStop.Visible = false;
        }
    }
}
