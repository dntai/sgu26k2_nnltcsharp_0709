namespace Color_Style
{
    partial class frmColorStyle
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
            this.lblBlue = new System.Windows.Forms.Label();
            this.lblGreen = new System.Windows.Forms.Label();
            this.lblRed = new System.Windows.Forms.Label();
            this.scrBlue = new System.Windows.Forms.HScrollBar();
            this.scrGreen = new System.Windows.Forms.HScrollBar();
            this.scrRed = new System.Windows.Forms.HScrollBar();
            this.grpChon = new System.Windows.Forms.GroupBox();
            this.radNen = new System.Windows.Forms.RadioButton();
            this.radChu = new System.Windows.Forms.RadioButton();
            this.radDam = new System.Windows.Forms.RadioButton();
            this.radNghieng = new System.Windows.Forms.RadioButton();
            this.radThuong = new System.Windows.Forms.RadioButton();
            this.txtVanBan = new System.Windows.Forms.TextBox();
            this.lblThongBao = new System.Windows.Forms.Label();
            this.mnuChuongTrinh = new System.Windows.Forms.MenuStrip();
            this.mnuMessageBox = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMessageBox_OK = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMessageBox_OKCancel = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMessageBox_YesNo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMessageBox_YesNoCancel = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMessageBox_RetryCancel = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMessageBox_AbortRetryIgnore = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFontStyle = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFontStyle_Bold = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFontStyle_ITalic = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFontStyle_Regular = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFont = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFont_Font = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFont_ForeColor = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFont_BackColor = new System.Windows.Forms.ToolStripMenuItem();
            this.HopFont = new System.Windows.Forms.FontDialog();
            this.HopMau = new System.Windows.Forms.ColorDialog();
            this.mnuSystem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSystem_Game = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSystem_EXit = new System.Windows.Forms.ToolStripMenuItem();
            this.grpChon.SuspendLayout();
            this.mnuChuongTrinh.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBlue
            // 
            this.lblBlue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlue.ForeColor = System.Drawing.Color.Blue;
            this.lblBlue.Location = new System.Drawing.Point(184, 277);
            this.lblBlue.Name = "lblBlue";
            this.lblBlue.Size = new System.Drawing.Size(92, 22);
            this.lblBlue.TabIndex = 13;
            this.lblBlue.Text = "Blue = 0";
            // 
            // lblGreen
            // 
            this.lblGreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblGreen.Location = new System.Drawing.Point(184, 242);
            this.lblGreen.Name = "lblGreen";
            this.lblGreen.Size = new System.Drawing.Size(92, 22);
            this.lblGreen.TabIndex = 12;
            this.lblGreen.Text = "Green = 0";
            // 
            // lblRed
            // 
            this.lblRed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRed.ForeColor = System.Drawing.Color.Red;
            this.lblRed.Location = new System.Drawing.Point(184, 204);
            this.lblRed.Name = "lblRed";
            this.lblRed.Size = new System.Drawing.Size(92, 22);
            this.lblRed.TabIndex = 11;
            this.lblRed.Text = "Red = 0";
            // 
            // scrBlue
            // 
            this.scrBlue.Location = new System.Drawing.Point(289, 277);
            this.scrBlue.Maximum = 255;
            this.scrBlue.Name = "scrBlue";
            this.scrBlue.Size = new System.Drawing.Size(233, 23);
            this.scrBlue.TabIndex = 10;
            this.scrBlue.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scrBlue_Scroll);
            // 
            // scrGreen
            // 
            this.scrGreen.Location = new System.Drawing.Point(289, 242);
            this.scrGreen.Maximum = 255;
            this.scrGreen.Name = "scrGreen";
            this.scrGreen.Size = new System.Drawing.Size(233, 23);
            this.scrGreen.TabIndex = 9;
            this.scrGreen.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scrGreen_Scroll);
            // 
            // scrRed
            // 
            this.scrRed.Location = new System.Drawing.Point(288, 204);
            this.scrRed.Maximum = 255;
            this.scrRed.Name = "scrRed";
            this.scrRed.Size = new System.Drawing.Size(233, 23);
            this.scrRed.TabIndex = 8;
            this.scrRed.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scrRed_Scroll);
            // 
            // grpChon
            // 
            this.grpChon.Controls.Add(this.radNen);
            this.grpChon.Controls.Add(this.radChu);
            this.grpChon.Location = new System.Drawing.Point(170, 124);
            this.grpChon.Name = "grpChon";
            this.grpChon.Size = new System.Drawing.Size(234, 49);
            this.grpChon.TabIndex = 15;
            this.grpChon.TabStop = false;
            // 
            // radNen
            // 
            this.radNen.AutoSize = true;
            this.radNen.Location = new System.Drawing.Point(154, 16);
            this.radNen.Name = "radNen";
            this.radNen.Size = new System.Drawing.Size(45, 17);
            this.radNen.TabIndex = 1;
            this.radNen.Text = "Nền";
            this.radNen.UseVisualStyleBackColor = true;
            // 
            // radChu
            // 
            this.radChu.AutoSize = true;
            this.radChu.Checked = true;
            this.radChu.Location = new System.Drawing.Point(43, 16);
            this.radChu.Name = "radChu";
            this.radChu.Size = new System.Drawing.Size(44, 17);
            this.radChu.TabIndex = 0;
            this.radChu.TabStop = true;
            this.radChu.Text = "Chữ";
            this.radChu.UseVisualStyleBackColor = true;
            // 
            // radDam
            // 
            this.radDam.AutoSize = true;
            this.radDam.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radDam.Location = new System.Drawing.Point(63, 203);
            this.radDam.Name = "radDam";
            this.radDam.Size = new System.Drawing.Size(50, 17);
            this.radDam.TabIndex = 16;
            this.radDam.Text = "Đậm";
            this.radDam.UseVisualStyleBackColor = true;
            this.radDam.CheckedChanged += new System.EventHandler(this.radDam_CheckedChanged);
            // 
            // radNghieng
            // 
            this.radNghieng.AutoSize = true;
            this.radNghieng.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radNghieng.Location = new System.Drawing.Point(63, 242);
            this.radNghieng.Name = "radNghieng";
            this.radNghieng.Size = new System.Drawing.Size(65, 17);
            this.radNghieng.TabIndex = 17;
            this.radNghieng.Text = "Nghiêng";
            this.radNghieng.UseVisualStyleBackColor = true;
            this.radNghieng.CheckedChanged += new System.EventHandler(this.radNghieng_CheckedChanged);
            // 
            // radThuong
            // 
            this.radThuong.AutoSize = true;
            this.radThuong.Checked = true;
            this.radThuong.Location = new System.Drawing.Point(63, 278);
            this.radThuong.Name = "radThuong";
            this.radThuong.Size = new System.Drawing.Size(62, 17);
            this.radThuong.TabIndex = 18;
            this.radThuong.TabStop = true;
            this.radThuong.Text = "Thường";
            this.radThuong.UseVisualStyleBackColor = true;
            this.radThuong.CheckedChanged += new System.EventHandler(this.radThuong_CheckedChanged);
            // 
            // txtVanBan
            // 
            this.txtVanBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVanBan.Location = new System.Drawing.Point(100, 26);
            this.txtVanBan.Multiline = true;
            this.txtVanBan.Name = "txtVanBan";
            this.txtVanBan.Size = new System.Drawing.Size(375, 77);
            this.txtVanBan.TabIndex = 19;
            this.txtVanBan.Text = "ABCDEFGH";
            this.txtVanBan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblThongBao
            // 
            this.lblThongBao.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblThongBao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongBao.Location = new System.Drawing.Point(100, 328);
            this.lblThongBao.Name = "lblThongBao";
            this.lblThongBao.Size = new System.Drawing.Size(375, 55);
            this.lblThongBao.TabIndex = 20;
            this.lblThongBao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mnuChuongTrinh
            // 
            this.mnuChuongTrinh.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMessageBox,
            this.mnuFontStyle,
            this.mnuFont,
            this.mnuSystem});
            this.mnuChuongTrinh.Location = new System.Drawing.Point(0, 0);
            this.mnuChuongTrinh.Name = "mnuChuongTrinh";
            this.mnuChuongTrinh.Size = new System.Drawing.Size(572, 24);
            this.mnuChuongTrinh.TabIndex = 22;
            this.mnuChuongTrinh.Text = "menuStrip1";
            // 
            // mnuMessageBox
            // 
            this.mnuMessageBox.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMessageBox_OK,
            this.mnuMessageBox_OKCancel,
            this.mnuMessageBox_YesNo,
            this.mnuMessageBox_YesNoCancel,
            this.mnuMessageBox_RetryCancel,
            this.mnuMessageBox_AbortRetryIgnore});
            this.mnuMessageBox.Name = "mnuMessageBox";
            this.mnuMessageBox.Size = new System.Drawing.Size(79, 20);
            this.mnuMessageBox.Text = "MessageBox";
            // 
            // mnuMessageBox_OK
            // 
            this.mnuMessageBox_OK.Name = "mnuMessageBox_OK";
            this.mnuMessageBox_OK.Size = new System.Drawing.Size(168, 22);
            this.mnuMessageBox_OK.Text = "OK";
            this.mnuMessageBox_OK.Click += new System.EventHandler(this.mnuMessageBox_OK_Click);
            // 
            // mnuMessageBox_OKCancel
            // 
            this.mnuMessageBox_OKCancel.Name = "mnuMessageBox_OKCancel";
            this.mnuMessageBox_OKCancel.Size = new System.Drawing.Size(168, 22);
            this.mnuMessageBox_OKCancel.Text = "Ok-Cancel";
            this.mnuMessageBox_OKCancel.Click += new System.EventHandler(this.mnuMessageBox_OKCancel_Click);
            // 
            // mnuMessageBox_YesNo
            // 
            this.mnuMessageBox_YesNo.Name = "mnuMessageBox_YesNo";
            this.mnuMessageBox_YesNo.Size = new System.Drawing.Size(168, 22);
            this.mnuMessageBox_YesNo.Text = "Yes-No";
            this.mnuMessageBox_YesNo.Click += new System.EventHandler(this.mnuMessageBox_YesNo_Click);
            // 
            // mnuMessageBox_YesNoCancel
            // 
            this.mnuMessageBox_YesNoCancel.Name = "mnuMessageBox_YesNoCancel";
            this.mnuMessageBox_YesNoCancel.Size = new System.Drawing.Size(168, 22);
            this.mnuMessageBox_YesNoCancel.Text = "Yes-No-Cancel";
            this.mnuMessageBox_YesNoCancel.Click += new System.EventHandler(this.mnuMessageBox_YesNoCancel_Click);
            // 
            // mnuMessageBox_RetryCancel
            // 
            this.mnuMessageBox_RetryCancel.Name = "mnuMessageBox_RetryCancel";
            this.mnuMessageBox_RetryCancel.Size = new System.Drawing.Size(168, 22);
            this.mnuMessageBox_RetryCancel.Text = "Retry-Cancel";
            this.mnuMessageBox_RetryCancel.Click += new System.EventHandler(this.mnuMessageBox_RetryCancel_Click);
            // 
            // mnuMessageBox_AbortRetryIgnore
            // 
            this.mnuMessageBox_AbortRetryIgnore.Name = "mnuMessageBox_AbortRetryIgnore";
            this.mnuMessageBox_AbortRetryIgnore.Size = new System.Drawing.Size(168, 22);
            this.mnuMessageBox_AbortRetryIgnore.Text = "Abort-Retry-Ignore";
            this.mnuMessageBox_AbortRetryIgnore.Click += new System.EventHandler(this.mnuMessageBox_AbortRetryIgnore_Click);
            // 
            // mnuFontStyle
            // 
            this.mnuFontStyle.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFontStyle_Bold,
            this.mnuFontStyle_ITalic,
            this.mnuFontStyle_Regular});
            this.mnuFontStyle.Name = "mnuFontStyle";
            this.mnuFontStyle.Size = new System.Drawing.Size(65, 20);
            this.mnuFontStyle.Text = "FontStyle";
            // 
            // mnuFontStyle_Bold
            // 
            this.mnuFontStyle_Bold.Name = "mnuFontStyle_Bold";
            this.mnuFontStyle_Bold.Size = new System.Drawing.Size(111, 22);
            this.mnuFontStyle_Bold.Text = "Bold";
            this.mnuFontStyle_Bold.Click += new System.EventHandler(this.mnuFontStyle_Bold_Click);
            // 
            // mnuFontStyle_ITalic
            // 
            this.mnuFontStyle_ITalic.Name = "mnuFontStyle_ITalic";
            this.mnuFontStyle_ITalic.Size = new System.Drawing.Size(111, 22);
            this.mnuFontStyle_ITalic.Text = "ITalic";
            this.mnuFontStyle_ITalic.Click += new System.EventHandler(this.mnuFontStyle_ITalic_Click);
            // 
            // mnuFontStyle_Regular
            // 
            this.mnuFontStyle_Regular.Name = "mnuFontStyle_Regular";
            this.mnuFontStyle_Regular.Size = new System.Drawing.Size(111, 22);
            this.mnuFontStyle_Regular.Text = "Regular";
            this.mnuFontStyle_Regular.Click += new System.EventHandler(this.mnuFontStyle_Regular_Click);
            // 
            // mnuFont
            // 
            this.mnuFont.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFont_Font,
            this.mnuFont_ForeColor,
            this.mnuFont_BackColor});
            this.mnuFont.Name = "mnuFont";
            this.mnuFont.Size = new System.Drawing.Size(41, 20);
            this.mnuFont.Text = "Font";
            // 
            // mnuFont_Font
            // 
            this.mnuFont_Font.Name = "mnuFont_Font";
            this.mnuFont_Font.Size = new System.Drawing.Size(152, 22);
            this.mnuFont_Font.Text = "Font...";
            this.mnuFont_Font.Click += new System.EventHandler(this.mnuFont_Font_Click);
            // 
            // mnuFont_ForeColor
            // 
            this.mnuFont_ForeColor.Name = "mnuFont_ForeColor";
            this.mnuFont_ForeColor.Size = new System.Drawing.Size(152, 22);
            this.mnuFont_ForeColor.Text = "Fore Color...";
            this.mnuFont_ForeColor.Click += new System.EventHandler(this.mnuFont_ForeColor_Click);
            // 
            // mnuFont_BackColor
            // 
            this.mnuFont_BackColor.Name = "mnuFont_BackColor";
            this.mnuFont_BackColor.Size = new System.Drawing.Size(152, 22);
            this.mnuFont_BackColor.Text = "Back Color...";
            this.mnuFont_BackColor.Click += new System.EventHandler(this.mnuFont_BackColor_Click);
            // 
            // mnuSystem
            // 
            this.mnuSystem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSystem_Game,
            this.mnuSystem_EXit});
            this.mnuSystem.Name = "mnuSystem";
            this.mnuSystem.Size = new System.Drawing.Size(54, 20);
            this.mnuSystem.Text = "System";
            // 
            // mnuSystem_Game
            // 
            this.mnuSystem_Game.Name = "mnuSystem_Game";
            this.mnuSystem_Game.Size = new System.Drawing.Size(152, 22);
            this.mnuSystem_Game.Text = "Game";
            this.mnuSystem_Game.Click += new System.EventHandler(this.mnuSystem_Game_Click);
            // 
            // mnuSystem_EXit
            // 
            this.mnuSystem_EXit.Name = "mnuSystem_EXit";
            this.mnuSystem_EXit.Size = new System.Drawing.Size(152, 22);
            this.mnuSystem_EXit.Text = "Exit";
            // 
            // frmColorStyle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 416);
            this.Controls.Add(this.lblThongBao);
            this.Controls.Add(this.txtVanBan);
            this.Controls.Add(this.radThuong);
            this.Controls.Add(this.radNghieng);
            this.Controls.Add(this.radDam);
            this.Controls.Add(this.grpChon);
            this.Controls.Add(this.lblBlue);
            this.Controls.Add(this.lblGreen);
            this.Controls.Add(this.lblRed);
            this.Controls.Add(this.scrBlue);
            this.Controls.Add(this.scrGreen);
            this.Controls.Add(this.scrRed);
            this.Controls.Add(this.mnuChuongTrinh);
            this.MainMenuStrip = this.mnuChuongTrinh;
            this.Name = "frmColorStyle";
            this.Text = "Font - Style - Color & Menu";
            this.grpChon.ResumeLayout(false);
            this.grpChon.PerformLayout();
            this.mnuChuongTrinh.ResumeLayout(false);
            this.mnuChuongTrinh.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBlue;
        private System.Windows.Forms.Label lblGreen;
        private System.Windows.Forms.Label lblRed;
        private System.Windows.Forms.HScrollBar scrBlue;
        private System.Windows.Forms.HScrollBar scrGreen;
        private System.Windows.Forms.HScrollBar scrRed;
        private System.Windows.Forms.GroupBox grpChon;
        private System.Windows.Forms.RadioButton radNen;
        private System.Windows.Forms.RadioButton radChu;
        private System.Windows.Forms.RadioButton radDam;
        private System.Windows.Forms.RadioButton radNghieng;
        private System.Windows.Forms.RadioButton radThuong;
        private System.Windows.Forms.TextBox txtVanBan;
        private System.Windows.Forms.Label lblThongBao;
        private System.Windows.Forms.MenuStrip mnuChuongTrinh;
        private System.Windows.Forms.ToolStripMenuItem mnuFontStyle;
        private System.Windows.Forms.ToolStripMenuItem mnuFontStyle_Bold;
        private System.Windows.Forms.ToolStripMenuItem mnuFontStyle_ITalic;
        private System.Windows.Forms.ToolStripMenuItem mnuFontStyle_Regular;
        private System.Windows.Forms.ToolStripMenuItem mnuFont;
        private System.Windows.Forms.ToolStripMenuItem mnuFont_Font;
        private System.Windows.Forms.ToolStripMenuItem mnuFont_ForeColor;
        private System.Windows.Forms.ToolStripMenuItem mnuFont_BackColor;
        private System.Windows.Forms.FontDialog HopFont;
        private System.Windows.Forms.ColorDialog HopMau;
        private System.Windows.Forms.ToolStripMenuItem mnuMessageBox;
        private System.Windows.Forms.ToolStripMenuItem mnuMessageBox_OK;
        private System.Windows.Forms.ToolStripMenuItem mnuMessageBox_OKCancel;
        private System.Windows.Forms.ToolStripMenuItem mnuMessageBox_YesNo;
        private System.Windows.Forms.ToolStripMenuItem mnuMessageBox_YesNoCancel;
        private System.Windows.Forms.ToolStripMenuItem mnuMessageBox_RetryCancel;
        private System.Windows.Forms.ToolStripMenuItem mnuMessageBox_AbortRetryIgnore;
        private System.Windows.Forms.ToolStripMenuItem mnuSystem;
        private System.Windows.Forms.ToolStripMenuItem mnuSystem_Game;
        private System.Windows.Forms.ToolStripMenuItem mnuSystem_EXit;
    }
}

