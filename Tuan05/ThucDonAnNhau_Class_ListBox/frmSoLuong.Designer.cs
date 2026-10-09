namespace ThucDonAnNhau_Class_ListBox
{
    partial class frmSoLuong
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
            label1 = new Label();
            txtSoLuong = new TextBox();
            btnXong = new Button();
            btnHuy = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(49, 94);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(104, 17);
            label1.TabIndex = 0;
            label1.Text = "Số lượng đĩa:";
            // 
            // txtSoLuong
            // 
            txtSoLuong.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSoLuong.Location = new Point(172, 89);
            txtSoLuong.Margin = new Padding(4, 5, 4, 5);
            txtSoLuong.MaxLength = 1;
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(81, 23);
            txtSoLuong.TabIndex = 1;
            txtSoLuong.Text = "1";
            txtSoLuong.TextAlign = HorizontalAlignment.Center;
            txtSoLuong.KeyPress += txtSLgDia_KeyPress;
            // 
            // btnXong
            // 
            btnXong.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXong.Location = new Point(49, 159);
            btnXong.Margin = new Padding(4, 5, 4, 5);
            btnXong.Name = "btnXong";
            btnXong.Size = new Size(100, 35);
            btnXong.TabIndex = 2;
            btnXong.Text = "&Xong";
            btnXong.UseVisualStyleBackColor = true;
            btnXong.Click += btnXong_Click;
            // 
            // btnHuy
            // 
            btnHuy.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnHuy.Location = new Point(201, 159);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(94, 29);
            btnHuy.TabIndex = 3;
            btnHuy.Text = "&Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            // 
            // frmSoLuong
            // 
            AcceptButton = btnXong;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            CancelButton = btnHuy;
            ClientSize = new Size(364, 237);
            Controls.Add(btnHuy);
            Controls.Add(btnXong);
            Controls.Add(txtSoLuong);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmSoLuong";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmSoLuong";
            Load += frmSoLuong_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Button btnXong;
        private Button btnHuy;
    }
}