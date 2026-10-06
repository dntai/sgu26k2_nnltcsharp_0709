using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Thu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThiHanh_Click(object sender, EventArgs e)
        {
            XLHocSinh hs = new XLHocSinh();
            hs.HoLot = "Nguyễn An";
            hs.Ten = "Bình";
            hs.NgaySinh = new DateTime(1988, 10, 20);
            MessageBox.Show(hs.XuatThongTinHocSinh());
        }
    }
}