namespace HoSoNhanVien_Class
{
    partial class frmHoSoNV
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
            this.txtMaSo = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.bntThoat = new System.Windows.Forms.Button();
            this.btnLoaiBo = new System.Windows.Forms.Button();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.btnTiepNhan = new System.Windows.Forms.Button();
            this.lstDanhSach = new System.Windows.Forms.ListBox();
            this.grpPhai = new System.Windows.Forms.GroupBox();
            this.radNu = new System.Windows.Forms.RadioButton();
            this.radNam = new System.Windows.Forms.RadioButton();
            this.txtNamSinh = new System.Windows.Forms.TextBox();
            this.cboChucVu = new System.Windows.Forms.ComboBox();
            this.cboPhongBan = new System.Windows.Forms.ComboBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.btnDau = new System.Windows.Forms.Button();
            this.btnTruoc = new System.Windows.Forms.Button();
            this.btnSau = new System.Windows.Forms.Button();
            this.btnCuoi = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblSoNV = new System.Windows.Forms.Label();
            this.grpPhai.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMaSo
            // 
            this.txtMaSo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSo.Location = new System.Drawing.Point(172, 65);
            this.txtMaSo.Name = "txtMaSo";
            this.txtMaSo.Size = new System.Drawing.Size(112, 20);
            this.txtMaSo.TabIndex = 17;
            this.txtMaSo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMaSo_KeyDown);
            // 
            // Label6
            // 
            this.Label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(36, 65);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(120, 24);
            this.Label6.TabIndex = 32;
            this.Label6.Text = "Mã số:";
            this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bntThoat
            // 
            this.bntThoat.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntThoat.Location = new System.Drawing.Point(340, 483);
            this.bntThoat.Name = "bntThoat";
            this.bntThoat.Size = new System.Drawing.Size(120, 32);
            this.bntThoat.TabIndex = 30;
            this.bntThoat.Text = "Th&oát";
            this.bntThoat.Click += new System.EventHandler(this.bntThoat_Click);
            // 
            // btnLoaiBo
            // 
            this.btnLoaiBo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoaiBo.Location = new System.Drawing.Point(340, 393);
            this.btnLoaiBo.Name = "btnLoaiBo";
            this.btnLoaiBo.Size = new System.Drawing.Size(120, 32);
            this.btnLoaiBo.TabIndex = 29;
            this.btnLoaiBo.Text = "&Loại bỏ";
            this.btnLoaiBo.Click += new System.EventHandler(this.btnLoaiBo_Click);
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemMoi.Location = new System.Drawing.Point(340, 353);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(120, 32);
            this.btnThemMoi.TabIndex = 28;
            this.btnThemMoi.Text = "Thêm &mới";
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // btnTiepNhan
            // 
            this.btnTiepNhan.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTiepNhan.Location = new System.Drawing.Point(340, 313);
            this.btnTiepNhan.Name = "btnTiepNhan";
            this.btnTiepNhan.Size = new System.Drawing.Size(120, 32);
            this.btnTiepNhan.TabIndex = 27;
            this.btnTiepNhan.Text = "&Tiếp nhận";
            this.btnTiepNhan.Click += new System.EventHandler(this.btnTiepNhan_Click);
            // 
            // lstDanhSach
            // 
            this.lstDanhSach.DisplayMember = "HoTen";
            this.lstDanhSach.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstDanhSach.ItemHeight = 15;
            this.lstDanhSach.Location = new System.Drawing.Point(36, 313);
            this.lstDanhSach.Name = "lstDanhSach";
            this.lstDanhSach.Size = new System.Drawing.Size(280, 154);
            this.lstDanhSach.TabIndex = 31;
            this.lstDanhSach.Tag = "";
            this.lstDanhSach.SelectedIndexChanged += new System.EventHandler(this.lstDanhSach_SelectedIndexChanged);
            // 
            // grpPhai
            // 
            this.grpPhai.Controls.Add(this.radNu);
            this.grpPhai.Controls.Add(this.radNam);
            this.grpPhai.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPhai.Location = new System.Drawing.Point(300, 241);
            this.grpPhai.Name = "grpPhai";
            this.grpPhai.Size = new System.Drawing.Size(168, 46);
            this.grpPhai.TabIndex = 26;
            this.grpPhai.TabStop = false;
            // 
            // radNu
            // 
            this.radNu.Location = new System.Drawing.Point(93, 17);
            this.radNu.Name = "radNu";
            this.radNu.Size = new System.Drawing.Size(48, 24);
            this.radNu.TabIndex = 1;
            this.radNu.Text = "Nữ";
            // 
            // radNam
            // 
            this.radNam.Checked = true;
            this.radNam.Location = new System.Drawing.Point(16, 17);
            this.radNam.Name = "radNam";
            this.radNam.Size = new System.Drawing.Size(64, 24);
            this.radNam.TabIndex = 0;
            this.radNam.TabStop = true;
            this.radNam.Text = "Nam";
            // 
            // txtNamSinh
            // 
            this.txtNamSinh.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamSinh.Location = new System.Drawing.Point(172, 262);
            this.txtNamSinh.MaxLength = 4;
            this.txtNamSinh.Name = "txtNamSinh";
            this.txtNamSinh.Size = new System.Drawing.Size(104, 20);
            this.txtNamSinh.TabIndex = 25;
            this.txtNamSinh.Validated += new System.EventHandler(this.txtNamSinh_Validated);
            this.txtNamSinh.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNamSinh_KeyDown);
            this.txtNamSinh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNamSinh_KeyPress);
            // 
            // cboChucVu
            // 
            this.cboChucVu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChucVu.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboChucVu.Items.AddRange(new object[] {
            "Nhân viên",
            "Thủ kho",
            "Trưởng phòng",
            "Phó phòng",
            "Phó giám đốc",
            "Giám đốc"});
            this.cboChucVu.Location = new System.Drawing.Point(172, 209);
            this.cboChucVu.Name = "cboChucVu";
            this.cboChucVu.Size = new System.Drawing.Size(184, 22);
            this.cboChucVu.TabIndex = 22;
            this.cboChucVu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboChucVu_KeyDown);
            // 
            // cboPhongBan
            // 
            this.cboPhongBan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPhongBan.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPhongBan.Items.AddRange(new object[] {
            "Bảo vệ",
            "Kỹ thuật",
            "Kế toán",
            "Kho vận",
            "Kế hoạch",
            "Tiếp thị",
            "Giám đốc",
            "Hành chánh"});
            this.cboPhongBan.Location = new System.Drawing.Point(172, 161);
            this.cboPhongBan.Name = "cboPhongBan";
            this.cboPhongBan.Size = new System.Drawing.Size(184, 22);
            this.cboPhongBan.TabIndex = 21;
            this.cboPhongBan.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboPhongBan_KeyDown);
            // 
            // txtHoTen
            // 
            this.txtHoTen.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.Location = new System.Drawing.Point(172, 105);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(224, 20);
            this.txtHoTen.TabIndex = 18;
            this.txtHoTen.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtHoTen_KeyDown);
            // 
            // Label5
            // 
            this.Label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(36, 257);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(120, 24);
            this.Label5.TabIndex = 24;
            this.Label5.Text = "Năm sinh:";
            this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label4
            // 
            this.Label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(36, 209);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(120, 24);
            this.Label4.TabIndex = 23;
            this.Label4.Text = "Chức vụ:";
            this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label3
            // 
            this.Label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(36, 161);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(120, 24);
            this.Label3.TabIndex = 20;
            this.Label3.Text = "Phòng ban:";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label2
            // 
            this.Label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(36, 105);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(120, 24);
            this.Label2.TabIndex = 19;
            this.Label2.Text = "Họ và tên:";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label1
            // 
            this.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(124, 9);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(280, 40);
            this.Label1.TabIndex = 16;
            this.Label1.Text = "HỒ SƠ NHÂN VIÊN";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDau
            // 
            this.btnDau.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDau.Location = new System.Drawing.Point(6, 14);
            this.btnDau.Name = "btnDau";
            this.btnDau.Size = new System.Drawing.Size(26, 23);
            this.btnDau.TabIndex = 33;
            this.btnDau.Text = "|<";
            this.btnDau.UseVisualStyleBackColor = true;
            this.btnDau.Click += new System.EventHandler(this.btnDau_Click);
            // 
            // btnTruoc
            // 
            this.btnTruoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTruoc.Location = new System.Drawing.Point(31, 14);
            this.btnTruoc.Name = "btnTruoc";
            this.btnTruoc.Size = new System.Drawing.Size(26, 23);
            this.btnTruoc.TabIndex = 34;
            this.btnTruoc.Text = "<";
            this.btnTruoc.UseVisualStyleBackColor = true;
            this.btnTruoc.Click += new System.EventHandler(this.btnTruoc_Click);
            // 
            // btnSau
            // 
            this.btnSau.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSau.Location = new System.Drawing.Point(109, 14);
            this.btnSau.Name = "btnSau";
            this.btnSau.Size = new System.Drawing.Size(26, 23);
            this.btnSau.TabIndex = 36;
            this.btnSau.Text = ">";
            this.btnSau.UseVisualStyleBackColor = true;
            this.btnSau.Click += new System.EventHandler(this.btnSau_Click);
            // 
            // btnCuoi
            // 
            this.btnCuoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCuoi.Location = new System.Drawing.Point(134, 14);
            this.btnCuoi.Name = "btnCuoi";
            this.btnCuoi.Size = new System.Drawing.Size(26, 23);
            this.btnCuoi.TabIndex = 37;
            this.btnCuoi.Text = ">|";
            this.btnCuoi.UseVisualStyleBackColor = true;
            this.btnCuoi.Click += new System.EventHandler(this.btnCuoi_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblSoNV);
            this.groupBox2.Controls.Add(this.btnCuoi);
            this.groupBox2.Controls.Add(this.btnSau);
            this.groupBox2.Controls.Add(this.btnTruoc);
            this.groupBox2.Controls.Add(this.btnDau);
            this.groupBox2.Location = new System.Drawing.Point(98, 473);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(165, 45);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            // 
            // lblSoNV
            // 
            this.lblSoNV.BackColor = System.Drawing.Color.White;
            this.lblSoNV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSoNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoNV.Location = new System.Drawing.Point(57, 14);
            this.lblSoNV.Name = "lblSoNV";
            this.lblSoNV.Size = new System.Drawing.Size(51, 23);
            this.lblSoNV.TabIndex = 39;
            this.lblSoNV.Text = "0/0";
            this.lblSoNV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmHoSoNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 530);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtMaSo);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.bntThoat);
            this.Controls.Add(this.btnLoaiBo);
            this.Controls.Add(this.btnThemMoi);
            this.Controls.Add(this.btnTiepNhan);
            this.Controls.Add(this.lstDanhSach);
            this.Controls.Add(this.grpPhai);
            this.Controls.Add(this.txtNamSinh);
            this.Controls.Add(this.cboChucVu);
            this.Controls.Add(this.cboPhongBan);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Name = "frmHoSoNV";
            this.Text = "Quản lý nhân viên";
            this.Load += new System.EventHandler(this.frmHoSoNV_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmHoSoNV_FormClosed);
            this.grpPhai.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox txtMaSo;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Button bntThoat;
        internal System.Windows.Forms.Button btnLoaiBo;
        internal System.Windows.Forms.Button btnThemMoi;
        internal System.Windows.Forms.Button btnTiepNhan;
        internal System.Windows.Forms.ListBox lstDanhSach;
        internal System.Windows.Forms.GroupBox grpPhai;
        internal System.Windows.Forms.RadioButton radNu;
        internal System.Windows.Forms.RadioButton radNam;
        internal System.Windows.Forms.TextBox txtNamSinh;
        internal System.Windows.Forms.ComboBox cboChucVu;
        internal System.Windows.Forms.ComboBox cboPhongBan;
        internal System.Windows.Forms.TextBox txtHoTen;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Button btnDau;
        private System.Windows.Forms.Button btnTruoc;
        private System.Windows.Forms.Button btnSau;
        private System.Windows.Forms.Button btnCuoi;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblSoNV;
    }
}

