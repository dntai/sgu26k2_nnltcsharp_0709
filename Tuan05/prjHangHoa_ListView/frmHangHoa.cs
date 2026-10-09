using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace prjHangHoa_ListView
{
    public partial class frmHangHoa : Form
    {
        float fVAT =0.1f, fThanhTien=0.0f;
        float Thue = 0f;
        int i = 0;
        ListViewItem item;
        string[] GiaDung ={ "Kim Hằng", "Lê Tuấn", "Ngọc Hiền" };
        string[] TinHoc={"Hoàn Long", "Phong Vũ", "Thành Nhân"};
        string[] VanPhong ={ "Thiên Long", "Bến Nghé", "Bic" };
        public frmHangHoa()
        {
            InitializeComponent();
        }

        private string TongCong()
        {
            float Tong = 0f;
            for (int t = 0; t < lvHangHoa.Items.Count; t++)
            {
                Tong += float.Parse(lvHangHoa.Items[t].SubItems[8].Text);
            }
            return Tong.ToString("#,##0.00#");
        }

        private void btnChapNhan_Click(object sender, EventArgs e)
        {
            if (txtMaHang.Text.Trim().Length == 0 || txtMaHang.Text == "" ||
                txtTenHang.Text.Trim().Length == 0 || txtTenHang.Text == "" ||
                txtDonGia.TextLength == 0 || int.Parse(txtDonGia.Text) <= 0 ||
                txtSoLuongTon.TextLength == 0 || int.Parse(txtSoLuongTon.Text) < 0)
            {
                MessageBox.Show("Thông tin chưa hợp lệ", "Kiểm tra dữ liệu");
                txtMaHang.Focus();
                txtMaHang.Select(0, txtMaHang.TextLength);
                return;
            }
            if (KTMaso() == true)
            {
                MessageBox.Show("Mã hàng này đã có, xin vui lòng cho mã số khác", "Kiểm tra mã số");
                txtMaHang.Focus();
                txtMaHang.Select(0, txtMaHang.TextLength);
                return;
            }
            i++;
            item=new ListViewItem(i.ToString());
            item.SubItems.Add(txtMaHang.Text);
            item.SubItems.Add(txtTenHang.Text);
            item.SubItems.Add(cboLoaiHang.Text);
            item.SubItems.Add(cboNSX.Text);
            item.SubItems.Add(txtDonGia.Text);
            Thue = chkVAT.Checked == true ? fVAT : 0;
            item.SubItems.Add(chkVAT.Checked == true ? (fVAT * 100).ToString() + "%" : "0");
            item.SubItems.Add(txtSoLuongTon.Text);
            fThanhTien = int.Parse(txtDonGia.Text) * int.Parse(txtSoLuongTon.Text) * (1 + Thue);
            item.SubItems.Add(fThanhTien.ToString("#,##0.00#"));
            lvHangHoa.Items.Add(item);
            lblTongTriGia.Text = TongCong();
        }

        private void KTLoai()
        {
            cboNSX.Items.Clear();
            int loai;
            loai = cboLoaiHang.SelectedIndex;
            switch (loai)
            {
                case 0:
                    {
                        cboNSX.Items.AddRange(GiaDung);
                        break;
                    }
                case 1:
                    {
                        cboNSX.Items.AddRange(TinHoc);
                        break;
                    }
                default:
                    {
                        cboNSX.Items.AddRange(VanPhong);
                        break;
                    }
            }
            cboNSX.SelectedIndex = 0;
        }

        private bool KTMaso()
        {
            for (int k = 0; k < lvHangHoa.Items.Count; k++)
            {
                if (txtMaHang.Text == lvHangHoa.Items[k].SubItems[1].Text)
                {
                    return true;
                }
            }
            return false;
        }

        private void frmHangHoa_Load(object sender, EventArgs e)
        {
            cboLoaiHang.SelectedIndex = 0;
            KTLoai();
            cboNSX.SelectedIndex = 0;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cboLoaiHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            KTLoai();
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            txtMaHang.Clear();
            txtTenHang.Clear();
            cboLoaiHang.SelectedIndex=0;
            KTLoai();
            txtDonGia.Text = "0";
            chkVAT.Checked = true;
            txtSoLuongTon.Text = "0";
            txtMaHang.Focus();
        }

        private void btnLoaiBo_Click(object sender, EventArgs e)
        {
            lvHangHoa.Items.Remove(lvHangHoa.FocusedItem);
            DanhLaiSo();
            lblTongTriGia.Text = TongCong();
        }

        private void DanhLaiSo()
        {
            for (i = 0; i < lvHangHoa.Items.Count; i++)
            {
                lvHangHoa.Items[i].SubItems[0].Text = (i + 1).ToString();
            }
        }

        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled=true;
            }
        }

        private void txtSoLuongTon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled=true;
            }
        }

        private void lvHangHoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvHangHoa.FocusedItem != null)
            {
                txtMaHang.Text = lvHangHoa.FocusedItem.SubItems[1].Text;
                txtTenHang.Text = lvHangHoa.FocusedItem.SubItems[2].Text;
                cboLoaiHang.Text = lvHangHoa.FocusedItem.SubItems[3].Text;
                cboNSX.Text = lvHangHoa.FocusedItem.SubItems[4].Text;
                txtDonGia.Text = lvHangHoa.FocusedItem.SubItems[5].Text;
                chkVAT.Checked = lvHangHoa.FocusedItem.SubItems[6].Text == "0" ? false : true;
                txtSoLuongTon.Text = lvHangHoa.FocusedItem.SubItems[7].Text;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            lvHangHoa.FocusedItem.SubItems[1].Text = txtMaHang.Text;
            lvHangHoa.FocusedItem.SubItems[2].Text = txtTenHang.Text;
            lvHangHoa.FocusedItem.SubItems[3].Text = cboLoaiHang.Text;
            lvHangHoa.FocusedItem.SubItems[4].Text = cboNSX.Text;
            lvHangHoa.FocusedItem.SubItems[5].Text = txtDonGia.Text;
            lvHangHoa.FocusedItem.SubItems[6].Text = chkVAT.Checked == true ? (fVAT * 100).ToString() + "%" : "0";
            lvHangHoa.FocusedItem.SubItems[7].Text = txtSoLuongTon.Text;
            Thue = chkVAT.Checked == true ? fVAT : 0f;
            fThanhTien = int.Parse(txtDonGia.Text) * int.Parse(txtSoLuongTon.Text) * (1 + Thue);
            lvHangHoa.FocusedItem.SubItems[8].Text = fThanhTien.ToString();
            lblTongTriGia.Text = TongCong();
        }

    }
}