using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace DiemThi_Class_File
{
    public partial class frmBangDiem : Form
    {
        ClassThiSinh ts;
        string DuongDan, TenTapTin;
        bool ThayDoi;

        public frmBangDiem()
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
                    ts = new ClassThiSinh();
                    Dong = TapTinDoc.ReadLine();
                    ts.SBD = Dong;
                    Dong = TapTinDoc.ReadLine();
                    ts.HoTen = Dong;
                    Dong = TapTinDoc.ReadLine();
                    ts.NamSinh = Dong == null ? 0 : int.Parse(Dong);
                    Dong = TapTinDoc.ReadLine();
                    ts.Phai = Dong == null ? 0 : int.Parse(Dong);
                    Dong = TapTinDoc.ReadLine();
                    ts.DiaChi = Dong;
                    Dong = TapTinDoc.ReadLine();
                    ts.HDThi = Dong == null ? 0 : int.Parse(Dong);
                    Dong = TapTinDoc.ReadLine();
                    ts.DiemToan = Dong == null ? 0 : int.Parse(Dong);
                    Dong = TapTinDoc.ReadLine();
                    ts.DiemLy = Dong == null ? 0 : int.Parse(Dong);
                    Dong = TapTinDoc.ReadLine();
                    ts.DiemHoa = Dong == null ? 0 : int.Parse(Dong);
                    lstDanhSach.Items.Add(ts);
                } while (Dong != null);
                ts = null;
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
                    ts = (ClassThiSinh)(lstDanhSach.Items[i]);
                    TapTinGhi.WriteLine(ts.SBD);
                    TapTinGhi.WriteLine(ts.HoTen);
                    TapTinGhi.WriteLine(ts.NamSinh);
                    TapTinGhi.WriteLine(ts.Phai);
                    TapTinGhi.WriteLine(ts.DiaChi);
                    TapTinGhi.WriteLine(ts.HDThi);
                    TapTinGhi.WriteLine(ts.DiemToan);
                    TapTinGhi.WriteLine(ts.DiemLy);
                    TapTinGhi.WriteLine(ts.DiemHoa);
                }
                TapTinGhi.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Khong the luu tap tin");
            }

        }

        private bool KiemTraSBD()
        {
            for (int i = 0; i < lstDanhSach.Items.Count; i++)
            {
                ts = (ClassThiSinh)(lstDanhSach.Items[i]);
                if (String.Compare(ts.SBD, txtSBD.Text, true) == 0)
                {
                    return true;
                }
            }
            return false;
        }

        private void frmBangDiem_Load(object sender, EventArgs e)
        {
            DuongDan = Application.StartupPath + @"\..";
            DuongDan += @"\..";
            TenTapTin = DuongDan + @"\Dulieu.txt";
            Doc(TenTapTin);
            lblSoThiSinh.Text = lstDanhSach.Items.Count.ToString();
            if(lstDanhSach.Items.Count > 0)
            {
                lstDanhSach.SelectedIndex = 0;
            }
            else
            {
                radNam.Checked = true;
                cboHDThi.SelectedIndex = 0;
            }
            ThayDoi = false;
        }

        private void lstDanhSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstDanhSach.SelectedIndex != -1)
            {
                ts = (ClassThiSinh)(lstDanhSach.Items[lstDanhSach.SelectedIndex]);
                txtSBD.Text = ts.SBD;
                txtHoTen.Text = ts.HoTen;
                txtNamSinh.Text=ts.NamSinh.ToString();
                radNam.Checked = ts.Phai == 1 ? true : false;
                radNu.Checked = ts.Phai == 0 ? true : false;
                txtDiaChi.Text = ts.DiaChi;
                cboHDThi.SelectedIndex = ts.HDThi;
                txtToan.Text = ts.DiemToan.ToString();
                txtLy.Text = ts.DiemLy.ToString();
                txtHoa.Text = ts.DiemHoa.ToString();
            }
        }

        private void bntThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTiepNhan_Click(object sender, EventArgs e)
        {
            if (txtSBD.TextLength == 0 || txtSBD.Text.Trim() == ""
               || txtHoTen.Text.Trim() == "" || txtHoTen.TextLength == 0
               || txtDiaChi.Text.Trim() == "" || txtDiaChi.TextLength == 0)
            {
                MessageBox.Show("Chưa đủ thông tin để tiếp nhận", "Kiểm tra thông tin");
                txtSBD.Focus();
                return;
            }
            if (KiemTraSBD() == true)
            {
                MessageBox.Show("So báo danh nay da co, xin vui long nhap so khac", "Kiểm tra số báo danh");
                txtSBD.Select(0, txtSBD.TextLength);
                txtSBD.Focus();
                return;
            }
            else
            {
                if (DateTime.Now.Year - int.Parse(txtNamSinh.Text) < 18)
                {
                    DialogResult TL;
                    TL = MessageBox.Show("Chú ý\nThí sinh này chưa đủ 18 tuổi\nBạn có đồng ý tiếp nhận hay không",
                        "Tiếp nhận Thí sinh", MessageBoxButtons.YesNo);
                    if (TL == DialogResult.No) return;
                }
                ts = new ClassThiSinh();
                ts.SBD = txtSBD.Text;
                ts.HoTen = txtHoTen.Text;
                ts.NamSinh = int.Parse(txtNamSinh.Text);
                ts.Phai = radNam.Checked == true ? 1 : 0;
                ts.DiaChi = txtDiaChi.Text;
                ts.HDThi = cboHDThi.SelectedIndex;
                ts.DiemToan = int.Parse(txtToan.Text);
                ts.DiemLy = int.Parse(txtLy.Text);
                ts.DiemHoa = int.Parse(txtHoa.Text);
                lstDanhSach.Items.Add(ts);
                lstDanhSach.SelectedIndex = lstDanhSach.Items.Count - 1;
                lblSoThiSinh.Text = lstDanhSach.Items.Count.ToString();
                ThayDoi = true;
            }
        }

        private void txtNamSinh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtToan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtLy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtHoa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNamSinh_Validating(object sender, CancelEventArgs e)
        {
            if (txtNamSinh.TextLength < 4)
            {
                MessageBox.Show("Năm sinh phải đủ 4 chữ số", "Kiểm tra dữ liệu");
                e.Cancel = true;
            }
        }

        private void txtToan_Validating(object sender, CancelEventArgs e)
        {
            if (txtToan.TextLength == 0 || int.Parse(txtToan.Text) < 0 || int.Parse(txtToan.Text) > 10)
            {
                MessageBox.Show("Điểm không hợp lệ", "Kiểm tra dữ liệu");
                txtToan.Select(0, 2);
                e.Cancel = true;
            }
        }

        private void txtLy_Validating(object sender, CancelEventArgs e)
        {
            if (txtLy.TextLength == 0 || int.Parse(txtLy.Text) < 0 || int.Parse(txtLy.Text) > 10)
            {
                MessageBox.Show("Điểm không hợp lệ", "Kiểm tra dữ liệu");
                txtLy.Select(0, 2);
                e.Cancel = true;
            }
        }

        private void txtHoa_Validating(object sender, CancelEventArgs e)
        {
            if (txtHoa.TextLength == 0 || int.Parse(txtHoa.Text) < 0 || int.Parse(txtHoa.Text) > 10)
            {
                MessageBox.Show("Điểm không hợp lệ", "Kiểm tra dữ liệu");
                txtHoa.Select(0, 2);
                e.Cancel = true;
            }
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
                lblSoThiSinh.Text = lstDanhSach.Items.Count.ToString();
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

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            Ghi(TenTapTin);
            ThayDoi = false;
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            txtSBD.Clear();
            txtHoTen.Clear();
            txtNamSinh.Clear();
            radNam.Checked = true;
            txtDiaChi.Clear();
            cboHDThi.SelectedIndex = 0;
            txtToan.Text = "0";
            txtLy.Text = "0";
            txtHoa.Text = "0";
            txtSBD.Focus();
        }

        private void btnLoaiBo_Click(object sender, EventArgs e)
        {
            if (lstDanhSach.SelectedIndex != -1)
            {
                DialogResult Tl;
                Tl = MessageBox.Show("Bạn có thật sự muốn loại bỏ thí sinh này không?", "Cảnh báo xoá dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Tl == DialogResult.Yes)
                {

                    lstDanhSach.Items.RemoveAt(lstDanhSach.SelectedIndex);
                    lblSoThiSinh.Text = lstDanhSach.Items.Count.ToString();
                    ts = null;
                    if (lstDanhSach.Items.Count > 0)
                    {
                        lstDanhSach.SelectedIndex = lstDanhSach.Items.Count - 1;
                    }
                    ThayDoi = true;
                    btnThemMoi_Click(sender, e);
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            ts = (ClassThiSinh)(lstDanhSach.SelectedItem);
            ts.SBD = txtSBD.Text;
            ts.HoTen = txtHoTen.Text;
            ts.NamSinh = int.Parse(txtNamSinh.Text);
            ts.Phai = radNam.Checked == true ? 1 : 0;
            ts.DiaChi = txtDiaChi.Text;
            ts.HDThi = cboHDThi.SelectedIndex;
            ts.DiemToan = int.Parse(txtToan.Text);
            ts.DiemLy = int.Parse(txtLy.Text);
            ts.DiemHoa = int.Parse(txtHoa.Text);

            ListBox LtBox = new ListBox(); //Khai báo một đối tượng ListBox
            LtBox.DisplayMember = "Hoten";
            LtBox.Items.AddRange(lstDanhSach.Items);
            lstDanhSach.Items.Clear();
            lstDanhSach.Items.AddRange(LtBox.Items);
            lstDanhSach.Refresh();
            LtBox.Dispose();
            ThayDoi = true;
        }

        private void frmBangDiem_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void frmBangDiem_FormClosing(object sender, FormClosingEventArgs e)
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
                    if(TL==DialogResult.Cancel)
                    {
                        e.Cancel=true;
                    }
                }
            }
        }
    }
}