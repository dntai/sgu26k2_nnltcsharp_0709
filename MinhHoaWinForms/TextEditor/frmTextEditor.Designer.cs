namespace TextEditor
{
    partial class frmTextEditor
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
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnOK = new System.Windows.Forms.Button();
            this.VanBan = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnCancel
            // 
            this.BtnCancel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.Location = new System.Drawing.Point(242, 253);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(72, 24);
            this.BtnCancel.TabIndex = 5;
            this.BtnCancel.Text = "&Kết thúc";
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnOK
            // 
            this.BtnOK.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOK.Location = new System.Drawing.Point(162, 253);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(56, 24);
            this.BtnOK.TabIndex = 4;
            this.BtnOK.Text = "&Ghi";
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // VanBan
            // 
            this.VanBan.AllowDrop = true;
            this.VanBan.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VanBan.Location = new System.Drawing.Point(18, 13);
            this.VanBan.Multiline = true;
            this.VanBan.Name = "VanBan";
            this.VanBan.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.VanBan.Size = new System.Drawing.Size(312, 224);
            this.VanBan.TabIndex = 3;
            // 
            // frmTextEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 290);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.VanBan);
            this.Name = "frmTextEditor";
            this.Text = "Đọc và ghi tập tin";
            this.Load += new System.EventHandler(this.frmTextEditor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button BtnCancel;
        internal System.Windows.Forms.Button BtnOK;
        internal System.Windows.Forms.TextBox VanBan;
    }
}

