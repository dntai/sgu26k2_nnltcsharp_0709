namespace FoodTreeview
{
    partial class FrmFoodTree
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
            this.FoodTree = new System.Windows.Forms.TreeView();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.btnExpand = new System.Windows.Forms.Button();
            this.btnCollapse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FoodTree
            // 
            this.FoodTree.Location = new System.Drawing.Point(12, 32);
            this.FoodTree.Name = "FoodTree";
            this.FoodTree.Size = new System.Drawing.Size(220, 272);
            this.FoodTree.TabIndex = 0;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(282, 32);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(92, 29);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "&Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(282, 198);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(92, 29);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.Location = new System.Drawing.Point(282, 275);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(92, 29);
            this.btnEnd.TabIndex = 3;
            this.btnEnd.Text = "&End";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // btnExpand
            // 
            this.btnExpand.Location = new System.Drawing.Point(282, 82);
            this.btnExpand.Name = "btnExpand";
            this.btnExpand.Size = new System.Drawing.Size(92, 29);
            this.btnExpand.TabIndex = 4;
            this.btnExpand.Text = "&Expand";
            this.btnExpand.UseVisualStyleBackColor = true;
            this.btnExpand.Click += new System.EventHandler(this.btnExpand_Click);
            // 
            // btnCollapse
            // 
            this.btnCollapse.Location = new System.Drawing.Point(282, 137);
            this.btnCollapse.Name = "btnCollapse";
            this.btnCollapse.Size = new System.Drawing.Size(92, 29);
            this.btnCollapse.TabIndex = 5;
            this.btnCollapse.Text = "C&ollapse";
            this.btnCollapse.UseVisualStyleBackColor = true;
            this.btnCollapse.Click += new System.EventHandler(this.btnCollapse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Các loại Trái cây - Rau, củ, quả";
            // 
            // FrmFoodTree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 326);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCollapse);
            this.Controls.Add(this.btnExpand);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.FoodTree);
            this.Name = "FrmFoodTree";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Treeview";
            this.Load += new System.EventHandler(this.FrmFoodTree_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView FoodTree;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Button btnExpand;
        private System.Windows.Forms.Button btnCollapse;
        private System.Windows.Forms.Label label1;
    }
}

