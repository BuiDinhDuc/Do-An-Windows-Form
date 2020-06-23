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
using Microsoft.Reporting.WinForms;
namespace Quản_lý_thư_viện_Tri_Thức
{
    public partial class frmXemBaoCao : Form
    {
        SachBUS sachBUS = new SachBUS();
        public frmXemBaoCao()
        {
            InitializeComponent();
        }

        private void frmXemBaoCao_Load(object sender, EventArgs e)
        {

            this.rptViewer.RefreshReport();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void TatCaSanPham()
        {
            List<SachDTO> dsSach = sachBUS.LayDSSach();


            this.rptViewer.LocalReport.ReportEmbeddedResource = "GUI.rptTatCaSach.rdlc";
            this.rptViewer.LocalReport.DataSources.Add(new ReportDataSource("DSSach", dsSach));
            this.rptViewer.RefreshReport();
        }
    }
}
