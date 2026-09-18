using NNLTCS.BaiTap.TinhToanPhanSo;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NNLTCS.BaiTap.TinhToanPhanSo
{
    public class BieuThuc: IEnumerable<PhanSo>, IEnumerator<PhanSo>
    {
        private List<PhanSo> dsPhanSo = null;
        private int index;

        public PhanSo Current
        {
            get
            {
                return this.dsPhanSo[this.index];
            }
            set
            {
                this.dsPhanSo[this.index] = value;
            }
        }

        object IEnumerator.Current
        {
            get
            {
                return this.Current;
            }
        }

        public BieuThuc()// bieu thuc rong
        {
            this.dsPhanSo = new List<PhanSo>();
            this.index = -1;
        }
        public BieuThuc(params PhanSo[] ds)
        {
            this.dsPhanSo = new List<PhanSo>();
            for (int i = 0; i <= ds.Length - 1; i++)
            {
                this.dsPhanSo.Add(new PhanSo(ds[i]));
            }
            this.index = -1;
        }
        public void themPhanSo(PhanSo p)
        {
            dsPhanSo.Add(new PhanSo(p));
        }
        public override string ToString()
        {
            string s = "";
            for (int i = 0; i <= this.dsPhanSo.Count - 1; i++)
            {
                s = s + dsPhanSo[i].ToString() + "+";
            }
            if (s != "")
            {
                s = s.Substring(0, s.Length - 1);
            }
            return s;
        }
        public PhanSo tinhToan()
        {
            PhanSo kq = new PhanSo();
            for (int i = 0; i <= this.dsPhanSo.Count - 1; i++)
            {
                PhanSo p = this.dsPhanSo[i];
                kq = kq.tinhCong(p);
            }
            return kq;
        }

        public IEnumerator<PhanSo> GetEnumerator()
        {
            return this;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this;
        }

        public bool MoveNext()
        {
            if(this.index >= this.dsPhanSo.Count-1)
            {
                return false;
            }
            this.index += 1;
            return true;
        }

        public void Reset()
        {
            this.index = -1;
        }

        public void Dispose()
        {
        }

        public PhanSo this[int vitri]
        {
            get
            {
                if (vitri < 0 || vitri > dsPhanSo.Count - 1)
                {
                    throw new Exception("Vi tri khong ton tai!");
                }
                return this.dsPhanSo[vitri];
            }
        }
    }
}
