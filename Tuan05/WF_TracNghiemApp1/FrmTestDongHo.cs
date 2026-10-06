using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_TracNghiemApp1
{
    public partial class FrmTestDongHo : Form
    {
        public FrmTestDongHo()
        {
            InitializeComponent();

            btnStart.Click += BtnStart_Click;
            ucDongHo1.SoGiay = 10;
            ucDongHo1.Finish += UcDongHo1_Finish;
        }

        private void UcDongHo1_Finish(object sender, EventArgs e)
        {
            label1.Text = "Hoàn thành.";
        }

        private void BtnStart_Click(object? sender, EventArgs e)
        {
            label1.Text = "";
            ucDongHo1.SoGiay = 10;
            ucDongHo1.Start();
        }
    }
}
