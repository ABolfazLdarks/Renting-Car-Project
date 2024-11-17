using Renting_Car_Project.Forms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Windows.Forms;

namespace Renting_Car_Project
{
    public partial class MainForm : Form
    {
        private Timer hoverTimer;
        private Control currentHoverControl;
        private int colorStep = 5;
        private int currentColorValue = 40;
        private LoginRepository loginRepository;
        public MainForm()
        {
            InitializeComponent();
            FontManager.ApplyCustomFont(this.Controls);
            hoverTimer = new Timer();
            hoverTimer.Interval = 30;
            hoverTimer.Tick += HoverTimer_Tick;
            loginRepository = new LoginRepository();
        }
       

       

        private void Closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
      

        private void label3_Click(object sender, EventArgs e)
        {
      
        }

      
        private void Menu_But_MouseEnter(object sender, EventArgs e)
        {
            Control control = sender as Control;
            if (control != null && control.Tag != null && control.Tag.ToString() == "RPText")
            {
                currentHoverControl = control;
                currentColorValue = 40;
                hoverTimer.Start();
            }
        }

        private void Menu_But_MouseLeave(object sender, EventArgs e)
        {
            hoverTimer.Stop();
            Control control = sender as Control;
            if (control != null && control.Tag != null && control.Tag.ToString() == "RPText")
            {
                control.ForeColor = SystemColors.ButtonFace;
                control.BackColor = Color.FromArgb(35, 40, 45);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            TokenManager.DeleteToken();
            this.Hide();
            LoginForm loginForm = new LoginForm();
            this.Close();
            loginForm.Show();
        }

      
        private void Closebtn_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
            //AddUserControl1(@"/Resources/img/image2.jpg", "پلاس دنا", "در دسترس", "تومان20/000 ", "در گوهردشت");
        }

        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }
        private void AddUserControl1(string imagePath, string title, string details, string price, string status)
        {
            // ایجاد یک نمونه جدید از UserControl1
            var adControl = new UserControl1();

            // تنظیم داده‌ها
            adControl.SetData(imagePath, title, details, price, status);

            // اضافه کردن کنترل به FlowLayoutPanel
            flowLayoutPanel1.Controls.Add(adControl);
        }

    }
}
    