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
        public bool isMainRunning; //If Main Page is Running
        public bool isHitCounterRunning; //If Hit Counter Is Running
        public bool isControlRunning; //If Control Is Running
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
            connection = con; //DB Connection
            this.username = username; //Signed in Username
            dbFunctions = new DBFunctions(this, connection, username); //Database Functions
            dFunc = new Data_Functions(this, dbFunctions, username); //Data Functions
            txtCurrentMass.Text = dFunc.GetMass().ToString() + " KGs"; //Sets Current Mass Text Box
            PopulateGraphHitCounterComboBox();
        }

        public MaterialLabel GetMainLabel() { return lblOutput; } //Returns the Label on the Main Page

        public string GetOutputLabelText() { return lblOutput.Text; } //Output Label Getter

        public void SetOutputLabel(string outputText) { lblOutput.Text = outputText; } //Output Label Setter

        public MaterialComboBox GetMainComboBox() { return cmbUnit; } //Returns the Combo Box from the Main Page

        public string GetComboUnitText() { return cmbUnit.SelectedItem.ToString(); } //Returns the value of the combo box on the page

        public string GetGraphMainDate() { return dtpGraphMainDate.Text; } //Returns the Date Selected in the Graph Main View

        public string GetGraphControlDate() { return dtpGraphControlDate.Text; } //Returns the Date Selected in the Graph Control View

        public MaterialComboBox GetPortsComboBox() { return cmbPorts; } //Returns the Combo box for selecting Port for Arduino

        public void SetPortsComboBox(string portName) { cmbPorts.Items.Add(portName); } //Add the Port Names to the Combo Box

        public DataGridView GetStatsMainDGV() { return dgvStatsMain; } //Returns the DataGridView from the Main Tab of the Stats Page

        public DataGridView GetStatsControlDGV() { return dgvStatsControl; } //Returns the DataGridView from the Control Tab of the Stats Page

        public DataGridView GetStatsHitCounterDGV() { return dgvStatsHitCounter; } //Returns the DataGridView from the Hit Counter Tab of the Stats Page 

        public DateTime GetStatsMainDate() { return dtpStatsMainDate.Value; }

        public void SetStatsMainDataSource(DataTable hitData) { dgvStatsMain.DataSource = hitData; }

        public void SetStatsHitCounterDataSource(DataTable hitCounterData) { dgvStatsHitCounter.DataSource = hitCounterData; }

        public void SetStatsControlDataSource(DataTable controlData) { dgvStatsControl.DataSource = controlData; }

        public MaterialComboBox GetGraphHitCounterSessionsComboBox() { return cmbGraphHitCounterSessions; }

        public string GetPortComboBoxText()  //Returns the value of the selected port in the Combo Box
        {
            if (cmbPorts.SelectedItem == null)
            {
                MessageBox.Show("There is no Device Connected.\r\nPlease Connect a Device before continuing.", "Device Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
            }
            else
            {
                return cmbPorts.SelectedItem.ToString();
            }
        }

        public void SetCurrentPortText(string portName) { txtCurrentPort.Text = portName; } //Sets the current Port to the Text Box

        /*
         * Start Running the Program and initiate the Thread for the background
         */
        private void StartRunning()
        {
            Task readArduinoThread = new Task(() => //Create a new Thread to run the loop
            {
                while (isMainRunning) //Continuously Read the Data from the Arduino
                {
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
                isMainRunning = true;
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

            isMainRunning = false; //Stop the Loop and stop the reading of the data from the Arduino

            dFunc.ClosePort(); //Closes port to the Arduino
            dFunc.AddHitData(); //Add HitData from the List To The Database

            CheckStatsDialog(tabMain); //Show Dialog asking to show Statistics for Main Page
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

        private void cbHitTimer_CheckedChanged(object sender, EventArgs e)
        {
            switch (cbHitTimer.Checked)
            {
                case true: //Enables Controls for setting and using a Timer
                    lblHitTimer.Enabled = true;
                    txtHitTimer.Enabled = true;
                    btnHitTimer.Enabled = true;
                    break;
                case false: //Disables Controls for setting and using a Timer
                    lblHitTimer.Enabled = false;
                    txtHitTimer.Enabled = false;
                    btnHitTimer.Enabled = false;
                    break;
                default:
                    break;
            }
        }

        private void btnHitTimer_Click(object sender, EventArgs e)
        {

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

        private void CheckStatsDialog(TabPage currentTab)
        {
            TabPage switchTab = null; //Variable to store the tab within Statistics to switch to.
            
            switch (currentTab.Name) //Tab that has just finished it's Function
            {
                case "tabMain": //Main Page
                    switchTab = tabStatsMain;
                    break;
                case "tabHitCounter": //Hit Counter Page
                    switchTab = tabStatsHitCounter;
                    break;
                case "tabControl": //Control Page
                    switchTab = tabStatsControl;
                    break;
                default:
                    break;
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

        private void btnGraphMainGenerateGraph_Click(object sender, EventArgs e)
        {
            if (hitDataSeries != null) //Checks if Graph is already populated and clears then repopulates
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
            if (hitDataSeries != null)
            {
                hitDataSeries.Points.Clear(); //Clears the Graph of any points
            }
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

        private void btnStatsHitCounterClose_Click(object sender, EventArgs e)
        {
            connection.Close(); //Closes Database Connections
            Close(); //Closes Program
        }

        private void btnStatsControlClose_Click(object sender, EventArgs e)
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
            GraphFunctions.ChangeGraphColours(crtGraphMain);
            GraphFunctions.ChangeGraphColours(crtGraphControl);
        }

        private void btnDark_Click(object sender, EventArgs e)
        {
            skinManager.Theme = MaterialSkinManager.Themes.DARK; //Changes Material Skin Theme to Dark

            /*
             * Change Graph Text Colour
             */
            GraphFunctions.ChangeGraphColours(crtGraphMain);
            GraphFunctions.ChangeGraphColours(crtGraphControl);
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

        private void btnDBCheck_Click(object sender, EventArgs e) //Check Database Connection
        {
            if (connection.State == ConnectionState.Open)
            {
                MessageBox.Show("The Database is connected", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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

        private void btnOpenPort_Click(object sender, EventArgs e)
        {
            try
            {
                string portName = GetPortComboBoxText(); //Get Port Name from Combo Box
                dFunc.SetPort(dFunc.CreatePort(portName)); //Set the name of the Port and Create The Port and Connect
                SetCurrentPortText(portName); //Set the Current Port Name on Settings Page
                if (dFunc.port.PortName == portName) //Successful Port Creation
                {
                    MessageBox.Show("Connection to port: " + portName + " was successful", "Connection Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (ArgumentException)
            {
                //No Device Connected but Message Box already spawns.
            }
        }

        /*
         * Changes the Title Text of the program depending on the selected Tab
         */
        private void Tabs_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabs.SelectedTab.Name)
            {
                case "tabMain": //Main Page Name
                    this.Text = "Main Page";
                    break;
                case "tabHitCounter": //Hit Counter Page Name
                    this.Text = "Hit Counter";
                    break;
                case "tabControl": //Control Page Name
                    this.Text = "Control";
                    break;
                case "tabGraph": //Graph View Page Name
                    this.Text = "Graph View";
                    break;
                case "tabStatistics": //Statistics Page Name
                    this.Text = "Statistics";
                    break;
                case "tabSettings": //Settings Page Name
                    this.Text = "Settings";
                    break;
                default:
                    break;
            }
        }

        /*
         * Map Hit Data Points to the Graph
         */
        public void MapHitDataSeries(List<HitDataPoint> hitDataPoints)
        {
            hitDataSeries = crtGraphMain.Series["HitData"]; //Object that Data Points are added to.
            switch (cmbGraphMainUnits.SelectedItem.ToString())
            {
                case "Force":
                    {
                        /*
                        * Set Axis Title and Text Colour according to Current Theme.
                        */
                        crtGraphMain.ChartAreas[0].AxisX.Title = "Time";
                        crtGraphMain.ChartAreas[0].AxisY.Title = "Force [N]";
                        GraphFunctions.ChangeGraphColours(crtGraphMain);

                        /*
                        * Loop through List of Data Points and add them to the Points of the Graph.
                        */
                        foreach (HitDataPoint point in hitDataPoints)
                        {
                            hitDataSeries.Points.AddXY(point.GetTime().ToString(), point.GetForce());
                        }
                        break;
                    }
                case "Acceleration":
                    {
                        /*
                         * Set Axis Title and Text Colour according to Current Theme.
                         */
                        crtGraphMain.ChartAreas[0].AxisX.Title = "Time";
                        crtGraphMain.ChartAreas[0].AxisY.Title = "Acceleration (m/s" + '\u00B2' + ")";
                        GraphFunctions.ChangeGraphColours(crtGraphMain);

                        /*
                         * Loop through List of Data Points and add them to the Points of the Graph.
                         */
                        foreach (HitDataPoint point in hitDataPoints)
                        {
                            hitDataSeries.Points.AddXY(point.GetTime().ToString(), point.GetAccel());
                        }
                        break;
                    }
                default:
                    break;
            }
        }

        /*
         * Map Control Data Points to the Graph
         */
        public void MapControlDataSeries(List<ControlDataPoint> controlDataPoints)
        {
            controlDataSeries = crtGraphControl.Series["ControlData"];
            switch (cmbGraphControlUnits.SelectedItem.ToString())
            {
                case "Force":
                    {
                        /*
                        * Set Axis Title and Text Colour according to Current Theme.
                        */
                        crtGraphControl.ChartAreas[0].AxisX.Title = "Time";
                        crtGraphControl.ChartAreas[0].AxisY.Title = "Force [N]";
                        GraphFunctions.ChangeGraphColours(crtGraphControl);

                        /*
                        * Loop through List of Data Points and add them to the Points of the Graph.
                        */
                        foreach (ControlDataPoint point in controlDataPoints)
                        {
                            //controlDataSeries.Points.AddXY(point.GetTime().ToString(), point.GetForce());
                        }
                        break;
                    }
                case "Acceleration":
                    {
                        /*
                        * Set Axis Title and Text Colour according to Current Theme.
                        */
                        crtGraphControl.ChartAreas[0].AxisX.Title = "Time";
                        crtGraphControl.ChartAreas[0].AxisY.Title = "Acceleration (m/s" + '\u00B2' + ")";
                        GraphFunctions.ChangeGraphColours(crtGraphControl);

                        foreach (ControlDataPoint point in controlDataPoints)
                        {
                            //controlDataSeries.Points.AddXY(point.GetTime().ToString(), point.GetAccel());
                        }
                        break;
                    }
                default:
                    break;
            }
        }

        private void btnStatsMainGenerate_Click(object sender, EventArgs e)
        {
            if(dgvStatsMain != null)
            {
                dgvStatsMain.DataSource = null;
            }
            dbFunctions.GenerateMainStats();
        }

        private void btnStatsMainClear_Click(object sender, EventArgs e)
        {
            dgvStatsMain.DataSource = null;
        }

        private void btnStatsHitCounterGenerate_Click(object sender, EventArgs e)
        {
            if(dgvStatsHitCounter != null)
            {
                dgvStatsHitCounter.DataSource = null;
            }
            dbFunctions.GenerateHitCounterStats();
        }

        private void btnStatsHitCounterClear_Click(object sender, EventArgs e)
        {
            dgvStatsHitCounter.DataSource = null;
        }

        private void btnStatsControlGenerate_Click(object sender, EventArgs e)
        {
            if(dgvStatsControl != null)
            {
                dgvStatsControl.DataSource = null;
            }
            dbFunctions.GenerateControlStats();
        }

        private void btnStatsControlClear_Click(object sender, EventArgs e)
        {
            dgvStatsControl.DataSource = null;
        }

        private async void PopulateGraphHitCounterComboBox()
        {
            string day = dtpGraphHitCounterDate.Text;
            if (string.IsNullOrEmpty(day))
            {
                // set default value to today
                day = DateTime.Now.ToString("yyyy-MM-dd");
            }
            List<HitCounterSessionData> sessions = await Task.Run(() => dbFunctions.GetHitCounterSessions(username, day));
            List<string> sessionTexts = Data_Functions.GetSessionList(sessions);
            cmbGraphHitCounterSessions.Items.Clear();
            cmbGraphHitCounterSessions.Items.AddRange(sessionTexts.ToArray());
            if(cmbGraphHitCounterSessions != null)
            {
                cmbGraphHitCounterSessions.SelectedIndex = 0;
            }
        }

        private void dtpGraphHitCounterDate_ValueChanged(object sender, EventArgs e)
        {
            PopulateGraphHitCounterComboBox();
        }

    } 
}