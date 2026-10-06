namespace CacThaoTacTrenMang
{
    partial class frmMatMa
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
            this.txtMatMa = new System.Windows.Forms.TextBox();
            this.lblSoLan = new System.Windows.Forms.Label();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "ĐĂNG NHẬP CHƯƠNG TRÌNH";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật mã";
            // 
            // txtMatMa
            // 
            this.txtMatMa.Location = new System.Drawing.Point(99, 101);
            this.txtMatMa.Name = "txtMatMa";
            this.txtMatMa.PasswordChar = '*';
            this.txtMatMa.Size = new System.Drawing.Size(146, 20);
            this.txtMatMa.TabIndex = 2;
            // 
            // lblSoLan
            // 
            this.lblSoLan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSoLan.Location = new System.Drawing.Point(98, 145);
            this.lblSoLan.Name = "lblSoLan";
            this.lblSoLan.Size = new System.Drawing.Size(146, 23);
            this.lblSoLan.TabIndex = 3;
            this.lblSoLan.Text = "Đăng nhập lần 1";
            this.lblSoLan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Location = new System.Drawing.Point(260, 101);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(99, 22);
            this.btnDangNhap.TabIndex = 4;
            this.btnDangNhap.Text = "Đăng &nhập";
            this.btnDangNhap.UseVisualStyleBackColor = true;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(260, 146);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(99, 22);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "&Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmMatMa
            // 
            this.AcceptButton = this.btnDangNhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 198);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.lblSoLan);
            this.Controls.Add(this.txtMatMa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmMatMa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kiểm tra mật mã";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMatMa;
        private System.Windows.Forms.Label lblSoLan;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.Button btnThoat;
    }
}