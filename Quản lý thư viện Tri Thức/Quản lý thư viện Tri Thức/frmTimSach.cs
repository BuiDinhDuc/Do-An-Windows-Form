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
    public partial class frmTimSach : Form
    {
        SachBUS sachBUS = new SachBUS();
        TheLoaiBUS theloaiBUS = new TheLoaiBUS();

        public frmTimSach()
        {
            InitializeComponent();
        }



        private void frmSearchBooks_Load(object sender, EventArgs e)
        {
            dataSach.AutoGenerateColumns = false;
            dataSach.DataSource = sachBUS.LayDSSach();

            //
            cbbTheLoai.DataSource = theloaiBUS.LayDSTheLoai();
            cbbTheLoai.DisplayMember = "TenTheLoai";
            cbbTheLoai.ValueMember = "MaTheLoai";

            DataGridViewComboBoxColumn dtgvcol = (DataGridViewComboBoxColumn)MaTheLoai;


            dtgvcol.DataSource = theloaiBUS.LayDSTheLoai();
            dtgvcol.DisplayMember = "TenTheLoai";
            dtgvcol.ValueMember = "MaTheLoai";

            DataGridViewCheckBoxColumn dtgvchk = (DataGridViewCheckBoxColumn)SachHiem;

            dtgvchk.TrueValue = 0;
            dtgvchk.FalseValue = 1;

        }

        private void dataSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int vitri = e.RowIndex;

            if (vitri >= 0)
            {
                SachDTO s = sachBUS.timSach(dataSach.Rows[vitri].Cells[0].Value.ToString());
                if (s != null)
                {

                    txtNamXuatBan.Text = s.NamXuatBan.ToString();
                    txtNhaXuatBan.Text = s.TenNhaXuatBan;

                    txtTacGia.Text = s.TenTacGia;
                    txtTenSach.Text = s.TenSach;
                    cbbTheLoai.SelectedValue = s.MaTheLoai;
                    txtGiaTien.Text = ((int)s.DonGia).ToString();
                    if (s.SachHiem == true)
                    {
                        chkDuocMuon.Checked = true;
                    }
                    else
                        chkDuocMuon.Checked = false;

                }
                else
                    return;
            }
        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {

            if (txtTimKiem.Text != null)

                dataSach.DataSource = sachBUS.SearchBook(txtTimKiem.Text);
            else
                frmSearchBooks_Load(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
