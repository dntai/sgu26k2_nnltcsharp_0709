using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NNLTCS.BaiTap.TinhToanPhanSo
{
    public class PhanSo
    {
        private int tuSo;
        private int mauSo;

        public int TuSo
        {
            get { return tuSo; }
            set { tuSo = value; }
        }

        public int MauSo
        {
            get { return mauSo; }
            set 
            {
                if (value == 0)
                    throw new Exception("Mau so bang 0!");
                mauSo = value; 
            }
        }

        public PhanSo()// ham tao mac dinh (0/1)
        {
            this.tuSo = 0;
            this.mauSo = 1;
        }
        public PhanSo(int n)// tao tu so nguyen
        {
            this.tuSo = n;
            this.mauSo = 1;
        }

        public PhanSo(int tu, int mau) // tao tu tu, mau
        {
            this.tuSo = tu;
            this.mauSo = mau;
        }
        public PhanSo(PhanSo p)// ham tao sao chep
        {
            this.tuSo = p.tuSo;
            this.mauSo = p.mauSo;
        }
        public override string ToString()
        {
            if (this.mauSo == 1)
            {
                return string.Format("[{0}]", this.tuSo);
            }
            else
            {
                return string.Format("[{0}/{1}]", this.tuSo, this.mauSo);
            }
        }
        public PhanSo tinhCong(PhanSo b)
        {
            int tu_moi = this.tuSo * b.mauSo + this.mauSo * b.tuSo;
            int mau_moi = this.mauSo * b.mauSo;
            PhanSo kq = new PhanSo(tu_moi, mau_moi);
            kq.rutGon();
            return kq;
        }
        public static PhanSo tinhCong(PhanSo a, PhanSo b)
        {
            int tu_moi = a.tuSo * b.mauSo + a.mauSo * b.tuSo;
            int mau_moi = a.mauSo * b.mauSo;
            PhanSo kq = new PhanSo(tu_moi, mau_moi);
            kq.rutGon();
            return kq;
        }
        public static PhanSo operator +(PhanSo a, PhanSo b)
        {
            return PhanSo.tinhCong(a, b);
        }

        public void rutGon()
        {
            int uc = PhanSo.uocSoChungLonNhat(this.tuSo, this.mauSo);
            this.tuSo = this.tuSo / uc;
            this.mauSo = this.mauSo / uc;
        }

        private static int uocSoChungLonNhat(int a, int b)
        {
            while (b != 0)
            {
                int tmp = a;
                a = b;
                b = tmp % a;
            }
            return a;
        }
    }
}
