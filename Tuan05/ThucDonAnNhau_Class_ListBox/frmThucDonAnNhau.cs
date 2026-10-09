using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ThucDonAnNhau_Class_ListBox
{
    public partial class frmThucDonAnNhau : Form
    {
        ClassMonAn Mon;
        frmSoLuong fr;
        long TongCong; //Dùng để tính tổng giá tiền rồi chuyển định dạng
        public frmThucDonAnNhau()
        {
            InitializeComponent();
        }

        private void frmThucDonAnNhau_Load(object sender, EventArgs e)
        {
            Mon = new ClassMonAn();
            Mon.TaoMonAn("Bê thui", 40000, 0);
            lstThucDon.Items.Add(Mon);

            //Tao mon an thu 2
            Mon = new ClassMonAn();
            Mon.TaoMonAn("Bò tái chanh", 20000, 0);
            lstThucDon.Items.Add(Mon);

            //Tao mon an thu 3
            Mon = new ClassMonAn();
            Mon.TaoMonAn("Bò lúc lắc", 35000, 0);
            lstThucDon.Items.Add(Mon);

            //Tao mon an thu 4
            Mon = new ClassMonAn();
            Mon.TaoMonAn("Dê xào lăn", 45000, 0);
            lstThucDon.Items.Add(Mon);

            //Tao mon an thu 5
            Mon = new ClassMonAn();
            Mon.TaoMonAn("Lẩu dê", 45000, 0);
            lstThucDon.Items.Add(Mon);

            //Tao mon an thu 6
            Mon = new ClassMonAn();
            Mon.TaoMonAn("Lẩu đuôi bò", 50000, 0);
            lstThucDon.Items.Add(Mon);

            //Tao mon an thu 7
            Mon = new ClassMonAn();
            Mon.TaoMonAn("Khổ qua chà bông", 20000, 0);
            lstThucDon.Items.Add(Mon);

            //Tao mon an thu 8
            Mon = new ClassMonAn();
            Mon.TaoMonAn("Rau muống xào tỏi", 20000, 0);
            lstThucDon.Items.Add(Mon);

            lblTongCong.Text = "0";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            if(lstThucDon.SelectedIndex != -1)
            {
                fr = new frmSoLuong();
                DialogResult ret = fr.ShowDialog();
                if (ret == DialogResult.OK)
                {
                    lblSoLuong.Text = fr.SoLuong.ToString();
                    Mon = (ClassMonAn)(lstThucDon.Items[lstThucDon.SelectedIndex]);
                    lblDonGia.Text = Mon.DonGia.ToString("#,##0");
                    Mon.SoLuong = int.Parse(lblSoLuong.Text);
                    TongCong += (Mon.DonGia * Mon.SoLuong);
                    lblTongCong.Text = TongCong.ToString("#,##0");
                    lstMonChon.Items.Add(Mon);
                    lstThucDon.Items.RemoveAt(lstThucDon.SelectedIndex);
                }
            }
        }

        private void btnBoChon_Click(object sender, EventArgs e)
        {
            if(lstMonChon.SelectedIndex != -1)
            {
                Mon = (ClassMonAn)(lstMonChon.Items[lstMonChon.SelectedIndex]);
                TongCong -= (Mon.DonGia*Mon.SoLuong);
                lblTongCong.Text = TongCong.ToString("#,##0");
                lstThucDon.Items.Add(Mon);
                lstMonChon.Items.RemoveAt(lstMonChon.SelectedIndex);
                Mon.SoLuong = 0;
                lblDonGia.Text = "0";
                lblSoLuong.Text = "0";
            }
        }

        private void btnBoChonHet_Click(object sender, EventArgs e)
        {
            if (lstMonChon.Items.Count > 0)
            {
                for (int i = 0; i < lstMonChon.Items.Count; i++)
                {
                    Mon = (ClassMonAn)(lstMonChon.Items[i]);
                    Mon.SoLuong = 0;
                    lstThucDon.Items.Add(Mon);
                }
                TongCong = 0;
                lblDonGia.Text = "0";
                lblSoLuong.Text = "0";
                lblTongCong.Text = "0";
                lstMonChon.Items.Clear();
            }
        }

        private void lstThucDon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lstThucDon.SelectedIndex != -1)
            {
                Mon = (ClassMonAn)(lstThucDon.Items[lstThucDon.SelectedIndex]);
                lblDonGia.Text = Mon.DonGia.ToString("#,##0");
                lblSoLuong.Text = "1";
            }
        }

        private void lstMonChon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lstMonChon.SelectedIndex != -1)
            {
                Mon = (ClassMonAn)(lstMonChon.Items[lstMonChon.SelectedIndex]);
                lblDonGia.Text = Mon.DonGia.ToString("#,##0");
                lblSoLuong.Text = Mon.SoLuong.ToString();
            }
        }
    }
}