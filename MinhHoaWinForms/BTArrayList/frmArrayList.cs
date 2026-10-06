using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace BTArrayList
{
    public partial class frmArrayList : Form
    {
        int SoLoai;
        ArrayList CacLoaiTraiCay = new ArrayList();
        frmSoLoai fr = new frmSoLoai();
        frmCacLoai frm ;
        public frmArrayList()
        {
            InitializeComponent();
        }

        private void btnTrim_Click(object sender, EventArgs e)
        {
            CacLoaiTraiCay.TrimToSize();
            lblTrim.Text = "Số phần tử thực có: " 
                + CacLoaiTraiCay.Count + "\n"
                + "Khả năng ArrayList có thể chứa: " 
                + CacLoaiTraiCay.Capacity;
        }

        private void frmArrayList_Load(object sender, EventArgs e)
        {
            bool Trung;
            fr.ShowDialog();
            SoLoai=int.Parse(fr.Controls["txtSoLoai"].Text);
            for(int i = 1; i <= SoLoai; i++)
            {
                Trung = false;
                frm = new frmCacLoai();
                frm.Controls["lblLoaiThu"].Text = "Loại thứ: " + i;
                frm.ShowDialog();
                for (int a = 0; a < CacLoaiTraiCay.Count; a++)
                {
                    if(string.Compare(frm.Controls["txtLoai"].Text, CacLoaiTraiCay[a].ToString(),true) == 0)
                    {
                        MessageBox.Show("Loại trái cây này đã có, xin vui lòng nhập loại khác", "Kiểm tra");
                        Trung = true;
                        break;
                    }
                }
                if (Trung == true)
                {
                    i--;
                    continue;
                }
                CacLoaiTraiCay.Add(frm.Controls["txtLoai"].Text);
            }

            for(int j = 0; j< CacLoaiTraiCay.Count; j++)
            {
                lblTraiCay.Text = lblTraiCay.Text + CacLoaiTraiCay[j] + "\n";
            }
            lblBanDau.Text = "Số phần tử thực có: "
                + CacLoaiTraiCay.Count + "\n"
                + "Khả năng ArrayList có thể chứa: "
                + CacLoaiTraiCay.Capacity;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            CacLoaiTraiCay.Clear();
            CacLoaiTraiCay.TrimToSize();
            lblClear.Text = "Số phần tử thực có: "
                + CacLoaiTraiCay.Count + "\n"
                + "Khả năng ArrayList có thể chứa: "
                + CacLoaiTraiCay.Capacity;
        }
    }
}