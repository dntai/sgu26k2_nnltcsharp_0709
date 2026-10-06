using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HoSoNhanVien_Class
{
    public partial class frmHienMaSo : Form
    {
        string[] MaSo ={ "0", "7", "D", "0", "0", "4", "0", "0", "4", "8" };
        int i = 0;
        public frmHienMaSo()
        {
            InitializeComponent();
        }

        private void DongHo1_Tick(object sender, EventArgs e)
        {
            if (i > MaSo.GetUpperBound(0))
            {
                DongHo1.Stop();
                DongHo2.Start();
                return;
            }
            lblMaSo.Text += MaSo[i];
            i++;
        }

        private void DongHo2_Tick(object sender, EventArgs e)
        {
            DongHo2.Stop();
            frmHoSoNV fr = new frmHoSoNV();
            fr.Show();
            this.Hide();
        }
    }
}