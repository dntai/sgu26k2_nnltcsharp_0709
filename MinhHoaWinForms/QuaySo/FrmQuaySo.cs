using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuaySo
{
    public partial class FrmQuaySo : Form
    {
        Random Rnd = new Random(); //Nếu muốn gieo mầm thì chỉ định số vào trong Random(so)
        public FrmQuaySo()
        {
            InitializeComponent();
        }

        private void DongHo1_Tick(object sender, EventArgs e)
        {
            int so;
            so = Rnd.Next(0, 10);            
            lblQuay1.Text = so.ToString();
            so = Rnd.Next(0, 10);
            lblQuay2.Text = so.ToString();
            so = Rnd.Next(0, 10);
            lblQuay3.Text = so.ToString();
        }
        
        private void btnQuay_Click(object sender, EventArgs e)
        {
            lblTrungThuong.Text = "";
            picTien.Visible= false;
            DongHo1.Start();
            DongHo2.Start();
        }

        private void DongHo2_Tick(object sender, EventArgs e)
        {
            int Trung  = 0;
            long soTrung;
            DongHo1.Stop();
            DongHo2.Stop();
            if (txtDat1.Text==lblQuay1.Text)
                Trung ++;
            if (txtDat2.Text==lblQuay2.Text)
                Trung ++ ;
            if (txtDat3.Text==lblQuay3.Text)
                Trung ++ ;

            if (Trung == 3)
            {
                soTrung = Trung * 100000 * 3;
                lblKetQua.Text = "Trúng thưởng đặc biệt";
                lblTrungThuong.Text = soTrung.ToString("#,##0 VNĐ");
            }
            else if (Trung == 0)
                { 
                    lblKetQua.Text = "Không trúng thưởng";
                    lblTrungThuong.Text = "";
                }
                else
                {
                    lblKetQua.Text = "Trúng thưởng";
                    soTrung = Trung * 100000;
                    lblTrungThuong.Text = soTrung.ToString("#,##0 VNĐ");
                }

            if(Trung > 0)
                picTien.Visible = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        private void txtDat1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)&& !char.IsControl(e.KeyChar))
                e.Handled=true;
        }

        private void txtDat2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtDat3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        
    }
}