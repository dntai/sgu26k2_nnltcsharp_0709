using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BTArrayList
{
    public partial class frmSoLoai : Form
    {
        public frmSoLoai()
        {
            InitializeComponent();
        }

        private void txtSoLoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            if (txtSoLoai.TextLength==0 || int.Parse(txtSoLoai.Text) < 1)
            {
                MessageBox.Show("Xin nhập số từ 1 trở lên");
                txtSoLoai.Focus();
                txtSoLoai.Select(0, txtSoLoai.TextLength);
            }
            else
            {
                this.Close();
            }
        }

        
    }
}