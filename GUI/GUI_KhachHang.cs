using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;

namespace QuanLyPhongTro
{
    public partial class GUI_KhachHang : Form
    {
        public GUI_KhachHang()
        {
            InitializeComponent();
            txtKeyword.Text = "Nhập nội dung tìm kiếm";
            txtKeyword.ForeColor = Color.DarkGray;
        }

        BUS_KhachHang buskh = new BUS_KhachHang();


        public event EventHandler ExitForm;

        private void GUI_KhachHang_Load(object sender, EventArgs e)
        {
            dgvKhachHang.DataSource = buskh.GetKhachHang();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string maKhachHang = txtMaKhachHang.Text.Trim();
                string tenKhachHang = txtTenKhachHang.Text.Trim();
                string gioiTinh = cboGioitinh.Text.Trim();
                DateTime ngaySinh = DateTime.Parse(txtNgaySinh.Text.Trim());
                string queQuan = txtQueQuan.Text.Trim();
                string dienthoai = txtDienThoai.Text.Trim();
                string ngheNghiep = txtNgheNghiep.Text.Trim();
                string cCCD = txtCccd.Text.Trim();


                KhachHang kh = new KhachHang(maKhachHang, tenKhachHang, gioiTinh, ngaySinh, queQuan, dienthoai, ngheNghiep, cCCD);
                buskh.AddKhachHang(kh);
                MessageBox.Show("Thêm thông tin khách hàng thành công!");
                Reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                GUI_KhachHang_Load(sender, e);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maKhachHang = txtMaKhachHang.Text.Trim();
            string tenKhachHang = txtTenKhachHang.Text.Trim();
            string gioiTinh = cboGioitinh.Text.Trim();
            DateTime ngaySinh = DateTime.Parse(txtNgaySinh.Text.Trim());
            string queQuan = txtQueQuan.Text.Trim();
            string dienthoai = txtDienThoai.Text.Trim();
            string ngheNghiep = txtNgheNghiep.Text.Trim();
            string cCCD = txtCccd.Text.Trim();

            KhachHang kh = new KhachHang(maKhachHang, tenKhachHang, gioiTinh, ngaySinh, queQuan, dienthoai, ngheNghiep, cCCD);
            buskh.EditKhachHang(kh);
            MessageBox.Show("Cập nhật thông tin khách hàng thành công!");
            Reset();

            GUI_KhachHang_Load(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string maKhachHang = txtMaKhachHang.Text;
                buskh.DeleteKhachHang(maKhachHang);
                GUI_KhachHang_Load(sender, e);
                Reset();
            }
        }


        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
             
            txtMaKhachHang.Text = dgvKhachHang.CurrentRow.Cells[0].Value.ToString();
            txtTenKhachHang.Text = dgvKhachHang.CurrentRow.Cells[1].Value.ToString();
            cboGioitinh.SelectedIndex = dgvKhachHang.CurrentRow.Cells[2].Value.ToString() == "Nam" ? 0 : 1;
            txtNgaySinh.Text = Convert.ToDateTime(dgvKhachHang.CurrentRow.Cells[3].Value).ToShortDateString();
            txtQueQuan.Text = dgvKhachHang.CurrentRow.Cells[4].Value.ToString();
            txtDienThoai.Text = dgvKhachHang.CurrentRow.Cells[5].Value.ToString();
            txtNgheNghiep.Text = dgvKhachHang.CurrentRow.Cells[6].Value.ToString();
            txtCccd.Text = dgvKhachHang.CurrentRow.Cells[7].Value.ToString();
        }



        private void btnSearch_Click(object sender, EventArgs e)
        {

            string keyWord = txtKeyword.Text;
            dgvKhachHang.DataSource = buskh.SearchKhachHang(keyWord);

        }

        private void btnKetXuat_Click(object sender, EventArgs e)
        {


            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Microsoft Word | *.docx";
            saveFileDialog.Title = "Lưu thông tin khách hàng";
            saveFileDialog.ShowDialog();
            if (saveFileDialog.FileName != "")
            {
                try
                {
                    buskh.KetXuatWord(saveFileDialog.FileName);
                    MessageBox.Show("Kết xuất thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Thông báo lỗi");
                }

            }
        }

        private void btnThemDl_Click(object sender, EventArgs e)
        {
            OpenFileDialog saveFileDialog = new OpenFileDialog();
            saveFileDialog.DefaultExt = "*.xlsx";
            saveFileDialog.Filter = "Excel (*.xlsx)|*.xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    //buskh.ThemTuExcel(saveFileDialog.FileName);
                    GUI_KhachHang_Load(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Thông báo lỗi");
                }
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel (*.xlsx)|*.xlsx";
            saveFileDialog.Title = "Lưu thông tin khách hàng";
            saveFileDialog.ShowDialog();
            if (saveFileDialog.FileName != "")
            {
                    buskh.XuatExcel(saveFileDialog.FileName);
                    MessageBox.Show("Kết xuất thành công!");
                try
                {
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Thông báo lỗi");
                }
            }
        }




        private void btnThoat_Click(object sender, EventArgs e)
        {
            ExitForm(this, new EventArgs());
        }

        void Reset()
        {
            txtMaKhachHang.Clear();
            txtTenKhachHang.Clear();
            cboGioitinh.SelectedIndex = 0;
            txtNgaySinh.Clear();
            txtQueQuan.Clear();
            txtDienThoai.Clear();
            txtNgheNghiep.Clear();
            txtCccd.Clear();
        }

        private void txtKeyword_Enter(object sender, EventArgs e)
        {
            if (txtKeyword.Text == "Nhập nội dung tìm kiếm")
            {
                txtKeyword.Text = "";
                txtKeyword.ForeColor = Color.Black;
            }
        }

        private void txtKeyword_Leave(object sender, EventArgs e)
        {
            if (txtKeyword.Text == "")
            {
                txtKeyword.Text = "Nhập nội dung tìm kiếm";
                txtKeyword.ForeColor = Color.DarkGray;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            GUI_KhachHang_Load(sender, e);
            Reset();
        }

    }
}
