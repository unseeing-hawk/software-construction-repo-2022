using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_scientificLibrary.sql
{
    static class Editions
    {
        public static void addEdition(string name, int year, string type, string publisher, int count, int idAuthor)
        {
            SqlCommand cmd = new SqlCommand("AddEdition", Program.cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = name;
            cmd.Parameters.Add("@year", SqlDbType.Int).Value = year;
            cmd.Parameters.Add("@type", SqlDbType.VarChar).Value = type;
            cmd.Parameters.Add("@publisher", SqlDbType.VarChar).Value = publisher;
            cmd.Parameters.Add("@count", SqlDbType.Int).Value = count;
            cmd.Parameters.Add("@idAuthor", SqlDbType.Int).Value = idAuthor;

            cmd.ExecuteNonQuery();
        }

        public static SqlDataReader selectEdition(int id)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Editions WHERE IDEdition=@id", Program.cn);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;

            return cmd.ExecuteReader();
        }

        public static void updateEdition(int id, string name, int year, string type, string publisher, int count)
        {
            SqlCommand cmd = new SqlCommand("UPDATE Editions SET " +
                                                            "Name = @name, " +
                                                            "Year = @year, " +
                                                            "TypeOfEdition = @type, " +
                                                            "Publisher = @publisher, " +
                                                            "Count = @count " +
                                            "WHERE IDEdition = @idEdition", Program.cn);

            cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = name;
            cmd.Parameters.Add("@year", SqlDbType.Int).Value = year;
            cmd.Parameters.Add("@type", SqlDbType.VarChar).Value = type;
            cmd.Parameters.Add("@publisher", SqlDbType.VarChar).Value = publisher;
            cmd.Parameters.Add("@count", SqlDbType.Int).Value = count;
            cmd.Parameters.Add("@idEdition", SqlDbType.Int).Value = id;

            cmd.ExecuteNonQuery();
        }

        public static string getAllEditionsSelect()
        {
            return "SELECT * FROM ShowEditions";
        }

        public static string getEditionsTopSelect()
        {
            return "SELECT * FROM TopEditions";
        }

        public static string getAuthorEditionsTopSelect(string idAuthor)
        {
            return "SELECT TOP (SELECT COUNT(*) FROM Reviews) Editions.Name, " +
                                      "ROUND(AVG(CAST(Reviews.Rating AS FLOAT)), 2) AS AverageRating " +
                    "FROM Editions " +
                    "INNER JOIN Reviews ON Editions.IDEdition = Reviews.IDEdition " +
                    "INNER JOIN AuthorEdition ON AuthorEdition.IDAuthor = " + idAuthor + " AND " +
                                                "AuthorEdition.IDEdition = Editions.IDEdition " +
                    "GROUP BY Editions.Name ORDER BY AverageRating DESC";
        }

        public static string getReadersTopSelect()
        {
            return "SELECT * FROM ReadersTop";
        }

        public static string getAuthorsTopSelect()
        {
            return "SELECT * FROM AuthorsTop";
        }

        public static string getNoReturnedEditionsSelect()
        {
            return "SELECT * FROM NoReturnedEditions";
        }

        public static string getReaderNoReturnedEditionsSelect(string id)
        {
            return "SELECT Editions.[Name], " +
                          "Rentals.[Count], " +
                          "Rentals.[BorrowDate], " +
                          "Rentals.[ReturnDate] FROM Editions, Rentals " +
                   "WHERE Rentals.[Status] = 0 " +
                          "AND Rentals.IDReader = " + id + " AND " +
                          "Rentals.IDEdition = Editions.IDEdition " +
                   "ORDER BY[ReturnDate] ASC";
        }

        public static string getFindEditionByEditionNameOrAndAuthorSelect(string editionName = "", string idAuthor = "")
        {
            if (editionName == "" && idAuthor == "") return "";

            string result =
                "SELECT Editions.Name, " +
                          "Editions.Year, " +
                          "Editions.TypeOfEdition, " +
                          "Editions.Publisher, " +
                          "Editions.Count, " +
                          "(SELECT " +
                          "STUFF((SELECT '; ' + CAST(Users.FIO AS VARCHAR(150)) " +
                                 "FROM AuthorEdition ae2 INNER JOIN Users ON ae2.IDAuthor = Users.IDUser " +
                                 "WHERE ae1.IDEdition = ae2.IDEdition FOR XML PATH('')),1,1,'') " +
                          "FROM AuthorEdition ae1 " +
                          "WHERE IDEdition = Editions.IDEdition " +
                          "GROUP BY IDEdition) AS authorsEdition " +
                   "FROM Editions";

            if (editionName != "" && idAuthor == "")
                result += " WHERE Editions.Name = '" + editionName + "'";
            else if (editionName == "" && idAuthor != "")
                result += ", AuthorEdition WHERE AuthorEdition.IDAuthor=" + idAuthor + 
                                            " AND Editions.IDEdition=AuthorEdition.IDEdition";
            else
                result += ", AuthorEdition WHERE AuthorEdition.IDAuthor=" + idAuthor +
                                            " AND Editions.IDEdition=AuthorEdition.IDEdition " +
                                            "AND Editions.Name = '" + editionName + "'";

            return result;
        }
    
        public static SqlDataReader searchEdition(string name, int year, string type, string publisher, int idAuthor)
        {
            SqlCommand cmd = new SqlCommand("SearchEdition", Program.cn);
            cmd.CommandType = CommandType.StoredProcedure;

            if (name == "") cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = DBNull.Value;
            else cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = name;

            if (year == -1) cmd.Parameters.Add("@year", SqlDbType.Int).Value = DBNull.Value;
            else cmd.Parameters.Add("@year", SqlDbType.Int).Value = year;

            if (type == "") cmd.Parameters.Add("@type", SqlDbType.VarChar).Value = DBNull.Value;
            else cmd.Parameters.Add("@type", SqlDbType.VarChar).Value = type;

            if (publisher == "") cmd.Parameters.Add("@publisher", SqlDbType.VarChar).Value = DBNull.Value;
            else cmd.Parameters.Add("@publisher", SqlDbType.VarChar).Value = publisher;

            if (idAuthor == -1) cmd.Parameters.Add("@idAuthor", SqlDbType.Int).Value = DBNull.Value;
            else cmd.Parameters.Add("@idAuthor", SqlDbType.Int).Value = idAuthor;

            return cmd.ExecuteReader();
        }

        public static DataTable getAuthorEditionsDataTable(string idAuthor)
        {
            string cmd = "SELECT * FROM Editions " +
                         "INNER JOIN AuthorEdition ON Editions.IDEdition = AuthorEdition.IDEdition " +
                         "WHERE AuthorEdition.IDAuthor = " + idAuthor +
                         " ORDER BY[Name] ASC";

            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd, Program.cn);

            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);

            return ds.Tables[0];
        }

        public static void insertAuthorIntoEdition(string idAuthor, string idEdition)
        {
            if (idEdition == "") idEdition = "IDENT_CURRENT('Editions')";

            string insert = "IF EXISTS(SELECT* FROM AuthorEdition " +
                                      "WHERE IDAuthor= " + idAuthor + " AND " +
                                            "IDEdition = " + idEdition + ")" +
                            "BEGIN " +
                                "raiserror('У этого издания уже есть такой автор!!!', 16, 1) " +
                                "RETURN " +
                            "END " +
                            "INSERT INTO AuthorEdition VALUES(" + idAuthor + ", " + idEdition + ")";

            SqlCommand cmd = new SqlCommand(insert, Program.cn);
            cmd.ExecuteNonQuery();
        }
    }
}
