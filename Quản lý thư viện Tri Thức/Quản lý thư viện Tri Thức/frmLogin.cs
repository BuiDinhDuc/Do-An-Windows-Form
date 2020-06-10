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
    public partial class frmLogin : Form
    {
        NhanVienBUS nhanvienBUS = new NhanVienBUS();
        
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (nhanvienBUS.KtraDangNhap(txtUsername.Text, txtPassword.Text, ref frmHome.NameofUser, ref frmHome.PhanQuyen))
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
