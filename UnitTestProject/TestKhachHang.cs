using BUS;
using DTO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject
{
    [TestClass]
    public class TestKhachHang
    {
        [TestMethod]
        public void TestThemKhachHang_ThanhCong()
        {
            BUS_KhachHang busKH = new BUS_KhachHang();

            KhachHang kh = new KhachHang()
            {
                maKhachHang = "kh30",
                tenKhachHang = "Hoan",
                gioiTinh = "Nam",
                ngaySinh = DateTime.Parse("30/07/2003"),
                queQuan = "Hung Yen",
                dienThoai = "098766421",
                ngheNghiep = "Sinh vien",
                cCCD = "094230425"
            };
            bool result =  busKH.AddKhachHang(kh);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestThemKhachHang_ThatBai()
        {
            BUS_KhachHang busKH = new BUS_KhachHang();

            KhachHang kh = new KhachHang()
            {
                maKhachHang = "kh20",
                tenKhachHang = "Hoan",
                gioiTinh = "Nam",
                ngaySinh = DateTime.Parse("30/07/2003"),
                queQuan = "Hung Yen",
                dienThoai = "098766421",
                ngheNghiep = "Sinh vien",
                cCCD = "094230425"
            };
            bool result = busKH.AddKhachHang(kh);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestSuaKhachHang_ThanhCong()
        {
            BUS_KhachHang busKH = new BUS_KhachHang();

            KhachHang kh = new KhachHang()
            {
                maKhachHang = "kh30",
                tenKhachHang = "Hoan",
                gioiTinh = "Nam",
                ngaySinh = DateTime.Parse("30/07/2003"),
                queQuan = "Hung Yen",
                dienThoai = "098766434",
                ngheNghiep = "Sinh vien",
                cCCD = "094230425"
            };
            bool result = busKH.EditKhachHang(kh);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestSuaKhachHang_ThatBai()
        {
            BUS_KhachHang busKH = new BUS_KhachHang();

            KhachHang kh = new KhachHang()
            {
                maKhachHang = "kh25",
                tenKhachHang = "Hoan",
                gioiTinh = "Nam",
                ngaySinh = DateTime.Parse("30/07/2003"),
                queQuan = "Hung Yen",
                dienThoai = "098766421",
                ngheNghiep = "Sinh vien",
                cCCD = "094230425"
            };
            bool result = busKH.EditKhachHang(kh);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestXoaKhachHang_ThanhCong()
        {
            BUS_KhachHang bus_KH = new BUS_KhachHang();
            string maKhachHang = "kh30";

            bool result = bus_KH.DeleteKhachHang(maKhachHang);
            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void TestXoaKhachHang_ThatBai()
        {
            BUS_KhachHang bus_KH = new BUS_KhachHang();
            string maKhachHang = "kh30";

            bool result = bus_KH.DeleteKhachHang(maKhachHang);
            Assert.AreEqual(result, true);
        }
    }
}
