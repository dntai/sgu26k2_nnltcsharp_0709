using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NNLTCSharp.WinForms
{
    public partial class MainForm1 : Form
    {
        public MainForm1()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ban da click vao nut OK.");
        }

        private void MainForm1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ban da click vao form.");
            
        }

        private void MainForm1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Ban muon dong form hay khong?", "Thong bao", 
                        MessageBoxButtons.YesNo, 
                        MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
