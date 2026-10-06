namespace ThuGiaoTrinh
{
    partial class frmProgressBar
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
            this.ThanhChay = new System.Windows.Forms.ProgressBar();
            this.DongHo = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ThanhChay
            // 
            this.ThanhChay.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ThanhChay.Location = new System.Drawing.Point(0, 124);
            this.ThanhChay.Name = "ThanhChay";
            this.ThanhChay.Size = new System.Drawing.Size(572, 29);
            this.ThanhChay.TabIndex = 0;
            // 
            // DongHo
            // 
            this.DongHo.Enabled = true;
            this.DongHo.Interval = 250;
            this.DongHo.Tick += new System.EventHandler(this.DongHo_Tick);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("VNI-Times", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "Laäp trình cô baûn treân Widows vôùi C#";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmProgressBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 153);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ThanhChay);
            this.Name = "frmProgressBar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProgressBar";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar ThanhChay;
        private System.Windows.Forms.Timer DongHo;
        private System.Windows.Forms.Label label1;
    }
}