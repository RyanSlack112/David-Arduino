using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace David_Arduino
{
    internal class DBFunctions
    {
        private Login login;
        private MainForm mainForm;
        SqlConnection connection;
        string username;

        public DBFunctions(Login _login, SqlConnection _connection)
        {
            login = _login;
            connection = _connection;
        }

        public DBFunctions(MainForm _mainForm, SqlConnection _connection, string username)
        {
            mainForm = _mainForm;
            this.username = username;
            this.connection = _connection;
        }

        public SqlConnection ConnectToDB()
        {
            connection = new SqlConnection();
            connection.ConnectionString = "Data Source = (LocalDB)\\MSSQLLocalDB;"
                + "AttachDbFilename = E:\\Documents\\Visual Studio Projects\\David Arduino\\David Arduino\\DavidArduino.mdf;"
                + "Integrated Security = True";

            return connection;
        }

        public void Register()
        {
            if (login.GetTxtRegisterPass() == login.GetTxtRegisterPassConfirm())
            {
                using (SqlCommand cmd = new SqlCommand("INSERT INTO Users (username, firstName, lastName, email, password) VALUES (@username, @firstName, @lastName, @email, @password)", connection))
                {
                    SqlParameter uNameParam = new SqlParameter("@username", SqlDbType.VarChar, 50);
                    uNameParam.Value = login.GetTxtRegisterUsername();
                    cmd.Parameters.Add(uNameParam);

                    SqlParameter fNameParam = new SqlParameter("@firstName", SqlDbType.VarChar, 50);
                    fNameParam.Value = login.GetTxtRegisterFirstName();
                    cmd.Parameters.Add(fNameParam);

                    SqlParameter lNameParam = new SqlParameter("@lastName", SqlDbType.VarChar, 50);
                    lNameParam.Value = login.GetTxtRegisterLastName();
                    cmd.Parameters.Add(lNameParam);

                    SqlParameter emailParam = new SqlParameter("@email", SqlDbType.VarChar, 50);
                    emailParam.Value = login.GetTxtRegisterEmail();
                    cmd.Parameters.Add(emailParam);

                    SqlParameter passwordParam = new SqlParameter("@password", SqlDbType.VarChar, 50);
                    passwordParam.Value = login.GetTxtRegisterPass();
                    cmd.Parameters.Add(passwordParam);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("You have successfully registered your account", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Your Password Fields Don't Match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool Login(string user, string pass)
        {
            using (SqlCommand sqlCommand = new SqlCommand("SELECT username, password FROM Users WHERE username = @username", connection))
            {
                SqlParameter param = new SqlParameter("@username", SqlDbType.VarChar, 50);
                param.Value = user;
                sqlCommand.Parameters.Add(param);

                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string username = reader.GetString(0);
                        string password = reader.GetString(1);

                        if (username == user && password == pass)
                        {
                            return true;
                        }
                    }
                }
                return false;
            }
        }

        public void AddToHitData(HitData hitData)
        {
            using (SqlCommand cmd = new SqlCommand("INSERT INTO HitData(username, day, time, force, acceleration) VALUES (@username, @day, @time, @force, @acceleration)", connection))
            {
                SqlParameter userParam = new SqlParameter("@username", SqlDbType.VarChar, 50);
                userParam.Value = hitData.getUsername();
                cmd.Parameters.Add(userParam);

                SqlParameter dateParam = new SqlParameter("@day", SqlDbType.Date);
                dateParam.Value = hitData.getDate();
                cmd.Parameters.Add(dateParam);

                SqlParameter timeParam = new SqlParameter("@time", SqlDbType.Time, 7);
                TimeSpan time = TimeSpan.ParseExact(hitData.getTime().Substring(0, 8), "hh\\:mm\\:ss", null);
                int millis = int.Parse(hitData.getTime().Substring(9));
                time.Add(TimeSpan.FromMilliseconds(millis));
                timeParam.Value = time;
                cmd.Parameters.Add(timeParam);

                SqlParameter forceParam = new SqlParameter("@force", SqlDbType.Float);
                forceParam.Value = hitData.getForce();
                cmd.Parameters.Add(forceParam);

                SqlParameter accelParam = new SqlParameter("@acceleration", SqlDbType.Float);
                accelParam.Value = hitData.getAcceleration();
                cmd.Parameters.Add(accelParam);

                cmd.ExecuteNonQuery();
            }
        }
    }
}
