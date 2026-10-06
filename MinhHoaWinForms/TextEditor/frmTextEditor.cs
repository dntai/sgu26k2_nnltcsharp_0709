using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TextEditor
{
    public partial class frmTextEditor : Form
    {
        SmartMessage msg = new SmartMessage();
        public frmTextEditor()
        {
            InitializeComponent();
        }

        private void frmTextEditor_Load(object sender, EventArgs e)
        {
            VanBan.Text = msg.msgText;
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            msg.msgText = VanBan.Text;
            msg.Ghi();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}