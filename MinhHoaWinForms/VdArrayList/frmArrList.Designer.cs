namespace VdArrayList
{
    partial class frmArrList
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
            this.btnThiHanh = new System.Windows.Forms.Button();
            this.lblHienThi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnThiHanh
            // 
            this.btnThiHanh.Location = new System.Drawing.Point(107, 191);
            this.btnThiHanh.Name = "btnThiHanh";
            this.btnThiHanh.Size = new System.Drawing.Size(75, 23);
            this.btnThiHanh.TabIndex = 0;
            this.btnThiHanh.Text = "Thi hanh";
            this.btnThiHanh.UseVisualStyleBackColor = true;
            this.btnThiHanh.Click += new System.EventHandler(this.btnThiHanh_Click);
            // 
            // lblHienThi
            // 
            this.lblHienThi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblHienThi.Location = new System.Drawing.Point(31, 36);
            this.lblHienThi.Name = "lblHienThi";
            this.lblHienThi.Size = new System.Drawing.Size(230, 125);
            this.lblHienThi.TabIndex = 1;
            // 
            // frmArrList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.lblHienThi);
            this.Controls.Add(this.btnThiHanh);
            this.Name = "frmArrList";
            this.Text = "Vi du ArrayList";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnThiHanh;
        private System.Windows.Forms.Label lblHienThi;
    }
}

