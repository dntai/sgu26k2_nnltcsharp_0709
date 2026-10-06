namespace DiemThi_Class_File
{
    partial class frmKhoiDong
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.ThanhChay = new System.Windows.Forms.ProgressBar();
            this.DongHo = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã số: 07D0040048";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ThanhChay
            // 
            this.ThanhChay.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ThanhChay.Location = new System.Drawing.Point(0, 112);
            this.ThanhChay.Name = "ThanhChay";
            this.ThanhChay.Size = new System.Drawing.Size(356, 23);
            this.ThanhChay.Step = 5;
            this.ThanhChay.TabIndex = 1;
            // 
            // DongHo
            // 
            this.DongHo.Enabled = true;
            this.DongHo.Interval = 250;
            this.DongHo.Tick += new System.EventHandler(this.DongHo_Tick);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(294, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Họ và tên: Lê Minh Công";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmKhoiDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 135);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ThanhChay);
            this.Controls.Add(this.label1);
            this.Name = "frmKhoiDong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sinh viên dự thi";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar ThanhChay;
        private System.Windows.Forms.Timer DongHo;
        private System.Windows.Forms.Label label2;
    }
}