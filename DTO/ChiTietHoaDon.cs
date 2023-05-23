using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietHoaDon
    {
        public static int giaDien = 0;

        public string maHoaDon { get; set; }
        public string maPhong { get; set; }
        public int tienPhong { get; set; }
        public int tienDien { get; set; }
        public int tienNuoc { get; set; }
        public int tienMang { get; set; }
        public int tienVeSinh { get; set; }
        public int tienAnNinh { get; set; }
        public int chiPhiPhatSinh { get; set; }
        public string nDHoaDon { get; set; }

        public ChiTietHoaDon() { }
        public ChiTietHoaDon(string maHoaDon, string maPhong, int tienPhong, int tienDien, int tienNuoc, int tienMang, int tienVeSinh, int tienAnNinh, int chiPhiPhatSinh, string nDHoaDon)
        {
            this.maHoaDon = maHoaDon;
            this.maPhong = maPhong;
            this.tienPhong = tienPhong;
            this.tienDien = tienDien;
            this.tienNuoc = tienNuoc;
            this.tienMang = tienMang;
            this.tienVeSinh = tienVeSinh;
            this.tienAnNinh = tienAnNinh;
            this.chiPhiPhatSinh = chiPhiPhatSinh;
            this.nDHoaDon = nDHoaDon;
        }
    }
}
