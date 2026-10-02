using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Buoi7_FrmThucHienPhepTinh
{
    public partial class FrmThucHienPhepTinh : Form
    {

        public FrmThucHienPhepTinh()
        {
            InitializeComponent();
        }

        private void FrmThucHienPhepTinh_Load(object sender, EventArgs e)
        {
            txtSoA.Text = "";
            txtSoB.Text = "";
            txtKetQua.Text = "";

            btnCong.Click += new EventHandler(PhepTinh_Click);
            btnTru.Click += new EventHandler(PhepTinh_Click);
            btnNhan.Click += new EventHandler(PhepTinh_Click);
            btnChia.Click += new EventHandler(PhepTinh_Click);
        }

        void PhepTinh_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtSoA.Text);
            int b = int.Parse(txtSoB.Text);
            double kq = 0;

            Button btn = sender as Button;
            switch (btn.Text)
            {
                case "+":
                    kq = a + b;
                    break;
                case "-":
                    kq = a - b;
                    break;
                case "*":
                    kq = a * b;
                    break;
                case "/":
                    if (b != 0)
                    {
                        kq = a / (double)b;
                    }
                    break;
            }

            if (btn.Text == "/" && b == 0)
            {
                txtKetQua.Text = "Phép chia cho 0!";
            }
            else
            {
                txtKetQua.Text = string.Format("{0}{1}{2}={3}", a, btn.Text, b, kq);
            }
        }

        private void btnTiepTuc_Click(object sender, EventArgs e)
        {
            txtSoA.Text = "";
            txtSoB.Text = "";
            txtKetQua.Text = "";
            txtSoA.Focus();
        }

        private void NhapSo_Validating(object sender, CancelEventArgs e)
        {
            TextBox txtSo = sender as TextBox;
            try
            {
                int so = int.Parse(txtSo.Text);
                errorLoi.SetError(txtSo, null);
            }
            catch
            {
                errorLoi.SetError(txtSo, "Loi nhap so!");
                e.Cancel = true;
            }
        }
    }
}
