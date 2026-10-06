namespace Combo_Class_ArrayList
{
    partial class frmCongTy
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
            this.btnThoat = new System.Windows.Forms.Button();
            this.lblThongTinChon = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.cboCongTy = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(197, 122);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(72, 32);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "&Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // lblThongTinChon
            // 
            this.lblThongTinChon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblThongTinChon.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongTinChon.Location = new System.Drawing.Point(37, 122);
            this.lblThongTinChon.Name = "lblThongTinChon";
            this.lblThongTinChon.Size = new System.Drawing.Size(144, 40);
            this.lblThongTinChon.TabIndex = 6;
            this.lblThongTinChon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label1
            // 
            this.Label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(37, 15);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(136, 24);
            this.Label1.TabIndex = 5;
            this.Label1.Text = "Chọn công ty";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboCongTy
            // 
            this.cboCongTy.BackColor = System.Drawing.SystemColors.Window;
            this.cboCongTy.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCongTy.Location = new System.Drawing.Point(37, 55);
            this.cboCongTy.Name = "cboCongTy";
            this.cboCongTy.Size = new System.Drawing.Size(144, 23);
            this.cboCongTy.TabIndex = 4;
            this.cboCongTy.SelectedIndexChanged += new System.EventHandler(this.cboCongTy_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Thông tin chi tiết";
            // 
            // frmCongTy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 183);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.lblThongTinChon);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.cboCongTy);
            this.Name = "frmCongTy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ComboBox Class & ArrayList";
            this.Load += new System.EventHandler(this.frmCongTy_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnThoat;
        internal System.Windows.Forms.Label lblThongTinChon;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.ComboBox cboCongTy;
        private System.Windows.Forms.Label label2;
    }
}

