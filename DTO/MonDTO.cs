﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class MonDTO
    {
        public MonDTO()
        {
            hinh = "default-product.png";
        }

        private int maMon;
        private string tenMon;
        private int loaiMon;
        private string hinh;
        private bool trangThai;

        public int MaMon { get => maMon; set => maMon = value; }
        public string TenMon { get => tenMon; set => tenMon = value; }
        public int LoaiMon { get => loaiMon; set => loaiMon = value; }
        public string Hinh { get => hinh; set => hinh = value; }
        public bool TrangThai { get => trangThai; set => trangThai = value; }
    }
}
