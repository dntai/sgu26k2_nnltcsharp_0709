using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using WF_TracNghiemApp1;

namespace Buoi8_FrmPhieuKhaoSat
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmTest());
            // Application.Run(new FrmKhaoSat());
        }
    }
}
