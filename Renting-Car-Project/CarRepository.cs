using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

using System.IO;
using Renting_Car_Project.Forms;

using System.Data;
using System.Data.SqlClient;

using System.Drawing.Text;

using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Renting_Car_Project

{
  
    // این کدها را در کلاس مربوط به مدیریت آگهی‌ها قرار دهید (مثلاً CarRepository)
    public class CarRepository
    {
        // متد برای بررسی ویرایش آگهی
        public bool CanEditCar(int carId)
        {
            string connectionString = @"Server=Localhost;Database=RentingCARDB;Integrated Security=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT EditCount FROM CarEdits WHERE CarId = @CarId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@CarId", carId);

                var result = command.ExecuteScalar();
                if (result != null && Convert.ToInt32(result) >= 1)
                {
                    return false; // اگر تعداد ویرایش‌ها بیشتر از یا برابر با 1 است، ویرایش نمی‌شود
                }
                return true;
            }
        }

        // متد برای افزایش تعداد ویرایش آگهی
        public void IncrementEditCount(int carId)
        {
            string connectionString = @"Server=Localhost;Database=RentingCARDB;Integrated Security=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE CarEdits SET EditCount = EditCount + 1 WHERE CarId = @CarId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@CarId", carId);
                command.ExecuteNonQuery();
            }
        }
    }
}
