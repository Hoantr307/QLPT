using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_TaiKhoan
    {
        DAL_TaiKhoan dalTk = new DAL_TaiKhoan();

        public DataTable GetTaiKhoan(string tenTaiKhoan, string matKhau)
        {
            return dalTk.GetTaiKhoan(tenTaiKhoan, matKhau);
        }

        public bool kiemTraTK(string tenTaiKhoan, string matKhau)
        {
            return GetTaiKhoan(tenTaiKhoan, matKhau).Rows.Count > 0;
        }
    }
}
