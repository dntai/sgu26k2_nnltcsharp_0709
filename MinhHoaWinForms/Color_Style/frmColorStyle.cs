using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Color_Style
{
    public partial class frmColorStyle : Form
    {
        public frmColorStyle()
        {
            InitializeComponent();
        }

        private void DoiMau()
        {
            Color Mau;
            //Su dung phuong thuc tao mau bang 3 mau Red, Green, Blue
            Mau = Color.FromArgb(scrRed.Value, scrGreen.Value, scrBlue.Value);
            if (radChu.Checked == true)
            {
                txtVanBan.ForeColor = Mau;
            }
            else
            {
                txtVanBan.BackColor = Mau;
            }
            lblRed.Text = "Red    = " + scrRed.Value;
            lblGreen.Text = "Green = " + scrGreen.Value;
            lblBlue.Text = "Blue   = " + scrBlue.Value;
            HopMau.Color = Mau;
        }

        private void scrRed_Scroll(object sender, ScrollEventArgs e)
        {
            DoiMau();
        }

        private void scrGreen_Scroll(object sender, ScrollEventArgs e)
        {
            DoiMau();
        }

        private void scrBlue_Scroll(object sender, ScrollEventArgs e)
        {
            DoiMau();
        }

        private void radDam_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                txtVanBan.Font = new Font(txtVanBan.Font, FontStyle.Bold);
                lblThongBao.Text = "";
            }
            catch (Exception)
            {
                lblThongBao.Text = "Font chữ này không có kiểu Đậm";
            }
        }

        private void radNghieng_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                txtVanBan.Font = new Font(txtVanBan.Font, FontStyle.Italic);
                lblThongBao.Text = "";
            }
            catch (Exception)
            {
                lblThongBao.Text = "Font chữ này không có kiểu Nghiêng";
                lblThongBao.Text = "";
            }
        }

        private void radThuong_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                txtVanBan.Font = new Font(txtVanBan.Font, FontStyle.Regular);
            }
            catch (Exception)
            {
                lblThongBao.Text = "Font chữ này không có kiểu Thường";
            }
        }

        private void mnuFontStyle_Bold_Click(object sender, EventArgs e)
        {
            radDam.Checked = true;
        }

        private void mnuFontStyle_ITalic_Click(object sender, EventArgs e)
        {
            radNghieng.Checked = true;
        }

        private void mnuFontStyle_Regular_Click(object sender, EventArgs e)
        {
            radThuong.Checked = true;
        }

        private void mnuFont_Font_Click(object sender, EventArgs e)
        {
            HopFont.ShowDialog();
            if (this.HopFont.Font != null)
            {
                txtVanBan.Font = HopFont.Font;
            }
        }

        private void mnuFont_ForeColor_Click(object sender, EventArgs e)
        {
            HopMau.ShowDialog();
            txtVanBan.ForeColor = HopMau.Color;
            lblThongBao.Text = "Màu chữ đã chọn có số hiệu: " + HopMau.Color.ToArgb().ToString();
            radChu.Checked = true;
            scrRed.Value = HopMau.Color.R;
            scrGreen.Value = HopMau.Color.G;
            scrBlue.Value = HopMau.Color.B;
            lblRed.Text = "Red    = " + scrRed.Value;
            lblGreen.Text = "Green = " + scrGreen.Value;
            lblBlue.Text = "Blue   = " + scrBlue.Value;
        }

        private void mnuFont_BackColor_Click(object sender, EventArgs e)
        {
            HopMau.ShowDialog();
            txtVanBan.BackColor = HopMau.Color;
            lblThongBao.Text = "Màu nền đã chọn có số hiệu: " + HopMau.Color.ToArgb().ToString();
            radNen.Checked = true;
            scrRed.Value = HopMau.Color.R;
            scrGreen.Value = HopMau.Color.G;
            scrBlue.Value = HopMau.Color.B;
            lblRed.Text = "Red    = " + scrRed.Value;
            lblGreen.Text = "Green = " + scrGreen.Value;
            lblBlue.Text = "Blue   = " + scrBlue.Value;
        }

        private void mnuMessageBox_OK_Click(object sender, EventArgs e)
        {
            DialogResult DaNhan;
            DaNhan = MessageBox.Show("MessageBox OK", "MessageBox");
            lblThongBao.Text = "Bạn đã nhấn nút OK";
        }

        private void mnuMessageBox_OKCancel_Click(object sender, EventArgs e)
        {
            DialogResult DaNhan;
            DaNhan = MessageBox.Show("MessageBox OK", "MessageBox", MessageBoxButtons.OKCancel);
            if (DaNhan == DialogResult.OK)
            {
                lblThongBao.Text = "Bạn đã nhấn nút OK";
            }
            else
            {
                lblThongBao.Text = "Bạn đã nhấn nút Cancel";
            }
        }

        private void mnuMessageBox_YesNo_Click(object sender, EventArgs e)
        {
            DialogResult DaNhan;
            DaNhan = MessageBox.Show("MessageBox Yes-No", "MessageBox", MessageBoxButtons.YesNo);
            if (DaNhan == DialogResult.Yes)
            {
                lblThongBao.Text = "Bạn đã nhấn nút Yes";
            }
            else
            {
                lblThongBao.Text = "Bạn đã nhấn nút No";
            }
        }

        private void mnuMessageBox_RetryCancel_Click(object sender, EventArgs e)
        {
            DialogResult DaNhan;
            DaNhan = MessageBox.Show("MessageBox Retry-Cancel", "MessageBox", MessageBoxButtons.RetryCancel);
            if (DaNhan == DialogResult.Retry)
            {
                lblThongBao.Text = "Bạn đã nhấn nút Retry";
            }
            else
            {
                lblThongBao.Text = "Bạn đã nhấn nút Cancel";
            }
        }

        private void mnuMessageBox_YesNoCancel_Click(object sender, EventArgs e)
        {
            DialogResult DaNhan;
            DaNhan = MessageBox.Show("MessageBox Yes-No-Cancel", "MessageBox", MessageBoxButtons.YesNoCancel);
            switch (DaNhan)
            {
                case DialogResult.Yes: lblThongBao.Text = "Bạn đã nhấn nút Yes"; break;
                case DialogResult.No: lblThongBao.Text = "Bạn đã nhấn nút No"; break;
                default: lblThongBao.Text = "Bạn đã nhấn nút Cancel"; break;
            }
        }

        private void mnuMessageBox_AbortRetryIgnore_Click(object sender, EventArgs e)
        {
            DialogResult DaNhan;
            DaNhan = MessageBox.Show("MessageBox Abort-Retry-Ignore", "MessageBox", MessageBoxButtons.AbortRetryIgnore);
            switch (DaNhan)
            {
                case DialogResult.Abort: lblThongBao.Text = "Bạn đã nhấn nút Abort"; break;
                case DialogResult.Retry: lblThongBao.Text = "Bạn đã nhấn nút Retry"; break;
                default: lblThongBao.Text = "Bạn đã nhấn nút Ignore"; break;
            }
        }

        private void mnuSystem_Game_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("Freecell");
            }
            catch(Exception)
            {
                MessageBox.Show("Không có Game này trong hệ thống";
            }
        }

    }
}