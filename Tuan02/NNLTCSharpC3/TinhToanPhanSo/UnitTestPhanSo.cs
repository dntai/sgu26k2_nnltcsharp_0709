using NNLTCS.BaiTap.TinhToanPhanSo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NNLTCS.BaiTap.TinhToanPhanSo
{
    public class UnitTestPhanSo
    {
        static void Test4()
        {
            Console.WriteLine("--- Test4 ---");
            PhanSo p1 = new PhanSo(1, 4);
            PhanSo p2 = new PhanSo(2, 6);

            PhanSo kq1 = p1.tinhCong(p2);
            PhanSo kq2 = PhanSo.tinhCong(p1, p2);
            PhanSo kq3 = p1 + p2;
            Console.WriteLine("kq1={0},kq2={1},kq3={2}", kq1, kq2, kq3);
        }
        static void Test3()
        {
            Console.WriteLine("--- Test3 ---");
            PhanSo p1 = new PhanSo();
            PhanSo p2 = new PhanSo(5);
            PhanSo p3 = new PhanSo(1, 2);
            PhanSo p4 = new PhanSo(p3);

            BieuThuc bt = new BieuThuc();
            bt.themPhanSo(p1);
            bt.themPhanSo(p2);
            bt.themPhanSo(p3);
            bt.themPhanSo(p4);
            Console.WriteLine("Bieu thuc {0}!", bt);


            BieuThuc bt1 = new BieuThuc(p1, p2, p3, p4);
            Console.WriteLine("Bieu thuc {0}", bt1);
        }

        static void Test2()
        {
            Console.WriteLine("--- Test2 ---");
            PhanSo p1 = new PhanSo();
            PhanSo p2 = new PhanSo(5);
            PhanSo p3 = new PhanSo(1, 2);
            PhanSo p4 = new PhanSo(p3);

            Console.WriteLine("p1={0},p2={1},p3={2},p4={3}"
                , p1, p2, p3, p4);
        }
        static void Test1()
        {
            Console.WriteLine("--- Test1 ---");
            PhanSo p1 = new PhanSo();
            PhanSo p2 = new PhanSo(5);
            PhanSo p3 = new PhanSo(1, 2);
            PhanSo p4 = new PhanSo(p3);

            BieuThuc bt = new BieuThuc();
            bt.themPhanSo(p1);
            bt.themPhanSo(p2);
            bt.themPhanSo(p3);
            bt.themPhanSo(p4);
            PhanSo kq = bt.tinhToan();
            Console.WriteLine("Bieu thuc {0}={1}",
                bt, kq);

            Console.WriteLine("Mau so kq: {0}", kq.MauSo);
            Console.WriteLine("Phan so thu 2 trong bieu thuc {0} la {1}!", bt, bt[2]);

            BieuThuc bt1 = new BieuThuc(p1, p2, p3, p4);
            PhanSo kq1 = bt1.tinhToan();
            Console.WriteLine("Bieu thuc {0}={1}",
                bt1, kq1);

            Console.WriteLine("Cac phan so trong bieu thuc: ");
            foreach(PhanSo p in bt1)
            {
                Console.WriteLine("{0}", p);
            }
        }

        public static void Main(string[]args)
        {
            Test1();
            Test2();
            Test3();
            Test4();
        }
    }
}