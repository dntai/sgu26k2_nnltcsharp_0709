namespace ThucDonAnNhau_Class_ListBox
{
    partial class frmThucDonAnNhau
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
            this.lblTongCong = new System.Windows.Forms.Label();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.lblDonGia = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.Label4 = new System.Windows.Forms.Label();
            this.lstMonChon = new System.Windows.Forms.ListBox();
            this.btnBoChonHet = new System.Windows.Forms.Button();
            this.btnBoChon = new System.Windows.Forms.Button();
            this.btnChon = new System.Windows.Forms.Button();
            this.lstThucDon = new System.Windows.Forms.ListBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTongCong
            // 
            this.lblTongCong.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTongCong.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongCong.Location = new System.Drawing.Point(204, 332);
            this.lblTongCong.Name = "lblTongCong";
            this.lblTongCong.Size = new System.Drawing.Size(118, 24);
            this.lblTongCong.TabIndex = 29;
            this.lblTongCong.Text = "0";
            this.lblTongCong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSoLuong.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLuong.Location = new System.Drawing.Point(382, 65);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(40, 24);
            this.lblSoLuong.TabIndex = 28;
            this.lblSoLuong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDonGia
            // 
            this.lblDonGia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDonGia.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonGia.Location = new System.Drawing.Point(174, 65);
            this.lblDonGia.Name = "lblDonGia";
            this.lblDonGia.Size = new System.Drawing.Size(80, 24);
            this.lblDonGia.TabIndex = 27;
            this.lblDonGia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(373, 329);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(88, 32);
            this.btnThoat.TabIndex = 26;
            this.btnThoat.Text = "&Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Label4
            // 
            this.Label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.Color.Maroon;
            this.Label4.Location = new System.Drawing.Point(118, 337);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(80, 24);
            this.Label4.TabIndex = 25;
            this.Label4.Text = "Tổng cộng";
            // 
            // lstMonChon
            // 
            this.lstMonChon.DisplayMember = "Ten";
            this.lstMonChon.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstMonChon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lstMonChon.ItemHeight = 15;
            this.lstMonChon.Location = new System.Drawing.Point(317, 145);
            this.lstMonChon.Name = "lstMonChon";
            this.lstMonChon.Size = new System.Drawing.Size(144, 154);
            this.lstMonChon.Sorted = true;
            this.lstMonChon.TabIndex = 24;
            this.lstMonChon.SelectedIndexChanged += new System.EventHandler(this.lstMonChon_SelectedIndexChanged);
            // 
            // btnBoChonHet
            // 
            this.btnBoChonHet.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBoChonHet.Location = new System.Drawing.Point(216, 265);
            this.btnBoChonHet.Name = "btnBoChonHet";
            this.btnBoChonHet.Size = new System.Drawing.Size(76, 24);
            this.btnBoChonHet.TabIndex = 23;
            this.btnBoChonHet.Text = "Bỏ &hết";
            this.btnBoChonHet.Click += new System.EventHandler(this.btnBoChonHet_Click);
            // 
            // btnBoChon
            // 
            this.btnBoChon.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBoChon.Location = new System.Drawing.Point(216, 225);
            this.btnBoChon.Name = "btnBoChon";
            this.btnBoChon.Size = new System.Drawing.Size(76, 24);
            this.btnBoChon.TabIndex = 22;
            this.btnBoChon.Text = "&Bỏ";
            this.btnBoChon.Click += new System.EventHandler(this.btnBoChon_Click);
            // 
            // btnChon
            // 
            this.btnChon.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChon.Location = new System.Drawing.Point(216, 145);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(76, 24);
            this.btnChon.TabIndex = 21;
            this.btnChon.Text = "&Chọn";
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // lstThucDon
            // 
            this.lstThucDon.DisplayMember = "Ten";
            this.lstThucDon.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstThucDon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lstThucDon.ItemHeight = 15;
            this.lstThucDon.Location = new System.Drawing.Point(47, 145);
            this.lstThucDon.Name = "lstThucDon";
            this.lstThucDon.Size = new System.Drawing.Size(144, 154);
            this.lstThucDon.Sorted = true;
            this.lstThucDon.TabIndex = 20;
            this.lstThucDon.SelectedIndexChanged += new System.EventHandler(this.lstThucDon_SelectedIndexChanged);
            // 
            // Label3
            // 
            this.Label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(286, 65);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(80, 24);
            this.Label3.TabIndex = 19;
            this.Label3.Text = "Số lượng";
            // 
            // Label2
            // 
            this.Label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(38, 65);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(120, 24);
            this.Label2.TabIndex = 18;
            this.Label2.Text = "Giá món đang chọn";
            // 
            // Label1
            // 
            this.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(130, 9);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(248, 32);
            this.Label1.TabIndex = 17;
            this.Label1.Text = "THỰC ĐƠN HÔM NAY";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmThucDonAnNhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(500, 379);
            this.Controls.Add(this.lblTongCong);
            this.Controls.Add(this.lblSoLuong);
            this.Controls.Add(this.lblDonGia);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.lstMonChon);
            this.Controls.Add(this.btnBoChonHet);
            this.Controls.Add(this.btnBoChon);
            this.Controls.Add(this.btnChon);
            this.Controls.Add(this.lstThucDon);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Name = "frmThucDonAnNhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Class và ListBox";
            this.Load += new System.EventHandler(this.frmThucDonAnNhau_Load);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Label lblTongCong;
        internal System.Windows.Forms.Label lblSoLuong;
        internal System.Windows.Forms.Label lblDonGia;
        internal System.Windows.Forms.Button btnThoat;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.ListBox lstMonChon;
        internal System.Windows.Forms.Button btnBoChonHet;
        internal System.Windows.Forms.Button btnBoChon;
        internal System.Windows.Forms.Button btnChon;
        internal System.Windows.Forms.ListBox lstThucDon;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
    }
}

