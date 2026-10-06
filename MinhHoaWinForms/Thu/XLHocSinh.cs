using System;
using System.Collections.Generic;
using System.Text;

namespace Thu
{
    class XLHocSinh
    {
        public  string  HoLot
	    {
		    get 
		    {
			    return strHoLot;
		    }
		    set 
		    {
			    strHoLot= value;
		    }

	    }
	
        public  string  Ten
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

        public  DateTime NgaySinh
	    {
		    get 
		    {
			    return dNgaySinh;
		    }
    		
            set 
		    {
			    dNgaySinh = value;
		    }
	    }

        public  bool  Phai
	    {
		    get 
		    {
			    return bPhai;
		    }
		    set 
		    {
			    bPhai = value;
		    }
	    }

        public int Tuoi
        {
            get
            {
                return DateTime.Now.Year - NgaySinh.Year;
            }
        }
        public string XuatThongTinHocSinh ( )
        {
            string kq;
            kq = "Hoï teân hoïc sinh: " + HoLot + " " + Ten + ", Tuoi: " +
            Tuoi.ToString ( );
            return kq;
        }

        private string strHoLot;
        private string strTen;
        private DateTime dNgaySinh;
	    private bool bPhai;

    }
}
