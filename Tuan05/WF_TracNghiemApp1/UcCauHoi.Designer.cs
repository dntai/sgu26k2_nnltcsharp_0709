namespace Buoi8_FrmPhieuKhaoSat
{
    partial class UcCauHoi
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbxTraLoi = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblNoiDung = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxTraLoi
            // 
            this.gbxTraLoi.Location = new System.Drawing.Point(3, 131);
            this.gbxTraLoi.Name = "gbxTraLoi";
            this.gbxTraLoi.Size = new System.Drawing.Size(513, 234);
            this.gbxTraLoi.TabIndex = 3;
            this.gbxTraLoi.TabStop = false;
            this.gbxTraLoi.Text = "Câu trả lời";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblNoiDung);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(513, 122);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nội dung câu hỏi:";
            // 
            // lblNoiDung
            // 
            this.lblNoiDung.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblNoiDung.Location = new System.Drawing.Point(6, 16);
            this.lblNoiDung.Name = "lblNoiDung";
            this.lblNoiDung.Size = new System.Drawing.Size(501, 95);
            this.lblNoiDung.TabIndex = 0;
            this.lblNoiDung.Text = "lblNoiDung";
            // 
            // UcCauHoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbxTraLoi);
            this.Controls.Add(this.groupBox1);
            this.Name = "UcCauHoi";
            this.Size = new System.Drawing.Size(527, 374);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxTraLoi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblNoiDung;
    }
}
