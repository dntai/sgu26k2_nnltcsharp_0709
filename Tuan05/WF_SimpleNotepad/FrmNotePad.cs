using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Buoi9_SimpleNotepad
{
    public partial class FrmNotePad : Form
    {
        string pathFile = "";

        public FrmNotePad()
        {
            InitializeComponent();
        }

        private void mnuOpen_Click(object sender, EventArgs e)
        {
            // B1. Khai bao
            OpenFileDialog dlg = new OpenFileDialog();
            // B2. Khoi tao
            dlg.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            // B3. Hien thi va lay ket qua
            DialogResult ret = dlg.ShowDialog();
            // B4. Xu ly 
            if (ret == DialogResult.OK)
            {
                this.pathFile = dlg.FileName;
                rtfNoiDung.Rtf = this.readContentFile(pathFile);
            }
        }

        private string readContentFile(string path)
        {
            if (File.Exists(path) == false)
                throw new Exception("Duong dan khong ton tai!");
            StreamReader rd = new StreamReader(path);

            string content = rd.ReadToEnd();
            
            rd.Close();
            rd.Dispose();

            return content;
        }

        private void writeContentFile(string content, string path)
        {
            StreamWriter wt = new StreamWriter(path);

            wt.Write(content);

            wt.Close();
            wt.Dispose();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuNew_Click(object sender, EventArgs e)
        {
            this.pathFile = "";
            rtfNoiDung.Text = "";
        }

        private void mnuSave_Click(object sender, EventArgs e)
        {
            if (this.pathFile == "")
            {
                SaveFileDialog dlg = new SaveFileDialog();
                dlg.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
                DialogResult ret = dlg.ShowDialog();
                if (ret == System.Windows.Forms.DialogResult.OK)
                {
                    this.pathFile = dlg.FileName;
                    this.writeContentFile(rtfNoiDung.Rtf, this.pathFile);
                }
            }
            else
            {
                this.writeContentFile(rtfNoiDung.Rtf, this.pathFile);
            }
        }

        private void mnuSaveAs_Click(object sender, EventArgs e)
        {
            if (this.pathFile == "") return;

            FileInfo info = new FileInfo(this.pathFile);
            string dir = info.Directory.FullName;
            string name = info.Name;

            SaveFileDialog dlg = new SaveFileDialog();
            dlg.InitialDirectory = dir;
            dlg.FileName = name;
            DialogResult ret = dlg.ShowDialog();
            if (ret == System.Windows.Forms.DialogResult.OK)
            {
                this.pathFile = dlg.FileName;
                this.writeContentFile(rtfNoiDung.Rtf, this.pathFile);
            }
        }

        private void mnuStyle_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = sender as ToolStripMenuItem;
            switch (item.Text)
            {
                case "Bold":
                    rtfNoiDung.SelectionFont = new Font(rtfNoiDung.SelectionFont.FontFamily, rtfNoiDung.SelectionFont.Size, FontStyle.Bold);
                    break;
                case "Italic":
                    break;
                case "Underline":
                    break;
            }
        }

        private void mnuFont_Click(object sender, EventArgs e)
        {
            FontDialog dlg = new FontDialog();
            dlg.Font = rtfNoiDung.SelectionFont;
            DialogResult ret = dlg.ShowDialog();
            if (ret == DialogResult.OK)
            {
                rtfNoiDung.SelectionFont = dlg.Font;
            }
        }

        private void mnuShow_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void mnuHide_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void FrmNotePad_Resize(object sender, EventArgs e)
        {
            if (this.Size.Width == 160 && this.Size.Height == 28)
            {
                this.Hide();
            }
        }



    }
}
