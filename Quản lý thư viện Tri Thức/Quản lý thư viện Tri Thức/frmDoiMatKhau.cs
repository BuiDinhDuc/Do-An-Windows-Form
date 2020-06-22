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
    public partial class frmDoiMatKhau : Form
    {
        NhanVienBUS nhanVienBUS = new NhanVienBUS();
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (txtNewPassword.Text != txtReNewPassword.Text)
                MessageBox.Show(Constrant.MatKhauTrungNhau, Constrant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (!nhanVienBUS.KiemTraMatKhau(frmTrangChu.TaiKhoan, txtPassword.Text))
                    MessageBox.Show(Constrant.SaiMatKhau, Constrant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    if (nhanVienBUS.DoiMatKhau(frmTrangChu.TaiKhoan, txtNewPassword.Text))
                    {
                        MessageBox.Show(Constrant.DoiMKThanhCong, Constrant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                        MessageBox.Show(Constrant.DoiMKThatBai, Constrant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                

            }
        }
    }
}
