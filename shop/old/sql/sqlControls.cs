using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_scientificLibrary.sql
{
    static class sqlControls
    {
        public static void fillDataGridView(string selectCommand, DataGridView dataGridView)
        {
            if (selectCommand == "") return;
            
            SqlDataAdapter dataAdapter = new SqlDataAdapter(selectCommand, Program.cn);
            //SqlDataAdapter dataAdapter = new SqlDataAdapter(selectCommand, Program.cn);

            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridView.ReadOnly = true;
            dataGridView.DataSource = ds.Tables[0];
        }
    }
}
