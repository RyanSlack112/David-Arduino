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
using System.Data.SqlClient;
using System.Threading;
using System.Windows.Forms.DataVisualization.Charting;

namespace David_Arduino
{
    public partial class MainForm : MaterialForm
    {
        Data_Functions dFunc; //Data Function Object
        DBFunctions dbFunctions; //Database Functions Object
        MaterialSkinManager skinManager = MaterialSkinManager.Instance; //Material Skin Manager
        public bool isRunning; //If Program is Running
        SqlConnection connection; //Database Connection
        string username; //Signed In Username
        Series hitDataSeries; //Points for Main Graph
        Series controlDataSeries; //Points for Control Graph

        public MainForm(SqlConnection con, string username)
        {
            InitializeComponent();

            /*
             * Material Skin Initialization Code
             */
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            
            //Default Values
            connection = con;
            this.username = username;
            dbFunctions = new DBFunctions(this, connection, username);
            dFunc = new Data_Functions(this, dbFunctions, username);
            txtCurrentMass.Text = dFunc.GetMass().ToString() + " KGs";

            /*crtGraphMain.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            crtGraphMain.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            crtGraphMain.ChartAreas[0].AxisX.MinorGrid.Enabled = false;
            crtGraphMain.ChartAreas[0].AxisY.MinorGrid.Enabled = false;*/
        }

        public MaterialLabel GetMainLabel() //Returns the Label on the Main Page
        {
            return lblOutput;
        }

        public string GetOutputLabelText() //Output Label Getter
        {
            return lblOutput.Text;
        }

        public void SetOutputLabel(string outputText) //Output Label Setter
        {
            lblOutput.Text = outputText;
        }

        public MaterialComboBox GetMainComboBox() //Returns the Combo Box from the Main Page
        {
            return cmbUnit;
        }

        public string GetComboUnitText() //Returns the value of the combo box on the page
        {
            return cmbUnit.SelectedItem.ToString();
        }

        public string GetGraphMainDate() //Returns the Date Selected in the Graph Main View
        {
            return dtpGraphMainDate.Text;
        }

        public string GetGraphControlDate() //Returns the Date Selected in the Graph Control View
        {
            return dtpGraphControlDate.Text;
        }

        /*
         * Start Running the Program and initiate the Thread for the background
         */
        private void StartRunning()
        {
            Task readArduinoThread = new Task(() => //Create a new Thread to run the loop
            {
                while (isRunning) //Continuously Read the Data from the Arduino
                {
                    //dFunc.TestLabel();
                    dFunc.GetArduinoOutput(username);
                }
            }); 
            readArduinoThread.Start(); //Start the Thread
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                dFunc.OpenPort(); //Opens port to Arduino and connects

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
                StartRunning(); //Start reading from the Arduino
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

            dFunc.ClosePort(); //Closes port to the Arduino
            dFunc.AddHitData();

            CheckStatsDialog(tabMain);
        }

