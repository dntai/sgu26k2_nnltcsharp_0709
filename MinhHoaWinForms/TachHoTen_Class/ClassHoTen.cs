using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace TachHoTen_Class
{
    class ClassHoTen
    {   
        public string Ho
        {
            get { return strHo; }
            set { strHo = value; }
        }
        
        public string Lot
        {
            get { return strLot; }
            set { strLot = value; }
        }
        
        public string Ten
        {
            get { return strTen; }
            set { strTen = value; }
        }
        private string strHo;
        private string strLot;
        private string strTen;

        public string ChuanHoTen(ref string ChuoiHT)
        {
            string KTuTim;
            ChuoiHT = ChuoiHT.Trim().ToLower();
            
            while (ChuoiHT.IndexOf("  ")!= -1)
            {
                ChuoiHT = ChuoiHT.Replace("  "," ");
            }
            
            KTuTim = ChuoiHT.Substring(0, 1).ToUpper();
            ChuoiHT = ChuoiHT.Remove(0, 1);
            ChuoiHT = ChuoiHT.Insert(0, KTuTim);
            for(int i=1; i<=ChuoiHT.Length-1; i++)
            {
                if(ChuoiHT.Substring(i-1,1)==" ")
                {
                    KTuTim = ChuoiHT.Substring(i, 1).ToUpper();
                    ChuoiHT = ChuoiHT.Remove(i, 1);
                    ChuoiHT = ChuoiHT.Insert(i, KTuTim);
                }
            }
            return ChuoiHT;
        }

        public void TachHoTen(string ChuoiHT)
        { 
            int ViTri, BD, SoKT;
            ViTri = ChuoiHT.IndexOf(" ");
            if (ViTri == -1)
            {
                Ten = ChuoiHT;
                Ho = "";
                Lot = "";
            }
            else
            {
                Ho = ChuoiHT.Substring(0, ViTri);
                Ten = ChuoiHT.Substring(ChuoiHT.LastIndexOf(" ") + 1);
                BD = Ho.Length + 1;
                SoKT = ChuoiHT.Length - (BD + Ten.Length);
                if (SoKT > 0)
                {
                    Lot = ChuoiHT.Substring(BD, SoKT - 1);
                }
                else
                {
                    Lot = "";
                }
            }
        }
    }
}
