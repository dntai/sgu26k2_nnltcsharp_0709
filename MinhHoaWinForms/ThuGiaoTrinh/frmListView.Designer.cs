namespace ThuGiaoTrinh
{
    partial class frmListView
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
            this.txtThuMuc = new System.Windows.Forms.TextBox();
            this.lvThuMuc = new System.Windows.Forms.ListView();
            this.btnXem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnTroVe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thư mục cần xem";
            // 
            // txtThuMuc
            // 
            this.txtThuMuc.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThuMuc.Location = new System.Drawing.Point(198, 36);
            this.txtThuMuc.Name = "txtThuMuc";
            this.txtThuMuc.Size = new System.Drawing.Size(387, 22);
            this.txtThuMuc.TabIndex = 1;
            this.txtThuMuc.Validated += new System.EventHandler(this.txtThuMuc_Validated);
            // 
            // lvThuMuc
            // 
            this.lvThuMuc.AllowColumnReorder = true;
            this.lvThuMuc.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvThuMuc.Location = new System.Drawing.Point(45, 89);
            this.lvThuMuc.Name = "lvThuMuc";
            this.lvThuMuc.Size = new System.Drawing.Size(540, 309);
            this.lvThuMuc.TabIndex = 2;
            this.lvThuMuc.UseCompatibleStateImageBehavior = false;
            this.lvThuMuc.DoubleClick += new System.EventHandler(this.lvThuMuc_DoubleClick);
            // 
            // btnXem
            // 
            this.btnXem.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXem.Location = new System.Drawing.Point(243, 417);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(90, 36);
            this.btnXem.TabIndex = 3;
            this.btnXem.Text = "&Xem";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(425, 417);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(90, 36);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Th&oát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnTroVe
            // 
            this.btnTroVe.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTroVe.Location = new System.Drawing.Point(70, 416);
            this.btnTroVe.Name = "btnTroVe";
            this.btnTroVe.Size = new System.Drawing.Size(101, 36);
            this.btnTroVe.TabIndex = 5;
            this.btnTroVe.Text = "&Trở về";
            this.btnTroVe.UseVisualStyleBackColor = true;
            this.btnTroVe.Click += new System.EventHandler(this.btnTroVe_Click);
            // 
            // frmListView
            // 
            this.AcceptButton = this.btnXem;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnThoat;
            this.ClientSize = new System.Drawing.Size(622, 465);
            this.Controls.Add(this.btnTroVe);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.lvThuMuc);
            this.Controls.Add(this.txtThuMuc);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("VNI-Times", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmListView";
            this.Text = "frmListView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtThuMuc;
        private System.Windows.Forms.ListView lvThuMuc;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnTroVe;
    }
}