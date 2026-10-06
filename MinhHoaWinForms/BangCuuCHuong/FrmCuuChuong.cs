using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BangCuuChuong
{
    public partial class FrmCuuChuong : Form
    {
        public FrmCuuChuong()
        {
            InitializeComponent();
        }

        private void FrmCuuChuong_Load(object sender, EventArgs e)
        {
            //String[] arrCap={"2","3","4","5","6","7","8","9"};
            //lstCap.Items.AddRange(arrCap);
            int[] arrCap ={ 2, 3, 4, 5, 6, 7, 8, 9 };
            lstCap.DataSource = arrCap;

        }

        private void lstCap_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblKetQua.Text = "";
            for(int i=1;i<=9;i++)
            {
                //lblKetQua.Text +=  lstCap.SelectedItem + " X " + i + " = "
                //                + (int.Parse(lstCap.SelectedItem.ToString()) * i) + "\n";
                lblKetQua.Text += lstCap.SelectedItem + " X " + i + " = "
                                + (int)(lstCap.SelectedItem) * i + "\n";
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}