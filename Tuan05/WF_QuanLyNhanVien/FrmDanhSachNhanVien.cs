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
    public partial class FrmDanhSachNhanVien : Form
    {
        public FrmDanhSachNhanVien()
        {
            InitializeComponent();

            DuLieuChuongTrinh.GetModel.ThemNhanVien += new ThemNhanVienEventHandler(GetModel_ThemNhanVien);

            this.hienThiDanhSach();

        }

        void GetModel_ThemNhanVien(object sender, EventArgs e)
        {
            this.hienThiDanhSach();
        }

        private void hienThiDanhSach()
        {
            // Model
            DuLieuChuongTrinh model = DuLieuChuongTrinh.GetModel;
            // Duyet nhan vien hien thi len ListView
            lvwDanhSachNhanVien.Items.Clear();
            foreach (NhanVien nv in model.DanhSachNhanVien)
            {
                ListViewItem item = new ListViewItem(nv.MaNV);
                item.SubItems.Add(nv.HoTen);
                item.SubItems.Add(nv.NgaySinh.ToString("dd/MM/yyyy"));
                item.SubItems.Add(nv.DiaChi);

                lvwDanhSachNhanVien.Items.Add(item);

            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FrmNhapNhanVien frm = new FrmNhapNhanVien();
            DialogResult ret = frm.ShowDialog();
            if (ret == DialogResult.OK)
            {
                this.hienThiDanhSach();
            }
        }

    }
}
