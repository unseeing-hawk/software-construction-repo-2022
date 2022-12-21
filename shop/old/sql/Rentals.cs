using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_scientificLibrary.sql
{
    static class Rentals
    {
        public static void createRental(int idReader, int idEdition, int count, string borrowD, string returnD = "")
        {
            SqlCommand cmd = new SqlCommand("CreateRental", Program.cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@idReader", SqlDbType.Int).Value = idReader;
            cmd.Parameters.Add("@idEdition", SqlDbType.Int).Value = idEdition;
            cmd.Parameters.Add("@count", SqlDbType.Int).Value = count;
            cmd.Parameters.Add("@borrowD", SqlDbType.VarChar).Value = borrowD;

            if (returnD == "")
            {
                cmd.ExecuteNonQuery();
                return;
            }
            cmd.Parameters.Add("@returnD", SqlDbType.VarChar).Value = returnD;

            cmd.ExecuteNonQuery();
        }

        public static void returnRental(int idRental)
        {
            SqlCommand cmd = new SqlCommand("ReturnRental", Program.cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@idRental", SqlDbType.Int).Value = idRental;

            cmd.ExecuteNonQuery();
        }

        public static string getFindRentalsByEditionNameSelect(string idUser, string editionName)
        {
            if (editionName == "") return "";

            return "SELECT " +
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
                         "WHERE Users.IDUser = " + idUser + "  AND Editions.Name='" + editionName + "'" +
                         "ORDER BY Status ASC";
        }

        public static void updateRentalReturnDate(string idRental)
        {
            string commandString = "UPDATE Rentals SET ReturnDate = DATEADD(week, 2, ReturnDate) " +
                                   "WHERE IDRental = " + idRental;
            SqlCommand cmd = new SqlCommand(commandString, Program.cn);
            cmd.ExecuteNonQuery();
        }

        public static void createReview(int idReader, int idEdition, int rating)
        {
            SqlCommand cmd = new SqlCommand("CreateReview", Program.cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@idReader", SqlDbType.Int).Value = idReader;
            cmd.Parameters.Add("@idEdition", SqlDbType.Int).Value = idEdition;
            cmd.Parameters.Add("@rating", SqlDbType.Int).Value = rating;

            cmd.ExecuteNonQuery();
        }
    }
}
