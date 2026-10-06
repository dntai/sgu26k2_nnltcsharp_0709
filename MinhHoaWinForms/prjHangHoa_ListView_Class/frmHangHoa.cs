using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace prjHangHoa_ListView_File
{
    public partial class frmHangHoa : Form
    {
        float fVAT =0.1f, fThanhTien=0.0f;
        float Thue = 0f;
        int i = 0; //Tạo số thứ tự
        ListViewItem item;
        bool ThayDoi = false; //Theo dõi đã lưu vào FIe chưa
        string DuongDan, TenTapTin;
        string[] GiaDung ={ "Kim Hằng", "Lê Tuấn", "Ngọc Hiền" };
        string[] TinHoc={"Hoàn Long", "Phong Vũ", "Thành Nhân"};
        string[] VanPhong ={ "Thiên Long", "Bến Nghé", "Bic" };
        public frmHangHoa()
        {
            InitializeComponent();
        }

        public void Doc(string sFileName)
        {
            StreamReader TapTinDoc;
            FileStream TapTinTao;
            string Dong="";
            try
            {
                if (!File.Exists(sFileName) == true)
                {
                    TapTinTao = File.Create(sFileName);
                    TapTinTao.Close();
                }
                TapTinDoc = File.OpenText(sFileName);
                do
                {
                    i++;
                    item = new ListViewItem(i.ToString());
                    for (int j = 1; j <= 8; j++)
                    {
                        Dong = TapTinDoc.ReadLine(); //MaHang
                        item.SubItems.Add(Dong); 
                    }
                    lvHangHoa.Items.Add(item);
                } while (Dong != null);
                i--; // giảm i vì có một dòng rỗng được đưa vào ListView
                lvHangHoa.Items.RemoveAt(lvHangHoa.Items.Count-1); //Loại bỏ dòng rỗng
                TapTinDoc.Close();
                lblTongTriGia.Text = TongCong();
            }
            catch (Exception)
            {
                MessageBox.Show("Khong the doc tap tin du lieu");
            }
        }

        public void Ghi(string sFileName)
        {
            StreamWriter TapTinGhi;
            FileStream TapTinTao;
            try
            {
                TapTinTao = File.Create(sFileName);
                TapTinTao.Close();
                TapTinGhi = File.AppendText(sFileName);
                for (int j = 0; j < lvHangHoa.Items.Count; j++)
                {
                    for (int k = 1; k <= 8; k++)
                    {
                        TapTinGhi.WriteLine(lvHangHoa.Items[j].SubItems[k].Text);
                    }
                }
                TapTinGhi.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Khong the luu tap tin");
                //Ghi = False;
            }

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
            ThayDoi = true;
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
            DuongDan = Application.StartupPath + @"\..";
            DuongDan += @"\..";
            TenTapTin = DuongDan + @"\Dulieu.txt";
            Doc(TenTapTin);
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
            btnSua.Enabled = false;
            btnChapNhan.Enabled = true;
        }

        private void DanhLaiSo()
        {
            for (i = 0; i < lvHangHoa.Items.Count; i++)
            {
                lvHangHoa.Items[i].SubItems[0].Text = (i + 1).ToString();
            }
        }

        private void btnLoaiBo_Click(object sender, EventArgs e)
        {
            if (lvHangHoa.FocusedItem != null)
            {
                DialogResult TL;
                TL = MessageBox.Show("Bạn có thật sự muốn loại bỏ mặt hàng này không?", "Cảnh báo xoá dữ liệu",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (TL == DialogResult.Yes)
                {
                    lvHangHoa.Items.Remove(lvHangHoa.FocusedItem);
                    DanhLaiSo();
                    lblTongTriGia.Text = TongCong();
                    btnThemMoi_Click(sender, e);
                    ThayDoi = true;
                }
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
                btnSua.Enabled = true;
                btnChapNhan.Enabled = false;
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
            lvHangHoa.FocusedItem.SubItems[8].Text = fThanhTien.ToString("#,##0.00");
            lblTongTriGia.Text = TongCong();
            btnChapNhan.Enabled = true;
            btnSua.Enabled = false;
            ThayDoi = true;
        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            Ghi(TenTapTin);
            ThayDoi = false;     
        }

        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            DialogResult TL;
            TL = MessageBox.Show("Bạn có muốn loại bỏ danh sách hiện tại\nvà lấy lại danh sách từ File không?",
                                 "Cảnh báo: xoá toàn bộ danh sách hiện tại", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (TL == DialogResult.Yes)
            {
                lvHangHoa.Items.Clear();
                Doc(TenTapTin);
                ThayDoi = false;
                btnThemMoi_Click(sender, e);
            }
        }

        private void frmHangHoa_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ThayDoi == true)
            {
                DialogResult TL;
                TL = MessageBox.Show("Danh sách đã có thay đổi, bạn có muốn lưu lại sự thay đổi này không?",
                                    "Thoát chương trình", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (TL == DialogResult.Yes)
                {
                    Ghi(TenTapTin);
                }
                else
                {
                    if (TL == DialogResult.Cancel)
                    {
                        e.Cancel = true;
                    }
                }
            }
        }

        private void frmHangHoa_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

    }
}