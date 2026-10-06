using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace TextEditor
{
    class MyMessage
    {
        private string sMessage;
        public string msgText
        {
            get
            {
                return sMessage;
            }
            set
            {
                sMessage = value;
            }
        }
    }
}
