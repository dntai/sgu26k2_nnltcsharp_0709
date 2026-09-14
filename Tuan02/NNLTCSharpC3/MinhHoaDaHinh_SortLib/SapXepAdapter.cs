using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NNLTCS.UTILS
{
    public class SapXepAdapter
    {
        public virtual int SoSanh(object a, object b)
        {
            int ia = (int)a;
            int ib = (int)b;
            if (ia < ib)
                return -1;
            else if (ia == ib)
                return 0;
            return 1;
        }
    }
}
