using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using Renting_Car_Project.Forms;


namespace Renting_Car_Project
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

            var userSession = UserSession.LoadUserSession();

            if (userSession != null && userSession.IsLoggedIn)
            {
                Application.Run(new StartupForm());
            }
            else
            {
                Application.Run(new StartupForm());
            }
        }


    }
}
