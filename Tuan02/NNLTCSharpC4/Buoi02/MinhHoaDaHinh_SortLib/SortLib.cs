using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace NNLTCS.UTILS
{
    public class SortLib
    {
        public static void SapTang(int[] ds)
        {
            for (int i = 0; i <= ds.Length - 2; i++)
            {
                for (int j = i + 1; j <= ds.Length - 1; j++)
                {
                    if (ds[i] > ds[j])
                    {
                        int tmp = ds[i];
                        ds[i] = ds[j];
                        ds[j] = tmp;
                    }
                }
            }
        }


        public static void SapXep(int[] ds, SapXepAdapter da)
        {
            for (int i = 0; i <= ds.Length - 2; i++)
            {
                for (int j = i + 1; j <= ds.Length - 1; j++)
                {
                    if (da.SoSanh(ds[i],ds[j])>0)// Khi nao hoan vi
                    {
                        int tmp = ds[i];
                        ds[i] = ds[j];
                        ds[j] = tmp;
                    }
                }
            }
        }

        public static void SapXep1(IList ds, SapXepAdapter da)
        {
            for (int i = 0; i <= ds.Count - 2; i++)
            {
                for (int j = i + 1; j <= ds.Count - 1; j++)
                {
                    if (da.SoSanh(ds[i], ds[j]) > 0)// Khi nao hoan vi
                    {
                        object tmp = ds[i];
                        ds[i] = ds[j];
                        ds[j] = tmp;
                    }
                }
            }
        }

    }
}
