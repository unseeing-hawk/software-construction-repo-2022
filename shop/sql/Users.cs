using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop.sql
{
    static class Users
    {
        public static void userRegister(string fio, string email, string date, string password)
        {
            SqlCommand cmd = new SqlCommand("UserRegister", Program.cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@fio", SqlDbType.VarChar).Value = fio;
            cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = email;
            cmd.Parameters.Add("@birth", SqlDbType.Date).Value = date;
            cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = password;

            cmd.ExecuteNonQuery();
        }

        public static void updateUser(int id, string fio, string email, string birth)
        {
            SqlCommand cmd = new SqlCommand("UPDATE Users SET FIO=@fio, " +
                                                             "Email=@email, " +
                                                             "DateOfBirth=@birth " +
                                            "WHERE IDUser=@id", Program.cn);

            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@fio", SqlDbType.VarChar).Value = fio;
            cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = email;
            cmd.Parameters.Add("@birth", SqlDbType.Date).Value = birth;

            cmd.ExecuteNonQuery();
        }

        public static void updateUser(int id, string password)
        {
            SqlCommand cmd = new SqlCommand("UPDATE Users SET Password=@password " +
                                            "WHERE IDUser=@id", Program.cn);

            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = password;

            cmd.ExecuteNonQuery();
        }

        public static SqlDataReader selectUser(string email, string password)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Users WHERE Email=@em AND Password=@pass", Program.cn);
            cmd.Parameters.Add("@em", SqlDbType.VarChar).Value = email;
            cmd.Parameters.Add("@pass", SqlDbType.VarChar).Value = password;

            return cmd.ExecuteReader();
        }

        public static SqlDataReader selectUser(string email)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Users WHERE Email=@em", Program.cn);
            cmd.Parameters.Add("@em", SqlDbType.VarChar).Value = email;

            return cmd.ExecuteReader();
        }

        public static SqlDataReader selectUser(int id)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Users WHERE IDUser=@id", Program.cn);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;

            return cmd.ExecuteReader();
        }

    }
}
