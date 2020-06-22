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
        public static List<SachDTO> sach = new List<SachDTO>();
        public frmMuonSach()
        {
            InitializeComponent();
        }

        private void frmBorrowBooks_Load(object sender, EventArgs e)
        {


            foreach (SachDTO s in sachBUS.LayDSSach())
            {
                ListViewItem item = new ListViewItem();

                item.Text = s.TenSach;
                item.SubItems.Add(s.TenTacGia);


                lsvSach.Items.Add(item);

            }
        }

        private void btnChoMuon_Click(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection selected = lsvSach.SelectedItems;

            if (selected.Count < 1) return;
            else
            {
                foreach (ListViewItem item in selected)
                {
                    ListViewItem x = new ListViewItem();
                    x.Text = item.Text;

                    if (KtraDaThem(x))
                    {
                        lstSachMuon.Items.Add(x);
                        lsvSach.Items.Remove(item);

                        txtSoLuong.Text = lstSachMuon.Items.Count.ToString();
                    }
                    else return;
                }

            }

        }

        private bool KtraDaThem(ListViewItem listViewItem)
        {
            foreach(ListViewItem x in lstSachMuon.Items)
            {
                if (x.Text == listViewItem.Text)
                    return false;
            }
            return true;
        }

        private bool KtraDaTra(ListViewItem listViewItem)
        {
            foreach (ListViewItem x in lsvSach.Items)
            {
                if (x.Text == listViewItem.Text)
                    return false;
            }
            return true;
        }

        private void btnTraLai_Click(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection selected = lstSachMuon.SelectedItems;

            if (selected.Count < 1) return;
            else
            {
                foreach (ListViewItem item in selected)
                {
                    ListViewItem x = new ListViewItem();
                    x.Text = item.Text;

                    if (KtraDaTra(x))
                    {
                        lsvSach.Items.Add(x);
                        lstSachMuon.Items.Remove(item);

                        txtSoLuong.Text = lstSachMuon.Items.Count.ToString();
                    }
                    else return;
                }

            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.Text != null)

            {
                lsvSach.Items.Clear();
                foreach (SachDTO s in sachBUS.SearchBookWithName(txtTimKiem.Text))
                {
                    ListViewItem item = new ListViewItem();

                    item.Text = s.TenSach;
                    item.SubItems.Add(s.TenTacGia);


                    lsvSach.Items.Add(item);

                }

            }
            else
                frmBorrowBooks_Load(sender, e);




         }

        private void btnLapHoaDon_Click(object sender, EventArgs e)
        {
            List<string> listsach = new List<string>();

            foreach(ListViewItem listViewItem in lstSachMuon.Items)
            {
                listsach.Add(listViewItem.Text);
            }

            sach = sachBUS.LayDSSachDuocChon(listsach);


            frmLapHoaDon frmLapHoaDon = new frmLapHoaDon();
            frmLapHoaDon.ShowDialog();
        }
    }
}