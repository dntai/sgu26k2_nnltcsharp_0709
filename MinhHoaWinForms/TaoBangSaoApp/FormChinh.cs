using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TaoBangSaoApp
{
    public partial class FormChinh : Form
    {
        static int stt = 0;
        public FormChinh()
        {
            InitializeComponent();            
        }
               
        private void btnCopy_Click(object sender, EventArgs e)
        {
            FormChinh f = new FormChinh();
            stt++;
            f.Text = "Bản: " + stt.ToString();
            f.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}