using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
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
        private DBFunctions dbFunctions;

        public Login()
        {
            InitializeComponent();

            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            dbFunctions = new DBFunctions(this, connection);
            connection = dbFunctions.ConnectToDB();
            connection.Open();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            startLogin();
        }

        private void startLogin()
        {
            string username = txtLoginName.Text;
            string password = txtLoginPassword.Text;
            if (dbFunctions.Login(username, password) == true)
            {
                isLoggedIn = true;
            }
            else
            {
                MessageBox.Show("Login Failed", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            main = new MainForm(connection);
            Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            dbFunctions.Register();
        }

        public string GetTxtRegisterPass()
        {
            return txtRegisterPass.Text; 
        }

        public string GetTxtRegisterPassConfirm()
        {
            return txtRegisterPassConfirm.Text;
        }

        public string GetTxtRegisterUsername()
        {
            return txtRegisterUsername.Text;
        }

        public string GetTxtRegisterFirstName()
        {
            return txtRegisterFirstName.Text;
        }

        public string GetTxtRegisterLastName()
        {
            return txtRegisterLastName.Text;
        }

        public string GetTxtRegisterEmail()
        {
            return txtRegisterEmail.Text;
        }
    }
}

