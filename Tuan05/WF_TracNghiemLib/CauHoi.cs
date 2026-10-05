using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace TracNghiemApp.Lib
{
    public class CauHoi
    {
        private string noiDung;
        private List<string> dsTraLoi;
        private List<int> dsCauDung;

        public CauHoi() {
            this.noiDung = "";
            this.dsTraLoi = new List<string>();
            this.dsCauDung = new List<int>();
        }

        public bool IsMutilpeChoice
        {
            get
            {
                return this.dsCauDung.Count > 1;
            }
        }

        public CauHoi(string noidung, List<string> traloi, List<int> caudung)
        {
            this.noiDung = noidung;
            
            this.dsTraLoi = new List<string>();
            foreach (string tl in traloi)
            {
                this.dsTraLoi.Add(tl);
            }

            this.dsCauDung = new List<int>();
            foreach (int cd in caudung)
            {
                this.dsCauDung.Add(cd);
            }
        }

        public CauHoi(CauHoi cauhoi)
        {
            this.noiDung = cauhoi.noiDung;

            this.dsTraLoi = new List<string>();
            foreach (string tl in cauhoi.dsTraLoi)
            {
                this.dsTraLoi.Add(tl);
            }

            this.dsCauDung = new List<int>();
            foreach (int cd in cauhoi.dsCauDung)
            {
                this.dsCauDung.Add(cd);
            }
        }

        public override string ToString()
        {
            string kq = "";
            kq += string.Format("{0}\n", this.noiDung);
            for (int i = 0; i <= dsTraLoi.Count - 1; i++)
            {
                kq += string.Format("{0}. {1}\n", i + 1, this.dsTraLoi[i]);
            }
            kq += string.Format("Cau dung: ");
            foreach (int i in this.dsCauDung)
            {
                kq += string.Format(" {0}", i);
            }
            kq += "\n";
            return kq;
        }

        public void ReadFile(StreamReader rd)
        {
            string line;

            this.noiDung = rd.ReadLine();

            line = rd.ReadLine();
            string [] ds = line.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            
            int soCauTraLoi = int.Parse(ds[0]);
            
            this.dsCauDung = new List<int>();
            for (int i = 1; i <= ds.Length - 1; i++)
            {
                this.dsCauDung.Add(int.Parse(ds[i]));
            }

            this.dsTraLoi = new List<string>();
            for (int i = 1; i <= soCauTraLoi; i++)
            {
                this.dsTraLoi.Add(rd.ReadLine());
            }
        }


        public bool traLoi(params int[] ds)
        {
            foreach (int caudung in this.dsCauDung)
            {
                if (Array.IndexOf(ds, caudung) == -1)
                {
                    return false;
                }
            }
            return true;
        }

        public string NoiDungCauHoi
        {
            get
            {
                return this.noiDung;
            }
        }

        public int SoCauHoi
        {
            get
            {
                return this.dsTraLoi.Count;
            }
        }

        public string this[int index]
        {
            get
            {
                return this.dsTraLoi[index];
            }
        }

    }
}
