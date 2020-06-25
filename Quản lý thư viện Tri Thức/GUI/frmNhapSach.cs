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
        NhapSachBUS nhapSachBUS = new NhapSachBUS();
        CTNhapSachBUS cTNhapSachBUS = new CTNhapSachBUS();

        public string MaNhap = string.Empty;
        public frmNhapSach()
        {
            InitializeComponent();
        }

       

        private void frmNhapSach_Load(object sender, EventArgs e)
        {
            rdoNhapMoi.Checked = true;
            NhapSachMoi();
            MaNhap = nhapSachBUS.phatSinhMa();
            dtgv_Sach.AutoGenerateColumns = false;
            dtgv_Sach.DataSource = sachBUS.LayDSSach();
            txtMaNhap.Text = MaNhap;

            //
            cbbDauSach.DataSource = dauSachBUS.LayDSDauSach();
            cbbDauSach.DisplayMember = "TenDauSach";
            cbbDauSach.ValueMember = "MaDauSach";
         

        }

        public void NhapSachMoi()
        {
            txtMaNhap.ReadOnly = true;
            txtGiaTien.ReadOnly = false;
            txtMaSach.ReadOnly = true;
            txtNamXB.ReadOnly = false;
            txtNXB.ReadOnly = false;
            txtSach.ReadOnly = false;
            txtSoLuong.ReadOnly = false;
            txtTacGia.ReadOnly = false;
            

            txtMaSach.Text = sachBUS.PhatSinhMa();
            txtGiaTien.Text = string.Empty;
            txtNamXB.Text = string.Empty;
            txtNXB.Text = string.Empty;
            txtSach.Text = string.Empty;
            txtSoLuong.Text = string.Empty;
            txtTacGia.Text = string.Empty;
            label6.Text = "Số lượng";
            
            chkSachHiem.Checked = false;

        }

        public void NhapThemSach()
        {
            txtMaNhap.ReadOnly = true;
            txtGiaTien.ReadOnly = true;
            txtMaSach.ReadOnly = true;
            txtNamXB.ReadOnly = true;
            txtNXB.ReadOnly = true;
            txtSach.ReadOnly = true;
            txtSoLuong.ReadOnly = false;
            txtTacGia.ReadOnly = true;
        
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

                   

                    if (sachDTO.SachHiem)
                    {
                        chkSachHiem.Checked = true;
                    }
                    else
                        chkSachHiem.Checked = false;
                }
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {

            NhapSachDTO nhapSachDTO = new NhapSachDTO {

                MaNhap = txtMaNhap.Text,
                MaNV = frmDangNhap.MaNV,
                NgayNhap = DateTime.Now,
                ThanhTien = 0,
                TrangThai = true
   
            };


            CTNhapSachDTO cTNhapSachDTO = new CTNhapSachDTO {

                MaNhap = txtMaNhap.Text,
                MaSach = txtMaSach.Text,
                SoLuong = int.Parse(txtSoLuong.Text),
                DonGia = int.Parse(txtGiaTien.Text)

            };

         

            if(rdoNhapMoi.Checked)
            {
                SachDTO sachDTO = new SachDTO();
                sachDTO.MaSach = txtMaSach.Text;
                sachDTO.TenSach = txtSach.Text;
                sachDTO.MaDauSach = cbbDauSach.SelectedValue.ToString();
                sachDTO.TenTacGia = txtTacGia.Text;
                sachDTO.TenNhaXuatBan = txtNXB.Text;
                sachDTO.NamXuatBan = int.Parse(txtNamXB.Text);
                sachDTO.DonGia = int.Parse(txtGiaTien.Text);
                sachDTO.TrangThai = true;

                if (chkSachHiem.Checked) sachDTO.SachHiem = true;
                else
                    sachDTO.SachHiem = false;
                sachDTO.SoLuong = int.Parse(txtSoLuong.Text);

                if (sachBUS.ThemSachMoi(sachDTO) && nhapSachBUS.NhapSach(nhapSachDTO) && cTNhapSachBUS.ThemCTNhapSach(cTNhapSachDTO))
                {
                    MessageBox.Show(Constrant.ThemThanhCong, Constrant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmNhapSach_Load(sender, e);
                }
                else
                    MessageBox.Show(Constrant.ThemThatBai, Constrant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            if(rdoNhapThem.Checked)
            {
                if (sachBUS.NhapThemSachCu(txtMaSach.Text, int.Parse(txtSoLuong.Text)) && nhapSachBUS.NhapSach(nhapSachDTO) && cTNhapSachBUS.ThemCTNhapSach(cTNhapSachDTO))
                {
                    MessageBox.Show(Constrant.ThemThanhCong, Constrant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmNhapSach_Load(sender, e);
                }
                else
                    MessageBox.Show(Constrant.ThemThatBai, Constrant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtMaSach.Text = sachBUS.PhatSinhMa();
            txtGiaTien.Text = string.Empty;
            txtNamXB.Text = string.Empty;
            txtNXB.Text = string.Empty;
            txtSach.Text = string.Empty;
            txtSoLuong.Text = string.Empty;
            txtTacGia.Text = string.Empty;
            MaNhap = string.Empty;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (txtTimTenSach.Text != null)

                dtgv_Sach.DataSource = sachBUS.SearchBook(txtTimTenSach.Text);
            else
                frmNhapSach_Load(sender, e);
        }


    }
}
