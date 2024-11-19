using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using Renting_Car_Project.Forms;
using System.Drawing.Text;
using System.IO;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Renting_Car_Project.Forms
{
    public partial class StartupForm : Form
    {
        // تایمر برای تأخیر 2 ثانیه
        private Timer timer;

        public StartupForm()
        {
            InitializeComponent();

            // تنظیمات تایمر
            timer = new Timer();
            timer.Interval = 2000; // 2 ثانیه
            timer.Tick += Timer_Tick;
            timer.Start();

            FontManager.ApplyCustomFont(this.Controls);
        }

        private void CheckSavedToken()
        {
            string token = TokenManager.LoadToken();
            if (!string.IsNullOrEmpty(token))
            {
                MainForm form = new MainForm();
                form.Show();
                this.Hide();
            }
        }


        // وقتی تایمر تمام شود، به فرم بعدی بروید
        private void Timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();  // تایمر را متوقف می‌کنیم

            // فرم بعدی را باز می‌کنیم
            string token = TokenManager.LoadToken();
            if (!string.IsNullOrEmpty(token))
            {
                CheckSavedToken();

            }
            else
            {
            LoginForm form2 = new LoginForm();  // فرم بعدی شما
            form2.Show();


            // فرم فعلی را می‌بندیم
            this.Hide();

            }

        }
    }
}
