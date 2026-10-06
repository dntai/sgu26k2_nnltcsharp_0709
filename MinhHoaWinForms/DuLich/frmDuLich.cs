using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DuLich
{
    public partial class frmDuLich : Form
    {
        string phuongtien, loaive;
        public frmDuLich()
        {
            InitializeComponent();
        }

        private RadioButton LayPT(int n)
        {
            switch (n)
            {
                case 1:
                    {
                        return radMayBay;
                    }
                case 2:
                    {
                        return radTauHoa;
                    }
                default:
                    {
                        return radTauThuy;
                    }
            }
        }

        private RadioButton LayLV(int n)
        {
            switch (n)
            {
                case 1:
                    {
                        return radLoai1;
                    }
                case 2:
                    {
                        return radLoai2;
                    }
                default:
                    {
                        return radLoai3;
                    }
            }
        }


        private void btnDangKy_Click(object sender, EventArgs e)
        {
            
            //string phuongtien, loaive;
            if((txtDiaChi.TextLength == 0) || (txtDiaChi.Text.Trim()=="") || (txtHoTen.TextLength==0) || (txtHoTen.Text.Trim()==""))
            {
                MessageBox.Show("Thong tin chua hop le", "Nhac nho");
                return;
            }
            for (int i = 0; i <= 3; i++)
            {
                if (LayPT(i).Checked == true)
                {
                    phuongtien = LayPT(i).Text;
                }
            }
            for (int i = 0; i <= 3; i++)
            {
                if (LayLV(i).Checked == true)
                {
                    loaive = LayLV(i).Text;
                }
            }
            lblThongBao.Text = "Họ và tên khách hàng: " + txtHoTen.Text + "\n"
                             + "Địa chỉ: " + txtDiaChi.Text + "\n"
                             + "Đi bằng: " + phuongtien + "\n"
                             + "Vé " + loaive;
        }

        private void radMayBay_CheckedChanged(object sender, EventArgs e)
        {
            if (radMayBay.Checked == true)
            { 
                radLoai1.Text = "Loại 1:  1.500.000";
                radLoai2.Text = "Loại 2:  1.300.000";
                radLoai3.Text = "Loại 3:  1.100.000";
            }
        }

        private void radTauHoa_CheckedChanged(object sender, EventArgs e)
        {
            if (radTauHoa.Checked == true)
            {
                radLoai1.Text = "Loại 1:  1.000.000";
                radLoai2.Text = "Loại 2:    700.000";
                radLoai3.Text = "Loại 3:    500.000";
            }
        }

        private void radTauThuy_CheckedChanged(object sender, EventArgs e)
        {
            if (radTauThuy.Checked == true)
            {
                radLoai1.Text = "Loại 1:  1.200.000";
                radLoai2.Text = "Loại 2:    900.000";
                radLoai3.Text = "Loại 3:    700.000";
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMoi_Click(object sender, EventArgs e)
        {
            txtHoTen.Text = "";
            txtDiaChi.Text = "";
            radMayBay.Checked = true;
            radLoai2.Checked = true;
            lblThongBao.Text = "";
            txtHoTen.Focus();
        }
    }
}