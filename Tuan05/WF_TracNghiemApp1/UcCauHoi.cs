using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using TracNghiemApp.Lib;

namespace Buoi8_FrmPhieuKhaoSat
{
    public partial class UcCauHoi : UserControl
    {
        private CauHoi cauhoi;
        Dictionary<int, int> dsTraLoi;

        public UcCauHoi()
        {
            InitializeComponent();
            this.dsTraLoi = new Dictionary<int, int>();
        }


        public CauHoi NoiDung
        {
            get
            {
                return this.cauhoi;
            }
            set
            {
                this.cauhoi = value;
                this.showCauHoi();
            }
        }

        private void showCauHoi()
        {
            if (this.cauhoi == null) return;
            this.lblNoiDung.Text = this.cauhoi.NoiDungCauHoi;

            int delta_y = 0;
            dsTraLoi.Clear();
            for (int i = 0; i <= this.cauhoi.SoCauHoi - 1;i++ )
            {
                if (this.cauhoi.IsMutilpeChoice == true)
                {
                    CheckBox chkTraLoi = new CheckBox();

                    chkTraLoi.AutoSize = true;
                    chkTraLoi.Location = new System.Drawing.Point(9, 19 + delta_y);
                    chkTraLoi.Name = "chkTraLoi";
                    chkTraLoi.Size = new System.Drawing.Size(80, 17);
                    chkTraLoi.TabIndex = 0;
                    chkTraLoi.Text = this.cauhoi[i];
                    chkTraLoi.UseVisualStyleBackColor = true;
                    chkTraLoi.Tag = i + 1;

                    delta_y = delta_y + 17;

                    this.gbxTraLoi.Controls.Add(chkTraLoi);

                    chkTraLoi.CheckedChanged += new EventHandler(chkTraLoi_CheckedChanged);

                }
                else
                {
                    RadioButton rdoTraLoi = new RadioButton();

                    rdoTraLoi.AutoSize = true;
                    rdoTraLoi.Location = new System.Drawing.Point(9, 19 + delta_y);
                    rdoTraLoi.Name = "rdoTraLoi";
                    rdoTraLoi.Size = new System.Drawing.Size(85, 17);
                    rdoTraLoi.TabIndex = 0;
                    rdoTraLoi.TabStop = true;
                    rdoTraLoi.Text = this.cauhoi[i];
                    rdoTraLoi.UseVisualStyleBackColor = true;
                    rdoTraLoi.Tag = i + 1;

                    delta_y = delta_y + 17;

                    this.gbxTraLoi.Controls.Add(rdoTraLoi);

                    rdoTraLoi.CheckedChanged += new EventHandler(rdoTraLoi_CheckedChanged);
                }
            }
        }

        void rdoTraLoi_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdo = sender as RadioButton;
            int ans = (int)rdo.Tag;
            if (rdo.Checked == true)
            {
                rdo.ForeColor = Color.Red;
                if (dsTraLoi.ContainsKey(ans) == false)
                {
                    dsTraLoi[ans] = 1;
                }
            }
            else
            {
                rdo.ForeColor = Color.Black;
                if (dsTraLoi.ContainsKey(ans) == true)
                {
                    dsTraLoi.Remove(ans);
                }
            }
        }

        public int[] TraLoi
        {
            get
            {
                return dsTraLoi.Keys.ToArray();
            }
        }

        void chkTraLoi_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chk = sender as CheckBox;
            int ans = (int)chk.Tag;
            if (chk.Checked == true)
            {
                chk.ForeColor = Color.Red;
                if (dsTraLoi.ContainsKey(ans) == false)
                {
                    dsTraLoi[ans] = 1;
                }
            }
            else
            {
                chk.ForeColor = Color.Black;
                if (dsTraLoi.ContainsKey(ans) == true)
                {
                    dsTraLoi.Remove(ans);
                }
            }
        }
    }
}
