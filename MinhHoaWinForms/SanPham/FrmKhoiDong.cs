using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SanPham
{
    public partial class FrmKhoiDong : Form
    {
        public FrmKhoiDong()
        {
            InitializeComponent();
        }

        private void DongHo_Tick(object sender, EventArgs e)
        {
            if (ThanhChay.Value >= 100 )
            {
                FrmSanPham fr = new FrmSanPham();
                DongHo.Stop();
                this.Hide();
                fr.Show();
                return;
            }
            ThanhChay.Value = ThanhChay.Value + 5;
        }
    }
}