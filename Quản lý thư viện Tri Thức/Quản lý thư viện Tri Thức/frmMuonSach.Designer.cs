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
            this.colTen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTraLai = new System.Windows.Forms.Button();
            this.btnChoMuon = new System.Windows.Forms.Button();
            this.lsvSachMuon = new System.Windows.Forms.ListView();
            this.colTenSach = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtMaMuon = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtMaDG = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lsvSach
            // 
            this.lsvSach.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
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
            // colTen
            // 
            this.colTen.Text = "Tên sách";
            this.colTen.Width = 350;
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
            this.btnTraLai.Location = new System.Drawing.Point(548, 322);
            this.btnTraLai.Name = "btnTraLai";
            this.btnTraLai.Size = new System.Drawing.Size(73, 41);
            this.btnTraLai.TabIndex = 23;
            this.btnTraLai.Text = "<";
            this.btnTraLai.UseVisualStyleBackColor = true;
            this.btnTraLai.Click += new System.EventHandler(this.btnTraLai_Click);
            // 
            // btnChoMuon
            // 
            this.btnChoMuon.Location = new System.Drawing.Point(548, 239);
            this.btnChoMuon.Name = "btnChoMuon";
            this.btnChoMuon.Size = new System.Drawing.Size(73, 41);
            this.btnChoMuon.TabIndex = 22;
            this.btnChoMuon.Text = ">";
            this.btnChoMuon.UseVisualStyleBackColor = true;
            this.btnChoMuon.Click += new System.EventHandler(this.btnChoMuon_Click);
            // 
            // lsvSachMuon
            // 
            this.lsvSachMuon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colTenSach});
            this.lsvSachMuon.HideSelection = false;
            this.lsvSachMuon.Location = new System.Drawing.Point(673, 228);
            this.lsvSachMuon.Name = "lsvSachMuon";
            this.lsvSachMuon.Size = new System.Drawing.Size(400, 200);
            this.lsvSachMuon.TabIndex = 21;
            this.lsvSachMuon.UseCompatibleStateImageBehavior = false;
            this.lsvSachMuon.View = System.Windows.Forms.View.Details;
            // 
            // colTenSach
            // 
            this.colTenSach.Text = "Tên Sách";
            this.colTenSach.Width = 350;
            // 
            // txtMaMuon
            // 
            this.txtMaMuon.Location = new System.Drawing.Point(144, 41);
            this.txtMaMuon.Name = "txtMaMuon";
            this.txtMaMuon.Size = new System.Drawing.Size(185, 23);
            this.txtMaMuon.TabIndex = 17;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(397, 157);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 27;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // txtMaDG
            // 
            this.txtMaDG.Location = new System.Drawing.Point(849, 41);
            this.txtMaDG.Name = "txtMaDG";
            this.txtMaDG.Size = new System.Drawing.Size(185, 23);
            this.txtMaDG.TabIndex = 28;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(490, 41);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(185, 23);
            this.txtMaNV.TabIndex = 29;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(834, 482);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(98, 45);
            this.button4.TabIndex = 30;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(975, 482);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(98, 45);
            this.button5.TabIndex = 31;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(535, 405);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.ReadOnly = true;
            this.txtSoLuong.Size = new System.Drawing.Size(100, 23);
            this.txtSoLuong.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 33;
            this.label1.Text = "Mã Mượn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(364, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 34;
            this.label2.Text = "Mã Nhân Viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(716, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 17);
            this.label3.TabIndex = 35;
            this.label3.Text = "Mã Thẻ Độc Giả";
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
            this.label6.Location = new System.Drawing.Point(545, 385);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 38;
            this.label6.Text = "Số lượng";
            // 
            // frmBorrowBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 600);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.txtMaDG);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.lsvSachMuon);
            this.Controls.Add(this.lsvSach);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btnTraLai);
            this.Controls.Add(this.btnChoMuon);
            this.Controls.Add(this.txtMaMuon);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmBorrowBooks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Borrow Books";
            this.Load += new System.EventHandler(this.frmBorrowBooks_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lsvSach;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTraLai;
        private System.Windows.Forms.Button btnChoMuon;
        private System.Windows.Forms.ListView lsvSachMuon;
        private System.Windows.Forms.TextBox txtMaMuon;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtMaDG;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ColumnHeader colTen;
        private System.Windows.Forms.ColumnHeader colTenSach;
        private System.Windows.Forms.Label label6;
    }
}