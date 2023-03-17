using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        public MainForm()
        {
            InitializeComponent();
            dFunc = new Data_Functions();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        MaterialSkinManager skinManager = MaterialSkinManager.Instance;

        private void btnClose_Click(object sender, EventArgs e)
        {
            if(dFunc.port.IsOpen)
            {
                dFunc.port.Close(); 
            }
            Close();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            btnStart.Visible = false;
            btnStop.Enabled = true;
            btnStop.Visible = true;
            dFunc.openPort();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            btnStop.Enabled = false;
            btnStop.Visible = false;
            btnStart.Enabled = true;
            btnStart.Visible = true;
            dFunc.closePort();
        }

        private void btnSettingsClose_Click(object sender, EventArgs e)
        {
            if (dFunc.port.IsOpen)
            {
                dFunc.port.Close();
            }
            Close();
        }

        private void btnGraphClose_Click(object sender, EventArgs e)
        {
            if (dFunc.port.IsOpen)
            {
                dFunc.port.Close();
            }
            Close();
        }

        private void btnStatsClose_Click(object sender, EventArgs e)
        {
            if (dFunc.port.IsOpen)
            {
                dFunc.port.Close();
            }
            Close();
        }

        private void btnLight_Click(object sender, EventArgs e)
        {
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
        }

        private void btnDark_Click(object sender, EventArgs e)
        {
            skinManager.Theme = MaterialSkinManager.Themes.DARK;
        }

        private void Tabs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabs.SelectedTab == tabMain)
            {
                this.Text = "Main Menu";
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

        private void btnCheck_Click(object sender, EventArgs e)
        {
            dFunc.openPort();
            if(dFunc.port.IsOpen)
            {
                MessageBox.Show("The Arduino is connected");
                dFunc.port.Close();
            }
            else
            {
                MessageBox.Show("The Arduino is not connected");
            }
        }
    }
}
