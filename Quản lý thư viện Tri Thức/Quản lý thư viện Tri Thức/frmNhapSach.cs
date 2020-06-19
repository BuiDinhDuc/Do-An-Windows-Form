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
        DauSachBUS dauSachBUS = new DauSachBUS();
        public frmNhapSach()
        {
            InitializeComponent();
        }

       

        private void frmNhapSach_Load(object sender, EventArgs e)
        {
            rdoNhapMoi.Checked = true;
            NhapSachMoi();

            dtgv_Sach.AutoGenerateColumns = false;
            dtgv_Sach.DataSource = sachBUS.LayDSSach();

            //
            cbbDauSach.DataSource = dauSachBUS.LayDSDauSach();
            cbbDauSach.DisplayMember = "TenDauSach";
            cbbDauSach.ValueMember = "MaDauSach";
         

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

            txtGiaTien.Text = string.Empty;
            txtMaSach.Text = string.Empty;
            txtNamXB.Text = string.Empty;
            txtNXB.Text = string.Empty;
            txtSach.Text = string.Empty;
            txtSoLuong.Text = string.Empty;
            txtTacGia.Text = string.Empty;
            txtTheLoai.Text = string.Empty;
            
            chkSachHiem.Checked = false;

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
            label6.Text = "Số lượng nhập thêm";

        }

        private void rdoNhapMoi_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoNhapMoi.Checked)
                NhapSachMoi();
        }

        private void rdoNhapThem_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoNhapThem.Checked)
            {
                NhapThemSach();
                if(dtgv_Sach.SelectedRows.Count > 0)
                {
                    int vitri = dtgv_Sach.SelectedRows[0].Index;

                    SachDTO sachDTO = sachBUS.timSach(dtgv_Sach.Rows[vitri].Cells[0].Value.ToString());

                    txtGiaTien.Text = ((int)sachDTO.DonGia).ToString();
                    txtMaSach.Text = sachDTO.MaSach;
                    txtNamXB.Text = sachDTO.NamXuatBan.ToString();
                    txtNXB.Text = sachDTO.TenNhaXuatBan;
                    txtSach.Text = sachDTO.TenSach;

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

       

        private void dtgv_Sach_CellClick(object sender, DataGridViewCellEventArgs e)
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
