using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
using System.Windows.Forms;

namespace TextEditor
{
    class SmartMessage : MyMessage
    {
        public bool Ghi()
        {
            StreamWriter TapTinGhi;
            FileStream TapTinTao;
            string DuongDan, TenTapTin;
            DuongDan = Application.StartupPath + @"\..";
            DuongDan = DuongDan + @"\..";
            // Cach khac DuongDan = Replace(Application.StartupPath, "\bin", Space(0), , , CompareMethod.Text)
            TenTapTin = DuongDan + @"\Vanban.txt"; 
            try
            {
                TapTinTao = File.Create(TenTapTin);
                TapTinTao.Close();
                TapTinGhi = File.AppendText(TenTapTin);
                TapTinGhi.Write(msgText);
                TapTinGhi.Close();
                return true; 
            }
            catch (Exception)
            {
                return false;
            }
        }
        
        public bool Doc()
        {
            StreamReader TapTinDoc; 
            FileStream TapTinTao;
            string DuongDan, TenTapTin;
            DuongDan = Application.StartupPath + @"\..";
            DuongDan = DuongDan + @"\..";
            //Cach khac DuongDan = Replace(DuongDan, "\bin", Space(0), , , CompareMethod.Text)
            TenTapTin = DuongDan + @"\Vanban.txt";           
            try
            {
                if( !File.Exists(TenTapTin) == true)
                {
                    TapTinTao = File.Create(TenTapTin);
                    TapTinTao.Close();
                }
                TapTinDoc = File.OpenText(TenTapTin);
                msgText = TapTinDoc.ReadToEnd();
                TapTinDoc.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public SmartMessage()
        {
            new MyMessage();
            Doc();
        }
    }
}
