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
        // تایمر برای تأخیر 3 ثانیه
        private Timer timer;

        public StartupForm()
        {
            InitializeComponent();
            // پیکچر باکس را به فرم اضافه می‌کنیم
            PictureBox pictureBox = new PictureBox();
            pictureBox.Image =Properties.Resources.Startup;//مسیر تصویر
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Dock = DockStyle.Fill; // یا هر تنظیم دیگری که می‌خواهید
            this.Controls.Add(pictureBox);

            // تنظیمات تایمر
            timer = new Timer();
            timer.Interval = 3000; // 3 ثانیه
            timer.Tick += Timer_Tick;
            timer.Start();

            FontManager.ApplyCustomFont(this.Controls);
        }


        // وقتی تایمر تمام شود، به فرم بعدی بروید
        private void Timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();  // تایمر را متوقف می‌کنیم

            // فرم بعدی را باز می‌کنیم
            LoginForm form2 = new LoginForm();  // فرم بعدی شما
            form2.Show();

            // فرم فعلی را می‌بندیم
           // this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

       


        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
          
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
