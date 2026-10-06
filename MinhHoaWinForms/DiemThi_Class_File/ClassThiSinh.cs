using System;
using System.Collections.Generic;
using System.Text;

namespace DiemThi_Class_File
{
    class ClassThiSinh
    {
        private string strSBD, strHoTen, strDiaChi;
        private int iNamSinh, iPhai, iHDThi, iDiemToan, iDiemLy, iDiemHoa;
        public string SBD
        {
            get { return strSBD; }
            set { strSBD=value; }
        }
        public string HoTen
        {
            get { return strHoTen; }
            set { strHoTen = value; }
        }
        public string DiaChi
        {
            get { return strDiaChi; }
            set { strDiaChi = value; }
        }
        public int NamSinh
        {
            get { return iNamSinh; }
            set { iNamSinh = value; }
        }
        public int Phai
        {
            get { return iPhai; }
            set { iPhai = value; }
        }
        public int HDThi
        {
            get { return iHDThi; }
            set { iHDThi = value; }
        }
        public int DiemToan
        {
            get { return iDiemToan; }
            set { iDiemToan = value; }
        }
        public int DiemLy
        {
            get { return iDiemLy; }
            set { iDiemLy = value; }
        }
        public int DiemHoa
        {
            get { return iDiemHoa; }
            set { iDiemHoa = value; }
        }
    }
}
