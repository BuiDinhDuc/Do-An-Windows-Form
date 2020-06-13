namespace Quản_lý_thư_viện_Tri_Thức
{
    partial class frmTrangChu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.toolNhapSach = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMuonTra = new System.Windows.Forms.ToolStripMenuItem();
            this.toolQuanLiSach = new System.Windows.Forms.ToolStripMenuItem();
            this.toolQuyDinh = new System.Windows.Forms.ToolStripMenuItem();
            this.toolDocGia = new System.Windows.Forms.ToolStripMenuItem();
            this.toolThuThu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolThuVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnusMenu = new System.Windows.Forms.MenuStrip();
            this.toolThongKe = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.toolDoiMK = new System.Windows.Forms.ToolStripMenuItem();
            this.toolDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.toolDangNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTimKiem = new System.Windows.Forms.ToolStripMenuItem();
            this.sttStatus = new System.Windows.Forms.StatusStrip();
            this.lblCurrentUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblName = new System.Windows.Forms.ToolStripStatusLabel();
            this.time = new System.Windows.Forms.Timer(this.components);
            this.lblTime = new System.Windows.Forms.Label();
            this.mnusMenu.SuspendLayout();
            this.sttStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolNhapSach
            // 
            this.toolNhapSach.Name = "toolNhapSach";
            this.toolNhapSach.Size = new System.Drawing.Size(86, 54);
            this.toolNhapSach.Text = "Nhập sách";
            this.toolNhapSach.Click += new System.EventHandler(this.toolNhapSach_Click);
            // 
            // toolMuonTra
            // 
            this.toolMuonTra.Name = "toolMuonTra";
            this.toolMuonTra.Size = new System.Drawing.Size(120, 54);
            this.toolMuonTra.Text = "Mượn - trả sách";
            this.toolMuonTra.Click += new System.EventHandler(this.toolMuonTra_Click);
            // 
            // toolQuanLiSach
            // 
            this.toolQuanLiSach.BackColor = System.Drawing.Color.Lavender;
            this.toolQuanLiSach.Image = global::Quản_lý_thư_viện_Tri_Thức.Properties.Resources.Edit;
            this.toolQuanLiSach.Name = "toolQuanLiSach";
            this.toolQuanLiSach.Size = new System.Drawing.Size(115, 54);
            this.toolQuanLiSach.Text = "Quản lý sách";
            this.toolQuanLiSach.Click += new System.EventHandler(this.toolQuanLiSach_Click);
            // 
            // toolQuyDinh
            // 
            this.toolQuyDinh.Name = "toolQuyDinh";
            this.toolQuyDinh.Size = new System.Drawing.Size(172, 24);
            this.toolQuyDinh.Text = "Quy định chung";
            this.toolQuyDinh.Click += new System.EventHandler(this.toolQuyDinh_Click);
            // 
            // toolDocGia
            // 
            this.toolDocGia.Name = "toolDocGia";
            this.toolDocGia.Size = new System.Drawing.Size(172, 24);
            this.toolDocGia.Text = "Độc giả";
            this.toolDocGia.Click += new System.EventHandler(this.toolDocGia_Click);
            // 
            // toolThuThu
            // 
            this.toolThuThu.Name = "toolThuThu";
            this.toolThuThu.Size = new System.Drawing.Size(172, 24);
            this.toolThuThu.Text = "Thủ thư";
            this.toolThuThu.Click += new System.EventHandler(this.toolThuThu_Click);
            // 
            // toolThuVien
            // 
            this.toolThuVien.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolThuThu,
            this.toolDocGia,
            this.toolQuyDinh});
            this.toolThuVien.Name = "toolThuVien";
            this.toolThuVien.Size = new System.Drawing.Size(74, 54);
            this.toolThuVien.Text = "Thư viện";
            // 
            // mnusMenu
            // 
            this.mnusMenu.AutoSize = false;
            this.mnusMenu.BackColor = System.Drawing.Color.Lavender;
            this.mnusMenu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnusMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolThuVien,
            this.toolQuanLiSach,
            this.toolMuonTra,
            this.toolNhapSach,
            this.toolThongKe,
            this.toolTaiKhoan,
            this.toolDangNhap,
            this.toolTimKiem});
            this.mnusMenu.Location = new System.Drawing.Point(0, 0);
            this.mnusMenu.Name = "mnusMenu";
            this.mnusMenu.Size = new System.Drawing.Size(1174, 58);
            this.mnusMenu.TabIndex = 7;
            this.mnusMenu.Text = "menuStrip1";
            // 
            // toolThongKe
            // 
            this.toolThongKe.Image = global::Quản_lý_thư_viện_Tri_Thức.Properties.Resources.report_sach;
            this.toolThongKe.Name = "toolThongKe";
            this.toolThongKe.Size = new System.Drawing.Size(94, 54);
            this.toolThongKe.Text = "Thống kê";
            // 
            // toolTaiKhoan
            // 
            this.toolTaiKhoan.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolDoiMK,
            this.toolDangXuat});
            this.toolTaiKhoan.Image = global::Quản_lý_thư_viện_Tri_Thức.Properties.Resources.Login_Manager;
            this.toolTaiKhoan.Name = "toolTaiKhoan";
            this.toolTaiKhoan.Size = new System.Drawing.Size(143, 54);
            this.toolTaiKhoan.Text = "Quản lý tài khoản";
            // 
            // toolDoiMK
            // 
            this.toolDoiMK.Name = "toolDoiMK";
            this.toolDoiMK.Size = new System.Drawing.Size(159, 24);
            this.toolDoiMK.Text = "Đổi mật khẩu";
            this.toolDoiMK.Click += new System.EventHandler(this.toolDoiMK_Click);
            // 
            // toolDangXuat
            // 
            this.toolDangXuat.Name = "toolDangXuat";
            this.toolDangXuat.Size = new System.Drawing.Size(159, 24);
            this.toolDangXuat.Text = "Đăng xuất";
            this.toolDangXuat.Click += new System.EventHandler(this.toolDangXuat_Click);
            // 
            // toolDangNhap
            // 
            this.toolDangNhap.Image = global::Quản_lý_thư_viện_Tri_Thức.Properties.Resources.Lock;
            this.toolDangNhap.Name = "toolDangNhap";
            this.toolDangNhap.Size = new System.Drawing.Size(102, 54);
            this.toolDangNhap.Text = "Đăng nhập";
            this.toolDangNhap.Click += new System.EventHandler(this.toolDangNhap_Click);
            // 
            // toolTimKiem
            // 
            this.toolTimKiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolTimKiem.Image = global::Quản_lý_thư_viện_Tri_Thức.Properties.Resources.tìm_kiếm;
            this.toolTimKiem.Name = "toolTimKiem";
            this.toolTimKiem.Size = new System.Drawing.Size(134, 54);
            this.toolTimKiem.Text = "Tìm kiếm sách";
            this.toolTimKiem.Click += new System.EventHandler(this.toolTimKiem_Click);
            // 
            // sttStatus
            // 
            this.sttStatus.AutoSize = false;
            this.sttStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblCurrentUser,
            this.lblName});
            this.sttStatus.Location = new System.Drawing.Point(0, 637);
            this.sttStatus.Name = "sttStatus";
            this.sttStatus.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.sttStatus.Size = new System.Drawing.Size(1174, 24);
            this.sttStatus.SizingGrip = false;
            this.sttStatus.TabIndex = 11;
            this.sttStatus.Text = "statusStrip1";
            this.sttStatus.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.sttStatus_ItemClicked);
            // 
            // lblCurrentUser
            // 
            this.lblCurrentUser.BackColor = System.Drawing.SystemColors.Control;
            this.lblCurrentUser.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblCurrentUser.Name = "lblCurrentUser";
            this.lblCurrentUser.Size = new System.Drawing.Size(138, 19);
            this.lblCurrentUser.Text = "Người dùng hiện tại : ";
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 19);
            // 
            // time
            // 
            this.time.Tick += new System.EventHandler(this.time_Tick);
            // 
            // lblTime
            // 
            this.lblTime.Location = new System.Drawing.Point(1050, 636);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(124, 27);
            this.lblTime.TabIndex = 13;
            // 
            // frmTrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(1174, 661);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.sttStatus);
            this.Controls.Add(this.mnusMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmTrangChu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.mnusMenu.ResumeLayout(false);
            this.mnusMenu.PerformLayout();
            this.sttStatus.ResumeLayout(false);
            this.sttStatus.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem toolDangNhap;
        public System.Windows.Forms.ToolStripMenuItem toolDangXuat;
        public System.Windows.Forms.ToolStripMenuItem toolDoiMK;
        public System.Windows.Forms.ToolStripMenuItem toolTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem toolThongKe;
        public System.Windows.Forms.ToolStripMenuItem toolNhapSach;
        public System.Windows.Forms.ToolStripMenuItem toolMuonTra;
        public System.Windows.Forms.ToolStripMenuItem toolQuanLiSach;
        public System.Windows.Forms.ToolStripMenuItem toolQuyDinh;
        public System.Windows.Forms.ToolStripMenuItem toolDocGia;
        public System.Windows.Forms.ToolStripMenuItem toolThuThu;
        public System.Windows.Forms.ToolStripMenuItem toolThuVien;
        public System.Windows.Forms.MenuStrip mnusMenu;
        private System.Windows.Forms.ToolStripMenuItem toolTimKiem;
        private System.Windows.Forms.StatusStrip sttStatus;
        private System.Windows.Forms.ToolStripStatusLabel lblCurrentUser;
        private System.Windows.Forms.ToolStripStatusLabel lblName;
        private System.Windows.Forms.Timer time;
        private System.Windows.Forms.Label lblTime;
    }
}

