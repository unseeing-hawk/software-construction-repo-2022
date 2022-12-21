using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_scientificLibrary
{
    public partial class Table : Form
    {
        private OleDbDataAdapter da;
        public static bool users, orders;

        private void Table_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Text == "Users") users = false;
        }

        public Table(OleDbConnection cn, String str)
        {
            InitializeComponent();
            da = new OleDbDataAdapter("SELECT * FROM " + str, cn);
            DataTable tableCustomers = new DataTable(str);
            ds.Tables.Add(tableCustomers);
            dgTable.SetDataBinding(ds, str);
            da.Fill(ds, str);
            dgTable.DataMember = str;
            Text = str;
            if (Text == "Users") orders = true;

        }
    }
}
