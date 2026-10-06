namespace DiemThi_Class_File
{
    partial class frmBangDiem
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnLoadFile = new System.Windows.Forms.Button();
            this.btnSaveFile = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLoaiBo = new System.Windows.Forms.Button();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.btnTiepNhan = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.lblSoThiSinh = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSBD = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.lstDanhSach = new System.Windows.Forms.ListBox();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.radNu = new System.Windows.Forms.RadioButton();
            this.radNam = new System.Windows.Forms.RadioButton();
            this.txtNamSinh = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.bntThoat = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtToan = new System.Windows.Forms.TextBox();
            this.txtLy = new System.Windows.Forms.TextBox();
            this.txtHoa = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboHDThi = new System.Windows.Forms.ComboBox();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.btnLoadFile);
            this.groupBox3.Controls.Add(this.btnSaveFile);
            this.groupBox3.Location = new System.Drawing.Point(24, 392);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(191, 53);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            // 
            // btnLoadFile
            // 
            this.btnLoadFile.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadFile.Location = new System.Drawing.Point(7, 13);
            this.btnLoadFile.Name = "btnLoadFile";
            this.btnLoadFile.Size = new System.Drawing.Size(86, 33);
            this.btnLoadFile.TabIndex = 0;
            this.btnLoadFile.Text = "&Lấy từ File";
            this.btnLoadFile.Click += new System.EventHandler(this.btnLoadFile_Click);
            // 
            // btnSaveFile
            // 
            this.btnSaveFile.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveFile.Location = new System.Drawing.Point(99, 13);
            this.btnSaveFile.Name = "btnSaveFile";
            this.btnSaveFile.Size = new System.Drawing.Size(86, 31);
            this.btnSaveFile.TabIndex = 1;
            this.btnSaveFile.Text = "Lưu vào &File";
            this.btnSaveFile.Click += new System.EventHandler(this.btnSaveFile_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnLoaiBo);
            this.groupBox2.Controls.Add(this.btnThemMoi);
            this.groupBox2.Controls.Add(this.btnTiepNhan);
            this.groupBox2.Location = new System.Drawing.Point(221, 392);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(293, 54);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // btnLoaiBo
            // 
            this.btnLoaiBo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoaiBo.Location = new System.Drawing.Point(198, 13);
            this.btnLoaiBo.Name = "btnLoaiBo";
            this.btnLoaiBo.Size = new System.Drawing.Size(86, 31);
            this.btnLoaiBo.TabIndex = 2;
            this.btnLoaiBo.Text = "Loại &bỏ";
            this.btnLoaiBo.Click += new System.EventHandler(this.btnLoaiBo_Click);
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemMoi.Location = new System.Drawing.Point(106, 13);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(86, 31);
            this.btnThemMoi.TabIndex = 1;
            this.btnThemMoi.Text = "Thêm &mới";
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // btnTiepNhan
            // 
            this.btnTiepNhan.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTiepNhan.Location = new System.Drawing.Point(7, 13);
            this.btnTiepNhan.Name = "btnTiepNhan";
            this.btnTiepNhan.Size = new System.Drawing.Size(86, 31);
            this.btnTiepNhan.TabIndex = 0;
            this.btnTiepNhan.Text = "&Tiếp nhận";
            this.btnTiepNhan.Click += new System.EventHandler(this.btnTiepNhan_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(136, 350);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(86, 33);
            this.btnSua.TabIndex = 9;
            this.btnSua.Text = "Lưu &sửa đổi";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // lblSoThiSinh
            // 
            this.lblSoThiSinh.BackColor = System.Drawing.Color.Transparent;
            this.lblSoThiSinh.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSoThiSinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoThiSinh.Location = new System.Drawing.Point(522, 350);
            this.lblSoThiSinh.Name = "lblSoThiSinh";
            this.lblSoThiSinh.Size = new System.Drawing.Size(53, 26);
            this.lblSoThiSinh.TabIndex = 6;
            this.lblSoThiSinh.Text = "0";
            this.lblSoThiSinh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(405, 357);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Tổng số thí sinh";
            // 
            // txtSBD
            // 
            this.txtSBD.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSBD.Location = new System.Drawing.Point(136, 71);
            this.txtSBD.MaxLength = 5;
            this.txtSBD.Name = "txtSBD";
            this.txtSBD.Size = new System.Drawing.Size(80, 20);
            this.txtSBD.TabIndex = 0;
            // 
            // Label6
            // 
            this.Label6.BackColor = System.Drawing.Color.Transparent;
            this.Label6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(39, 73);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(86, 14);
            this.Label6.TabIndex = 0;
            this.Label6.Text = "Số báo danh";
            this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lstDanhSach
            // 
            this.lstDanhSach.DisplayMember = "HoTen";
            this.lstDanhSach.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstDanhSach.ItemHeight = 16;
            this.lstDanhSach.Location = new System.Drawing.Point(391, 94);
            this.lstDanhSach.Name = "lstDanhSach";
            this.lstDanhSach.Size = new System.Drawing.Size(200, 244);
            this.lstDanhSach.TabIndex = 12;
            this.lstDanhSach.TabStop = false;
            this.lstDanhSach.Tag = "";
            this.lstDanhSach.SelectedIndexChanged += new System.EventHandler(this.lstDanhSach_SelectedIndexChanged);
            // 
            // GroupBox1
            // 
            this.GroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.GroupBox1.Controls.Add(this.radNu);
            this.GroupBox1.Controls.Add(this.radNam);
            this.GroupBox1.Font = new System.Drawing.Font("VNI-Times", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.Location = new System.Drawing.Point(217, 128);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(123, 34);
            this.GroupBox1.TabIndex = 3;
            this.GroupBox1.TabStop = false;
            // 
            // radNu
            // 
            this.radNu.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radNu.Location = new System.Drawing.Point(74, 11);
            this.radNu.Name = "radNu";
            this.radNu.Size = new System.Drawing.Size(48, 20);
            this.radNu.TabIndex = 1;
            this.radNu.Text = "Nữ";
            // 
            // radNam
            // 
            this.radNam.Checked = true;
            this.radNam.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radNam.Location = new System.Drawing.Point(11, 11);
            this.radNam.Name = "radNam";
            this.radNam.Size = new System.Drawing.Size(55, 20);
            this.radNam.TabIndex = 0;
            this.radNam.TabStop = true;
            this.radNam.Text = "Nam";
            // 
            // txtNamSinh
            // 
            this.txtNamSinh.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamSinh.Location = new System.Drawing.Point(136, 139);
            this.txtNamSinh.MaxLength = 4;
            this.txtNamSinh.Name = "txtNamSinh";
            this.txtNamSinh.Size = new System.Drawing.Size(75, 20);
            this.txtNamSinh.TabIndex = 2;
            this.txtNamSinh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNamSinh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNamSinh_KeyPress);
            this.txtNamSinh.Validating += new System.ComponentModel.CancelEventHandler(this.txtNamSinh_Validating);
            // 
            // txtHoTen
            // 
            this.txtHoTen.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.Location = new System.Drawing.Point(136, 104);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(160, 20);
            this.txtHoTen.TabIndex = 1;
            // 
            // Label5
            // 
            this.Label5.BackColor = System.Drawing.Color.Transparent;
            this.Label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(39, 139);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(86, 15);
            this.Label5.TabIndex = 2;
            this.Label5.Text = "Năm sinh";
            this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label3
            // 
            this.Label3.BackColor = System.Drawing.Color.Transparent;
            this.Label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(38, 171);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(86, 15);
            this.Label3.TabIndex = 47;
            this.Label3.Text = "Phòng ban";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label2
            // 
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(39, 106);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(86, 15);
            this.Label2.TabIndex = 1;
            this.Label2.Text = "Họ và tên";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label1
            // 
            this.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(159, 9);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(319, 41);
            this.Label1.TabIndex = 19;
            this.Label1.Text = "BẢNG ĐIỂM THI TUYỂN SINH";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bntThoat
            // 
            this.bntThoat.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntThoat.Location = new System.Drawing.Point(526, 406);
            this.bntThoat.Name = "bntThoat";
            this.bntThoat.Size = new System.Drawing.Size(86, 31);
            this.bntThoat.TabIndex = 10;
            this.bntThoat.Text = "Th&oát";
            this.bntThoat.Click += new System.EventHandler(this.bntThoat_Click);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(38, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 15);
            this.label8.TabIndex = 3;
            this.label8.Text = "Địa chỉ";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(388, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(203, 20);
            this.label10.TabIndex = 18;
            this.label10.Text = "Danh sách thí sinh";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(68, 33);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 20);
            this.label11.TabIndex = 3;
            this.label11.Text = "Toán";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Location = new System.Drawing.Point(136, 171);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(203, 20);
            this.txtDiaChi.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(142, 33);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 20);
            this.label12.TabIndex = 1;
            this.label12.Text = "Lý";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(216, 33);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 20);
            this.label13.TabIndex = 2;
            this.label13.Text = "Hóa";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtToan
            // 
            this.txtToan.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtToan.Location = new System.Drawing.Point(67, 59);
            this.txtToan.MaxLength = 2;
            this.txtToan.Name = "txtToan";
            this.txtToan.Size = new System.Drawing.Size(50, 20);
            this.txtToan.TabIndex = 2;
            this.txtToan.Text = "0";
            this.txtToan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtToan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtToan_KeyPress);
            this.txtToan.Validating += new System.ComponentModel.CancelEventHandler(this.txtToan_Validating);
            // 
            // txtLy
            // 
            this.txtLy.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLy.Location = new System.Drawing.Point(141, 59);
            this.txtLy.MaxLength = 2;
            this.txtLy.Name = "txtLy";
            this.txtLy.Size = new System.Drawing.Size(50, 20);
            this.txtLy.TabIndex = 4;
            this.txtLy.Text = "0";
            this.txtLy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLy_KeyPress);
            this.txtLy.Validating += new System.ComponentModel.CancelEventHandler(this.txtLy_Validating);
            // 
            // txtHoa
            // 
            this.txtHoa.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoa.Location = new System.Drawing.Point(215, 59);
            this.txtHoa.MaxLength = 2;
            this.txtHoa.Name = "txtHoa";
            this.txtHoa.Size = new System.Drawing.Size(50, 20);
            this.txtHoa.TabIndex = 5;
            this.txtHoa.Text = "0";
            this.txtHoa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtHoa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHoa_KeyPress);
            this.txtHoa.Validating += new System.ComponentModel.CancelEventHandler(this.txtHoa_Validating);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtHoa);
            this.groupBox5.Controls.Add(this.txtLy);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.txtToan);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(42, 237);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(298, 101);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Điểm các môn thi:";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 15);
            this.label4.TabIndex = 48;
            this.label4.Text = "Hội đồng thi:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboHDThi
            // 
            this.cboHDThi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHDThi.FormattingEnabled = true;
            this.cboHDThi.Items.AddRange(new object[] {
            "Lý Tự Trọng",
            "Nguyễn Thượng Hiền",
            "Phú Nhuận",
            "Nguyễn Gia Thiều"});
            this.cboHDThi.Location = new System.Drawing.Point(136, 201);
            this.cboHDThi.Name = "cboHDThi";
            this.cboHDThi.Size = new System.Drawing.Size(203, 21);
            this.cboHDThi.TabIndex = 5;
            // 
            // frmBangDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 464);
            this.Controls.Add(this.cboHDThi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.bntThoat);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblSoThiSinh);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSBD);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.lstDanhSach);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.txtNamSinh);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.groupBox5);
            this.Name = "frmBangDiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trường CĐKT Lý Tự Trọng";
            this.Load += new System.EventHandler(this.frmBangDiem_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmBangDiem_FormClosed);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmBangDiem_FormClosing);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.GroupBox1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        internal System.Windows.Forms.Button btnLoadFile;
        internal System.Windows.Forms.Button btnSaveFile;
        private System.Windows.Forms.GroupBox groupBox2;
        internal System.Windows.Forms.Button btnSua;
        internal System.Windows.Forms.Button btnLoaiBo;
        internal System.Windows.Forms.Button btnThemMoi;
        internal System.Windows.Forms.Button btnTiepNhan;
        private System.Windows.Forms.Label lblSoThiSinh;
        private System.Windows.Forms.Label label7;
        internal System.Windows.Forms.TextBox txtSBD;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.ListBox lstDanhSach;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.RadioButton radNu;
        internal System.Windows.Forms.RadioButton radNam;
        internal System.Windows.Forms.TextBox txtNamSinh;
        internal System.Windows.Forms.TextBox txtHoTen;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button bntThoat;
        internal System.Windows.Forms.Label label8;
        internal System.Windows.Forms.Label label10;
        internal System.Windows.Forms.Label label11;
        internal System.Windows.Forms.TextBox txtDiaChi;
        internal System.Windows.Forms.Label label12;
        internal System.Windows.Forms.Label label13;
        internal System.Windows.Forms.TextBox txtToan;
        internal System.Windows.Forms.TextBox txtLy;
        internal System.Windows.Forms.TextBox txtHoa;
        private System.Windows.Forms.GroupBox groupBox5;
        internal System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboHDThi;
    }
}

