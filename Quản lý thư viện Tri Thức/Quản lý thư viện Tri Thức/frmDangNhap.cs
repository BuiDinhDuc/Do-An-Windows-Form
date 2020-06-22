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


namespace Quản_lý_thư_viện_Tri_Thức
{
    public partial class frmDangNhap : Form
    {
        NhanVienBUS nhanvienBUS = new NhanVienBUS();
        public static string MaNV = string.Empty;
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (nhanvienBUS.KtraDangNhap(txtUsername.Text, txtPassword.Text, ref frmTrangChu.NameofUser, ref frmTrangChu.PhanQuyen,ref MaNV,ref frmTrangChu.TaiKhoan))
            {
                MessageBox.Show(Constrant.DangNhapThanhCong,Constrant.ThongBao,MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Close();
            }
            else
                MessageBox.Show(Constrant.LoiDangNhap,Constrant.ThongBao,MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
