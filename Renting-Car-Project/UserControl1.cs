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
        public string Data { get; set; }
        public UserControl1()
        {
            InitializeComponent();
            this.Click += new EventHandler(UserControl1_Click);
            this.Click += new EventHandler(guna2Panel1_Click);
            FontManager.ApplyCustomFont(this.Controls);
        }


        // متد برای تنظیم داده‌های خودرو در UserControl
        public void SetCarData(string carName, string carColor, string carModel, int carPrice, byte[] carImage , string Location)
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
                                

        }

        private void guna2Panel1_Click(object sender, EventArgs e)
        {

           
            // فراخوانی متدی در فرم اصلی برای نمایش پنل جزئیات
            Form paraenForm = this.FindForm();
            if (paraenForm is MainForm mainForm)
            {
                mainForm.ShowDetailPanel(this.Data,this); // ارسال داده ها به mainform
                this.Visible = false; //مخفی کردن یوزرکنترل
            }
           
           



        }
      
               
        //رویداد کلیک برای نشان دادن پنل جزئیات
        private void UserControl1_Click(object sender, EventArgs e)
        {
            // فراخوانی متدی در فرم اصلی برای نمایش پنل جزئیات
            Form paraenForm = this.FindForm();
            if (paraenForm is MainForm mainForm)
            {
                mainForm.ShowDetailPanel(this.Data,this); // ارسال داده ها به mainform
                this.Visible = false; //مخفی کردن یوزرکنترل
            }
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
