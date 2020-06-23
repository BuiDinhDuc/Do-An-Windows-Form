using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quản_lý_thư_viện_Tri_Thức
{
    public partial class frmChonXemThongKe : Form
    {
        public frmChonXemThongKe()
        {
            InitializeComponent();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if(rdoTatCaSanPham.Checked)
            {
                frmXemBaoCao f = new frmXemBaoCao();
                f.TatCaSanPham();
                f.ShowDialog();
            }
        }
    }
}
