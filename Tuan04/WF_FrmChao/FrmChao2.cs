using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NNLTCS.WinForms
{
    public partial class FrmChao2 : Form
    {
        public FrmChao2()
        {
            InitializeComponent();
        }

        private void btnChao_Click(object sender, EventArgs e)
        {
            lblChao.Text = string.Format("Xin chào, bạn {0}", txtHoTen.Text);
        }
    }
}
