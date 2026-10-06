using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AmDuong
{
    public partial class frmDLichALich : Form
    {
        int Can, Chi;
        string strCan, strChi;
        public frmDLichALich()
        {
            InitializeComponent();
        }

        private void ButtVIEW_Click(object sender, EventArgs e)
        {

            try
            {
                Can = System.Int32.Parse(TxtNamDL.Text) % 10;
                switch (Can)
                {
                    case 0:
                        {
                            strCan = "Canh";
                            break;
                        }
                    case 1:
                        {
                            strCan = "Tân";
                            break;
                        }
                    case 2:
                        {
                            strCan = "Nhâm";
                            break;
                        }
                    case 3:
                        {
                            strCan = "Qúy";
                            break;
                        }
                    case 4:
                        {
                            strCan = "Giáp";
                            break;
                        }
                    case 5:
                        {
                            strCan = "Ất";
                            break;
                        }
                    case 6:
                        {
                            strCan = "Bính";
                            break;
                        }
                    case 7:
                        {
                            strCan = "Đinh";
                            break;
                        }
                    case 8:
                        {
                            strCan = "Mậu";
                            break;
                        }
                    case -9:
                        {
                            strCan = "Tân";
                            break;
                        }
                    case -8:
                        {
                            strCan = "Nhâm";
                            break;
                        }
                    case -7:
                        {
                            strCan = "Qúy";
                            break;
                        }
                    case -6:
                        {
                            strCan = "Giáp";
                            break;
                        }
                    case -5:
                        {
                            strCan = "Ất";
                            break;
                        }
                    case -4:
                        {
                            strCan = "Bính";
                            break;
                        }
                    case -3:
                        {
                            strCan = "Đinh";
                            break;
                        }
                    case -2:
                        {
                            strCan = "Mậu";
                            break;
                        }
                    default:
                        {
                            strCan = "Kỷ";
                            break;
                        }
                }
                Chi = System.Int32.Parse(TxtNamDL.Text) % 12;
                switch (Chi)
                {
                    case 0:
                        {
                            strChi = "Thân";
                            break;
                        }
                    case 1:
                        {
                            strChi = "Dậu";
                            break;
                        }
                    case 2:
                        {
                            strChi = "Tuất";
                            break;
                        }
                    case 3:
                        {
                            strChi = "Hợi";
                            break;
                        }
                    case 4:
                        {
                            strChi = "Tý";
                            break;
                        }
                    case 5:
                        {
                            strChi = "Sửu";
                            break;
                        }
                    case 6:
                        {
                            strChi = "Dần";
                            break;
                        }
                    case 7:
                        {
                            strChi = "Mẹo";
                            break;
                        }
                    case 8:
                        {
                            strChi = "Thìn";
                            break;
                        }
                    case 9:
                        {
                            strChi = "Tỵ";
                            break;
                        }
                    case 10:
                        {
                            strChi = "Ngọ";
                            break;
                        }
                    case -11:
                        {
                            strChi = "Dậu";
                            break;
                        }
                    case -10:
                        {
                            strChi = "Tuất";
                            break;
                        }
                    case -9:
                        {
                            strChi = "Hợi";
                            break;
                        }
                    case -8:
                        {
                            strChi = "Tý";
                            break;
                        }
                    case -7:
                        {
                            strChi = "Sửu";
                            break;
                        }
                    case -6:
                        {
                            strChi = "Dần";
                            break;
                        }
                    case -5:
                        {
                            strChi = "Mẹo";
                            break;
                        }
                    case -4:
                        {
                            strChi = "Thìn";
                            break;
                        }
                    case -3:
                        {
                            strChi = "Tỵ";
                            break;
                        }
                    case -2:
                        {
                            strChi = "Ngọ";
                            break;
                        }
                    default:
                        {
                            strChi = "Mùi";
                            break;
                        }
                }
                LblNamAL.Text = strCan + " " + strChi;  
            }
            catch (Exception)
            {
                MessageBox.Show("Năm không hợp lệ", "Thông báo lỗi");
            }
            finally 
            {
                TxtNamDL.Focus();
                TxtNamDL.Select(0, TxtNamDL.TextLength);
            }
        }

        private void ButtCLOSE_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtNamDL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar!='-')
                e.Handled = true;
        }

    }
}