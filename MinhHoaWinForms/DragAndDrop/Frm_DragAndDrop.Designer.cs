namespace DragAndDrop
{
    partial class Frm_DragAndDrop
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.FirstTree = new System.Windows.Forms.TreeView();
            this.SecondTree = new System.Windows.Forms.TreeView();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.FirstTree);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.SecondTree);
            this.splitContainer1.Size = new System.Drawing.Size(536, 296);
            this.splitContainer1.SplitterDistance = 261;
            this.splitContainer1.TabIndex = 0;
            // 
            // FirstTree
            // 
            this.FirstTree.AllowDrop = true;
            this.FirstTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FirstTree.Location = new System.Drawing.Point(0, 0);
            this.FirstTree.Name = "FirstTree";
            this.FirstTree.Size = new System.Drawing.Size(261, 296);
            this.FirstTree.TabIndex = 0;
            this.FirstTree.DragDrop += new System.Windows.Forms.DragEventHandler(this.tree_DragDrop);
            this.FirstTree.DragOver += new System.Windows.Forms.DragEventHandler(this.tree_DragOver);
            this.FirstTree.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FirstTree_KeyDown);
            this.FirstTree.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tree_MouseDown);
            // 
            // SecondTree
            // 
            this.SecondTree.AllowDrop = true;
            this.SecondTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SecondTree.Location = new System.Drawing.Point(0, 0);
            this.SecondTree.Name = "SecondTree";
            this.SecondTree.Size = new System.Drawing.Size(271, 296);
            this.SecondTree.TabIndex = 0;
            this.SecondTree.DragDrop += new System.Windows.Forms.DragEventHandler(this.tree_DragDrop);
            this.SecondTree.DragOver += new System.Windows.Forms.DragEventHandler(this.tree_DragOver);
            this.SecondTree.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SecondTree_KeyDown);
            this.SecondTree.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tree_MouseDown);
            // 
            // Frm_DragAndDrop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 296);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Frm_DragAndDrop";
            this.Text = "Drag and Drop";
            this.Load += new System.EventHandler(this.Frm_DragAndDrop_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView FirstTree;
        private System.Windows.Forms.TreeView SecondTree;

    }
}

