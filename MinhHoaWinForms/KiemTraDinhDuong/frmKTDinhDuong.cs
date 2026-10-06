using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KiemTraDinhDuong
{
    public partial class frmKTDinhDuong : Form
    {
        public frmKTDinhDuong()
        {
            InitializeComponent();
        }

        private void KTNut()
        {
            if (lstMonAn.Items.Count == 0)
            {
                btnChon.Enabled = false;
                btnChonHet.Enabled = false;
            }
            else
            {
                btnChon.Enabled = true;
                btnChonHet.Enabled = true;
            }
            if (lstMonChon.Items.Count == 0)
            {
                btnBoChon.Enabled = false;
                btnBoHet.Enabled = false;
            }
            else
            {
                btnBoChon.Enabled = true;
                btnBoHet.Enabled = true;
            }
        }

        private void frmKTDinhDuong_Load(object sender, EventArgs e)
        {
            string[] arrCacMonAn = {"Bò bít tết", "Gà xối mỡ", "Cá lóc hấp", "Khoai tây chiên dòn",
                                    "Xà lách trộn trứng", "Cá chiên", "Thịt kho trứng", "Cá kho tộ",
                                    "Tàu hũ dồn thịt", "Trái cây"};
            lstMonAn.BeginUpdate();
            lstMonAn.Items.AddRange(arrCacMonAn);
            lstMonAn.EndUpdate();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            if(lstMonAn.SelectedIndex != -1)
            {
                lstMonChon.Items.Add(lstMonAn.SelectedItem);
                lstMonAn.Items.RemoveAt(lstMonAn.SelectedIndex);
                lblTest.Text = "";
            }
            KTNut();
        }
        private void btnBoChon_Click(object sender, EventArgs e)
        {
            if(lstMonChon.SelectedIndex != -1)
            {
                lstMonAn.Items.Add(lstMonChon.SelectedItem);
                lstMonChon.Items.RemoveAt(lstMonChon.SelectedIndex);
                lblTest.Text = "";
            }

            KTNut();
        }

        private void btnChonHet_Click(object sender, EventArgs e)
        {
            if (lstMonAn.SelectedIndices.Count > 0)
            {
                while (lstMonAn.SelectedIndex != -1)
                {
                    //Chuyển sang lstMonChon
                    lstMonChon.Items.Add(lstMonAn.SelectedItem);
                    //Xóa mục đã chuyển trong lstMonAn
                    lstMonAn.Items.Remove(lstMonAn.SelectedIndex);
                }
            }
            else
            {
                lstMonChon.Items.AddRange(lstMonAn.Items);
                lstMonAn.Items.Clear();
            }
            lblTest.Text = "";
            KTNut();
        }

        private void btnBoHet_Click(object sender, EventArgs e)
        {
            //Dung cach 2
            int SoPT = lstMonChon.SelectedIndices.Count;
            if (SoPT > 0)
            {
                while (SoPT > 0)
                {
                    //Chuyển sang lstMonAn
                    lstMonAn.Items.Add(lstMonChon.SelectedItem);
                    //Xóa mục đã chuyển trong lstMonAn
                    lstMonChon.Items.Remove(lstMonChon.SelectedItem);
                    SoPT--;
                }
            }
            else
            {
                lstMonAn.Items.AddRange(lstMonChon.Items);
                lstMonChon.Items.Clear();
            }
            lblTest.Text = "";

            KTNut();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            if(lstMonChon.Items.Count > 6)
            {
                lblTest.Text = "Bạn ăn quá nhiều thức ăn trong một bữa";
            }
            else
            {
                int Diem = 0;
                string NhanXet;
                for(int i = 0; i<=lstMonChon.Items.Count - 1; i++)
                {
                    if(String.Compare(lstMonChon.Items[i].ToString(), "Bò bít tết")==0) 
                    {
                        Diem = Diem + 20;
                    }
                    if (String.Compare(lstMonChon.Items[i].ToString(), "Gà xối mỡ") == 0) 
                    {
                        Diem = Diem + 25;
                    }
                    if (string.Compare(lstMonChon.Items[i].ToString(), "Cá lóc hấp") == 0)
                    {
                        Diem = Diem + 20;
                    }

                    if (String.Compare(lstMonChon.Items[i].ToString(), "Khoai tây chiên dòn") == 0)
                    {
                        Diem = Diem + 15;
                    }

                    if (String.Compare(lstMonChon.Items[i].ToString(), "Xà lách trộn trứng") == 0)
                    {
                        Diem = Diem + 5;
                    }
                    if (String.Compare(lstMonChon.Items[i].ToString(), "Cá chiên") == 0)
                    {
                        Diem = Diem + 15;                    }
                        if (string.Compare(lstMonChon.Items[i].ToString(), "Thịt kho trứng") == 0)
                    {
                        Diem = Diem + 20;
                    }
                    if (String.Compare(lstMonChon.Items[i].ToString(), "Cá kho tộ") == 0)
                    {
                        Diem = Diem + 10;
                    }

                    if (String.Compare(lstMonChon.Items[i].ToString(), "Tàu hũ dồn thịt") == 0)
                    {
                        Diem = Diem + 5;
                    }
                    if (String.Compare(lstMonChon.Items[i].ToString(), "Trái cây") == 0)
                        {
                            Diem = Diem + 5;
                        }
                }
                lblTest.Text = "Bạn đã chọn " + lstMonChon.Items.Count + " món ăn" +
                               "\n" + "Điểm: " + Diem + "\n";

                if(Diem <= 40)
                {
                    NhanXet = "Các món ăn này chưa đủ dinh dưỡng cho bạn";
                }
                else
                {
                    if (Diem <= 70)
                    {
                        NhanXet = "Bạn chọn thức ăn rất hợp lý";
                    }
                    else
                    {
                        NhanXet = "Bạn chọn quá thừa dinh dưỡng, không tốt cho sức khỏe";
                    }
                }
                lblTest.Text = lblTest.Text + NhanXet;
            }
        }
    }
}