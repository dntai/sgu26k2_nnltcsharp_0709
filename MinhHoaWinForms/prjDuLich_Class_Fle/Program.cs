using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace prjDuLich_Class_Fle
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
            Application.Run(new frmDangKy());
        }
    }
}