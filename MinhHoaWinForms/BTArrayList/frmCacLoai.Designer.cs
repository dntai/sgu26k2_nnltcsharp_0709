namespace BTArrayList
{
    partial class frmCacLoai
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
            this.lblLoaiThu = new System.Windows.Forms.Label();
            this.txtLoai = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLoaiThu
            // 
            this.lblLoaiThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoaiThu.Location = new System.Drawing.Point(96, 31);
            this.lblLoaiThu.Name = "lblLoaiThu";
            this.lblLoaiThu.Size = new System.Drawing.Size(100, 23);
            this.lblLoaiThu.TabIndex = 0;
            this.lblLoaiThu.Text = "Loại thứ 1";
            this.lblLoaiThu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtLoai
            // 
            this.txtLoai.Location = new System.Drawing.Point(89, 66);
            this.txtLoai.Name = "txtLoai";
            this.txtLoai.Size = new System.Drawing.Size(126, 20);
            this.txtLoai.TabIndex = 1;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(109, 115);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "Đồng Ý";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // frmCacLoai
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 165);
            this.ControlBox = false;
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtLoai);
            this.Controls.Add(this.lblLoaiThu);
            this.Name = "frmCacLoai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập phần tử của mảng";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLoaiThu;
        private System.Windows.Forms.TextBox txtLoai;
        private System.Windows.Forms.Button btnOK;
    }
}