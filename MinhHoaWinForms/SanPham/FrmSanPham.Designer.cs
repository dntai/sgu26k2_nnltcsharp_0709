namespace SanPham
{
    partial class FrmSanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSanPham));
            this.label1 = new System.Windows.Forms.Label();
            this.MayTinhTay = new System.Windows.Forms.RadioButton();
            this.PC = new System.Windows.Forms.RadioButton();
            this.MayPhoto = new System.Windows.Forms.RadioButton();
            this.LapTop = new System.Windows.Forms.RadioButton();
            this.Rada = new System.Windows.Forms.RadioButton();
            this.MayIn = new System.Windows.Forms.RadioButton();
            this.Phone = new System.Windows.Forms.RadioButton();
            this.DiaA = new System.Windows.Forms.RadioButton();
            this.btnThoat = new System.Windows.Forms.Button();
            this.Hinh = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Hinh)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Miriam", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(87, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(420, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Các mặt hàng hiện có bán tại các Đại lý";
            // 
            // MayTinhTay
            // 
            this.MayTinhTay.AutoSize = true;
            this.MayTinhTay.BackColor = System.Drawing.Color.Transparent;
            this.MayTinhTay.Checked = true;
            this.MayTinhTay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MayTinhTay.ForeColor = System.Drawing.Color.Maroon;
            this.MayTinhTay.Location = new System.Drawing.Point(42, 102);
            this.MayTinhTay.Name = "MayTinhTay";
            this.MayTinhTay.Size = new System.Drawing.Size(144, 24);
            this.MayTinhTay.TabIndex = 1;
            this.MayTinhTay.TabStop = true;
            this.MayTinhTay.Text = "Máy tính bỏ túi";
            this.MayTinhTay.UseVisualStyleBackColor = false;
            this.MayTinhTay.CheckedChanged += new System.EventHandler(this.MayTinhTay_CheckedChanged);
            // 
            // PC
            // 
            this.PC.AutoSize = true;
            this.PC.BackColor = System.Drawing.Color.Transparent;
            this.PC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PC.ForeColor = System.Drawing.Color.Maroon;
            this.PC.Location = new System.Drawing.Point(42, 139);
            this.PC.Name = "PC";
            this.PC.Size = new System.Drawing.Size(171, 24);
            this.PC.TabIndex = 2;
            this.PC.Text = "Máy vi tính để bàn";
            this.PC.UseVisualStyleBackColor = false;
            this.PC.CheckedChanged += new System.EventHandler(this.PC_CheckedChanged);
            // 
            // MayPhoto
            // 
            this.MayPhoto.AutoSize = true;
            this.MayPhoto.BackColor = System.Drawing.Color.Transparent;
            this.MayPhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MayPhoto.ForeColor = System.Drawing.Color.Maroon;
            this.MayPhoto.Location = new System.Drawing.Point(42, 181);
            this.MayPhoto.Name = "MayPhoto";
            this.MayPhoto.Size = new System.Drawing.Size(156, 24);
            this.MayPhoto.TabIndex = 3;
            this.MayPhoto.Text = "Máy Photo Copy";
            this.MayPhoto.UseVisualStyleBackColor = false;
            this.MayPhoto.CheckedChanged += new System.EventHandler(this.MayPhoto_CheckedChanged);
            // 
            // LapTop
            // 
            this.LapTop.AutoSize = true;
            this.LapTop.BackColor = System.Drawing.Color.Transparent;
            this.LapTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LapTop.ForeColor = System.Drawing.Color.Maroon;
            this.LapTop.Location = new System.Drawing.Point(42, 217);
            this.LapTop.Name = "LapTop";
            this.LapTop.Size = new System.Drawing.Size(166, 24);
            this.LapTop.TabIndex = 4;
            this.LapTop.Text = "Máy tính sách tay";
            this.LapTop.UseVisualStyleBackColor = false;
            this.LapTop.CheckedChanged += new System.EventHandler(this.LapTop_CheckedChanged);
            // 
            // Rada
            // 
            this.Rada.AutoSize = true;
            this.Rada.BackColor = System.Drawing.Color.Transparent;
            this.Rada.Font = new System.Drawing.Font("Murray", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rada.ForeColor = System.Drawing.Color.White;
            this.Rada.Location = new System.Drawing.Point(330, 341);
            this.Rada.Name = "Rada";
            this.Rada.Size = new System.Drawing.Size(147, 38);
            this.Rada.TabIndex = 8;
            this.Rada.Text = "Ăng ten Rada";
            this.Rada.UseVisualStyleBackColor = false;
            this.Rada.CheckedChanged += new System.EventHandler(this.Rada_CheckedChanged);
            // 
            // MayIn
            // 
            this.MayIn.AutoSize = true;
            this.MayIn.BackColor = System.Drawing.Color.Transparent;
            this.MayIn.Font = new System.Drawing.Font("Murray", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MayIn.ForeColor = System.Drawing.Color.White;
            this.MayIn.Location = new System.Drawing.Point(330, 305);
            this.MayIn.Name = "MayIn";
            this.MayIn.Size = new System.Drawing.Size(157, 38);
            this.MayIn.TabIndex = 7;
            this.MayIn.Text = "Máy in thế hệ 3";
            this.MayIn.UseVisualStyleBackColor = false;
            this.MayIn.CheckedChanged += new System.EventHandler(this.MayIn_CheckedChanged);
            // 
            // Phone
            // 
            this.Phone.AutoSize = true;
            this.Phone.BackColor = System.Drawing.Color.Transparent;
            this.Phone.Font = new System.Drawing.Font("Murray", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phone.ForeColor = System.Drawing.Color.White;
            this.Phone.Location = new System.Drawing.Point(330, 263);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(229, 38);
            this.Phone.TabIndex = 6;
            this.Phone.Text = "Trạm điện thoại công cộng";
            this.Phone.UseVisualStyleBackColor = false;
            this.Phone.CheckedChanged += new System.EventHandler(this.Phone_CheckedChanged);
            // 
            // DiaA
            // 
            this.DiaA.AutoSize = true;
            this.DiaA.BackColor = System.Drawing.Color.Transparent;
            this.DiaA.Font = new System.Drawing.Font("Murray", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiaA.ForeColor = System.Drawing.Color.White;
            this.DiaA.Location = new System.Drawing.Point(330, 226);
            this.DiaA.Name = "DiaA";
            this.DiaA.Size = new System.Drawing.Size(182, 38);
            this.DiaA.TabIndex = 5;
            this.DiaA.Text = "Đĩa mềm thế hệ mới";
            this.DiaA.UseVisualStyleBackColor = false;
            this.DiaA.CheckedChanged += new System.EventHandler(this.DiaA_CheckedChanged);
            // 
            // btnThoat
            // 
            this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(51, 316);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 27);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "&Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Hinh
            // 
            this.Hinh.BackColor = System.Drawing.Color.Transparent;
            this.Hinh.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Hinh.Location = new System.Drawing.Point(351, 96);
            this.Hinh.Name = "Hinh";
            this.Hinh.Size = new System.Drawing.Size(112, 120);
            this.Hinh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Hinh.TabIndex = 10;
            this.Hinh.TabStop = false;
            // 
            // FrmSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SanPham.Properties.Resources.Sample_Picture08;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnThoat;
            this.ClientSize = new System.Drawing.Size(635, 413);
            this.ControlBox = false;
            this.Controls.Add(this.Hinh);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.Rada);
            this.Controls.Add(this.MayIn);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.DiaA);
            this.Controls.Add(this.LapTop);
            this.Controls.Add(this.MayPhoto);
            this.Controls.Add(this.PC);
            this.Controls.Add(this.MayTinhTay);
            this.Controls.Add(this.label1);
            this.Name = "FrmSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "San pham";
            this.Load += new System.EventHandler(this.FrmSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Hinh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton MayTinhTay;
        private System.Windows.Forms.RadioButton PC;
        private System.Windows.Forms.RadioButton MayPhoto;
        private System.Windows.Forms.RadioButton LapTop;
        private System.Windows.Forms.RadioButton Rada;
        private System.Windows.Forms.RadioButton MayIn;
        private System.Windows.Forms.RadioButton Phone;
        private System.Windows.Forms.RadioButton DiaA;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.PictureBox Hinh;
    }
}