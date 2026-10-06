using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;


namespace HoSoNV_Class_File
{
    public partial class frmHoSoNV : Form
    {
        ClassNhanVien Nv;
        string DuongDan, TenTapTin;
        public frmHoSoNV()
        {
            InitializeComponent();
        }

        private void bntThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

         public void Doc(string sFileName)
         {
            StreamReader TapTinDoc; 
            FileStream TapTinTao; 
            string Dong;
            try
            {
                if(!File.Exists(sFileName) == true)
                {
                    TapTinTao = File.Create(sFileName);
                    TapTinTao.Close();
                }
                TapTinDoc = File.OpenText(sFileName);
                do
                {
                    Nv = new ClassNhanVien();
                    Dong = TapTinDoc.ReadLine();
                    Nv.MaSo = Dong;
                    Dong = TapTinDoc.ReadLine();
                    Nv.HoTen = Dong;
                    Dong = TapTinDoc.ReadLine();
                    Nv.PhongBan = Dong == null ? 0 : int.Parse(Dong);
                    Dong = TapTinDoc.ReadLine();
                    Nv.ChucVu = Dong == null ? 0 : int.Parse(Dong);
                    Dong = TapTinDoc.ReadLine();
                    Nv.NamSinh = Dong == null ? 0 : int.Parse(Dong);
                    Dong = TapTinDoc.ReadLine();
                    Nv.Phai = Dong == null ? 0 : int.Parse(Dong);
                    lstDanhSach.Items.Add(Nv);
                }while(Dong!=null);
                Nv = null;
                lstDanhSach.Items.RemoveAt(lstDanhSach.Items.Count - 1);
                TapTinDoc.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Khong the doc tap tin du lieu");
            }
            //TapTinDoc.Close(;)
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
                for( int i=0; i<lstDanhSach.Items.Count; i++)
                {
                    Nv = (ClassNhanVien)(lstDanhSach.Items[i]);
                    TapTinGhi.WriteLine(Nv.MaSo);
                    TapTinGhi.WriteLine(Nv.HoTen);
                    TapTinGhi.WriteLine(Nv.PhongBan);
                    TapTinGhi.WriteLine(Nv.ChucVu);
                    TapTinGhi.WriteLine(Nv.NamSinh);
                    TapTinGhi.WriteLine(Nv.Phai);
                }
                TapTinGhi.Close();
            }
            catch(Exception)
            {
                MessageBox.Show("Khong the luu tap tin");
                //Ghi = False;
            }

        }

        private bool KiemTraMaSo()
        {
            for (int i = 0; i < lstDanhSach.Items.Count; i++)
            {
                Nv = (ClassNhanVien)(lstDanhSach.Items[i]);
                if (String.Compare(Nv.MaSo, txtMaSo.Text, true) == 0)
                {
                    return true;
                }
            }
            return false;
        }

        private void frmHoSoNV_Load(object sender, EventArgs e)
        {
            cboPhongBan.SelectedIndex = 5;
            cboChucVu.SelectedIndex = 0;
            DuongDan = Application.StartupPath + @"\..";
            DuongDan += @"\..";
            TenTapTin = DuongDan + @"\Dulieu.txt";
            Doc(TenTapTin);
            lblSoNV.Text = lstDanhSach.Items.Count.ToString();
        }

        private void lstDanhSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstDanhSach.SelectedIndex != -1)
            {
                Nv = (ClassNhanVien)(lstDanhSach.Items[lstDanhSach.SelectedIndex]);
                txtMaSo.Text = Nv.MaSo;
                txtHoTen.Text = Nv.HoTen;
                cboPhongBan.SelectedIndex = Nv.PhongBan;
                cboChucVu.SelectedIndex = Nv.ChucVu;
                txtNamSinh.Text = Nv.NamSinh.ToString();
                radNam.Checked = Nv.Phai == 1 ? true : false;
                radNu.Checked = Nv.Phai == 0 ? true : false;
                //lblSoNV.Text = (lstDanhSach.SelectedIndex + 1).ToString() + "/" + lstDanhSach.Items.Count.ToString();
            }
        }

        private void btnTiepNhan_Click(object sender, EventArgs e)
        {
            if (txtMaSo.TextLength == 0 || txtMaSo.Text.Trim() == ""
               || txtHoTen.Text.Trim() == "" || txtHoTen.TextLength == 0)
            {
                MessageBox.Show("Chua du thong tin de tiep nhan", "Kiem tra nhap lieu");
                txtMaSo.Focus();
                return;
            }
            if (KiemTraMaSo() == true)
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
                lblSoNV.Text = lstDanhSach.Items.Count.ToString();
            }
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
                    lblSoNV.Text = lstDanhSach.Items.Count.ToString();
                    Nv = null;
                    if (lstDanhSach.Items.Count > 0)
                    {
                        lstDanhSach.SelectedIndex = lstDanhSach.Items.Count - 1;
                    }
                    btnThemMoi_Click(sender, e);
                }
            }
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

        private void btnLuu_Click(object sender, EventArgs e)
        {
            Ghi(TenTapTin);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Nv = (ClassNhanVien)(lstDanhSach.SelectedItem);
            Nv.MaSo = txtMaSo.Text;
            Nv.HoTen = txtHoTen.Text;
            Nv.PhongBan = cboPhongBan.SelectedIndex;
            Nv.ChucVu = cboChucVu.SelectedIndex;
            Nv.NamSinh = int.Parse(txtNamSinh.Text);
            Nv.Phai = radNam.Checked == true ? 1 : 0;

            ListBox LtBox = new ListBox();
            LtBox.DisplayMember = "Hoten";
            LtBox.Items.AddRange(lstDanhSach.Items);
            lstDanhSach.Items.Clear();
            lstDanhSach.Items.AddRange(LtBox.Items);
            lstDanhSach.Refresh();
            LtBox.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lstDanhSach.Items.Clear();
            Doc(TenTapTin);
            lblSoNV.Text = lstDanhSach.Items.Count.ToString();
        }
    }
}