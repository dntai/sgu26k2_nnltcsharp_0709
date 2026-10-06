using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TachHoTen_Class
{
    public partial class Form1 : Form
    {
        ClassHoTen ht = new ClassHoTen();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string TT = "  anh   em   ta  ";
            lblThu.Text=ht.ChuanHoTen(ref TT);
        }
    }
}