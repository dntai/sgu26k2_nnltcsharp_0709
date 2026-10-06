using System.Collections.Generic;
using System.Text;

namespace prjDuLich_Class_Fle
{
    class ClassThongTinDK
    {
        private string strMaDK, strHoTen;
        private int iDangKy, iSoNguoi, iTour, iPhuongTien;

        public string MaDK
        {
            get { return strMaDK; }
            set { strMaDK = value; }
        }
        public string HoTen
        {
            get { return strHoTen; }
            set { strHoTen = value; }
        }
        public int DangKy
        {
            get { return iDangKy; }
            set { iDangKy = value; }
        }
        public int SoNguoi
        {
            get { return iSoNguoi; }
            set { iSoNguoi = value; }
        }
        public int Tour
        {
            get { return iTour; }
            set { iTour = value; }
        }
        public int PhuongTien
        {
            get { return iPhuongTien; }
            set { iPhuongTien = value; }
        }
    }
}
