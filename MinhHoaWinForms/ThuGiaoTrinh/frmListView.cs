using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ThuGiaoTrinh
{
    public partial class frmListView : Form
    {
        DirectoryInfo dir;  //Khai báo đối tượng Thư mục
        public frmListView()
        {
            InitializeComponent();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            try
            {
                int i = 0;
                this.lvThuMuc.Clear();
                // Sử dụng đối tượng thư mục          
                dir = new DirectoryInfo(@txtThuMuc.Text + "\\");
                txtThuMuc.Text = dir.FullName;
                // Khai báo các cột trong ListView
                this.lvThuMuc.Columns.Add("No", 30, HorizontalAlignment.Center);
                this.lvThuMuc.Columns.Add("Name", 120, HorizontalAlignment.Left);
                this.lvThuMuc.Columns.Add("Size", 50, HorizontalAlignment.Right);
                this.lvThuMuc.Columns.Add("Type", 120, HorizontalAlignment.Right);


                // Cho phép chọn nguyên dòng
                this.lvThuMuc.FullRowSelect = true;
                // Chọn chế độ trình bày
                this.lvThuMuc.View = View.Details;
                // Khai báo một mục (dòng) cho ListView
                ListViewItem item;
                // Duyệt qua các thư mục

                if (dir.Root.ToString().CompareTo(txtThuMuc.Text) != 0)
                {
                    lvThuMuc.Items.Add("..");
                }
                foreach (DirectoryInfo SubDir in dir.GetDirectories("*.*"))
                {
                    i += 1;
                    // Khởi tạo đối tượng ListView
                    item = new ListViewItem(i.ToString());
                    // Trình bày tên thư mục
                    item.SubItems.Add(SubDir.Name);
                    // Trình thuộc tính của thư mục
                    item.SubItems.Add(SubDir.Attributes.ToString());
                    // Thêm một dòng vào ListView
                    this.lvThuMuc.Items.Add(item);
                }

                // Duyệt qua các tập tin
                foreach (FileInfo f in dir.GetFiles("*.*"))
                {
                    i += 1;
                    // Khởi tạo một dòng
                    item = new ListViewItem(i.ToString());
                    // Trình bày tên tập tin
                    item.SubItems.Add(f.Name);
                    // Trình kích thước tập tin
                    item.SubItems.Add(f.Length.ToString());
                    // Trình thuộc tính của tập tin
                    item.SubItems.Add(f.Attributes.ToString());
                    // Thêm một dòng vào ListView
                    this.lvThuMuc.Items.Add(item);
                }
            }
            catch (DirectoryNotFoundException)  	//Neáu thö muïc khoâng hôïp leä
            {
                MessageBox.Show("Thu muc nay khong ton tai");
                return;
            }
            catch(IOException)
            {
                MessageBox.Show("Ổ này chưa có đĩa");
                return;
            }
            finally
            {
                txtThuMuc.Focus();
                txtThuMuc.Select(0, txtThuMuc.TextLength);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lvThuMuc_DoubleClick(object sender, EventArgs e)
        {
            if (lvThuMuc.FocusedItem.SubItems[0].Text == "..")
            {
                btnTroVe_Click(sender, e);
                return;
            }
            if (lvThuMuc.FocusedItem.SubItems[2].Text.IndexOf("Directory") != -1)
            {
                txtThuMuc.Text += @"\" + lvThuMuc.FocusedItem.SubItems[1].Text;
                btnXem_Click(sender, e);
            }
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            txtThuMuc.Text = dir.Root.FullName;
            btnXem_Click(sender, e);
        }

        private void txtThuMuc_Validated(object sender, EventArgs e)
        {
            while (txtThuMuc.Text.IndexOf(@":\\") != -1)
            {
                txtThuMuc.Text = txtThuMuc.Text.Replace(@":\\", @":\");
            }
            while (txtThuMuc.Text.IndexOf(@":.") != -1)
            {
                txtThuMuc.Text = txtThuMuc.Text.Replace(@":.", @":");
            }
        }
    }
}