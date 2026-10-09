using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;  //Khai báo để sử dụng ArrayList

namespace Combo_Class_ArrayList
{
    public partial class frmCongTy : Form
    {
        public frmCongTy()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCongTy_Load(object sender, EventArgs e)
        {
            //Tạo mảng chứa danh sách các mục chọn
            ArrayList DsCongTy = new ArrayList();
            DsCongTy.Add(new ClassCongTy("Minh Khai", "MK"));
            DsCongTy.Add(new ClassCongTy("Microsoft Corp", "MS"));
            DsCongTy.Add(new ClassCongTy("Yahoo Inc", "YH"));
            DsCongTy.Add(new ClassCongTy("Google", "GG"));
            DsCongTy.Add(new ClassCongTy("HP Computer Corp", "HP"));
            DsCongTy.Add(new ClassCongTy("Đồng Tâm Long An", "DT"));
            DsCongTy.Add(new ClassCongTy("Nam Long", "NL"));
            //Gán nguồn danh sách cho Combo là DsCongTy
            cboCongTy.DataSource = DsCongTy;
            //Quy định cột Ten sẽ cung cấp giá trị hiển thị trong ComboBox (Khóa)
            cboCongTy.DisplayMember = "Ten";
            //Quy định cột Ma cung cấp giá trị tương ứng với cột Ten
            cboCongTy.ValueMember = "Ma";
            cboCongTy_SelectedIndexChanged(sender, e);
        }

        private void cboCongTy_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblThongTinChon.Text = String.Format("{0}{1}Có mã số là {2}", cboCongTy.Text, "\n", cboCongTy.SelectedValue);

        }
    }
}