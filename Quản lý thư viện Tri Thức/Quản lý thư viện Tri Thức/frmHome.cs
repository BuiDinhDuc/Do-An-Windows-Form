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
    public partial class frmHome : Form
    {
        public static int PhanQuyen = -1;
        public static string NameofUser = string.Empty;

        public frmHome()
        {
            InitializeComponent();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            if (PhanQuyen == 1)
                QuyenQL();
            else if (PhanQuyen == 0)
                QuyenNV();
            else if (PhanQuyen == -1)
                QuyenDG();

            time.Start();
            time_Tick(sender,e);
            this.Show();

        }

        #region Method
        void QuyenQL()
        {
            lblName.Text = NameofUser;
            toolThuVien.Enabled = true;
            toolThuThu.Enabled = true;
            toolDocGia.Enabled = true;
            toolQuanLiSach.Enabled = true;
            toolMuonTra.Enabled = true;
            toolNhapSach.Enabled = true;
            toolThongKe.Enabled = true;
            toolTaiKhoan.Enabled = true;
            toolDangXuat.Enabled = true;
            toolDoiMK.Enabled = true;
            toolDangNhap.Enabled = false;
            toolTimKiem.Enabled = false;
        }

        void QuyenNV()
        {
            lblName.Text = NameofUser;
            toolThuVien.Enabled = true;
            toolThuThu.Enabled = false;
            toolDocGia.Enabled = true;
            toolQuanLiSach.Enabled = true;
            toolMuonTra.Enabled = true;
            toolNhapSach.Enabled = true;
            toolThongKe.Enabled = false;
            toolTaiKhoan.Enabled = true;
            toolDangNhap.Enabled = false;
            toolDangXuat.Enabled = true;
            toolDoiMK.Enabled = true;
            toolTimKiem.Enabled = false;
        }

        void QuyenDG()
        {
            NameofUser = "None";
            toolThuVien.Enabled = false;
            toolQuanLiSach.Enabled = false;
            toolMuonTra.Enabled = false;
            toolNhapSach.Enabled = false;
            toolThongKe.Enabled = false;
            toolTaiKhoan.Enabled = false;
            toolDangNhap.Enabled = true;
            toolTimKiem.Enabled = true;
        }


        #endregion

        private void toolThuThu_Click(object sender, EventArgs e)
        {
            frmLibrarians fThuThu = new frmLibrarians();
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }
            
                fThuThu.MdiParent = this;
                fThuThu.Show();
            
        }

        private void toolDocGia_Click(object sender, EventArgs e)
        {
            frmReaders fDocGia = new frmReaders();
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }
            
                fDocGia.MdiParent = this;
                fDocGia.Show();
            
        }

        private void toolQuyDinh_Click(object sender, EventArgs e)
        {
            frmLaws fQuyDinh = new frmLaws();
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }
            
                fQuyDinh.MdiParent = this;
                fQuyDinh.Show();
            
        }

        private void toolQuanLiSach_Click(object sender, EventArgs e)
        {
            frmBooks fSach = new frmBooks();

            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }
            fSach.MdiParent = this;
            fSach.Show();


        }

        private void toolMuonTra_Click(object sender, EventArgs e)
        {
            frmBorrowBooks fMuonSach = new frmBorrowBooks();
           
                foreach(Form frm in this.MdiChildren)
                {
                    frm.Close();
                }
                fMuonSach.MdiParent = this;
                fMuonSach.Show();
            
        }

        private void toolNhapSach_Click(object sender, EventArgs e)
        {
            frmAddBooks fNhapSach = new frmAddBooks();
           
                foreach (Form frm in this.MdiChildren)
                {
                    frm.Close();
                }
                fNhapSach.MdiParent = this;
                fNhapSach.Show();
            
        }

        private void toolDoiMK_Click(object sender, EventArgs e)
        {
            frmChangePassword fDoiMatKhau = new frmChangePassword();
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }
            
                fDoiMatKhau.MdiParent = this;
                fDoiMatKhau.Show();
            
        }

        private void toolDangXuat_Click(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }
            PhanQuyen = -1;
            frmHome_Load(sender, e);
        }

        private void toolDangNhap_Click(object sender, EventArgs e)
        {
            frmLogin fDangNhap = new frmLogin();
          
                foreach (Form frm in this.MdiChildren)
                {
                    frm.Close();
                }

                 fDangNhap.ShowDialog();
                frmHome_Load(sender, e);
           
            
            
        }

        private void toolTimKiem_Click(object sender, EventArgs e)
        {
            frmSearchBooks fTimKiemSach = new frmSearchBooks();

            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }


            fTimKiemSach.MdiParent = this;
                fTimKiemSach.Show();
            
        }

        private void sttStatus_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void time_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            string hour, minute, second;
            if (now.Hour < 10)
                hour = "0" + now.Hour;
            else
                hour = now.Hour.ToString();

            if (now.Minute < 10)
                minute = "0" + now.Minute;
            else
                minute = now.Minute.ToString();

            if (now.Second < 10)
                second = "0" + now.Second;
            else
                second = now.Second.ToString();

            lblTime.Text = "Time : "+ hour + ":"+minute+":"+second;
            
            

        }
    }
}
