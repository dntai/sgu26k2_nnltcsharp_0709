using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace DriveTreeView
{
    public partial class FrmTreeView : Form
    {
        public FrmTreeView()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            treeDrive.Nodes.Clear();
            int i = 0;
            foreach (string dr in Directory.GetLogicalDrives())
            {
                treeDrive.Nodes.Add(dr);
                GetFolder(dr,i);
                i++;
            }
        }

        void GetFolder(string name, int level)
        {
            try
            {
                int level1 = 0;
                //Duyệt qua từng thư mục
                foreach (string d in Directory.GetDirectories(name))
                {
                    //Thêm Node vào Node hiện hàn của điều khiển
                    treeDrive.Nodes[level].Nodes.Add(d.Substring(3));
                    //Liệt kê danh sách tập tin của thư mục
                    GetFile(d, level, level1);
                    level1++;
                }
            }
            catch (Exception ex)
            {
            }
        }

        void GetFile(string name, int level, int level1)
        {
            try
            {
                //Duyệt qua từng tập tin
                foreach (string f in Directory.GetFiles(name))
                {
                    //Thêm Node vào Node hiện hành của điều khiển
                    treeDrive.Nodes[level].Nodes[level1].Nodes.Add(f.Substring(name.Length + 1));
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCollapse_Click(object sender, EventArgs e)
        {
            treeDrive.CollapseAll();
        }

        private void btnExpand_Click(object sender, EventArgs e)
        {
            treeDrive.ExpandAll();
        }
    }
}