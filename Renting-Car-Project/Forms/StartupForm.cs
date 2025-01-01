using System;
using System.Windows.Forms;

namespace Renting_Car_Project.Forms
{
    public partial class StartupForm : Form
    {
        private Timer timer;

        public StartupForm()
        {
            InitializeComponent();

            timer = new Timer();
            timer.Interval = 2000;
            timer.Tick += Timer_Tick;
            timer.Start();

            FontManager.ApplyCustomFont(this.Controls);
        }

        private void CheckSavedToken()
        {
            var userSession = UserSession.LoadUserSession();

            if (userSession != null && userSession.IsLoggedIn)
            {
                MainForm form = new MainForm(userSession.UserId);
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("اطلاعات کاربری یافت نشد، لطفاً وارد شوید.", "خطا");
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Hide();
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();

            var userSession = UserSession.LoadUserSession();

            if (userSession != null && userSession.IsLoggedIn)
            {
                CheckSavedToken();
            }
            else
            {
                LoginForm form2 = new LoginForm();
                form2.Show();
                this.Hide();
            }
        }

       
    }
}
