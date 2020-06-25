namespace Quản_lý_thư_viện_Tri_Thức
{
    partial class frmNhapSach
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
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.txtTacGia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNamXB = new System.Windows.Forms.TextBox();
            this.cbbDauSach = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNXB = new System.Windows.Forms.TextBox();
            this.txtSach = new System.Windows.Forms.TextBox();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMaSach = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.grpNhapSach = new System.Windows.Forms.GroupBox();
            this.txtMaNhap = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.chkSachHiem = new System.Windows.Forms.CheckBox();
            this.txtGiaTien = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.dtgv_Sach = new System.Windows.Forms.DataGridView();
            this.MaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTacGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoNhapThem = new System.Windows.Forms.RadioButton();
            this.rdoNhapMoi = new System.Windows.Forms.RadioButton();
            this.txtTimTenSach = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.grpNhapSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Sach)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(281, 343);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(102, 41);
            this.btnLamMoi.TabIndex = 10;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtTacGia
            // 
            this.txtTacGia.Location = new System.Drawing.Point(157, 163);
            this.txtTacGia.Name = "txtTacGia";
            this.txtTacGia.Size = new System.Drawing.Size(226, 23);
            this.txtTacGia.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Năm xuất bản";
            // 
            // txtNamXB
            // 
            this.txtNamXB.Location = new System.Drawing.Point(157, 223);
            this.txtNamXB.Name = "txtNamXB";
            this.txtNamXB.Size = new System.Drawing.Size(226, 23);
            this.txtNamXB.TabIndex = 5;
            // 
            // cbbDauSach
            // 
            this.cbbDauSach.FormattingEnabled = true;
            this.cbbDauSach.Location = new System.Drawing.Point(157, 133);
            this.cbbDauSach.Name = "cbbDauSach";
            this.cbbDauSach.Size = new System.Drawing.Size(226, 24);
            this.cbbDauSach.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nhà xuất bản";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đầu sách";
            // 
            // txtNXB
            // 
            this.txtNXB.Location = new System.Drawing.Point(157, 193);
            this.txtNXB.Name = "txtNXB";
            this.txtNXB.Size = new System.Drawing.Size(226, 23);
            this.txtNXB.TabIndex = 4;
            // 
            // txtSach
            // 
            this.txtSach.Location = new System.Drawing.Point(157, 103);
            this.txtSach.Name = "txtSach";
            this.txtSach.Size = new System.Drawing.Size(226, 23);
            this.txtSach.TabIndex = 1;
            // 
            // txtMaSach
            // 
            this.txtMaSach.Location = new System.Drawing.Point(157, 73);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.ReadOnly = true;
            this.txtMaSach.Size = new System.Drawing.Size(226, 23);
            this.txtMaSach.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tác giả";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên sách";
            // 
            // lblMaSach
            // 
            this.lblMaSach.AutoSize = true;
            this.lblMaSach.Location = new System.Drawing.Point(21, 77);
            this.lblMaSach.Name = "lblMaSach";
            this.lblMaSach.Size = new System.Drawing.Size(61, 17);
            this.lblMaSach.TabIndex = 0;
            this.lblMaSach.Text = "Mã sách";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(157, 343);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(102, 41);
            this.btnOK.TabIndex = 9;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // grpNhapSach
            // 
            this.grpNhapSach.BackColor = System.Drawing.Color.PowderBlue;
            this.grpNhapSach.Controls.Add(this.txtMaNhap);
            this.grpNhapSach.Controls.Add(this.label7);
            this.grpNhapSach.Controls.Add(this.chkSachHiem);
            this.grpNhapSach.Controls.Add(this.txtGiaTien);
            this.grpNhapSach.Controls.Add(this.label6);
            this.grpNhapSach.Controls.Add(this.txtSoLuong);
            this.grpNhapSach.Controls.Add(this.btnLamMoi);
            this.grpNhapSach.Controls.Add(this.label9);
            this.grpNhapSach.Controls.Add(this.btnOK);
            this.grpNhapSach.Controls.Add(this.txtTacGia);
            this.grpNhapSach.Controls.Add(this.label5);
            this.grpNhapSach.Controls.Add(this.txtNamXB);
            this.grpNhapSach.Controls.Add(this.cbbDauSach);
            this.grpNhapSach.Controls.Add(this.label2);
            this.grpNhapSach.Controls.Add(this.label1);
            this.grpNhapSach.Controls.Add(this.txtNXB);
            this.grpNhapSach.Controls.Add(this.txtSach);
            this.grpNhapSach.Controls.Add(this.txtMaSach);
            this.grpNhapSach.Controls.Add(this.label4);
            this.grpNhapSach.Controls.Add(this.label3);
            this.grpNhapSach.Controls.Add(this.lblMaSach);
            this.grpNhapSach.Location = new System.Drawing.Point(748, 151);
            this.grpNhapSach.Name = "grpNhapSach";
            this.grpNhapSach.Size = new System.Drawing.Size(410, 390);
            this.grpNhapSach.TabIndex = 10;
            this.grpNhapSach.TabStop = false;
            this.grpNhapSach.Text = "Thông tin nhập sách";
            // 
            // txtMaNhap
            // 
            this.txtMaNhap.Location = new System.Drawing.Point(156, 43);
            this.txtMaNhap.Name = "txtMaNhap";
            this.txtMaNhap.ReadOnly = true;
            this.txtMaNhap.Size = new System.Drawing.Size(226, 23);
            this.txtMaNhap.TabIndex = 12;
           
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Mã nhập";
            
            // 
            // chkSachHiem
            // 
            this.chkSachHiem.AutoSize = true;
            this.chkSachHiem.Location = new System.Drawing.Point(157, 312);
            this.chkSachHiem.Name = "chkSachHiem";
            this.chkSachHiem.Size = new System.Drawing.Size(93, 21);
            this.chkSachHiem.TabIndex = 8;
            this.chkSachHiem.Text = "Sách hiếm";
            this.chkSachHiem.UseVisualStyleBackColor = true;
            // 
            // txtGiaTien
            // 
            this.txtGiaTien.Location = new System.Drawing.Point(157, 253);
            this.txtGiaTien.Name = "txtGiaTien";
            this.txtGiaTien.Size = new System.Drawing.Size(226, 23);
            this.txtGiaTien.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Số lượng";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(157, 283);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(226, 23);
            this.txtSoLuong.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 256);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 17);
            this.label9.TabIndex = 11;
            this.label9.Text = "Giá tiền";
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.Location = new System.Drawing.Point(482, 9);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(189, 39);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "Nhập sách";
            // 
            // dtgv_Sach
            // 
            this.dtgv_Sach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_Sach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_Sach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSach,
            this.TenSach,
            this.TenTacGia,
            this.SoLuong});
            this.dtgv_Sach.Location = new System.Drawing.Point(0, 151);
            this.dtgv_Sach.Name = "dtgv_Sach";
            this.dtgv_Sach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv_Sach.Size = new System.Drawing.Size(742, 390);
            this.dtgv_Sach.TabIndex = 11;
            this.dtgv_Sach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_Sach_CellClick);
            // 
            // MaSach
            // 
            this.MaSach.DataPropertyName = "MaSach";
            this.MaSach.FillWeight = 80F;
            this.MaSach.HeaderText = "Mã sách";
            this.MaSach.Name = "MaSach";
            // 
            // TenSach
            // 
            this.TenSach.DataPropertyName = "TenSach";
            this.TenSach.FillWeight = 273.2625F;
            this.TenSach.HeaderText = "Tên sách";
            this.TenSach.Name = "TenSach";
            // 
            // TenTacGia
            // 
            this.TenTacGia.DataPropertyName = "TenTacGia";
            this.TenTacGia.FillWeight = 157.9146F;
            this.TenTacGia.HeaderText = "Tác giả";
            this.TenTacGia.Name = "TenTacGia";
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.FillWeight = 127.7394F;
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.Name = "SoLuong";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoNhapThem);
            this.groupBox1.Controls.Add(this.rdoNhapMoi);
            this.groupBox1.Location = new System.Drawing.Point(748, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(410, 78);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn loại nhập sách";
            // 
            // rdoNhapThem
            // 
            this.rdoNhapThem.AutoSize = true;
            this.rdoNhapThem.Location = new System.Drawing.Point(234, 35);
            this.rdoNhapThem.Name = "rdoNhapThem";
            this.rdoNhapThem.Size = new System.Drawing.Size(148, 21);
            this.rdoNhapThem.TabIndex = 1;
            this.rdoNhapThem.TabStop = true;
            this.rdoNhapThem.Text = "Nhập thêm sách cũ";
            this.rdoNhapThem.UseVisualStyleBackColor = true;
            this.rdoNhapThem.CheckedChanged += new System.EventHandler(this.rdoNhapThem_CheckedChanged);
            // 
            // rdoNhapMoi
            // 
            this.rdoNhapMoi.AutoSize = true;
            this.rdoNhapMoi.Location = new System.Drawing.Point(17, 35);
            this.rdoNhapMoi.Name = "rdoNhapMoi";
            this.rdoNhapMoi.Size = new System.Drawing.Size(120, 21);
            this.rdoNhapMoi.TabIndex = 0;
            this.rdoNhapMoi.TabStop = true;
            this.rdoNhapMoi.Text = "Nhập sách mới";
            this.rdoNhapMoi.UseVisualStyleBackColor = true;
            this.rdoNhapMoi.CheckedChanged += new System.EventHandler(this.rdoNhapMoi_CheckedChanged);
            // 
            // txtTimTenSach
            // 
            this.txtTimTenSach.Location = new System.Drawing.Point(12, 86);
            this.txtTimTenSach.Name = "txtTimTenSach";
            this.txtTimTenSach.Size = new System.Drawing.Size(442, 23);
            this.txtTimTenSach.TabIndex = 13;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackgroundImage = global::Quản_lý_thư_viện_Tri_Thức.Properties.Resources.tìm_kiếm;
            this.btnTimKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTimKiem.Location = new System.Drawing.Point(503, 72);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(124, 51);
            this.btnTimKiem.TabIndex = 14;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // frmNhapSach
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1170, 600);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTimTenSach);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtgv_Sach);
            this.Controls.Add(this.grpNhapSach);
            this.Controls.Add(this.lblTieuDe);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmNhapSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập sách";
            this.Load += new System.EventHandler(this.frmNhapSach_Load);
            this.grpNhapSach.ResumeLayout(false);
            this.grpNhapSach.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Sach)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.TextBox txtTacGia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNamXB;
        private System.Windows.Forms.ComboBox cbbDauSach;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNXB;
        private System.Windows.Forms.TextBox txtSach;
        private System.Windows.Forms.TextBox txtMaSach;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMaSach;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.GroupBox grpNhapSach;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.DataGridView dtgv_Sach;
        private System.Windows.Forms.CheckBox chkSachHiem;
        private System.Windows.Forms.TextBox txtGiaTien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoNhapThem;
        private System.Windows.Forms.RadioButton rdoNhapMoi;
        private System.Windows.Forms.TextBox txtTimTenSach;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTacGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.TextBox txtMaNhap;
        private System.Windows.Forms.Label label7;
    }
}