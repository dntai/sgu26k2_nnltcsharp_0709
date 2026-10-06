using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ThucDonAnNhau_Class_ListBox
{
    public partial class frmSoLuong : Form
    {
        public frmSoLuong()
        {
            InitializeComponent();
        }

        private void btnXong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSoLuong_Load(object sender, EventArgs e)
        {
            txtSoLuong.Select(0, 1);
        }

        private void txtSLgDia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}