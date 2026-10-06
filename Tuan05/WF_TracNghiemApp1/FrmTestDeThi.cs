using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TracNghiemApp.Lib;

namespace WF_TracNghiemApp1
{
    public partial class FrmTestDeThi : Form
    {
        public FrmTestDeThi()
        {
            InitializeComponent();

            btnTestCauHoi.Click += BtnTestCauHoi_Click;
        }

        private void BtnTestCauHoi_Click(object? sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Application.StartupPath + @"..\..\..";
            DialogResult ret = openFileDialog1.ShowDialog();
            if (ret == DialogResult.OK)
            {
                string fpath = openFileDialog1.FileName;
                // MessageBox.Show(fpath);
                using (StreamReader reader = new StreamReader(fpath))
                {
                    CauHoi cauhoi = new CauHoi();
                    cauhoi.ReadFile(reader);
                    MessageBox.Show(cauhoi.ToString());
                }
            }
        }
    }
}
