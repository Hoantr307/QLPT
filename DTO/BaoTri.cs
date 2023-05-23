using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BaoTri
    {
        public string maBaoTri { get; set; }
        public string maPhong { get; set; }
        public string noiDung { get; set; }
        public DateTime ngayBaoTri { get; set; }

        public BaoTri() { }
        public BaoTri(string maBaoTri, string maPhong, string noiDung, DateTime ngayBaoTri)
        {
            this.maBaoTri = maBaoTri;
            this.maPhong = maPhong;
            this.noiDung = noiDung;
            this.ngayBaoTri = ngayBaoTri;
        }
    }
}
