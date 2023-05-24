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
    public class BUS_DKDichVu
    {
        DAL_DKDichVu daldk = new DAL_DKDichVu();
        public DataTable GetDichVu()
        {
            return daldk.GetDichVu();
        }

        public DataTable GetDangKyDV()
        {

            return daldk.GetDangKyDV();
        }

        public bool AddDKDV(DKDichVu dKDichVu)
        {
            try
            {
                return daldk.AddDKDV(dKDichVu);

            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool EditDKDV(DKDichVu dKDichVu)
        {
            return daldk.EditDKDV(dKDichVu);
        }

        public bool DeleteDKDV(string maCTHD, string maDichVu)
        {
            return daldk.DeleteDKDV(maCTHD, maDichVu);
        }
    }
}
