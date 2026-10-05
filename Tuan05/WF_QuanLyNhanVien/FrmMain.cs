using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using NNLTCSharp.WinForms;

namespace NNLTCSharp.WinForms
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void mnuNapDuLieu_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + @"\DanhSach.txt";
            DuLieuChuongTrinh.GetModel.NapDuLieu(path);
            List<NhanVien> ds = DuLieuChuongTrinh.GetModel.DanhSachNhanVien;
        }

        private void mnuDanhSach_Click(object sender, EventArgs e)
        {
            FrmDanhSachNhanVien frm = new FrmDanhSachNhanVien();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuNhap_Click(object sender, EventArgs e)
        {
            FrmNhapNhanVien frm = new FrmNhapNhanVien();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
