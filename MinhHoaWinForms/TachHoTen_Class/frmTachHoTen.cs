using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TachHoTen_Class
{
    public partial class frmTachHoTen : Form
    {
        ClassHoTen Ht = new ClassHoTen();
        public frmTachHoTen()
        {
            InitializeComponent();
        }

        private void btnTach_Click(object sender, EventArgs e)
        {
            string ChuoiTam = txtHoTen.Text;
            if(txtHoTen.Text.Trim()=="" || txtHoTen.TextLength==0)
            {
                MessageBox.Show("Ho va ten phai co thi moi tach", "Thong bao");
                txtHoTen.Focus();
                return;
            }
            txtHoTen.Text = Ht.ChuanHoTen(ref ChuoiTam);
            Ht.TachHoTen(txtHoTen.Text);
            lblHo.Text = Ht.Ho;
            lblLot.Text = Ht.Lot;
            lblTen.Text = Ht.Ten;
        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DongHo_Tick(object sender, EventArgs e)
        {
            this.Text = this.Text.Substring(1) + this.Text.Substring(0, 1);
        }
    }
}