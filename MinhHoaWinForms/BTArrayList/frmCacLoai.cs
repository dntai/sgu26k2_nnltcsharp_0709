using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BTArrayList
{
    public partial class frmCacLoai : Form
    {
        public frmCacLoai()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtLoai.Text.Trim() == "" || txtLoai.TextLength == 0)
            {
                MessageBox.Show("Xin cho biết tên loại trái cây");
                txtLoai.Focus();
            }
            else
            {
                this.Close();
            }
        }
    }
}