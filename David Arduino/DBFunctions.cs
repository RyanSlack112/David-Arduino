using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace David_Arduino
{
    internal class DBFunctions
    {
        private Login login; //Login Form Object
        private MainForm mainForm; //Main Form Object
        SqlConnection connection; //Database Connection
        string username; //Signed In Username

        /*
         * Login Form Constructor
         */
        public DBFunctions(Login _login, SqlConnection _connection)
        {
            //Default Values
            login = _login;
            connection = _connection;
        }

        /*
         * Main Form Constructor
         */
        public DBFunctions(MainForm _mainForm, SqlConnection _connection, string username)
        {
            //Default Values
            mainForm = _mainForm;
            this.username = username;
            this.connection = _connection;
        }

        /*
         * Establish a connection to the Database
         */
        public SqlConnection ConnectToDB()
        {
            string serverName = "davidprojects.database.windows.net";
            string databaseName = "DavidArduino";
            string username = "RyanSlack";
            string password = "Carol!ne34";

            string connectionString = $"Server={serverName};Database={databaseName};User ID={username};Password={password};Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
            }
            catch (Exception ex) 
            {
                string dataDirectory = Path.GetDirectoryName(Application.ExecutablePath);
                AppDomain.CurrentDomain.SetData("DataDirectory", dataDirectory);
                string relativePath = @"|DataDirectory|\DavidArduino.mdf";
                connection.ConnectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={relativePath};Integrated Security=True;";

                connection.Open(); //Opens Database Connection
            }
            return connection;
        }

        /*
         * Collects Information from form and assigns a new user to the Database
         */
        public void Register()
        {
            if (login.GetTxtRegisterPass() == login.GetTxtRegisterPassConfirm()) //Password check
            {
                /*
                 * SQL Statements to add a User to the Database
                 */
                using (SqlCommand cmd = new SqlCommand("INSERT INTO Users (username, firstName, lastName, email, password) VALUES (@username, @firstName, @lastName, @email, @password)", connection))
                {
                    //Username
                    SqlParameter uNameParam = new SqlParameter("@username", SqlDbType.VarChar, 50);
                    uNameParam.Value = login.GetTxtRegisterUsername();
                    cmd.Parameters.Add(uNameParam);

                    //First Name
                    SqlParameter fNameParam = new SqlParameter("@firstName", SqlDbType.VarChar, 50);
                    fNameParam.Value = login.GetTxtRegisterFirstName();
                    cmd.Parameters.Add(fNameParam);

                    //Last Name
                    SqlParameter lNameParam = new SqlParameter("@lastName", SqlDbType.VarChar, 50);
                    lNameParam.Value = login.GetTxtRegisterLastName();
                    cmd.Parameters.Add(lNameParam);

                    //Email
                    SqlParameter emailParam = new SqlParameter("@email", SqlDbType.VarChar, 50);
                    emailParam.Value = login.GetTxtRegisterEmail();
                    cmd.Parameters.Add(emailParam);

                    //Password
                    SqlParameter passwordParam = new SqlParameter("@password", SqlDbType.VarChar, 50);
                    passwordParam.Value = login.GetTxtRegisterPass();
                    cmd.Parameters.Add(passwordParam);

                    cmd.ExecuteNonQuery(); //Send Data to the Database

                    //Acknowledge successful addition of new User
                    MessageBox.Show("You have successfully registered your account", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Your Password Fields Don't Match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /*
         * Gather information from Login Form and check database if information matches and Sign User in
         */
        public bool Login(string user, string pass)
        {
            /*
             * SQL Statements to check if Login information matches and return true if it does
             */
            using (SqlCommand sqlCommand = new SqlCommand("SELECT username, password FROM Users WHERE username = @username", connection))
            {
                //Username
                SqlParameter param = new SqlParameter("@username", SqlDbType.VarChar, 50);
                param.Value = user;
                sqlCommand.Parameters.Add(param);

                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string username = reader.GetString(0); //Username from Database
                        string password = reader.GetString(1); //Password from Database

                        if (username == user && password == pass) //Username and Password Match Check
                        {
                            return true; //Successful Login
                        }
                    }
                }
                return false; //Unsuccessful Login
            }
        }

        /*
         * Take Information about HitData from HitData object and add it to the database
         */
        public void AddToHitData(HitData hitData)
        {
            /*
             * SQL Statements for adding HitData to Database
             */
            using (SqlCommand cmd = new SqlCommand("INSERT INTO HitData(username, day, time, force, acceleration) VALUES (@username, @day, @time, @force, @acceleration)", connection))
            {
                //Username
                SqlParameter userParam = new SqlParameter("@username", SqlDbType.VarChar, 50);
                userParam.Value = hitData.getUsername();
                cmd.Parameters.Add(userParam);

                //Day
                SqlParameter dateParam = new SqlParameter("@day", SqlDbType.Date);
                dateParam.Value = hitData.getDate();
                cmd.Parameters.Add(dateParam);

                //Time Of Hit
                SqlParameter timeParam = new SqlParameter("@time", SqlDbType.Time, 7);
                TimeSpan time = TimeSpan.ParseExact(hitData.getTime().Substring(0, 8), "hh\\:mm\\:ss", null);
                int millis = int.Parse(hitData.getTime().Substring(9));
                time.Add(TimeSpan.FromMilliseconds(millis));
                timeParam.Value = time;
                cmd.Parameters.Add(timeParam);

                //Force Recorded for Hit
                SqlParameter forceParam = new SqlParameter("@force", SqlDbType.Float);
                forceParam.Value = hitData.getForce();
                cmd.Parameters.Add(forceParam);

                //Acceleration
                SqlParameter accelParam = new SqlParameter("@acceleration", SqlDbType.Float);
                accelParam.Value = hitData.getAcceleration();
                cmd.Parameters.Add(accelParam);

                cmd.ExecuteNonQuery(); //Send Data to the Database
            }
        }

        public void AddToHitCounterData(HitCounterData hitCounterData)
        {

        }

        public void AddToControlData(ControlData controlData)
        {

        }

        /*
         * Get List of HitData Points to add to a Graph
         */
        public List<HitDataPoint> GetHitDataFromDb(string username, string day)
        {
            List<HitDataPoint> hitDataPoints = new List<HitDataPoint>(); //List of HitData Point

            /*
             * SQL Statements to Retrieve HitData from Database according to Username and Day and add to the list
             */
            using(SqlCommand cmd = new SqlCommand("SELECT time, force, acceleration FROM HitData WHERE username = @username AND day = @day", connection))
            {
                //Username
                SqlParameter userParam = new SqlParameter("username", SqlDbType.VarChar, 50);
                userParam.Value = username;
                cmd.Parameters.Add(userParam);

                //Day
                SqlParameter dayParam = new SqlParameter("day", SqlDbType.Date);
                dayParam.Value = day;
                cmd.Parameters.Add(dayParam);

                /*
                 * Read Data from Database and add to List of HitData Points
                 */
                using(SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        HitDataPoint hitDataPoint = new HitDataPoint();
                        hitDataPoint.SetTime(reader.GetTimeSpan(0));
                        hitDataPoint.SetForce(Convert.ToSingle(reader.GetDouble(1)));
                        hitDataPoint.SetAccel(Convert.ToSingle(reader.GetDouble(2)));
                        hitDataPoints.Add(hitDataPoint);
                    }
                }
            }
            return hitDataPoints;
        }

        /*
         * Get List of Hit Counter Data and add to the Graph
         */
        public List<HitCounterDataPoint> GetHitCounterDataFromDb(string username, string day)
        {
            List<HitCounterDataPoint> hitCounterDataPoints = new List<HitCounterDataPoint>();
            return hitCounterDataPoints;
        }

        public List<HitCounterSessionData> GetHitCounterSessions(string username, string day)
        {
            List<HitCounterSessionData> sessions = new List<HitCounterSessionData>();
            using (SqlCommand cmd = new SqlCommand("SELECT startTime, endTime, amountOfHits FROM HitCounterSessionData WHERE username = @username AND day = @day", connection))
            {
                //Username
                SqlParameter userParam = new SqlParameter("username", SqlDbType.VarChar, 50);
                userParam.Value = username;
                cmd.Parameters.Add(userParam);

                //Day
                SqlParameter dayParam = new SqlParameter("day", SqlDbType.Date);
                dayParam.Value = DateTime.Parse(day);
                cmd.Parameters.Add(dayParam);

                /*
                 * Read Data from Database and add to List of HitData Points
                 */
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        HitCounterSessionData hitCounterSessionData = new HitCounterSessionData();
                        hitCounterSessionData.SetStartTime(reader.GetTimeSpan(0));
                        hitCounterSessionData.SetEndTime(reader.GetTimeSpan(1));
                        hitCounterSessionData.SetAmountOfHits(reader.GetInt32(2));
                        sessions.Add(hitCounterSessionData);
                    }
                }
            }
            return sessions;
        }

        /*
         * Get List of Control Data and add to the Graph
         */
        public List<ControlDataPoint> GetControlDataFromDb(string username, string day)
        {
            List<ControlDataPoint> controlDataPoints = new List<ControlDataPoint>();
            return controlDataPoints;
        }

        /*
         * Retrieve the hit data from the Database and print it to the DataGridView
         */
        public void GenerateMainStats()
        {
            /*
             * SQL Statements to Retrieve HitData from Database according to Username and Day and print to the DataGridView
             */
            SqlCommand command = new SqlCommand("SELECT username, force, acceleration, day, time FROM HitData WHERE username = @username AND day = @day", connection);

            SqlParameter userParam = new SqlParameter("@username", SqlDbType.VarChar, 50);
            userParam.Value = username;
            command.Parameters.Add(userParam);

            SqlParameter dayParam = new SqlParameter("@day", SqlDbType.Date);
            dayParam.Value = mainForm.GetStatsMainDate();
            command.Parameters.Add(dayParam);

            /*
             * Create Data table and Add Data Columns
             */
            DataTable hitDataTable = new DataTable();
            hitDataTable.Columns.Add("Username");
            hitDataTable.Columns.Add("Force");
            hitDataTable.Columns.Add("Acceleration");
            hitDataTable.Columns.Add("Date");
            hitDataTable.Columns.Add("Time");

            /*
             * Retrieve the data and add the data to rows
             */
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    string usernameValue = reader.GetString(0);
                    string forceValue = Convert.ToSingle(reader.GetDouble(1)).ToString("N2").Trim() + "N";
                    string accelValue = Convert.ToSingle(reader.GetDouble(2)).ToString("N2").Trim() + "m/s" + '\u00B2';
                    string dayValue = reader.GetDateTime(3).ToString("dd/MM/yyyy");
                    TimeSpan timeValue = reader.GetTimeSpan(4);
                    DateTime timeValDt = DateTime.MinValue.Add(timeValue);
                    string formattedTime = timeValDt.ToString("hh:mm:ss tt");

                    DataRow hitDataRow = hitDataTable.NewRow();
                    hitDataRow["Username"] = usernameValue;
                    hitDataRow["Force"] = forceValue;
                    hitDataRow["Acceleration"] = accelValue;
                    hitDataRow["Date"] = dayValue;
                    hitDataRow["Time"] = formattedTime;
                    hitDataTable.Rows.Add(hitDataRow);
                }
            }

            /*
             * Add the data to the Stats Page and Format the DataGridView
             */
            mainForm.SetStatsMainDataSource(hitDataTable);
            mainForm.GetStatsMainDGV().ForeColor = Color.Black;
            mainForm.GetStatsMainDGV().AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            mainForm.GetStatsMainDGV().AutoResizeColumns();
        }

        /*
         * Retrieve the Hit Counter Data from the Database and print it to the DataGridView
         */
        public void GenerateHitCounterStats()
        {
            DataTable hitCounterData = new DataTable();
            mainForm.SetStatsHitCounterDataSource(hitCounterData);
            mainForm.GetStatsHitCounterDGV().ForeColor = Color.Black;
            mainForm.GetStatsHitCounterDGV().AutoSizeColumnsMode= DataGridViewAutoSizeColumnsMode.Fill;
            mainForm.GetStatsHitCounterDGV().AutoResizeColumns();
        }

        /*
         * Retrieve the Control Data from the Database and print it to the DataGridView
         */
        public void GenerateControlStats()
        {
            DataTable controlData = new DataTable();
            mainForm.SetStatsControlDataSource(controlData);
            mainForm.GetStatsControlDGV().ForeColor = Color.Black;
            mainForm.GetStatsControlDGV().AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            mainForm.GetStatsControlDGV().AutoResizeColumns();
        }
    }
}
