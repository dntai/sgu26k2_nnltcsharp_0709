using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLyTraiCay_ListBox
{
    public partial class frmQLTraiCay : Form
    {
        public frmQLTraiCay()
        {
            InitializeComponent();
        }

        private void DemSoLoai()
        {
            lblSoLoai.Text = lstTraiCay.Items.Count + " loai";
        }

        private void frmQLTraiCay_Load(object sender, EventArgs e)
        {
            string[] arrTraiCay = { "Mãng cầu", "Chôm chôm", "Nhãn", "Mít", "Đu đủ", "Sầu riêng" };
            lstTraiCay.Items.AddRange(arrTraiCay);
            //Không dùng lstTraiCay.DataSource = arrTraiCay vì chỉ dùng cho đối tượng;
            DemSoLoai();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTCMoi.TextLength == 0 || txtTCMoi.Text.Trim() == "")
            {
                MessageBox.Show("Cua co ten trai cay can them", "Them moi");
                return;
            }
            if(lstTraiCay.FindStringExact(txtTCMoi.Text) !=-1)
            {
                MessageBox.Show("Loại trái cây này đã có", "Thêm mới");
            }
            else
            {
                if(lstTraiCay.SelectedIndex >= 0)
                {
                    lstTraiCay.Items.Insert(lstTraiCay.SelectedIndex, txtTCMoi.Text);
                }
                else
                {
                    //lstTraiCay.Items.Insert(LstTraiCay.Items.Count, txtTCMoi.Text);
                    lstTraiCay.Items.Add(txtTCMoi.Text);
                }
                DemSoLoai();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult Tl;
            if(lstTraiCay.SelectedItems.Count > 0)
            {
                Tl = MessageBox.Show("Bạn có thật sự muốn xoá các mục chọn không?",
                                "Cảnh báo xoá dữ liệu", MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question);
                if(Tl == DialogResult.Yes)
                {
                    while(lstTraiCay.SelectedIndex!=-1)
                    {
                        lstTraiCay.Items.RemoveAt(lstTraiCay.SelectedIndex);
                    }
                    DemSoLoai();
                }
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            int KQTim = lstTraiCay.FindStringExact(txtTCTim.Text);
            if (KQTim != -1)
            {
                lblKetquaTim.Text = "Đây là loại thứ " + (KQTim + 1).ToString();
                lstTraiCay.SelectedIndex = -1;
                lstTraiCay.SelectedIndex = KQTim;
                txtTCTim.Select(0, txtTCTim.TextLength);
            }
            else
            {
                lblKetquaTim.Text = "Không có loại này trong danh sách";
                lstTraiCay.SelectedIndex = -1;
            }
        }
    }
}