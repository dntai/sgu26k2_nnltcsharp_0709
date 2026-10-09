using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace prj_TreeView
{
    public partial class frmTreeView : Form
    {
        public frmTreeView()
        {
            InitializeComponent();
        }

        private void GetDisk()
        {
            // Duyệt ổ dĩa
            foreach( string d in Directory.GetLogicalDrives())
            {
                // Thêm vào TreeView
                TreeNode n   = treeView1.Nodes.Add(d);
                n.Tag = d;
                n.Nodes.Add("Nut con ...");
            }
        }

        private void frmTreeView_Load(object sender, EventArgs e)
        {
            GetDisk();
        }

        private void treeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            try
            {
                if (e.Node.Nodes[0].Text == "Nut con ...")
                {
                    e.Node.Nodes.Clear();

                    foreach (string FullPath in Directory.GetDirectories(e.Node.Tag.ToString()))
                    {
                        int idx = FullPath.LastIndexOf("\\");
                        TreeNode childNode = e.Node.Nodes.Add(FullPath.Substring(idx + 1));
                        childNode.Tag = FullPath;
                        childNode.Nodes.Add("Nut con ...");
                    }
                }

                if ((e.Node.Nodes.Count > 0) && (e.Node.Nodes[0].Text == "Nut con ..."))
                {
                    e.Cancel = true;
                }
            }
            catch (Exception ) { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}