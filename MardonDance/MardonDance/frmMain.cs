using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Configuration;
using MardonDance.DAL;

using System.Data.Sql;
using System.Data.SqlClient;

namespace MardonDance
{
    public partial class frmMain : Form
    {
        private SQLCE.SQLCEDatabase oDatabase;

        public frmMain()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            oDatabase = new SQLCE.SQLCEDatabase(MardonDataAccess.ConnectionString);
        }

        private void btnAddNewContact_Click(object sender, EventArgs e)
        {
            using (frmNewContact frm = new frmNewContact())
            {
                frm.ShowDialog();
            }
        }

    }
}
