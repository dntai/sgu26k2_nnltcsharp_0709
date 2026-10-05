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
    public partial class FrmKhaoSat : Form
    {
        DeThi dethi;

        public FrmKhaoSat()
        {
            InitializeComponent();

            string path = Application.StartupPath;

            dethi = new DeThi();
            dethi.ReadFile(path + "\\KhaoSat1.txt");
            ucCauHoi1.NoiDung = dethi[1];
        }

        private void FrmKhaoSat_Load(object sender, EventArgs e)
        {

        }

        private void btnAnswer_Click(object sender, EventArgs e)
        {
            int[] ds = ucCauHoi1.TraLoi;
            string kq = string.Join(" ", ds);
            MessageBox.Show(kq);
        }
    }
}
