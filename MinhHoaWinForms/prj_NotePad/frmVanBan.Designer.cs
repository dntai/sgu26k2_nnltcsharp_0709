namespace prj_NotePad
{
    partial class frmVanBan
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
            this.RtxtVanBan = new System.Windows.Forms.RichTextBox();
            this.LuuFile = new System.Windows.Forms.SaveFileDialog();
            this.mnuTat = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuTat_Cut = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTat_Copy = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuTat_Paste = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTat_Undo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuTat.SuspendLayout();
            this.SuspendLayout();
            // 
            // RtxtVanBan
            // 
            this.RtxtVanBan.CausesValidation = false;
            this.RtxtVanBan.ContextMenuStrip = this.mnuTat;
            this.RtxtVanBan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RtxtVanBan.Location = new System.Drawing.Point(0, 0);
            this.RtxtVanBan.Name = "RtxtVanBan";
            this.RtxtVanBan.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.RtxtVanBan.Size = new System.Drawing.Size(312, 274);
            this.RtxtVanBan.TabIndex = 1;
            this.RtxtVanBan.Text = "";
            // 
            // LuuFile
            // 
            this.LuuFile.DefaultExt = "*.txt";
            this.LuuFile.Filter = "Text File (*.txt)|*.txt|All File|*.*";
            // 
            // mnuTat
            // 
            this.mnuTat.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTat_Undo,
            this.toolStripMenuItem2,
            this.mnuTat_Cut,
            this.mnuTat_Copy,
            this.toolStripMenuItem1,
            this.mnuTat_Paste});
            this.mnuTat.Name = "mnuTat";
            this.mnuTat.Size = new System.Drawing.Size(153, 126);
            // 
            // mnuTat_Cut
            // 
            this.mnuTat_Cut.Name = "mnuTat_Cut";
            this.mnuTat_Cut.Size = new System.Drawing.Size(152, 22);
            this.mnuTat_Cut.Text = "&Cut";
            this.mnuTat_Cut.Click += new System.EventHandler(this.mnuTat_Cut_Click);
            // 
            // mnuTat_Copy
            // 
            this.mnuTat_Copy.Name = "mnuTat_Copy";
            this.mnuTat_Copy.Size = new System.Drawing.Size(152, 22);
            this.mnuTat_Copy.Text = "C&opy";
            this.mnuTat_Copy.Click += new System.EventHandler(this.mnuTat_Copy_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
            // 
            // mnuTat_Paste
            // 
            this.mnuTat_Paste.Name = "mnuTat_Paste";
            this.mnuTat_Paste.Size = new System.Drawing.Size(152, 22);
            this.mnuTat_Paste.Text = "&Paste";
            this.mnuTat_Paste.Click += new System.EventHandler(this.mnuTat_Paste_Click);
            // 
            // mnuTat_Undo
            // 
            this.mnuTat_Undo.Name = "mnuTat_Undo";
            this.mnuTat_Undo.Size = new System.Drawing.Size(152, 22);
            this.mnuTat_Undo.Text = "&Undo";
            this.mnuTat_Undo.Click += new System.EventHandler(this.mnuTat_Undo_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(149, 6);
            // 
            // frmVanBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 274);
            this.Controls.Add(this.RtxtVanBan);
            this.Name = "frmVanBan";
            this.Text = "frmVanBan";
            this.Load += new System.EventHandler(this.frmVanBan_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmVanBan_FormClosed);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmVanBan_FormClosing);
            this.mnuTat.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.RichTextBox RtxtVanBan;
        internal System.Windows.Forms.SaveFileDialog LuuFile;
        private System.Windows.Forms.ContextMenuStrip mnuTat;
        private System.Windows.Forms.ToolStripMenuItem mnuTat_Cut;
        private System.Windows.Forms.ToolStripMenuItem mnuTat_Copy;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuTat_Paste;
        private System.Windows.Forms.ToolStripMenuItem mnuTat_Undo;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
    }
}