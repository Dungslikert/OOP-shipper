﻿namespace QuanLyShipper.formshipper.Forms
{
    partial class frm_TaiKhoan
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_doimatkhau = new QuanLyShipper.RJControls.RJLogin();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DiaChi_tb = new QuanLyShipper.RJControls.RJButton();
            this.label6 = new System.Windows.Forms.Label();
            this.email_tb = new QuanLyShipper.RJControls.RJButton();
            this.label5 = new System.Windows.Forms.Label();
            this.CCCD_tb = new QuanLyShipper.RJControls.RJButton();
            this.label4 = new System.Windows.Forms.Label();
            this.Sdt_tb = new QuanLyShipper.RJControls.RJButton();
            this.label3 = new System.Windows.Forms.Label();
            this.Ten_tb = new QuanLyShipper.RJControls.RJButton();
            this.label2 = new System.Windows.Forms.Label();
            this.TenTK_tb = new QuanLyShipper.RJControls.RJButton();
            this.label1 = new System.Windows.Forms.Label();
<<<<<<< HEAD
            this.btn_capnhat = new QuanLyShipper.RJControls.RJLogin();
=======
            this.btn_capNhat = new QuanLyShipper.RJControls.RJLogin();
>>>>>>> 27e1d6ae0340cbc2e2ace3fc978dfda8fe64a13f
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(107)))), ((int)(((byte)(225)))));
<<<<<<< HEAD
            this.panel1.Controls.Add(this.btn_capnhat);
=======
            this.panel1.Controls.Add(this.btn_capNhat);
>>>>>>> 27e1d6ae0340cbc2e2ace3fc978dfda8fe64a13f
            this.panel1.Controls.Add(this.btn_doimatkhau);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(456, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(234, 423);
            this.panel1.TabIndex = 0;
            // 
            // btn_doimatkhau
            // 
            this.btn_doimatkhau.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_doimatkhau.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_doimatkhau.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.btn_doimatkhau.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_doimatkhau.BorderRadius = 10;
            this.btn_doimatkhau.BorderSize = 0;
            this.btn_doimatkhau.FlatAppearance.BorderSize = 0;
            this.btn_doimatkhau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_doimatkhau.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_doimatkhau.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_doimatkhau.Location = new System.Drawing.Point(46, 204);
            this.btn_doimatkhau.Name = "btn_doimatkhau";
            this.btn_doimatkhau.Size = new System.Drawing.Size(150, 40);
            this.btn_doimatkhau.TabIndex = 1;
            this.btn_doimatkhau.Text = "Đổi mật khẩu";
            this.btn_doimatkhau.TextColor = System.Drawing.SystemColors.Control;
            this.btn_doimatkhau.UseVisualStyleBackColor = false;
            this.btn_doimatkhau.Click += new System.EventHandler(this.btn_nhandon_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackgroundImage = global::QuanLyShipper.Properties.Resources.Avatar;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(59, 37);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(123, 125);
            this.panel3.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumPurple;
            this.panel2.Controls.Add(this.DiaChi_tb);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.email_tb);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.CCCD_tb);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.Sdt_tb);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.Ten_tb);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.TenTK_tb);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.ForeColor = System.Drawing.SystemColors.Control;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(456, 423);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // DiaChi_tb
            // 
<<<<<<< HEAD
            this.rjButton6.BackColor = System.Drawing.SystemColors.Window;
            this.rjButton6.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton6.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjButton6.BorderRadius = 15;
            this.rjButton6.BorderSize = 2;
            this.rjButton6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjButton6.Location = new System.Drawing.Point(167, 353);
            this.rjButton6.Margin = new System.Windows.Forms.Padding(4);
            this.rjButton6.Multiline = false;
            this.rjButton6.Name = "rjButton6";
            this.rjButton6.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjButton6.PasswordChar = false;
            this.rjButton6.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjButton6.PlaceholderText = "";
            this.rjButton6.Size = new System.Drawing.Size(260, 31);
            this.rjButton6.TabIndex = 11;
            this.rjButton6.Texts = "";
            this.rjButton6.UnderlinedStyle = false;
