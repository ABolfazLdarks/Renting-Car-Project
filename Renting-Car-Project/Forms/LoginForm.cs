using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Renting_Car_Project.Forms
{
    public partial class LoginForm : Form
    {
        bool sideBar_Expand = true;
        private Timer hoverTimer;
        private Control currentHoverControl;
        private int colorStep = 5;
        private int currentColorValue = 40;

        public LoginForm()
        {
            InitializeComponent();
            FontManager.ApplyCustomFont(this.Controls);
            hoverTimer = new Timer();
            hoverTimer.Interval = 30;
            hoverTimer.Tick += HoverTimer_Tick;

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void Timer_Sidebar_Menu_Tick(object sender, EventArgs e)
        {
            if (sideBar_Expand)
            {
                SideBar.Width -= 10;
                if (SideBar.Width == SideBar.MinimumSize.Width)
                {
                    sideBar_Expand = false;
                    Timer_Sidebar_Menu.Stop();
                }
            }
            else
            {
                SideBar.Width += 10;
                if (SideBar.Width == SideBar.MaximumSize.Width)
                {
                    sideBar_Expand = true;
                    Timer_Sidebar_Menu.Stop();
                }
            }
        }
        private void Menu_Button_Click(object sender, EventArgs e)
        {
            Timer_Sidebar_Menu.Start();

        }

        private void guna2Panel4_MouseEnter(object sender, EventArgs e)
        {
            Control control = sender as Control;
            if (control != null && control.Tag != null && control.Tag.ToString() == "RPText")
            {
                currentHoverControl = control;
                currentColorValue = 40;
                hoverTimer.Start();
            }
        }

        private void guna2Panel4_MouseLeave(object sender, EventArgs e)
        {
            hoverTimer.Stop();
            Control control = sender as Control;
            if (control != null && control.Tag != null && control.Tag.ToString() == "RPText")
            {
                control.ForeColor = SystemColors.ButtonFace;    
                control.BackColor = Color.FromArgb(35, 40, 45);
                    }
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

        private void Closebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            guna2Panel5.Visible = true;
        }

        private void Closebtn_Paint(object sender, PaintEventArgs e)
        {
      
        }
    }
}
