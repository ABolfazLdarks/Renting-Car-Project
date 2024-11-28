using Renting_Car_Project.Forms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Windows.Forms;


namespace Renting_Car_Project
{
    public partial class MainForm : Form
    {
       
        // متغیر برای ذخیره مسیر کامل فایل تصویر
        private string imageFilePath = "";


        private Timer hoverTimer;
        private Control currentHoverControl;
        private int colorStep = 5;
        private int currentColorValue = 40;
        private LoginRepository loginRepository;


      
        public MainForm()
        {
            InitializeComponent();
            FontManager.ApplyCustomFont(this.Controls);
            hoverTimer = new Timer();
            hoverTimer.Interval = 30;
            hoverTimer.Tick += HoverTimer_Tick;
            loginRepository = new LoginRepository();
          


        }




        private void Closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void HoverTimer_Tick(object sender, EventArgs e)
        {
            if (currentHoverControl != null)
            {
                currentColorValue += colorStep;
                if (currentColorValue > 255) currentColorValue = 255;

                currentHoverControl.ForeColor = Color.FromArgb(currentColorValue, currentColorValue, currentColorValue);
            }
        }

        private void Menu_But_MouseEnter(object sender, EventArgs e)
        {
            Control control = sender as Control;
            if (control != null && control.Tag != null && control.Tag.ToString() == "RPText")
            {
                currentHoverControl = control;
                currentColorValue = 40;
                hoverTimer.Start();
            }
        }

        private void Menu_But_MouseLeave(object sender, EventArgs e)
        {
            hoverTimer.Stop();
            Control control = sender as Control;
            if (control != null && control.Tag != null && control.Tag.ToString() == "RPText")
            {
                control.ForeColor = SystemColors.ButtonFace;
                control.BackColor = Color.FromArgb(35, 40, 45);
            }
        }
        

        private void Closebtn_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
      
        }
        

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            string connectionString = @"Server=Localhost;Database=RentingCARDB;Integrated Security=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();


                    // خواندن تصویر به صورت باینری از مسیر کامل فایل
                    byte[] imageBytes = null;
                    if (!string.IsNullOrEmpty(imageFilePath))
                    {
                        // خواندن فایل تصویر از مسیر کامل
                        imageBytes = File.ReadAllBytes(imageFilePath); // تبدیل تصویر به بایت‌ها
                    }

                    string query = "INSERT INTO Cars(Cars_Name,brand,YearOfProduction,Color,StateOfCar,Description,Image,Location,CarOperation,PriceDay) " + "VALUES (@Cars_Name,@brand,@YearOfProduction,@Color,@StateOfCar,@Description,@Image,@Location,@CarOperation,@PriceDay)";


                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // اضافه کردن پارامترها به دستور SQL

                        command.Parameters.AddWithValue("@Cars_Name", txtCarName.Text);
                        command.Parameters.AddWithValue("@brand", txtBrand.Text);
                        command.Parameters.AddWithValue("@YearOfProduction", int.Parse(txtModelYear.Text));
                        command.Parameters.AddWithValue("@Color", txtColor.Text);
                        command.Parameters.AddWithValue("@StateOfCar", txtStateofCar.Text);
                        command.Parameters.AddWithValue("@Description", txtDescription.Text);
                        command.Parameters.AddWithValue("@Image", imageBytes);
                        command.Parameters.AddWithValue("@Location", txtLocation.Text);
                        command.Parameters.AddWithValue("@CarOperation", int.Parse(txtMileage.Text));
                        command.Parameters.AddWithValue("@PriceDay", int.Parse(txtPrice.Text));