=======
            this.DiaChi_tb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DiaChi_tb.BackColor = System.Drawing.SystemColors.Window;
            this.DiaChi_tb.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.DiaChi_tb.BorderFocusColor = System.Drawing.Color.HotPink;
            this.DiaChi_tb.BorderRadius = 15;
            this.DiaChi_tb.BorderSize = 2;
            this.DiaChi_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiaChi_tb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DiaChi_tb.Location = new System.Drawing.Point(167, 353);
            this.DiaChi_tb.Margin = new System.Windows.Forms.Padding(4);
            this.DiaChi_tb.Multiline = false;
            this.DiaChi_tb.Name = "DiaChi_tb";
            this.DiaChi_tb.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.DiaChi_tb.PasswordChar = false;
            this.DiaChi_tb.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.DiaChi_tb.PlaceholderText = "";
            this.DiaChi_tb.Size = new System.Drawing.Size(260, 31);
            this.DiaChi_tb.TabIndex = 11;
            this.DiaChi_tb.Texts = "";
            this.DiaChi_tb.UnderlinedStyle = false;
>>>>>>> 27e1d6ae0340cbc2e2ace3fc978dfda8fe64a13f
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 353);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 21);
            this.label6.TabIndex = 10;
            this.label6.Text = "Địa chỉ :";
            // 
            // email_tb
            // 
<<<<<<< HEAD
            this.rjButton5.BackColor = System.Drawing.SystemColors.Window;
            this.rjButton5.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton5.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjButton5.BorderRadius = 15;
            this.rjButton5.BorderSize = 2;
            this.rjButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjButton5.Location = new System.Drawing.Point(167, 289);
            this.rjButton5.Margin = new System.Windows.Forms.Padding(4);
            this.rjButton5.Multiline = false;
            this.rjButton5.Name = "rjButton5";
            this.rjButton5.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjButton5.PasswordChar = false;
            this.rjButton5.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjButton5.PlaceholderText = "";
            this.rjButton5.Size = new System.Drawing.Size(260, 31);
            this.rjButton5.TabIndex = 9;
            this.rjButton5.Texts = "";
            this.rjButton5.UnderlinedStyle = false;
=======
            this.email_tb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.email_tb.BackColor = System.Drawing.SystemColors.Window;
            this.email_tb.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.email_tb.BorderFocusColor = System.Drawing.Color.HotPink;
            this.email_tb.BorderRadius = 15;
            this.email_tb.BorderSize = 2;
            this.email_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_tb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.email_tb.Location = new System.Drawing.Point(167, 289);
            this.email_tb.Margin = new System.Windows.Forms.Padding(4);
            this.email_tb.Multiline = false;
            this.email_tb.Name = "email_tb";
            this.email_tb.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.email_tb.PasswordChar = false;
            this.email_tb.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.email_tb.PlaceholderText = "";
            this.email_tb.Size = new System.Drawing.Size(260, 31);
            this.email_tb.TabIndex = 9;
            this.email_tb.Texts = "";
            this.email_tb.UnderlinedStyle = false;
>>>>>>> 27e1d6ae0340cbc2e2ace3fc978dfda8fe64a13f
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "Email :";
            // 
            // CCCD_tb
            // 
<<<<<<< HEAD
            this.rjButton4.BackColor = System.Drawing.SystemColors.Window;
            this.rjButton4.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton4.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjButton4.BorderRadius = 15;
            this.rjButton4.BorderSize = 2;
            this.rjButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjButton4.Location = new System.Drawing.Point(167, 223);
            this.rjButton4.Margin = new System.Windows.Forms.Padding(4);
            this.rjButton4.Multiline = false;
            this.rjButton4.Name = "rjButton4";
            this.rjButton4.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjButton4.PasswordChar = false;
            this.rjButton4.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjButton4.PlaceholderText = "";
            this.rjButton4.Size = new System.Drawing.Size(260, 31);
            this.rjButton4.TabIndex = 7;
            this.rjButton4.Texts = "";
            this.rjButton4.UnderlinedStyle = false;
=======
            this.CCCD_tb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CCCD_tb.BackColor = System.Drawing.SystemColors.Window;
            this.CCCD_tb.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.CCCD_tb.BorderFocusColor = System.Drawing.Color.HotPink;
            this.CCCD_tb.BorderRadius = 15;
            this.CCCD_tb.BorderSize = 2;
            this.CCCD_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CCCD_tb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CCCD_tb.Location = new System.Drawing.Point(167, 223);
            this.CCCD_tb.Margin = new System.Windows.Forms.Padding(4);
            this.CCCD_tb.Multiline = false;
            this.CCCD_tb.Name = "CCCD_tb";
            this.CCCD_tb.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.CCCD_tb.PasswordChar = false;
            this.CCCD_tb.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.CCCD_tb.PlaceholderText = "";
            this.CCCD_tb.Size = new System.Drawing.Size(260, 31);
            this.CCCD_tb.TabIndex = 7;
            this.CCCD_tb.Texts = "";
            this.CCCD_tb.UnderlinedStyle = false;
>>>>>>> 27e1d6ae0340cbc2e2ace3fc978dfda8fe64a13f
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "CCCD :";
            // 
            // Sdt_tb
            // 
