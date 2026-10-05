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
    public partial class FrmNhapNhanVien : Form
    {
        public FrmNhapNhanVien()
        {
            InitializeComponent();
        }

        public NhanVien getControl2Model()
        {
            NhanVien nv = new NhanVien();
            nv.MaNV = txtMaNV.Text;
            nv.HoTen = txtHoTen.Text;
            nv.DiaChi = txtDiaChi.Text;
            nv.NgaySinh = datNgaySinh.Value;
            return nv;
        }

        public NhanVien DuLieu
        {
            get
            {
                return this.getControl2Model();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DuLieuChuongTrinh.GetModel.themNhanVien(this.DuLieu);
            // Modal
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            // Modal
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
