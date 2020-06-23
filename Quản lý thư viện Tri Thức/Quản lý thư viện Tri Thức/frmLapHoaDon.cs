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
    public partial class frmLapHoaDon : Form
    {
        MuonSachBUS muonSachBUS = new MuonSachBUS();
        public frmLapHoaDon()
        {
            InitializeComponent();
        }
        
        private void frmLapHoaDon_Load(object sender, EventArgs e)
        {
            List<SachDTO> sachDTOs = new List<SachDTO>();
            sachDTOs = frmMuonSach.sach;
            double Tongtien = 0;
            int idem = 0;
            foreach (SachDTO s in sachDTOs)
            {
                ListViewItem item = new ListViewItem();

                item.Text = s.TenSach;
                item.SubItems.Add(s.TenTacGia);
                double tien = (double)s.DonGia * frmMuonSach.soluong[idem];
                int soLuong = s.SoLuong;
                item.SubItems.Add(frmMuonSach.soluong[idem].ToString());
                item.SubItems.Add(s.DonGia.ToString());
                item.SubItems.Add(tien.ToString());
                lsvSach.Items.Add(item);
                Tongtien += tien;
                idem++;
            }
            txtTongTien.Text = Tongtien.ToString();

            txtTenNhanVien.Text = frmTrangChu.NameofUser;

            txtMaMuon.Text = muonSachBUS.phatSinhMa();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {

        }
    }
}
