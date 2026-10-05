namespace Buoi8_FrmPhieuKhaoSat
{
    partial class FrmKhaoSat
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnAnswer = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ucCauHoi1 = new Buoi8_FrmPhieuKhaoSat.UcCauHoi();
            this.ucDongHo1 = new Buoi8_FrmPhieuKhaoSat.UcDongHo();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(447, 416);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "&Next";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnAnswer
            // 
            this.btnAnswer.Location = new System.Drawing.Point(366, 416);
            this.btnAnswer.Name = "btnAnswer";
            this.btnAnswer.Size = new System.Drawing.Size(75, 23);
            this.btnAnswer.TabIndex = 3;
            this.btnAnswer.Text = "&Answer";
            this.btnAnswer.UseVisualStyleBackColor = true;
            this.btnAnswer.Click += new System.EventHandler(this.btnAnswer_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Họ tên:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(60, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(224, 20);
            this.textBox1.TabIndex = 5;
            // 
            // ucCauHoi1
            // 
            this.ucCauHoi1.Location = new System.Drawing.Point(12, 36);
            this.ucCauHoi1.Name = "ucCauHoi1";
            this.ucCauHoi1.NoiDung = null;
            this.ucCauHoi1.Size = new System.Drawing.Size(527, 374);
            this.ucCauHoi1.TabIndex = 7;
            // 
            // ucDongHo1
            // 
            this.ucDongHo1.BackColor = System.Drawing.Color.Yellow;
            this.ucDongHo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucDongHo1.Location = new System.Drawing.Point(303, 6);
            this.ucDongHo1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucDongHo1.Name = "ucDongHo1";
            this.ucDongHo1.Size = new System.Drawing.Size(151, 22);
            this.ucDongHo1.SoGiay = 0;
            this.ucDongHo1.TabIndex = 6;
            // 
            // FrmKhaoSat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 464);
            this.Controls.Add(this.ucCauHoi1);
            this.Controls.Add(this.ucDongHo1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAnswer);
            this.Controls.Add(this.button1);
            this.Name = "FrmKhaoSat";
            this.Text = "Khảo sát ý kiến";
            this.Load += new System.EventHandler(this.FrmKhaoSat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAnswer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private UcDongHo ucDongHo1;
        private UcCauHoi ucCauHoi1;
    }
}

