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

        // تابع برای خواندن داده‌ها از جدول Users
        public void ReadUsersFromDatabase()
        {
            string connectionString = "Server=localhost;Database=RentingCARDB;Integrated Security=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT TOP (1000) [UserID], [FirstName], [LastName], [Address] FROM [RentingCARDB].[dbo].[Users]";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        MessageBox.Show($"UserID: {reader["UserID"]}, Name: {reader["FirstName"]} {reader["LastName"]}, Address: {reader["Address"]}");
                    }
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

        // رویداد بارگذاری فرم
        private void Form1_Load(object sender, EventArgs e)
        {
            ConnectToDatabase(); // فراخوانی تابع اتصال
            ReadUsersFromDatabase();  // فراخوانی تابع خواندن
        }
    }
}
