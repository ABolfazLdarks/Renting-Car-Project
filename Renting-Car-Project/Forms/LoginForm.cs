using Guna.UI2.WinForms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Renting_Car_Project.Forms
{
    public partial class LoginForm : Form
    {
        bool sideBar_Expand = true;
        private Timer hoverTimer;
        private Control currentHoverControl;
        private int colorStep = 5;
        private int currentColorValue = 40;
        private LoginRepository loginRepository;

        public LoginForm()
        {
            InitializeComponent();
            FontManager.ApplyCustomFont(this.Controls);
            hoverTimer = new Timer();
            hoverTimer.Interval = 30;
            hoverTimer.Tick += HoverTimer_Tick;
            loginRepository = new LoginRepository();
            CheckSavedUserId();  
        }

        private void CheckSavedUserId()
        {
            var userSession = UserSession.LoadUserSession(); 

            if (userSession != null && userSession.IsLoggedIn) 
            {
                MainForm form = new MainForm(userSession.UserId); 
                form.Show();
                this.Hide();
            }
        }


        private void LoginForm_Load(object sender, EventArgs e)
        {
            guna2Panel7.Visible = true;
        }

        private void Timer_Sidebar_Menu_Tick(object sender, EventArgs e)
        {
            if (sideBar_Expand)
            {
                SideBar.Width -= 10;
                if (SideBar.Width == SideBar.MinimumSize.Width)
                {
                    sideBar_Expand = false;
                    Timer_Sidebar_Menu.Stop();
                }
            }
            else
            {
                SideBar.Width += 10;
                if (SideBar.Width == SideBar.MaximumSize.Width)
                {
                    sideBar_Expand = true;
                    Timer_Sidebar_Menu.Stop();
                }
            }
        }

        private void Menu_Button_Click(object sender, EventArgs e)
        {
            Timer_Sidebar_Menu.Start();
        }

      

        private void HoverTimer_Tick(object sender, EventArgs e)
        {
            if (currentHoverControl != null)
            {
                currentColorValue += colorStep;
                if (currentColorValue > 255) currentColorValue = 255;

                currentHoverControl.ForeColor = Color.FromArgb(currentColorValue, currentColorValue, currentColorValue);
            }
        }

        private void Closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            guna2Panel5.Visible = true;
            guna2Panel7.Visible = false;
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {
            txtPassSignUp.PasswordChar = '*';
        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {
            txtRPTpass.PasswordChar = '*';
        }

        private void guna2TextBox5_TextChanged(object sender, EventArgs e)
        {
            txtPassLog.PasswordChar = '*';
        }

        private void guna2CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2CheckBox2.Checked == true)
            {
                txtPassLog.PasswordChar = '\0';
            }
            else
            {
                txtPassLog.PasswordChar = '*';
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            guna2Panel7.Visible = true;
            guna2Panel5.Visible = false;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (IsNullOrWhiteSpace(txtUserSignUp.Text) ||
                IsNullOrWhiteSpace(txtPassSignUp.Text) ||
                IsNullOrWhiteSpace(txtRPTpass.Text))
            {
                lblFillField.Visible = true;
                txtUserSignUp.BorderColor = txtPassSignUp.BorderColor = txtRPTpass.BorderColor = Color.Red;
            }
            if (txtPassSignUp.Text != txtRPTpass.Text)
            {
                label12.Visible = true;
                txtPassSignUp.BorderColor = txtRPTpass.BorderColor = Color.Red;
                txtPassSignUp.Clear();
                txtRPTpass.Clear();
            }
            else
            {
                lblFillField.Visible = false;
                txtUserSignUp.BorderColor = txtPassSignUp.BorderColor = txtRPTpass.BorderColor = Color.FromArgb(213, 218, 223);

                string userName = txtUserSignUp.Text;
                string password = txtPassSignUp.Text;
                UserRepository userRepository = new UserRepository();
                userRepository.RegisterUser(userName, password); 
                txtUserSignUp.Text = txtPassSignUp.Text = txtRPTpass.Text = string.Empty;

                guna2Panel7.Visible = true;
                guna2Panel5.Visible = false;
                txtUserLog.Text = userName;
                txtPassLog.Text = password;
            }
        }

        private bool IsNullOrWhiteSpace(string input)
        {
            return string.IsNullOrWhiteSpace(input);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUserLog.Text;
            string password = txtPassLog.Text;
            int userId = loginRepository.LoginUser(userName, password);
         

            if (string.IsNullOrWhiteSpace(userName) || string.IsNullOrWhiteSpace(password))
            {
                lblFillFields.Visible = true;
                txtUserLog.BorderColor = txtPassLog.BorderColor = Color.Red;
            }
            else
            {
                lblFillFields.Visible = false;
                txtUserLog.BorderColor = txtPassLog.BorderColor = Color.FromArgb(213, 218, 223);

                if (userId != -1) 
                {
                    bool isLoggedIn = true; 
                    UserSession.SaveUserSession(userId, isLoggedIn); 
                    MainForm form = new MainForm(userId);
                    form.Show();
                    this.Hide();
                }
                else
                {
                    lblFillFields.Visible = true;
                    lblFillFields.Text = "نام کاربری یا رمز عبور اشتباه است";
                    txtUserLog.Clear();
                    txtPassLog.Clear();
                }
            }
        }


        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2CheckBox1.Checked == true)
            {
                txtPassSignUp.PasswordChar = '\0';
                txtRPTpass.PasswordChar = '\0';
            }
            else
            {
                txtPassSignUp.PasswordChar = '*';
                txtRPTpass.PasswordChar = '*';
            }
        }

      
        private void guna2Panel3_Click(object sender, EventArgs e)
        {
            guna2Panel7.Visible = true;
            guna2Panel5.Visible = false;
        }

       
        private void guna2Panel8_MouseEnter(object sender, EventArgs e)
        {
            Control control = sender as Control;
            if (control != null && control.Tag != null && control.Tag.ToString() == "RPText")
            {
                currentHoverControl = control;
                currentColorValue = 40;
                hoverTimer.Start();
            }
        }

        private void guna2Panel8_MouseLeave(object sender, EventArgs e)
        {
            hoverTimer.Stop();
            Control control = sender as Control;
            if (control != null && control.Tag != null && control.Tag.ToString() == "RPText")
            {
                control.ForeColor = SystemColors.ButtonFace;
                control.BackColor = Color.FromArgb(35, 40, 45);
            }
        }

        private void guna2Panel8_Click(object sender, EventArgs e)
        {
            guna2Panel5.Visible = true;
            guna2Panel7.Visible = false;
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            Control control = sender as Control;
            if (control != null && control.Tag != null && control.Tag.ToString() == "RPText")
            {
                currentHoverControl = control;
                currentColorValue = 40;
                hoverTimer.Start();
            }
        }

       

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            Control control = sender as Control;
            if (control != null && control.Tag != null && control.Tag.ToString() == "RPText")
            {
                currentHoverControl = control;
                currentColorValue = 40;
                hoverTimer.Start();
            }
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            hoverTimer.Stop();
            Control control = sender as Control;
            if (control != null && control.Tag != null && control.Tag.ToString() == "RPText")
            {
                control.ForeColor = SystemColors.ButtonFace;
                control.BackColor = Color.FromArgb(35, 40, 45);
            }
        }

      

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            hoverTimer.Stop();
            Control control = sender as Control;
            if (control != null && control.Tag != null && control.Tag.ToString() == "RPText")
            {
                control.ForeColor = SystemColors.ButtonFace;
                control.BackColor = Color.FromArgb(35, 40, 45);
            }
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            Control control = sender as Control;
            if (control != null && control.Tag != null && control.Tag.ToString() == "RPText")
            {
                currentHoverControl = control;
                currentColorValue = 40;
                hoverTimer.Start();
            }
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            hoverTimer.Stop();
            Control control = sender as Control;
            if (control != null && control.Tag != null && control.Tag.ToString() == "RPText")
            {
                control.ForeColor = SystemColors.ButtonFace;
                control.BackColor = Color.FromArgb(35, 40, 45);
            }
        }
    }
}
