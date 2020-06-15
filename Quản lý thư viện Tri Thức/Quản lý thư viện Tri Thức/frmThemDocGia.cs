using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
namespace Quản_lý_thư_viện_Tri_Thức
{
    public partial class frmThemDocGia : Form
    {
        DocGiaBUS docGiaBUS = new DocGiaBUS();
        TheThuVienBUS theThuVienBUS = new TheThuVienBUS();

        public frmThemDocGia()
        {
            InitializeComponent();
        }

        private void frmAddReaders_Load(object sender, EventArgs e)
        {
            txtMaDocGia.Text = docGiaBUS.phatsinhma();
            txtMaThe.Text = theThuVienBUS.phatsinhma();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            TheThuVienDTO theThuVienDTO = new TheThuVienDTO
            {
                SoThe = txtMaThe.Text,
                NgayBatDau = dtmNgayBD.Value,
                TrangThai = true
            };

            DocGiaDTO docGiaDTO = new DocGiaDTO 
            { 
                MaDocGia = txtMaDocGia.Text,
                TenDocGia = txtTenDocGia.Text,
                CMND = txtCMND.Text,
                DiaChi = txtDiaChi.Text,
                SoThe = txtMaThe.Text,
                TrangThai = true
            };

            if (theThuVienBUS.themTheTV(theThuVienDTO) && docGiaBUS.themDocGia(docGiaDTO))
            {
                MessageBox.Show(Constrant.ThemThanhCong, Constrant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

            }
            else
                MessageBox.Show(Constrant.ThemThatBai, Constrant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
