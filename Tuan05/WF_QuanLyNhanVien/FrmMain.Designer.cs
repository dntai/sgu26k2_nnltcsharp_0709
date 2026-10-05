namespace NNLTCSharp.WinForms
{
    partial class FrmMain
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
            menuStrip1 = new MenuStrip();
            hệThốngToolStripMenuItem = new ToolStripMenuItem();
            nạpDữLiệuToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            thoátToolStripMenuItem = new ToolStripMenuItem();
            nhânViênToolStripMenuItem = new ToolStripMenuItem();
            nhậpToolStripMenuItem = new ToolStripMenuItem();
            danhSáchToolStripMenuItem = new ToolStripMenuItem();
            cấuHìnhToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { hệThốngToolStripMenuItem, nhânViênToolStripMenuItem, cấuHìnhToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(8, 3, 0, 3);
            menuStrip1.Size = new Size(902, 30);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            hệThốngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nạpDữLiệuToolStripMenuItem, toolStripSeparator1, thoátToolStripMenuItem });
            hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            hệThốngToolStripMenuItem.Size = new Size(85, 24);
            hệThốngToolStripMenuItem.Text = "&Hệ thống";
            // 
            // nạpDữLiệuToolStripMenuItem
            // 
            nạpDữLiệuToolStripMenuItem.Name = "nạpDữLiệuToolStripMenuItem";
            nạpDữLiệuToolStripMenuItem.Size = new Size(170, 26);
            nạpDữLiệuToolStripMenuItem.Text = "&Nạp dữ liệu";
            nạpDữLiệuToolStripMenuItem.Click += mnuNapDuLieu_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(167, 6);
            // 
            // thoátToolStripMenuItem
            // 
            thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            thoátToolStripMenuItem.Size = new Size(170, 26);
            thoátToolStripMenuItem.Text = "&Thoát";
            // 
            // nhânViênToolStripMenuItem
            // 
            nhânViênToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nhậpToolStripMenuItem, danhSáchToolStripMenuItem });
            nhânViênToolStripMenuItem.Name = "nhânViênToolStripMenuItem";
            nhânViênToolStripMenuItem.Size = new Size(89, 24);
            nhânViênToolStripMenuItem.Text = "&Nhân viên";
            // 
            // nhậpToolStripMenuItem
            // 
            nhậpToolStripMenuItem.Name = "nhậpToolStripMenuItem";
            nhậpToolStripMenuItem.Size = new Size(160, 26);
            nhậpToolStripMenuItem.Text = "&Nhập ";
            nhậpToolStripMenuItem.Click += mnuNhap_Click;
            // 
            // danhSáchToolStripMenuItem
            // 
            danhSáchToolStripMenuItem.Name = "danhSáchToolStripMenuItem";
            danhSáchToolStripMenuItem.Size = new Size(160, 26);
            danhSáchToolStripMenuItem.Text = "&Danh sách";
            danhSáchToolStripMenuItem.Click += mnuDanhSach_Click;
            // 
            // cấuHìnhToolStripMenuItem
            // 
            cấuHìnhToolStripMenuItem.Name = "cấuHìnhToolStripMenuItem";
            cấuHìnhToolStripMenuItem.Size = new Size(80, 24);
            cấuHìnhToolStripMenuItem.Text = "&Cấu hình";
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = WF_QuanLyNhanVien.Properties.Resources.BKG;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(902, 461);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 5, 4, 5);
            Name = "FrmMain";
            Text = "Quản lý nhân viên";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nạpDữLiệuToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhậpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhSáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cấuHìnhToolStripMenuItem;
    }
}

