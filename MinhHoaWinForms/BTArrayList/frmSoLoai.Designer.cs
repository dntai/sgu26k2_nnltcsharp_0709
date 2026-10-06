namespace BTArrayList
{
    partial class frmSoLoai
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
            this.txtSoLoai = new System.Windows.Forms.TextBox();
            this.btnDongY = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cho biết số loại cần tạo";
            // 
            // txtSoLoai
            // 
            this.txtSoLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLoai.Location = new System.Drawing.Point(47, 48);
            this.txtSoLoai.Name = "txtSoLoai";
            this.txtSoLoai.Size = new System.Drawing.Size(142, 23);
            this.txtSoLoai.TabIndex = 1;
            this.txtSoLoai.Text = "1";
            this.txtSoLoai.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSoLoai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoLoai_KeyPress);
            // 
            // btnDongY
            // 
            this.btnDongY.Location = new System.Drawing.Point(83, 99);
            this.btnDongY.Name = "btnDongY";
            this.btnDongY.Size = new System.Drawing.Size(75, 23);
            this.btnDongY.TabIndex = 2;
            this.btnDongY.Text = "Đồng ý";
            this.btnDongY.UseVisualStyleBackColor = true;
            this.btnDongY.Click += new System.EventHandler(this.btnDongY_Click);
            // 
            // frmSoLoai
            // 
            this.AcceptButton = this.btnDongY;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 152);
            this.ControlBox = false;
            this.Controls.Add(this.btnDongY);
            this.Controls.Add(this.txtSoLoai);
            this.Controls.Add(this.label1);
            this.Name = "frmSoLoai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xác định số phần tử";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSoLoai;
        private System.Windows.Forms.Button btnDongY;
    }
}