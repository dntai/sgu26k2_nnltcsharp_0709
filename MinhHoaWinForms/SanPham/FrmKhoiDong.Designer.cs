namespace SanPham
{
    partial class FrmKhoiDong
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
            this.ThanhChay = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DongHo = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // ThanhChay
            // 
            this.ThanhChay.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ThanhChay.Location = new System.Drawing.Point(0, 239);
            this.ThanhChay.Name = "ThanhChay";
            this.ThanhChay.Size = new System.Drawing.Size(578, 27);
            this.ThanhChay.Step = 5;
            this.ThanhChay.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(54, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hãy đón mua các sản phẩm từ:";
            // 
            // Label2
            // 
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Label2.Location = new System.Drawing.Point(12, 65);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(553, 64);
            this.Label2.TabIndex = 2;
            this.Label2.Text = "Cửa hàng thiết bị Văn phòng, Tin học, Viễn thông THANH HÙNG";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(126, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(338, 47);
            this.label3.TabIndex = 3;
            this.label3.Text = "Với nhiều sản phẩm tân tiến, thế hệ mới, giá rẻ Bảo hành chu đáo, nhanh chóng";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DongHo
            // 
            this.DongHo.Enabled = true;
            this.DongHo.Interval = 250;
            this.DongHo.Tick += new System.EventHandler(this.DongHo_Tick);
            // 
            // FrmKhoiDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(578, 266);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ThanhChay);
            this.Name = "FrmKhoiDong";
            this.Opacity = 0.8;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Khoi dong";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar ThanhChay;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer DongHo;
    }
}

