
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using Renting_Car_Project.Forms;
using System.Drawing.Text;
using System.IO;



namespace Renting_Car_Project
{
    public partial class Form1 : Form
    {
        private List<Image> images = new List<Image>();
        private int currentImageIndex = 0;
        private Timer timer;


        public Form1()
        {
            InitializeComponent();
            LoadImages();
            SetupTimer();
            FontManager.ApplyCustomFont(this.Controls);
        }

        // تابع برای اتصال به دیتابیس
        public void ConnectToDatabase()
        {
            // رشته اتصال
            string connectionString = "Server=localhost;Database=RentingCARDB;Integrated Security=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MessageBox.Show("Connected to database successfully!");
                }
                catch (SqlException sqlEx)
                {
                    MessageBox.Show($"SQL Error: {sqlEx.Message}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ConnectToDatabase(); // فراخوانی تابع اتصال
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("به خودروچی خوش آمدید", "خودروچی",MessageBoxButtons.OK,MessageBoxIcon.Information);
            LoginForm form2 = new LoginForm();
            form2.Show();
            
            this.Hide();
        }

        private void Closebtn_Paint(object sender, PaintEventArgs e)
        {

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
            timer.Interval = 5000; // زمان تغییر تصویر به میلی ثانیه
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
    