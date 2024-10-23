using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Renting_Car_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
    }
}
    