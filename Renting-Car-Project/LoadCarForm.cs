using Renting_Car_Project.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Renting_Car_Project
{
    public partial class LoadCarForm : Form
    {
        public string CarsName{ get; set;  }
        public LoadCarForm()
        {
            InitializeComponent();
            FontManager.ApplyCustomFont(this.Controls);
        }

        private void LoadCarForm_Load(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(CarsName))
            //{
            //    MessageBox.Show("ماشین ارسال نشد");
            //    return;
            //}




            string connectionString = @"Server=Localhost;Database=RentingCARDB;Integrated Security=True;";



            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Cars WHERE CarsName = @CarsName ";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@CarsName",CarsName );



                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();



                    if (reader.Read())
                    {

                        label9.Text ="خودرو : "+ reader["CarsName"].ToString();
                        label1.Text= "برند : " + reader["brand"].ToString();
                        label2.Text = "مدل : " + reader["YearOfProduction"].ToString();
                        label3.Text = "رنگ : " + reader["Color"].ToString();
                        label4.Text = "وضعیت خودرو : " + reader["StateOfCar"].ToString();
                        label5.Text = "توضیحات : " + reader["Description"].ToString();
                        
                        label6.Text = "مکان : " + reader["Location"].ToString();
                        label7.Text = "کارکرد : " + reader["CarOperation"].ToString();
                        label8.Text = "قیمت : " + reader["PriceDay"].ToString() + "تومان";
                        
                        // خواندن تصویر به صورت باینری
                        if (reader["Image"] != DBNull.Value)
                        {
                            byte[] imageData = (byte[])reader["Image"];
                            using (MemoryStream ms = new MemoryStream(imageData))
                            {
                                guna2PictureBox1.Image = Image.FromStream(ms);
                            }
                        }
                        else
                        {
                            guna2PictureBox1.Image = null; // اگر تصویری ذخیره نشده بود
                        }

                    }
                    // reader.Close();

                    // connection.Close();




                    else
                    {
                        MessageBox.Show("خطا در ارسال ماشین");
                    }



                }
                catch (Exception ex)
                {
                    MessageBox.Show("شرح خطا" + ex.Message);
                }


            }

        }

     

        private void Closebtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }             
    }
}
