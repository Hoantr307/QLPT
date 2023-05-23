using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyPhongTro
{
    public partial class GUI_ChiTietHD : Form
    {
        public GUI_ChiTietHD()
        {
            InitializeComponent();
            guna2ShadowForm1.SetShadowForm(this);
        }


        private void GUI_ChiTietHD_Load(object sender, EventArgs e)
        {

        }

        private void btnDKDichVu_Click(object sender, EventArgs e)
        {
            GUI_DKDichVu f = new GUI_DKDichVu();
            f.ShowDialog();
        }

        private void btnDKDichVu_Click_1(object sender, EventArgs e)
        {
            pnlCTHD.Visible = false;
        }

        private void btnCTHD_Click(object sender, EventArgs e)
        {
            pnlCTHD.Visible = true;
        }
    }
}
