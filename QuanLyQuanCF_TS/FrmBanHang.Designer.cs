﻿namespace QuanLyQuanCF_TS
{
    partial class FrmBanHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panelMenu = new MetroFramework.Controls.MetroPanel();
            this.radMenuTopping = new MaterialSkin.Controls.MaterialRadioButton();
            this.radMenuMon = new MaterialSkin.Controls.MaterialRadioButton();
            this.lsvMenu = new System.Windows.Forms.ListView();
            this.colMenuTenMon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMenuGiaTien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imlMon = new System.Windows.Forms.ImageList(this.components);
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.txtTimKiem = new MetroFramework.Controls.MetroTextBox();
            this.panelHoaDon = new MetroFramework.Controls.MetroPanel();
            this.panelThanhToan = new MetroFramework.Controls.MetroPanel();
            this.lblThanhTien = new MetroFramework.Controls.MetroLabel();
            this.lblTong = new MetroFramework.Controls.MetroLabel();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.panelLayout = new MetroFramework.Controls.MetroPanel();
            this.panelLoai = new MetroFramework.Controls.MetroPanel();
            this.colTenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelHoaDon.SuspendLayout();
            this.panelThanhToan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.panelLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panelMenu);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panelHoaDon);
            this.splitContainer1.Panel2MinSize = 350;
            this.splitContainer1.Size = new System.Drawing.Size(954, 341);
            this.splitContainer1.SplitterDistance = 515;
            this.splitContainer1.TabIndex = 0;
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.radMenuTopping);
            this.panelMenu.Controls.Add(this.radMenuMon);
            this.panelMenu.Controls.Add(this.lsvMenu);
            this.panelMenu.Controls.Add(this.metroLabel1);
            this.panelMenu.Controls.Add(this.btnQuayLai);
            this.panelMenu.Controls.Add(this.txtTimKiem);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMenu.HorizontalScrollbarBarColor = true;
            this.panelMenu.HorizontalScrollbarHighlightOnWheel = false;
            this.panelMenu.HorizontalScrollbarSize = 10;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(515, 341);
            this.panelMenu.TabIndex = 1;
            this.panelMenu.VerticalScrollbarBarColor = true;
            this.panelMenu.VerticalScrollbarHighlightOnWheel = false;
            this.panelMenu.VerticalScrollbarSize = 10;
            // 
            // radMenuTopping
            // 
            this.radMenuTopping.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radMenuTopping.AutoSize = true;
            this.radMenuTopping.Depth = 0;
            this.radMenuTopping.Enabled = false;
            this.radMenuTopping.Font = new System.Drawing.Font("Roboto", 10F);
            this.radMenuTopping.Location = new System.Drawing.Point(398, 4);
            this.radMenuTopping.Margin = new System.Windows.Forms.Padding(0);
            this.radMenuTopping.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radMenuTopping.MouseState = MaterialSkin.MouseState.HOVER;
            this.radMenuTopping.Name = "radMenuTopping";
            this.radMenuTopping.Ripple = true;
            this.radMenuTopping.Size = new System.Drawing.Size(114, 30);
            this.radMenuTopping.TabIndex = 7;
            this.radMenuTopping.Text = "Menu topping";
            this.radMenuTopping.UseVisualStyleBackColor = true;
            this.radMenuTopping.CheckedChanged += new System.EventHandler(this.radMenuTopping_CheckedChanged);
            // 
            // radMenuMon
            // 
            this.radMenuMon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radMenuMon.AutoSize = true;
            this.radMenuMon.Checked = true;
            this.radMenuMon.Depth = 0;
            this.radMenuMon.Font = new System.Drawing.Font("Roboto", 10F);
            this.radMenuMon.Location = new System.Drawing.Point(300, 4);
            this.radMenuMon.Margin = new System.Windows.Forms.Padding(0);
            this.radMenuMon.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radMenuMon.MouseState = MaterialSkin.MouseState.HOVER;
            this.radMenuMon.Name = "radMenuMon";
            this.radMenuMon.Ripple = true;
            this.radMenuMon.Size = new System.Drawing.Size(94, 30);
            this.radMenuMon.TabIndex = 6;
            this.radMenuMon.TabStop = true;
            this.radMenuMon.Text = "Menu món";
            this.radMenuMon.UseVisualStyleBackColor = true;
            this.radMenuMon.CheckedChanged += new System.EventHandler(this.radMenuMon_CheckedChanged);
            // 
            // lsvMenu
            // 
            this.lsvMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsvMenu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMenuTenMon,
            this.colMenuGiaTien});
            this.lsvMenu.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvMenu.FullRowSelect = true;
            this.lsvMenu.GridLines = true;
            this.lsvMenu.LargeImageList = this.imlMon;
            this.lsvMenu.Location = new System.Drawing.Point(3, 37);
            this.lsvMenu.MultiSelect = false;
            this.lsvMenu.Name = "lsvMenu";
            this.lsvMenu.Size = new System.Drawing.Size(509, 301);
            this.lsvMenu.TabIndex = 5;
            this.lsvMenu.TileSize = new System.Drawing.Size(270, 100);
            this.lsvMenu.UseCompatibleStateImageBehavior = false;
            this.lsvMenu.View = System.Windows.Forms.View.Tile;
            this.lsvMenu.Click += new System.EventHandler(this.lsvMon_Click);
            // 
            // colMenuTenMon
            // 
            this.colMenuTenMon.Text = "Tên món";
            // 
            // colMenuGiaTien
            // 
            this.colMenuGiaTien.Text = "Giá tiền";
            // 
            // imlMon
            // 
            this.imlMon.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imlMon.ImageSize = new System.Drawing.Size(64, 64);
            this.imlMon.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(27, 9);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(63, 19);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Tìm kiếm";
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.BackgroundImage = global::QuanLyQuanCF_TS.Properties.Resources.back;
            this.btnQuayLai.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnQuayLai.FlatAppearance.BorderSize = 0;
            this.btnQuayLai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuayLai.Location = new System.Drawing.Point(3, 8);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(20, 20);
            this.btnQuayLai.TabIndex = 3;
            this.btnQuayLai.UseVisualStyleBackColor = true;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtTimKiem.CustomButton.Image = null;
            this.txtTimKiem.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.txtTimKiem.CustomButton.Name = "";
            this.txtTimKiem.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTimKiem.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTimKiem.CustomButton.TabIndex = 1;
            this.txtTimKiem.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTimKiem.CustomButton.UseSelectable = true;
            this.txtTimKiem.CustomButton.Visible = false;
            this.txtTimKiem.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtTimKiem.Lines = new string[0];
            this.txtTimKiem.Location = new System.Drawing.Point(96, 8);
            this.txtTimKiem.MaxLength = 32767;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.PasswordChar = '\0';
            this.txtTimKiem.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTimKiem.SelectedText = "";
            this.txtTimKiem.SelectionLength = 0;
            this.txtTimKiem.SelectionStart = 0;
            this.txtTimKiem.ShortcutsEnabled = true;
            this.txtTimKiem.Size = new System.Drawing.Size(200, 23);
            this.txtTimKiem.TabIndex = 2;
            this.txtTimKiem.UseSelectable = true;
            this.txtTimKiem.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTimKiem.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtTimKiem.Enter += new System.EventHandler(this.txtTimKiem_Enter);
            this.txtTimKiem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTimKiem_KeyPress);
            this.txtTimKiem.Leave += new System.EventHandler(this.txtTimKiem_Leave);
            // 
            // panelHoaDon
            // 
            this.panelHoaDon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelHoaDon.Controls.Add(this.panelThanhToan);
            this.panelHoaDon.Controls.Add(this.dgvHoaDon);
            this.panelHoaDon.HorizontalScrollbarBarColor = true;
            this.panelHoaDon.HorizontalScrollbarHighlightOnWheel = false;
            this.panelHoaDon.HorizontalScrollbarSize = 10;
            this.panelHoaDon.Location = new System.Drawing.Point(13, 0);
            this.panelHoaDon.Name = "panelHoaDon";
            this.panelHoaDon.Size = new System.Drawing.Size(422, 338);
            this.panelHoaDon.TabIndex = 0;
            this.panelHoaDon.VerticalScrollbarBarColor = true;
            this.panelHoaDon.VerticalScrollbarHighlightOnWheel = false;
            this.panelHoaDon.VerticalScrollbarSize = 10;
            // 
            // panelThanhToan
            // 
            this.panelThanhToan.Controls.Add(this.lblThanhTien);
            this.panelThanhToan.Controls.Add(this.lblTong);
            this.panelThanhToan.Controls.Add(this.btnThanhToan);
            this.panelThanhToan.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelThanhToan.HorizontalScrollbarBarColor = true;
            this.panelThanhToan.HorizontalScrollbarHighlightOnWheel = false;
            this.panelThanhToan.HorizontalScrollbarSize = 10;
            this.panelThanhToan.Location = new System.Drawing.Point(0, 226);
            this.panelThanhToan.Name = "panelThanhToan";
            this.panelThanhToan.Size = new System.Drawing.Size(422, 112);
            this.panelThanhToan.TabIndex = 8;
            this.panelThanhToan.VerticalScrollbarBarColor = true;
            this.panelThanhToan.VerticalScrollbarHighlightOnWheel = false;
            this.panelThanhToan.VerticalScrollbarSize = 10;
            // 
            // lblThanhTien
            // 
            this.lblThanhTien.AutoSize = true;
            this.lblThanhTien.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblThanhTien.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblThanhTien.Location = new System.Drawing.Point(3, 19);
            this.lblThanhTien.Name = "lblThanhTien";
            this.lblThanhTien.Size = new System.Drawing.Size(33, 25);
            this.lblThanhTien.TabIndex = 6;
            this.lblThanhTien.Text = "0d";
            // 
            // lblTong
            // 
            this.lblTong.AutoSize = true;
            this.lblTong.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblTong.Location = new System.Drawing.Point(3, 4);
            this.lblTong.Name = "lblTong";
            this.lblTong.Size = new System.Drawing.Size(33, 15);
            this.lblTong.TabIndex = 5;
            this.lblTong.Text = "Tổng";
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThanhToan.BackColor = System.Drawing.Color.LimeGreen;
            this.btnThanhToan.Enabled = false;
            this.btnThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThanhToan.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.ForeColor = System.Drawing.SystemColors.Window;
            this.btnThanhToan.Location = new System.Drawing.Point(3, 53);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(416, 56);
            this.btnThanhToan.TabIndex = 7;
            this.btnThanhToan.Text = "THANH TOÁN";
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.AllowUserToAddRows = false;
            this.dgvHoaDon.AllowUserToDeleteRows = false;
            this.dgvHoaDon.AllowUserToResizeRows = false;
            this.dgvHoaDon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHoaDon.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHoaDon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHoaDon.ColumnHeadersHeight = 50;
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTenMon,
            this.colSoLuong,
            this.colDonGia});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHoaDon.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvHoaDon.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvHoaDon.Location = new System.Drawing.Point(3, 8);
            this.dgvHoaDon.MultiSelect = false;
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.RowHeadersVisible = false;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvHoaDon.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvHoaDon.RowTemplate.Height = 50;
            this.dgvHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHoaDon.Size = new System.Drawing.Size(416, 212);
            this.dgvHoaDon.TabIndex = 4;
            this.dgvHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoaDon_CellClick);
            this.dgvHoaDon.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoaDon_CellValueChanged);
            this.dgvHoaDon.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvHoaDon_RowsAdded);
            this.dgvHoaDon.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvHoaDon_RowsRemoved);
            this.dgvHoaDon.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvHoaDon_KeyDown);
            // 
            // panelLayout
            // 
            this.panelLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelLayout.Controls.Add(this.splitContainer1);
            this.panelLayout.HorizontalScrollbarBarColor = true;
            this.panelLayout.HorizontalScrollbarHighlightOnWheel = false;
            this.panelLayout.HorizontalScrollbarSize = 10;
            this.panelLayout.Location = new System.Drawing.Point(23, 20);
            this.panelLayout.Name = "panelLayout";
            this.panelLayout.Size = new System.Drawing.Size(954, 341);
            this.panelLayout.TabIndex = 0;
            this.panelLayout.VerticalScrollbarBarColor = true;
            this.panelLayout.VerticalScrollbarHighlightOnWheel = false;
            this.panelLayout.VerticalScrollbarSize = 10;
            // 
            // panelLoai
            // 
            this.panelLoai.BackColor = System.Drawing.SystemColors.Control;
            this.panelLoai.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelLoai.HorizontalScrollbar = true;
            this.panelLoai.HorizontalScrollbarBarColor = false;
            this.panelLoai.HorizontalScrollbarHighlightOnWheel = false;
            this.panelLoai.HorizontalScrollbarSize = 10;
            this.panelLoai.Location = new System.Drawing.Point(20, 370);
            this.panelLoai.Name = "panelLoai";
            this.panelLoai.Size = new System.Drawing.Size(960, 60);
            this.panelLoai.TabIndex = 1;
            this.panelLoai.VerticalScrollbarBarColor = true;
            this.panelLoai.VerticalScrollbarHighlightOnWheel = false;
            this.panelLoai.VerticalScrollbarSize = 10;
            // 
            // colTenMon
            // 
            this.colTenMon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTenMon.HeaderText = "Tên món";
            this.colTenMon.Name = "colTenMon";
            this.colTenMon.ReadOnly = true;
            this.colTenMon.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colSoLuong
            // 
            this.colSoLuong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colSoLuong.DefaultCellStyle = dataGridViewCellStyle2;
            this.colSoLuong.HeaderText = "Số lượng";
            this.colSoLuong.Name = "colSoLuong";
            this.colSoLuong.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colSoLuong.Width = 98;
            // 
            // colDonGia
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colDonGia.DefaultCellStyle = dataGridViewCellStyle3;
            this.colDonGia.HeaderText = "Đơn giá";
            this.colDonGia.Name = "colDonGia";
            this.colDonGia.ReadOnly = true;
            this.colDonGia.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // FrmBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1000, 450);
            this.ControlBox = false;
            this.Controls.Add(this.panelLoai);
            this.Controls.Add(this.panelLayout);
            this.DisplayHeader = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBanHang";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Resizable = false;
            this.ShowIcon = false;
            this.Text = "Bán hàng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmBanHang_FormClosed);
            this.Load += new System.EventHandler(this.FrmBanHang_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panelHoaDon.ResumeLayout(false);
            this.panelThanhToan.ResumeLayout(false);
            this.panelThanhToan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.panelLayout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private MetroFramework.Controls.MetroPanel panelMenu;
        private MetroFramework.Controls.MetroTextBox txtTimKiem;
        private System.Windows.Forms.Button btnQuayLai;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.ListView lsvMenu;
        private MetroFramework.Controls.MetroPanel panelHoaDon;
        private System.Windows.Forms.DataGridView dgvHoaDon;
        private System.Windows.Forms.Button btnThanhToan;
        private MetroFramework.Controls.MetroLabel lblThanhTien;
        private MetroFramework.Controls.MetroLabel lblTong;
        private MetroFramework.Controls.MetroPanel panelThanhToan;
        private System.Windows.Forms.ColumnHeader colMenuTenMon;
        private System.Windows.Forms.ColumnHeader colMenuGiaTien;
        private MetroFramework.Controls.MetroPanel panelLayout;
        private MetroFramework.Controls.MetroPanel panelLoai;
        private System.Windows.Forms.ImageList imlMon;
        private MaterialSkin.Controls.MaterialRadioButton radMenuMon;
        private MaterialSkin.Controls.MaterialRadioButton radMenuTopping;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDonGia;
    }
}