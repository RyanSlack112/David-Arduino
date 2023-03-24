using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace David_Arduino
{
    public partial class Login : MaterialForm
    {
        SqlConnection connection;
        public MainForm main;
        MaterialSkinManager skinManager = MaterialSkinManager.Instance; //Material Skin Manager
        public bool isLoggedIn { get; set; }

        public Login()
        {
            InitializeComponent();

            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            connectToDB();
            connection.Open();
        }

        private void connectToDB()
        {
            connection = new SqlConnection();
            connection.ConnectionString = "Data Source = (LocalDB)\\MSSQLLocalDB;"
                + "AttachDbFilename = E:\\Documents\\Visual Studio Projects\\David Arduino\\David Arduino\\DavidArduino.mdf;"
                + "Integrated Security = True";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            main = new MainForm(connection);
            this.Close();
            isLoggedIn = true;
        }
    }
}

