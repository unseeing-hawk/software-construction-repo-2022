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
    static class Users
    {
        public static void readerRegister(string fio, string email, string date, string password)
        {
            SqlCommand cmd = new SqlCommand("ReaderRegister", Program.cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@fio", SqlDbType.VarChar).Value = fio;
            cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = email;
            cmd.Parameters.Add("@birth", SqlDbType.Date).Value = date;
            cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = password;

            cmd.ExecuteNonQuery();
        }

        public static void authorRegister(string fio, string email, string date, string password)
        {
            SqlCommand cmd = new SqlCommand("AuthorRegister", Program.cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@fio", SqlDbType.VarChar).Value = fio;
            cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = email;
            cmd.Parameters.Add("@birth", SqlDbType.Date).Value = date;
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

        public static string getUserRentalsSelect(string idUser)
        {
            return "SELECT " +
                                "Rentals.[IDRental], " +
                                "Editions.[IDEdition], " +
                                "Editions.[Name] AS EditionName, " +
                                "(SELECT " +
                                "STUFF((SELECT '; ' + CAST(Users.FIO AS VARCHAR(150)) " +
                                        "FROM AuthorEdition ae2 INNER JOIN Users ON ae2.IDAuthor = Users.IDUser " +
                                        "WHERE ae1.IDEdition = ae2.IDEdition FOR XML PATH('')),1,1,'') " +
                                    "FROM AuthorEdition ae1 " +
                                    "WHERE IDEdition = Editions.IDEdition " +
                                    "GROUP BY IDEdition) AS authorsEdition, " +
                                "CASE Rentals.[Status] WHEN 0 " +
                                    "THEN 'Арендовано' " +
                                    "ELSE 'Возвращено' " +
                                "END AS RentalStatus, " +
                                "Rentals.[Count], " +
                                "Rentals.[BorrowDate], " +
                                "Rentals.[ReturnDate] " +
                         "FROM Users " +
                         "INNER JOIN Rentals ON Rentals.IDReader = Users.IDUser " +
                         "INNER JOIN Editions ON Editions.IDEdition = Rentals.IDEdition " +
                         "WHERE Users.IDUser = " + idUser + " " +
                         "ORDER BY Status ASC";
        }
    }
}
