﻿using DAL.Interface;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_HoaDon : IHoaDonDAL
    {
        public DataTable GetHoaDon()
        {
            string query = $"Select * from HoaDon";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public void AddHoaDon(HoaDon hoaDon)
        {
            string query = $"SP_AddHoaDon @maHoaDon , @maQuanLy , @maKhachHang , @ngayLap , @tongTien , @loaiThanhToan , @trangThai ";
            DataProvider.Instance.
                ExecuteQuery(query, new object[]
                {
                    hoaDon.maHoaDon,
                    hoaDon.maQuanLy,
                    hoaDon.maKhachHang,
                    hoaDon.ngayLap,
                    hoaDon.ngayThanhToan,
                    hoaDon.tongTien,
                    hoaDon.loaiThanhToan,
                    hoaDon.trangThai
                });
        }

        public void EditHoaDon(HoaDon hoaDon)
        {
            string query = $"SP_EditHoaDon @maHoaDon , @maQuanLy , @maKhachHang , @ngayLap , @tongTien , @loaiThanhToan , @trangThai ";
            DataProvider.Instance.
                ExecuteQuery(query, new object[]
                {
                    hoaDon.maHoaDon,
                    hoaDon.maQuanLy,
                    hoaDon.maKhachHang,
                    hoaDon.ngayLap,
                    hoaDon.ngayThanhToan,
                    hoaDon.tongTien,
                    hoaDon.loaiThanhToan,
                    hoaDon.trangThai
                });
        }

        public void DeleteHoaDon(string maHoaDon)
        {
            string query = $"SP_DeleteHoaDon @maHoaDon ";
            DataProvider.Instance.ExecuteQuery(query, new object[] { maHoaDon });

        }

        public DataTable SearchHoaDon(string keyword)
        {
            string query = "SP_SearchHoaDon @key ";

            return DataProvider.Instance.ExecuteQuery(query, new object[] { keyword });
        }
    }
}
