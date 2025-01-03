using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using Renting_Car_Project.Forms;
using System.Data.SqlClient;
using System.Drawing.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
namespace Renting_Car_Project
{
    public partial class UserControl1 : UserControl
    {
        public string CarsName { get; set; }
        public int carId { get; set; }
      
        public UserControl1()
        {
            InitializeComponent();
            FontManager.ApplyCustomFont(this.Controls);
        }

      
        // متد برای نمایش دکمه‌ها
        public void ShowUpdateAndDeleteButtons()
        {
            btnUpdate.Visible = true;
            btnDelete.Visible = true;
        }

        // متد برای مخفی کردن دکمه‌ها
        public void HideUpdateAndDeleteButtons()
        {
            btnUpdate.Visible = false;
            btnDelete.Visible = false;
        }
        // متد برای تنظیم داده‌های خودرو در UserControl
        public void SetCarData(string carName, string carColor, string carModel, int carPrice, byte[] carImage, string Location, int carId)
        {
            lblCarName.Text = $"خودرو {carName}";
            lblCarColor.Text = $"رنگ : {carColor}";
            lblCarModel.Text = $" مدل : { carModel}";

            // نمایش قیمت به صورت int

            lblCarPrice.Text = $"قیمت روزانه : {carPrice:#,0} تومان"; // نمایش قیمت به صورت فرمت عددی

            using (MemoryStream ms = new MemoryStream(carImage))
            {
                guna2PictureBox1.Image = Image.FromStream(ms);

            }


            lblLocation.Text = $"در  {Location}";
            this.carId = carId;

        }

        private void guna2Panel1_Click(object sender, EventArgs e)
        {
            try
            {


                LoadCarForm loadCarForm = new LoadCarForm
                {
                    CarsName = this.CarsName // ارسال نام خودرو به فرم
                };
                loadCarForm.ShowDialog(); // باز کردن فرم به صورت Dialog

            }
            catch (Exception ex)
            {
                // نمایش شرح خطا
                MessageBox.Show("خطا هنگام کلیک روی یوزرکنترل: " + ex.Message);
            }
        }
        //رویداد کلیک برای نشان دادن پنل جزئیات
        private void UserControl1_Click(object sender, EventArgs e)
        {
            try
            {

                LoadCarForm loadCarForm = new LoadCarForm
                {
                    CarsName = this.CarsName // ارسال نام خودرو به فرم
                };
                loadCarForm.ShowDialog(); // باز کردن فرم به صورت Dialog

            }
            catch (Exception ex)
            {
                // نمایش شرح خطا
                MessageBox.Show("خطا هنگام کلیک روی یوزرکنترل: " + ex.Message);
            }
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
           
                // به صفحه ویرایش هدایت کنیم
                EditCarForm editForm = new EditCarForm(carId);
                editForm.ShowDialog();
                
                MainForm mainForm = (MainForm)Application.OpenForms["MainForm"];
                mainForm.LoadAds(); // بارگذاری مجدد آگهی‌ها 
                              
       

        }
       
        private void btnDelete_Click(object sender, EventArgs e)
        {
            guna2Panel2.Visible = true;


        }
        private void DeleteAdFromDatabase()
        {
            // اتصال به دیتابیس و حذف آگهی
            string connectionString = @"Server=Localhost;Database=RentingCARDB;Integrated Security=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // دستور حذف آگهی بر اساس CarId
                string query = "DELETE FROM Cars WHERE Cars_ID = @Cars_ID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Cars_ID", this.carId);  // اینجا CarId را باید از یوزرکنترل بگیرید

                command.ExecuteNonQuery();
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            string deleteReason = null;


            if (guna2RadioButton1.Checked)
                deleteReason = "منصرف شدم";
            else if (guna2RadioButton2.Checked)
                deleteReason = "خریدار پیدا نشد";

            else if (guna2RadioButton3.Checked)
                deleteReason = "آگهی به فروش رفت";

            if (string.IsNullOrEmpty(deleteReason))
            {


            }


            // حذف آگهی از دیتابیس با توجه به CarId
            DeleteAdFromDatabase();

            // مخفی کردن پنل دلیل حذف و رفرش آگهی‌ها
            guna2Panel2.Visible = false;
           
            MessageBox.Show("آگهی با موفقیت حذف شد");
           
            this.Visible = false;
        }
      
    

        private void guna2Panel15_Click(object sender, EventArgs e)
        {
            guna2Panel3.Visible = false;
        }

        private void guna2Panel4_Click(object sender, EventArgs e)
        {
            guna2Panel2.Visible = false;
        }

        

        private void btndetial_Click(object sender, EventArgs e)
        {
            


            guna2Panel3.Visible = true;

            string connectionString = @"Server=Localhost;Database=RentingCARDB;Integrated Security=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // ابتدا UserId مربوط به carId را پیدا می‌کنیم
                string getUserIdQuery = "SELECT UserId FROM Cars WHERE Cars_ID = @Cars_ID";
                SqlCommand getUserIdCommand = new SqlCommand(getUserIdQuery, connection);
                getUserIdCommand.Parameters.AddWithValue("@Cars_ID", carId);

                object userIdObj = getUserIdCommand.ExecuteScalar(); // گرفتن UserId
                if (userIdObj == null)
                {
                    MessageBox.Show("اطلاعاتی برای این آگهی یافت نشد");
                    return;
                }

                int userId = Convert.ToInt32(userIdObj);

                // حالا اطلاعات تماس کاربر را پیدا می‌کنیم
                string getPhoneQuery = "SELECT PhoneNumber FROM Users WHERE UserId = @UserId";
                SqlCommand getPhoneCommand = new SqlCommand(getPhoneQuery, connection);
                getPhoneCommand.Parameters.AddWithValue("@UserId", userId);

                SqlDataReader reader = getPhoneCommand.ExecuteReader();
                if (reader.Read())
                {
                    lblphone.Text = reader["PhoneNumber"].ToString(); // نمایش شماره تماس
                }
                else
                {
                    lblphone.Text = "اطلاعات تماس یافت نشد";
                }

                connection.Close();
            }
        }

    }
}
