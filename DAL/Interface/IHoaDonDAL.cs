using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interface
{
    public interface IHoaDonDAL
    {
        DataTable GetHoaDon();

        void AddHoaDon(HoaDon hoaDon);

        void EditHoaDon(HoaDon hoaDon);

        void DeleteHoaDon(string maHoaDon);

        DataTable SearchHoaDon(string keyword);
    }
}
