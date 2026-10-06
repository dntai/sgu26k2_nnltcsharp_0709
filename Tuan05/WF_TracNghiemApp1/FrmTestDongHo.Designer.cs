namespace WF_TracNghiemApp1
{
    partial class FrmTestDongHo
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
            ucDongHo1 = new Buoi8_FrmPhieuKhaoSat.UcDongHo();
            btnStart = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // ucDongHo1
            // 
            ucDongHo1.BackColor = Color.Yellow;
            ucDongHo1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ucDongHo1.Location = new Point(114, 44);
            ucDongHo1.Margin = new Padding(5, 6, 5, 6);
            ucDongHo1.Name = "ucDongHo1";
            ucDongHo1.Size = new Size(226, 119);
            ucDongHo1.SoGiay = 20;
            ucDongHo1.TabIndex = 0;
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.IndianRed;
            btnStart.Location = new Point(49, 200);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(162, 85);
            btnStart.TabIndex = 1;
            btnStart.Text = "START";
            btnStart.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.BackColor = Color.Peru;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(291, 200);
            label1.Name = "label1";
            label1.Size = new Size(157, 85);
            label1.TabIndex = 2;
            label1.Text = "label1";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FrmTestDongHo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(546, 333);
            Controls.Add(label1);
            Controls.Add(btnStart);
            Controls.Add(ucDongHo1);
            Name = "FrmTestDongHo";
            Text = "FrmTestDongHo";
            ResumeLayout(false);
        }

        #endregion

        private Buoi8_FrmPhieuKhaoSat.UcDongHo ucDongHo1;
        private Button btnStart;
        private Label label1;
    }
}