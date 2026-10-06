using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ThuGiaoTrinh
{
    public partial class FrmSo2 : Form
    {
        public FrmSo2()
        {
            InitializeComponent();
        }

        private void FrmSo2_Load(object sender, EventArgs e)
        {
            int i;
            for (i = 0; i<=8; i++)
            {
                Rectangle r= new Rectangle(i, 2 * i, 520, 250);
                lstA.Items.Add(r);
            }

            lstValMem.ValueMember = "X";
            for (i = 0; i<=8;i++)
            {
                Rectangle rec = new Rectangle(i, 2 * i, 520, 250);
                lstValMem.Items.Add(rec);
            }
            MessageBox.Show(lstValMem.Items[0].ToString());
        }

        private void cboTraiCay_KeyDown(object sender, KeyEventArgs e)
        {  
            string item;
            if (e.KeyCode == Keys.Enter)
            {   
                item = this.cboTraiCay.Text;
                if (string.IsNullOrEmpty(item))
                {
                    MessageBox.Show("Khong ten de tim");
                }
                else
                {
                    int idx;
                    if (this.cboTraiCay.FindStringExact(item) == -1)
                    {
                        idx = this.cboTraiCay.Items.Add(item);
                    }
                    else
                    {
                        MessageBox.Show("Trai cay nay da co");
                        idx = this.cboTraiCay.Items.IndexOf(item);
                    }
                    this.cboTraiCay.SelectedIndex = idx;
                    SendKeys.Send("{F4}");
                }
            }

        }     
    }
}