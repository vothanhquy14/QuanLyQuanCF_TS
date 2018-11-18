﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using BUS;
using DTO;

namespace QuanLyQuanCF_TS
{
    public partial class FrmBaoCao : MetroFramework.Forms.MetroForm
    {
        public FrmBaoCao()
        {
            InitializeComponent();
        }

        private static FrmBaoCao _Instance = null;

        public static FrmBaoCao Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new FrmBaoCao();
                }
                return _Instance;
            }
        }

        private void FrmBaoCao_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instance = null;
        }

        private void frmBaoCao_Load(object sender, EventArgs e)
        {
            cmbLoaiMon.DisplayMember = "TenLoaiMon";
            cmbLoaiMon.ValueMember = "MaLoaiMon";
            cmbLoaiMon.DataSource = LoaiMonBUS.LayDanhSachLoaiMon();
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            FrmHienThiBaoCao frm = new FrmHienThiBaoCao();

            if (radTatCaMon.Checked)
            {
                frm.HienTatCaMon();
            }
            else if (radTheoLoaiMon.Checked)
            {
                frm.HienMonTheoLoai((int)cmbLoaiMon.SelectedValue);
            }
            else if (radGomNhomMon.Checked)
            {
                //frm.HienSanPhamTheoNhom();
            }
            else if (radTatCaHoaDon.Checked)
            {
                //frm.HienSanPhamTheoNhom();
            }
            //else if (radHoaDonTheoThang.Checked)
            //{
            //    frm.HienSanPhamTheoNhom();
            //}
            //else if (radHoaDonTheoNam.Checked)
            //{
            //    frm.HienSanPhamTheoNhom();
            //}
            //else if (radDoanhThuTheoTuan.Checked)
            //{
            //    frm.HienSanPhamTheoNhom();
            //}
            //else if (radDoanhThuTheoThang.Checked)
            //{
            //    frm.HienSanPhamTheoNhom();
            //}
            //else if (radDoanhThuTheoNam.Checked)
            //{
            //    frm.HienSanPhamTheoNhom();
            //}
            //else if (radTatCaNguyenLieu.Checked)
            //{
            //    frm.HienSanPhamTheoNhom();
            //}
            //else if (radTatCaPhieuNhap.Checked)
            //{
            //    frm.HienSanPhamTheoNhom();
            //}
            //else if (radPhieuNhapTheoThang.Checked)
            //{
            //    frm.HienSanPhamTheoNhom();
            //}
            //else if (radPhieuNhapTheoNam.Checked)
            //{
            //    frm.HienSanPhamTheoNhom();
            //}

            frm.Show();
        }
    }
}
