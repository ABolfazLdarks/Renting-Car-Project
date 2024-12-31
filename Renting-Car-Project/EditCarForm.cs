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
  
    public partial class EditCarForm : Form
    {
        // متغیر برای ذخیره مسیر کامل فایل تصویر
     
        private int CarId;
        private Label lblLocation;
        private Label lblCarPrice;
        private Label lblCarModel;
        private Label lblCarColor;
        private Label lblCarName;
        private Guna.UI2.WinForms.Guna2TextBox txtCarName;
        private Guna.UI2.WinForms.Guna2TextBox txtCarColor;
        private Guna.UI2.WinForms.Guna2TextBox txtCarModel;
        private Guna.UI2.WinForms.Guna2TextBox txtCarPrice;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Panel Closebtn;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;

      

        public EditCarForm(int carId)
        {
            InitializeComponent();
            CarId = carId;
           
        }

        private void LoadCarData()
        {
            


        }

    private void btnSave_Click(object sender, EventArgs e)
        {
          
        }

        private void InitializeComponent()
        {
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblCarPrice = new System.Windows.Forms.Label();
            this.lblCarModel = new System.Windows.Forms.Label();
            this.lblCarColor = new System.Windows.Forms.Label();
            this.lblCarName = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.txtCarName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCarColor = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCarModel = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCarPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.Closebtn = new Guna.UI2.WinForms.Guna2Panel();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLocation
            // 
            this.lblLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.ForeColor = System.Drawing.Color.Gray;
            this.lblLocation.Location = new System.Drawing.Point(284, 180);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblLocation.Size = new System.Drawing.Size(149, 35);
            this.lblLocation.TabIndex = 17;
            this.lblLocation.Text = "label3";
            this.lblLocation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCarPrice
            // 
            this.lblCarPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarPrice.ForeColor = System.Drawing.Color.Gray;
            this.lblCarPrice.Location = new System.Drawing.Point(297, 145);
            this.lblCarPrice.Name = "lblCarPrice";
            this.lblCarPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblCarPrice.Size = new System.Drawing.Size(151, 35);
            this.lblCarPrice.TabIndex = 16;
            this.lblCarPrice.Text = "label3";
            this.lblCarPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCarModel
            // 
            this.lblCarModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarModel.ForeColor = System.Drawing.Color.Gray;
            this.lblCarModel.Location = new System.Drawing.Point(351, 75);
            this.lblCarModel.Name = "lblCarModel";
            this.lblCarModel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblCarModel.Size = new System.Drawing.Size(97, 35);
            this.lblCarModel.TabIndex = 15;
            this.lblCarModel.Text = "label3";
            this.lblCarModel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCarColor
            // 
            this.lblCarColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarColor.ForeColor = System.Drawing.Color.Gray;
            this.lblCarColor.Location = new System.Drawing.Point(297, 110);
            this.lblCarColor.Name = "lblCarColor";
            this.lblCarColor.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblCarColor.Size = new System.Drawing.Size(151, 35);
            this.lblCarColor.TabIndex = 14;
            this.lblCarColor.Text = "label2";
            this.lblCarColor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCarName
            // 
            this.lblCarName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarName.ForeColor = System.Drawing.Color.Black;
            this.lblCarName.Location = new System.Drawing.Point(361, 40);
            this.lblCarName.Name = "lblCarName";
            this.lblCarName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblCarName.Size = new System.Drawing.Size(99, 35);
            this.lblCarName.TabIndex = 13;
            this.lblCarName.Text = "label1";
            this.lblCarName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2PictureBox1.BorderRadius = 10;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(12, 12);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(243, 200);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 12;
            this.guna2PictureBox1.TabStop = false;
            // 
            // txtCarName
            // 
            this.txtCarName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCarName.DefaultText = "";
            this.txtCarName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCarName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCarName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCarName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCarName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCarName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCarName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCarName.Location = new System.Drawing.Point(191, 241);
            this.txtCarName.Name = "txtCarName";
            this.txtCarName.PasswordChar = '\0';
            this.txtCarName.PlaceholderText = "";
            this.txtCarName.SelectedText = "";
            this.txtCarName.Size = new System.Drawing.Size(200, 36);
            this.txtCarName.TabIndex = 18;
            // 
            // txtCarColor
            // 
            this.txtCarColor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCarColor.DefaultText = "";
            this.txtCarColor.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCarColor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCarColor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCarColor.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCarColor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCarColor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCarColor.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCarColor.Location = new System.Drawing.Point(191, 283);
            this.txtCarColor.Name = "txtCarColor";
            this.txtCarColor.PasswordChar = '\0';
            this.txtCarColor.PlaceholderText = "";
            this.txtCarColor.SelectedText = "";
            this.txtCarColor.Size = new System.Drawing.Size(200, 36);
            this.txtCarColor.TabIndex = 19;
            // 
            // txtCarModel
            // 
            this.txtCarModel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCarModel.DefaultText = "";
            this.txtCarModel.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCarModel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCarModel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCarModel.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCarModel.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCarModel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCarModel.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCarModel.Location = new System.Drawing.Point(191, 325);
            this.txtCarModel.Name = "txtCarModel";
            this.txtCarModel.PasswordChar = '\0';
            this.txtCarModel.PlaceholderText = "";
            this.txtCarModel.SelectedText = "";
            this.txtCarModel.Size = new System.Drawing.Size(200, 36);
            this.txtCarModel.TabIndex = 20;
            // 
            // txtCarPrice
            // 
            this.txtCarPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCarPrice.DefaultText = "";
            this.txtCarPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCarPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCarPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCarPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCarPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCarPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCarPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCarPrice.Location = new System.Drawing.Point(191, 367);
            this.txtCarPrice.Name = "txtCarPrice";
            this.txtCarPrice.PasswordChar = '\0';
            this.txtCarPrice.PlaceholderText = "";
            this.txtCarPrice.SelectedText = "";
            this.txtCarPrice.Size = new System.Drawing.Size(200, 36);
            this.txtCarPrice.TabIndex = 20;
            // 
            // guna2Button1
            // 
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(202, 409);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(180, 45);
            this.guna2Button1.TabIndex = 21;
            this.guna2Button1.Text = "guna2Button1";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // Closebtn
            // 
            this.Closebtn.AutoScroll = true;
            this.Closebtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Closebtn.BackgroundImage = global::Renting_Car_Project.Properties.Resources.multiply_48px_____;
            this.Closebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Closebtn.Location = new System.Drawing.Point(455, 12);
            this.Closebtn.Margin = new System.Windows.Forms.Padding(2);
            this.Closebtn.Name = "Closebtn";
            this.Closebtn.Size = new System.Drawing.Size(37, 36);
            this.Closebtn.TabIndex = 22;
            this.Closebtn.Tag = "";
            this.Closebtn.Click += new System.EventHandler(this.Closebtn_Click);
            // 
            // EditCarForm
            // 
            this.ClientSize = new System.Drawing.Size(503, 463);
            this.Controls.Add(this.Closebtn);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.txtCarPrice);
            this.Controls.Add(this.txtCarModel);
            this.Controls.Add(this.txtCarColor);
            this.Controls.Add(this.txtCarName);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.lblCarPrice);
            this.Controls.Add(this.lblCarModel);
            this.Controls.Add(this.lblCarColor);
            this.Controls.Add(this.lblCarName);
            this.Controls.Add(this.guna2PictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditCarForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.EditCarForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

      

    
       
    
        private void guna2Button1_Click(object sender, EventArgs e)
        {

            // کد ویرایش آگهی در اینجا
            string connectionString = @"Server=Localhost;Database=RentingCARDB;Integrated Security=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
              
                string query = "UPDATE Cars SET CarsName = @CarsName, Color = @Color, YearOfProduction = @YearOfProduction, PriceDay = @PriceDay WHERE Cars_ID = @Cars_ID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@CarsName", txtCarName.Text);
                command.Parameters.AddWithValue("@Color", txtCarColor.Text);
                command.Parameters.AddWithValue("@YearOfProduction", txtCarModel.Text);
                command.Parameters.AddWithValue("@PriceDay", txtCarPrice.Text);
               
                command.Parameters.AddWithValue("@Cars_ID", CarId);  // شناسه آگهی برای به‌روزرسانی

                command.ExecuteNonQuery();  // اجرای دستورات به روز رسانی

                MessageBox.Show("آگهی شما با موفقیت ویرایش شد!");

                connection.Close();
                this.Visible = false;
            }

          
        }
    
    

        private void Closebtn_Click(object sender, EventArgs e)
        {
           // پاک کردن تکست باکس‌ها و بستن فرم
            txtCarName.Clear();
            txtCarColor.Clear();
            txtCarModel.Clear();
            txtCarPrice.Clear();
            guna2PictureBox1.Image = null;  // تصویر را پاک می‌کنیم

            this.Close();
        }

        private void EditCarForm_Load(object sender, EventArgs e)
        {
            string connectionString = @"Server=Localhost;Database=RentingCARDB;Integrated Security=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Cars WHERE Cars_ID = @Cars_ID";  // دریافت اطلاعات آگهی از پایگاه داده
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Cars_ID", CarId);  // ارسال شناسه آگهی به دیتابیس

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    // بارگذاری اطلاعات آگهی به تکست باکس‌ها
                    txtCarName.Text = reader["CarsName"].ToString();
                    txtCarColor.Text = reader["Color"].ToString();
                    txtCarModel.Text = reader["YearOfProduction"].ToString();
                    txtCarPrice.Text = reader["PriceDay"].ToString();

                    // بارگذاری تصویر آگهی
                    byte[] imageBytes = reader["Image"] as byte[];
                    if (imageBytes != null)
                    {
                        using (MemoryStream ms = new MemoryStream(imageBytes))
                        {
                            guna2PictureBox1.Image = Image.FromStream(ms);
                        }
                    }
                }
                connection.Close();
            }
        }
    }
    
}
