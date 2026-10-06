using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DuLich
{
    public partial class frmMatMa : Form
    {
        int SoLan = 1;
        string strMatMa = "abc";
        public frmMatMa()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            int kq;
            kq = String.Compare(txtMatMa.Text, strMatMa, true); //Có phân biệt HOA thường
            if (kq == 0)
            {
                MessageBox.Show("Mật mã hợp lệ", "Kiểm tra mật mã");
                frmDuLich fr = new frmDuLich();
                this.Hide();
                fr.Show();
                return;
            }
            SoLan += 1;
            if (SoLan > 3)
            {
                MessageBox.Show("Bạn đã đăng nhập 3 lần không hợp lệ", "Thông báo");
                Application.Exit();
            }
            lblSoLan.Text = "Đăng nhập lần " + SoLan;
            txtMatMa.Focus();
            txtMatMa.Select(0, txtMatMa.TextLength);
        }

    }
}