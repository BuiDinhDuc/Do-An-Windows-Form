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
    public partial class frmDocGia : Form
    {
        DocGiaBUS docgiaBUS = new DocGiaBUS();
        public frmDocGia()
        {
            InitializeComponent();
        }

        private void frmReaders_Load(object sender, EventArgs e)
        {
            dataDocGia.AutoGenerateColumns = false;
            dataDocGia.DataSource = docgiaBUS.LoadDSDocGia();
        }

        private void dataDocGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //int vitri = e.RowIndex;

            //if (vitri < 0)
            //    return;
            //else
            //{
            //    Sach s = docgiaBUS(dataSach.Rows[vitri].Cells[0].Value.ToString());
            //    if (s != null)
            //    {
            //        txtMaSach.Text = s.MaSach;
            //        txtNamXuatBan.Text = s.NamXuatBan.ToString();
            //        txtNhaXuatBan.Text = s.TenNhaXuatBan;
            //        txtSoLuong.Text = s.SoLuong.ToString();
            //        txtTacGia.Text = s.TenTacGia;
            //        txtTenSach.Text = s.TenSach;
            //        cbbTheLoai.SelectedValue = s.MaTheLoai;
            //    }
            //}
        }
    }
}
