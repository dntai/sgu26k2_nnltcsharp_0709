using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace prjDuLich_Class_Fle
{
    public partial class frmDangKy : Form
    {
        ClassThongTinDK tt;
        string DuongDan, TenTapTin;
        int[] arrDonGia ={ 1000000, 1500000, 2200000, 3500000, 4500000, 7000000 };
        int iDG;
        bool ThayDoi;
        public frmDangKy()
        {
            InitializeComponent();
        }

        public void Doc(string sFileName)
        {
            StreamReader TapTinDoc;
            FileStream TapTinTao;
            string Dong;
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
                    tt = new ClassThongTinDK();
                    Dong = TapTinDoc.ReadLine();
                    tt.MaDK = Dong;
                    Dong = TapTinDoc.ReadLine();
                    tt.HoTen= Dong;
                    Dong = TapTinDoc.ReadLine();
                    tt.DangKy= Dong == null ? 0 : int.Parse(Dong);
                    Dong = TapTinDoc.ReadLine();
                    tt.SoNguoi = Dong == null ? 0 : int.Parse(Dong);
                    Dong = TapTinDoc.ReadLine();
                    tt.Tour = Dong == null ? 0 : int.Parse(Dong);
                    Dong = TapTinDoc.ReadLine();
                    tt.PhuongTien = Dong == null ? 0 : int.Parse(Dong);
                    lstDanhSach.Items.Add(tt);
                } while (Dong != null);
                tt = null;
                lstDanhSach.Items.RemoveAt(lstDanhSach.Items.Count - 1);
                TapTinDoc.Close();
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
                for (int i = 0; i < lstDanhSach.Items.Count; i++)
                {
                    tt = (ClassThongTinDK)(lstDanhSach.Items[i]);
                    TapTinGhi.WriteLine(tt.MaDK);
                    TapTinGhi.WriteLine(tt.HoTen);
                    TapTinGhi.WriteLine(tt.DangKy);
                    TapTinGhi.WriteLine(tt.SoNguoi);
                    TapTinGhi.WriteLine(tt.Tour);
                    TapTinGhi.WriteLine(tt.PhuongTien);
                }
                TapTinGhi.Close();
                MessageBox.Show("Đã lưu vào File", "Lưu trữ");
            }
            catch (Exception)
            {
                MessageBox.Show("Khong the luu tap tin");
            }

        }
        
        private void LayDG_TT()
        {
            iDG = arrDonGia[cboTour.SelectedIndex * 2 + cboPhuongTien.SelectedIndex];
            lblDonGia.Text = iDG.ToString("#,##0");
            lblThanhTien.Text = (int.Parse(txtSoNguoi.Text) * iDG).ToString("#,##0");
        }
        private bool KTMaDK()
        {
            for (int i = 0; i < lstDanhSach.Items.Count; i++)
            {
                tt = (ClassThongTinDK)(lstDanhSach.Items[i]);
                if (string.Compare(txtMaDK.Text, tt.MaDK,true)==0)
                {
                    return true;
                }
            }
            return false;
        }

        private void frmDangKy_Load(object sender, EventArgs e)
        {
            DuongDan = Application.StartupPath + @"\..";
            DuongDan += @"\..";
            TenTapTin = DuongDan + @"\Dulieu.txt";
            Doc(TenTapTin);
            cboTour.SelectedIndex = 1;
            cboPhuongTien.SelectedIndex = 0;
            LayDG_TT();
            if (lstDanhSach.Items.Count > 0)
            {
                lstDanhSach.SelectedIndex = 0;
            }
            else
            {
                lblMauTin.Text = "0/0";
            }
        }

        private void cboTour_SelectedIndexChanged(object sender, EventArgs e)
        {
            LayDG_TT();
        }

        private void cboPhuongTien_SelectedIndexChanged(object sender, EventArgs e)
        {
            LayDG_TT();
        }

        private void btnChapNhan_Click(object sender, EventArgs e)
        {
            if (txtMaDK.Text.Trim() == "" || txtMaDK.TextLength == 0 ||
                txtHoTen.Text.Trim() == "" || txtHoTen.TextLength == 0 ||
                txtSoNguoi.TextLength == 0 || int.Parse(txtSoNguoi.Text) <= 0)
            {
                MessageBox.Show("Thông tin chưa hợp lệ", "Kiểm tra thông tin nhập");
                return;
            }
            if (KTMaDK() == true)
            {
                MessageBox.Show("Mã đăng ký này đã có, xin vui lòng cho mã đăng ký khác");
                txtMaDK.Focus();
                txtMaDK.Select(0, txtMaDK.TextLength);
                return;
            }
            tt = new ClassThongTinDK();
            tt.MaDK = txtMaDK.Text;
            tt.HoTen = txtHoTen.Text;
            tt.DangKy = radCaNhan.Checked == true ? 1 : 0;
            tt.SoNguoi = int.Parse(txtSoNguoi.Text);
            tt.Tour = cboTour.SelectedIndex;
            tt.PhuongTien = cboPhuongTien.SelectedIndex;
            lstDanhSach.Items.Add(tt);
            ThayDoi = true;
            lstDanhSach.SelectedIndex = lstDanhSach.Items.Count - 1;
            lblMauTin.Text = lstDanhSach.SelectedIndex + 1 + "/" + lstDanhSach.Items.Count;
        }

        private void txtSoNguoi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            txtMaDK.Clear();
            txtHoTen.Clear();
            radCaNhan.Checked = true;
            txtSoNguoi.Text = "1";
            cboTour.SelectedIndex = 1;
            cboPhuongTien.SelectedIndex = 0;
            LayDG_TT();
            txtMaDK.Focus();
            btnChapNhan.Enabled = true;
            btnLuuSuaDoi.Enabled = false;
        }

        private void lstDanhSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstDanhSach.SelectedIndex != -1)
            {
                tt = (ClassThongTinDK)(lstDanhSach.Items[lstDanhSach.SelectedIndex]);
                txtMaDK.Text = tt.MaDK;
                txtHoTen.Text = tt.HoTen;
                radCaNhan.Checked = tt.DangKy == 1 ? true : false;
                radTapThe.Checked = tt.DangKy == 0 ? true : false;
                txtSoNguoi.Text = tt.SoNguoi.ToString();
                cboTour.SelectedIndex = tt.Tour;
                cboPhuongTien.SelectedIndex = tt.PhuongTien;
                LayDG_TT();
                lblMauTin.Text = lstDanhSach.SelectedIndex + 1 + "/" + lstDanhSach.Items.Count;
                btnChapNhan.Enabled = false;
                btnLuuSuaDoi.Enabled = true;
            }
        }

        private void txtSoNguoi_TextChanged(object sender, EventArgs e)
        {
            LayDG_TT();
        }

        private void txtSoNguoi_Validating(object sender, CancelEventArgs e)
        {
            if (int.Parse(txtSoNguoi.Text) <= 0)
            {
                MessageBox.Show("Số người không hợp lệ", "Kiểm tra số liệu");
                e.Cancel = true;
            }
        }

        private void BtnLoaiBo_Click(object sender, EventArgs e)
        {
            if (lstDanhSach.SelectedIndex != -1)
            {
                DialogResult TL;
                TL = MessageBox.Show("Bạn có thật sự muốn loại bỏ  tên khách hàng này không",
                                    "Cảnh báo xoá dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (TL == DialogResult.Yes)
                {
                    lstDanhSach.Items.RemoveAt(lstDanhSach.SelectedIndex);
                    ThayDoi = true;
                    btnThemMoi_Click(sender, e);
                    LayDG_TT();
                    lblMauTin.Text = lstDanhSach.SelectedIndex + 1 + "/" + lstDanhSach.Items.Count;
                }
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
            lstDanhSach.SelectedIndex = lstDanhSach.Items.Count-1;
        }

        private void btnTruoc_Click(object sender, EventArgs e)
        {
            if (lstDanhSach.SelectedIndex > 0)
            {
                lstDanhSach.SelectedIndex--;
            }
        }

        private void btnSau_Click(object sender, EventArgs e)
        {
            if (lstDanhSach.SelectedIndex < lstDanhSach.Items.Count-1)
            {
                lstDanhSach.SelectedIndex++;
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            int KQTim = lstDanhSach.FindStringExact(txtTenTim.Text);
            if (KQTim != -1)
            {
                lstDanhSach.SelectedIndex = -1;
                lstDanhSach.SelectedIndex = KQTim;
                txtTenTim.Select(0, txtTenTim.TextLength);
            }
            else
            {
                MessageBox.Show("Không có tên khách hàng này trong danh sách","Tìm kiếm");
                lstDanhSach.SelectedIndex = -1;
            }
        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            Ghi(TenTapTin);
            
        }

        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            DialogResult Tl;
            Tl = MessageBox.Show("Bạn có muốn loại bỏ danh sách hiện có và lấy lại danh sách từ File?",
                                "Cảnh báo: Xoá cả danh sách", MessageBoxButtons.YesNo);
            if (Tl == DialogResult.Yes)
            {
                lstDanhSach.Items.Clear();
                Doc(TenTapTin);
                if (lstDanhSach.Items.Count > 0)
                {
                    lstDanhSach.SelectedIndex = 0;
                }
                else
                {
                    btnThemMoi_Click(sender, e);
                }
                ThayDoi = false;
            }
        }

        private void btnLuuSuaDoi_Click(object sender, EventArgs e)
        {
            if (lstDanhSach.SelectedIndex != -1)
            {
                tt = (ClassThongTinDK)(lstDanhSach.SelectedItem);
                tt.MaDK = txtMaDK.Text;
                tt.HoTen = txtHoTen.Text;
                tt.DangKy = radCaNhan.Checked == true ? 1 : 0;
                tt.SoNguoi = int.Parse(txtSoNguoi.Text);
                tt.Tour = cboTour.SelectedIndex;
                tt.PhuongTien = cboPhuongTien.SelectedIndex;


                ListBox LtBox = new ListBox();
                LtBox.DisplayMember = "Hoten";
                LtBox.Items.AddRange(lstDanhSach.Items);
                lstDanhSach.Items.Clear();
                lstDanhSach.Items.AddRange(LtBox.Items);
                lstDanhSach.Refresh();
                LtBox.Dispose();
            }
            else
            {
                MessageBox.Show("Chưa chọn mục nào trong danh sách", "Lưu sửa đổi");
            }
        }

        private void frmDangKy_FormClosing(object sender, FormClosingEventArgs e)
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

        private void frmDangKy_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void txtMaDK_Leave(object sender, EventArgs e)
        {
            if (txtMaDK.Text.Trim() != "" && txtMaDK.TextLength > 0)
            {
                txtMaDK.Text = txtMaDK.Text.ToUpper();
            }
        }
    }
}