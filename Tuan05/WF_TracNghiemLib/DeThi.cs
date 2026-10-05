using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace TracNghiemApp.Lib
{
    public class DeThi
    {
        private List<CauHoi> dsCauHoi;
        
        public DeThi()
        {
            this.dsCauHoi = new List<CauHoi>();
        }

        public override string ToString()
        {
            string kq = "";
            kq += string.Format("So cau hoi: {0}\n", this.dsCauHoi.Count);
            foreach (CauHoi ch in this.dsCauHoi)
            {
                kq += string.Format("{0}\n", ch);
            }
            return kq;
        }

        public CauHoi this[int index]
        {
            get
            {
                return this.dsCauHoi[index];
            }
        }

        public int SoCauHoi
        {
            get
            {
                return this.dsCauHoi.Count;
            }
        }

        public void ReadFile(string path)
        {
            StreamReader rd = new StreamReader(path);
            int soCauHoi = int.Parse(rd.ReadLine());
            for (int i = 1; i <= soCauHoi; i++)
            {
                CauHoi ch = new CauHoi();
                ch.ReadFile(rd);
                this.dsCauHoi.Add(ch);
            }
            rd.Close();
        }

    }
}
