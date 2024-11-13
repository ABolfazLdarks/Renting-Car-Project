namespace Renting_Car_Project
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.BorderlessFormMain = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.btnLogOut = new System.Windows.Forms.Label();
            this.SideBar = new Guna.UI2.WinForms.Guna2Panel();
            this.Menu_Button = new Guna.UI2.WinForms.Guna2Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Closebtn = new Guna.UI2.WinForms.Guna2Panel();
            this.SideBar.SuspendLayout();
            this.Menu_Button.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BorderlessFormMain
            // 
            this.BorderlessFormMain.AnimateWindow = true;
            this.BorderlessFormMain.BorderRadius = 35;
            this.BorderlessFormMain.ContainerControl = this;
            this.BorderlessFormMain.DockForm = false;
            this.BorderlessFormMain.DockIndicatorTransparencyValue = 0.6D;
            this.BorderlessFormMain.ResizeForm = false;
            this.BorderlessFormMain.TransparentWhileDrag = true;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Image = global::Renting_Car_Project.Properties.Resources.material_symbols__logout__1_;
            this.btnLogOut.Location = new System.Drawing.Point(9, 7);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(56, 65);
            this.btnLogOut.TabIndex = 0;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
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
            this.SideBar.Dock = System.Windows.Forms.DockStyle.Right;
            this.SideBar.Location = new System.Drawing.Point(630, 0);
            this.SideBar.Margin = new System.Windows.Forms.Padding(2);
            this.SideBar.MaximumSize = new System.Drawing.Size(124, 494);
            this.SideBar.MinimumSize = new System.Drawing.Size(55, 585);
            this.SideBar.Name = "SideBar";
            this.SideBar.Size = new System.Drawing.Size(124, 585);
            this.SideBar.TabIndex = 4;
            // 
            // Menu_Button
            // 
            this.Menu_Button.BorderColor = System.Drawing.Color.White;
            this.Menu_Button.Controls.Add(this.label3);
            this.Menu_Button.Location = new System.Drawing.Point(2, 33);
            this.Menu_Button.Margin = new System.Windows.Forms.Padding(2);
            this.Menu_Button.Name = "Menu_Button";
            this.Menu_Button.Size = new System.Drawing.Size(122, 114);
            this.Menu_Button.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(24, 46);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 24);
            this.label3.TabIndex = 2;
            this.label3.Tag = "RPText";
            this.label3.Text = "آگهی ها";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.label2);
            this.guna2Panel2.Location = new System.Drawing.Point(0, 352);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(124, 139);
            this.guna2Panel2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(1, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 24);
            this.label2.TabIndex = 2;
            this.label2.Tag = "RPText";
            this.label2.Text = "خودروچی من";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Location = new System.Drawing.Point(2, 190);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(122, 114);
            this.guna2Panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(24, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 24);
            this.label1.TabIndex = 2;
            this.label1.Tag = "RPText";
            this.label1.Text = "ثبت آگهی";
            // 
            // Closebtn
            // 
            this.Closebtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Closebtn.BackgroundImage = global::Renting_Car_Project.Properties.Resources.multiply_48px_____;
            this.Closebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Closebtn.Location = new System.Drawing.Point(69, 7);
            this.Closebtn.Margin = new System.Windows.Forms.Padding(2);
            this.Closebtn.Name = "Closebtn";
            this.Closebtn.Size = new System.Drawing.Size(37, 36);
            this.Closebtn.TabIndex = 3;
            this.Closebtn.Tag = "";
            this.Closebtn.Click += new System.EventHandler(this.Closebtn_Click);
            this.Closebtn.Paint += new System.Windows.Forms.PaintEventHandler(this.Closebtn_Paint);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 576);
            this.Controls.Add(this.SideBar);
            this.Controls.Add(this.Closebtn);
            this.Controls.Add(this.btnLogOut);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
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
        private Guna.UI2.WinForms.Guna2BorderlessForm BorderlessFormMain;
        private System.Windows.Forms.Label btnLogOut;
        private Guna.UI2.WinForms.Guna2Panel SideBar;
        private Guna.UI2.WinForms.Guna2Panel Menu_Button;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel Closebtn;
    }
}