        private void CheckStatsDialog(TabPage currentTab)
        {
            TabPage switchTab = null; //Variable to store the tab within Statistics to switch to.
            if(currentTab == tabMain) //switchTab is Main Page
            {
                switchTab = tabStatsMain;
            }
            else if(currentTab == tabHitCounter) //switchTab is Hit Counter
            {
                switchTab = tabStatsHitCounter;
            }
            else if(currentTab == tabControl) //switchTab is Control
            {
                switchTab = tabStatsControl;
            }

            /*
             * Show Dialog on whether to switch to the tab after the function is finished.
             */
            DialogResult dialog = MessageBox.Show("Would you like to view the Statistics of the Last Session?", "Statistics", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                tabs.SelectedTab = tabStatistics;
                tabsStatistics.SelectedTab = switchTab;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            connection.Close(); //Closes Database Connections
            Close(); //Closes Program
        }

        private void btnHitCounterClose_Click(object sender, EventArgs e)
        {
            connection.Close(); //Closes Database Connections
            Close(); //Closes Program
        }

        private void btnControlClose_Click(object sender, EventArgs e)
        {
            connection.Close(); //Closes Database Connections
            Close(); //Closes Program
        }

        private void btnGraphClose_Click(object sender, EventArgs e)
        {
            connection.Close(); //Closes Database Connections
            Close(); //Closes Program
        }

        private void btnStatsClose_Click(object sender, EventArgs e)
        {
            connection.Close(); //Closes Database Connections
            Close(); //Closes Program
        }

        private void btnSettingsClose_Click(object sender, EventArgs e)
        {
            connection.Close(); //Closes Database Connections
            Close(); //Closes Program
        }

        private void btnLight_Click(object sender, EventArgs e)
        {
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT; //Changes Material Skin Theme to Light
            
            /*
             * Change Graph Text Colour
             */
            crtGraphMain.ChartAreas[0].AxisX.TitleForeColor = Color.Black;
            crtGraphMain.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.Black;
            crtGraphMain.ChartAreas[0].AxisY.TitleForeColor = Color.Black;
            crtGraphMain.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.Black;
        }

        private void btnDark_Click(object sender, EventArgs e)
        {
            skinManager.Theme = MaterialSkinManager.Themes.DARK; //Changes Material Skin Theme to Dark

            /*
             * Change Graph Text Colour
             */
            crtGraphMain.ChartAreas[0].AxisX.TitleForeColor = Color.White;
            crtGraphMain.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.White;
            crtGraphMain.ChartAreas[0].AxisY.TitleForeColor = Color.White;
            crtGraphMain.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.White;
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
                dFunc.OpenPort(); //Opens Arduino Port
                MessageBox.Show("The Arduino is connected", "Connection Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dFunc.ClosePort(); //Closes Arduino Port
            }
            catch (IOException) //Exception if Arduino is not connected
            {
                MessageBox.Show("The Arduino is not connected", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            SetOutputLabel(GetComboUnitText());
        }

        private void btnChangeMass_Click(object sender, EventArgs e)
        {
            try
            {
                float newMass = float.Parse(txtMassInput.Text); //Take the input from the Mass Input Textbox
                dFunc.SetMass(newMass); //Set the new Mass
                txtCurrentMass.Text = dFunc.GetMass().ToString() + " KGs";
                MessageBox.Show("Mass Changed Successfully to " + newMass.ToString() + " KGs", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information); //Display a MessageBox indicating the successful changing of the Mass
            }
            catch (FormatException) //Invalid Input
            {
                MessageBox.Show("Please input a number in Kilograms", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTestMass_Click(object sender, EventArgs e)
        {
            SetOutputLabel(dFunc.GetMass().ToString());
        }

        private void btnHitCounterStart_Click(object sender, EventArgs e)
        {
            /*
             * Button Visibilty
             */
            btnHitCounterStart.Enabled = false;
            btnHitCounterStart.Visible = false;
            btnHitCounterStop.Enabled = true;
            btnHitCounterStop.Visible = true;
        }

        private void btnHitCounterStop_Click(object sender, EventArgs e)
        {

            /*
             * Button Visibility
             */
            btnHitCounterStart.Enabled = true;
            btnHitCounterStart.Visible = true;
            btnHitCounterStop.Enabled = false;
            btnHitCounterStop.Visible = false;

            CheckStatsDialog(tabHitCounter); //Checks current tab and switches to the Stats tab if Dialog is Yes
        }

        private void btnControlStart_Click(object sender, EventArgs e)
        {
            /*
             * Button Visibility
             */
            btnControlStart.Enabled = false;
            btnControlStart.Visible = false;
            btnControlStop.Enabled = true;
            btnControlStop.Visible = true;
        }

        private void btnControlStop_Click(object sender, EventArgs e)
        {

            /*
             * Button Visibility
             */
            btnControlStart.Enabled = true;
            btnControlStart.Visible = true;
            btnControlStop.Enabled = false;
            btnControlStop.Visible = false;

            CheckStatsDialog(tabControl); //Checks current tab and switches to the Stats tab if Dialog is Yes
        }

        private void cbHitTimer_CheckedChanged(object sender, EventArgs e)
        {
            //Enables Controls for setting and using a Timer
            if(cbHitTimer.Checked)
            {
                lblHitTimer.Enabled = true;
                txtHitTimer.Enabled = true;
                btnHitTimer.Enabled = true;
            }
            else if(!cbHitTimer.Checked)
            {
                lblHitTimer.Enabled = false;
                txtHitTimer.Enabled = false;
                btnHitTimer.Enabled = false;
            }
        }

        private void btnHitTimer_Click(object sender, EventArgs e)
        {

        }

        private void btnDBCheck_Click(object sender, EventArgs e) //Check Database Connection
        {
            if(connection.State == ConnectionState.Open)
            {
                MessageBox.Show("The Database is connected", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnGraphMainGenerateGraph_Click(object sender, EventArgs e)
        {
            if(hitDataSeries != null) //Checks if Graph is already populated and clears then repopulates
            {
                hitDataSeries.Points.Clear();
                dFunc.GenerateMainGraph();
            }
            else //If it's clear, just populates it.
            {
                dFunc.GenerateMainGraph();
            }
            
        }

        private void btnGraphMainClearGraph_Click(object sender, EventArgs e)
        {
            hitDataSeries.Points.Clear(); //Clears the Graph of any points
        }

        private void btnGraphControlGenerateGraph_Click(object sender, EventArgs e)
        {
            if (controlDataSeries != null) //Checks if Graph is already populated and clears then repopulates
            {
                controlDataSeries.Points.Clear();
                dFunc.GenerateControlGraph();
            }
            else //If it's clear, just populates it.
            {
                dFunc.GenerateControlGraph();
            }
        }

        private void btnGraphControlClearGraph_Click(object sender, EventArgs e)
        {
            controlDataSeries.Points.Clear();
        }

        /*
         * Map Data Points to the graph
         */
        public void MapHitDataSeries(List<HitDataPoint> hitDataPoints)
        {
            hitDataSeries = crtGraphMain.Series["HitData"]; //Object that Data Points are added to.

            if(cmbGraphMainUnits.SelectedItem.ToString() == "Force") //Force is selected in Combo Box
            {
                /*
                 * Set Axis Title and Text Colour according to Current Theme.
                 */
                crtGraphMain.ChartAreas[0].AxisX.Title = "Time";
                crtGraphMain.ChartAreas[0].AxisY.Title = "Force [N]";
                if (skinManager.Theme == MaterialSkinManager.Themes.DARK)
                {
                    crtGraphMain.ChartAreas[0].AxisX.TitleForeColor = Color.White;
                    crtGraphMain.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.White;
                    crtGraphMain.ChartAreas[0].AxisY.TitleForeColor = Color.White;
                    crtGraphMain.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.White;
                }
                else if(skinManager.Theme == MaterialSkinManager.Themes.LIGHT)
                {
                    crtGraphMain.ChartAreas[0].AxisX.TitleForeColor = Color.Black;
                    crtGraphMain.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.Black;
                    crtGraphMain.ChartAreas[0].AxisY.TitleForeColor = Color.Black;
                    crtGraphMain.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.Black;
                }

                /*
                 * Loop through List of Data Points and add them to the Points of the Graph.
                 */
                foreach (HitDataPoint point in hitDataPoints)
                {
                    hitDataSeries.Points.AddXY(point.GetTime().ToString(), point.GetForce());
                }
            }
            else if(cmbGraphMainUnits.SelectedItem.ToString() == "Acceleration")
            {

                /*
                 * Set Axis Title and Text Colour according to Current Theme.
                 */
                crtGraphMain.ChartAreas[0].AxisX.Title = "Time";
                crtGraphMain.ChartAreas[0].AxisY.Title = "Acceleration (m/s^2)";
                if (skinManager.Theme == MaterialSkinManager.Themes.DARK)
                {
                    crtGraphMain.ChartAreas[0].AxisX.TitleForeColor = Color.White;
                    crtGraphMain.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.White;
                    crtGraphMain.ChartAreas[0].AxisY.TitleForeColor = Color.White;
                    crtGraphMain.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.White;
                }
                else if (skinManager.Theme == MaterialSkinManager.Themes.LIGHT)
                {
                    crtGraphMain.ChartAreas[0].AxisX.TitleForeColor = Color.Black;
                    crtGraphMain.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.Black;
                    crtGraphMain.ChartAreas[0].AxisY.TitleForeColor = Color.Black;
                    crtGraphMain.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.Black;
                }

                /*
                 * Loop through List of Data Points and add them to the Points of the Graph.
                 */
                foreach (HitDataPoint point in hitDataPoints)
                {
                    hitDataSeries.Points.AddXY(point.GetTime().ToString(), point.GetAccel());
                }
            }
        }

        public void MapControlDataSeries(List<ControlDataPoint> controlDataPoints)
        {
            crtGraphControl.ChartAreas[0].AxisX.Title = "Time";
            crtGraphControl.ChartAreas[0].AxisY.Title = "Acceleration (m/s^2)";
            if (skinManager.Theme == MaterialSkinManager.Themes.DARK)
            {
                crtGraphControl.ChartAreas[0].AxisX.TitleForeColor = Color.White;
                crtGraphControl.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.White;
                crtGraphControl.ChartAreas[0].AxisY.TitleForeColor = Color.White;
                crtGraphControl.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.White;
            }
            else if (skinManager.Theme == MaterialSkinManager.Themes.LIGHT)
            {
                crtGraphControl.ChartAreas[0].AxisX.TitleForeColor = Color.Black;
                crtGraphControl.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.Black;
                crtGraphControl.ChartAreas[0].AxisY.TitleForeColor = Color.Black;
                crtGraphControl.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.Black;
            }
        }
    }
}