using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;  //Thêm dòng này
namespace HelloApp
{
    public partial class Hello : Form
    {
        public Hello()
        {
            InitializeComponent();
        }

        private void btnHello_Click(object sender, EventArgs e)
        {
            if (txtHoTen.Text.Length > 0)
                MessageBox.Show("Xin chào " + txtHoTen.Text,"Hello");
            else
                MessageBox.Show("Xin cho biết họ tên","Hello");
        }

        private void chuoiLK1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                string chuoi = @"C:\Inetpub\wwwroot\postinfo.html";
                e.Link.Visited = true;
                Process.Start(chuoi);
            }
            catch (Exception ) { }
        }       

        private void chuoiLK2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            try
            {
                e.Link.Visited = true;

                System.Diagnostics.Process.Start("IExplore.exe", "http://www.yahoo.com");
            }
            catch (Exception ) { }
            
        }


        public void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();            
        }
    }
}