namespace HoSoNhanVien_Class
{
    partial class frmHienMaSo
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
            this.lblMaSo = new System.Windows.Forms.Label();
            this.DongHo1 = new System.Windows.Forms.Timer(this.components);
            this.DongHo2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblMaSo
            // 
            this.lblMaSo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMaSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaSo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblMaSo.Location = new System.Drawing.Point(45, 36);
            this.lblMaSo.Name = "lblMaSo";
            this.lblMaSo.Size = new System.Drawing.Size(348, 51);
            this.lblMaSo.TabIndex = 0;
            this.lblMaSo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DongHo1
            // 
            this.DongHo1.Enabled = true;
            this.DongHo1.Interval = 500;
            this.DongHo1.Tick += new System.EventHandler(this.DongHo1_Tick);
            // 
            // DongHo2
            // 
            this.DongHo2.Interval = 2000;
            this.DongHo2.Tick += new System.EventHandler(this.DongHo2_Tick);
            // 
            // frmHienMaSo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(449, 145);
            this.ControlBox = false;
            this.Controls.Add(this.lblMaSo);
            this.Name = "frmHienMaSo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mã số nhân viên Quản trị";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMaSo;
        private System.Windows.Forms.Timer DongHo1;
        private System.Windows.Forms.Timer DongHo2;
    }
}