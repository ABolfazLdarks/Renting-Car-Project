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
        public MainForm()
        {
            InitializeComponent();
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
                }
                catch (SqlException sqlEx)
                {
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ConnectToDatabase(); // فراخوانی تابع اتصال
        }
    
        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            LoginForm form2 = new LoginForm();
            form2.Show();
            this.Hide();
        }
    }
}
    