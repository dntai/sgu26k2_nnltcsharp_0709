namespace AmDuong
{
    partial class frmDLichALich
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDLichALich));
            this.ButtCLOSE = new System.Windows.Forms.Button();
            this.ButtVIEW = new System.Windows.Forms.Button();
            this.LblNamAL = new System.Windows.Forms.Label();
            this.TxtNamDL = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtCLOSE
            // 
            this.ButtCLOSE.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtCLOSE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtCLOSE.Image = ((System.Drawing.Image)(resources.GetObject("ButtCLOSE.Image")));
            this.ButtCLOSE.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtCLOSE.Location = new System.Drawing.Point(279, 214);
            this.ButtCLOSE.Name = "ButtCLOSE";
            this.ButtCLOSE.Size = new System.Drawing.Size(64, 23);
            this.ButtCLOSE.TabIndex = 13;
            this.ButtCLOSE.Text = "&Close";
            this.ButtCLOSE.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtCLOSE.Click += new System.EventHandler(this.ButtCLOSE_Click);
            // 
            // ButtVIEW
            // 
            this.ButtVIEW.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtVIEW.Image = ((System.Drawing.Image)(resources.GetObject("ButtVIEW.Image")));
            this.ButtVIEW.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtVIEW.Location = new System.Drawing.Point(55, 214);
            this.ButtVIEW.Name = "ButtVIEW";
            this.ButtVIEW.Size = new System.Drawing.Size(64, 23);
            this.ButtVIEW.TabIndex = 12;
            this.ButtVIEW.Text = "&View";
            this.ButtVIEW.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtVIEW.Click += new System.EventHandler(this.ButtVIEW_Click);
            // 
            // LblNamAL
            // 
            this.LblNamAL.BackColor = System.Drawing.SystemColors.Control;
            this.LblNamAL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblNamAL.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNamAL.Location = new System.Drawing.Point(205, 143);
            this.LblNamAL.Name = "LblNamAL";
            this.LblNamAL.Size = new System.Drawing.Size(104, 23);
            this.LblNamAL.TabIndex = 11;
            this.LblNamAL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtNamDL
            // 
            this.TxtNamDL.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNamDL.Location = new System.Drawing.Point(215, 94);
            this.TxtNamDL.MaxLength = 4;
            this.TxtNamDL.Name = "TxtNamDL";
            this.TxtNamDL.Size = new System.Drawing.Size(80, 21);
            this.TxtNamDL.TabIndex = 10;
            this.TxtNamDL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtNamDL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNamDL_KeyPress);
            // 
            // Label3
            // 
            this.Label3.Font = new System.Drawing.Font("VNI-Times", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Image = ((System.Drawing.Image)(resources.GetObject("Label3.Image")));
            this.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Label3.Location = new System.Drawing.Point(47, 142);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(120, 23);
            this.Label3.TabIndex = 9;
            this.Label3.Text = "Naêm AÂm lòch";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label2
            // 
            this.Label2.Font = new System.Drawing.Font("VNI-Times", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Image = ((System.Drawing.Image)(resources.GetObject("Label2.Image")));
            this.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Label2.Location = new System.Drawing.Point(47, 94);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(120, 23);
            this.Label2.TabIndex = 8;
            this.Label2.Text = "Naêm Döông lòch";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label1
            // 
            this.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Label1.Font = new System.Drawing.Font("VNI-Times", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(23, 30);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(360, 24);
            this.Label1.TabIndex = 7;
            this.Label1.Text = "Chöông trình ñoåi naêm Döông lòch ra AÂm lòch";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmDLichALich
            // 
            this.AcceptButton = this.ButtVIEW;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ButtCLOSE;
            this.ClientSize = new System.Drawing.Size(401, 266);
            this.Controls.Add(this.ButtCLOSE);
            this.Controls.Add(this.ButtVIEW);
            this.Controls.Add(this.LblNamAL);
            this.Controls.Add(this.TxtNamDL);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Name = "frmDLichALich";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lunar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button ButtCLOSE;
        internal System.Windows.Forms.Button ButtVIEW;
        internal System.Windows.Forms.Label LblNamAL;
        internal System.Windows.Forms.TextBox TxtNamDL;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
    }
}

