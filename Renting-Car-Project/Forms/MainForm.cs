using Renting_Car_Project.Forms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Renting_Car_Project
{
    public partial class MainForm : Form
    {
        
        // متغیر برای ذخیره مسیر کامل فایل تصویر
        private string imageFilePath = "";

        private int _userId;

        private Timer hoverTimer;
        bool sideBar_Expand = true;
        private Control currentHoverControl;
        private int colorStep = 5;
        private int currentColorValue = 40;
        private LoginRepository loginRepository;

        public MainForm(int userId)
        {
            InitializeComponent();
            FontManager.ApplyCustomFont(this.Controls);
            hoverTimer = new Timer();
            hoverTimer.Interval = 30;
            _userId = userId;
            hoverTimer.Tick += HoverTimer_Tick;
            loginRepository = new LoginRepository();
            addusercontrol();
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

        private void label5_Click(object sender, EventArgs e)
        {
            UserSession.Logout(); 
            this.Hide();
            LoginForm loginForm = new LoginForm();
            this.Close();
            loginForm.Show();
        }

        private void Closebtn_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
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

                    string query = "INSERT INTO Cars(Sellers_ID,Cars_Name,brand,YearOfProduction,Color,StateOfCar,Description,Image,Location,CarOperation,PriceDay,ViewState) " + "VALUES (@Sellers_ID,@Cars_Name,@brand,@YearOfProduction,@Color,@StateOfCar,@Description,@Image,@Location,@CarOperation,@PriceDay,@ViewState)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Sellers_ID", _userId);
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
                        command.Parameters.AddWithValue("@ViewState", 1);

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
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp"; // انواع تصاویر قابل انتخاب
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                imageFilePath = openFileDialog1.FileName;
                string fileName = Path.GetFileName(imageFilePath);
                txtImage.Text = fileName; // فقط نام فایل (با پسوند) نمایش داده می‌شود
            }
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(guna2TextBox1.Text))
            {
                string searchTerm = guna2TextBox1.Text.Trim();
                string connectionString = @"Server=Localhost;Database=RentingCARDB;Integrated Security=True;";
                string query = "SELECT * FROM Cars WHERE Cars_Name LIKE @Cars_Name";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Cars_Name", "%" + searchTerm + "%");

                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        flowLayoutPanel1.Controls.Clear();

                        while (reader.Read())
                        {
                            string carName = reader["Cars_Name"].ToString();
                            string carColor = reader["Color"].ToString();
                            string carModel = reader["YearOfProduction"].ToString();
                            int carPrice = Convert.ToInt32(reader["PriceDay"]);
                            byte[] carImage = reader["Image"] as byte[];
                            string Location = reader["Location"].ToString();

                            UserControl1 carControl1 = new UserControl1();
                            carControl1.SetCarData(carName, carColor, carModel, carPrice, carImage, Location);
                            flowLayoutPanel1.Controls.Add(carControl1);
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
                flowLayoutPanel1.Controls.Clear();
            }
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

        private void Timer_Sidebar_Menu_Tick(object sender, EventArgs e)
        {
            if (sideBar_Expand)
            {
                SideBar2.Width -= 10;
                if (SideBar2.Width == SideBar2.MinimumSize.Width)
                {
                    sideBar_Expand = false;
                    Timer_Sidebar_Menu.Stop();
                }
            }
            else
            {
                SideBar2.Width += 10;
                if (SideBar2.Width == SideBar2.MaximumSize.Width)
                {
                    sideBar_Expand = true;
                    Timer_Sidebar_Menu.Stop();
                }
            }
        }

        private void guna2Panel8_Click(object sender, EventArgs e)
        {
            Timer_Sidebar_Menu.Start();
        }
       

        private void Menu_But_Click(object sender, EventArgs e)
        {
            guna2Panel3.Visible = false;
            PanleAccount.Visible = false;
            flowLayoutPanel1.Visible = true;

            loaddata();
          
             
            
        }

        private void loaddata()
        {
          
             string connectionString = @"Server=Localhost;Database=RentingCARDB;Integrated Security=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT Cars_Name,brand,YearOfProduction,Color,StateOfCar,Description,Image,Location,CarOperation,PriceDay FROM Cars WHERE ViewState = 1";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                flowLayoutPanel1.Controls.Clear();

                while (reader.Read())
                {
                    string carName = reader["Cars_Name"].ToString();
                    string carColor = reader["Color"].ToString();
                    string carModel = reader["YearOfProduction"].ToString();
                    int carPrice = Convert.ToInt32(reader["PriceDay"]);
                    byte[] carImage = reader["Image"] as byte[];
                    string Location = reader["Location"].ToString();

                    UserControl1 carControl = new UserControl1();

                    carControl.SetCarData(carName, carColor, carModel, carPrice, carImage, Location);

                    flowLayoutPanel1.Controls.Add(carControl);


                }

            }
        }
        private void UserControl1_Click(object sender, EventArgs e)
        {
           // UserControl1 currentUsercontrol = (UserControl1)sender;
           // currentUsercontrol.Visible = false;


           // UserControl2 userControl2 = new UserControl2();
            //guna2Panel4.Controls.Add(userControl2);
           // guna2Panel4.Visible = true;
            //userControl2.BringToFront();
            
           

        }
         public void ShowUserControl2()
        {
            flowLayoutPanel1.Visible = false;
            guna2Panel14.Visible = true;



        }
        private void addusercontrol()
        {
            //UserControl2 = new UserControl2();
          //  {
           //     Visible = false;
           // }
          //  guna2Panel14.Controls.Add(UserControl2);


        }
        private void guna2Panel2_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Visible = false;
            PanleAccount.Visible = false;
            guna2Panel3.Visible = true;
        }
         private void label2_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Visible = false;
            guna2Panel3.Visible = false;
            PanleAccount.Visible = true;
        }

        private void guna2Panel9_Paint(object sender, PaintEventArgs e)
        {

        }

       


        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Click(object sender, EventArgs e)
        {
          
        }

        private void guna2Panel10_Click(object sender, EventArgs e)
        {
     
        }

        private void guna2Panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel4_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel4_MouseCaptureChanged(object sender, EventArgs e)
        {

        }

        private void guna2Panel4_MouseClick(object sender, MouseEventArgs e)
        {
            flowLayoutPanel1.Visible = false;
            guna2Panel3.Visible = false;
            PanleAccount.Visible = true;
        }

        private void guna2Panel7_Click(object sender, EventArgs e)
        {
         
        }

        private void guna2Panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel13_Click(object sender, EventArgs e)
        {
            UserSession.Logout();
            this.Hide();
            LoginForm loginForm = new LoginForm();
            this.Close();
            loginForm.Show();
        }

        private void guna2Panel15_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel15_Click(object sender, EventArgs e)
        {
            guna2Panel14.Visible = false;
            guna2Panel3.Visible = false;
            PanleAccount.Visible = false;
            flowLayoutPanel1.Visible = true;
            loaddata();
          
           
        }
    }
}
