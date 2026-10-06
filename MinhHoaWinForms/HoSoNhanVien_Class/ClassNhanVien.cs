using System;
using System.Collections.Generic;
using System.Text;

namespace HoSoNhanVien_Class
{
    class ClassNhanVien
    {
        private string strMaSo, strHoTen;
        private int iPhongBan, iChucVu, iNamSinh, iPhai;

        public string MaSo
        {
            get 
            {
                return strMaSo;
            }
            set 
            {
                strMaSo = value;
            }
        }

        public string HoTen
        {
            get 
            {
                return strHoTen;
            }
            set 
            {
                strHoTen = value;
            }
        }

        public int PhongBan
        {
            get
            {
                return iPhongBan; 
            }
            set
            {
                iPhongBan = value;
            }
        }

        public int ChucVu
        {
            get
            {
                return iChucVu;
            }
            set
            {
                iChucVu = value;
            }
        }

        public int NamSinh
        {
            get
            {
                return iNamSinh;
            }
            set
            {
                iNamSinh = value;
            }
        }

        public int Phai
        {
            get
            {
                return iPhai;
            }
            set
            {
                iPhai = value;
            }
        }
    }
}
