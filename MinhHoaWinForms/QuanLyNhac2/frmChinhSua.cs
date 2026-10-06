using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLyNhac2
{
    public partial class frmChinhSua : Form
    {
        public frmChinhSua()
        {
            InitializeComponent();
        }

        public TextBox LoiNhac
        {
            get
            {
                return txtLoiNhac;
            }
            set
            {
                txtLoiNhac = value;
            }
        }
        public Label TenBaiHat
        {
            get { return lblTenBaiHat; }
            set { lblTenBaiHat = value; }
        }
        public Label TenNhacSi
        {
            get {return lblNhacSi ;}
            set {lblNhacSi=value ;}
        }
        public Label TenCaSi
        {
            get {return lblTenCaSi ;}
            set { lblTenCaSi = value; }
        }
        public Label TheLoai
        {
            get {return lblTheLoai ;}
            set {lblTheLoai=value ;}
        }
        public Label Album
        {
            get {return lblAlbum ;}
            set {lblAlbum=value ;}
        }
        public Label DuongDan
        {
            get {return lblDuongDan ;}
            set {lblDuongDan=value ;}
        }

    }
}