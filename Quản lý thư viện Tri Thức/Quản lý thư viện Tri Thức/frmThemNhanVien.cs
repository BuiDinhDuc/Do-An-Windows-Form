using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using BUS;
using DTO;
namespace Quản_lý_thư_viện_Tri_Thức
{
    public partial class frmThemNhanVien : Form
    {
        NhanVienBUS nhanvienBUS = new NhanVienBUS();


        public frmThemNhanVien()
        {
            InitializeComponent();
        }

        private void frmThemNhanVien_Load(object sender, EventArgs e)
        {



            string MaNV = nhanvienBUS.phatsinhma();
            txtMaNV.Text = MaNV;

            rdoThuThu.Checked = true;
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (txtPass.Text == txtRePass.Text)
            {

                    string mkmahoa = GetMD5(txtPass.Text);

                    NhanVienDTO nhanVienDTO = new NhanVienDTO
                    {


                        MaNV = txtMaNV.Text,
                        HoTenNV = txtHoTen.Text,
                        NgSinh = dtmNgSinh.Value,
                        SDT = txtSDT.Text,
                        TaiKhoan = txtTaiKhoan.Text,
                        MatKhau = mkmahoa,
                        Quyen = rdoThuThu.Checked ? 0 : 1

                    };
                if (nhanvienBUS.themNhanVien(nhanVienDTO))
                {
                    MessageBox.Show(Constrant.ThemThanhCong, Constrant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    
                }
                else
                    MessageBox.Show(Constrant.ThemThatBai, Constrant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Error);
               
                
                
            }
            else
                MessageBox.Show(Constrant.MatKhauTrungNhau, Constrant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        

        public String GetMD5(string MatKhau)
        {
            String str = String.Empty;
            Byte[] buffer = System.Text.Encoding.UTF8.GetBytes(MatKhau);

            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            buffer = md5.ComputeHash(buffer);

            foreach (Byte b in buffer)
            {
                str += b.ToString("x2");
            }


            return str;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
