using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace NNLTCSharp.WinForms
{
    public delegate void ThemNhanVienEventHandler(object sender, EventArgs e);
    public class DuLieuChuongTrinh
    {
        public event ThemNhanVienEventHandler ThemNhanVien;

        private static DuLieuChuongTrinh instance;
        private DuLieuChuongTrinh() { }
        public static DuLieuChuongTrinh GetModel
        {
            get
            {
                if (DuLieuChuongTrinh.instance == null)
                    DuLieuChuongTrinh.instance = new DuLieuChuongTrinh();
                return DuLieuChuongTrinh.instance;
            }
        }


        private List<NhanVien> dsNhanVien;

        public List<NhanVien> DanhSachNhanVien
        {
            get 
            {
                return this.dsNhanVien; 
            }
        }

        public void themNhanVien(NhanVien nv)
        {
            this.dsNhanVien.Add(nv);
            if (this.ThemNhanVien != null)
                this.ThemNhanVien(this, EventArgs.Empty); // Raise Event
        }

        public void NapDuLieu(string path)
        {
            StreamReader rd = new StreamReader(path);
            this.dsNhanVien = new List<NhanVien>();
            while (rd.EndOfStream == false)
            {
                string line = rd.ReadLine();
                NhanVien nv = NhanVien.Parse(line);
                dsNhanVien.Add(nv);
            }

            rd.Close();
            rd.Dispose();
        }

    }
}
