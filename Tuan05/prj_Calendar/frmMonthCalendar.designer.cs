namespace prj_Calendar
{
    partial class frmMonthCalendar
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
            this.Lich = new System.Windows.Forms.MonthCalendar();
            this.SuspendLayout();
            // 
            // Lich
            // 
            this.Lich.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lich.Location = new System.Drawing.Point(-2, 0);
            this.Lich.Name = "Lich";
            this.Lich.TabIndex = 0;
            this.Lich.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.Lich_DateChanged);
            // 
            // frmMonthCalendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 278);
            this.Controls.Add(this.Lich);
            this.Name = "frmMonthCalendar";
            this.Text = "frmMonthCalendar";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar Lich;
    }
}