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
            //AddClickEvent(this);
            this.Click += new EventHandler(UserControl1_Click);
            this.Click += new EventHandler(guna2Panel1_Click);
            FontManager.ApplyCustomFont(this.Controls);
        }

        private void AddClickEvent(Control control)
        {
            control.Click += UserControl1_Click;
            control.Click += guna2Panel1_Click;
            foreach (Control child in control.Controls)
            {
                AddClickEvent(child);
            }
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
            int editCount = GetCarEditCount(carId);
            if (editCount >= 1)
            {
                MessageBox.Show("شما تنها یکبار می‌توانید این آگهی را ویرایش کنید.");
            }
            else
            {

               
                    // به صفحه ویرایش هدایت کنیم
                    EditCarForm editForm = new EditCarForm(carId);
                editForm.ShowDialog();
                    // پس از ویرایش، تعداد ویرایش را به روز می‌کنیم
                    IncrementEditCount(carId);
                    MainForm mainForm = (MainForm)Application.OpenForms["MainForm"];
                    mainForm.LoadAds(); // بارگذاری آگهی‌ها مجدد
                
              
               

               
             
            }
            // فراخوانی مجدد متد LoadAds برای بارگذاری آگهی‌ها و رفرش کردن FlowLayoutPanel
          
        }
        private int GetCarEditCount(int carId)
        {
            int count = 0;
            string connectionString = @"Server=Localhost;Database=RentingCARDB;Integrated Security=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT EditCount FROM CarEdits WHERE Cars_ID = @Cars_ID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Cars_ID", carId);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    count = Convert.ToInt32(reader["EditCount"]);
                }
                connection.Close();
            }
            return count;
        }

        private void IncrementEditCount(int carId)
        {
            string connectionString = @"Server=Localhost;Database=RentingCARDB;Integrated Security=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE CarEdits SET EditCount = EditCount + 1 WHERE Cars_ID = @Cars_ID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Cars_ID", carId);
                command.ExecuteNonQuery();
                connection.Close();
            }
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
            MainForm mainForm1 = (MainForm)Application.OpenForms["MainForm"];
            mainForm1.RefreshAdList(); // بارگذاری آگهی‌ها مجدد
            MessageBox.Show("اگهی با موفقیت حذف شد");
        }

       
    }
}
