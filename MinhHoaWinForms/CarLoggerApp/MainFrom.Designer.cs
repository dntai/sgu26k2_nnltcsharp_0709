namespace CarLoggerApp
{
    
    partial class MainFrom
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
            this.menuChinh = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFile_Clear = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFile_Make = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFile_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFile_Save = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFile_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.carDataGrid = new System.Windows.Forms.DataGridView();
            this.mySaveFile = new System.Windows.Forms.SaveFileDialog();
            this.myOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.menuChinh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // menuChinh
            // 
            this.menuChinh.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile});
            this.menuChinh.Location = new System.Drawing.Point(0, 0);
            this.menuChinh.Name = "menuChinh";
            this.menuChinh.Size = new System.Drawing.Size(545, 24);
            this.menuChinh.TabIndex = 0;
            this.menuChinh.Text = "menuChinh";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile_Clear,
            this.mnuFile_Make,
            this.mnuFile_Open,
            this.mnuFile_Save,
            this.mnuFile_Exit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(35, 20);
            this.mnuFile.Text = "&File";
            // 
            // mnuFile_Clear
            // 
            this.mnuFile_Clear.Name = "mnuFile_Clear";
            this.mnuFile_Clear.Size = new System.Drawing.Size(152, 22);
            this.mnuFile_Clear.Text = "&Clear All Cars";
            this.mnuFile_Clear.Click += new System.EventHandler(this.mnuFile_Clear_Click);
            // 
            // mnuFile_Make
            // 
            this.mnuFile_Make.Name = "mnuFile_Make";
            this.mnuFile_Make.Size = new System.Drawing.Size(152, 22);
            this.mnuFile_Make.Text = "&Make New Car";
            this.mnuFile_Make.Click += new System.EventHandler(this.mnuFile_Make_Click);
            // 
            // mnuFile_Open
            // 
            this.mnuFile_Open.Name = "mnuFile_Open";
            this.mnuFile_Open.Size = new System.Drawing.Size(152, 22);
            this.mnuFile_Open.Text = "&Open Car File";
            this.mnuFile_Open.Click += new System.EventHandler(this.mnuFile_Open_Click);
            // 
            // mnuFile_Save
            // 
            this.mnuFile_Save.Name = "mnuFile_Save";
            this.mnuFile_Save.Size = new System.Drawing.Size(152, 22);
            this.mnuFile_Save.Text = "&Save Car File";
            this.mnuFile_Save.Click += new System.EventHandler(this.mnuFile_Save_Click);
            // 
            // mnuFile_Exit
            // 
            this.mnuFile_Exit.Name = "mnuFile_Exit";
            this.mnuFile_Exit.Size = new System.Drawing.Size(152, 22);
            this.mnuFile_Exit.Text = "&Exit";
            this.mnuFile_Exit.Click += new System.EventHandler(this.mnuFile_Exit_Click);
            // 
            // carDataGrid
            // 
            this.carDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.carDataGrid.Location = new System.Drawing.Point(25, 52);
            this.carDataGrid.Name = "carDataGrid";
            this.carDataGrid.ReadOnly = true;
            this.carDataGrid.Size = new System.Drawing.Size(505, 198);
            this.carDataGrid.TabIndex = 1;
            // 
            // mySaveFile
            // 
            this.mySaveFile.FileName = "carDoc";
            this.mySaveFile.Filter = "car Files(*.car)|*.car|All Files(*.*)|*.*";
            this.mySaveFile.InitialDirectory = ".";
            this.mySaveFile.RestoreDirectory = true;
            // 
            // myOpenFile
            // 
            this.myOpenFile.Filter = "car Files(*.car)|*.car|All Files(*.*)|*.*";
            this.myOpenFile.InitialDirectory = ".";
            this.myOpenFile.RestoreDirectory = true;
            // 
            // MainFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 297);
            this.Controls.Add(this.carDataGrid);
            this.Controls.Add(this.menuChinh);
            this.MainMenuStrip = this.menuChinh;
            this.Name = "MainFrom";
            this.Text = "Car Logger Application";
            this.menuChinh.ResumeLayout(false);
            this.menuChinh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuChinh;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuFile_Clear;
        private System.Windows.Forms.ToolStripMenuItem mnuFile_Make;
        private System.Windows.Forms.ToolStripMenuItem mnuFile_Open;
        private System.Windows.Forms.ToolStripMenuItem mnuFile_Save;
        private System.Windows.Forms.ToolStripMenuItem mnuFile_Exit;
        private System.Windows.Forms.DataGridView carDataGrid;
        private System.Windows.Forms.SaveFileDialog mySaveFile;
        private System.Windows.Forms.OpenFileDialog myOpenFile;
        
    }
}

