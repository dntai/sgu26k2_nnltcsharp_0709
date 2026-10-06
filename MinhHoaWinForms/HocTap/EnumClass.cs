using System;
using System.Collections.Generic;
using System.Text;

enum EmpType : byte
{   Manager = 10,
    Grunt = 1,
    Contractor = 100,
    VP = 9
}
namespace HocTap
{
    class EnumClass
    {
        public static void AskForBonus(EmpType e)
        {
            switch (e)
            {   case EmpType.Contractor:
                    Console.WriteLine("Ban da co qua nhieu tien mat...");
                    break;
                case EmpType.Grunt:
                    Console.WriteLine("Anh ban gion mat ha...");
                    break;
                case EmpType.Manager:
                    Console.WriteLine("Thi truong chung khoan the nao roi...");
                    break;
                case EmpType.VP:
                    Console.WriteLine("Very good, sir!");
                    break;
                default: break;
            }
        }
        public static void Main()
        {
            EmpType fred;
            fred = EmpType.Contractor;
            AskForBonus(fred);
            Console.WriteLine("Anh la {0}", Enum.Format(typeof(EmpType), fred, "G"));
            Console.WriteLine("Kieu du lieu cua Enum nay la {0}", Enum.GetUnderlyingType(typeof(EmpType)));
            Array obj = Enum.GetValues(typeof(EmpType));
            Console.WriteLine("Enum nay co {0} thanh vien", obj.Length);
            foreach(EmpType e in obj)
            {   Console.Write("Ten chuoi: {0}", Enum.Format(typeof(EmpType),e,"G"));
                Console.Write(" ({0})", Enum.Format(typeof(EmpType), e, "D"));
                Console.Write(" ({0})\n", Enum.Format(typeof(EmpType), e, "x"));
            }
            int m=1;
            switch (m)
            {   case 1:
                //Console.WriteLine("abc"); nếu có dùng câu lệnh này mà không dùng lệnh break sẽ bị lỗi
                case 2:
                    Console.WriteLine("Cde");
                    break;
            }
            Random randObj = new Random(1);
            for (int j = 0; j < 6; j++)
                Console.Write(" {0,10} ", randObj.Next());

            Console.ReadLine();
        }
    }
}
