using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
namespace CarLoggerApp
{
       
    public partial class MainFrom : Form
    {
        public ArrayList arTheCars = null;
        
        private void UpdateGrid()
        {
            if (arTheCars != null)
            {
                //Tạo đối tượng DataTable mang tên Inventory
                DataTable inventory = new DataTable("Inventory");

                //Tạo các đối tượng DataColumn
                DataColumn petName = new DataColumn("Pet Name");
                DataColumn make = new DataColumn("Car Make");
                DataColumn color = new DataColumn("Car Color");

                //Thêm cột vào bảng dữ liệu Invetory
                inventory.Columns.Add(petName);
                inventory.Columns.Add(make);
                inventory.Columns.Add(color);
                //Duyệt qua ArrayList để tạo những hàng dữ liệu
                foreach (Car c in arTheCars)
                {
                    //Tạo một hàng dữ liệu
                    DataRow newRow;
                    newRow = inventory.NewRow();
                    newRow["Pet Name"] = c.petName;
                    newRow["Car Make"] = c.make;
                    newRow["Car Color"] = c.color;
                    inventory.Rows.Add(newRow);
                }
                //Gắn nguồn dữ liệu cho DataGrid
                carDataGrid.DataSource = inventory;
            }
        }
       
        public MainFrom()
        {
            InitializeComponent();
            CenterToScreen();
            
            //Thêm vài chiếc xe
            arTheCars = new ArrayList();
            arTheCars.Add(new Car("Siddhartha","BWM","Silver"));
            arTheCars.Add(new Car("Chucky","Caravan","Pea Soup Green"));
            arTheCars.Add(new Car("Fred","Audi TT","Red"));
            
            //Cho hiển thị nội dung của DataGrid
            UpdateGrid();
        }

        private void mnuFile_Make_Click(object sender, EventArgs e)
        {
            AddCar d = new AddCar();
            d.SetupOKCancel();
            d.ShowDialog();
            if (d.DialogResult == DialogResult.OK)
            {
                arTheCars.Add(d.theCar);
                UpdateGrid();
            }
        }

        private void mnuFile_Save_Click(object sender, EventArgs e)
        {
            //Kiểm tra có tên tập tin chưa
            if (mySaveFile.ShowDialog() == DialogResult.OK)
            {
                Stream myStream = null;
                if ((myStream = mySaveFile.OpenFile()) != null)
                {
                    //Save các xe
                    BinaryFormatter myBinaryFormat = new BinaryFormatter();
                    myBinaryFormat.Serialize(myStream, arTheCars);
                    myStream.Close();
                }
            }
        }

        private void mnuFile_Open_Click(object sender, EventArgs e)
        {
            //Kiểm tra có tên tập tin chưa
            if (myOpenFile.ShowDialog() == DialogResult.OK)
            {
                //Xóa trắng ArrayList hiện hành
                arTheCars.Clear();
                Stream myStream = null;
                if ((myStream = myOpenFile.OpenFile()) != null)
                {
                    //Đọc dữ liệu các đối tượng Car
                    BinaryFormatter myBinaryFormat = new BinaryFormatter();
                    arTheCars = (ArrayList)myBinaryFormat.Deserialize(myStream);
                    myStream.Close();
                    UpdateGrid();
                }
            }
        }

        private void mnuFile_Clear_Click(object sender, EventArgs e)
        {
            arTheCars.Clear();
            UpdateGrid();
        }

        private void mnuFile_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }       
    }
}