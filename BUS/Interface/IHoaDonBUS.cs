using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Interface
{
    public interface IHoaDonBUS
    {
        DataTable GetHoaDon();

        void AddHoaDon(HoaDon hoaDon);

        void EditHoaDon(HoaDon hoaDon);

        void DeleteHoaDon(string maHoaDon);

        DataTable SearchHoaDon(string keyword);



        List<object> GetAll(DataTable tbHoaDon);

        void KetXuatWord(string exportPath);

        void XuatExcel(string filePath);
    }
}
