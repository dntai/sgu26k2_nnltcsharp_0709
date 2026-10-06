using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SanPham
{
    public partial class FrmSanPham : Form
    {
        String DuongDan;
        public FrmSanPham()
        {
            InitializeComponent();
        }

        
        private void FrmSanPham_Load(object sender, EventArgs e)
        {
            DuongDan = Application.StartupPath + @"\..";
            DuongDan = DuongDan + @"\..";
            //DuongDan = DuongDan.Substring(0,DuongDan.Length - 10);
            MayTinhTay.Checked = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MayTinhTay_CheckedChanged(object sender, EventArgs e)
        {
            Hinh.Image=System.Drawing.Image.FromFile(DuongDan + @"\Hinh\MayTinh.Wmf");
        }

        private void PC_CheckedChanged(object sender, EventArgs e)
        {
            Hinh.Image = System.Drawing.Image.FromFile(DuongDan + @"\Hinh\PC.Wmf");
        }

        private void MayPhoto_CheckedChanged(object sender, EventArgs e)
        {
            Hinh.Image = System.Drawing.Image.FromFile(DuongDan + @"\Hinh\MayPhoto.Wmf");
        }

        private void LapTop_CheckedChanged(object sender, EventArgs e)
        {
            Hinh.Image = System.Drawing.Image.FromFile(DuongDan + @"\Hinh\LapTop.Wmf");
        }

        private void DiaA_CheckedChanged(object sender, EventArgs e)
        {
            Hinh.Image = System.Drawing.Image.FromFile(DuongDan + @"\Hinh\DiaA.Wmf");
        }

        private void Phone_CheckedChanged(object sender, EventArgs e)
        {
            Hinh.Image = System.Drawing.Image.FromFile(DuongDan + @"\Hinh\Phone.Wmf");
        }

        private void MayIn_CheckedChanged(object sender, EventArgs e)
        {
            Hinh.Image = System.Drawing.Image.FromFile(DuongDan + @"\Hinh\MayIn.Wmf");
        }

        private void Rada_CheckedChanged(object sender, EventArgs e)
        {
            Hinh.Image = System.Drawing.Image.FromFile(DuongDan + @"\Hinh\Rada.Wmf");
        }
    }
}