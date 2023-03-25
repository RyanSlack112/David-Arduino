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

namespace David_Arduino
{
    public partial class MainForm : MaterialForm
    {
        Data_Functions dFunc; //Data Function Object
        MaterialSkinManager skinManager = MaterialSkinManager.Instance; //Material Skin Manager
        public bool isRunning; //If Program is Running
        SqlConnection connection;
        Task readArduinoThread;
        CancellationTokenSource cts = new CancellationTokenSource();

        public MainForm(SqlConnection con)
        {
            InitializeComponent();

            /*
             * Material Skin Initialization Code
             */
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            dFunc = new Data_Functions(this);
            txtCurrentMass.Text = dFunc.getMass().ToString() + " KGs";
            connection = con;
            //connectToDB();
            //connection.Open();
        }

        private void connectToDB()
        {
            connection = new SqlConnection();
            connection.ConnectionString = "Data Source = (LocalDB)\\MSSQLLocalDB;"
                + "AttachDbFilename = E:\\Documents\\Visual Studio Projects\\David Arduino\\David Arduino\\DavidArduino.mdf;"
                + "Integrated Security = True";
        }

        private void checkDFunc() //Checks if Data Function Object exists and creates it if it doesn't
        {
            if (dFunc == null)
            {
                dFunc = new Data_Functions(this); //Arduino Data and Connection Object
                Console.WriteLine("Created");
            }
        }

        public MaterialLabel getMainLabel()
        {
            return lblOutput;
        }

        public string getOutputLabelText() //Output Label Getter
        {
            return lblOutput.Text;
        }

        public void setOutputLabel(string outputText) //Output Label Setter
        {
            lblOutput.Text = outputText;
        }

        public MaterialComboBox getMainComboBox()
        {
            return cmbUnit;
        }

        public string getComboUnitText() //Returns the value of the combo box on the page
        {
            return cmbUnit.SelectedItem.ToString();
        }

        /*
         * Start Running the Program and initiate the Thread for the background
         */
        private void startRunning()
        {
            checkDFunc(); //Check whether Data Function Object exists
            readArduinoThread = new Task(() => //Create a new Thread to run the loop
            {
                while (isRunning) //Continuously Read the Data from the Arduino
                {
                    //dFunc.TestLabel();
                    dFunc.getArduinoOutput();
                }
            }); 
            readArduinoThread.Start(); //Start the Thread
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                checkDFunc();
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
            connection.Close();
            Close(); //Closes Program
        }

        private void btnHitCounterClose_Click(object sender, EventArgs e)
        {
            connection.Close();
            Close(); //Closes Program
        }

        private void btnControlClose_Click(object sender, EventArgs e)
        {
            connection.Close();
            Close(); //Closes Program
        }

        private void btnGraphClose_Click(object sender, EventArgs e)
        {
            connection.Close();
            Close(); //Closes Program
        }

        private void btnStatsClose_Click(object sender, EventArgs e)
        {
            connection.Close();
            Close(); //Closes Program
        }

        private void btnSettingsClose_Click(object sender, EventArgs e)
        {
            connection.Close();
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
                checkDFunc(); //Check whether Data Function Object exists
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
                checkDFunc(); //Check whether Data Function Object exists
                float newMass = float.Parse(txtMassInput.Text); //Take the input from the Mass Input Textbox
                dFunc.setMass(newMass); //Set the new Mass
                txtCurrentMass.Text = dFunc.getMass().ToString() + " KGs";
                MessageBox.Show("Mass Changed Successfully to " + newMass.ToString() + " KGs", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information); //Display a MessageBox indicating the successful changing of the Mass
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
            checkDFunc(); //Check whether Data Function Object exists

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
            checkDFunc(); //Check whether Data Function Object exists

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

        private void btnDBCheck_Click(object sender, EventArgs e)
        {
            if(connection.State == ConnectionState.Open)
            {
                MessageBox.Show("The Database is connected", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
