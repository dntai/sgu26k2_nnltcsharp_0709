using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;  

namespace prj_Calendar
{
    public partial class frmMonthCalendar : Form
    {
        public frmMonthCalendar()
        {
            InitializeComponent();
        }
        public struct SystemTime  
         {  
              public ushort Year;  
              public ushort Month;  
              public ushort DayOfWeek;  
              public ushort Day;  
              public ushort Hour;  
              public ushort Minute;  
              public ushort Second;  
              public ushort Millisecond;  
          };  

        [DllImport("kernel32.dll", EntryPoint = "GetSystemTime", SetLastError = true)]  
        public extern static void Win32GetSystemTime(ref SystemTime sysTime);  
        [DllImport("kernel32.dll", EntryPoint = "SetSystemTime", SetLastError = true)]  
        public extern static bool Win32SetSystemTime(ref SystemTime sysTime);  

        private void Lich_DateChanged(object sender, DateRangeEventArgs e)
        {
            SystemTime updatedTime = new SystemTime();
            updatedTime.Year = (ushort)Lich.TodayDate.Year;
            updatedTime.Month = (ushort)Lich.TodayDate.Month;
            updatedTime.Day = (ushort)Lich.TodayDate.Day;
            Win32SetSystemTime(ref updatedTime);
            SystemTime currTime = new SystemTime();
            Win32GetSystemTime(ref currTime);  

        }

     
    }
}