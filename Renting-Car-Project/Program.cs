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

            // بارگذاری اطلاعات کاربر از فایل
            var userSession = UserSession.LoadUserSession();

            // بررسی اینکه آیا کاربر وارد شده است
            if (userSession != null && userSession.IsLoggedIn)
            {
                // اگر کاربر وارد شده باشد، صفحه راه‌اندازی نمایش داده می‌شود
                Application.Run(new StartupForm()); 
            }
            else
            {
                // اگر کاربر وارد نشده باشد، صفحه راه‌اندازی نمایش داده می‌شود
                Application.Run(new StartupForm()); 
            }

        }

    }
}