<<<<<<< HEAD
            this.rjButton3.BackColor = System.Drawing.SystemColors.Window;
            this.rjButton3.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton3.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjButton3.BorderRadius = 15;
            this.rjButton3.BorderSize = 2;
            this.rjButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjButton3.Location = new System.Drawing.Point(167, 159);
            this.rjButton3.Margin = new System.Windows.Forms.Padding(4);
            this.rjButton3.Multiline = false;
            this.rjButton3.Name = "rjButton3";
            this.rjButton3.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjButton3.PasswordChar = false;
            this.rjButton3.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjButton3.PlaceholderText = "";
            this.rjButton3.Size = new System.Drawing.Size(260, 31);
            this.rjButton3.TabIndex = 5;
            this.rjButton3.Texts = "";
            this.rjButton3.UnderlinedStyle = false;
=======
            this.Sdt_tb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Sdt_tb.BackColor = System.Drawing.SystemColors.Window;
            this.Sdt_tb.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.Sdt_tb.BorderFocusColor = System.Drawing.Color.HotPink;
            this.Sdt_tb.BorderRadius = 15;
            this.Sdt_tb.BorderSize = 2;
            this.Sdt_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sdt_tb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Sdt_tb.Location = new System.Drawing.Point(167, 159);
            this.Sdt_tb.Margin = new System.Windows.Forms.Padding(4);
            this.Sdt_tb.Multiline = false;
            this.Sdt_tb.Name = "Sdt_tb";
            this.Sdt_tb.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.Sdt_tb.PasswordChar = false;
            this.Sdt_tb.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.Sdt_tb.PlaceholderText = "";
            this.Sdt_tb.Size = new System.Drawing.Size(260, 31);
            this.Sdt_tb.TabIndex = 5;
            this.Sdt_tb.Texts = "";
            this.Sdt_tb.UnderlinedStyle = false;
>>>>>>> 27e1d6ae0340cbc2e2ace3fc978dfda8fe64a13f
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "SĐT :";
            // 
            // Ten_tb
            // 
<<<<<<< HEAD
            this.rjButton2.BackColor = System.Drawing.SystemColors.Window;
            this.rjButton2.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton2.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjButton2.BorderRadius = 15;
            this.rjButton2.BorderSize = 2;
            this.rjButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjButton2.Location = new System.Drawing.Point(167, 98);
            this.rjButton2.Margin = new System.Windows.Forms.Padding(4);
            this.rjButton2.Multiline = false;
            this.rjButton2.Name = "rjButton2";
            this.rjButton2.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjButton2.PasswordChar = false;
            this.rjButton2.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjButton2.PlaceholderText = "";
            this.rjButton2.Size = new System.Drawing.Size(260, 31);
            this.rjButton2.TabIndex = 3;
            this.rjButton2.Texts = "";
            this.rjButton2.UnderlinedStyle = false;
=======
            this.Ten_tb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Ten_tb.BackColor = System.Drawing.SystemColors.Window;
            this.Ten_tb.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.Ten_tb.BorderFocusColor = System.Drawing.Color.HotPink;
            this.Ten_tb.BorderRadius = 15;
            this.Ten_tb.BorderSize = 2;
            this.Ten_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ten_tb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Ten_tb.Location = new System.Drawing.Point(167, 98);
            this.Ten_tb.Margin = new System.Windows.Forms.Padding(4);
            this.Ten_tb.Multiline = false;
            this.Ten_tb.Name = "Ten_tb";
            this.Ten_tb.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.Ten_tb.PasswordChar = false;
            this.Ten_tb.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.Ten_tb.PlaceholderText = "";
            this.Ten_tb.Size = new System.Drawing.Size(260, 31);
            this.Ten_tb.TabIndex = 3;
            this.Ten_tb.Texts = "";
            this.Ten_tb.UnderlinedStyle = false;
>>>>>>> 27e1d6ae0340cbc2e2ace3fc978dfda8fe64a13f
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 98);
            this.label2.Name = "label2";
<<<<<<< HEAD
            this.label2.Size = new System.Drawing.Size(38, 21);
=======
            this.label2.Size = new System.Drawing.Size(45, 21);
>>>>>>> 27e1d6ae0340cbc2e2ace3fc978dfda8fe64a13f
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên :";
            // 
            // TenTK_tb
            // 
