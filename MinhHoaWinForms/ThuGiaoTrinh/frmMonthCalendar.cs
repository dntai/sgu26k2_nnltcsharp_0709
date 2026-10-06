using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace ThuGiaoTrinh
{
    public partial class frmMonthCalendar : Form
    {
        public frmMonthCalendar()
        {
            InitializeComponent();
        }

        private void frmMonthCalendar_Load(object sender, EventArgs e)
        {
            string[] a = new string[6];
            a.SetValue("Xanh", 0);
            a.SetValue("Do", 1);
            a.SetValue("Tim", 2);
            a.SetValue("Vang", 3);
            a.SetValue("Hong", 4);
            a.SetValue("Trang", 5);
            for (int i = 0; i <= a.GetUpperBound(0); i++)
            {
                MessageBox.Show(a[i]);
            }

            /*DirectoryInfo TMCha;
            TMCha = Directory.GetParent(@"C:\WINDOWS");
            MessageBox.Show(TMCha.ToString());

            //D:\BaiTap\C#\ThuGiaoTrinh\T huGiaoTrinh\bin
            MessageBox.Show(Directory.GetCurrentDirectory());
            Directory.SetCurrentDirectory(@"..");
            MessageBox.Show(Directory.GetCurrentDirectory());
            Directory.SetCurrentDirectory(@"\");
            MessageBox.Show(Directory.GetCurrentDirectory());*/
            /*if (Directory.Exists(@"D:\THUCHoI"))
            {
                DateTime d = Directory.GetCreationTime(@"D:\THUCHOI");
                MessageBox.Show(@"Ngay tao thu muc D:\THUCHOI la: " + d.ToString());
                if (d < DateTime.Today.AddDays(-100))
                {
                    Directory.SetCreationTime(@"D:\THUCHOI", DateTime.Today);
                    MessageBox.Show(@"Ngay moi cua thu muc D:\THUCHOI la: " + Directory.GetCreationTime(@"D:\THUCHOI").ToString());
                }
            }
            else
            {
                MessageBox.Show("Khong co thu muc nay");
                return;
            }
            try
            {
                DirectoryInfo d = new DirectoryInfo(@"D:\THUCHOI");
                d.Delete(true);
                MessageBox.Show("Xoa thanh cong");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi xoa thu muc " + ex.Message.ToString());
            }*/
        }        
    }
}