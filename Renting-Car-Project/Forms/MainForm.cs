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
       

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            TokenManager.DeleteToken();
            this.Hide();
            LoginForm loginForm = new LoginForm();
            this.Close();
            loginForm.Show();
        }

        private void Closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
    