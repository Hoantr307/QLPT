using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_DKDichVu
    {
        public DataTable GetDichVu()
        {
            string query = "select * from DichVu";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable GetDangKyDV()
        {
            string query = "select dk.MaCTHD, dv.TenDichVu, dv.DonGia, dk.ngayDK, dk.ngayKT from DKDichVu dk inner join DichVu dv on dk.MaDichVu = dv.MaDichVu";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public bool AddDKDV(DKDichVu dKDichVu)
        {
            string query = "SP_AddDkDichVu @maCTHD , @maDichVu , @ngayDangKy  , @ngayKetThuc  ";
            
            return DataProvider.Instance.
                ExecuteNonQuery(query, new object[]
                {
                    dKDichVu.maCTHD, 
                    dKDichVu.maDichVu, 
                    dKDichVu.ngayDK, 
                    dKDichVu.ngayKT
                }) > 0;
        }

        public bool EditDKDV(DKDichVu dKDichVu)
        {
            string query = "SP_EditDkDichVu @maCTHD , @maDichVu , @ngayDangKy  , @ngayKetThuc  ";

            return DataProvider.Instance.
                ExecuteNonQuery(query, new object[]
                {
                    dKDichVu.maCTHD,
                    dKDichVu.maDichVu,
                    dKDichVu.ngayDK,
                    dKDichVu.ngayKT
                }) > 0;
        }

        public bool DeleteDKDV(string maCTHD, string maDichVu)
        {
            string query = "SP_DeleteDkDichVu @maCTHD , @maDichVu  ";

            return DataProvider.Instance.
                ExecuteNonQuery(query, new object[]
                {
                    maCTHD, maDichVu
                }) > 0;
        }
    }
}
