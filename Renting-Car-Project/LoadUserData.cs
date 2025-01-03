using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using Renting_Car_Project.Forms;
using System.Drawing.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
namespace Renting_Car_Project
{
   
    public partial class LoadUserData : Form
    {
        public LoadUserData()
        {
            InitializeComponent();
            FontManager.ApplyCustomFont(this.Controls);
        }
       
        private int GetLoggedInUserId()
        {
            var userSession = UserSession.LoadUserSession(); // فرض می‌کنیم که این متد شناسه کاربر را از سشن بارگذاری می‌کند
            return userSession?.UserId ?? -1; // اگر سشن خالی بود، مقدار -1 بازگشت داده می‌شود
        }
        private void LoadUserData_Load(object sender, EventArgs e)
        {
            int loggedInUserId = GetLoggedInUserId();

            if (loggedInUserId == -1)
            {
                MessageBox.Show("لطفاً وارد حساب خود شوید");
                return;
            }
            string connectionString = @"Server=Localhost;Database=RentingCARDB;Integrated Security=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Users WHERE UserId = @UserId";  // دریافت اطلاعات کاربر از پایگاه داده
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserId", loggedInUserId);  // ارسال شناسه کاربر به دیتابیس

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    // بارگذاری اطلاعات کاربر به تکست باکس‌ها
                    txtusername.Text = reader["UserName"].ToString();
                    txtpassword.Text = reader["Password"].ToString();
                    txtphonenumber.Text = reader["PhoneNumber"].ToString();
                    txtname.Text = reader["FirstName"].ToString();
                    txtfname.Text = reader["LastName"].ToString();
                    txtemail.Text = reader["Email"].ToString();
                   
                    txtcodemeli.Text = reader["codemelli"].ToString();
                    if (reader["ProfilePicture"] != DBNull.Value)
                    {
                        byte[] imageData = (byte[])reader["ProfilePicture"];
                        using (MemoryStream ms = new MemoryStream(imageData))
                        {
                            guna2CirclePictureBox1.Image = Image.FromStream(ms);
                        }
                    }
                    else
                    {
                        guna2CirclePictureBox1.Image = null; // اگر تصویری ذخیره نشده بود
                    }

                }
                connection.Close();
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            int loggedInUserId = GetLoggedInUserId();

            if (loggedInUserId == -1)
            {
                MessageBox.Show("لطفاً وارد حساب خود شوید");
                return;
            }
         
            string connectionString = @"Server=Localhost;Database=RentingCARDB;Integrated Security=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "UPDATE Users SET PhoneNumber = @PhoneNumber, FirstName = @FirstName, LastName = @LastName, Email = @Email ,codemelli=@codemelli WHERE UserId = @UserId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@PhoneNumber", txtphonenumber.Text);
                command.Parameters.AddWithValue("@FirstName", txtname.Text);
                command.Parameters.AddWithValue("@LastName", txtfname.Text);
                command.Parameters.AddWithValue("@Email", txtemail.Text);
               
                command.Parameters.AddWithValue("@codemelli", txtcodemeli.Text);

                command.Parameters.AddWithValue("@UserId", loggedInUserId);  // شناسه کاربر برای به‌روزرسانی

                command.ExecuteNonQuery();  // اجرای دستورات به روز رسانی

                MessageBox.Show("حساب کاربری شما با موفقیت ویرایش شد");

                connection.Close();
                this.Visible = false;
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            // باز کردن دیالوگ انتخاب فایل
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif",
                Title = "Select an Image"
                
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // نمایش تصویر در PictureBox
                guna2CirclePictureBox1.Image = Image.FromFile(openFileDialog.FileName);

                // ذخیره تصویر در پایگاه داده
                SaveImageToDatabase(openFileDialog.FileName);
            }
        }
        private void SaveImageToDatabase(string filePath)
        {
            try
            {
                // خواندن تصویر به صورت بایت آرایه
                byte[] imageBytes = File.ReadAllBytes(filePath);
                int loggedInUserId = GetLoggedInUserId();

                if (loggedInUserId == -1)
                {
                    MessageBox.Show("لطفاً وارد حساب خود شوید");
                    return;
                }
                // اتصال به پایگاه داده
                string connectionString = @"Server=Localhost;Database=RentingCARDB;Integrated Security=True;";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // دستور SQL برای درج داده
                    string query = "UPDATE Users SET ProfilePicture=@ProfilePicture WHERE UserId = @UserId";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ProfilePicture", imageBytes);
                        command.Parameters.AddWithValue("@UserId", loggedInUserId);
                        command.ExecuteNonQuery();
                    }
                   
                }

               
               
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void Closebtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
