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
        public static List<MuonSachTamDTO> mst = new List<MuonSachTamDTO>();

        public frmMuonSach()
        {
            InitializeComponent();
        }

        private void frmBorrowBooks_Load(object sender, EventArgs e)
        {


            foreach (SachDTO s in sachBUS.LayDSSach())
            {
                ListViewItem item = new ListViewItem(s.MaSach);

                item.SubItems.Add(s.TenSach);
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
                    x.SubItems.Add(item.SubItems[1].Text);
                    x.SubItems.Add(nudSoLuong.Value.ToString());

                    if (KtraDaThem(x))
                    {
                        lstSachMuon.Items.Add(x);             
                        lsvSach.Items.Remove(item);
                        nudSoLuong.Value = 1;
                        
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
                    x.SubItems.Add(item.SubItems[1].Text);
                    if (KtraDaTra(x))
                    {
                        lsvSach.Items.Add(x);
                        lstSachMuon.Items.Remove(item);

                       
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
          
           foreach(ListViewItem item in lstSachMuon.Items)
            {
                MuonSachTamDTO muonSachTamDTO = new MuonSachTamDTO();
                muonSachTamDTO.MaSach = item.Text;
                muonSachTamDTO.TenSach = item.SubItems[1].Text;
                muonSachTamDTO.SoLuong = int.Parse(item.SubItems[2].Text);

                mst.Add(muonSachTamDTO);
            }
            

           
            frmLapHoaDon frmLapHoaDon = new frmLapHoaDon();
            frmLapHoaDon.ShowDialog();
        }

        private void lstSachMuon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}