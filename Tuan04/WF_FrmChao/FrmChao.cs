using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NNLTCS.WinForms
{
    public partial class FrmChao : Form
    {
        public FrmChao()
        {
            InitializeComponent();
        }

        private void btnChao_Click(object sender, EventArgs e)
        {
            lblChao.Text = string.Format("Chào bạn, {0}!", txtChao.Text);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("btnThoat_Click");
            this.Close();
        }

        private void FrmChao_FormClosing(object sender, FormClosingEventArgs e)
        {
            // MessageBox.Show("FrmChao_FormClosing");
            DialogResult ret = MessageBox.Show("Bạn có muốn thoát chương trình không?", "Thoát chương trình", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
