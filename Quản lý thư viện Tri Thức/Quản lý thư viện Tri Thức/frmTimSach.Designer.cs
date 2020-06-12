namespace Quản_lý_thư_viện_Tri_Thức
{
    partial class frmTimSach
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.txtNamXuatBan = new System.Windows.Forms.TextBox();
            this.lblNamXuatBan = new System.Windows.Forms.Label();
            this.lblNhaXuatBan = new System.Windows.Forms.Label();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.lblTenSach = new System.Windows.Forms.Label();
            this.txtNhaXuatBan = new System.Windows.Forms.TextBox();
            this.lblTheLoai = new System.Windows.Forms.Label();
            this.txtTacGia = new System.Windows.Forms.TextBox();
            this.lblTacGia = new System.Windows.Forms.Label();
            this.grpSach = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbTheLoai = new System.Windows.Forms.ComboBox();
            this.chkDuocMuon = new System.Windows.Forms.CheckBox();
            this.txtGiaTien = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataSach = new System.Windows.Forms.DataGridView();
            this.MaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TacGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaTheLoai = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.SachHiem = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.SoTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTraCuu = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.grpSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSach)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 44;
            this.label1.Text = "Tìm kiếm";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtTimKiem.Location = new System.Drawing.Point(232, 110);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(400, 23);
            this.txtTimKiem.TabIndex = 43;
            this.txtTimKiem.Tag = "";
            // 
            // txtNamXuatBan
            // 
            this.txtNamXuatBan.Location = new System.Drawing.Point(114, 216);
            this.txtNamXuatBan.Margin = new System.Windows.Forms.Padding(4);
            this.txtNamXuatBan.Name = "txtNamXuatBan";
            this.txtNamXuatBan.ReadOnly = true;
            this.txtNamXuatBan.Size = new System.Drawing.Size(200, 23);
            this.txtNamXuatBan.TabIndex = 28;
            // 
            // lblNamXuatBan
            // 
            this.lblNamXuatBan.AutoSize = true;
            this.lblNamXuatBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamXuatBan.Location = new System.Drawing.Point(14, 219);
            this.lblNamXuatBan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNamXuatBan.Name = "lblNamXuatBan";
            this.lblNamXuatBan.Size = new System.Drawing.Size(95, 17);
            this.lblNamXuatBan.TabIndex = 32;
            this.lblNamXuatBan.Text = "Năm xuất bản";
            // 
            // lblNhaXuatBan
            // 
            this.lblNhaXuatBan.AutoSize = true;
            this.lblNhaXuatBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhaXuatBan.Location = new System.Drawing.Point(14, 174);
            this.lblNhaXuatBan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNhaXuatBan.Name = "lblNhaXuatBan";
            this.lblNhaXuatBan.Size = new System.Drawing.Size(92, 17);
            this.lblNhaXuatBan.TabIndex = 25;
            this.lblNhaXuatBan.Text = "Nhà xuất bản";
            // 
            // txtTenSach
            // 
            this.txtTenSach.Location = new System.Drawing.Point(114, 26);
            this.txtTenSach.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.ReadOnly = true;
            this.txtTenSach.Size = new System.Drawing.Size(200, 23);
            this.txtTenSach.TabIndex = 27;
            // 
            // lblTenSach
            // 
            this.lblTenSach.AutoSize = true;
            this.lblTenSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenSach.Location = new System.Drawing.Point(14, 26);
            this.lblTenSach.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenSach.Name = "lblTenSach";
            this.lblTenSach.Size = new System.Drawing.Size(67, 17);
            this.lblTenSach.TabIndex = 22;
            this.lblTenSach.Text = "Tên sách";
            // 
            // txtNhaXuatBan
            // 
            this.txtNhaXuatBan.Location = new System.Drawing.Point(114, 171);
            this.txtNhaXuatBan.Margin = new System.Windows.Forms.Padding(4);
            this.txtNhaXuatBan.Name = "txtNhaXuatBan";
            this.txtNhaXuatBan.ReadOnly = true;
            this.txtNhaXuatBan.Size = new System.Drawing.Size(200, 23);
            this.txtNhaXuatBan.TabIndex = 29;
            // 
            // lblTheLoai
            // 
            this.lblTheLoai.AutoSize = true;
            this.lblTheLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTheLoai.Location = new System.Drawing.Point(14, 76);
            this.lblTheLoai.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTheLoai.Name = "lblTheLoai";
            this.lblTheLoai.Size = new System.Drawing.Size(59, 17);
            this.lblTheLoai.TabIndex = 24;
            this.lblTheLoai.Text = "Thể loại";
            // 
            // txtTacGia
            // 
            this.txtTacGia.Location = new System.Drawing.Point(114, 122);
            this.txtTacGia.Margin = new System.Windows.Forms.Padding(4);
            this.txtTacGia.Name = "txtTacGia";
            this.txtTacGia.ReadOnly = true;
            this.txtTacGia.Size = new System.Drawing.Size(200, 23);
            this.txtTacGia.TabIndex = 30;
            // 
            // lblTacGia
            // 
            this.lblTacGia.AutoSize = true;
            this.lblTacGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTacGia.Location = new System.Drawing.Point(14, 125);
            this.lblTacGia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTacGia.Name = "lblTacGia";
            this.lblTacGia.Size = new System.Drawing.Size(55, 17);
            this.lblTacGia.TabIndex = 23;
            this.lblTacGia.Text = "Tác giả";
            // 
            // grpSach
            // 
            this.grpSach.Controls.Add(this.label4);
            this.grpSach.Controls.Add(this.cbbTheLoai);
            this.grpSach.Controls.Add(this.chkDuocMuon);
            this.grpSach.Controls.Add(this.txtGiaTien);
            this.grpSach.Controls.Add(this.label2);
            this.grpSach.Controls.Add(this.txtNamXuatBan);
            this.grpSach.Controls.Add(this.lblNamXuatBan);
            this.grpSach.Controls.Add(this.lblNhaXuatBan);
            this.grpSach.Controls.Add(this.txtTenSach);
            this.grpSach.Controls.Add(this.lblTenSach);
            this.grpSach.Controls.Add(this.txtNhaXuatBan);
            this.grpSach.Controls.Add(this.lblTheLoai);
            this.grpSach.Controls.Add(this.txtTacGia);
            this.grpSach.Controls.Add(this.lblTacGia);
            this.grpSach.Location = new System.Drawing.Point(756, 191);
            this.grpSach.Name = "grpSach";
            this.grpSach.Size = new System.Drawing.Size(372, 355);
            this.grpSach.TabIndex = 45;
            this.grpSach.TabStop = false;
            this.grpSach.Text = "Chi tiết sách";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 17);
            this.label4.TabIndex = 38;
            this.label4.Text = "Có thể mượn";
            // 
            // cbbTheLoai
            // 
            this.cbbTheLoai.Enabled = false;
            this.cbbTheLoai.FormattingEnabled = true;
            this.cbbTheLoai.Location = new System.Drawing.Point(114, 76);
            this.cbbTheLoai.Name = "cbbTheLoai";
            this.cbbTheLoai.Size = new System.Drawing.Size(200, 24);
            this.cbbTheLoai.TabIndex = 37;
            // 
            // chkDuocMuon
            // 
            this.chkDuocMuon.AutoSize = true;
            this.chkDuocMuon.Enabled = false;
            this.chkDuocMuon.Location = new System.Drawing.Point(114, 305);
            this.chkDuocMuon.Name = "chkDuocMuon";
            this.chkDuocMuon.Size = new System.Drawing.Size(15, 14);
            this.chkDuocMuon.TabIndex = 36;
            this.chkDuocMuon.UseVisualStyleBackColor = true;
            // 
            // txtGiaTien
            // 
            this.txtGiaTien.Location = new System.Drawing.Point(114, 264);
            this.txtGiaTien.Margin = new System.Windows.Forms.Padding(4);
            this.txtGiaTien.Name = "txtGiaTien";
            this.txtGiaTien.ReadOnly = true;
            this.txtGiaTien.Size = new System.Drawing.Size(200, 23);
            this.txtGiaTien.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 267);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 34;
            this.label2.Text = "Giá tiền";
            // 
            // dataSach
            // 
            this.dataSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataSach.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataSach.ColumnHeadersHeight = 25;
            this.dataSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSach,
            this.TenSach,
            this.TacGia,
            this.MaTheLoai,
            this.SachHiem,
            this.SoTien});
            this.dataSach.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataSach.Location = new System.Drawing.Point(-1, 191);
            this.dataSach.Margin = new System.Windows.Forms.Padding(4);
            this.dataSach.Name = "dataSach";
            this.dataSach.ReadOnly = true;
            this.dataSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataSach.Size = new System.Drawing.Size(750, 357);
            this.dataSach.TabIndex = 41;
            this.dataSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataSach_CellClick);
            // 
            // MaSach
            // 
            this.MaSach.DataPropertyName = "MaSach";
            this.MaSach.HeaderText = "Mã sách";
            this.MaSach.Name = "MaSach";
            this.MaSach.ReadOnly = true;
            this.MaSach.Visible = false;
            // 
            // TenSach
            // 
            this.TenSach.DataPropertyName = "TenSach";
            this.TenSach.FillWeight = 200F;
            this.TenSach.HeaderText = "Tên sách";
            this.TenSach.Name = "TenSach";
            this.TenSach.ReadOnly = true;
            // 
            // TacGia
            // 
            this.TacGia.DataPropertyName = "TenTacGia";
            this.TacGia.HeaderText = "Tác giả";
            this.TacGia.Name = "TacGia";
            this.TacGia.ReadOnly = true;
            // 
            // MaTheLoai
            // 
            this.MaTheLoai.DataPropertyName = "MaTheLoai";
            this.MaTheLoai.FillWeight = 150F;
            this.MaTheLoai.HeaderText = "Thể loại";
            this.MaTheLoai.Name = "MaTheLoai";
            this.MaTheLoai.ReadOnly = true;
            this.MaTheLoai.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MaTheLoai.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // SachHiem
            // 
            this.SachHiem.DataPropertyName = "SachHiem";
            this.SachHiem.HeaderText = "Có thể mượn";
            this.SachHiem.Name = "SachHiem";
            this.SachHiem.ReadOnly = true;
            this.SachHiem.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SachHiem.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // SoTien
            // 
            this.SoTien.DataPropertyName = "DonGia";
            this.SoTien.HeaderText = "Số tiền";
            this.SoTien.Name = "SoTien";
            this.SoTien.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(309, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(290, 46);
            this.label3.TabIndex = 46;
            this.label3.Text = "Tìm kiếm sách";
            // 
            // btnTraCuu
            // 
            this.btnTraCuu.BackgroundImage = global::Quản_lý_thư_viện_Tri_Thức.Properties.Resources.tìm_kiếm;
            this.btnTraCuu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTraCuu.Location = new System.Drawing.Point(673, 91);
            this.btnTraCuu.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnTraCuu.Name = "btnTraCuu";
            this.btnTraCuu.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnTraCuu.Size = new System.Drawing.Size(76, 61);
            this.btnTraCuu.TabIndex = 42;
            this.btnTraCuu.UseVisualStyleBackColor = true;
            this.btnTraCuu.Click += new System.EventHandler(this.btnTraCuu_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Quản_lý_thư_viện_Tri_Thức.Properties.Resources.exit;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(1058, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 70);
            this.button1.TabIndex = 47;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmSearchBooks
            // 
            this.AcceptButton = this.btnTraCuu;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1170, 600);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.grpSach);
            this.Controls.Add(this.btnTraCuu);
            this.Controls.Add(this.dataSach);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmSearchBooks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Books";
            this.Load += new System.EventHandler(this.frmSearchBooks_Load);
            this.grpSach.ResumeLayout(false);
            this.grpSach.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.TextBox txtNamXuatBan;
        private System.Windows.Forms.Label lblNamXuatBan;
        private System.Windows.Forms.Label lblNhaXuatBan;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.Label lblTenSach;
        private System.Windows.Forms.TextBox txtNhaXuatBan;
        private System.Windows.Forms.Label lblTheLoai;
        private System.Windows.Forms.TextBox txtTacGia;
        private System.Windows.Forms.Label lblTacGia;
        private System.Windows.Forms.GroupBox grpSach;
        private System.Windows.Forms.Button btnTraCuu;
        public System.Windows.Forms.DataGridView dataSach;
        private System.Windows.Forms.CheckBox chkDuocMuon;
        private System.Windows.Forms.TextBox txtGiaTien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbTheLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TacGia;
        private System.Windows.Forms.DataGridViewComboBoxColumn MaTheLoai;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SachHiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoTien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}