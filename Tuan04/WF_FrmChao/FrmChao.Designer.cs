namespace NNLTCS.WinForms
{
    partial class FrmChao
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
            this.txtChao = new System.Windows.Forms.TextBox();
            this.lblChao = new System.Windows.Forms.Label();
            this.btnChao = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ tên của bạn:";
            // 
            // txtChao
            // 
            this.txtChao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtChao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChao.ForeColor = System.Drawing.Color.Blue;
            this.txtChao.Location = new System.Drawing.Point(102, 6);
            this.txtChao.Name = "txtChao";
            this.txtChao.Size = new System.Drawing.Size(177, 20);
            this.txtChao.TabIndex = 1;
            this.txtChao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblChao
            // 
            this.lblChao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblChao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChao.ForeColor = System.Drawing.Color.Blue;
            this.lblChao.Location = new System.Drawing.Point(102, 40);
            this.lblChao.Name = "lblChao";
            this.lblChao.Size = new System.Drawing.Size(177, 23);
            this.lblChao.TabIndex = 2;
            this.lblChao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnChao
            // 
            this.btnChao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnChao.Location = new System.Drawing.Point(105, 66);
            this.btnChao.Name = "btnChao";
            this.btnChao.Size = new System.Drawing.Size(75, 23);
            this.btnChao.TabIndex = 3;
            this.btnChao.Text = "Chào";
            this.btnChao.UseVisualStyleBackColor = true;
            this.btnChao.Click += new System.EventHandler(this.btnChao_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThoat.Location = new System.Drawing.Point(186, 66);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // FrmChao
            // 
            this.AcceptButton = this.btnChao;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnThoat;
            this.ClientSize = new System.Drawing.Size(296, 99);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnChao);
            this.Controls.Add(this.lblChao);
            this.Controls.Add(this.txtChao);
            this.Controls.Add(this.label1);
            this.Name = "FrmChao";
            this.Text = "Xin chào";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmChao_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtChao;
        private System.Windows.Forms.Label lblChao;
        private System.Windows.Forms.Button btnChao;
        private System.Windows.Forms.Button btnThoat;
    }
}

