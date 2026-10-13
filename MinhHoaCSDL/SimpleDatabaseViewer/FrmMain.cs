using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Configuration;
using Buoi10Bai2_SimpleDatabaseViewer.Model;
using System.Data.SqlClient;

namespace Buoi10Bai2_SimpleDatabaseViewer
{
    public partial class FrmMain : Form
    {
        DataModel model = DataModel.Model;
        DataTable table = null;
        string table_name = "";

        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                if (model.Connect(ConfigurationManager.AppSettings["connection"]) == true)
                {
                    // Thanh cong
                    MessageBox.Show("Ket noi thanh cong!");
                    // Nap du lieu vao cboDatabases
                    DataTable dt = model.ExecuteStoredProc("sp_databases");
                        // C1. Tu lam: Model --> View
                    /*
                    cboDatabases.Items.Clear();
                    for (int i = 0; i <= dt.Rows.Count - 1; i++)
                    {
                        cboDatabases.Items.Add(dt.Rows[i]["DATABASE_NAME"].ToString());
                    }*/
                        // C2. DataBind: Model <--> View
                    cboDatabases.DataSource = dt;
                    cboDatabases.DisplayMember = "DATABASE_NAME";
                    cboDatabases.ValueMember = "DATABASE_NAME";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi chuong trinh: " + ex.Message);
            }
        }

        private void cboDatabases_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboDatabases.ValueMember is string && cboDatabases.Text != "")
                {
                    string dbname = cboDatabases.Text;
                    model.ChangeDatabase(dbname);

                    // Truyen du lieu
                    // C1.
                    /*
                    SqlParameter param = new SqlParameter();
                    param.ParameterName = "@table_type";
                    param.Value = "'TABLE'";
                    DataTable dt = model.ExecuteStoredProc("sp_tables", param);*/
                    Dictionary<string, object> dsParams = new Dictionary<string, object>();
                    dsParams["table_type"] = "'TABLE'";
                    DataTable dt = model.ExecuteStoredProc("sp_tables", dsParams);

                    // DataBind
                    cboTables.DataSource = dt;
                    cboTables.DisplayMember = "TABLE_NAME";
                    cboTables.ValueMember = "TABLE_NAME";

                }
            }
            catch (Exception ee)
            {
            }
        }

        private void cboTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTables.SelectedValue is string && cboTables.SelectedValue.ToString()!= "")
            {
                string table_name = cboTables.SelectedValue.ToString();
                this.table_name = table_name;

                string sqlScalar = "SELECT COUNT(*) FROM " + table_name;
                lblNumRows.Text = model.ExecuteSelectScalar(sqlScalar).ToString();

                string sqlSelect = "SELECT * FROM " + table_name;
                DataTable dt = model.ExecuteSelect(sqlSelect);
                this.table = dt;

                lvData.Columns.Clear();
                // Column
                foreach (DataColumn dc in dt.Columns)
                {
                    lvData.Columns.Add(dc.ColumnName);
                }
                // Row
                lvData.Items.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = row[0].ToString();
                    for (int i = 1; i <= row.ItemArray.Length - 1; i++)
                    {
                        item.SubItems.Add(row[i].ToString());
                    }
                    lvData.Items.Add(item);
                }

            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            FrmUpdateData frm = new FrmUpdateData();
            frm.Data = this.table;
            DialogResult ret = frm.ShowDialog();
            if (ret == System.Windows.Forms.DialogResult.OK)
            {
                DataTable tblUpdate = frm.Data;

                // Cap nhat tro lai Server
                // Cach1. Auto
                    string sql = "SELECT * FROM " + this.table_name;
                    SqlDataAdapter da = new SqlDataAdapter(sql, model.Connection);
                    // Xay dung tham so
                    // C1. Neu truy van tren 1 bang
                    SqlCommandBuilder builder = new SqlCommandBuilder(da);
                    da.InsertCommand = builder.GetInsertCommand();
                    da.DeleteCommand = builder.GetDeleteCommand();
                    da.UpdateCommand = builder.GetUpdateCommand();// viet lai
                    // goi y:
                    //  Lay schema
                    /*
                    SqlConnection conn;
                    conn.GetSchema();*/
                    /*
                    SqlCommand cmd = new SqlCommand();
                    SqlDataReader rd = cmd.ExecuteReader(CommandBehavior.KeyInfo);
                    DataTable dt = rd.GetSchemaTable();*/
                    // Cap nhat len Server
                    da.Update(tblUpdate);// viet lai (xem slide CapNhatDuLieu)
                    // Ghi nhan dong bo
                    tblUpdate.AcceptChanges();
                // Cach 2. Manual

            }
        }
    }
}
