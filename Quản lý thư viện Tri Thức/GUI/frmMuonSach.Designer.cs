namespace Quản_lý_thư_viện_Tri_Thức
{
    partial class frmMuonSach
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
            this.lsvSach = new System.Windows.Forms.ListView();
            this.MaSach1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTraLai = new System.Windows.Forms.Button();
            this.btnChoMuon = new System.Windows.Forms.Button();
            this.lstSachMuon = new System.Windows.Forms.ListView();
            this.MaSach = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTenSach = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnLapHoaDon = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nudSoLuong = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // lsvSach
            // 
            this.lsvSach.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MaSach1,
            this.colTen});
            this.lsvSach.FullRowSelect = true;
            this.lsvSach.HideSelection = false;
            this.lsvSach.Location = new System.Drawing.Point(75, 228);
            this.lsvSach.MultiSelect = false;
            this.lsvSach.Name = "lsvSach";
            this.lsvSach.Size = new System.Drawing.Size(400, 200);
            this.lsvSach.TabIndex = 26;
            this.lsvSach.UseCompatibleStateImageBehavior = false;
            this.lsvSach.View = System.Windows.Forms.View.Details;
            // 
            // MaSach1
            // 
            this.MaSach1.Text = "Mã sách";
            this.MaSach1.Width = 0;
            // 
            // colTen
            // 
            this.colTen.Text = "Tên sách";
            this.colTen.Width = 400;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(72, 157);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(279, 23);
            this.txtTimKiem.TabIndex = 24;
            // 
            // btnTraLai
            // 
            this.btnTraLai.Location = new System.Drawing.Point(520, 311);
            this.btnTraLai.Name = "btnTraLai";
            this.btnTraLai.Size = new System.Drawing.Size(73, 41);
            this.btnTraLai.TabIndex = 23;
            this.btnTraLai.Text = "<";
            this.btnTraLai.UseVisualStyleBackColor = true;
            this.btnTraLai.Click += new System.EventHandler(this.btnTraLai_Click);
            // 
            // btnChoMuon
            // 
            this.btnChoMuon.Location = new System.Drawing.Point(580, 239);
            this.btnChoMuon.Name = "btnChoMuon";
            this.btnChoMuon.Size = new System.Drawing.Size(73, 43);
            this.btnChoMuon.TabIndex = 22;
            this.btnChoMuon.Text = ">";
            this.btnChoMuon.UseVisualStyleBackColor = true;
            this.btnChoMuon.Click += new System.EventHandler(this.btnChoMuon_Click);
            // 
            // lstSachMuon
            // 
            this.lstSachMuon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MaSach,
            this.colTenSach,
            this.colSL});
            this.lstSachMuon.FullRowSelect = true;
            this.lstSachMuon.HideSelection = false;
            this.lstSachMuon.Location = new System.Drawing.Point(682, 228);
            this.lstSachMuon.Name = "lstSachMuon";
            this.lstSachMuon.Size = new System.Drawing.Size(417, 200);
            this.lstSachMuon.TabIndex = 21;
            this.lstSachMuon.UseCompatibleStateImageBehavior = false;
            this.lstSachMuon.View = System.Windows.Forms.View.Details;
            this.lstSachMuon.SelectedIndexChanged += new System.EventHandler(this.lstSachMuon_SelectedIndexChanged);
            // 
            // MaSach
            // 
            this.MaSach.Text = "Mã sách";
            this.MaSach.Width = 0;
            // 
            // colTenSach
            // 
            this.colTenSach.Text = "Tên Sách";
            this.colTenSach.Width = 350;
            // 
            // colSL
            // 
            this.colSL.Text = "Số lượng";
            this.colSL.Width = 80;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(400, 152);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 33);
            this.btnTimKiem.TabIndex = 27;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnLapHoaDon
            // 
            this.btnLapHoaDon.Location = new System.Drawing.Point(834, 482);
            this.btnLapHoaDon.Name = "btnLapHoaDon";
            this.btnLapHoaDon.Size = new System.Drawing.Size(98, 45);
            this.btnLapHoaDon.TabIndex = 30;
            this.btnLapHoaDon.Text = "Lập hóa đơn";
            this.btnLapHoaDon.UseVisualStyleBackColor = true;
            this.btnLapHoaDon.Click += new System.EventHandler(this.btnLapHoaDon_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(975, 482);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(98, 45);
            this.btnHuy.TabIndex = 31;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 17);
            this.label4.TabIndex = 36;
            this.label4.Text = "Sách Có Thể Cho Mượn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(797, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 17);
            this.label5.TabIndex = 37;
            this.label5.Text = "Sách sẽ mượn";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(494, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 38;
            this.label6.Text = "Số lượng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(70)))), ((int)(((byte)(54)))));
            this.label1.Location = new System.Drawing.Point(439, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 63);
            this.label1.TabIndex = 39;
            this.label1.Text = "Mượn sách";
            // 
            // nudSoLuong
            // 
            this.nudSoLuong.Location = new System.Drawing.Point(502, 259);
            this.nudSoLuong.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSoLuong.Name = "nudSoLuong";
            this.nudSoLuong.Size = new System.Drawing.Size(47, 23);
            this.nudSoLuong.TabIndex = 40;
            this.nudSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // frmMuonSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(220)))), ((int)(((byte)(201)))));
            this.ClientSize = new System.Drawing.Size(1170, 600);
            this.Controls.Add(this.nudSoLuong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLapHoaDon);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.lstSachMuon);
            this.Controls.Add(this.lsvSach);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btnTraLai);
            this.Controls.Add(this.btnChoMuon);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMuonSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Borrow Books";
            this.Load += new System.EventHandler(this.frmBorrowBooks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lsvSach;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTraLai;
        private System.Windows.Forms.Button btnChoMuon;
        private System.Windows.Forms.ListView lstSachMuon;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnLapHoaDon;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ColumnHeader colTen;
        private System.Windows.Forms.ColumnHeader colTenSach;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudSoLuong;
        private System.Windows.Forms.ColumnHeader colSL;
        private System.Windows.Forms.ColumnHeader MaSach1;
        private System.Windows.Forms.ColumnHeader MaSach;
    }
}