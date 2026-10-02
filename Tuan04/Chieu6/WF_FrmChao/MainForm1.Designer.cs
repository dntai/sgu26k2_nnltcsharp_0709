namespace NNLTCSharp.WinForms
{
    partial class MainForm1
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
            btnOK = new Button();
            SuspendLayout();
            // 
            // btnOK
            // 
            btnOK.Location = new Point(169, 101);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(120, 61);
            btnOK.TabIndex = 0;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // MainForm1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LimeGreen;
            ClientSize = new Size(451, 278);
            Controls.Add(btnOK);
            Name = "MainForm1";
            Text = "MainForm1";
            FormClosing += MainForm1_FormClosing;
            Click += MainForm1_Click;
            ResumeLayout(false);
        }

        #endregion

        private Button btnOK;
    }
}