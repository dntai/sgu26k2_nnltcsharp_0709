using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FoodTreeview
{
    public partial class FrmFoodTree : Form
    {
        public FrmFoodTree()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            String[] TraiCay ={ "Cam", "Quít", "Xoài", "Nhãn", "Sầu riêng", "Bưởi" };
            String[] RauCu ={ "Rau muống", "Cải bẹ xanh", "Cà rốt", "Cà chua", "Củ hành", "Củ tỏi" };
            TreeNode Nut;
            FoodTree.Nodes.Clear();
            Nut = FoodTree.Nodes.Add("Trái cây");
            for (int i = 0; i <= TraiCay.GetUpperBound(0); i++)
            {
                Nut.Nodes.Add(TraiCay[i]);
            }
            Nut = FoodTree.Nodes.Add("Rau củ quả");
            for (int i = 0; i <= TraiCay.GetUpperBound(0); i++)
            {
                Nut.Nodes.Add(RauCu[i]);
            }
        }

        private void btnExpand_Click(object sender, EventArgs e)
        {
            FoodTree.ExpandAll();
        }

        private void btnCollapse_Click(object sender, EventArgs e)
        {
            FoodTree.CollapseAll();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            FoodTree.Nodes.Clear();
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmFoodTree_Load(object sender, EventArgs e)
        {

        }
    }
}