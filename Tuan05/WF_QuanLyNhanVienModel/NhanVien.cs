using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NNLTCSharp.WinForms
{
    public class NhanVien
    {
        private string maNV;

        public string MaNV
        {
            get { return maNV; }
            set { maNV = value; }
        }
        private string hoTen;

        public string HoTen
        {
            get { return hoTen; }
            set { hoTen = value; }
        }
        private DateTime ngaySinh;

        public DateTime NgaySinh
        {
            get { return ngaySinh; }
            set { ngaySinh = value; }
        }
        private string diaChi;

        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }

        public NhanVien() { }

        public NhanVien(string manv, string hoten, DateTime ns, string dc)
        {
            this.NgaySinh = ns;
            this.HoTen = hoten;
            this.MaNV = manv;
            this.DiaChi = dc;
        }

        public NhanVien(NhanVien nv)
        {
            this.NgaySinh = nv.NgaySinh;
            this.HoTen = nv.HoTen;
            this.MaNV = nv.MaNV;
            this.DiaChi = nv.DiaChi;
        }

        public override string ToString()
        {
            string kq = "";
            kq += "THONG TIN NHAN VIEN:\n";
            kq += string.Format("+ Ma nv: {0}\n", this.MaNV);
            kq += string.Format("+ Ho ten: {0}\n", this.HoTen);
            kq += string.Format("+ Ngay sinh: {0}\n", this.NgaySinh.ToString("dd/MM/yyyy"));
            kq += string.Format("+ Dia chi: {0}\n", this.DiaChi);
            return base.ToString();
        }

        public static NhanVien Parse(string content)
        {
            NhanVien nv = new NhanVien();

            string []ds = content.Split(new string[] { "," },StringSplitOptions.RemoveEmptyEntries);
            nv.MaNV = ds[0];
            nv.HoTen = ds[1];
            nv.NgaySinh = DateTime.Parse(ds[2]);
            nv.DiaChi = ds[3];

            return nv;
        }

    }
}
