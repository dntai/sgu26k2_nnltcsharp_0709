using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ThuGiaoTrinh
{
    public partial class FrmScrollBar : Form
    {
        public FrmScrollBar()
        {
            InitializeComponent();
        }

        private void DoiMau()
        {
            Color Mau;
            //Su dung phuong thuc tao mau bang 3 mau Red, Green, Blue
            Mau = Color.FromArgb(scrRed.Value, scrGreen.Value, scrBlue.Value);
            picHinh.BackColor = Mau;
            lblRed.Text   = "Red    = " + scrRed.Value;
            lblGreen.Text = "Green = " + scrGreen.Value;
            lblBlue.Text  = "Blue   = " + scrBlue.Value;
        }

        private void scrRed_Scroll(object sender, ScrollEventArgs e)
        {
            DoiMau();
        }

        private void scrGreen_Scroll(object sender, ScrollEventArgs e)
        {
            DoiMau();
        }

        private void scrBlue_Scroll(object sender, ScrollEventArgs e)
        {
            DoiMau();
        }
    }
}