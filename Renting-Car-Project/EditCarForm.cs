using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using Renting_Car_Project.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Drawing.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Renting_Car_Project
{
  
    public partial class EditCarForm : Form
    {
        
     
        private int CarId;
        private Label lblLocation;
        private Label lblCarModel;
        private Label lblstatecar;
        private Label lblCarName;
        private Guna.UI2.WinForms.Guna2TextBox txtCarName;
        private Guna.UI2.WinForms.Guna2TextBox txtbrand;
        private Guna.UI2.WinForms.Guna2TextBox txtCarModel;
        private Guna.UI2.WinForms.Guna2TextBox txtstatecar;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Panel Closebtn;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.ComponentModel.IContainer components;
        private Guna.UI2.WinForms.Guna2TextBox txtMileage;
        private Guna.UI2.WinForms.Guna2TextBox txtlocation;
        private Guna.UI2.WinForms.Guna2TextBox txtcoment;
        private Label lblMileage;
        private Label lblbrand;
        private Label lblcoment;
        private Guna.UI2.WinForms.Guna2TextBox txtprice;
        private Label lblprice;
        private Guna.UI2.WinForms.Guna2Button btnImage;
        private Guna.UI2.WinForms.Guna2TextBox txtcolor;
        private Label lblcolor;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    



        public EditCarForm(int carId)
        {
            InitializeComponent();
            CarId = carId;
            FontManager.ApplyCustomFont(this.Controls);
        }
                
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditCarForm));
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblCarModel = new System.Windows.Forms.Label();
            this.lblstatecar = new System.Windows.Forms.Label();
            this.lblCarName = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.txtCarName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtbrand = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCarModel = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtstatecar = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.Closebtn = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.lblcoment = new System.Windows.Forms.Label();
            this.txtcoment = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblbrand = new System.Windows.Forms.Label();
            this.txtlocation = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblMileage = new System.Windows.Forms.Label();
            this.txtMileage = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblprice = new System.Windows.Forms.Label();
            this.txtprice = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnImage = new Guna.UI2.WinForms.Guna2Button();
            this.lblcolor = new System.Windows.Forms.Label();
            this.txtcolor = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLocation
            // 
            this.lblLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.ForeColor = System.Drawing.Color.Gray;
            this.lblLocation.Location = new System.Drawing.Point(560, 313);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblLocation.Size = new System.Drawing.Size(99, 35);
            this.lblLocation.TabIndex = 17;
            this.lblLocation.Text = "مکان:";
            this.lblLocation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCarModel
            // 
            this.lblCarModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarModel.ForeColor = System.Drawing.Color.Gray;
            this.lblCarModel.Location = new System.Drawing.Point(560, 146);
            this.lblCarModel.Name = "lblCarModel";
            this.lblCarModel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblCarModel.Size = new System.Drawing.Size(97, 35);
            this.lblCarModel.TabIndex = 15;
            this.lblCarModel.Text = "مدل:";
            this.lblCarModel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblstatecar
            // 
            this.lblstatecar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstatecar.ForeColor = System.Drawing.Color.Gray;
            this.lblstatecar.Location = new System.Drawing.Point(550, 229);
            this.lblstatecar.Name = "lblstatecar";
            this.lblstatecar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblstatecar.Size = new System.Drawing.Size(103, 35);
            this.lblstatecar.TabIndex = 14;
            this.lblstatecar.Text = "وضعیت خودرو:";
            this.lblstatecar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCarName
            // 
            this.lblCarName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarName.ForeColor = System.Drawing.Color.Black;
            this.lblCarName.Location = new System.Drawing.Point(560, 62);
            this.lblCarName.Name = "lblCarName";
            this.lblCarName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblCarName.Size = new System.Drawing.Size(99, 35);
            this.lblCarName.TabIndex = 13;
            this.lblCarName.Text = "نام خودرو:";
            this.lblCarName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2PictureBox1.BorderRadius = 10;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(45, 61);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(243, 200);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 12;
            this.guna2PictureBox1.TabStop = false;
            // 
            // txtCarName
            // 
            this.txtCarName.BorderRadius = 10;
            this.txtCarName.BorderThickness = 2;
            this.txtCarName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCarName.DefaultText = "";
            this.txtCarName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCarName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCarName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCarName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCarName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCarName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCarName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCarName.Location = new System.Drawing.Point(348, 61);
            this.txtCarName.Name = "txtCarName";
            this.txtCarName.PasswordChar = '\0';
            this.txtCarName.PlaceholderText = "";
            this.txtCarName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCarName.SelectedText = "";
            this.txtCarName.Size = new System.Drawing.Size(200, 36);
            this.txtCarName.TabIndex = 1;
            // 
            // txtbrand
            // 
            this.txtbrand.BorderRadius = 10;
            this.txtbrand.BorderThickness = 2;
            this.txtbrand.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbrand.DefaultText = "";
            this.txtbrand.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbrand.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbrand.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbrand.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbrand.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbrand.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtbrand.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbrand.Location = new System.Drawing.Point(348, 103);
            this.txtbrand.Name = "txtbrand";
            this.txtbrand.PasswordChar = '\0';
            this.txtbrand.PlaceholderText = "";
            this.txtbrand.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtbrand.SelectedText = "";
            this.txtbrand.Size = new System.Drawing.Size(200, 36);
            this.txtbrand.TabIndex = 2;
            // 
            // txtCarModel
            // 
            this.txtCarModel.BorderRadius = 10;
            this.txtCarModel.BorderThickness = 2;
            this.txtCarModel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCarModel.DefaultText = "";
            this.txtCarModel.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCarModel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCarModel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCarModel.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCarModel.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCarModel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCarModel.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCarModel.Location = new System.Drawing.Point(348, 145);
            this.txtCarModel.Name = "txtCarModel";
            this.txtCarModel.PasswordChar = '\0';
            this.txtCarModel.PlaceholderText = "";
            this.txtCarModel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCarModel.SelectedText = "";
            this.txtCarModel.Size = new System.Drawing.Size(200, 36);
            this.txtCarModel.TabIndex = 3;
            // 
            // txtstatecar
            // 
            this.txtstatecar.BorderRadius = 10;
            this.txtstatecar.BorderThickness = 2;
            this.txtstatecar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtstatecar.DefaultText = "";
            this.txtstatecar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtstatecar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtstatecar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtstatecar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtstatecar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtstatecar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtstatecar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtstatecar.Location = new System.Drawing.Point(348, 229);
            this.txtstatecar.Name = "txtstatecar";
            this.txtstatecar.PasswordChar = '\0';
            this.txtstatecar.PlaceholderText = "";
            this.txtstatecar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtstatecar.SelectedText = "";
            this.txtstatecar.Size = new System.Drawing.Size(200, 36);
            this.txtstatecar.TabIndex = 5;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 10;
            this.guna2Button1.BorderThickness = 2;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(222, 458);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(180, 45);
            this.guna2Button1.TabIndex = 11;
            this.guna2Button1.Text = "ثبت ";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // Closebtn
            // 
            this.Closebtn.AutoScroll = true;
            this.Closebtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Closebtn.BackgroundImage = global::Renting_Car_Project.Properties.Resources.multiply_48px_____;
            this.Closebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Closebtn.Location = new System.Drawing.Point(617, 11);
            this.Closebtn.Margin = new System.Windows.Forms.Padding(2);
            this.Closebtn.Name = "Closebtn";
            this.Closebtn.Size = new System.Drawing.Size(37, 36);
            this.Closebtn.TabIndex = 22;
            this.Closebtn.Tag = "";
            this.Closebtn.Click += new System.EventHandler(this.Closebtn_Click);
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 10;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // lblcoment
            // 
            this.lblcoment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcoment.ForeColor = System.Drawing.Color.Gray;
            this.lblcoment.Location = new System.Drawing.Point(554, 272);
            this.lblcoment.Name = "lblcoment";
            this.lblcoment.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblcoment.Size = new System.Drawing.Size(103, 35);
            this.lblcoment.TabIndex = 14;
            this.lblcoment.Text = "توضیحات خودرو:";
            this.lblcoment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtcoment
            // 
            this.txtcoment.BorderRadius = 10;
            this.txtcoment.BorderThickness = 2;
            this.txtcoment.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcoment.DefaultText = "";
            this.txtcoment.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtcoment.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtcoment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtcoment.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtcoment.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtcoment.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtcoment.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtcoment.Location = new System.Drawing.Point(348, 271);
            this.txtcoment.Name = "txtcoment";
            this.txtcoment.PasswordChar = '\0';
            this.txtcoment.PlaceholderText = "";
            this.txtcoment.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtcoment.SelectedText = "";
            this.txtcoment.Size = new System.Drawing.Size(200, 36);
            this.txtcoment.TabIndex = 6;
            // 
            // lblbrand
            // 
            this.lblbrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbrand.ForeColor = System.Drawing.Color.Gray;
            this.lblbrand.Location = new System.Drawing.Point(554, 104);
            this.lblbrand.Name = "lblbrand";
            this.lblbrand.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblbrand.Size = new System.Drawing.Size(103, 35);
            this.lblbrand.TabIndex = 14;
            this.lblbrand.Text = "برند:";
            this.lblbrand.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtlocation
            // 
            this.txtlocation.BorderRadius = 10;
            this.txtlocation.BorderThickness = 2;
            this.txtlocation.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtlocation.DefaultText = "";
            this.txtlocation.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtlocation.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtlocation.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtlocation.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtlocation.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtlocation.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtlocation.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtlocation.Location = new System.Drawing.Point(348, 313);
            this.txtlocation.Name = "txtlocation";
            this.txtlocation.PasswordChar = '\0';
            this.txtlocation.PlaceholderText = "";
            this.txtlocation.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtlocation.SelectedText = "";
            this.txtlocation.Size = new System.Drawing.Size(200, 36);
            this.txtlocation.TabIndex = 7;
            // 
            // lblMileage
            // 
            this.lblMileage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMileage.ForeColor = System.Drawing.Color.Gray;
            this.lblMileage.Location = new System.Drawing.Point(554, 356);
            this.lblMileage.Name = "lblMileage";
            this.lblMileage.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblMileage.Size = new System.Drawing.Size(103, 35);
            this.lblMileage.TabIndex = 14;
            this.lblMileage.Text = "کارکرد:";
            this.lblMileage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMileage
            // 
            this.txtMileage.BorderRadius = 10;
            this.txtMileage.BorderThickness = 2;
            this.txtMileage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMileage.DefaultText = "";
            this.txtMileage.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMileage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMileage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMileage.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMileage.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMileage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMileage.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMileage.Location = new System.Drawing.Point(348, 355);
            this.txtMileage.Name = "txtMileage";
            this.txtMileage.PasswordChar = '\0';
            this.txtMileage.PlaceholderText = "";
            this.txtMileage.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtMileage.SelectedText = "";
            this.txtMileage.Size = new System.Drawing.Size(200, 36);
            this.txtMileage.TabIndex = 8;
            // 
            // lblprice
            // 
            this.lblprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprice.ForeColor = System.Drawing.Color.Gray;
            this.lblprice.Location = new System.Drawing.Point(554, 397);
            this.lblprice.Name = "lblprice";
            this.lblprice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblprice.Size = new System.Drawing.Size(103, 35);
            this.lblprice.TabIndex = 14;
            this.lblprice.Text = "قیمت:";
            this.lblprice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtprice
            // 
            this.txtprice.BorderRadius = 10;
            this.txtprice.BorderThickness = 2;
            this.txtprice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtprice.DefaultText = "";
            this.txtprice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtprice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtprice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtprice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtprice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtprice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtprice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtprice.Location = new System.Drawing.Point(348, 397);
            this.txtprice.Name = "txtprice";
            this.txtprice.PasswordChar = '\0';
            this.txtprice.PlaceholderText = "";
            this.txtprice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtprice.SelectedText = "";
            this.txtprice.Size = new System.Drawing.Size(200, 36);
            this.txtprice.TabIndex = 9;
            // 
            // btnImage
            // 
            this.btnImage.BorderRadius = 10;
            this.btnImage.BorderThickness = 2;
            this.btnImage.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnImage.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnImage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnImage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnImage.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnImage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnImage.ForeColor = System.Drawing.Color.White;
            this.btnImage.Location = new System.Drawing.Point(78, 272);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(180, 45);
            this.btnImage.TabIndex = 10;
            this.btnImage.Text = "تغییر تصویر";
            this.btnImage.Click += new System.EventHandler(this.btnImage_Click);
            // 
            // lblcolor
            // 
            this.lblcolor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcolor.ForeColor = System.Drawing.Color.Gray;
            this.lblcolor.Location = new System.Drawing.Point(554, 188);
            this.lblcolor.Name = "lblcolor";
            this.lblcolor.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblcolor.Size = new System.Drawing.Size(103, 35);
            this.lblcolor.TabIndex = 14;
            this.lblcolor.Text = "رنگ:";
            this.lblcolor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtcolor
            // 
            this.txtcolor.BorderRadius = 10;
            this.txtcolor.BorderThickness = 2;
            this.txtcolor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcolor.DefaultText = "";
            this.txtcolor.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtcolor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtcolor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtcolor.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtcolor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtcolor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtcolor.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtcolor.Location = new System.Drawing.Point(348, 187);
            this.txtcolor.Name = "txtcolor";
            this.txtcolor.PasswordChar = '\0';
            this.txtcolor.PlaceholderText = "";
            this.txtcolor.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtcolor.SelectedText = "";
            this.txtcolor.Size = new System.Drawing.Size(200, 36);
            this.txtcolor.TabIndex = 4;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(248, 7);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(154, 40);
            this.guna2HtmlLabel1.TabIndex = 35;
            this.guna2HtmlLabel1.Text = "آگهی تنظیمات";
            this.guna2HtmlLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // EditCarForm
            // 
            this.ClientSize = new System.Drawing.Size(665, 515);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.btnImage);
            this.Controls.Add(this.Closebtn);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.txtMileage);
            this.Controls.Add(this.txtlocation);
            this.Controls.Add(this.txtcoment);
            this.Controls.Add(this.txtcolor);
            this.Controls.Add(this.txtstatecar);
            this.Controls.Add(this.txtCarModel);
            this.Controls.Add(this.lblprice);
            this.Controls.Add(this.txtbrand);
            this.Controls.Add(this.lblMileage);
            this.Controls.Add(this.txtCarName);
            this.Controls.Add(this.lblbrand);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.lblcoment);
            this.Controls.Add(this.lblcolor);
            this.Controls.Add(this.lblCarModel);
            this.Controls.Add(this.lblstatecar);
            this.Controls.Add(this.lblCarName);
            this.Controls.Add(this.guna2PictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditCarForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.EditCarForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

      

    
       
    
        private void guna2Button1_Click(object sender, EventArgs e)
        {

            // کد ویرایش آگهی در اینجا
            string connectionString = @"Server=Localhost;Database=RentingCARDB;Integrated Security=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
              
                string query = "UPDATE Cars SET CarsName = @CarsName, brand = @brand, YearOfProduction = @YearOfProduction, Color = @Color ,  StateOfCar = @StateOfCar , Description = @Description , Location = @Location , CarOperation = @CarOperation ,PriceDay=@PriceDay WHERE Cars_ID = @Cars_ID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@CarsName", txtCarName.Text);
                command.Parameters.AddWithValue("@brand", txtbrand.Text);
                command.Parameters.AddWithValue("@YearOfProduction", txtCarModel.Text);
                         
                command.Parameters.AddWithValue("@Color", txtcolor.Text);
                command.Parameters.AddWithValue("@StateOfCar", txtstatecar.Text);
                command.Parameters.AddWithValue("@Description", txtcoment.Text);
                command.Parameters.AddWithValue("@Location", txtlocation.Text);
                command.Parameters.AddWithValue("@CarOperation", txtMileage.Text);
                command.Parameters.AddWithValue("@PriceDay", txtprice.Text);
                command.Parameters.AddWithValue("@Cars_ID", CarId);  // شناسه آگهی برای به‌روزرسانی

                command.ExecuteNonQuery();  // اجرای دستورات به روز رسانی

                MessageBox.Show("آگهی شما با موفقیت ویرایش شد");

                connection.Close();
                this.Visible = false;
            }

          
        }
    
    

        private void Closebtn_Click(object sender, EventArgs e)
        {
            //// پاک کردن تکست باکس‌ها و بستن فرم
            // txtCarName.Clear();
            // txtbrand.Clear();
            // txtCarModel.Clear();
            // txtstatecar.Clear();
           // guna2PictureBox1.Image = null;  // تصویر را پاک می‌کنیم
            this.Close();
        }

        private void EditCarForm_Load(object sender, EventArgs e)
        {
            string connectionString = @"Server=Localhost;Database=RentingCARDB;Integrated Security=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Cars WHERE Cars_ID = @Cars_ID";  // دریافت اطلاعات آگهی از پایگاه داده
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Cars_ID", CarId);  // ارسال شناسه کاربر به دیتابیس

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    // بارگذاری اطلاعات آگهی به تکست باکس‌ها
                    txtCarName.Text = reader["CarsName"].ToString();
                    txtbrand.Text = reader["brand"].ToString();
                    txtCarModel.Text = reader["YearOfProduction"].ToString();
                    txtcolor.Text = reader["Color"].ToString();
                    txtstatecar.Text = reader["StateOfCar"].ToString();
                    txtcoment.Text = reader["Description"].ToString();
                    txtlocation.Text = reader["Location"].ToString();
                    txtMileage.Text = reader["CarOperation"].ToString();
                    txtprice.Text = reader["PriceDay"].ToString();
                   

                    // بارگذاری تصویر آگهی
                    byte[] imageBytes = reader["Image"] as byte[];
                    if (imageBytes != null)
                    {
                        using (MemoryStream ms = new MemoryStream(imageBytes))
                        {
                            guna2PictureBox1.Image = Image.FromStream(ms);
                        }
                    }
                }
                connection.Close();
            }
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            // باز کردن دیالوگ انتخاب فایل
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif",
                Title = "Select an Image"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // نمایش تصویر در PictureBox
                guna2PictureBox1.Image = Image.FromFile(openFileDialog.FileName);

                // ذخیره تصویر در پایگاه داده
                SaveImageToDatabase(openFileDialog.FileName);
            }

        }
        private void SaveImageToDatabase(string filePath)
        {
            try
            {
                // خواندن تصویر به صورت بایت آرایه
                byte[] imageBytes = File.ReadAllBytes(filePath);
                int loggedInUserId = GetLoggedInUserId();

                if (loggedInUserId == -1)
                {
                    MessageBox.Show("لطفاً وارد حساب خود شوید");
                    return;
                }
                // اتصال به پایگاه داده
                string connectionString = @"Server=Localhost;Database=RentingCARDB;Integrated Security=True;";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // دستور SQL برای درج داده
                    string query = "UPDATE Cars SET Image=@Image WHERE UserId = @UserId AND Cars_ID=@Cars_ID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Image", imageBytes);
                        command.Parameters.AddWithValue("@UserId", loggedInUserId);
                        command.Parameters.AddWithValue("@Cars_ID", CarId);
               
                        command.ExecuteNonQuery();
                    }

                }



            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        private int GetLoggedInUserId()
        {
            var userSession = UserSession.LoadUserSession(); // فرض می‌کنیم که این متد شناسه کاربر را از سشن بارگذاری می‌کند
            return userSession?.UserId ?? -1; // اگر سشن خالی بود، مقدار -1 بازگشت داده می‌شود
        }
    }
    
}
