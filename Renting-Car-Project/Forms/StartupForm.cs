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
        private List<Image> images = new List<Image>();
        private int currentImageIndex = 0;
        private Timer timer;

        public StartupForm()
        {
            InitializeComponent();
            LoadImages();
            SetupTimer();
            FontManager.ApplyCustomFont(this.Controls);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            MessageBox.Show("به خودروچی خوش آمدید", "خودروچی", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoginForm form2 = new LoginForm();
                form2.Show();
            this.Hide();


        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("به امید دیدار", "خودروچی", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void LoadImages()
        {
            images.Add(Properties.Resources.image1);
            images.Add(Properties.Resources.image2);
            images.Add(Properties.Resources.image3);


        }
        private void SetupTimer()
        {
            timer = new Timer();
            timer.Interval = 2000; // زمان تغییر تصویر به میلی ثانیه
            timer.Tick += Timer_Tick;
            timer.Start();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (images.Count > 0)
            {
                guna2PictureBox1.Image = images[currentImageIndex];
                currentImageIndex = (currentImageIndex + 1) % images.Count; // به تصویر بعدی برو
            }
        }
    }
}
