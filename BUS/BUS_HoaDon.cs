using BUS.Interface;
using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_HoaDon : IHoaDonBUS
    {
        DAL_HoaDon dalhd = new DAL_HoaDon();
        public DataTable GetHoaDon()
        {
            return dalhd.GetHoaDon();
        }

        public void AddHoaDon(HoaDon hoaDon)
        {
            dalhd.AddHoaDon(hoaDon);
        }

        public void EditHoaDon(HoaDon hoaDon)
        {
            dalhd.EditHoaDon(hoaDon);
        }

        public void DeleteHoaDon(string maHoaDon)
        {
            dalhd.DeleteHoaDon(maHoaDon);
        }

        public DataTable SearchHoaDon(string keyword)
        {
            return dalhd.SearchHoaDon(keyword);
        }



        public List<object> GetAll(DataTable tbHoaDon)
        {
            List<object> list = new List<object>();
            foreach (DataRow row in tbHoaDon.Rows)
            {
                HoaDon hd = new HoaDon()
                {
                    maHoaDon = row["MaHopDong"].ToString(),
                    maQuanLy = row["MaQuanLy"].ToString(),
                    maKhachHang = row["MaKhachHang"].ToString(),
                    ngayLap = (DateTime)row["MaPhong"],
                    tongTien = (int)row["NgayBatDau"],
                    loaiThanhToan = row["MaKhachHang"].ToString(),
                    trangThai = row["MaKhachHang"].ToString(),
                };
                list.Add((object)hd);
            }
            return list;
        }

        public void KetXuatWord(string exportPath)
        {
            //WordHelper.ExportToWord(dalhd.GetHoaDon(), "Template\\HoaDon_Template.docx", exportPath);
        }

        public void XuatExcel(string filePath)
        {
            ExcelHelper.WriteExcelFile(filePath, "Template\\KhachHang_Template.xlsx", dalhd.GetHoaDon());
        }
    }
}
