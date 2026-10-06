using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DiemThi_Class_File
{
    public partial class frmKhoiDong : Form
    {
        public frmKhoiDong()
        {
            InitializeComponent();
        }

        private void DongHo_Tick(object sender, EventArgs e)
        {
            if (ThanhChay.Value >= 100)
            {
                DongHo.Stop();
                frmBangDiem fr = new frmBangDiem();
                fr.Show();
                this.Hide();
                return;
            }
            ThanhChay.Value += 5;
        }
    }
}