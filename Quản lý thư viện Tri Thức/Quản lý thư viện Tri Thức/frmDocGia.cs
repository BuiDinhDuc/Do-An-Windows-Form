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
            dataDocGia.DataSource = docgiaBUS.LayDSDocGia();
        }

        private void dataDocGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int vitri = e.RowIndex;

            if (vitri < 0)
                return;
            else
            {
                DocGiaDTO docGiaDTO = new DocGiaDTO();
                docGiaDTO = docgiaBUS.timDOcGia(dataDocGia.Rows[vitri].Cells[0].Value.ToString());
                txtMaDocGia.Text = docGiaDTO.MaDocGia;
                txtMaThe.Text = docGiaDTO.SoThe;
                
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }
    }
}
