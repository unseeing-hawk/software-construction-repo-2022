using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shop.sql
{
    static class Bank
    {
        public static void buyGame(string phone, string cardnum, string carddate, int cardcvv, int sum)
        {
            SqlConnection cn = new SqlConnection("Data Source =  desktop-fsjq9s9; " +
                                                 "Initial Catalog = bank; " +
                                                 "Integrated Security = True;");

            try
            {
                cn.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Connection failed!!", "Connection", MessageBoxButtons.OK);
            }

            SqlCommand cmd = new SqlCommand("BuyGame", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@phone", SqlDbType.VarChar).Value = phone;
            cmd.Parameters.Add("@cardnum", SqlDbType.VarChar).Value = cardnum;
            cmd.Parameters.Add("@carddate", SqlDbType.Date).Value = carddate;
            cmd.Parameters.Add("@cardcvv", SqlDbType.Int).Value = cardcvv;
            cmd.Parameters.Add("@sum", SqlDbType.Int).Value = sum;

            cmd.ExecuteNonQuery();
            cn.Close();
        }
    }
}
