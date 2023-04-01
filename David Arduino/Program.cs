using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace David_Arduino
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Login login = new Login(); //Create Login Form Object 
            Application.Run(login); //Open Login Form

            if (login.GetIsLoggedIn()) { Application.Run(login.main); } //If Logged in, Start Main Form
        }        
    }
}
