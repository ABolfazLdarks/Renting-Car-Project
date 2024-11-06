using Guna.UI2.WinForms;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

public class LoginRepository
{
    public bool LoginUser(string userName, string password)
    {
        using (SqlConnection connection = new SqlConnection(DatabaseConfig.ConnectionString))
        {
            string query = "SELECT COUNT(1) FROM Users WHERE UserName = @UserName AND Password = @Password"; // کامند sql جهت بررسی ورود کاربر
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@UserName", userName);
                command.Parameters.AddWithValue("@Password", password);

                try
                {
                    connection.Open();
                    int count = (int)command.ExecuteScalar();

                    if (count == 1)
                    {
                        return true;
                    }
                    else
                    {
                        MessageBox.Show(" !نام کاربری یا رمز عبور اشتباه است", "خطا در ورود");
                        return false;
                        
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"خطا در ورود: {ex.Message}", "مشکلی رخ داد");
                    return false;
                }
            }
        }
    }
}
