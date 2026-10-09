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

            btnHuy.Click += BtnHuy_Click;
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int SoLuong
        {
            get
            {
                int ret = 1;
                try
                {
                    ret = int.Parse(txtSoLuong.Text);
                    if (ret == 0) ret = 1;
                }
                catch {
                }
                return ret;
            }
            set
            {
                if(value <= 0)
                {
                    value = 1;
                }
                txtSoLuong.Text = value.ToString();
            }
        }

        private void BtnHuy_Click(object? sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnXong_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
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