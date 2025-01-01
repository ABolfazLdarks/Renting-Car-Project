using Guna.UI2.WinForms;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

public class LoginRepository
{
    public int LoginUser(string userName, string password)
    {
        using (SqlConnection connection = new SqlConnection(DatabaseConfig.ConnectionString))
        {
            string query = "SELECT UserId FROM Users WHERE UserName = @UserName AND Password = @Password"; // بازگشت UserId
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@UserName", userName);
                command.Parameters.AddWithValue("@Password", password);

                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();

                    if (result != null && int.TryParse(result.ToString(), out int userId))
                    {
                        return userId;
                    }

                    else
                    {
                       // MessageBox.Show("نام کاربری یا رمز عبور اشتباه است", "خطا در ورود");
                        return -1;
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"خطا در ورود: {ex.Message}", "مشکلی رخ داد");
                    return -1; 
                }
            }
        }
    }

}
