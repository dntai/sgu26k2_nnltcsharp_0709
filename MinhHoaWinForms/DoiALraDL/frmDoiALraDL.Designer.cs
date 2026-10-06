namespace DoiALraDL
{
    partial class frmDoiALraDL
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
            this.cboAmLich = new System.Windows.Forms.ComboBox();
            this.lstDuongLich = new System.Windows.Forms.ListBox();
            this.btnXem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn năm Âm lịch";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(265, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Các năm Dương lịch";
            // 
            // cboAmLich
            // 
            this.cboAmLich.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboAmLich.FormattingEnabled = true;
            this.cboAmLich.Location = new System.Drawing.Point(39, 50);
            this.cboAmLich.Name = "cboAmLich";
            this.cboAmLich.Size = new System.Drawing.Size(126, 24);
            this.cboAmLich.TabIndex = 2;
            // 
            // lstDuongLich
            // 
            this.lstDuongLich.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstDuongLich.FormattingEnabled = true;
            this.lstDuongLich.ItemHeight = 16;
            this.lstDuongLich.Location = new System.Drawing.Point(267, 49);
            this.lstDuongLich.Name = "lstDuongLich";
            this.lstDuongLich.Size = new System.Drawing.Size(111, 132);
            this.lstDuongLich.TabIndex = 3;
            // 
            // btnXem
            // 
            this.btnXem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXem.Location = new System.Drawing.Point(66, 216);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(99, 21);
            this.btnXem.TabIndex = 4;
            this.btnXem.Text = "&Xem";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(280, 216);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(99, 21);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "&Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmDoiALraDL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 266);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.lstDuongLich);
            this.Controls.Add(this.cboAmLich);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmDoiALraDL";
            this.Text = "Đổi năm Âm lịch ra Dương lịch";
            this.Load += new System.EventHandler(this.frmDoiALraDL_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboAmLich;
        private System.Windows.Forms.ListBox lstDuongLich;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.Button btnThoat;
    }
}

