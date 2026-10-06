using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Buoi8_FrmPhieuKhaoSat
{
    public delegate void DelDongHoFinish(object sender, EventArgs e);

    public partial class UcDongHo : UserControl
    {
        private int tongSoGiay;
        public event DelDongHoFinish Finish;

        public UcDongHo()
        {
            InitializeComponent();

            this.timer1.Enabled = false;
            this.SoGiay = 60;
            this.inDongHo();
        }

        private void inDongHo()
        {
            int hh = this.tongSoGiay / 3600;
            int mm = (this.tongSoGiay % 3600) / 60;
            int ss = this.tongSoGiay % 60;
            lblDongHo.Text = string.Format("{0:0#}:{1:0#}:{2:0#}", hh, mm, ss);
        }

        public int SoGiay
        {
            get
            {
                return this.tongSoGiay;
            }
            set
            {
                this.tongSoGiay = value;
                this.inDongHo();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.tongSoGiay == 0)
            {
                this.timer1.Stop();
                if (this.Finish != null)
                {
                    this.Finish(this, EventArgs.Empty);
                }
                return;
            }
            this.tongSoGiay = this.tongSoGiay - 1;
            this.inDongHo();
        }

        public void Start()
        {
            this.timer1.Enabled = true;
            this.timer1.Start();
        }

        public void Stop()
        {
            this.timer1.Stop();
        }



    }
}
