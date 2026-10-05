namespace Buoi8_FrmPhieuKhaoSat
{
    partial class FrmTest
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
            ucDongHo = new UcDongHo();
            btnStartClock = new Button();
            lblHoanThanh = new Label();
            ucCauHoi1 = new UcCauHoi();
            btnChonCauHoi = new Button();
            openFileDialog1 = new OpenFileDialog();
            SuspendLayout();
            // 
            // ucDongHo
            // 
            ucDongHo.BackColor = Color.Yellow;
            ucDongHo.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ucDongHo.Location = new Point(14, 15);
            ucDongHo.Margin = new Padding(5, 6, 5, 6);
            ucDongHo.Name = "ucDongHo";
            ucDongHo.Size = new Size(232, 60);
            ucDongHo.SoGiay = 60;
            ucDongHo.TabIndex = 0;
            // 
            // btnStartClock
            // 
            btnStartClock.Location = new Point(254, 15);
            btnStartClock.Name = "btnStartClock";
            btnStartClock.Size = new Size(102, 60);
            btnStartClock.TabIndex = 1;
            btnStartClock.Text = "Start Clock";
            btnStartClock.UseVisualStyleBackColor = true;
            // 
            // lblHoanThanh
            // 
            lblHoanThanh.BackColor = Color.IndianRed;
            lblHoanThanh.Font = new Font("Segoe UI", 12F);
            lblHoanThanh.Location = new Point(362, 15);
            lblHoanThanh.Name = "lblHoanThanh";
            lblHoanThanh.Size = new Size(171, 60);
            lblHoanThanh.TabIndex = 2;
            lblHoanThanh.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ucCauHoi1
            // 
            ucCauHoi1.Location = new Point(14, 103);
            ucCauHoi1.Margin = new Padding(4, 5, 4, 5);
            ucCauHoi1.Name = "ucCauHoi1";
            ucCauHoi1.NoiDung = null;
            ucCauHoi1.Size = new Size(699, 719);
            ucCauHoi1.TabIndex = 3;
            // 
            // btnChonCauHoi
            // 
            btnChonCauHoi.Location = new Point(539, 15);
            btnChonCauHoi.Name = "btnChonCauHoi";
            btnChonCauHoi.Size = new Size(174, 60);
            btnChonCauHoi.TabIndex = 4;
            btnChonCauHoi.Text = "Chon cau hoi";
            btnChonCauHoi.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // FrmTest
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(731, 681);
            Controls.Add(btnChonCauHoi);
            Controls.Add(ucCauHoi1);
            Controls.Add(lblHoanThanh);
            Controls.Add(btnStartClock);
            Controls.Add(ucDongHo);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FrmTest";
            Text = "FrmTest";
            ResumeLayout(false);
        }

        #endregion

        private UcDongHo ucDongHo1;
        private UcDongHo ucDongHo;
        private Button btnStartClock;
        private Label lblHoanThanh;
        private UcCauHoi ucCauHoi1;
        private Button btnChonCauHoi;
        private OpenFileDialog openFileDialog1;
    }
}