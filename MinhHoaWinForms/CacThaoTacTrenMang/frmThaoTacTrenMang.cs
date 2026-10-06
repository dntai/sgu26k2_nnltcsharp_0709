using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CacThaoTacTrenMang
{
    public partial class frmThaoTacTrenMang : Form
    {
        int[] MangA = new int[20];
        int SoPT=9;
        Random rd = new Random();
        public frmThaoTacTrenMang()
        {
            InitializeComponent();
        }

        private void HoanVi(ref int a, ref int b)
        { 
            //int tam;
            //tam = a
            //a = b
            //b = tam
            a = a + b;
            b = a - b;
            a = a - b;
        }

        private void XoaCacNhan()
        {
            lblNho.Text = "";
            lblLon.Text = "";
            lblChan.Text = "";
            lblLe.Text = "";
            lblTongChan.Text = "";
            lblTongLe.Text = "";
            lblViTri.Text = "";
        }

        private void frmThaoTacTrenMang_Load(object sender, EventArgs e)
        { 
            for (int i = 0; i <= SoPT; i++)
            {
                MangA[i] = rd.Next(0, 51);
                lblGiaTri.Text += MangA[i].ToString() + "\n";
            }
            lblGiaTri.Text = lblGiaTri.Text.Substring(0, lblGiaTri.Text.Length - 1);
            lblTongsoPT.Text = (SoPT+1).ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnNho_Click(object sender, EventArgs e)
        {
            int Min = MangA[0];
            for(int i = 1; i <= SoPT; i++)
            {
                if(MangA[i] < Min)
                {
                    Min = MangA[i];
                }
            }
            lblNho.Text = Min.ToString();
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            SoPT = 9;
            lblTongsoPT.Text = (SoPT+1).ToString();
            XoaCacNhan();
            lblGiaTri.Text = "";
            MangA = new int[20];
            for(int i = 0; i<= SoPT; i++)
            {
                MangA[i] = rd.Next(0, 51);
                lblGiaTri.Text += MangA[i] + "\n";
            }
        }

        private void btnLon_Click(object sender, EventArgs e)
        {
            int Max = MangA[0];
            for (int i = 1; i <= SoPT; i++)
            {
                if (MangA[i] > Max)
                {
                    Max = MangA[i];
                }
            }
            lblLon.Text = Max.ToString();
        }

        private void btnChan_Click(object sender, EventArgs e)
        {
            lblChan.Text = "";
            for(int i=0; i <= SoPT; i++)
            {
                if(MangA[i] % 2 == 0)
                {
                    lblChan.Text += MangA[i] + ", ";
                }
            }
            try
            {
                lblChan.Text = lblChan.Text.Substring(0, lblChan.Text.Length - 2);
            }
            catch(Exception)
            {
                lblChan.Text = "";
            }
        }

        private void btnLe_Click(object sender, EventArgs e)
        {
            lblLe.Text = "";
            for (int i = 0; i <= SoPT; i++)
            {
                if (MangA[i] % 2 == 1)
                {
                    lblLe.Text += MangA[i] + ", ";
                }
            }
            try
            {
                lblLe.Text = lblLe.Text.Substring(0, lblLe.Text.Length - 2);
            }
            catch (Exception)
            {
                lblLe.Text = "";
            }
        }

        private void btnTongChan_Click(object sender, EventArgs e)
        {
            int TongChan = 0;
            lblTongChan.Text = "";
            for (int i = 0; i <= SoPT; i++)
            {
                if (MangA[i] % 2 == 0)
                {
                    TongChan += MangA[i];
                }
            }
            lblTongChan.Text = TongChan.ToString();
        }

        private void btnTongLe_Click(object sender, EventArgs e)
        {
            int TongLe = 0;
            lblTongLe.Text = "";
            for (int i = 0; i <= SoPT; i++)
            {
                if (MangA[i] % 2 == 1)
                {
                    TongLe += MangA[i];
                }
            }
            lblTongLe.Text = TongLe.ToString();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            int GT;
            lblViTri.Text = "";
            if(txtGTTim.Text == "")
            {
                MessageBox.Show("Khong co gia tri de tim", "Du lieu nhap sai");
                return;
            }
            GT = int.Parse(txtGTTim.Text);
            for( int i=0; i <= SoPT; i++)
            {
                if(MangA[i] == GT)
                {
                    lblViTri.Text += i + 1 + ", ";
                }
            }
            if(lblViTri.Text != "")
            {
                lblViTri.Text = lblViTri.Text.Substring(0, lblViTri.Text.Length - 2);
            }
            else
            {
                lblViTri.Text = "Không có giá trị này trong mảng";
            }
            txtGTTim.Select(0, txtGTTim.TextLength);
            txtGTTim.Focus();
        }

        private void txtGTTim_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnChen_Click(object sender, EventArgs e)
        {
            int i, GT, VT;
            if(SoPT == MangA.GetUpperBound(0))
            {
                MessageBox.Show("Het cho chen", "Canh bao");
                return;
            }
            if(txtVTChen.Text == "" || txtGTChen.Text == "")
            {
                MessageBox.Show("Thong tin chen khong du", "Loi chen gia tri");
                return;
            }
            if(int.Parse(txtVTChen.Text) <= 0 || int.Parse(txtVTChen.Text) > SoPT + 2)
            {
                MessageBox.Show("Chen tu 1 -> " + (SoPT + 2) , "Loi chen gia tri");
                return;
            }
            GT = int.Parse(txtGTChen.Text);
            VT = int.Parse(txtVTChen.Text);
            SoPT += 1;

            for(i=SoPT; i>=VT; i--)
            {
                MangA[i] = MangA[i - 1];
            }
            MangA[i] = GT;
            //SoPT += 1;
            lblGiaTri.Text = "";
            for(i = 0; i<= SoPT; i++)
            {
                lblGiaTri.Text += MangA[i] + "\n";
            }
            XoaCacNhan();
            lblGiaTri.Text = lblGiaTri.Text.Substring(0, lblGiaTri.Text.Length - 1);
            lblTongsoPT.Text = (SoPT+1).ToString();
        }

        private void txtGTChen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtVTChen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnSXTang_Click(object sender, EventArgs e)
        {
            lblGiaTri.Text = "";
            XoaCacNhan();
            for(int i = 0; i < SoPT; i++)
            {
                for (int j = i + 1; j <= SoPT; j++)
                {
                    if (MangA[i] > MangA[j])
                    {
                        HoanVi(ref MangA[i], ref MangA[j]);
                    }
                }

            }

            for(int i = 0; i <= SoPT; i++)
            {
                lblGiaTri.Text += MangA[i] + "\n";
            }
            lblGiaTri.Text =lblGiaTri.Text.Substring(0, lblGiaTri.Text.Length - 1);
        }

        private void btnSXGiam_Click(object sender, EventArgs e)
        {
            lblGiaTri.Text = "";
            XoaCacNhan();
            for (int i = 0; i < SoPT; i++)
            {
                for (int j = i + 1; j <= SoPT; j++)
                {
                    if (MangA[i] < MangA[j])
                    {
                        HoanVi(ref MangA[i], ref MangA[j]);
                    }
                }
            }
            
            for (int i = 0; i <= SoPT; i++)
            {
                lblGiaTri.Text += MangA[i] + "\n";
            }
            lblGiaTri.Text = lblGiaTri.Text.Substring(0, lblGiaTri.Text.Length - 1);
        }
    }
}