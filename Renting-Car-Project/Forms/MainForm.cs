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
        public MainForm()
        {
            InitializeComponent();
            FontManager.ApplyCustomFont(this.Controls);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    
        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            LoginForm form2 = new LoginForm();
            form2.Show();
            this.Hide();
        }

        private void TpMain_Click(object sender, EventArgs e)
        {

        }
    }
}
    