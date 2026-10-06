using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TextBox
{
    public partial class FrmTimKiem : Form
    {
        int BatDau=0, ViTriBD = 0 ;
        string NoiDung = "";
        public FrmTimKiem()
        {
            InitializeComponent();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            BatDau = txtVanBan.Text.IndexOf(txtChuoiTim.Text, StringComparison.OrdinalIgnoreCase); //Khong phan biet HOA thuong

            if (BatDau >= 0)
            {
                txtVanBan.SelectionStart = BatDau;
                txtVanBan.SelectionLength= txtChuoiTim.TextLength;
                txtVanBan.Focus();
                BatDau += txtChuoiTim.TextLength;
            }
            else
            {
                MessageBox.Show("Không có chuỗi này trong văn bản");
                BatDau = 0;
            }
        }

        private void btnTimTiep_Click(object sender, EventArgs e)
        {
            int Timtiep ;
            if (BatDau >= txtVanBan.Text.Length) 
            {
                MessageBox.Show("Đã hết văn bản");
                BatDau = 0;
                return;
            }
        //*'Timtiep = txtVanBan.Text.IndexOf(txtChuoiTim.Text, StringComparison.OrdinalIgnoreCase); //Khong phan biet HOA thuong
            Timtiep = txtVanBan.Text.IndexOf(txtChuoiTim.Text, BatDau, StringComparison.OrdinalIgnoreCase); //Khong phan biet HOA thuong

            if (Timtiep >= 0)
            {
                txtVanBan.SelectionStart = Timtiep;
                txtVanBan.SelectionLength = txtChuoiTim.TextLength;
                txtVanBan.Focus();
                BatDau = Timtiep + txtChuoiTim.TextLength;
            }
            else
            {
                MessageBox.Show("Không còn tìm thấy chuỗi này");
                BatDau = 0;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnThayThe_Click(object sender, EventArgs e)
        {
            
            if (txtChuoiTim.Text == "")
            {
                MessageBox.Show("Chưa có chuỗi cần tìm");
                return;
            }
            BatDau = txtVanBan.Text.IndexOf(txtChuoiTim.Text, ViTriBD, StringComparison.OrdinalIgnoreCase);
            if (BatDau >= 0)
            {
                ViTriBD = BatDau + txtChuoiTim.TextLength;
                txtVanBan.SelectionStart = BatDau;
                txtVanBan.SelectionLength = txtChuoiTim.TextLength; //ChuoiCanTim.Length
                txtVanBan.Focus();
                txtVanBan.SelectedText = txtVanBan.SelectedText.Replace(txtVanBan.SelectedText, txtChuoiThay.Text);
            }
            else
            {
                MessageBox.Show("Không có chuỗi này trong văn bản");
                ViTriBD = 0;
            }
        }

        private void btnThayTatCa_Click(object sender, EventArgs e)
        {
            // Tìm không phân biệt chữ hoa và thường
            if (txtChuoiTim.Text == "")
            {
                MessageBox.Show("Chưa có chuỗi cần tìm", "Tìm và thay thế tất cả");
                return;
            }
            BatDau = txtVanBan.Text.IndexOf(txtChuoiTim.Text, ViTriBD, StringComparison.OrdinalIgnoreCase);
            if (BatDau == -1)
            {
                MessageBox.Show("Không có chuỗi này trong văn bản", "Tìm và thay thế tất cả");
                return;
            }
            while (BatDau >= 0)
            {
                txtVanBan.SelectionStart = BatDau;
                txtVanBan.SelectionLength = txtChuoiTim.TextLength; //ChuoiCanTim.Length
                txtVanBan.Focus();
                txtVanBan.SelectedText = txtVanBan.SelectedText.Replace(txtVanBan.SelectedText, txtChuoiThay.Text);
                ViTriBD = BatDau + txtChuoiTim.TextLength;
                BatDau = txtVanBan.Text.IndexOf(txtChuoiTim.Text, ViTriBD, StringComparison.OrdinalIgnoreCase);     
            }
            //txtVanBan.Text = txtVanBan.Text.Replace(txtChuoiTim.Text, txtChuoiThay.Text);
        }

        private void FrmTimKiem_Load(object sender, EventArgs e)
        {
            NoiDung = txtVanBan.Text;
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            txtVanBan.Text = NoiDung;
            txtChuoiTim.Text = "";
            txtChuoiThay.Text = "";
            txtChuoiTim.Focus();
        }

    }
}