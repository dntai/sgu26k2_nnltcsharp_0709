namespace HelloApp
{
    partial class Hello
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.chuoiLK1 = new System.Windows.Forms.LinkLabel();
            this.btnHello = new System.Windows.Forms.Button();
            this.chuoiLK2 = new System.Windows.Forms.LinkLabel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập họ và tên:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(120, 33);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(213, 20);
            this.txtHoTen.TabIndex = 1;
            // 
            // chuoiLK1
            // 
            this.chuoiLK1.AutoSize = true;
            this.chuoiLK1.Location = new System.Drawing.Point(117, 87);
            this.chuoiLK1.Name = "chuoiLK1";
            this.chuoiLK1.Size = new System.Drawing.Size(151, 13);
            this.chuoiLK1.TabIndex = 2;
            this.chuoiLK1.TabStop = true;
            this.chuoiLK1.Text = "Http://localhost/trangchu.html";
            this.chuoiLK1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.chuoiLK1_LinkClicked);
            // 
            // btnHello
            // 
            this.btnHello.Location = new System.Drawing.Point(120, 185);
            this.btnHello.Name = "btnHello";
            this.btnHello.Size = new System.Drawing.Size(122, 26);
            this.btnHello.TabIndex = 3;
            this.btnHello.Text = "Hello";
            this.btnHello.UseVisualStyleBackColor = true;
            this.btnHello.Click += new System.EventHandler(this.btnHello_Click);
            // 
            // chuoiLK2
            // 
            this.chuoiLK2.AutoSize = true;
            this.chuoiLK2.LinkArea = new System.Windows.Forms.LinkArea(17, 23);
            this.chuoiLK2.Location = new System.Drawing.Point(117, 120);
            this.chuoiLK2.Name = "chuoiLK2";
            this.chuoiLK2.Size = new System.Drawing.Size(189, 17);
            this.chuoiLK2.TabIndex = 4;
            this.chuoiLK2.TabStop = true;
            this.chuoiLK2.Text = "Xin liên lạc tới:http://www.yahoo.com";
            this.chuoiLK2.UseCompatibleTextRendering = true;
            this.chuoiLK2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.chuoiLK2_LinkClicked);
            // 
            // btnThoat
            // 
            this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThoat.Location = new System.Drawing.Point(253, 228);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(79, 27);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Hello
            // 
            this.AcceptButton = this.btnHello;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnThoat;
            this.ClientSize = new System.Drawing.Size(362, 266);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.chuoiLK2);
            this.Controls.Add(this.btnHello);
            this.Controls.Add(this.chuoiLK1);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.label1);
            this.Name = "Hello";
            this.Text = "Hello";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.LinkLabel chuoiLK1;
        private System.Windows.Forms.Button btnHello;
        private System.Windows.Forms.LinkLabel chuoiLK2;
        private System.Windows.Forms.Button btnThoat;
    }
}

