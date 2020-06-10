namespace Quản_lý_thư_viện_Tri_Thức
{
    partial class frmBooks
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
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.cbbTheLoai = new System.Windows.Forms.ComboBox();
            this.toTLamMoi = new System.Windows.Forms.ToolTip(this.components);
            this.btnReset = new System.Windows.Forms.Button();
            this.ToTSua = new System.Windows.Forms.ToolTip(this.components);
            this.btnSua = new System.Windows.Forms.Button();
            this.toTXoa = new System.Windows.Forms.ToolTip(this.components);
            this.btnXoa = new System.Windows.Forms.Button();
            this.toTTimKiem = new System.Windows.Forms.ToolTip(this.components);
            this.btnTraCuu = new System.Windows.Forms.Button();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.lblMaSach = new System.Windows.Forms.Label();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.lblNamXuatBan = new System.Windows.Forms.Label();
            this.txtTacGia = new System.Windows.Forms.TextBox();
            this.txtNhaXuatBan = new System.Windows.Forms.TextBox();
            this.txtNamXuatBan = new System.Windows.Forms.TextBox();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.lblNhaXuatBan = new System.Windows.Forms.Label();
            this.lblTheLoai = new System.Windows.Forms.Label();
            this.lblTacGia = new System.Windows.Forms.Label();
            this.lblTenSach = new System.Windows.Forms.Label();
            this.dataSach = new System.Windows.Forms.DataGridView();
            this.MaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaTheLoai = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.TenTacGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chkSachHiem = new System.Windows.Forms.CheckBox();
            this.grpThongTin = new System.Windows.Forms.GroupBox();
            this.txtGiaTien = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataSach)).BeginInit();
            this.grpThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(145, 210);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(195, 23);
            this.txtSoLuong.TabIndex = 6;
            // 
            // cbbTheLoai
            // 
            this.cbbTheLoai.FormattingEnabled = true;
            this.cbbTheLoai.Location = new System.Drawing.Point(145, 90);
            this.cbbTheLoai.Name = "cbbTheLoai";
            this.cbbTheLoai.Size = new System.Drawing.Size(195, 24);
            this.cbbTheLoai.TabIndex = 2;
            // 
            // btnReset
            // 
            this.btnReset.BackgroundImage = global::Quản_lý_thư_viện_Tri_Thức.Properties.Resources.For_NH;
            this.btnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReset.Location = new System.Drawing.Point(274, 303);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(66, 54);
            this.btnReset.TabIndex = 11;
            this.toTLamMoi.SetToolTip(this.btnReset, "Làm mới");
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackgroundImage = global::Quản_lý_thư_viện_Tri_Thức.Properties.Resources.Edit;
            this.btnSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSua.Location = new System.Drawing.Point(145, 303);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(66, 54);
            this.btnSua.TabIndex = 10;
            this.ToTSua.SetToolTip(this.btnSua, "Sửa");
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.AutoSize = true;
            this.btnXoa.BackColor = System.Drawing.SystemColors.Control;
            this.btnXoa.BackgroundImage = global::Quản_lý_thư_viện_Tri_Thức.Properties.Resources.for_NH_4;
            this.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnXoa.Location = new System.Drawing.Point(17, 303);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(66, 54);
            this.btnXoa.TabIndex = 9;
            this.toTXoa.SetToolTip(this.btnXoa, "Xóa sách");
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnTraCuu
            // 
            this.btnTraCuu.BackgroundImage = global::Quản_lý_thư_viện_Tri_Thức.Properties.Resources.tìm_kiếm;
            this.btnTraCuu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTraCuu.Location = new System.Drawing.Point(1073, 124);
            this.btnTraCuu.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnTraCuu.Name = "btnTraCuu";
            this.btnTraCuu.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnTraCuu.Size = new System.Drawing.Size(40, 40);
            this.btnTraCuu.TabIndex = 8;
            this.toTTimKiem.SetToolTip(this.btnTraCuu, "Tìm kiếm");
            this.btnTraCuu.UseVisualStyleBackColor = true;
            this.btnTraCuu.Click += new System.EventHandler(this.btnTraCuu_Click);
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Location = new System.Drawing.Point(14, 213);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(64, 17);
            this.lblSoLuong.TabIndex = 0;
            this.lblSoLuong.Text = "Số lượng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(771, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tìm kiếm";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtTimKiem.Location = new System.Drawing.Point(853, 133);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(209, 23);
            this.txtTimKiem.TabIndex = 7;
            this.txtTimKiem.Tag = "";
            // 
            // lblMaSach
            // 
            this.lblMaSach.AutoSize = true;
            this.lblMaSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaSach.Location = new System.Drawing.Point(14, 33);
            this.lblMaSach.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaSach.Name = "lblMaSach";
            this.lblMaSach.Size = new System.Drawing.Size(61, 17);
            this.lblMaSach.TabIndex = 0;
            this.lblMaSach.Text = "Mã sách";
            // 
            // txtMaSach
            // 
            this.txtMaSach.Location = new System.Drawing.Point(145, 30);
            this.txtMaSach.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.ReadOnly = true;
            this.txtMaSach.Size = new System.Drawing.Size(195, 23);
            this.txtMaSach.TabIndex = 0;
            // 
            // lblNamXuatBan
            // 
            this.lblNamXuatBan.AutoSize = true;
            this.lblNamXuatBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamXuatBan.Location = new System.Drawing.Point(14, 183);
            this.lblNamXuatBan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNamXuatBan.Name = "lblNamXuatBan";
            this.lblNamXuatBan.Size = new System.Drawing.Size(95, 17);
            this.lblNamXuatBan.TabIndex = 0;
            this.lblNamXuatBan.Text = "Năm xuất bản";
            // 
            // txtTacGia
            // 
            this.txtTacGia.Location = new System.Drawing.Point(145, 120);
            this.txtTacGia.Margin = new System.Windows.Forms.Padding(4);
            this.txtTacGia.Name = "txtTacGia";
            this.txtTacGia.Size = new System.Drawing.Size(195, 23);
            this.txtTacGia.TabIndex = 3;
            // 
            // txtNhaXuatBan
            // 
            this.txtNhaXuatBan.Location = new System.Drawing.Point(145, 150);
            this.txtNhaXuatBan.Margin = new System.Windows.Forms.Padding(4);
            this.txtNhaXuatBan.Name = "txtNhaXuatBan";
            this.txtNhaXuatBan.Size = new System.Drawing.Size(195, 23);
            this.txtNhaXuatBan.TabIndex = 4;
            // 
            // txtNamXuatBan
            // 
            this.txtNamXuatBan.Location = new System.Drawing.Point(145, 180);
            this.txtNamXuatBan.Margin = new System.Windows.Forms.Padding(4);
            this.txtNamXuatBan.Name = "txtNamXuatBan";
            this.txtNamXuatBan.Size = new System.Drawing.Size(195, 23);
            this.txtNamXuatBan.TabIndex = 5;
            // 
            // txtTenSach
            // 
            this.txtTenSach.Location = new System.Drawing.Point(145, 60);
            this.txtTenSach.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(195, 23);
            this.txtTenSach.TabIndex = 1;
            // 
            // lblNhaXuatBan
            // 
            this.lblNhaXuatBan.AutoSize = true;
            this.lblNhaXuatBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhaXuatBan.Location = new System.Drawing.Point(14, 153);
            this.lblNhaXuatBan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNhaXuatBan.Name = "lblNhaXuatBan";
            this.lblNhaXuatBan.Size = new System.Drawing.Size(92, 17);
            this.lblNhaXuatBan.TabIndex = 0;
            this.lblNhaXuatBan.Text = "Nhà xuất bản";
            // 
            // lblTheLoai
            // 
            this.lblTheLoai.AutoSize = true;
            this.lblTheLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTheLoai.Location = new System.Drawing.Point(14, 93);
            this.lblTheLoai.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTheLoai.Name = "lblTheLoai";
            this.lblTheLoai.Size = new System.Drawing.Size(59, 17);
            this.lblTheLoai.TabIndex = 0;
            this.lblTheLoai.Text = "Thể loại";
            // 
            // lblTacGia
            // 
            this.lblTacGia.AutoSize = true;
            this.lblTacGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTacGia.Location = new System.Drawing.Point(14, 123);
            this.lblTacGia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTacGia.Name = "lblTacGia";
            this.lblTacGia.Size = new System.Drawing.Size(55, 17);
            this.lblTacGia.TabIndex = 0;
            this.lblTacGia.Text = "Tác giả";
            // 
            // lblTenSach
            // 
            this.lblTenSach.AutoSize = true;
            this.lblTenSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenSach.Location = new System.Drawing.Point(14, 63);
            this.lblTenSach.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenSach.Name = "lblTenSach";
            this.lblTenSach.Size = new System.Drawing.Size(67, 17);
            this.lblTenSach.TabIndex = 0;
            this.lblTenSach.Text = "Tên sách";
            // 
            // dataSach
            // 
            this.dataSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataSach.BackgroundColor = System.Drawing.Color.Silver;
            this.dataSach.ColumnHeadersHeight = 25;
            this.dataSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSach,
            this.TenSach,
            this.MaTheLoai,
            this.TenTacGia,
            this.SoLuong});
            this.dataSach.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataSach.Location = new System.Drawing.Point(-1, 191);
            this.dataSach.Margin = new System.Windows.Forms.Padding(4);
            this.dataSach.Name = "dataSach";
            this.dataSach.ReadOnly = true;
            this.dataSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataSach.Size = new System.Drawing.Size(750, 357);
            this.dataSach.TabIndex = 0;
            this.dataSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataSach_CellClick);
            // 
            // MaSach
            // 
            this.MaSach.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.MaSach.DataPropertyName = "MaSach";
            this.MaSach.FillWeight = 75F;
            this.MaSach.HeaderText = "Mã Sách";
            this.MaSach.Name = "MaSach";
            this.MaSach.ReadOnly = true;
            this.MaSach.Width = 86;
            // 
            // TenSach
            // 
            this.TenSach.DataPropertyName = "TenSach";
            this.TenSach.FillWeight = 200F;
            this.TenSach.HeaderText = "Tên Sách";
            this.TenSach.Name = "TenSach";
            this.TenSach.ReadOnly = true;
            // 
            // MaTheLoai
            // 
            this.MaTheLoai.DataPropertyName = "MaTheLoai";
            this.MaTheLoai.FillWeight = 150F;
            this.MaTheLoai.HeaderText = "Thể Loại";
            this.MaTheLoai.Name = "MaTheLoai";
            this.MaTheLoai.ReadOnly = true;
            this.MaTheLoai.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MaTheLoai.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // TenTacGia
            // 
            this.TenTacGia.DataPropertyName = "TenTacGia";
            this.TenTacGia.FillWeight = 150F;
            this.TenTacGia.HeaderText = "Tác Giả";
            this.TenTacGia.Name = "TenTacGia";
            this.TenTacGia.ReadOnly = true;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.FillWeight = 75F;
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            // 
            // chkSachHiem
            // 
            this.chkSachHiem.AutoSize = true;
            this.chkSachHiem.Location = new System.Drawing.Point(145, 270);
            this.chkSachHiem.Name = "chkSachHiem";
            this.chkSachHiem.Size = new System.Drawing.Size(93, 21);
            this.chkSachHiem.TabIndex = 12;
            this.chkSachHiem.Text = "Sách hiếm";
            this.chkSachHiem.UseVisualStyleBackColor = true;
            // 
            // grpThongTin
            // 
            this.grpThongTin.Controls.Add(this.txtGiaTien);
            this.grpThongTin.Controls.Add(this.label2);
            this.grpThongTin.Controls.Add(this.btnReset);
            this.grpThongTin.Controls.Add(this.chkSachHiem);
            this.grpThongTin.Controls.Add(this.btnSua);
            this.grpThongTin.Controls.Add(this.txtSoLuong);
            this.grpThongTin.Controls.Add(this.btnXoa);
            this.grpThongTin.Controls.Add(this.lblSoLuong);
            this.grpThongTin.Controls.Add(this.cbbTheLoai);
            this.grpThongTin.Controls.Add(this.txtMaSach);
            this.grpThongTin.Controls.Add(this.txtTenSach);
            this.grpThongTin.Controls.Add(this.lblNamXuatBan);
            this.grpThongTin.Controls.Add(this.lblMaSach);
            this.grpThongTin.Controls.Add(this.txtNamXuatBan);
            this.grpThongTin.Controls.Add(this.txtNhaXuatBan);
            this.grpThongTin.Controls.Add(this.txtTacGia);
            this.grpThongTin.Controls.Add(this.lblNhaXuatBan);
            this.grpThongTin.Controls.Add(this.lblTheLoai);
            this.grpThongTin.Controls.Add(this.lblTenSach);
            this.grpThongTin.Controls.Add(this.lblTacGia);
            this.grpThongTin.Location = new System.Drawing.Point(773, 184);
            this.grpThongTin.Name = "grpThongTin";
            this.grpThongTin.Size = new System.Drawing.Size(356, 364);
            this.grpThongTin.TabIndex = 13;
            this.grpThongTin.TabStop = false;
            this.grpThongTin.Text = "Thông tin chi tiết";
            // 
            // txtGiaTien
            // 
            this.txtGiaTien.Location = new System.Drawing.Point(145, 240);
            this.txtGiaTien.Name = "txtGiaTien";
            this.txtGiaTien.Size = new System.Drawing.Size(195, 23);
            this.txtGiaTien.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Giá tiền";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(408, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(341, 63);
            this.label3.TabIndex = 14;
            this.label3.Text = "Quản lý sách";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Quản_lý_thư_viện_Tri_Thức.Properties.Resources.Edit1;
            this.pictureBox1.Location = new System.Drawing.Point(127, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 131);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = global::Quản_lý_thư_viện_Tri_Thức.Properties.Resources.exit;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExit.Location = new System.Drawing.Point(1043, 9);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(70, 70);
            this.btnExit.TabIndex = 48;
            this.btnExit.Text = "\r\n";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1170, 600);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.grpThongTin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btnTraCuu);
            this.Controls.Add(this.dataSach);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmBooks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý sách";
            this.Load += new System.EventHandler(this.frmBooks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSach)).EndInit();
            this.grpThongTin.ResumeLayout(false);
            this.grpThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.ComboBox cbbTheLoai;
        private System.Windows.Forms.ToolTip toTLamMoi;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ToolTip ToTSua;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.ToolTip toTXoa;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.ToolTip toTTimKiem;
        private System.Windows.Forms.Button btnTraCuu;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label lblMaSach;
        private System.Windows.Forms.TextBox txtMaSach;
        private System.Windows.Forms.Label lblNamXuatBan;
        private System.Windows.Forms.TextBox txtTacGia;
        private System.Windows.Forms.TextBox txtNhaXuatBan;
        private System.Windows.Forms.TextBox txtNamXuatBan;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.Label lblNhaXuatBan;
        private System.Windows.Forms.Label lblTheLoai;
        private System.Windows.Forms.Label lblTacGia;
        private System.Windows.Forms.Label lblTenSach;
        public System.Windows.Forms.DataGridView dataSach;
        private System.Windows.Forms.CheckBox chkSachHiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSach;
        private System.Windows.Forms.DataGridViewComboBoxColumn MaTheLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTacGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.GroupBox grpThongTin;
        private System.Windows.Forms.TextBox txtGiaTien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnExit;
    }
}