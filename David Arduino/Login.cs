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

        private bool userLogin(string user, string pass)
        {
            SqlCommand sqlCommand = new SqlCommand("SELECT username, password FROM Users WHERE username = @username", connection);
            SqlParameter param = new SqlParameter("@username", SqlDbType.VarChar, 50);
            param.Value = user;
            sqlCommand.Parameters.Add(param);

            SqlDataReader reader = sqlCommand.ExecuteReader();

            if (reader.Read())
            {
                string username = reader.GetString(0);
                string password = reader.GetString(1);

                if (username == user && password == pass) 
                {
                    return true;    
                }
            }
            return false;
        }

        private void userRegister()
        {
            if(txtRegisterPass.Text == txtRegisterPassConfirm.Text)
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Users (username, firstName, lastName, email, password) VALUES (@username, @firstName, @lastName, @email, @password)", connection);
                SqlParameter uNameParam = new SqlParameter("@username", SqlDbType.VarChar, 50);
                uNameParam.Value = txtRegisterUsername.Text;
                cmd.Parameters.Add(uNameParam);

                SqlParameter fNameParam = new SqlParameter("@firstName", SqlDbType.VarChar, 50);
                fNameParam.Value = txtRegisterFirstName.Text;
                cmd.Parameters.Add(fNameParam);

                SqlParameter lNameParam = new SqlParameter("@lastName", SqlDbType.VarChar, 50);
                lNameParam.Value = txtRegisterLastName.Text;
                cmd.Parameters.Add(lNameParam);

                SqlParameter emailParam = new SqlParameter("@email", SqlDbType.VarChar, 50);
                emailParam.Value = txtRegisterEmail.Text;
                cmd.Parameters.Add(emailParam);

                SqlParameter passwordParam = new SqlParameter("@password", SqlDbType.VarChar, 50);
                passwordParam.Value = txtRegisterPass.Text;
                cmd.Parameters.Add(passwordParam);

                cmd.ExecuteNonQuery();

                MessageBox.Show("You have successfully registered your account", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Your Password Fields Don't Match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            startLogin();
        }

        private void startLogin()
        {
            string username = txtLoginName.Text;
            string password = txtLoginPassword.Text;
            if (userLogin(username, password) == true)
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
            userRegister();
        }
    }
}

