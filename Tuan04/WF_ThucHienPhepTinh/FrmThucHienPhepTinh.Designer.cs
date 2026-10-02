namespace Buoi7_FrmThucHienPhepTinh
{
    partial class FrmThucHienPhepTinh
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            txtSoA = new TextBox();
            txtSoB = new TextBox();
            label2 = new Label();
            txtKetQua = new TextBox();
            label3 = new Label();
            btnCong = new Button();
            btnTru = new Button();
            btnChia = new Button();
            btnNhan = new Button();
            btnTiepTuc = new Button();
            btnThoat = new Button();
            errorLoi = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorLoi).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 14);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(45, 20);
            label1.TabIndex = 0;
            label1.Text = "Số a: ";
            // 
            // txtSoA
            // 
            txtSoA.Location = new Point(87, 9);
            txtSoA.Margin = new Padding(4, 5, 4, 5);
            txtSoA.Name = "txtSoA";
            txtSoA.RightToLeft = RightToLeft.Yes;
            txtSoA.Size = new Size(172, 27);
            txtSoA.TabIndex = 1;
            txtSoA.Text = "2";
            txtSoA.Validating += NhapSo_Validating;
            // 
            // txtSoB
            // 
            txtSoB.Location = new Point(87, 49);
            txtSoB.Margin = new Padding(4, 5, 4, 5);
            txtSoB.Name = "txtSoB";
            txtSoB.RightToLeft = RightToLeft.Yes;
            txtSoB.Size = new Size(172, 27);
            txtSoB.TabIndex = 3;
            txtSoB.Text = "3";
            txtSoB.Validating += NhapSo_Validating;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 54);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 2;
            label2.Text = "Số b:";
            // 
            // txtKetQua
            // 
            txtKetQua.Location = new Point(87, 131);
            txtKetQua.Margin = new Padding(4, 5, 4, 5);
            txtKetQua.Name = "txtKetQua";
            txtKetQua.ReadOnly = true;
            txtKetQua.Size = new Size(172, 27);
            txtKetQua.TabIndex = 5;
            txtKetQua.Text = "5";
            txtKetQua.TextAlign = HorizontalAlignment.Right;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 135);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(63, 20);
            label3.TabIndex = 4;
            label3.Text = "Kết quả:";
            // 
            // btnCong
            // 
            btnCong.Location = new Point(268, 6);
            btnCong.Margin = new Padding(4, 5, 4, 5);
            btnCong.Name = "btnCong";
            btnCong.Size = new Size(41, 35);
            btnCong.TabIndex = 6;
            btnCong.Text = "+";
            btnCong.UseVisualStyleBackColor = true;
            // 
            // btnTru
            // 
            btnTru.Location = new Point(317, 6);
            btnTru.Margin = new Padding(4, 5, 4, 5);
            btnTru.Name = "btnTru";
            btnTru.Size = new Size(41, 35);
            btnTru.TabIndex = 7;
            btnTru.Text = "-";
            btnTru.UseVisualStyleBackColor = true;
            // 
            // btnChia
            // 
            btnChia.Location = new Point(317, 46);
            btnChia.Margin = new Padding(4, 5, 4, 5);
            btnChia.Name = "btnChia";
            btnChia.Size = new Size(41, 35);
            btnChia.TabIndex = 9;
            btnChia.Text = "/";
            btnChia.UseVisualStyleBackColor = true;
            // 
            // btnNhan
            // 
            btnNhan.Location = new Point(268, 46);
            btnNhan.Margin = new Padding(4, 5, 4, 5);
            btnNhan.Name = "btnNhan";
            btnNhan.Size = new Size(41, 35);
            btnNhan.TabIndex = 8;
            btnNhan.Text = "*";
            btnNhan.UseVisualStyleBackColor = true;
            // 
            // btnTiepTuc
            // 
            btnTiepTuc.Location = new Point(268, 86);
            btnTiepTuc.Margin = new Padding(4, 5, 4, 5);
            btnTiepTuc.Name = "btnTiepTuc";
            btnTiepTuc.Size = new Size(91, 35);
            btnTiepTuc.TabIndex = 10;
            btnTiepTuc.Text = "Tiếp tục";
            btnTiepTuc.UseVisualStyleBackColor = true;
            btnTiepTuc.Click += btnTiepTuc_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(268, 131);
            btnThoat.Margin = new Padding(4, 5, 4, 5);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(91, 35);
            btnThoat.TabIndex = 11;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // errorLoi
            // 
            errorLoi.ContainerControl = this;
            // 
            // FrmThucHienPhepTinh
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(375, 178);
            Controls.Add(btnThoat);
            Controls.Add(btnTiepTuc);
            Controls.Add(btnChia);
            Controls.Add(btnNhan);
            Controls.Add(btnTru);
            Controls.Add(btnCong);
            Controls.Add(txtKetQua);
            Controls.Add(label3);
            Controls.Add(txtSoB);
            Controls.Add(label2);
            Controls.Add(txtSoA);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FrmThucHienPhepTinh";
            Text = "Thực hiện phép tính";
            Load += FrmThucHienPhepTinh_Load;
            ((System.ComponentModel.ISupportInitialize)errorLoi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSoA;
        private System.Windows.Forms.TextBox txtSoB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKetQua;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCong;
        private System.Windows.Forms.Button btnTru;
        private System.Windows.Forms.Button btnChia;
        private System.Windows.Forms.Button btnNhan;
        private System.Windows.Forms.Button btnTiepTuc;
        private System.Windows.Forms.Button btnThoat;
        private ErrorProvider errorLoi;
    }
}

