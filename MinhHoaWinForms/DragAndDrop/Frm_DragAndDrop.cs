using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DragAndDrop
{
    public partial class Frm_DragAndDrop : Form
    {
        public Frm_DragAndDrop()
        {
            InitializeComponent();
        }

        private void Frm_DragAndDrop_Load(object sender, EventArgs e)
        {
            String[] TraiCay ={ "Cam", "Quít", "Xoài", "Nhãn", "Sầu riêng", "Bưởi" };
            String[] RauCu ={ "Rau muống", "Cải xanh", "Cà rốt", "Cà chua", "Của hành", "Củ tỏi" };
            TreeNode Nut;
            Nut = FirstTree.Nodes.Add("Trái cây");
            for (int i = 0; i <= 5; i++)
            {
                Nut.Nodes.Add(TraiCay[i]);
            }
            Nut.Expand();

            Nut = SecondTree.Nodes.Add("Rau củ");
            for (int i = 0; i <= 5; i++)
            {
                Nut.Nodes.Add(RauCu[i]);
            }
            Nut.Expand();
        }

        private void tree_MouseDown(object sender, MouseEventArgs e)
        {
            TreeView tree = (TreeView)sender; //đi lấy cây
            TreeNode nut = tree.GetNodeAt(e.X, e.Y); //lấy node dưới con nháy chuột

            tree.SelectedNode = nut;
            //Bắt đầu lôi thả với một bản sao của node
            if (nut != null)
            {
                tree.DoDragDrop(nut.Clone(), DragDropEffects.All);
            }
        }

        private void tree_DragOver(object sender, DragEventArgs e)
        {
            TreeView tree = (TreeView)sender; //đi lấy cây
            e.Effect = DragDropEffects.None; //theo mặc nhiên từ chối lôi thả
            //Kiểm tra dạng thức hợp lệ
            if (e.Data.GetData(typeof(TreeNode)) != null)
            {
                Point pt = new Point(e.X, e.Y); //lấy điểm màn hình
                pt = tree.PointToClient(pt); //Đổi qua tọa độ Treeview
                TreeNode nut = tree.GetNodeAt(pt); //Kiểm tra hợp lệ
                if (nut != null)
                {
                    e.Effect = DragDropEffects.Copy;
                    tree.SelectedNode = nut;
                }
            }
        }

        private void tree_DragDrop(object sender, DragEventArgs e)
        {
            TreeView tree = (TreeView)sender; //đi lấy cây
            Point pt = new Point(e.X, e.Y); //lấy điểm màn hình
            pt = tree.PointToClient(pt); //Đổi qua tọa độ Treeview
            TreeNode nut = tree.GetNodeAt(pt); //Kiểm tra hợp lệ
            //Thêm một node con
            nut.Nodes.Add((TreeNode)e.Data.GetData(typeof(TreeNode)));
            //Cho nhìn thấy node mới thêm vào
            nut.Expand();
        }
        
        private void SecondTree_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                SecondTree.Nodes.Remove(SecondTree.SelectedNode);
            }
        }

        private void FirstTree_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                FirstTree.Nodes.Remove(FirstTree.SelectedNode);
            }
        }   
    }
}