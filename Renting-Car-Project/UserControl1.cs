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

namespace Renting_Car_Project
{
    public partial class UserControl1 : UserControl
    {
        public string CarsName { get; set; }
        public int CarID { get; set; }
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
            public void SetCarData(string carName, string carColor, string carModel, int carPrice, byte[] carImage , string Location , int carId)
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
            this.CarID = carId;

        }

        private void guna2Panel1_Click(object sender, EventArgs e)
        {
            try
            {
               // if (string.IsNullOrEmpty(CarsName))
                //{
                    // باز کردن فرم جدید
                    LoadCarForm loadCarForm = new LoadCarForm
                    {
                        CarsName = this.CarsName // ارسال نام خودرو به فرم
                    };
                    loadCarForm.ShowDialog(); // باز کردن فرم به صورت Dialog
                //}
                //else
                //{
                    // نمایش مقدار فعلی CarsName برای دیباگ
                   // MessageBox.Show("نام خودرو تنظیم نشده است! مقدار فعلی CarsName: " + (CarsName ?? "null"));
                //}
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
               // if (string.IsNullOrEmpty(CarsName))
               // {
                    // باز کردن فرم جدید
                    LoadCarForm loadCarForm = new LoadCarForm
                    {
                        CarsName = this.CarsName // ارسال نام خودرو به فرم
                    };
                    loadCarForm.ShowDialog(); // باز کردن فرم به صورت Dialog
                //}
               // else
               // {
                    // نمایش مقدار فعلی CarsName برای دیباگ
                    //MessageBox.Show("نام خودرو تنظیم نشده است! مقدار فعلی CarsName: " + (CarsName ?? "null"));
                //}
            }
            catch (Exception ex)
            {
                // نمایش شرح خطا
                MessageBox.Show("خطا هنگام کلیک روی یوزرکنترل: " + ex.Message);
            }
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
