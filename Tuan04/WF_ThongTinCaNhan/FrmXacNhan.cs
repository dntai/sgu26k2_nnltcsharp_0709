using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Buoi7_FrmThongTinCaNhan
{
    public partial class FrmXacNhan : Form
    {
        public FrmXacNhan()
        {
            InitializeComponent();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            MessageBox.Show("XacNhan");
        }

        private void FrmXacNhan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                btnXacNhan.PerformClick();
            }
        }

        private void txtHoTen_Validating(object sender, CancelEventArgs e)
        {
            if (txtHoTen.Text == "")
            {
                errNhapLieu.SetError(txtHoTen, "Dữ liệu không để rỗng");
                e.Cancel = true;
            }
            else
            {
                errNhapLieu.SetError(txtHoTen, null);
                e.Cancel = false;
            }
        }

        private void txtNgaySinh_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                DateTime dt = DateTime.Parse(txtNgaySinh.Text);
                errNhapLieu.SetError(txtNgaySinh, null);
                e.Cancel = false;
            }
            catch (Exception ee)
            {
                errNhapLieu.SetError(txtNgaySinh, "Ngay sinh khong hop le!");
                e.Cancel = true;
            }
        }
    }
}
