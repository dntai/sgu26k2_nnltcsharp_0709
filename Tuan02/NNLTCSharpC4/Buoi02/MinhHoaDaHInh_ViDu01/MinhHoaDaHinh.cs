using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NNLTCS.BaiTap
{
    internal class MinhHoaDaHinh
    {
        class A
        {
            public void Method1()
            {
                Console.WriteLine("A - Method1");
            }
            public void Process()
            {
                Console.WriteLine("A - Process");
            }
            public virtual void Name()
            {
                Console.WriteLine("Toi la A!");
            }
        }

        class B : A
        {
            public void Method2()
            {
                Console.WriteLine("B - Method2");
            }
            public void Process()
            {
                Console.WriteLine("B - Process");
            }
            public override void Name()
            {
                Console.WriteLine("Toi la B!");
            }
        }

        class C : B
        {
            public override void Name()
            {
                Console.WriteLine("Toi la C!");
            }
        }

        class D : C
        {
            public virtual void Name()
            {
                Console.WriteLine("Toi la D!");
            }
        }

        class E : D
        {
            public override void Name()
            {
                Console.WriteLine("Toi la E!");
            }
        }

        public static void Main(string[] args)
        {
            // Tai su dung
            B b = new B();
            b.Method1();
            
            // Mo rong
            b.Method2();

            // Ko da hinh
            A a = new B();// doi tuong lop cha duoc quyen gan boi doi tuong lop con
            a.Process();

            // Da hinh
            A a1 = new B();
            a1.Name();

            // Da hinh lien tiep
            A aa = new A();// v
            A bb = new B();// o
            A cc = new C();// o
            A dd = new D();// v
            A ee = new E();// o
            Console.WriteLine("======");
            aa.Name(); bb.Name();
            cc.Name(); dd.Name();
            ee.Name();
        }
    }
}
