using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NNLTCS.UTILS.ConsoleLib;

namespace NNLTCS.BaiTap.TinhToanApp
{
    class XuLyMenuChoose: IMenuChooseListener
    {

        public void MenuChoose(object sender, MenuChooseEventArgs args)
        {
            switch (args.Item)
            {
                case 1:
                    Console.WriteLine("Thoat");
                    args.IsExit = true;
                    break;
                case 2:
                    Console.WriteLine("Nhap");
                    break;
                case 3:
                    Console.WriteLine("Tinh");
                    break;
                default:
                    break;
            }
        }
    }
    public class TinhToanApp
    {
        public static double a, b;
        static void Main(string[] args)
        {
            ConsoleMenu app = new ConsoleMenu("TINH TONG HAI SO", "Moi ban chon: ","Thoat", "Nhap so a, b","Xuat a, b", "Tinh tong");
            // app.AddMenuChooseListener(new XuLyMenuChoose());
            app.MenuChoose += app_MenuChoose;
            app.Process();
        }

        static void app_MenuChoose(object sender, MenuChooseEventArgs args)
        {
            Console.WriteLine("Event");
            switch (args.Item)
            {
                case 1:
                    Console.WriteLine("Thoat");
                    args.IsExit = true;
                    break;
                case 2:
                    Console.Write("Moi nhap so a: ");
                    a = double.Parse( Console.ReadLine() );
                    Console.Write("Moi nhap so b: ");
                    b = double.Parse( Console.ReadLine() );
                    break;
                case 3:
                    Console.WriteLine("a = {0}, b = {1}", a, b);
                    break;
                case 4:
                    Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
                    break;
                default:
                    break;
            }
        }
    }
}
