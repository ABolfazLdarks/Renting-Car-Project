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
        public UserControl1()
        {
            InitializeComponent();
          
        }


        // متد برای تنظیم داده‌های خودرو در UserControl
        public void SetCarData(string carName, string carColor, string carModel, int carPrice, byte[] carImage)
        {
            lblCarName.Text = carName;
            lblCarColor.Text = carColor;
            lblCarModel.Text = carModel;
            // نمایش قیمت به صورت int
            lblCarPrice.Text = $"قیمت روزانه: {carPrice:#,0}"; // نمایش قیمت به صورت فرمت عددی

            // بررسی اگر تصویر موجود باشد
            //if (carImage != null && carImage.Length > 0)
            //{
            //    try
            //    {
            //        // ذخیره تصویر موقت برای بررسی
            //        //string tempFilePath = Path.Combine(Path.GetTempPath(), "tempCarImage.jpg");
            //       // File.WriteAllBytes(tempFilePath, carImage);

            //        // بارگذاری تصویر از فایل موقت
            //        guna2PictureBox1.Image = Image.FromFile(tempFilePath);
            //    }
            //    catch (Exception ex)
            //    {
            //        // نمایش پیغام خطا در صورت بروز مشکل در بارگذاری تصویر
            //        MessageBox.Show("خطا در بارگذاری تصویر: " + ex.Message);
            //    }
            //}
            //else
            //{
            //    // اگر تصویر موجود نیست، یک تصویر پیش‌فرض نمایش دهید
            //    //guna2PictureBox1.Image = Properties.Resources.image1;
            //}
            using (MemoryStream ms = new MemoryStream(carImage))
            {
                guna2PictureBox1.Image = Image.FromStream(ms);
            }


        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
