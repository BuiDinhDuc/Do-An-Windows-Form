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
      
    public partial class frmNhapSach : Form
    {
        SachBUS sachBUS = new SachBUS();
        TheLoaiBUS theLoaiBUS = new TheLoaiBUS();
        public frmNhapSach()
        {
            InitializeComponent();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {

        }

        private void txtTheLoai_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void frmNhapSach_Load(object sender, EventArgs e)
        {
            rdoNhapMoi.Checked = true;
            NhapSachMoi();

            dtgv_Sach.AutoGenerateColumns = false;
            dtgv_Sach.DataSource = sachBUS.LayDSSach();

        }

        public void NhapSachMoi()
        {
            txtGiaTien.ReadOnly = false;
            txtMaSach.ReadOnly = true;
            txtNamXB.ReadOnly = false;
            txtNXB.ReadOnly = false;
            txtSach.ReadOnly = false;
            txtSoLuong.ReadOnly = false;
            txtTacGia.ReadOnly = false;
            txtTheLoai.ReadOnly = false;
            
        }

        public void NhapThemSach()
        {
            txtGiaTien.ReadOnly = true;
            txtMaSach.ReadOnly = true;
            txtNamXB.ReadOnly = true;
            txtNXB.ReadOnly = true;
            txtSach.ReadOnly = true;
            txtSoLuong.ReadOnly = false;
            txtTacGia.ReadOnly = true;
            txtTheLoai.ReadOnly = true;

        }

        private void rdoNhapMoi_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoNhapMoi.Checked)
                NhapSachMoi();
        }

        private void rdoNhapThem_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoNhapThem.Checked)
                NhapThemSach();
        }

        private void dtgv_Sach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            else
            {
                if (rdoNhapMoi.Checked)
                    return;
                else if (rdoNhapThem.Checked)
                {
                    SachDTO sachDTO = new SachDTO();

                    sachDTO = sachBUS.timSach(dtgv_Sach.Rows[e.RowIndex].Cells[0].Value.ToString());

                    txtGiaTien.Text = ((int)sachDTO.DonGia).ToString();
                    txtMaSach.Text = sachDTO.MaSach;
                    txtNamXB.Text = sachDTO.NamXuatBan.ToString();
                    txtNXB.Text = sachDTO.TenNhaXuatBan;
                    txtSach.Text = sachDTO.TenSach;
                    txtSoLuong.Text = ((int)sachDTO.SoLuong).ToString();
                    txtTacGia.Text = sachDTO.TenTacGia;
                    cbbDauSach.SelectedValue = sachDTO.MaDauSach;

                    txtTheLoai.Text = theLoaiBUS.timTheLoai(sachDTO.MaTheLoai).TenTheLoai;
                    
                    if (sachDTO.SachHiem)
                    {
                        chkSachHiem.Checked = true;
                    }
                    else
                        chkSachHiem.Checked = false;
                }
            }
        }
    }
}
