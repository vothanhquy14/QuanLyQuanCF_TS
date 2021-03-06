﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public static class rptHoaDon_TaiKhoanDAO
    {
        public static List<rptHoaDon_TaiKhoanDTO> DoiMaNhanVienThanhTenNhanVien()
        {
            SqlConnection connection = DataProvider.GetConnection();
            string query = "SELECT HoaDon.ma_hoa_don, HoaDon.ngay_lap, TaiKhoan.ho_ten, HoaDon.tien_mat, HoaDon.tien_thua, HoaDon.tong_tien FROM HoaDon,TaiKhoan WHERE HoaDon.nhan_vien_lap=TaiKhoan.ma_tai_khoan";

            SqlCommand command = new SqlCommand();

            command.CommandText = query;
            command.Connection = connection;

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            List<rptHoaDon_TaiKhoanDTO> result = new List<rptHoaDon_TaiKhoanDTO>();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    rptHoaDon_TaiKhoanDTO hoaDon_TaiKhoanDTO = new rptHoaDon_TaiKhoanDTO();
                    hoaDon_TaiKhoanDTO.MaHoaDon = reader.GetInt32(0);
                    hoaDon_TaiKhoanDTO.NgayLap = reader.GetDateTime(1);
                    hoaDon_TaiKhoanDTO.TenNhanVien = reader.GetString(2);
                    hoaDon_TaiKhoanDTO.TienMat = reader.GetDouble(3);
                    hoaDon_TaiKhoanDTO.TienThua = reader.GetDouble(4);
                    hoaDon_TaiKhoanDTO.TongTien = reader.GetDouble(5);
                    result.Add(hoaDon_TaiKhoanDTO);
                }
            }

            connection.Close();
            return result;
        }

        public static List<rptHoaDon_TaiKhoanDTO> DoiMaNhanVienThanhTenNhanVien(DateTime timeStart, DateTime timeEnd)
        {
            SqlConnection connection = DataProvider.GetConnection();
            string query = "SELECT HoaDon.ma_hoa_don, HoaDon.ngay_lap, TaiKhoan.ho_ten, HoaDon.tien_mat, HoaDon.tien_thua, HoaDon.tong_tien FROM HoaDon,TaiKhoan WHERE HoaDon.nhan_vien_lap=TaiKhoan.ma_tai_khoan and ngay_lap between @timeStart and @timeEnd";
            SqlCommand command = new SqlCommand();
            command.Parameters.Add("@timeStart", System.Data.SqlDbType.DateTime, 0).Value = timeStart;
            command.Parameters.Add("@timeEnd", System.Data.SqlDbType.DateTime, 0).Value = timeEnd;

            command.CommandText = query;
            command.Connection = connection;

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            List<rptHoaDon_TaiKhoanDTO> result = new List<rptHoaDon_TaiKhoanDTO>();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    rptHoaDon_TaiKhoanDTO hoaDon_TaiKhoanDTO = new rptHoaDon_TaiKhoanDTO();
                    hoaDon_TaiKhoanDTO.MaHoaDon = reader.GetInt32(0);
                    hoaDon_TaiKhoanDTO.NgayLap = reader.GetDateTime(1);
                    hoaDon_TaiKhoanDTO.TenNhanVien = reader.GetString(2);
                    hoaDon_TaiKhoanDTO.TienMat = reader.GetDouble(3);
                    hoaDon_TaiKhoanDTO.TienThua = reader.GetDouble(4);
                    hoaDon_TaiKhoanDTO.TongTien = reader.GetDouble(5);
                    result.Add(hoaDon_TaiKhoanDTO);
                }
            }

            connection.Close();
            return result;
        }

        public static List<rptHoaDon_TaiKhoanDTO> LayHoaDonMaMoiNhat()
        {
            SqlConnection connection = DataProvider.GetConnection();
            string query = "SELECT HoaDon.ma_hoa_don, HoaDon.ngay_lap, TaiKhoan.ho_ten, HoaDon.tien_mat, HoaDon.tien_thua, HoaDon.tong_tien FROM HoaDon,TaiKhoan where HoaDon.nhan_vien_lap=TaiKhoan.ma_tai_khoan and ma_hoa_don = (SELECT MAX(ma_hoa_don)FROM HoaDon)";

            SqlCommand command = new SqlCommand();

            command.CommandText = query;
            command.Connection = connection;

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            List<rptHoaDon_TaiKhoanDTO> result = new List<rptHoaDon_TaiKhoanDTO>();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    rptHoaDon_TaiKhoanDTO hoaDon_TaiKhoanDTO = new rptHoaDon_TaiKhoanDTO();
                    hoaDon_TaiKhoanDTO.MaHoaDon = reader.GetInt32(0);
                    hoaDon_TaiKhoanDTO.NgayLap = reader.GetDateTime(1);
                    hoaDon_TaiKhoanDTO.TenNhanVien = reader.GetString(2);
                    hoaDon_TaiKhoanDTO.TienMat = reader.GetDouble(3);
                    hoaDon_TaiKhoanDTO.TienThua = reader.GetDouble(4);
                    hoaDon_TaiKhoanDTO.TongTien = reader.GetDouble(5);
                    result.Add(hoaDon_TaiKhoanDTO);
                }
            }

            connection.Close();
            return result;
        }

        public static List<rptHoaDon_TaiKhoanDTO> DanhSachHoaDonVuaMoiLapTrongNgay()
        {
            SqlConnection connection = DataProvider.GetConnection();
            string query = "select HoaDon.ma_hoa_don, HoaDon.ngay_lap, TaiKhoan.ho_ten, HoaDon.tien_mat, HoaDon.tien_thua, HoaDon.tong_tien from HoaDon,TaiKhoan where HoaDon.nhan_vien_lap=TaiKhoan.ma_tai_khoan and DAY(GETDATE()) = DAY(ngay_lap) and MONTH(GETDATE()) = MONTH(ngay_lap) and YEAR(GETDATE()) = YEAR(ngay_lap)";
            SqlCommand command = new SqlCommand();
            command.CommandText = query;
            command.Connection = connection;

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            List<rptHoaDon_TaiKhoanDTO> result = new List<rptHoaDon_TaiKhoanDTO>();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    rptHoaDon_TaiKhoanDTO hoaDon_TaiKhoanDTO = new rptHoaDon_TaiKhoanDTO();
                    hoaDon_TaiKhoanDTO.MaHoaDon = reader.GetInt32(0);
                    hoaDon_TaiKhoanDTO.NgayLap = reader.GetDateTime(1);
                    hoaDon_TaiKhoanDTO.TenNhanVien = reader.GetString(2);
                    hoaDon_TaiKhoanDTO.TienMat = reader.GetDouble(3);
                    hoaDon_TaiKhoanDTO.TienThua = reader.GetDouble(4);
                    hoaDon_TaiKhoanDTO.TongTien = reader.GetDouble(5);
                    result.Add(hoaDon_TaiKhoanDTO);
                }
            }

            connection.Close();
            return result;
        }

        public static int LayMaHoaDonMoiNhat()
        {
            SqlConnection connection = DataProvider.GetConnection();
            string query = "SELECT MAX(ma_hoa_don) FROM HoaDon";
            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            var result = command.ExecuteScalar();
            connection.Close();

            return result is DBNull ? 0 : Convert.ToInt32(result);
        }

        public static List<rptHoaDon_TaiKhoanDTO> DoiMaNhanVienThanhTenNhanVien(DateTime timeLine)
        {
            SqlConnection connection = DataProvider.GetConnection();
            string query = "SELECT HoaDon.ma_hoa_don, HoaDon.ngay_lap, TaiKhoan.ho_ten, HoaDon.tien_mat, HoaDon.tien_thua, HoaDon.tong_tien FROM HoaDon,TaiKhoan WHERE HoaDon.nhan_vien_lap = TaiKhoan.ma_tai_khoan and DATEPART(YYYY, ngay_lap) = YEAR(@timeLine) AND DATEPART(MM, ngay_lap) = MONTH(@timeLine) AND DATEPART(DD, ngay_lap) = DAY(@timeLine)";

            SqlCommand command = new SqlCommand();
            command.Parameters.Add("@timeLine", System.Data.SqlDbType.DateTime, 0).Value = timeLine;
            command.CommandText = query;
            command.Connection = connection;

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            List<rptHoaDon_TaiKhoanDTO> result = new List<rptHoaDon_TaiKhoanDTO>();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    rptHoaDon_TaiKhoanDTO hoaDon_TaiKhoanDTO = new rptHoaDon_TaiKhoanDTO();
                    hoaDon_TaiKhoanDTO.MaHoaDon = reader.GetInt32(0);
                    hoaDon_TaiKhoanDTO.NgayLap = reader.GetDateTime(1);
                    hoaDon_TaiKhoanDTO.TenNhanVien = reader.GetString(2);
                    hoaDon_TaiKhoanDTO.TienMat = reader.GetDouble(3);
                    hoaDon_TaiKhoanDTO.TienThua = reader.GetDouble(4);
                    hoaDon_TaiKhoanDTO.TongTien = reader.GetDouble(5);
                    result.Add(hoaDon_TaiKhoanDTO);
                }
            }

            connection.Close();
            return result;
        }
    }
}
