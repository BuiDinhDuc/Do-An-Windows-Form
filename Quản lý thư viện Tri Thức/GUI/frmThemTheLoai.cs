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
    public partial class frmThemTheLoai : Form
    {
        TheLoaiBUS TheLoaiBUS = new TheLoaiBUS();
        
        public frmThemTheLoai()
        {
            InitializeComponent();
            txtMaTheLoai.Text = TheLoaiBUS.PhatSinhMa();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            TheLoaiDTO theLoaiDTO = new TheLoaiDTO();
            theLoaiDTO.MaTheLoai = txtMaTheLoai.Text;
            theLoaiDTO.TenTheLoai = txtTenTheLoai.Text;
            theLoaiDTO.TrangThai = true;

            if(TheLoaiBUS.themTheLoai(theLoaiDTO))
            {
                MessageBox.Show(Constrant.ThemThanhCong, Constrant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
                MessageBox.Show(Constrant.ThemThatBai, Constrant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
