using System;
using System.Collections.Generic;
using System.Text;

namespace ThucDonAnNhau_Class_ListBox
{
    class ClassMonAn
    {
        private string strTen;
        private int iDonGia, iSoLuong;
        public string Ten
        {
            get
            {
                return strTen;
            }
            set 
            {
                strTen = value;
            }
        }
        public int DonGia
        {
            get 
            {
                return iDonGia;
            }
            set 
            {
                iDonGia = value;
            }
        }
        public int SoLuong
        {
            get
            {
                return iSoLuong;
            }
            set
            {
                iSoLuong = value;
            }
        }
        public void TaoMonAn(string sTen, int iDG, int iSL)
        {
            Ten = sTen;
            DonGia = iDG;
            SoLuong = iSL;
        }
    }
}
