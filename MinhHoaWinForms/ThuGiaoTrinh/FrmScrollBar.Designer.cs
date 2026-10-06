namespace ThuGiaoTrinh
{
    partial class FrmScrollBar
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
            this.scrRed = new System.Windows.Forms.HScrollBar();
            this.scrGreen = new System.Windows.Forms.HScrollBar();
            this.scrBlue = new System.Windows.Forms.HScrollBar();
            this.lblRed = new System.Windows.Forms.Label();
            this.lblGreen = new System.Windows.Forms.Label();
            this.lblBlue = new System.Windows.Forms.Label();
            this.picHinh = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picHinh)).BeginInit();
            this.SuspendLayout();
            // 
            // scrRed
            // 
            this.scrRed.Location = new System.Drawing.Point(137, 160);
            this.scrRed.Maximum = 255;
            this.scrRed.Name = "scrRed";
            this.scrRed.Size = new System.Drawing.Size(233, 23);
            this.scrRed.TabIndex = 1;
            this.scrRed.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scrRed_Scroll);
            // 
            // scrGreen
            // 
            this.scrGreen.Location = new System.Drawing.Point(138, 198);
            this.scrGreen.Maximum = 255;
            this.scrGreen.Name = "scrGreen";
            this.scrGreen.Size = new System.Drawing.Size(233, 23);
            this.scrGreen.TabIndex = 2;
            this.scrGreen.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scrGreen_Scroll);
            // 
            // scrBlue
            // 
            this.scrBlue.Location = new System.Drawing.Point(138, 233);
            this.scrBlue.Maximum = 255;
            this.scrBlue.Name = "scrBlue";
            this.scrBlue.Size = new System.Drawing.Size(233, 23);
            this.scrBlue.TabIndex = 3;
            this.scrBlue.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scrBlue_Scroll);
            // 
            // lblRed
            // 
            this.lblRed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRed.ForeColor = System.Drawing.Color.Red;
            this.lblRed.Location = new System.Drawing.Point(33, 160);
            this.lblRed.Name = "lblRed";
            this.lblRed.Size = new System.Drawing.Size(92, 22);
            this.lblRed.TabIndex = 4;
            // 
            // lblGreen
            // 
            this.lblGreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblGreen.Location = new System.Drawing.Point(33, 198);
            this.lblGreen.Name = "lblGreen";
            this.lblGreen.Size = new System.Drawing.Size(92, 22);
            this.lblGreen.TabIndex = 5;
            // 
            // lblBlue
            // 
            this.lblBlue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlue.ForeColor = System.Drawing.Color.Blue;
            this.lblBlue.Location = new System.Drawing.Point(33, 233);
            this.lblBlue.Name = "lblBlue";
            this.lblBlue.Size = new System.Drawing.Size(92, 22);
            this.lblBlue.TabIndex = 6;
            // 
            // picHinh
            // 
            this.picHinh.BackColor = System.Drawing.Color.White;
            this.picHinh.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picHinh.Location = new System.Drawing.Point(33, 12);
            this.picHinh.Name = "picHinh";
            this.picHinh.Size = new System.Drawing.Size(336, 132);
            this.picHinh.TabIndex = 7;
            this.picHinh.TabStop = false;
            // 
            // FrmScrollBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 266);
            this.Controls.Add(this.picHinh);
            this.Controls.Add(this.lblBlue);
            this.Controls.Add(this.lblGreen);
            this.Controls.Add(this.lblRed);
            this.Controls.Add(this.scrBlue);
            this.Controls.Add(this.scrGreen);
            this.Controls.Add(this.scrRed);
            this.Name = "FrmScrollBar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ScrollBar";
            ((System.ComponentModel.ISupportInitialize)(this.picHinh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.HScrollBar scrRed;
        private System.Windows.Forms.HScrollBar scrGreen;
        private System.Windows.Forms.HScrollBar scrBlue;
        private System.Windows.Forms.Label lblRed;
        private System.Windows.Forms.Label lblGreen;
        private System.Windows.Forms.Label lblBlue;
        private System.Windows.Forms.PictureBox picHinh;
        private System.Windows.Forms.Timer timer1;
    }
}