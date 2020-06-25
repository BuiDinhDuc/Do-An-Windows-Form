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
using System.Data.SqlClient;
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
        
            List<SachDTO> sachDTOs = new List<SachDTO>();
            sachDTOs = sachBUS.LayDSSach();
           
            rptSach rptSach = new rptSach();
            rptSach.SetDataSource(sachDTOs);
            cRVSach.ReportSource = rptSach;
          
        }
  
    }
}
