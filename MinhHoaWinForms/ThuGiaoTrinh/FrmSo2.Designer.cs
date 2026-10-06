namespace ThuGiaoTrinh
{
    partial class FrmSo2
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
            this.lstA = new System.Windows.Forms.ListBox();
            this.lstValMem = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboTraiCay = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lstA
            // 
            this.lstA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstA.FormattingEnabled = true;
            this.lstA.ItemHeight = 16;
            this.lstA.Location = new System.Drawing.Point(33, 56);
            this.lstA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstA.Name = "lstA";
            this.lstA.Size = new System.Drawing.Size(200, 116);
            this.lstA.TabIndex = 2;
            // 
            // lstValMem
            // 
            this.lstValMem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstValMem.FormattingEnabled = true;
            this.lstValMem.ItemHeight = 16;
            this.lstValMem.Location = new System.Drawing.Point(269, 56);
            this.lstValMem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstValMem.Name = "lstValMem";
            this.lstValMem.Size = new System.Drawing.Size(99, 116);
            this.lstValMem.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("VNI-Times", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Khoâng thay ñoåi giaù trò ValueMember";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("VNI-Times", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(267, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "ValueMember=X";
            // 
            // cboTraiCay
            // 
            this.cboTraiCay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTraiCay.FormattingEnabled = true;
            this.cboTraiCay.Items.AddRange(new object[] {
            "Buoi",
            "Thom",
            "Mang cau",
            "Dua"});
            this.cboTraiCay.Location = new System.Drawing.Point(269, 189);
            this.cboTraiCay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboTraiCay.Name = "cboTraiCay";
            this.cboTraiCay.Size = new System.Drawing.Size(98, 24);
            this.cboTraiCay.TabIndex = 6;
            this.cboTraiCay.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboTraiCay_KeyDown);
            // 
            // FrmSo2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 255);
            this.Controls.Add(this.cboTraiCay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstValMem);
            this.Controls.Add(this.lstA);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmSo2";
            this.Text = "List Box";
            this.Load += new System.EventHandler(this.FrmSo2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstA;
        private System.Windows.Forms.ListBox lstValMem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboTraiCay;


    }
}