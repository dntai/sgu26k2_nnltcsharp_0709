using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Windows.Forms;

using System.Data; // Offline: DataSet, DataTable, DataRow, DataColumn, ...
using System.Data.SqlClient; // Online: Data Provider, (Connection), (Command,Paramter,Transaction), (DataReader, DataAdapter)

namespace Buoi10Bai2_SimpleDatabaseViewer.Model
{
    public class DataModel
    {
        #region Singleton
        private static DataModel instance;
        private DataModel()
        {
            this.m_connection = new SqlConnection();
        }
        public static DataModel Model
        {
            get
            {
                if (DataModel.instance == null)
                    DataModel.instance = new DataModel();
                return DataModel.instance;
            }
        }
        #endregion

        #region Field
        private SqlConnection m_connection = null;
        #endregion

        #region SqlHelper

        public bool Connect(string connectionString)
        {
            this.m_connection.ConnectionString = connectionString;
            
            try
            {
                this.m_connection.Open();
                if (this.m_connection.State == ConnectionState.Open)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (SqlException ex)
            {
                // MessageBox.Show(string.Format("Message: {0}\r\n", ex.Message));
                // Ghi Log
                throw ex;
            }
        }

        public void Close()
        {
            try
            {
                if (this.m_connection != null)
                {
                    if (this.m_connection.State != ConnectionState.Closed)
                    {
                        this.m_connection.Close();
                    }
                }
            }
            catch (Exception ee)
            {
            }
        }

        public void ChangeDatabase(string dbname)
        {
            this.m_connection.ChangeDatabase(dbname);
        }

        ~DataModel()
        {
            if (this.m_connection != null)
            {
                this.Close();
                this.m_connection.Dispose();
                this.m_connection = null;
            }
        }

        public DataTable ExecuteStoredProc(string storedProc, params SqlParameter[] dsParams)
        {
            // B1. Tao Command
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = this.m_connection;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = storedProc;

            // B2. Truyen tham so
            cmd.Parameters.AddRange(dsParams);

            // B3. Thuc thi Command
            SqlDataReader reader = cmd.ExecuteReader();

            // B4. Lay du lieu ve
            DataTable dt = new DataTable();
            dt.Load(reader);

            return dt;
        }

        public DataTable ExecuteStoredProc(string storedProc, Dictionary<string,object> dsParams)
        {
            // B1. Tao Command
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = this.m_connection;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = storedProc;

            // B2. Truyen tham so
            foreach (string paramName in dsParams.Keys)
            {
                SqlParameter param = new SqlParameter();
                param.ParameterName = "@" + paramName;
                param.Value = dsParams[paramName];
                // param.SourceVersion, param.SourceColumn
                cmd.Parameters.Add(param);
                    
            }

            // B3. Thuc thi Command
            SqlDataReader reader = cmd.ExecuteReader();

            // B4. Lay du lieu ve
            DataTable dt = new DataTable();
            dt.Load(reader);

            return dt;
        }

        public DataTable ExecuteSelect(string sqlSelect, Dictionary<string,object> dsParams)
        {
            // B1. Tao Command
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = this.m_connection;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sqlSelect;

            // B2. Truyen tham so
            foreach (string paramName in dsParams.Keys)
            {
                SqlParameter param = new SqlParameter();
                param.ParameterName = "@" + paramName;
                param.Value = dsParams[paramName];
                // param.SourceVersion, param.SourceColumn
                cmd.Parameters.Add(param);

            }

            // B3. Thuc thi Command
            SqlDataReader reader = cmd.ExecuteReader();

            // B4. Lay du lieu ve
            DataTable dt = this.LoadTable(reader);

            return dt;
        }

        public DataTable ExecuteSelect(string sqlSelect, params SqlParameter[] dsParams)
        {
            // B1. Tao Command
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = this.m_connection;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sqlSelect;

            // B2. Truyen tham so
            cmd.Parameters.AddRange(dsParams);

            // B3. Thuc thi Command
            SqlDataReader reader = cmd.ExecuteReader();

            // B4. Lay du lieu ve
            DataTable dt = this.LoadTable(reader);

            return dt;
        }

        public DataTable LoadTable(SqlDataReader reader)
        {
            DataTable table = new DataTable();

            // Column
            for (int i = 0; i <= reader.FieldCount - 1; i++)
            {
                DataColumn dt = new DataColumn();
                dt.ColumnName = reader.GetName(i);
                dt.DataType = reader.GetFieldType(i);
                // dt.Expression = "SoLuong*DonGia";
                table.Columns.Add(dt);
            }

            // Row
            while (reader.Read())
            {
                DataRow dr = table.NewRow();

                for (int i = 0; i <= reader.FieldCount - 1; i++)
                {
                    dr[i] = reader[i];
                }

                table.Rows.Add(dr); // --> trang thai la Added
            }
            
            // Dua trang thai ve Unchanged
            table.AcceptChanges();

            reader.Close();
            return table;
        }

        // SELECT COUNT(*) FROM ????
        public object ExecuteSelectScalar(string sqlSelectScalar, params SqlParameter[] dsParams)
        {
            // B1. Tao Command
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = this.m_connection;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sqlSelectScalar;

            // B2. Truyen tham so
            cmd.Parameters.AddRange(dsParams);

            // B3. Thuc thi Command
            object ret = cmd.ExecuteScalar();

            return ret;
        }

        public object ExecuteSelectScalar(string sqlSelectScalar, Dictionary<string, object> dsParams)
        {
            // B1. Tao Command
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = this.m_connection;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sqlSelectScalar;

            // B2. Truyen tham so
            foreach (string paramName in dsParams.Keys)
            {
                SqlParameter param = new SqlParameter();
                param.ParameterName = "@" + paramName;
                param.Value = dsParams[paramName];
                // param.SourceVersion, param.SourceColumn
                cmd.Parameters.Add(param);

            }

            // B3. Thuc thi Command
            object ret = cmd.ExecuteScalar();

            return ret;
        }

        public SqlConnection Connection
        {
            get
            {
                return this.m_connection;
            }
        }

        #endregion
    }
}
