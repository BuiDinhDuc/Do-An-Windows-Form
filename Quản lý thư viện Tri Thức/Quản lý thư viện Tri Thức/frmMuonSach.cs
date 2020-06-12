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
    public partial class frmMuonSach : Form
    {
        SachBUS sachBUS = new SachBUS();
        
        public frmMuonSach()
        {
            InitializeComponent();
        }

        private void frmBorrowBooks_Load(object sender, EventArgs e)
        {
           

            //foreach( Sach s in sachBUS.LoadDSSach())
            //{
            //    ListViewItem item = new ListViewItem();

            //    item.Text = s.TenSach;
            //    item.SubItems.Add(s.TenTacGia);
                

            //    lsvSach.Items.Add(item);
              
            //}
        }

        private void btnChoMuon_Click(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection selected = lsvSach.SelectedItems;

            if (selected.Count < 1) return;
            else
            {
                foreach(ListViewItem item in selected)
                {
                    ListViewItem x = new ListViewItem();
                    x.Text = item.Text;

                    lsvSachMuon.Items.Add(x);
                    lsvSach.Items.Remove(item);

                    txtSoLuong.Text = lsvSachMuon.Items.Count.ToString();
                }

            }

        }

        private void btnTraLai_Click(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection selected = lsvSachMuon.SelectedItems;

            if (selected.Count < 1) return;
            else
            {
                foreach (ListViewItem item in selected)
                {
                    ListViewItem x = new ListViewItem();
                    x.Text = item.Text;

                    lsvSach.Items.Add(x);
                    lsvSachMuon.Items.Remove(item);

                    txtSoLuong.Text = lsvSachMuon.Items.Count.ToString();
                }

            }
        }
    }
}
