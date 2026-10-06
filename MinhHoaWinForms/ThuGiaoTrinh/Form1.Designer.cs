namespace ThuGiaoTrinh
{
    partial class FrmSo1
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
            this.MenuChinh = new System.Windows.Forms.MenuStrip();
            this.formToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moForm2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuChinh.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuChinh
            // 
            this.MenuChinh.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formToolStripMenuItem});
            this.MenuChinh.Location = new System.Drawing.Point(0, 0);
            this.MenuChinh.Name = "MenuChinh";
            this.MenuChinh.Size = new System.Drawing.Size(297, 24);
            this.MenuChinh.TabIndex = 2;
            this.MenuChinh.Text = "menuStrip1";
            // 
            // formToolStripMenuItem
            // 
            this.formToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.moForm2ToolStripMenuItem});
            this.formToolStripMenuItem.Name = "formToolStripMenuItem";
            this.formToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.formToolStripMenuItem.Text = "Form";
            // 
            // moForm2ToolStripMenuItem
            // 
            this.moForm2ToolStripMenuItem.Name = "moForm2ToolStripMenuItem";
            this.moForm2ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.moForm2ToolStripMenuItem.Text = "Mo Form 2";
            this.moForm2ToolStripMenuItem.Click += new System.EventHandler(this.moForm2ToolStripMenuItem_Click);
            // 
            // FrmSo1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 268);
            this.Controls.Add(this.MenuChinh);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MenuChinh;
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "FrmSo1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MenuChinh.ResumeLayout(false);
            this.MenuChinh.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuChinh;
        private System.Windows.Forms.ToolStripMenuItem formToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moForm2ToolStripMenuItem;
    }
}

