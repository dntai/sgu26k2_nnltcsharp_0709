using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SimpleDatabaseViewer
{
    public partial class FrmUpdateData : Form
    {
        DataTable table = null;

        public FrmUpdateData()
        {
            InitializeComponent();
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public DataTable Data
        {
            get
            {
                return this.table;
            }
            set
            {
                this.table = value;
                // DataBind
                this.dgvData.DataSource = this.table;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            // Modal
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (this.table != null)
            {
                this.table.RejectChanges();
            }
            // Modal
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            if (this.table != null)
            {
                this.table.RejectChanges();
            }
        }

    }
}