<<<<<<< HEAD
            this.rjButton1.BackColor = System.Drawing.SystemColors.Window;
            this.rjButton1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjButton1.BorderRadius = 15;
            this.rjButton1.BorderSize = 2;
            this.rjButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjButton1.Location = new System.Drawing.Point(167, 37);
            this.rjButton1.Margin = new System.Windows.Forms.Padding(4);
            this.rjButton1.Multiline = false;
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjButton1.PasswordChar = false;
            this.rjButton1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjButton1.PlaceholderText = "";
            this.rjButton1.Size = new System.Drawing.Size(260, 31);
            this.rjButton1.TabIndex = 1;
            this.rjButton1.Texts = "";
            this.rjButton1.UnderlinedStyle = false;
=======
            this.TenTK_tb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TenTK_tb.BackColor = System.Drawing.SystemColors.Window;
            this.TenTK_tb.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.TenTK_tb.BorderFocusColor = System.Drawing.Color.HotPink;
            this.TenTK_tb.BorderRadius = 15;
            this.TenTK_tb.BorderSize = 2;
            this.TenTK_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenTK_tb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TenTK_tb.Location = new System.Drawing.Point(167, 37);
            this.TenTK_tb.Margin = new System.Windows.Forms.Padding(4);
            this.TenTK_tb.Multiline = false;
            this.TenTK_tb.Name = "TenTK_tb";
            this.TenTK_tb.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.TenTK_tb.PasswordChar = false;
            this.TenTK_tb.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TenTK_tb.PlaceholderText = "";
            this.TenTK_tb.Size = new System.Drawing.Size(260, 31);
            this.TenTK_tb.TabIndex = 1;
            this.TenTK_tb.Texts = "";
            this.TenTK_tb.UnderlinedStyle = false;
>>>>>>> 27e1d6ae0340cbc2e2ace3fc978dfda8fe64a13f
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên tài khoản :";
            // 
<<<<<<< HEAD
            // btn_capnhat
            // 
            this.btn_capnhat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_capnhat.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_capnhat.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.btn_capnhat.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_capnhat.BorderRadius = 10;
            this.btn_capnhat.BorderSize = 0;
            this.btn_capnhat.FlatAppearance.BorderSize = 0;
            this.btn_capnhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_capnhat.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_capnhat.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_capnhat.Location = new System.Drawing.Point(46, 353);
            this.btn_capnhat.Name = "btn_capnhat";
            this.btn_capnhat.Size = new System.Drawing.Size(150, 40);
            this.btn_capnhat.TabIndex = 2;
            this.btn_capnhat.Text = "Cập nhật";
            this.btn_capnhat.TextColor = System.Drawing.SystemColors.Control;
            this.btn_capnhat.UseVisualStyleBackColor = false;
=======
            // btn_capNhat
            // 
            this.btn_capNhat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_capNhat.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_capNhat.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.btn_capNhat.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_capNhat.BorderRadius = 10;
            this.btn_capNhat.BorderSize = 0;
            this.btn_capNhat.FlatAppearance.BorderSize = 0;
            this.btn_capNhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_capNhat.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_capNhat.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_capNhat.Location = new System.Drawing.Point(46, 289);
            this.btn_capNhat.Name = "btn_capNhat";
            this.btn_capNhat.Size = new System.Drawing.Size(150, 40);
            this.btn_capNhat.TabIndex = 1;
            this.btn_capNhat.Text = "Cập nhật thông tin";
            this.btn_capNhat.TextColor = System.Drawing.SystemColors.Control;
            this.btn_capNhat.UseVisualStyleBackColor = false;
            this.btn_capNhat.Click += new System.EventHandler(this.btn_nhandon_Click);
>>>>>>> 27e1d6ae0340cbc2e2ace3fc978dfda8fe64a13f
            // 
            // frm_TaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 423);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frm_TaiKhoan";
            this.Text = "Tài khoản";
            this.Load += new System.EventHandler(this.frm_TaiKhoan_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private RJControls.RJLogin btn_doimatkhau;
        private System.Windows.Forms.Label label1;
        private RJControls.RJButton DiaChi_tb;
        private System.Windows.Forms.Label label6;
        private RJControls.RJButton email_tb;
        private System.Windows.Forms.Label label5;
        private RJControls.RJButton CCCD_tb;
        private System.Windows.Forms.Label label4;
        private RJControls.RJButton Sdt_tb;
        private System.Windows.Forms.Label label3;
        private RJControls.RJButton Ten_tb;
        private System.Windows.Forms.Label label2;
<<<<<<< HEAD
        private RJControls.RJButton rjButton1;
        private RJControls.RJLogin btn_capnhat;
=======
        private RJControls.RJButton TenTK_tb;
        private RJControls.RJLogin btn_capNhat;
>>>>>>> 27e1d6ae0340cbc2e2ace3fc978dfda8fe64a13f
    }
}