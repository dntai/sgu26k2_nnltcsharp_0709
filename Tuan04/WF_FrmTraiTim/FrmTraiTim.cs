using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NNLTCSharp.WinForms
{
    public partial class FrmTraiTim : Form
    {
        Point point1 = new Point();
        Point point2 = new Point();

        public FrmTraiTim()
        {
            InitializeComponent();
        }

        private void FrmTraiTim_MouseDown(object sender, MouseEventArgs e)
        {
            point1 = e.Location;
        }

        private void FrmTraiTim_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                point2 = e.Location;
                int dx = point2.X - point1.X;
                int dy = point2.Y - point1.Y;
                this.Location = new Point(this.Location.X + dx, this.Location.Y + dy);
            }
        }
    }
}
