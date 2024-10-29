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
            this.HoverTimer = new System.Windows.Forms.Timer(this.components);
            this.Closebtn = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel5 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.SideBar.SuspendLayout();
            this.Menu_Button.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginBorderless
            // 
            this.LoginBorderless.AnimateWindow = true;
            this.LoginBorderless.BorderRadius = 35;
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
            this.SideBar.BorderRadius = 61;
            this.SideBar.Controls.Add(this.Menu_Button);
            this.SideBar.Controls.Add(this.guna2Panel2);
            this.SideBar.Controls.Add(this.guna2Panel1);
            this.SideBar.Location = new System.Drawing.Point(-2, 0);
            this.SideBar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SideBar.MaximumSize = new System.Drawing.Size(124, 494);
            this.SideBar.MinimumSize = new System.Drawing.Size(55, 585);
            this.SideBar.Name = "SideBar";
            this.SideBar.Size = new System.Drawing.Size(124, 585);
            this.SideBar.TabIndex = 0;
            // 
            // Menu_Button
            // 
            this.Menu_Button.BorderColor = System.Drawing.Color.White;
            this.Menu_Button.Controls.Add(this.label3);
            this.Menu_Button.Controls.Add(this.guna2Panel6);
            this.Menu_Button.Location = new System.Drawing.Point(2, 33);
            this.Menu_Button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Menu_Button.Name = "Menu_Button";
            this.Menu_Button.Size = new System.Drawing.Size(122, 114);
            this.Menu_Button.TabIndex = 3;
            this.Menu_Button.Click += new System.EventHandler(this.Menu_Button_Click);
            this.Menu_Button.MouseEnter += new System.EventHandler(this.guna2Panel4_MouseEnter);
            this.Menu_Button.MouseLeave += new System.EventHandler(this.guna2Panel4_MouseLeave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(67, 46);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 24);
            this.label3.TabIndex = 2;
            this.label3.Tag = "RPText";
            this.label3.Text = "منو";
            this.label3.Click += new System.EventHandler(this.Menu_Button_Click);
            this.label3.MouseEnter += new System.EventHandler(this.guna2Panel4_MouseEnter);
            this.label3.MouseLeave += new System.EventHandler(this.guna2Panel4_MouseLeave);
            // 
            // guna2Panel6
            // 
            this.guna2Panel6.BackgroundImage = global::Renting_Car_Project.Properties.Resources.material_symbols__menu;
            this.guna2Panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2Panel6.Location = new System.Drawing.Point(7, 46);
            this.guna2Panel6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2Panel6.Name = "guna2Panel6";
            this.guna2Panel6.Size = new System.Drawing.Size(37, 36);
            this.guna2Panel6.TabIndex = 1;
            this.guna2Panel6.Tag = "";
            this.guna2Panel6.Click += new System.EventHandler(this.Menu_Button_Click);
            this.guna2Panel6.MouseEnter += new System.EventHandler(this.guna2Panel4_MouseEnter);
            this.guna2Panel6.MouseLeave += new System.EventHandler(this.guna2Panel4_MouseLeave);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.label2);
            this.guna2Panel2.Controls.Add(this.guna2Panel4);
            this.guna2Panel2.Location = new System.Drawing.Point(0, 352);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(124, 139);
            this.guna2Panel2.TabIndex = 3;
            this.guna2Panel2.MouseEnter += new System.EventHandler(this.guna2Panel4_MouseEnter);
            this.guna2Panel2.MouseLeave += new System.EventHandler(this.guna2Panel4_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(50, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 48);
            this.label2.TabIndex = 2;
            this.label2.Tag = "RPText";
            this.label2.Text = "ساخت\r\n حساب";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            this.label2.MouseEnter += new System.EventHandler(this.guna2Panel4_MouseEnter);
            this.label2.MouseLeave += new System.EventHandler(this.guna2Panel4_MouseLeave);
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.BackgroundImage = global::Renting_Car_Project.Properties.Resources.signin;
            this.guna2Panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2Panel4.Location = new System.Drawing.Point(4, 45);
            this.guna2Panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.Size = new System.Drawing.Size(41, 43);
            this.guna2Panel4.TabIndex = 1;
            this.guna2Panel4.Tag = "RPText";
            this.guna2Panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel4_Paint);
            this.guna2Panel4.MouseEnter += new System.EventHandler(this.guna2Panel4_MouseEnter);
            this.guna2Panel4.MouseLeave += new System.EventHandler(this.guna2Panel4_MouseLeave);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.guna2Panel3);
            this.guna2Panel1.Location = new System.Drawing.Point(2, 190);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(122, 114);
            this.guna2Panel1.TabIndex = 0;
            this.guna2Panel1.MouseEnter += new System.EventHandler(this.guna2Panel4_MouseEnter);
            this.guna2Panel1.MouseLeave += new System.EventHandler(this.guna2Panel4_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(56, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 24);
            this.label1.TabIndex = 2;
            this.label1.Tag = "RPText";
            this.label1.Text = "ورود";
            this.label1.MouseEnter += new System.EventHandler(this.guna2Panel4_MouseEnter);
            this.label1.MouseLeave += new System.EventHandler(this.guna2Panel4_MouseLeave);
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackgroundImage = global::Renting_Car_Project.Properties.Resources.login;
            this.guna2Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2Panel3.Location = new System.Drawing.Point(2, 41);
            this.guna2Panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(39, 43);
            this.guna2Panel3.TabIndex = 1;
            this.guna2Panel3.Tag = "";
            this.guna2Panel3.MouseEnter += new System.EventHandler(this.guna2Panel4_MouseEnter);
            this.guna2Panel3.MouseLeave += new System.EventHandler(this.guna2Panel4_MouseLeave);
            // 
            // HoverTimer
            // 
            this.HoverTimer.Tick += new System.EventHandler(this.HoverTimer_Tick);
            // 
            // Closebtn
            // 
            this.Closebtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Closebtn.BackgroundImage = global::Renting_Car_Project.Properties.Resources.multiply_48px_____;
            this.Closebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Closebtn.Location = new System.Drawing.Point(708, 10);
            this.Closebtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Closebtn.Name = "Closebtn";
            this.Closebtn.Size = new System.Drawing.Size(37, 36);
            this.Closebtn.TabIndex = 2;
            this.Closebtn.Tag = "";
            this.Closebtn.Click += new System.EventHandler(this.Closebtn_Click);
            this.Closebtn.Paint += new System.Windows.Forms.PaintEventHandler(this.Closebtn_Paint);
            // 
            // guna2Panel5
            // 
            this.guna2Panel5.Controls.Add(this.guna2Button2);
            this.guna2Panel5.Controls.Add(this.guna2Button1);
            this.guna2Panel5.Controls.Add(this.guna2HtmlLabel2);
            this.guna2Panel5.Controls.Add(this.guna2HtmlLabel1);
            this.guna2Panel5.Controls.Add(this.guna2TextBox2);
            this.guna2Panel5.Controls.Add(this.guna2TextBox1);
            this.guna2Panel5.Location = new System.Drawing.Point(205, 79);
            this.guna2Panel5.Name = "guna2Panel5";
            this.guna2Panel5.Size = new System.Drawing.Size(522, 292);
            this.guna2Panel5.TabIndex = 0;
            this.guna2Panel5.Visible = false;
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Location = new System.Drawing.Point(68, 32);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(299, 36);
            this.guna2TextBox1.TabIndex = 0;
            // 
            // guna2TextBox2
            // 
            this.guna2TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox2.DefaultText = "";
            this.guna2TextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox2.Location = new System.Drawing.Point(68, 111);
            this.guna2TextBox2.Name = "guna2TextBox2";
            this.guna2TextBox2.PasswordChar = '\0';
            this.guna2TextBox2.PlaceholderText = "";
            this.guna2TextBox2.SelectedText = "";
            this.guna2TextBox2.Size = new System.Drawing.Size(299, 36);
            this.guna2TextBox2.TabIndex = 1;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(373, 28);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(121, 40);
            this.guna2HtmlLabel1.TabIndex = 2;
            this.guna2HtmlLabel1.Text = "کاربری نام";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(373, 107);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(113, 40);
            this.guna2HtmlLabel2.TabIndex = 2;
            this.guna2HtmlLabel2.Text = "عبور رمز";
            // 
            // guna2Button1
            // 
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(314, 180);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(180, 45);
            this.guna2Button1.TabIndex = 3;
            this.guna2Button1.Text = "ثبت نام";
            // 
            // guna2Button2
            // 
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Location = new System.Drawing.Point(68, 180);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(180, 45);
            this.guna2Button2.TabIndex = 4;
            this.guna2Button2.Text = "بازگشت";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 576);
            this.Controls.Add(this.guna2Panel5);
            this.Controls.Add(this.Closebtn);
            this.Controls.Add(this.SideBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "LoginForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.SideBar.ResumeLayout(false);
            this.Menu_Button.ResumeLayout(false);
            this.Menu_Button.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel5.ResumeLayout(false);
            this.guna2Panel5.PerformLayout();
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
        private System.Windows.Forms.Timer HoverTimer;
        private Guna.UI2.WinForms.Guna2Panel Closebtn;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel5;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox2;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
    }
}