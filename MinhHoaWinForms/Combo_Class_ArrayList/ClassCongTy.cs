using System;
using System.Collections.Generic;
using System.Text;

namespace Combo_Class_ArrayList
{
    class ClassCongTy
    {
        private string strTen, strMa;
        
        public ClassCongTy(string sTen, string sMa)
        {
            strTen = sTen;
            strMa = sMa;
        }
        
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
        
        public string Ma
        {
            get
            {
                return strMa;
            }
            set
            {
                strMa = value;
            }
        }
    }
}
