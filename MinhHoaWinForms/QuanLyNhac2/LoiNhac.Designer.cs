namespace QuanLyNhac2
{
    partial class LoiNhac
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
            this.txtLoiNhac = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtLoiNhac
            // 
            this.txtLoiNhac.Location = new System.Drawing.Point(2, 3);
            this.txtLoiNhac.Multiline = true;
            this.txtLoiNhac.Name = "txtLoiNhac";
            this.txtLoiNhac.Size = new System.Drawing.Size(400, 296);
            this.txtLoiNhac.TabIndex = 0;
            // 
            // LoiNhac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 309);
            this.Controls.Add(this.txtLoiNhac);
            this.Name = "LoiNhac";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoiNhac";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.LoiNhac_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLoiNhac;
    }
}