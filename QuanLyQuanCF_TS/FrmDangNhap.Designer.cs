﻿namespace QuanLyQuanCF_TS
{
    partial class FrmDangNhap
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
            this.mDangNhap = new MetroFramework.Controls.MetroPanel();
            this.lblThongTin1 = new MetroFramework.Controls.MetroLabel();
            this.lblThongTin2 = new MetroFramework.Controls.MetroLabel();
            this.btnDangNhap = new MetroFramework.Controls.MetroButton();
            this.txtMatKhau = new MetroFramework.Controls.MetroTextBox();
            this.cmbNhanVien = new MetroFramework.Controls.MetroComboBox();
            this.lblMatKhau = new MetroFramework.Controls.MetroLabel();
            this.lblTenDangNhap = new MetroFramework.Controls.MetroLabel();
            this.mDangNhap.SuspendLayout();
            this.SuspendLayout();
            // 
            // mDangNhap
            // 
            this.mDangNhap.Controls.Add(this.lblThongTin1);
            this.mDangNhap.Controls.Add(this.lblThongTin2);
            this.mDangNhap.Controls.Add(this.btnDangNhap);
            this.mDangNhap.Controls.Add(this.txtMatKhau);
            this.mDangNhap.Controls.Add(this.cmbNhanVien);
            this.mDangNhap.Controls.Add(this.lblMatKhau);
            this.mDangNhap.Controls.Add(this.lblTenDangNhap);
            this.mDangNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mDangNhap.HorizontalScrollbarBarColor = true;
            this.mDangNhap.HorizontalScrollbarHighlightOnWheel = false;
            this.mDangNhap.HorizontalScrollbarSize = 10;
            this.mDangNhap.Location = new System.Drawing.Point(20, 60);
            this.mDangNhap.Name = "mDangNhap";
            this.mDangNhap.Size = new System.Drawing.Size(760, 370);
            this.mDangNhap.TabIndex = 0;
            this.mDangNhap.VerticalScrollbarBarColor = true;
            this.mDangNhap.VerticalScrollbarHighlightOnWheel = false;
            this.mDangNhap.VerticalScrollbarSize = 10;
            // 
            // lblThongTin1
            // 
            this.lblThongTin1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblThongTin1.Location = new System.Drawing.Point(0, 324);
            this.lblThongTin1.Name = "lblThongTin1";
            this.lblThongTin1.Size = new System.Drawing.Size(760, 23);
            this.lblThongTin1.TabIndex = 9;
            this.lblThongTin1.Text = "Đồ án môn học Lập Trình Windows Nâng Cao";
            this.lblThongTin1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblThongTin2
            // 
            this.lblThongTin2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblThongTin2.Location = new System.Drawing.Point(0, 347);
            this.lblThongTin2.Name = "lblThongTin2";
            this.lblThongTin2.Size = new System.Drawing.Size(760, 23);
            this.lblThongTin2.TabIndex = 8;
            this.lblThongTin2.Text = "Lớp CĐTH 16 PMB - Nhóm 15";
            this.lblThongTin2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDangNhap.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnDangNhap.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnDangNhap.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDangNhap.Location = new System.Drawing.Point(462, 174);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(105, 31);
            this.btnDangNhap.TabIndex = 6;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.UseSelectable = true;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.txtMatKhau.CustomButton.Image = null;
            this.txtMatKhau.CustomButton.Location = new System.Drawing.Point(279, 1);
            this.txtMatKhau.CustomButton.Name = "";
            this.txtMatKhau.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtMatKhau.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMatKhau.CustomButton.TabIndex = 1;
            this.txtMatKhau.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMatKhau.CustomButton.UseSelectable = true;
            this.txtMatKhau.CustomButton.Visible = false;
            this.txtMatKhau.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtMatKhau.Lines = new string[0];
            this.txtMatKhau.Location = new System.Drawing.Point(266, 145);
            this.txtMatKhau.MaxLength = 32767;
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '●';
            this.txtMatKhau.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMatKhau.SelectedText = "";
            this.txtMatKhau.SelectionLength = 0;
            this.txtMatKhau.SelectionStart = 0;
            this.txtMatKhau.ShortcutsEnabled = true;
            this.txtMatKhau.Size = new System.Drawing.Size(301, 23);
            this.txtMatKhau.TabIndex = 5;
            this.txtMatKhau.UseSelectable = true;
            this.txtMatKhau.UseSystemPasswordChar = true;
            this.txtMatKhau.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMatKhau.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtMatKhau.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMatKhau_KeyPress);
            // 
            // cmbNhanVien
            // 
            this.cmbNhanVien.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbNhanVien.FormattingEnabled = true;
            this.cmbNhanVien.ItemHeight = 23;
            this.cmbNhanVien.Location = new System.Drawing.Point(266, 105);
            this.cmbNhanVien.Name = "cmbNhanVien";
            this.cmbNhanVien.Size = new System.Drawing.Size(301, 29);
            this.cmbNhanVien.TabIndex = 4;
            this.cmbNhanVien.UseSelectable = true;
            // 
            // lblMatKhau
            // 
            this.lblMatKhau.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMatKhau.AutoSize = true;
            this.lblMatKhau.Location = new System.Drawing.Point(184, 145);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new System.Drawing.Size(63, 19);
            this.lblMatKhau.TabIndex = 3;
            this.lblMatKhau.Text = "Mật khẩu";
            // 
            // lblTenDangNhap
            // 
            this.lblTenDangNhap.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTenDangNhap.AutoSize = true;
            this.lblTenDangNhap.Location = new System.Drawing.Point(184, 111);
            this.lblTenDangNhap.Name = "lblTenDangNhap";
            this.lblTenDangNhap.Size = new System.Drawing.Size(67, 19);
            this.lblTenDangNhap.TabIndex = 2;
            this.lblTenDangNhap.Text = "Nhân viên";
            // 
            // FrmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.mDangNhap);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDangNhap";
            this.Resizable = false;
            this.ShowIcon = false;
            this.Text = "Đăng nhập";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmDangNhap_FormClosed);
            this.Load += new System.EventHandler(this.FrmDangNhap_Load);
            this.mDangNhap.ResumeLayout(false);
            this.mDangNhap.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel mDangNhap;
        private MetroFramework.Controls.MetroLabel lblTenDangNhap;
        private MetroFramework.Controls.MetroButton btnDangNhap;
        private MetroFramework.Controls.MetroTextBox txtMatKhau;
        private MetroFramework.Controls.MetroComboBox cmbNhanVien;
        private MetroFramework.Controls.MetroLabel lblMatKhau;
        private MetroFramework.Controls.MetroLabel lblThongTin1;
        private MetroFramework.Controls.MetroLabel lblThongTin2;
    }
}