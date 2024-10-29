namespace Renting_Car_Project
{
    partial class Form1
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
            this.Form1Borderless = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.Closebtn = new Guna.UI2.WinForms.Guna2Panel();
            this.SuspendLayout();
            // 
            // Form1Borderless
            // 
            this.Form1Borderless.AnimationInterval = 800;
            this.Form1Borderless.BorderRadius = 35;
            this.Form1Borderless.ContainerControl = this;
            this.Form1Borderless.DockIndicatorTransparencyValue = 0.6D;
            this.Form1Borderless.DragForm = false;
            this.Form1Borderless.TransparentWhileDrag = true;
            // 
            // guna2Button1
            // 
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(188, 251);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(135, 37);
            this.guna2Button1.TabIndex = 1;
            this.guna2Button1.Text = "ورود";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // Closebtn
            // 
            this.Closebtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Closebtn.BackgroundImage = global::Renting_Car_Project.Properties.Resources.multiply_48px_____;
            this.Closebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Closebtn.Location = new System.Drawing.Point(11, 7);
            this.Closebtn.Margin = new System.Windows.Forms.Padding(2);
            this.Closebtn.Name = "Closebtn";
            this.Closebtn.Size = new System.Drawing.Size(37, 36);
            this.Closebtn.TabIndex = 3;
            this.Closebtn.Tag = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 366);
            this.Controls.Add(this.Closebtn);
            this.Controls.Add(this.guna2Button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2BorderlessForm Form1Borderless;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Panel Closebtn;
    }
}

