namespace Quản_lý_thư_viện_Tri_Thức
{
    partial class frmChonXemThongKe
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbbDauSach = new System.Windows.Forms.ComboBox();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.rdoHoaDonMuon = new System.Windows.Forms.RadioButton();
            this.rdoNhomDauSach = new System.Windows.Forms.RadioButton();
            this.rdoTheoLoai = new System.Windows.Forms.RadioButton();
            this.rdoTatCaSanPham = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbbDauSach);
            this.groupBox1.Controls.Add(this.btnXacNhan);
            this.groupBox1.Controls.Add(this.rdoHoaDonMuon);
            this.groupBox1.Controls.Add(this.rdoNhomDauSach);
            this.groupBox1.Controls.Add(this.rdoTheoLoai);
            this.groupBox1.Controls.Add(this.rdoTatCaSanPham);
            this.groupBox1.Location = new System.Drawing.Point(13, 25);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(426, 313);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Loại thống kê";
            // 
            // cbbDauSach
            // 
            this.cbbDauSach.FormattingEnabled = true;
            this.cbbDauSach.Location = new System.Drawing.Point(211, 97);
            this.cbbDauSach.Name = "cbbDauSach";
            this.cbbDauSach.Size = new System.Drawing.Size(177, 24);
            this.cbbDauSach.TabIndex = 5;
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Location = new System.Drawing.Point(142, 238);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(144, 44);
            this.btnXacNhan.TabIndex = 4;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // rdoHoaDonMuon
            // 
            this.rdoHoaDonMuon.AutoSize = true;
            this.rdoHoaDonMuon.Location = new System.Drawing.Point(17, 187);
            this.rdoHoaDonMuon.Name = "rdoHoaDonMuon";
            this.rdoHoaDonMuon.Size = new System.Drawing.Size(154, 21);
            this.rdoHoaDonMuon.TabIndex = 3;
            this.rdoHoaDonMuon.TabStop = true;
            this.rdoHoaDonMuon.Text = "Theo hóa đơn mượn";
            this.rdoHoaDonMuon.UseVisualStyleBackColor = true;
            // 
            // rdoNhomDauSach
            // 
            this.rdoNhomDauSach.AutoSize = true;
            this.rdoNhomDauSach.Location = new System.Drawing.Point(17, 144);
            this.rdoNhomDauSach.Name = "rdoNhomDauSach";
            this.rdoNhomDauSach.Size = new System.Drawing.Size(160, 21);
            this.rdoNhomDauSach.TabIndex = 2;
            this.rdoNhomDauSach.TabStop = true;
            this.rdoNhomDauSach.Text = "Theo nhóm đầu sách";
            this.rdoNhomDauSach.UseVisualStyleBackColor = true;
            // 
            // rdoTheoLoai
            // 
            this.rdoTheoLoai.AutoSize = true;
            this.rdoTheoLoai.Location = new System.Drawing.Point(17, 98);
            this.rdoTheoLoai.Name = "rdoTheoLoai";
            this.rdoTheoLoai.Size = new System.Drawing.Size(121, 21);
            this.rdoTheoLoai.TabIndex = 1;
            this.rdoTheoLoai.TabStop = true;
            this.rdoTheoLoai.Text = "Theo đầu sách";
            this.rdoTheoLoai.UseVisualStyleBackColor = true;
            // 
            // rdoTatCaSanPham
            // 
            this.rdoTatCaSanPham.AutoSize = true;
            this.rdoTatCaSanPham.Location = new System.Drawing.Point(17, 50);
            this.rdoTatCaSanPham.Name = "rdoTatCaSanPham";
            this.rdoTatCaSanPham.Size = new System.Drawing.Size(100, 21);
            this.rdoTatCaSanPham.TabIndex = 0;
            this.rdoTatCaSanPham.TabStop = true;
            this.rdoTatCaSanPham.Text = "Tất cả sách";
            this.rdoTatCaSanPham.UseVisualStyleBackColor = true;
            // 
            // frmChonXemThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 349);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmChonXemThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chọn xem thống kê";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.RadioButton rdoHoaDonMuon;
        private System.Windows.Forms.RadioButton rdoNhomDauSach;
        private System.Windows.Forms.RadioButton rdoTheoLoai;
        private System.Windows.Forms.RadioButton rdoTatCaSanPham;
        private System.Windows.Forms.ComboBox cbbDauSach;
    }
}