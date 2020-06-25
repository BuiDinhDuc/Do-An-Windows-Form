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
    public partial class frmSach : Form
    {
        SachBUS sachBUS = new SachBUS();
        TheLoaiBUS theloaiBUS = new TheLoaiBUS();
        DauSachBUS dausachBUS = new DauSachBUS();
        public frmSach()
        {
            InitializeComponent();
        }

        private void frmBooks_Load(object sender, EventArgs e)
        {
            //load vao datagridview
            dataSach.AutoGenerateColumns = false;
            dataSach.DataSource = sachBUS.LayDSSach();

            //load vao combobox Dau Sach
            cbbDauSach.DataSource = dausachBUS.LayDSDauSach();
            cbbDauSach.DisplayMember = "TenDauSach";
            cbbDauSach.ValueMember = "MaDauSach";

            cbbDauSach.SelectedIndex = 0;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string MaSach = txtMaSach.Text;
            sachBUS.DeleteBooks(MaSach);
            MessageBox.Show(Constrant.XoaThanhCong,Constrant.ThongBao,MessageBoxButtons.OK,MessageBoxIcon.Information);
            frmBooks_Load(sender, e);
        }

        private void dataSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int vitri = e.RowIndex;

            if (vitri < 0)
                return;
            else
            {
                SachDTO s = sachBUS.timSach(dataSach.Rows[vitri].Cells[0].Value.ToString());
                if (s != null)
                {
                    txtMaSach.Text = s.MaSach;
                    txtNamXuatBan.Text = s.NamXuatBan.ToString();
                    cbbDauSach.SelectedValue = s.MaDauSach;
                    txtNhaXuatBan.Text = s.TenNhaXuatBan;
                    txtSoLuong.Text = s.SoLuong.ToString();
                    txtTacGia.Text = s.TenTacGia;
                    txtTenSach.Text = s.TenSach;
                    txtTheLoai.Text = theloaiBUS.timTheLoai(s.MaTheLoai).TenTheLoai;
                    txtGiaTien.Text = ((int)s.DonGia).ToString();
                    if (s.SachHiem)
                    {
                        chkSachHiem.Checked = true;
                    }
                    else
                        chkSachHiem.Checked = false;
                }
            } 
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            SachDTO s = new SachDTO();
            s.MaSach = txtMaSach.Text;
            s.TenSach = txtTenSach.Text;
            s.MaDauSach = cbbDauSach.SelectedValue.ToString();
            s.TenTacGia = txtTacGia.Text;
            s.MaTheLoai = cbbDauSach.SelectedValue.ToString();
            s.TenNhaXuatBan = txtNhaXuatBan.Text;
            s.NamXuatBan = Int32.Parse(txtNamXuatBan.Text);
            s.SoLuong = Convert.ToInt32( txtSoLuong.Text);
            s.DonGia = Convert.ToDecimal(txtGiaTien.Text);
            s.SachHiem = chkSachHiem.Checked ? true : false;
            sachBUS.Editbook(s);
            MessageBox.Show(Constrant.SuaThanhCong,Constrant.ThongBao,MessageBoxButtons.OK,MessageBoxIcon.Information);
            frmBooks_Load(sender, e);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtMaSach.Text = string.Empty;
            txtGiaTien.Text = string.Empty;
            txtNamXuatBan.Text = string.Empty;
            txtNhaXuatBan.Text = string.Empty;
            txtSoLuong.Text = string.Empty;
            txtTacGia.Text = string.Empty;
            txtTenSach.Text = string.Empty;
            
            chkSachHiem.Checked = false;

        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.Text != null)

                dataSach.DataSource = sachBUS.SearchBook(txtTimKiem.Text);
            else
                frmBooks_Load(sender, e);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
