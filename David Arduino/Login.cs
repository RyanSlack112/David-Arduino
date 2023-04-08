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
        private bool isLoggedIn;
        private DBFunctions dbFunctions;

        public Login()
        {
            InitializeComponent();

            /*
             * Material Skin Initialization Code
             */
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            
            //Default Values
            dbFunctions = new DBFunctions(this, connection);
            connection = dbFunctions.ConnectToDB(); //Connects to the Database
        }

        /*
         * Gather Information from Login Screen and Pass into Function to check for Successful Login
         * If successful, Open Main Form and Close Login Screen.
         */
        private void startLogin()
        {
            string username = txtLoginName.Text; //Username
            string password = txtLoginPassword.Text; //Password
            if (dbFunctions.Login(username, password) == true) //Check if Username and Password are correct
            {
                isLoggedIn = true; //Logged in
                main = new MainForm(connection, username); //Create Main Form Object
                Close(); //Close Login Form
            }
            else
            {
                MessageBox.Show("Login Failed", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e) { startLogin(); } //Login Function

        private void btnRegister_Click(object sender, EventArgs e) { dbFunctions.Register(); /*Register Function*/}

        public string GetTxtRegisterPass() { return txtRegisterPass.Text; } //Return Text from Password Field on Register Tab

        public string GetTxtRegisterPassConfirm() { return txtRegisterPassConfirm.Text; } //Return Text from Password Confirm Field on Register Tab

        public string GetTxtRegisterUsername() { return txtRegisterUsername.Text; } //Return Text from Username Field on Register Tab

        public string GetTxtRegisterFirstName() { return txtRegisterFirstName.Text; } //Return Text from First Name Field on Register Tab

        public string GetTxtRegisterLastName() { return txtRegisterLastName.Text; } //Return Text from Last Name Fiel on Register Tab

        public string GetTxtRegisterEmail() { return txtRegisterEmail.Text; } //Return Text from Email Field On Register Tab

        public bool GetIsLoggedIn() { return isLoggedIn; } //Returns the IsLoggedIn Variable value.

        private void tabsLogin_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabsLogin.SelectedIndex == 0)
            {
                this.AcceptButton = btnLogin;
            }
            else if(tabsLogin.SelectedIndex == 1)
            {
                this.AcceptButton = btnRegister;
            }
        }

        private void tabsLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (tabsLogin.SelectedIndex == 0 && e.KeyChar == (char)Keys.Enter)
            {
                //MessageBox.Show("Did you really think I was going to implement this feature.\r\nYou absolute fucking idiot");
                startLogin();
            }
            else if (tabsLogin.SelectedIndex == 1 && e.KeyChar == (char)Keys.Enter)
            {
                dbFunctions.Register();
            }
        }
    }
}