                        command.ExecuteNonQuery(); // اجرا کردن دستور
                        MessageBox.Show("آگهی با موفقیت ذخیره شد", "عملیات موفق");
                        txtCarName.Clear(); txtBrand.Clear(); txtModelYear.Clear(); txtColor.Clear(); txtStateofCar.Clear(); txtDescription.Clear(); txtImage.Clear(); txtLocation.Clear(); txtMileage.Clear(); txtPrice.Clear();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("خطا: " + ex.Message);
                }
            }
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            // ایجاد کادر انتخاب فایل
            //OpenFileDialog openFileDialog = new OpenFileDialog();
            // استفاده از openFileDialog1 برای انتخاب تصویر
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp"; // انواع تصاویر قابل انتخاب
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // مسیر کامل تصویر انتخاب شده را در تکست باکس ذخیره می‌کنیم
                // txtImage.Text = openFileDialog1.FileName;
                // نمایش فقط نام فایل (با پسوند) در تکست‌باکس
                //string fileName = Path.GetFileName(openFileDialog1.FileName);
                //txtImage.Text = fileName; // فقط نام فایل (با پسوند) نمایش داده می‌شود


                // ذخیره مسیر کامل فایل در متغیر imageFilePath
                imageFilePath = openFileDialog1.FileName;

                // نمایش فقط نام فایل (با پسوند) در تکست‌باکس
                string fileName = Path.GetFileName(imageFilePath);
                txtImage.Text = fileName; // فقط نام فایل (با پسوند) نمایش داده می‌شود





            }
        }

        private void guna2VScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }
        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

          
                // ابتدا مطمئن میشویم که ورودی خالی نیست
                if (!string.IsNullOrWhiteSpace(guna2TextBox1.Text))
                {
                    // رشته جستجو شده از TextBox
                    string searchTerm = guna2TextBox1.Text.Trim();

                    // انجام عملیات جستجو در پایگاه داده
                    string connectionString = @"Server=Localhost;Database=RentingCARDB;Integrated Security=True;";  // اتصال به پایگاه داده
                    string query = "SELECT * FROM Cars WHERE Cars_Name LIKE @Cars_Name";

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@Cars_Name", "%" + searchTerm + "%");

                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        // ابتدا فلوی لیوت پانل را پاک می‌کنیم تا نتایج جدید نمایش داده شود
                        flowLayoutPanel1.Controls.Clear();

                        while (reader.Read())
                        {
                                                     
                                // خواندن داده‌ها از پایگاه داده
                                string carName = reader["Cars_Name"].ToString();
                                string carColor = reader["Color"].ToString();
                                string carModel = reader["YearOfProduction"].ToString();
                                // تبدیل قیمت به نوع int
                                int carPrice = Convert.ToInt32(reader["PriceDay"]);
                                byte[] carImage = reader["Image"] as byte[];

                                string Location = reader["Location"].ToString();



                                // ایجاد یک نمونه از UserControl و تنظیم داده‌ها
                                UserControl1 carControl1 = new UserControl1();
                                carControl1.SetCarData(carName, carColor, carModel, carPrice, carImage, Location);

                                // افزودن UserControl به FlowLayoutPanel
                                flowLayoutPanel1.Controls.Add(carControl1); // افزودن UserControl جدید به FlowLayoutPanel
                            
                          
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                    }
                }
                else
                {
                // اگر ورودی خالی باشد، فلوی لیوت پانل را پاک می‌کنیم
                flowLayoutPanel1.Controls.Clear();
                }
            






        }

        private void guna2TextBox1_MouseEnter(object sender, EventArgs e)
        {
           

        }

        private void guna2TextBox1_Leave(object sender, EventArgs e)
        {



            guna2TextBox1.Text = "جستجو در همه آگهی ها";
            guna2TextBox1.ForeColor = Color.Gray;
            guna2TextBox1.ReadOnly = true;

        }

        private void guna2TextBox1_MouseClick(object sender, MouseEventArgs e)
        {
           
                guna2TextBox1.Text = "";
                guna2TextBox1.ForeColor = Color.Gray;
                guna2TextBox1.ReadOnly = false;
            
        }

        private void guna2TextBox1_MouseLeave(object sender, EventArgs e)
        {

            
          
        }

        private void guna2TextBox1_Load(object sender, EventArgs e)
        {
            
        }

        private void Menu_But_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Visible = true;
            guna2Panel3.Visible = false;


            //تنظیم مقدار Maximum براساس محتوای FlowLayoutPanel
            //guna2VScrollBar1.Maximum = Math.Max(0, flowLayoutPanel1.DisplayRectangle.Height - flowLayoutPanel1.ClientSize.Height);

            // اتصال به پایگاه داده
            string connectionString = @"Server=Localhost;Database=RentingCARDB;Integrated Security=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT Cars_Name,brand,YearOfProduction,Color,StateOfCar,Description,Image,Location,CarOperation,PriceDay FROM Cars";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                //پاک کردن محتوای قبلی FlowLayoutPanel
                flowLayoutPanel1.Controls.Clear();

                while (reader.Read())
                {
                    // خواندن داده‌ها از پایگاه داده
                    string carName = reader["Cars_Name"].ToString();
                    string carColor = reader["Color"].ToString();
                    string carModel = reader["YearOfProduction"].ToString();
                    // تبدیل قیمت به نوع int
                    int carPrice = Convert.ToInt32(reader["PriceDay"]);
                    byte[] carImage = reader["Image"] as byte[];

                    string Location = reader["Location"].ToString();
                 
                  

                    // ایجاد یک نمونه از UserControl و تنظیم داده‌ها
                    UserControl1 carControl = new UserControl1();
                    carControl.SetCarData(carName, carColor, carModel, carPrice, carImage, Location);

                    // افزودن UserControl به FlowLayoutPanel
                    flowLayoutPanel1.Controls.Add(carControl); // افزودن UserControl جدید به FlowLayoutPanel
                }
            }
        }

        private void guna2Panel9_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Visible = false;
            guna2Panel3.Visible = true;
        }

        private void guna2Panel5_Click(object sender, EventArgs e)
        {
            TokenManager.DeleteToken();
            this.Hide();
            LoginForm loginForm = new LoginForm();
            this.Close();
            loginForm.Show();
        }
    }
}




