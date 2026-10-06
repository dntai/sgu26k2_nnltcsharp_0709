namespace KiemTraDinhDuong
{
    partial class frmKTDinhDuong
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
            this.lstMonAn = new System.Windows.Forms.ListBox();
            this.btnChon = new System.Windows.Forms.Button();
            this.btnBoChon = new System.Windows.Forms.Button();
            this.btnChonHet = new System.Windows.Forms.Button();
            this.btnBoHet = new System.Windows.Forms.Button();
            this.lstMonChon = new System.Windows.Forms.ListBox();
            this.lblTest = new System.Windows.Forms.Label();
            this.btnTest = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(155, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "BỮA ĂN CỦA BẠN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstMonAn
            // 
            this.lstMonAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstMonAn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lstMonAn.FormattingEnabled = true;
            this.lstMonAn.Location = new System.Drawing.Point(38, 108);
            this.lstMonAn.Name = "lstMonAn";
            this.lstMonAn.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstMonAn.Size = new System.Drawing.Size(140, 147);
            this.lstMonAn.Sorted = true;
            this.lstMonAn.TabIndex = 1;
            // 
            // btnChon
            // 
            this.btnChon.Location = new System.Drawing.Point(237, 108);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(75, 23);
            this.btnChon.TabIndex = 2;
            this.btnChon.Text = ">";
            this.btnChon.UseVisualStyleBackColor = true;
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // btnBoChon
            // 
            this.btnBoChon.Enabled = false;
            this.btnBoChon.Location = new System.Drawing.Point(237, 137);
            this.btnBoChon.Name = "btnBoChon";
            this.btnBoChon.Size = new System.Drawing.Size(75, 23);
            this.btnBoChon.TabIndex = 3;
            this.btnBoChon.Text = "<";
            this.btnBoChon.UseVisualStyleBackColor = true;
            this.btnBoChon.Click += new System.EventHandler(this.btnBoChon_Click);
            // 
            // btnChonHet
            // 
            this.btnChonHet.Location = new System.Drawing.Point(237, 205);
            this.btnChonHet.Name = "btnChonHet";
            this.btnChonHet.Size = new System.Drawing.Size(75, 23);
            this.btnChonHet.TabIndex = 4;
            this.btnChonHet.Text = ">>";
            this.btnChonHet.UseVisualStyleBackColor = true;
            this.btnChonHet.Click += new System.EventHandler(this.btnChonHet_Click);
            // 
            // btnBoHet
            // 
            this.btnBoHet.Enabled = false;
            this.btnBoHet.Location = new System.Drawing.Point(237, 234);
            this.btnBoHet.Name = "btnBoHet";
            this.btnBoHet.Size = new System.Drawing.Size(75, 23);
            this.btnBoHet.TabIndex = 5;
            this.btnBoHet.Text = "<<";
            this.btnBoHet.UseVisualStyleBackColor = true;
            this.btnBoHet.Click += new System.EventHandler(this.btnBoHet_Click);
            // 
            // lstMonChon
            // 
            this.lstMonChon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstMonChon.ForeColor = System.Drawing.Color.Green;
            this.lstMonChon.FormattingEnabled = true;
            this.lstMonChon.Location = new System.Drawing.Point(359, 108);
            this.lstMonChon.Name = "lstMonChon";
            this.lstMonChon.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstMonChon.Size = new System.Drawing.Size(140, 147);
            this.lstMonChon.Sorted = true;
            this.lstMonChon.TabIndex = 6;
            // 
            // lblTest
            // 
            this.lblTest.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTest.Location = new System.Drawing.Point(41, 276);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(359, 54);
            this.lblTest.TabIndex = 7;
            this.lblTest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(424, 276);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 8;
            this.btnTest.Text = "&Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(424, 307);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "Th&oát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(69, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Các món ăn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(372, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Sở thích của bạn";
            // 
            // frmKTDinhDuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 358);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.lblTest);
            this.Controls.Add(this.lstMonChon);
            this.Controls.Add(this.btnBoHet);
            this.Controls.Add(this.btnChonHet);
            this.Controls.Add(this.btnBoChon);
            this.Controls.Add(this.btnChon);
            this.Controls.Add(this.lstMonAn);
            this.Controls.Add(this.label1);
            this.Name = "frmKTDinhDuong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kiểm tra dinh dưỡng";
            this.Load += new System.EventHandler(this.frmKTDinhDuong_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstMonAn;
        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.Button btnBoChon;
        private System.Windows.Forms.Button btnChonHet;
        private System.Windows.Forms.Button btnBoHet;
        private System.Windows.Forms.ListBox lstMonChon;
        private System.Windows.Forms.Label lblTest;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

