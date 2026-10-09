namespace WF_TracNghiemApp1
{
    partial class FrmTestDeThi
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
            btnTestCauHoi = new Button();
            openFileDialog1 = new OpenFileDialog();
            SuspendLayout();
            // 
            // btnTestCauHoi
            // 
            btnTestCauHoi.Location = new Point(12, 12);
            btnTestCauHoi.Name = "btnTestCauHoi";
            btnTestCauHoi.Size = new Size(148, 48);
            btnTestCauHoi.TabIndex = 0;
            btnTestCauHoi.Text = "Test Cau Hoi";
            btnTestCauHoi.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // FrmTestDeThi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(471, 186);
            Controls.Add(btnTestCauHoi);
            Name = "FrmTestDeThi";
            Text = "FrmTestDeThi";
            ResumeLayout(false);
        }

        #endregion

        private Button btnTestCauHoi;
        private OpenFileDialog openFileDialog1;
    }
}