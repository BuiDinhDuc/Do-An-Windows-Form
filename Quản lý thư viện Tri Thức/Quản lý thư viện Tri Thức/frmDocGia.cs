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
using BUS;

namespace Quản_lý_thư_viện_Tri_Thức
{
    public partial class frmDocGia : Form
    {
        DocGiaBUS docgiaBUS = new DocGiaBUS();
        TheThuVienBUS theThuVienBUS = new TheThuVienBUS();
        public frmDocGia()
        {
            InitializeComponent();
        }

        private void frmReaders_Load(object sender, EventArgs e)
        {
            dataDocGia.AutoGenerateColumns = false;
            dataDocGia.DataSource = docgiaBUS.LayDSDocGia();

            DocGiaDTO docGiaDTO = new DocGiaDTO();
            docGiaDTO = docgiaBUS.timDOcGia(dataDocGia.Rows[0].Cells[0].Value.ToString());
            txtMaDocGia.Text = docGiaDTO.MaDocGia;
            txtMaThe.Text = docGiaDTO.SoThe;
            txtTenDocGia.Text = docGiaDTO.TenDocGia;
            txtCMND.Text = docGiaDTO.CMND;
            txtDiaChi.Text = docGiaDTO.DiaChi;

            dtmNgayBD.Value = theThuVienBUS.LayNgayBatDau(txtMaThe.Text);
        }

        private void dataDocGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int vitri = e.RowIndex;

            if (vitri < 0)
                return;
            else
            {
                DocGiaDTO docGiaDTO = new DocGiaDTO();
                docGiaDTO = docgiaBUS.timDOcGia(dataDocGia.Rows[vitri].Cells[0].Value.ToString());
                txtMaDocGia.Text = docGiaDTO.MaDocGia;
                txtMaThe.Text = docGiaDTO.SoThe;
                txtTenDocGia.Text = docGiaDTO.TenDocGia;
                txtCMND.Text = docGiaDTO.CMND;
                txtDiaChi.Text = docGiaDTO.DiaChi;

                dtmNgayBD.Value = theThuVienBUS.LayNgayBatDau(txtMaThe.Text);

               
                
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmThemDocGia fDocGia = new frmThemDocGia();
            fDocGia.ShowDialog();

            frmReaders_Load(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(theThuVienBUS.xoaTheTV(txtMaThe.Text) && docgiaBUS.xoaDocGia(txtMaDocGia.Text))
            {
                MessageBox.Show(Constrant.XoaThanhCong, Constrant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmReaders_Load(sender, e);
            }
            else
            {
                MessageBox.Show(Constrant.XoaThatBai, Constrant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DocGiaDTO docGiaDTO = new DocGiaDTO
            {
                MaDocGia = txtMaDocGia.Text,
                TenDocGia = txtTenDocGia.Text,
                CMND = txtCMND.Text,
                DiaChi = txtDiaChi.Text

            };

            TheThuVienDTO theThuVienDTO = new TheThuVienDTO
            {   
                SoThe = txtMaThe.Text,
                NgayBatDau = dtmNgayBD.Value };

            if (docgiaBUS.suaDocGia(docGiaDTO) && theThuVienBUS.suaTheTV(theThuVienDTO))
            {
                MessageBox.Show(Constrant.SuaThanhCong, Constrant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmReaders_Load(sender, e);
            }
            else
                MessageBox.Show(Constrant.SuaThatBai, Constrant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtMaThe.Text = string.Empty;
            txtTenDocGia.Text = string.Empty;
            txtCMND.Text = string.Empty;
            txtDiaChi.Text = string.Empty;
            txtMaDocGia.Text = string.Empty;
            dtmNgayBD.Value = DateTime.Now;
        }
    }
}
