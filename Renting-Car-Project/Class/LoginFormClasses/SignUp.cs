using Guna.UI2.WinForms;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

public class User
{
    public int UserId { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }
    public bool HasPremission { get; set; } = false;
    public DateTime CreatedTime { get; set; }
}

public class UserRepository
{
    public void RegisterUser(string userName, string password)
    {
        var user = new User
        {
            UserId = GenerateUserId(),
            UserName = userName,
            Password = password,
            CreatedTime = DateTime.Now,
        };

        using (SqlConnection connection = new SqlConnection(DatabaseConfig.ConnectionString))
        {
            string query = "INSERT INTO Users (UserId,UserName, Password, HasPremission, CreatedTime) VALUES (@UserId,@UserName, @Password, @HasPremission, @CreatedTime)"; // کامند sql جهت ذخیره اطلاعاتی که دریافت میشود
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@UserId", user.UserId);
                command.Parameters.AddWithValue("@UserName", user.UserName);
                command.Parameters.AddWithValue("@Password", user.Password);
                command.Parameters.AddWithValue("@HasPremission", user.HasPremission);
                command.Parameters.AddWithValue("@CreatedTime", user.CreatedTime);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("ثبت نام با موفقیت انجام شد !","عملیات موفق");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"خطا در ثبت‌نام: {ex.Message}", "مشکلی رخ داد");
                }
            }
        }
    }
private int GenerateUserId()
{
    using (SqlConnection connection = new SqlConnection(DatabaseConfig.ConnectionString))
    {
        string query = "SELECT ISNULL(MAX(UserId), 0) + 1 FROM Users"; // دریافت تعداد کاربران و یکی به آن اضافه کردن برای آیدی
        using (SqlCommand command = new SqlCommand(query, connection))
        {
            try
            {
                connection.Open();
                return (int)command.ExecuteScalar();
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"خطا در تولید UserId: {ex.Message}", "مشکلی رخ داد");
                return 1;
            }
        }
    }
}

}