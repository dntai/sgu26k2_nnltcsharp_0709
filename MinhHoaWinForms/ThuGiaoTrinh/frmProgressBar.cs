using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ThuGiaoTrinh
{
    public partial class frmProgressBar : Form
    {
        public frmProgressBar()
        {
            InitializeComponent();
        }

        private void DongHo_Tick(object sender, EventArgs e)
        {
            if (ThanhChay.Value >= 100)
            {
                //frmTreeView fr = new frmTreeView();
                DongHo.Stop();
                //this.Hide();
                //fr.Show();
                this.Close();
                return;
            }
            ThanhChay.Value += 5;
        }
    }
}