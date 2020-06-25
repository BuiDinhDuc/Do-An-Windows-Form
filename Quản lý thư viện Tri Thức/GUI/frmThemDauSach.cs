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
    public partial class frmThemDauSach : Form
    {
        DauSachBUS DauSachBUS = new DauSachBUS();
        TheLoaiBUS TheLoaiBUS = new TheLoaiBUS();
        public frmThemDauSach()
        {
            InitializeComponent();
        }

        private void frmThemDauSach_Load(object sender, EventArgs e)
        {
            cbbTheLoai.DataSource = TheLoaiBUS.LayDSTheLoai();
            cbbTheLoai.DisplayMember = "TenTheLoai";
            cbbTheLoai.ValueMember = "MaTheLoai";

            txtMaDauSach.Text = DauSachBUS.PhatSinhMa();
            cbbTheLoai.SelectedItem = 0;
            txtTenDauSach.Text = string.Empty;
            
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThemTheLoai_Click(object sender, EventArgs e)
        {
            frmThemTheLoai frmTTL = new frmThemTheLoai();
            frmTTL.ShowDialog();
            frmThemDauSach_Load(sender, e);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DauSachDTO dauSachDTO = new DauSachDTO
            {
                MaDauSach = txtMaDauSach.Text,
                TenDauSach = txtTenDauSach.Text,
                MaTheLoai = cbbTheLoai.SelectedValue.ToString(),
                TrangThai = true

            };

            if (DauSachBUS.ThemDauSach(dauSachDTO))
            {
                MessageBox.Show(Constrant.ThemThanhCong, Constrant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmThemDauSach_Load(sender, e);
            }
            else
                MessageBox.Show(Constrant.ThemThatBai, Constrant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
