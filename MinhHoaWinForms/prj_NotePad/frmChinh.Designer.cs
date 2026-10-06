namespace prj_NotePad
{
    partial class frmChinh
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
            this.MenuChinh = new System.Windows.Forms.MainMenu(this.components);
            this.mFile = new System.Windows.Forms.MenuItem();
            this.mFile_New = new System.Windows.Forms.MenuItem();
            this.mFile_Open = new System.Windows.Forms.MenuItem();
            this.MenuItem1 = new System.Windows.Forms.MenuItem();
            this.mFile_Save = new System.Windows.Forms.MenuItem();
            this.mFile_SaveAs = new System.Windows.Forms.MenuItem();
            this.MenuItem2 = new System.Windows.Forms.MenuItem();
            this.mFile_Exit = new System.Windows.Forms.MenuItem();
            this.mEdit = new System.Windows.Forms.MenuItem();
            this.mEdit_Undo = new System.Windows.Forms.MenuItem();
            this.MenuItem3 = new System.Windows.Forms.MenuItem();
            this.mEdit_Cut = new System.Windows.Forms.MenuItem();
            this.mEdit_Copy = new System.Windows.Forms.MenuItem();
            this.mEdit_Paste = new System.Windows.Forms.MenuItem();
            this.mEdit_Delete = new System.Windows.Forms.MenuItem();
            this.MenuItem4 = new System.Windows.Forms.MenuItem();
            this.mEdit_SelectAll = new System.Windows.Forms.MenuItem();
            this.mEdit_TimeDate = new System.Windows.Forms.MenuItem();
            this.mFormat = new System.Windows.Forms.MenuItem();
            this.mFormat_Font = new System.Windows.Forms.MenuItem();
            this.mFormat_ForeColor = new System.Windows.Forms.MenuItem();
            this.mFormat_BackColor = new System.Windows.Forms.MenuItem();
            this.mFormat_WordWrap = new System.Windows.Forms.MenuItem();
            this.HopFont = new System.Windows.Forms.FontDialog();
            this.HopMau = new System.Windows.Forms.ColorDialog();
            this.MoFile = new System.Windows.Forms.OpenFileDialog();
            this.LuuFile = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // MenuChinh
            // 
            this.MenuChinh.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mFile,
            this.mEdit,
            this.mFormat});
            // 
            // mFile
            // 
            this.mFile.Index = 0;
            this.mFile.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mFile_New,
            this.mFile_Open,
            this.MenuItem1,
            this.mFile_Save,
            this.mFile_SaveAs,
            this.MenuItem2,
            this.mFile_Exit});
            this.mFile.Text = "File";
            // 
            // mFile_New
            // 
            this.mFile_New.Index = 0;
            this.mFile_New.Text = "New";
            this.mFile_New.Click += new System.EventHandler(this.mFile_New_Click);
            // 
            // mFile_Open
            // 
            this.mFile_Open.Index = 1;
            this.mFile_Open.Text = "Open";
            this.mFile_Open.Click += new System.EventHandler(this.mFile_Open_Click);
            // 
            // MenuItem1
            // 
            this.MenuItem1.Index = 2;
            this.MenuItem1.Text = "-";
            // 
            // mFile_Save
            // 
            this.mFile_Save.Index = 3;
            this.mFile_Save.Text = "Save";
            this.mFile_Save.Click += new System.EventHandler(this.mFile_Save_Click);
            // 
            // mFile_SaveAs
            // 
            this.mFile_SaveAs.Index = 4;
            this.mFile_SaveAs.Text = "Save As";
            this.mFile_SaveAs.Click += new System.EventHandler(this.mFile_SaveAs_Click);
            // 
            // MenuItem2
            // 
            this.MenuItem2.Index = 5;
            this.MenuItem2.Text = "-";
            // 
            // mFile_Exit
            // 
            this.mFile_Exit.Index = 6;
            this.mFile_Exit.Text = "Exit";
            this.mFile_Exit.Click += new System.EventHandler(this.mFile_Exit_Click);
            // 
            // mEdit
            // 
            this.mEdit.Index = 1;
            this.mEdit.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mEdit_Undo,
            this.MenuItem3,
            this.mEdit_Cut,
            this.mEdit_Copy,
            this.mEdit_Paste,
            this.mEdit_Delete,
            this.MenuItem4,
            this.mEdit_SelectAll,
            this.mEdit_TimeDate});
            this.mEdit.Text = "Edit";
            this.mEdit.Click += new System.EventHandler(this.mEdit_Click);
            // 
            // mEdit_Undo
            // 
            this.mEdit_Undo.Index = 0;
            this.mEdit_Undo.Text = "Undo";
            this.mEdit_Undo.Click += new System.EventHandler(this.mEdit_Undo_Click);
            // 
            // MenuItem3
            // 
            this.MenuItem3.Index = 1;
            this.MenuItem3.Text = "-";
            // 
            // mEdit_Cut
            // 
            this.mEdit_Cut.Index = 2;
            this.mEdit_Cut.Text = "Cut";
            this.mEdit_Cut.Click += new System.EventHandler(this.mEdit_Cut_Click);
            // 
            // mEdit_Copy
            // 
            this.mEdit_Copy.Index = 3;
            this.mEdit_Copy.Text = "Copy";
            this.mEdit_Copy.Click += new System.EventHandler(this.mEdit_Copy_Click);
            // 
            // mEdit_Paste
            // 
            this.mEdit_Paste.Index = 4;
            this.mEdit_Paste.Text = "Paste";
            this.mEdit_Paste.Click += new System.EventHandler(this.mEdit_Paste_Click);
            // 
            // mEdit_Delete
            // 
            this.mEdit_Delete.Index = 5;
            this.mEdit_Delete.Text = "Delete All";
            this.mEdit_Delete.Click += new System.EventHandler(this.mEdit_Delete_Click);
            // 
            // MenuItem4
            // 
            this.MenuItem4.Index = 6;
            this.MenuItem4.Text = "-";
            // 
            // mEdit_SelectAll
            // 
            this.mEdit_SelectAll.Index = 7;
            this.mEdit_SelectAll.Text = "Select All";
            this.mEdit_SelectAll.Click += new System.EventHandler(this.mEdit_SelectAll_Click);
            // 
            // mEdit_TimeDate
            // 
            this.mEdit_TimeDate.Index = 8;
            this.mEdit_TimeDate.Text = "Time/Date";
            this.mEdit_TimeDate.Click += new System.EventHandler(this.mEdit_TimeDate_Click);
            // 
            // mFormat
            // 
            this.mFormat.Index = 2;
            this.mFormat.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mFormat_Font,
            this.mFormat_ForeColor,
            this.mFormat_BackColor,
            this.mFormat_WordWrap});
            this.mFormat.Text = "Format";
            // 
            // mFormat_Font
            // 
            this.mFormat_Font.Index = 0;
            this.mFormat_Font.Text = "Font";
            this.mFormat_Font.Click += new System.EventHandler(this.mFormat_Font_Click);
            // 
            // mFormat_ForeColor
            // 
            this.mFormat_ForeColor.Index = 1;
            this.mFormat_ForeColor.Text = "ForeColor";
            this.mFormat_ForeColor.Click += new System.EventHandler(this.mFormat_ForeColor_Click);
            // 
            // mFormat_BackColor
            // 
            this.mFormat_BackColor.Index = 2;
            this.mFormat_BackColor.Text = "BackColor";
            this.mFormat_BackColor.Click += new System.EventHandler(this.mFormat_BackColor_Click);
            // 
            // mFormat_WordWrap
            // 
            this.mFormat_WordWrap.Checked = true;
            this.mFormat_WordWrap.Index = 3;
            this.mFormat_WordWrap.Text = "Word Wrap";
            this.mFormat_WordWrap.Click += new System.EventHandler(this.mFormat_WordWrap_Click);
            // 
            // frmChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 266);
            this.IsMdiContainer = true;
            this.Menu = this.MenuChinh;
            this.Name = "frmChinh";
            this.Text = "Chương trình minh họa NotePad";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmChinh_Load);
            this.GotFocus += new System.EventHandler(this.frmChinh_GotFocus);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmChinh_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.MainMenu MenuChinh;
        internal System.Windows.Forms.MenuItem mFile;
        internal System.Windows.Forms.MenuItem mFile_New;
        internal System.Windows.Forms.MenuItem mFile_Open;
        internal System.Windows.Forms.MenuItem MenuItem1;
        internal System.Windows.Forms.MenuItem mFile_Save;
        internal System.Windows.Forms.MenuItem mFile_SaveAs;
        internal System.Windows.Forms.MenuItem MenuItem2;
        internal System.Windows.Forms.MenuItem mFile_Exit;
        internal System.Windows.Forms.MenuItem mEdit;
        internal System.Windows.Forms.MenuItem mEdit_Undo;
        internal System.Windows.Forms.MenuItem MenuItem3;
        internal System.Windows.Forms.MenuItem mEdit_Cut;
        internal System.Windows.Forms.MenuItem mEdit_Copy;
        internal System.Windows.Forms.MenuItem mEdit_Paste;
        internal System.Windows.Forms.MenuItem mEdit_Delete;
        internal System.Windows.Forms.MenuItem MenuItem4;
        internal System.Windows.Forms.MenuItem mEdit_SelectAll;
        internal System.Windows.Forms.MenuItem mEdit_TimeDate;
        internal System.Windows.Forms.MenuItem mFormat;
        internal System.Windows.Forms.MenuItem mFormat_Font;
        internal System.Windows.Forms.MenuItem mFormat_ForeColor;
        internal System.Windows.Forms.MenuItem mFormat_BackColor;
        internal System.Windows.Forms.MenuItem mFormat_WordWrap;
        internal System.Windows.Forms.FontDialog HopFont;
        internal System.Windows.Forms.ColorDialog HopMau;
        internal System.Windows.Forms.OpenFileDialog MoFile;
        internal System.Windows.Forms.SaveFileDialog LuuFile;
    }
}

