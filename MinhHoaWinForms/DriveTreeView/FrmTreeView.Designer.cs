namespace DriveTreeView
{
    partial class FrmTreeView
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
            this.treeDrive = new System.Windows.Forms.TreeView();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnCollapse = new System.Windows.Forms.Button();
            this.btnExpand = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // treeDrive
            // 
            this.treeDrive.FullRowSelect = true;
            this.treeDrive.Location = new System.Drawing.Point(14, 9);
            this.treeDrive.Name = "treeDrive";
            this.treeDrive.Size = new System.Drawing.Size(405, 371);
            this.treeDrive.TabIndex = 0;
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.Location = new System.Drawing.Point(14, 405);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(83, 34);
            this.btnShow.TabIndex = 1;
            this.btnShow.Text = "&Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnCollapse
            // 
            this.btnCollapse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCollapse.Location = new System.Drawing.Point(106, 405);
            this.btnCollapse.Name = "btnCollapse";
            this.btnCollapse.Size = new System.Drawing.Size(83, 34);
            this.btnCollapse.TabIndex = 2;
            this.btnCollapse.Text = "&CollapseAll";
            this.btnCollapse.UseVisualStyleBackColor = true;
            this.btnCollapse.Click += new System.EventHandler(this.btnCollapse_Click);
            // 
            // btnExpand
            // 
            this.btnExpand.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpand.Location = new System.Drawing.Point(198, 405);
            this.btnExpand.Name = "btnExpand";
            this.btnExpand.Size = new System.Drawing.Size(83, 34);
            this.btnExpand.TabIndex = 3;
            this.btnExpand.Text = "&ExpandAll";
            this.btnExpand.UseVisualStyleBackColor = true;
            this.btnExpand.Click += new System.EventHandler(this.btnExpand_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnd.Location = new System.Drawing.Point(343, 405);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(83, 34);
            this.btnEnd.TabIndex = 4;
            this.btnEnd.Text = "&End";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // FrmTreeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 462);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.btnExpand);
            this.Controls.Add(this.btnCollapse);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.treeDrive);
            this.Name = "FrmTreeView";
            this.Text = "Xem thông tin ổ đĩa";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeDrive;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnCollapse;
        private System.Windows.Forms.Button btnExpand;
        private System.Windows.Forms.Button btnEnd;
    }
}

