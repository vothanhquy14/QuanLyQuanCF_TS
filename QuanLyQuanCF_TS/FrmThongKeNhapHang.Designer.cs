﻿namespace QuanLyQuanCF_TS
{
    partial class FrmThongKeNhapHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.dateTimePick = new MetroFramework.Controls.MetroDateTime();
            this.dateTimeEnd = new MetroFramework.Controls.MetroDateTime();
            this.dateTimeStart = new MetroFramework.Controls.MetroDateTime();
            this.radMocThoiGian = new MetroFramework.Controls.MetroRadioButton();
            this.radKhoangThoiGian = new MetroFramework.Controls.MetroRadioButton();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.dgvPhieuNhap = new System.Windows.Forms.DataGridView();
            this.colMaPhieuNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNhaCungCap = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colNgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThai = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.dgvCTPhieuNhap = new System.Windows.Forms.DataGridView();
            this.colMaNguyenLieu = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colKhoiLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTPhieuNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.btnQuayLai);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(20, 60);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(41, 484);
            this.metroPanel1.TabIndex = 21;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.BackColor = System.Drawing.Color.White;
            this.btnQuayLai.BackgroundImage = global::QuanLyQuanCF_TS.Properties.Resources.back;
            this.btnQuayLai.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnQuayLai.FlatAppearance.BorderSize = 0;
            this.btnQuayLai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuayLai.Location = new System.Drawing.Point(13, 10);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(20, 20);
            this.btnQuayLai.TabIndex = 4;
            this.btnQuayLai.UseVisualStyleBackColor = false;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(61, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1249, 484);
            this.panel1.TabIndex = 22;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer4);
            this.splitContainer1.Size = new System.Drawing.Size(1249, 484);
            this.splitContainer1.SplitterDistance = 611;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.BackColor = System.Drawing.Color.White;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainer2.Panel1.Controls.Add(this.dateTimePick);
            this.splitContainer2.Panel1.Controls.Add(this.dateTimeEnd);
            this.splitContainer2.Panel1.Controls.Add(this.dateTimeStart);
            this.splitContainer2.Panel1.Controls.Add(this.radMocThoiGian);
            this.splitContainer2.Panel1.Controls.Add(this.radKhoangThoiGian);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Size = new System.Drawing.Size(611, 484);
            this.splitContainer2.SplitterDistance = 167;
            this.splitContainer2.TabIndex = 0;
            // 
            // dateTimePick
            // 
            this.dateTimePick.Location = new System.Drawing.Point(298, 55);
            this.dateTimePick.MinimumSize = new System.Drawing.Size(0, 29);
            this.dateTimePick.Name = "dateTimePick";
            this.dateTimePick.Size = new System.Drawing.Size(211, 29);
            this.dateTimePick.TabIndex = 9;
            this.dateTimePick.ValueChanged += new System.EventHandler(this.dateTimePick_ValueChanged_1);
            // 
            // dateTimeEnd
            // 
            this.dateTimeEnd.Location = new System.Drawing.Point(24, 114);
            this.dateTimeEnd.MinimumSize = new System.Drawing.Size(0, 29);
            this.dateTimeEnd.Name = "dateTimeEnd";
            this.dateTimeEnd.Size = new System.Drawing.Size(211, 29);
            this.dateTimeEnd.TabIndex = 8;
            this.dateTimeEnd.ValueChanged += new System.EventHandler(this.dateTimeEnd_ValueChanged_1);
            // 
            // dateTimeStart
            // 
            this.dateTimeStart.Location = new System.Drawing.Point(24, 55);
            this.dateTimeStart.MinimumSize = new System.Drawing.Size(0, 29);
            this.dateTimeStart.Name = "dateTimeStart";
            this.dateTimeStart.Size = new System.Drawing.Size(211, 29);
            this.dateTimeStart.TabIndex = 7;
            // 
            // radMocThoiGian
            // 
            this.radMocThoiGian.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.radMocThoiGian.Location = new System.Drawing.Point(298, 14);
            this.radMocThoiGian.Name = "radMocThoiGian";
            this.radMocThoiGian.Size = new System.Drawing.Size(246, 24);
            this.radMocThoiGian.TabIndex = 6;
            this.radMocThoiGian.Text = "Chọn mốc thời gian";
            this.radMocThoiGian.UseSelectable = true;
            this.radMocThoiGian.CheckedChanged += new System.EventHandler(this.radMocThoiGian_CheckedChanged_1);
            // 
            // radKhoangThoiGian
            // 
            this.radKhoangThoiGian.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.radKhoangThoiGian.Location = new System.Drawing.Point(24, 14);
            this.radKhoangThoiGian.Name = "radKhoangThoiGian";
            this.radKhoangThoiGian.Size = new System.Drawing.Size(246, 24);
            this.radKhoangThoiGian.TabIndex = 5;
            this.radKhoangThoiGian.Text = "Chọn khoảng thời gian";
            this.radKhoangThoiGian.UseSelectable = true;
            this.radKhoangThoiGian.CheckedChanged += new System.EventHandler(this.radKhoangThoiGian_CheckedChanged_1);
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.metroLabel1);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.dgvPhieuNhap);
            this.splitContainer3.Size = new System.Drawing.Size(611, 313);
            this.splitContainer3.SplitterDistance = 25;
            this.splitContainer3.TabIndex = 0;
            // 
            // dgvPhieuNhap
            // 
            this.dgvPhieuNhap.AllowUserToAddRows = false;
            this.dgvPhieuNhap.AllowUserToDeleteRows = false;
            this.dgvPhieuNhap.AllowUserToResizeRows = false;
            this.dgvPhieuNhap.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPhieuNhap.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPhieuNhap.ColumnHeadersHeight = 70;
            this.dgvPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPhieuNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaPhieuNhap,
            this.ColNhaCungCap,
            this.colNgayLap,
            this.colTongTien,
            this.colTrangThai});
            this.dgvPhieuNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPhieuNhap.EnableHeadersVisualStyles = false;
            this.dgvPhieuNhap.Location = new System.Drawing.Point(0, 0);
            this.dgvPhieuNhap.MultiSelect = false;
            this.dgvPhieuNhap.Name = "dgvPhieuNhap";
            this.dgvPhieuNhap.ReadOnly = true;
            this.dgvPhieuNhap.RowHeadersVisible = false;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPhieuNhap.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPhieuNhap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhieuNhap.Size = new System.Drawing.Size(611, 284);
            this.dgvPhieuNhap.TabIndex = 1;
            this.dgvPhieuNhap.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvPhieuNhap_RowsAdded);
            // 
            // colMaPhieuNhap
            // 
            this.colMaPhieuNhap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colMaPhieuNhap.DataPropertyName = "maPhieuNhap";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colMaPhieuNhap.DefaultCellStyle = dataGridViewCellStyle2;
            this.colMaPhieuNhap.HeaderText = "Mã phiếu nhập";
            this.colMaPhieuNhap.Name = "colMaPhieuNhap";
            this.colMaPhieuNhap.ReadOnly = true;
            // 
            // ColNhaCungCap
            // 
            this.ColNhaCungCap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColNhaCungCap.DataPropertyName = "NhaCungCap";
            this.ColNhaCungCap.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.ColNhaCungCap.HeaderText = "Nhà cung cấp";
            this.ColNhaCungCap.Name = "ColNhaCungCap";
            this.ColNhaCungCap.ReadOnly = true;
            this.ColNhaCungCap.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColNhaCungCap.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colNgayLap
            // 
            this.colNgayLap.DataPropertyName = "ngayLap";
            this.colNgayLap.HeaderText = "Ngày lập";
            this.colNgayLap.Name = "colNgayLap";
            this.colNgayLap.ReadOnly = true;
            // 
            // colTongTien
            // 
            this.colTongTien.DataPropertyName = "tongTien";
            this.colTongTien.HeaderText = "Tổng tiền";
            this.colTongTien.Name = "colTongTien";
            this.colTongTien.ReadOnly = true;
            // 
            // colTrangThai
            // 
            this.colTrangThai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTrangThai.DataPropertyName = "trangThai";
            this.colTrangThai.HeaderText = "Trạng thái";
            this.colTrangThai.Name = "colTrangThai";
            this.colTrangThai.ReadOnly = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(0, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(193, 23);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Danh sách phiếu nhập";
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.metroLabel2);
            this.splitContainer4.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer4_Panel1_Paint);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.dgvCTPhieuNhap);
            this.splitContainer4.Size = new System.Drawing.Size(634, 484);
            this.splitContainer4.SplitterDistance = 25;
            this.splitContainer4.TabIndex = 0;
            // 
            // dgvCTPhieuNhap
            // 
            this.dgvCTPhieuNhap.AllowUserToAddRows = false;
            this.dgvCTPhieuNhap.AllowUserToDeleteRows = false;
            this.dgvCTPhieuNhap.AllowUserToResizeRows = false;
            this.dgvCTPhieuNhap.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCTPhieuNhap.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCTPhieuNhap.ColumnHeadersHeight = 70;
            this.dgvCTPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCTPhieuNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaNguyenLieu,
            this.colKhoiLuong,
            this.colDonGia});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCTPhieuNhap.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvCTPhieuNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCTPhieuNhap.EnableHeadersVisualStyles = false;
            this.dgvCTPhieuNhap.Location = new System.Drawing.Point(0, 0);
            this.dgvCTPhieuNhap.Name = "dgvCTPhieuNhap";
            this.dgvCTPhieuNhap.RowHeadersVisible = false;
            this.dgvCTPhieuNhap.Size = new System.Drawing.Size(634, 455);
            this.dgvCTPhieuNhap.TabIndex = 1;
            this.dgvCTPhieuNhap.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvCTPhieuNhap_RowsAdded);
            // 
            // colMaNguyenLieu
            // 
            this.colMaNguyenLieu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colMaNguyenLieu.DataPropertyName = "maNguyenLieu";
            this.colMaNguyenLieu.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.colMaNguyenLieu.HeaderText = "Tên nguyên liệu";
            this.colMaNguyenLieu.Name = "colMaNguyenLieu";
            this.colMaNguyenLieu.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colMaNguyenLieu.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colKhoiLuong
            // 
            this.colKhoiLuong.DataPropertyName = "khoiLuong";
            this.colKhoiLuong.HeaderText = "Khối lượng";
            this.colKhoiLuong.Name = "colKhoiLuong";
            // 
            // colDonGia
            // 
            this.colDonGia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDonGia.DataPropertyName = "donGia";
            this.colDonGia.HeaderText = "Đơn giá";
            this.colDonGia.Name = "colDonGia";
            // 
            // metroLabel2
            // 
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(2, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(175, 23);
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "Chi tiết phiếu nhập";
            // 
            // FrmThongKeNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1330, 564);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.metroPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmThongKeNhapHang";
            this.Resizable = false;
            this.ShowIcon = false;
            this.Text = "Thống kê nhập hàng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmThongKeNhapHang_FormClosed);
            this.Load += new System.EventHandler(this.FrmThongKeNhapHang_Load);
            this.metroPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuNhap)).EndInit();
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTPhieuNhap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private MetroFramework.Controls.MetroDateTime dateTimePick;
        private MetroFramework.Controls.MetroDateTime dateTimeEnd;
        private MetroFramework.Controls.MetroDateTime dateTimeStart;
        private MetroFramework.Controls.MetroRadioButton radMocThoiGian;
        private MetroFramework.Controls.MetroRadioButton radKhoangThoiGian;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.DataGridView dgvPhieuNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaPhieuNhap;
        private System.Windows.Forms.DataGridViewComboBoxColumn ColNhaCungCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTongTien;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colTrangThai;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.DataGridView dgvCTPhieuNhap;
        private System.Windows.Forms.DataGridViewComboBoxColumn colMaNguyenLieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKhoiLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDonGia;
    }
}