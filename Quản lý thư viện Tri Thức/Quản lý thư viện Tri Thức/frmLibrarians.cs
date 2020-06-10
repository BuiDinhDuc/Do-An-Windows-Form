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
    public partial class frmLibrarians : Form
    {
        NhanVienBUS nhanvienBUS = new NhanVienBUS();
        public frmLibrarians()
        {
            InitializeComponent();
        }

        private void frmLibrarians_Load(object sender, EventArgs e)
        {
            dataThuThu.AutoGenerateColumns = false;
            dataThuThu.DataSource = nhanvienBUS.LoadDSNhanVien();

            txtMaNV.DataBindings.Add("Text", dataThuThu.DataSource, "MaNV");
            txtHoTenNV.DataBindings.Add("Text", dataThuThu.DataSource, "HoTenNV");
            dtmNgSinh.DataBindings.Add("Text",dataThuThu.DataSource,"NgSinh");
            txtSDT.DataBindings.Add("Text", dataThuThu.DataSource, "SDT");

        }
    }
}
