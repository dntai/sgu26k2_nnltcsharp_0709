using NNLTCS.UTILS;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NNLTCS.BaiTap
{
    internal class SapGiamAdapter: SapXepAdapter
    {
        public override int SoSanh(object a, object b)
        {
            int ia = (int)a;
            int ib = (int)b;
            if (ia < ib)
                return 1;
            else if (ia == ib)
                return 0;
            return -1;
        }
    }


    internal class ChanLeAdapter : SapXepAdapter
    {
        public override int SoSanh(object a, object b)
        {
            int ia = (int)a;
            int ib = (int)b;
            if (ia % 2 == 0 && ib % 2 == 1)
                return -1;
            else if (ia % 2 == 1 && ib % 2 == 0)
                return 1;
            return 0;
        }
    }
    public class TestSortLib
    {
        static void printArray(IList ds)
        {
            Console.Write("Day so co {0} phan tu: ", ds.Count);
            for (int i = 0; i <= ds.Count - 1; i++)
            {
                Console.Write("{0} ", ds[i]);
            }
            Console.WriteLine();
        }

        static void Test1()
        {
            Console.WriteLine("--- Test1 --- ");
            int[] ds = { 1, 5, 2, 1, 3, 4, 2, 3 };
            printArray(ds);
            NNLTCS.UTILS.SortLib.SapTang(ds);
            printArray(ds);
        }


        static void Test2()
        {
            Console.WriteLine("--- Test2 --- ");
            int[] ds = { 1, 5, 2, 1, 3, 4, 2, 3 };
            printArray(ds);
            NNLTCS.UTILS.SortLib.SapXep(ds, new SapXepAdapter());
            printArray(ds);
        }

        static void Test3()
        {
            Console.WriteLine("--- Test3 --- ");
            int[] ds = { 1, 5, 2, 1, 3, 4, 2, 3 };
            printArray(ds);
            NNLTCS.UTILS.SortLib.SapXep(ds, new SapGiamAdapter());
            printArray(ds);
        }


        static void Test4()
        {
            Console.WriteLine("--- Test4 --- ");
            int[] ds = { 1, 5, 2, 1, 3, 4, 2, 3 };
            printArray(ds);
            NNLTCS.UTILS.SortLib.SapXep(ds, new ChanLeAdapter());
            printArray(ds);
        }

        static void Test5()
        {
            Console.WriteLine("--- Test5 --- ");
            double[] ds = { 1.1, 5.1, 2.2, 1.3, 3.2, 4.5, 2.3, 3.3 };
            printArray(ds);
            NNLTCS.UTILS.SortLib.SapXep1(ds, new ChanLeAdapter());
            printArray(ds);
        }
        static void Main(string[] args)
        {
            Test1();
            Test2();
            Test3();
            Test4();
            Test5();
        }
    }
}
