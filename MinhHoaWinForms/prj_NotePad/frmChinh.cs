using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace prj_NotePad
{
    public partial class frmChinh : Form
    {
        public static string sTenTapTin="";
        public static bool Dong = true;
        public bool Thoat;
        public static frmVanBan fr ;

        public frmChinh()
        {
            InitializeComponent();
        }

        private void mFile_New_Click(object sender, EventArgs e)
        {
            if(Dong == false)
            {
                if(fr.RtxtVanBan.Modified == true)
                {
                    DialogResult Tl;
                    Tl = MessageBox.Show("Noi dung tap tin da thay doi, ban co muon luu lai khong?", "Mo moi", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if(Tl == DialogResult.Yes)
                    {
                        mFile_Save_Click(sender, e);
                        if(Thoat == true) return;
                    }
                    else
                    {
                        if(Tl == DialogResult.Cancel) return;
                    }
                }
            }
            else
            { 
                fr = new frmVanBan();
                fr.MdiParent = this;
                fr.Show();
                fr.WindowState = FormWindowState.Maximized;
            }
            fr.RtxtVanBan.Clear();
            fr.Text = "Untitled";
            fr.RtxtVanBan.Modified = false;
            sTenTapTin = "";
        }

        private void mFile_Open_Click(object sender, EventArgs e)
        {
            if(Dong == false)
            {
                if(fr.RtxtVanBan.Modified == true)
                {
                    DialogResult Tl;
                    Tl = MessageBox.Show("Noi dung tap tin da thay doi, ban co muon luu lai khong?", "Mo moi", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if(Tl == DialogResult.Yes)
                    {
                        mFile_Save_Click(sender, e);
                        if(Thoat == true) return;
                    }
                    else
                    {
                        if(Tl == DialogResult.Cancel) return;
                    }
                }
            }
            else
            {
                fr = new frmVanBan();
                fr.MdiParent = this;
                //fr.Show();
                fr.WindowState = FormWindowState.Maximized;
            }
            MoFile.FileName = "";
            MoFile.ShowDialog();
            if (MoFile.FileName == "")
            {
                Thoat = true;
                return;
            }
            else
            {
                sTenTapTin = MoFile.FileName;
                fr.Show();
                fr.RtxtVanBan.LoadFile(sTenTapTin);
                fr.Text = sTenTapTin;
                fr.RtxtVanBan.Modified = false;
            }
        }

        private void mFile_Save_Click(object sender, EventArgs e)
        {
            try
            {
                //Trong truong hop soan tap tin moi
                if (sTenTapTin == "")
                {
                    this.LuuFile.ShowDialog();  //Mo hop thoai Luu file
                    if (LuuFile.FileName == "")
                    {
                        Thoat = true;
                        return;
                    }
                    sTenTapTin = LuuFile.FileName; //Xac dinh ten tap tin moi can tao
                }
                //Truong hop mo tap tin da co
                fr.RtxtVanBan.SaveFile(sTenTapTin); //Ghi noi dung moi hieu chinh vao tap tin
                fr.Text = sTenTapTin;  //Hien thi ten tap tin moi len thanh tieu de
                fr.RtxtVanBan.Modified = false;  //Tinh trang thay doi da duoc xu ly
            }
            catch (Exception) { }
        }

        private void mFile_SaveAs_Click(object sender, EventArgs e)
        {
            try
            {
                if (sTenTapTin != "")
                {
                    fr.RtxtVanBan.SaveFile(sTenTapTin);
                }
                LuuFile.ShowDialog();  //Mo hop thoai luu file
                if (LuuFile.FileName == "")
                {
                    Thoat = true;
                    return;
                }
                sTenTapTin = LuuFile.FileName; //Xac dinh ten tap tin se luu
                fr.RtxtVanBan.SaveFile(sTenTapTin);  //Tao/ mo va luu tap tin
                fr.Text = sTenTapTin; //Hien thi ten tap tin len tieu de Form
                fr.RtxtVanBan.Modified = false; //Tinh trang thay doi da duoc xu ly
            }
            catch (Exception) { }
        }

        private void mFile_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmChinh_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Dong == true) Application.Exit();
        }

        private void mEdit_Undo_Click(object sender, EventArgs e)
        {
            fr.RtxtVanBan.Undo();
        }

        private void mEdit_Cut_Click(object sender, EventArgs e)
        {
            fr.RtxtVanBan.Cut();
        }

        private void mEdit_Paste_Click(object sender, EventArgs e)
        {
            try
            {
                fr.RtxtVanBan.Paste();
            }
            catch (Exception)
            {}
        }

        private void mEdit_Copy_Click(object sender, EventArgs e)
        {
            fr.RtxtVanBan.Copy();
        }

        private void mEdit_Delete_Click(object sender, EventArgs e)
        {
            DialogResult Tl;
            Tl = MessageBox.Show("Ban co that su muon xoa het van ban khong?", "Xoa het van ban", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(Tl == DialogResult.Yes)
            {
                fr.RtxtVanBan.SelectAll();
                SendKeys.Send("{Del}");
            }
        }

        private void mEdit_SelectAll_Click(object sender, EventArgs e)
        {
            fr.RtxtVanBan.SelectAll();
        }

        private void mEdit_TimeDate_Click(object sender, EventArgs e)
        {
            fr.RtxtVanBan.Text += DateTime.Now.ToString();
        }

        private void frmChinh_GotFocus(object sender, EventArgs e)
        
        {
            if(Dong == true)
            {
                mFile_Save.Enabled = false;
                mFile_SaveAs.Enabled = false;
                mEdit.Enabled = false;
                mFormat.Enabled = false;
            }
            else
            {
                mFile_Save.Enabled = true;
                mFile_SaveAs.Enabled = true;
                mEdit.Enabled = true;
                mFormat.Enabled = true;
            }
        }

        private void frmChinh_Load(object sender, EventArgs e)
        {
            fr = new frmVanBan();
            fr.MdiParent = this;
            fr.Show();
            fr.WindowState = FormWindowState.Maximized;
        }

        private void mEdit_Click(object sender, EventArgs e)
        {
            frmChinh_GotFocus(sender, e);
        }

        private void mFormat_Font_Click(object sender, EventArgs e)
        {
            HopFont.ShowDialog();
            fr.RtxtVanBan.SelectionFont = HopFont.Font;
        }

        private void mFormat_ForeColor_Click(object sender, EventArgs e)
        {
            HopMau.ShowDialog();
            fr.RtxtVanBan.SelectionColor = HopMau.Color;
        }

        private void mFormat_BackColor_Click(object sender, EventArgs e)
        {
            HopMau.ShowDialog();
            fr.RtxtVanBan.SelectionBackColor = HopMau.Color;
        }

        private void mFormat_WordWrap_Click(object sender, EventArgs e)
        {
            mFormat_WordWrap.Checked = !mFormat_WordWrap.Checked;
            if(mFormat_WordWrap.Checked == true)
            {
                fr.RtxtVanBan.WordWrap = true;
                fr.RtxtVanBan.ScrollBars = RichTextBoxScrollBars.ForcedVertical;
            }
            else
            {
                fr.RtxtVanBan.WordWrap = false;
                fr.RtxtVanBan.ScrollBars = RichTextBoxScrollBars.ForcedBoth;
            }
        }
    }
}