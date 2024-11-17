using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }
     
        public void SetData(string imagePath, string title, string details, string price, string status)
        {
            guna2PictureBox1.ImageLocation = imagePath;
            guna2HtmlLabel1.Text = title;
            label1.Text = details;
            label2.Text = price;
            label3.Text = status;
            

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
