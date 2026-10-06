using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace prj_NotePad
{
    public partial class frmVanBan : Form
    {
      
        bool Dung = false;

        public frmVanBan()
        {
            InitializeComponent();
        }

        private void Save()
        { 
            if(frmChinh.sTenTapTin != "")
            {
                RtxtVanBan.SaveFile(frmChinh.sTenTapTin);
            }
            else
            {
                LuuFile.ShowDialog(); //Mo hop thoai luu file
                if(LuuFile.FileName == "") //Trường hợp nhấn nút Cancel
                {
                    Dung = true;
                    return;
                }
                frmChinh.sTenTapTin = LuuFile.FileName; //Xac dinh ten tap tin se luu
                RtxtVanBan.SaveFile(frmChinh.sTenTapTin);  //Tao/ mo va luu tap tin
            }
            RtxtVanBan.Modified = false;
        }

        private void frmVanBan_Load(object sender, EventArgs e)
        {
            frmChinh.Dong = false;
        }

        private void frmVanBan_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmChinh.sTenTapTin = "";
            frmChinh.Dong = true;
        }

        private void frmVanBan_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (frmChinh.Dong == false)
            //{
                DialogResult TraLoi;
                if (RtxtVanBan.Modified == true)  //Truong hop co sua doi
                {
                    TraLoi = MessageBox.Show("Tap tin da thay doi, ban co muon luu lai hay khong?", "Chuan bi dong tap tin", MessageBoxButtons.YesNoCancel);
                    if (TraLoi == DialogResult.Yes)
                    {
                        Save();
                        if (Dung == true)
                        {
                            e.Cancel = true;
                            return;
                        }
                        RtxtVanBan.Modified = false;
                        frmChinh.Dong = true;
                    }
                    else
                    {
                        if (TraLoi == DialogResult.Cancel)
                        {
                            e.Cancel = true;
                            return;
                        }
                    }
                }
            //}
        }

        private void RtxtVanBan_TextChanged(object sender, EventArgs e)
        {
            RtxtVanBan.Modified = true;
        }

        private void mnuTat_Cut_Click(object sender, EventArgs e)
        {
            RtxtVanBan.Cut();
        }

        private void mnuTat_Copy_Click(object sender, EventArgs e)
        {
            RtxtVanBan.Copy();
        }

        private void mnuTat_Paste_Click(object sender, EventArgs e)
        {
            try
            {
                RtxtVanBan.Paste();
            }
            catch (Exception) { }
        }

        private void mnuTat_Undo_Click(object sender, EventArgs e)
        {
            RtxtVanBan.Undo();
        }
    }
}