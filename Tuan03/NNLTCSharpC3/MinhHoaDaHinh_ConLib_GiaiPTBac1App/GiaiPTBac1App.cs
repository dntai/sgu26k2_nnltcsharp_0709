using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NNLTCS.UTILS.ConsoleLib;

namespace NNLTCS.BaiTap.GiaiPTBac1App
{
    class GiaiPTBac1App: ConsoleMenu
    {
        // Model
        double a, b;

        public GiaiPTBac1App(): base("GIAI PHUONG TRINH BAC 1","Moi ban chon: ","Nhap tham so a, b", "Xuat tham so a, b", "Giai phuong trinh", "Thoat")
        {

        }

        public override void OnMenuChoose(MenuChooseEventArgs args)
        {
            switch(args.Item)
            {
                case 1:
                    Console.Write("Moi nhap so a: ");
                    a = double.Parse( Console.ReadLine() );
                    Console.Write("Moi nhap so b: ");
                    b = double.Parse( Console.ReadLine() );
                    break;
                case 2:
                    Console.WriteLine("{0}x + {1} = 0", a, b);
                    break;
                case 3:
                    if(a == 0)
                    {
                        if(b == 0)
                        {
                            Console.WriteLine("Phuong trinh vo so nghiem!");
                        }
                        else
                        {
                            Console.WriteLine("Phuong trinh vo nghiem!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Phuong trinh 1 nghiem, x = {0}", -b / a);
                    }
                    break;
                case 4:
                    Console.WriteLine("Hen gap lai!");
                    args.IsExit = true;
                    break;
                default:
                    break;
            }
        }
    }
}
