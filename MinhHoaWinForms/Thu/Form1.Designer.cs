namespace Thu
{
    partial class Form1
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
            this.btnThiHanh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnThiHanh
            // 
            this.btnThiHanh.Location = new System.Drawing.Point(96, 190);
            this.btnThiHanh.Name = "btnThiHanh";
            this.btnThiHanh.Size = new System.Drawing.Size(75, 23);
            this.btnThiHanh.TabIndex = 0;
            this.btnThiHanh.Text = "Thi Hanh";
            this.btnThiHanh.UseVisualStyleBackColor = true;
            this.btnThiHanh.Click += new System.EventHandler(this.btnThiHanh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.btnThiHanh);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnThiHanh;
    }
}

