using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VdArrayList
{
    public partial class frmArrList : Form
    {
        static ArrayList arList;

        public frmArrList()
        {
            InitializeComponent();
        }
        
        public void AssignValue()
        {
            for(int i = 0; i < 5; i++)
            { 
                ClassVD cls = new ClassVD();
                cls.name = "HCM " + i.ToString();
                cls.value = "Ho Chi Minh " + i.ToString();
                arList.Add(cls);
            }
        }

        public void PrintValue()
        {
            lblHienThi.Text = "";
            lblHienThi.Text = "In gia tri:\n";

            foreach (ClassVD cls in arList)
            {
                lblHienThi.Text +="Name: " + cls.name + ", Value: " + cls.value + "\n";
            }
        }

        private void btnThiHanh_Click(object sender, EventArgs e)
        {
            arList = new ArrayList();
            AssignValue();
            PrintValue();
        }

    }
}