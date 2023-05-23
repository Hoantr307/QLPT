using BUS;
using DTO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace UnitTestProject
{
    [TestClass]
    public class TestDkDichVu
    {
        [TestMethod]
        public void TestThemDV_NhapDung()
        {
            BUS_DKDichVu bUS_DK = new BUS_DKDichVu();

            DKDichVu dk = new DKDichVu()
            {
                maCTHD = "ct01",
                maDichVu = "vs",
                ngayDK = DateTime.ParseExact("23/05/2023", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                ngayKT = DateTime.ParseExact("23/06/2023", "dd/MM/yyyy", CultureInfo.InvariantCulture)
            };

            bool result =  bUS_DK.AddDKDV(dk);
            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void TestThemDV_DeTrong()
        {
            BUS_DKDichVu bUS_DK = new BUS_DKDichVu();

            DKDichVu dk = new DKDichVu()
            {
                maCTHD = "",
                maDichVu = "",
                ngayDK = DateTime.ParseExact("", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                ngayKT = DateTime.ParseExact("", "dd/MM/yyyy", CultureInfo.InvariantCulture)
            };

            bool result = bUS_DK.AddDKDV(dk);
            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void TestThemDV_NhapSaiMaCt()
        {
            BUS_DKDichVu bUS_DK = new BUS_DKDichVu();

            DKDichVu dk = new DKDichVu()
            {
                maCTHD = "ct02",
                maDichVu = "vs",
                ngayDK = DateTime.ParseExact("20/05/2023", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                ngayKT = DateTime.ParseExact("24/05/2023", "dd/MM/yyyy", CultureInfo.InvariantCulture)
            };

            bool result = bUS_DK.AddDKDV(dk);
            Assert.AreEqual(result, true);
        }


        [TestMethod]
        public void TestSuaDV_ThanhCong()
        {
            BUS_DKDichVu bUS_DK = new BUS_DKDichVu();

            DKDichVu dk = new DKDichVu()
            {
                maCTHD = "ct01",
                maDichVu = "vs",
                ngayDK = DateTime.ParseExact("15/05/2023", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                ngayKT = DateTime.ParseExact("24/05/2023", "dd/MM/yyyy", CultureInfo.InvariantCulture)
            };

            bool result = bUS_DK.EditDKDV(dk);
            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void TestSuaDV_ThatBai()
        {
            BUS_DKDichVu bUS_DK = new BUS_DKDichVu();

            DKDichVu dk = new DKDichVu()
            {
                maCTHD = "ct01",
                maDichVu = "vs",
                ngayDK = DateTime.ParseExact("", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                ngayKT = DateTime.ParseExact("", "dd/MM/yyyy", CultureInfo.InvariantCulture)
            };

            bool result = bUS_DK.EditDKDV(dk);
            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void TestXoaDV_ThanhCong()
        {
            BUS_DKDichVu bUS_DK = new BUS_DKDichVu();
            string maCTHD = "CT01";
            string maDichVu = "vs";

            bool result = bUS_DK.DeleteDKDV(maCTHD, maDichVu);
            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void TestXoaDV_ThatBai()
        {
            BUS_DKDichVu bUS_DK = new BUS_DKDichVu();
            string maCTHD = "";
            string maDichVu = "";

            bool result = bUS_DK.DeleteDKDV(maCTHD, maDichVu);
            Assert.AreEqual(result, true);
        }
    }
}
