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
    public partial class frmNhanVien : Form
    {
        NhanVienBUS nhanvienBUS = new NhanVienBUS();
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void frmLibrarians_Load(object sender, EventArgs e)
        {
            dataThuThu.AutoGenerateColumns = false;
            dataThuThu.DataSource = nhanvienBUS.LayDSNhanVien();

            NhanVienDTO nv = nhanvienBUS.timNhanVien(dataThuThu.Rows[0].Cells[0].Value.ToString());

            txtMaNV.Text = nv.MaNV;
            txtHoTenNV.Text = nv.HoTenNV;
            txtSDT.Text = nv.SDT;
            dtmNgSinh.Value = nv.NgSinh;

        }

        private void dataThuThu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int vitri = e.RowIndex;

            if (vitri < 0)
                return;
            else
            {
                NhanVienDTO nv = nhanvienBUS.timNhanVien(dataThuThu.Rows[vitri].Cells[0].Value.ToString());

                txtMaNV.Text = nv.MaNV;
                txtHoTenNV.Text = nv.HoTenNV;
                txtSDT.Text = nv.SDT;
                dtmNgSinh.Value = nv.NgSinh;

            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaNV.Text = string.Empty;
            txtHoTenNV.Text = string.Empty;
            txtSDT.Text = string.Empty;
            dtmNgSinh.Value = DateTime.Now;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (nhanvienBUS.xoaNhanVien(txtMaNV.Text))
                MessageBox.Show(Constrant.XoaThanhCong, Constrant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(Constrant.XoaThatBai, Constrant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Error);
            frmLibrarians_Load(sender, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            NhanVienDTO nv = nhanvienBUS.timNhanVien(txtMaNV.Text);
            nv.HoTenNV = txtHoTenNV.Text;
            nv.NgSinh = dtmNgSinh.Value;
            nv.SDT = txtSDT.Text;


            if (nhanvienBUS.suaNhanVien(nv))
                MessageBox.Show(Constrant.SuaThanhCong, Constrant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(Constrant.SuaThatBai, Constrant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Error);
            frmLibrarians_Load(sender, e);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmThemNhanVien fThemNV = new frmThemNhanVien();
            fThemNV.ShowDialog();
            frmLibrarians_Load(sender,e);
        }
    }
}
