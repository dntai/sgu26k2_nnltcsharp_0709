using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HoSoNhanVien_Class
{
    public partial class frmHoSoNV : Form
    {
        ClassNhanVien Nv;
        public frmHoSoNV()
        {
            InitializeComponent();
        }

        private bool KiemTraMaSo()
        { 
            for(int i = 0; i < lstDanhSach.Items.Count; i++)
            {
                Nv = (ClassNhanVien)(lstDanhSach.Items[i]);
                if(String.Compare(Nv.MaSo, txtMaSo.Text,true) == 0)
                {
                    return true;
                }
            }
            return false;
        }

        private void btnTiepNhan_Click(object sender, EventArgs e)
        {
           if (txtMaSo.TextLength == 0 || txtMaSo.Text.Trim()== ""
                || txtHoTen.Text.Trim() == "" || txtHoTen.TextLength == 0 )
            {
                MessageBox.Show("Chua du thong tin de tiep nhan", "Kiem tra nhap lieu"); 
                txtMaSo.Focus();
                return;
            }
            if(KiemTraMaSo() == true)
            {
                MessageBox.Show("Ma so nay da co, xin vui long nhap ma so khac", "Kiem tra");
                txtMaSo.Select(0, txtMaSo.TextLength);
                txtMaSo.Focus();
                return;
            }
            else
            {
                if (DateTime.Now.Year - int.Parse(txtNamSinh.Text) < 18)
                {
                    DialogResult TL;
                    TL = MessageBox.Show("Chú ý\nỨng viên này chưa đủ 18 tuổi\nBạn có đồng ý tiếp nhận hay không",
                        "Tiếp nhận nhân viên", MessageBoxButtons.YesNo);
                    if (TL == DialogResult.No) return;
                }
                Nv = new ClassNhanVien();
                Nv.MaSo = txtMaSo.Text;
                Nv.HoTen = txtHoTen.Text;
                Nv.PhongBan = cboPhongBan.SelectedIndex;
                Nv.ChucVu = cboChucVu.SelectedIndex;
                Nv.NamSinh = int.Parse(txtNamSinh.Text);
                Nv.Phai = radNam.Checked == true ? 1 : 0;
                lstDanhSach.Items.Add(Nv);
                lstDanhSach.SelectedIndex = lstDanhSach.Items.Count - 1;
                //lblSoNV.Refresh();
            }
        }

        private void bntThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmHoSoNV_Load(object sender, EventArgs e)
        {
            cboPhongBan.SelectedIndex = 5;
            cboChucVu.SelectedIndex = 0;
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            txtMaSo.Clear();
            txtHoTen.Clear();
            cboPhongBan.SelectedIndex = 5;
            cboChucVu.SelectedIndex = 0;
            txtNamSinh.Clear();
            radNam.Checked = true;
            txtMaSo.Focus();
        }

        private void btnLoaiBo_Click(object sender, EventArgs e)
        {
            if (lstDanhSach.SelectedIndex != -1)
            {
                DialogResult Tl;
                Tl = MessageBox.Show("Ban co that su muon loai bo nhan vien nay khong?", "Canh bao xoa du lieu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Tl == DialogResult.Yes)
                {

                    lstDanhSach.Items.RemoveAt(lstDanhSach.SelectedIndex);
                    Nv = null;
                    if (lstDanhSach.Items.Count > 0)
                    {
                        lstDanhSach.SelectedIndex = lstDanhSach.Items.Count - 1;
                    }
                    else
                    {
                        lblSoNV.Text = "0/0";
                    }
                    btnThemMoi_Click(sender, e);
                }
            }
        }

        private void lstDanhSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lstDanhSach.SelectedIndex != -1)
            {
                Nv = (ClassNhanVien)(lstDanhSach.Items[lstDanhSach.SelectedIndex]);
                txtMaSo.Text = Nv.MaSo;
                txtHoTen.Text = Nv.HoTen;
                cboPhongBan.SelectedIndex = Nv.PhongBan;
                cboChucVu.SelectedIndex = Nv.ChucVu;
                txtNamSinh.Text = Nv.NamSinh.ToString();
                radNam.Checked = Nv.Phai == 1 ? true : false;
                radNu.Checked = Nv.Phai == 0 ? true : false;
                lblSoNV.Text=(lstDanhSach.SelectedIndex+1).ToString()+ "/" + lstDanhSach.Items.Count.ToString();
            }
        }

        private void txtNamSinh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNamSinh_Validated(object sender, EventArgs e)
        {
            if (txtNamSinh.TextLength < 4)
            {
                MessageBox.Show("Nam sinh phải đủ 4 chữ số");
                txtNamSinh.Focus();
            }
        }

        private void btnDau_Click(object sender, EventArgs e)
        {
            if (lstDanhSach.Items.Count > 0)
            {
                lstDanhSach.SelectedIndex = 0;
            }
        }

        private void btnCuoi_Click(object sender, EventArgs e)
        {
            if (lstDanhSach.Items.Count > 0)
            {
                lstDanhSach.SelectedIndex = lstDanhSach.Items.Count-1;
            }
        }

        private void btnTruoc_Click(object sender, EventArgs e)
        {
            int Vt = lstDanhSach.SelectedIndex;
            if (Vt > 0)
            {
                lstDanhSach.SelectedIndex = Vt - 1;
            }
        }

        private void btnSau_Click(object sender, EventArgs e)
        {
            int Vt = lstDanhSach.SelectedIndex;
            if (Vt >=0 && Vt < lstDanhSach.Items.Count-1)
            {
                lstDanhSach.SelectedIndex = Vt + 1;
            }
        }

        private void txtMaSo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) txtHoTen.Focus();
        }

        private void txtHoTen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) cboPhongBan.Focus();
        }

        private void cboPhongBan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) cboChucVu.Focus();
        }

        private void cboChucVu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) txtNamSinh.Focus();
        }

        private void txtNamSinh_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) grpPhai.Focus();
        }

        private void frmHoSoNV_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}