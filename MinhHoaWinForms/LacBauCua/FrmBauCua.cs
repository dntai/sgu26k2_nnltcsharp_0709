using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace LacBauCua
{
    public partial class FrmBauCua : Form
    {
        Random Rnd = new Random();
        public FrmBauCua()
        {
            InitializeComponent();
        }

        void Chaychu()
        {
            for(int I = 1; I <= lblLac.Text.Length * 50; I++)
            {
                lblLac.Text = lblLac.Text.Substring(1) + lblLac.Text.Substring(0, 1);
                for (long J = 1; J <= 50000; J++) ;
                lblLac.Refresh();
            }
        }

        PictureBox GanHinh(int n)
        {
            switch (n)
            {
                case 1:
                    {
                        return Hinh1;
                    }
                case 2:
                    {
                        return Hinh2;
                    }
                case 3:
                    {
                        return Hinh3;
                    }
                case 4:
                    {
                        return Hinh4;
                    }
                case 5:
                    {
                        return Hinh5;
                    }
                default:
                        return Hinh6;
                    
            }
        }

        TextBox LayDat(int n) 
        {
            switch (n)
            {
                case 1:
                    return txtDat1;
                case 2:
                    return txtDat2;
                case 3:
                    return txtDat3;
                case 4:
                    return txtDat4;
                case 5:
                    return txtDat5;
                case 6:
                    return txtDat6;
                default:
                    return null;
            }
        }

        Label LayTrung(int n) 
        {
            switch (n)
            {
                case 1:
                    return lblTrung1;
                case 2:
                    return lblTrung2;
                case 3:
                    return lblTrung3;
                case 4:
                    return lblTrung4;
                case 5:
                    return lblTrung5;
                default:
                    return lblTrung6;
                    
            }
        }



        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblLac_Click(object sender, EventArgs e)
        {
            int Y, X, Z;
            double So = 0;
            if(txtDat1.Text == "" && txtDat2.Text == "" && txtDat3.Text == "" 
                   && txtDat4.Text == "" && txtDat5.Text == "" && txtDat6.Text == "")
            {
                MessageBox.Show("Phai dat tien roi moi quay");
                return;
            }
            Chaychu();
            X = Rnd.Next(1,6);
            Y = Rnd.Next(1,6);
            Z = Rnd.Next(1,6);
            HINHTRUNG1.Image = GanHinh(X).Image;
            HINHTRUNG2.Image = GanHinh(Y).Image;
            HINHTRUNG3.Image = GanHinh(Z).Image;
            So = Int32.Parse(LayTrung(X).Text == "" ? "0" : LayTrung(X).Text) + Int32.Parse(LayDat(X).Text == "" ? "0" : LayDat(X).Text);
            LayTrung(X).Text = So.ToString();
            So = Int32.Parse(LayTrung(Y).Text == "" ? "0" : LayTrung(Y).Text) + Int32.Parse(LayDat(Y).Text == "" ? "0" : LayDat(Y).Text);
            LayTrung(Y).Text = So.ToString();
            So = Int32.Parse(LayTrung(Z).Text == "" ? "0" : LayTrung(Z).Text) + Int32.Parse(LayDat(Z).Text == "" ? "0" : LayDat(Z).Text);
            LayTrung(Z).Text = So.ToString();
            lblLac.Enabled = false;
            btnXoa.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtDat1.Text = "";
            txtDat2.Text = "";
            txtDat3.Text = "";
            txtDat4.Text = "";
            txtDat5.Text = "";
            txtDat6.Text = "";
            lblTrung1.Text = "";
            lblTrung2.Text = "";
            lblTrung3.Text = "";
            lblTrung4.Text = "";
            lblTrung5.Text = "";
            lblTrung6.Text = "";
            lblLac.Enabled = true;
        }

        private void txtDat1_KeyPress(object sender, KeyPressEventArgs e)
        {
             if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
             {
                e.Handled = true;
             }
        }

        private void txtDat2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDat3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDat4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDat5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDat6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

    }
}