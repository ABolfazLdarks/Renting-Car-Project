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
    public partial class Form1 : Form
    {
        public Form1()
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
            LoginForm form2 = new LoginForm();
            form2.Show();
            this.Hide();
        }
    }
}
    