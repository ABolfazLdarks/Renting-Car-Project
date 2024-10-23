namespace Renting_Car_Project.Forms
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.LoginBorderless = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.Elipse_Form = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.DragControl_Form = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.Timer_Sidebar_Menu = new System.Windows.Forms.Timer(this.components);
            this.SideBar = new Guna.UI2.WinForms.Guna2Panel();
            this.Menu_Button = new Guna.UI2.WinForms.Guna2Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2Panel6 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.SideBar.SuspendLayout();
            this.Menu_Button.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginBorderless
            // 
            this.LoginBorderless.AnimateWindow = true;
            this.LoginBorderless.BorderRadius = 50;
            this.LoginBorderless.ContainerControl = this;
            this.LoginBorderless.DockIndicatorColor = System.Drawing.Color.Silver;
            this.LoginBorderless.DockIndicatorTransparencyValue = 0.6D;
            this.LoginBorderless.DragForm = false;
            this.LoginBorderless.ResizeForm = false;
            this.LoginBorderless.TransparentWhileDrag = true;
            // 
            // Elipse_Form
            // 
            this.Elipse_Form.BorderRadius = 9;
            this.Elipse_Form.TargetControl = this;
            // 
            // DragControl_Form
            // 
            this.DragControl_Form.DockIndicatorTransparencyValue = 0.6D;
            this.DragControl_Form.TargetControl = this;
            this.DragControl_Form.UseTransparentDrag = true;
            // 
            // Timer_Sidebar_Menu
            // 
            this.Timer_Sidebar_Menu.Interval = 10;
            this.Timer_Sidebar_Menu.Tick += new System.EventHandler(this.Timer_Sidebar_Menu_Tick);
            // 
            // SideBar
            // 
            this.SideBar.AutoRoundedCorners = true;
            this.SideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.SideBar.BorderColor = System.Drawing.Color.White;
            this.SideBar.BorderRadius = 138;
            this.SideBar.Controls.Add(this.Menu_Button);
            this.SideBar.Controls.Add(this.guna2Panel2);
            this.SideBar.Controls.Add(this.guna2Panel1);
            this.SideBar.Location = new System.Drawing.Point(-2, 0);
            this.SideBar.MaximumSize = new System.Drawing.Size(289, 608);
            this.SideBar.MinimumSize = new System.Drawing.Size(73, 720);
            this.SideBar.Name = "SideBar";
            this.SideBar.Size = new System.Drawing.Size(278, 720);
            this.SideBar.TabIndex = 0;
            // 
            // Menu_Button
            // 
            this.Menu_Button.Controls.Add(this.label3);
            this.Menu_Button.Controls.Add(this.guna2Panel6);
            this.Menu_Button.Location = new System.Drawing.Point(3, 41);
            this.Menu_Button.Name = "Menu_Button";
            this.Menu_Button.Size = new System.Drawing.Size(283, 140);
            this.Menu_Button.TabIndex = 3;
            this.Menu_Button.Click += new System.EventHandler(this.Menu_Button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(137, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 44);
            this.label3.TabIndex = 2;
            this.label3.Text = "منو";
            this.label3.Click += new System.EventHandler(this.Menu_Button_Click);
            // 
            // guna2Panel6
            // 
            this.guna2Panel6.BackgroundImage = global::Renting_Car_Project.Properties.Resources.material_symbols__menu;
            this.guna2Panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2Panel6.Location = new System.Drawing.Point(0, 37);
            this.guna2Panel6.Name = "guna2Panel6";
            this.guna2Panel6.Size = new System.Drawing.Size(68, 66);
            this.guna2Panel6.TabIndex = 1;
            this.guna2Panel6.Click += new System.EventHandler(this.Menu_Button_Click);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.label2);
            this.guna2Panel2.Controls.Add(this.guna2Panel4);
            this.guna2Panel2.Location = new System.Drawing.Point(0, 433);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(289, 171);
            this.guna2Panel2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(113, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 88);
            this.label2.TabIndex = 2;
            this.label2.Text = "ساخت\r\n حساب";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.BackgroundImage = global::Renting_Car_Project.Properties.Resources.signin;
            this.guna2Panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2Panel4.Location = new System.Drawing.Point(3, 42);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.Size = new System.Drawing.Size(68, 66);
            this.guna2Panel4.TabIndex = 1;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.guna2Panel3);
            this.guna2Panel1.Location = new System.Drawing.Point(3, 234);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(286, 140);
            this.guna2Panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(120, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 44);
            this.label1.TabIndex = 2;
            this.label1.Text = "ورود";
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackgroundImage = global::Renting_Car_Project.Properties.Resources.login;
            this.guna2Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2Panel3.Location = new System.Drawing.Point(0, 28);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(68, 66);
            this.guna2Panel3.TabIndex = 1;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 709);
            this.Controls.Add(this.SideBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.SideBar.ResumeLayout(false);
            this.Menu_Button.ResumeLayout(false);
            this.Menu_Button.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm LoginBorderless;
        private Guna.UI2.WinForms.Guna2Elipse Elipse_Form;
        private Guna.UI2.WinForms.Guna2DragControl DragControl_Form;
        private System.Windows.Forms.Timer Timer_Sidebar_Menu;
        private Guna.UI2.WinForms.Guna2Panel SideBar;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private Guna.UI2.WinForms.Guna2Panel Menu_Button;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel6;
    }
}