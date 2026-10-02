namespace Buoi7_FrmThongTinCaNhan
{
    partial class FrmXacNhan
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
            txtHoTen = new TextBox();
            txtNgaySinh = new TextBox();
            label2 = new Label();
            txtSoThich = new TextBox();
            label3 = new Label();
            btnXacNhan = new Button();
            errNhapLieu = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errNhapLieu).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 14);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 0;
            label1.Text = "Họ và tên:";
            // 
            // txtHoTen
            // 
            txtHoTen.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtHoTen.Location = new Point(100, 9);
            txtHoTen.Margin = new Padding(4, 5, 4, 5);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(223, 27);
            txtHoTen.TabIndex = 0;
            txtHoTen.Validating += txtHoTen_Validating;
            // 
            // txtNgaySinh
            // 
            txtNgaySinh.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNgaySinh.Location = new Point(100, 49);
            txtNgaySinh.Margin = new Padding(4, 5, 4, 5);
            txtNgaySinh.Name = "txtNgaySinh";
            txtNgaySinh.Size = new Size(223, 27);
            txtNgaySinh.TabIndex = 1;
            txtNgaySinh.Validating += txtNgaySinh_Validating;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 54);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 2;
            label2.Text = "Ngày sinh";
            // 
            // txtSoThich
            // 
            txtSoThich.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtSoThich.Location = new Point(100, 89);
            txtSoThich.Margin = new Padding(4, 5, 4, 5);
            txtSoThich.Multiline = true;
            txtSoThich.Name = "txtSoThich";
            txtSoThich.Size = new Size(223, 75);
            txtSoThich.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 94);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 4;
            label3.Text = "Sở thích:";
            // 
            // btnXacNhan
            // 
            btnXacNhan.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnXacNhan.Location = new Point(100, 173);
            btnXacNhan.Margin = new Padding(4, 5, 4, 5);
            btnXacNhan.Name = "btnXacNhan";
            btnXacNhan.Size = new Size(148, 35);
            btnXacNhan.TabIndex = 3;
            btnXacNhan.Text = "&Xác nhận (F1)";
            btnXacNhan.UseVisualStyleBackColor = true;
            btnXacNhan.Click += btnXacNhan_Click;
            // 
            // errNhapLieu
            // 
            errNhapLieu.ContainerControl = this;
            // 
            // FrmXacNhan
            // 
            AcceptButton = btnXacNhan;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(340, 221);
            Controls.Add(btnXacNhan);
            Controls.Add(txtSoThich);
            Controls.Add(label3);
            Controls.Add(txtNgaySinh);
            Controls.Add(label2);
            Controls.Add(txtHoTen);
            Controls.Add(label1);
            KeyPreview = true;
            Margin = new Padding(4, 5, 4, 5);
            Name = "FrmXacNhan";
            Text = "Thông tin cá nhân";
            KeyDown += FrmXacNhan_KeyDown;
            ((System.ComponentModel.ISupportInitialize)errNhapLieu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtNgaySinh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSoThich;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.ErrorProvider errNhapLieu;
    }
}

