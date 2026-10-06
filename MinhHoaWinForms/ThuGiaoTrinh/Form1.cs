using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ThuGiaoTrinh
{
    public partial class FrmSo1 : Form
    {
        public FrmSo1()
        {
            InitializeComponent();
        }

        private void moForm2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSo2 f = new FrmSo2();
            f.MdiParent = this;
            f.Show();
        }
    }
}