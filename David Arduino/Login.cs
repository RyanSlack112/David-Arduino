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

            /*
             * Material Skin Initialization Code
             */
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            
            //Default Values
            dbFunctions = new DBFunctions(this, connection);
            connection = dbFunctions.ConnectToDB();
            connection.Open(); //Open Database Connection
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            startLogin(); //Login Function
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

        private void btnRegister_Click(object sender, EventArgs e)
        {
            dbFunctions.Register(); //Register Function
        }

        public string GetTxtRegisterPass() //Return Text from Password Field on Register Tab
        {
            return txtRegisterPass.Text; 
        }

        public string GetTxtRegisterPassConfirm() //Return Text from Password Confirm Field on Register Tab
        {
            return txtRegisterPassConfirm.Text;
        }

        public string GetTxtRegisterUsername() //Return Text from Username Field on Register Tab
        {
            return txtRegisterUsername.Text;
        }

        public string GetTxtRegisterFirstName() //Return Text from First Name Field on Register Tab
        {
            return txtRegisterFirstName.Text;
        }

        public string GetTxtRegisterLastName() //Return Text from Last Name Fiel on Register Tab
        {
            return txtRegisterLastName.Text;
        }

        public string GetTxtRegisterEmail() //Return Text from Email Field On Register Tab
        {
            return txtRegisterEmail.Text;
        }
    }
}

