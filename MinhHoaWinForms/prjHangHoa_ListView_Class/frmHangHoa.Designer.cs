namespace prjHangHoa_ListView_File
{
    partial class frmHangHoa
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaHang = new System.Windows.Forms.TextBox();
            this.txtTenHang = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboLoaiHang = new System.Windows.Forms.ComboBox();
            this.cboNSX = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.chkVAT = new System.Windows.Forms.CheckBox();
            this.txtSoLuongTon = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lvHangHoa = new System.Windows.Forms.ListView();
            this.SoTT = new System.Windows.Forms.ColumnHeader();
            this.MaHang = new System.Windows.Forms.ColumnHeader();
            this.TenHang = new System.Windows.Forms.ColumnHeader();
            this.Loai = new System.Windows.Forms.ColumnHeader();
            this.NSX = new System.Windows.Forms.ColumnHeader();
            this.DonGia = new System.Windows.Forms.ColumnHeader();
            this.VAT = new System.Windows.Forms.ColumnHeader();
            this.SoLuongTon = new System.Windows.Forms.ColumnHeader();
            this.TTien = new System.Windows.Forms.ColumnHeader();
            this.btnChapNhan = new System.Windows.Forms.Button();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.btnLoaiBo = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTongTriGia = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSaveFile = new System.Windows.Forms.Button();
            this.btnLoadFile = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(195, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(490, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÔNG TIN HÀNG HOÁ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã hàng:";
            // 
            // txtMaHang
            // 
            this.txtMaHang.Location = new System.Drawing.Point(156, 82);
            this.txtMaHang.Name = "txtMaHang";
            this.txtMaHang.Size = new System.Drawing.Size(100, 20);
            this.txtMaHang.TabIndex = 2;
            // 
            // txtTenHang
            // 
            this.txtTenHang.Location = new System.Drawing.Point(459, 81);
            this.txtTenHang.Name = "txtTenHang";
            this.txtTenHang.Size = new System.Drawing.Size(180, 20);
            this.txtTenHang.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(397, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên hàng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(93, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Loại hàng:";
            // 
            // cboLoaiHang
            // 
            this.cboLoaiHang.FormattingEnabled = true;
            this.cboLoaiHang.Items.AddRange(new object[] {
            "Hàng gia dụng",
            "Thiết bị tin học",
            "Văn phòng phẩm"});
            this.cboLoaiHang.Location = new System.Drawing.Point(156, 118);
            this.cboLoaiHang.Name = "cboLoaiHang";
            this.cboLoaiHang.Size = new System.Drawing.Size(161, 21);
            this.cboLoaiHang.TabIndex = 6;
            this.cboLoaiHang.SelectedIndexChanged += new System.EventHandler(this.cboLoaiHang_SelectedIndexChanged);
            // 
            // cboNSX
            // 
            this.cboNSX.FormattingEnabled = true;
            this.cboNSX.Location = new System.Drawing.Point(459, 120);
            this.cboNSX.Name = "cboNSX";
            this.cboNSX.Size = new System.Drawing.Size(180, 21);
            this.cboNSX.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(403, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Nhà SX:";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(156, 156);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(100, 20);
            this.txtDonGia.TabIndex = 10;
            this.txtDonGia.Text = "0";
            this.txtDonGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDonGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDonGia_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(93, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Đơn giá:";
            // 
            // chkVAT
            // 
            this.chkVAT.AutoSize = true;
            this.chkVAT.Checked = true;
            this.chkVAT.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkVAT.Location = new System.Drawing.Point(324, 163);
            this.chkVAT.Name = "chkVAT";
            this.chkVAT.Size = new System.Drawing.Size(75, 17);
            this.chkVAT.TabIndex = 12;
            this.chkVAT.Text = "Thuế VAT";
            this.chkVAT.UseVisualStyleBackColor = true;
            // 
            // txtSoLuongTon
            // 
            this.txtSoLuongTon.Location = new System.Drawing.Point(556, 156);
            this.txtSoLuongTon.Name = "txtSoLuongTon";
            this.txtSoLuongTon.Size = new System.Drawing.Size(83, 20);
            this.txtSoLuongTon.TabIndex = 14;
            this.txtSoLuongTon.Text = "0";
            this.txtSoLuongTon.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSoLuongTon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoLuongTon_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(475, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Số lượng tồn";
            // 
            // lvHangHoa
            // 
            this.lvHangHoa.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.SoTT,
            this.MaHang,
            this.TenHang,
            this.Loai,
            this.NSX,
            this.DonGia,
            this.VAT,
            this.SoLuongTon,
            this.TTien});
            this.lvHangHoa.FullRowSelect = true;
            this.lvHangHoa.GridLines = true;
            this.lvHangHoa.Location = new System.Drawing.Point(12, 220);
            this.lvHangHoa.MultiSelect = false;
            this.lvHangHoa.Name = "lvHangHoa";
            this.lvHangHoa.Size = new System.Drawing.Size(856, 139);
            this.lvHangHoa.TabIndex = 15;
            this.lvHangHoa.UseCompatibleStateImageBehavior = false;
            this.lvHangHoa.View = System.Windows.Forms.View.Details;
            this.lvHangHoa.SelectedIndexChanged += new System.EventHandler(this.lvHangHoa_SelectedIndexChanged);
            // 
            // SoTT
            // 
            this.SoTT.Text = "Số TT";
            this.SoTT.Width = 46;
            // 
            // MaHang
            // 
            this.MaHang.Text = "Mã hàng";
            this.MaHang.Width = 73;
            // 
            // TenHang
            // 
            this.TenHang.Text = "Tên hàng";
            this.TenHang.Width = 155;
            // 
            // Loai
            // 
            this.Loai.Text = "Loại";
            this.Loai.Width = 124;
            // 
            // NSX
            // 
            this.NSX.Text = "Nhà sản xuất";
            this.NSX.Width = 109;
            // 
            // DonGia
            // 
            this.DonGia.Text = "Đơn giá";
            this.DonGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.DonGia.Width = 80;
            // 
            // VAT
            // 
            this.VAT.Text = "Thuế VAT";
            this.VAT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.VAT.Width = 67;
            // 
            // SoLuongTon
            // 
            this.SoLuongTon.Text = "Số lượng tồn";
            this.SoLuongTon.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.SoLuongTon.Width = 78;
            // 
            // TTien
            // 
            this.TTien.Text = "Thành tiền";
            this.TTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TTien.Width = 114;
            // 
            // btnChapNhan
            // 
            this.btnChapNhan.Location = new System.Drawing.Point(12, 23);
            this.btnChapNhan.Name = "btnChapNhan";
            this.btnChapNhan.Size = new System.Drawing.Size(81, 22);
            this.btnChapNhan.TabIndex = 16;
            this.btnChapNhan.Text = "Chấp &nhận";
            this.btnChapNhan.UseVisualStyleBackColor = true;
            this.btnChapNhan.Click += new System.EventHandler(this.btnChapNhan_Click);
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Location = new System.Drawing.Point(109, 23);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(81, 22);
            this.btnThemMoi.TabIndex = 17;
            this.btnThemMoi.Text = "Thêm &mới";
            this.btnThemMoi.UseVisualStyleBackColor = true;
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // btnLoaiBo
            // 
            this.btnLoaiBo.Location = new System.Drawing.Point(206, 23);
            this.btnLoaiBo.Name = "btnLoaiBo";
            this.btnLoaiBo.Size = new System.Drawing.Size(81, 22);
            this.btnLoaiBo.TabIndex = 18;
            this.btnLoaiBo.Text = "Loại &bỏ";
            this.btnLoaiBo.UseVisualStyleBackColor = true;
            this.btnLoaiBo.Click += new System.EventHandler(this.btnLoaiBo_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(776, 407);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(81, 22);
            this.btnThoat.TabIndex = 19;
            this.btnThoat.Text = "&Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnSua
            // 
            this.btnSua.Enabled = false;
            this.btnSua.Location = new System.Drawing.Point(358, 407);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(81, 22);
            this.btnSua.TabIndex = 20;
            this.btnSua.Text = "Lưu &sửa đổi";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLoaiBo);
            this.groupBox1.Controls.Add(this.btnThemMoi);
            this.groupBox1.Controls.Add(this.btnChapNhan);
            this.groupBox1.Location = new System.Drawing.Point(37, 384);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 63);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(644, 370);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Tổng trị giá";
            // 
            // lblTongTriGia
            // 
            this.lblTongTriGia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTongTriGia.Location = new System.Drawing.Point(722, 365);
            this.lblTongTriGia.Name = "lblTongTriGia";
            this.lblTongTriGia.Size = new System.Drawing.Size(135, 23);
            this.lblTongTriGia.TabIndex = 23;
            this.lblTongTriGia.Text = "0";
            this.lblTongTriGia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSaveFile);
            this.groupBox2.Controls.Add(this.btnLoadFile);
            this.groupBox2.Location = new System.Drawing.Point(456, 386);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(198, 63);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            // 
            // btnSaveFile
            // 
            this.btnSaveFile.Location = new System.Drawing.Point(109, 23);
            this.btnSaveFile.Name = "btnSaveFile";
            this.btnSaveFile.Size = new System.Drawing.Size(81, 22);
            this.btnSaveFile.TabIndex = 17;
            this.btnSaveFile.Text = "&Lưu vào File";
            this.btnSaveFile.UseVisualStyleBackColor = true;
            this.btnSaveFile.Click += new System.EventHandler(this.btnSaveFile_Click);
            // 
            // btnLoadFile
            // 
            this.btnLoadFile.Location = new System.Drawing.Point(12, 23);
            this.btnLoadFile.Name = "btnLoadFile";
            this.btnLoadFile.Size = new System.Drawing.Size(81, 22);
            this.btnLoadFile.TabIndex = 16;
            this.btnLoadFile.Text = "Lấy từ &File";
            this.btnLoadFile.UseVisualStyleBackColor = true;
            this.btnLoadFile.Click += new System.EventHandler(this.btnLoadFile_Click);
            // 
            // frmHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(880, 461);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.lblTongTriGia);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.lvHangHoa);
            this.Controls.Add(this.txtSoLuongTon);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.chkVAT);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboNSX);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboLoaiHang);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTenHang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMaHang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmHangHoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmHangHoa";
            this.Load += new System.EventHandler(this.frmHangHoa_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmHangHoa_FormClosed);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmHangHoa_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaHang;
        private System.Windows.Forms.TextBox txtTenHang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboLoaiHang;
        private System.Windows.Forms.ComboBox cboNSX;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkVAT;
        private System.Windows.Forms.TextBox txtSoLuongTon;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ColumnHeader SoTT;
        private System.Windows.Forms.ColumnHeader MaHang;
        private System.Windows.Forms.ColumnHeader TenHang;
        private System.Windows.Forms.ColumnHeader Loai;
        private System.Windows.Forms.ColumnHeader NSX;
        private System.Windows.Forms.ColumnHeader DonGia;
        private System.Windows.Forms.ColumnHeader VAT;
        private System.Windows.Forms.ColumnHeader SoLuongTon;
        private System.Windows.Forms.ColumnHeader TTien;
        private System.Windows.Forms.Button btnChapNhan;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.Button btnLoaiBo;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTongTriGia;
        private System.Windows.Forms.ListView lvHangHoa;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSaveFile;
        private System.Windows.Forms.Button btnLoadFile;
    }
}