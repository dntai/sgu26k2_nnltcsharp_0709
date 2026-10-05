using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TracNghiemApp.Lib;

namespace Buoi8_FrmPhieuKhaoSat
{
    public partial class FrmTest : Form
    {
        public FrmTest()
        {
            InitializeComponent();

            btnStartClock.Click += BtnStartClock_Click;
            btnChonCauHoi.Click += BtnChonCauHoi_Click;
            ucDongHo.Finish += UcDongHo_Finish;
        }

        private void BtnChonCauHoi_Click(object? sender, EventArgs e)
        {
            DialogResult ret = openFileDialog1.ShowDialog();
            if (ret == DialogResult.OK)
            {
                string fname = openFileDialog1.FileName;
                CauHoi cauhoi = new CauHoi();
                using (StreamReader reader = new StreamReader(fname))
                {
                    cauhoi.ReadFile(reader);
                }
                MessageBox.Show(cauhoi.ToString());
                ucCauHoi1.NoiDung = cauhoi;
            }
        }

        private void UcDongHo_Finish(object sender, EventArgs e)
        {
            lblHoanThanh.Text = "Hoan thanh!";
        }

        private void BtnStartClock_Click(object? sender, EventArgs e)
        {
            ucDongHo.SoGiay = 10;
            ucDongHo.Start();
        }
    }
}
