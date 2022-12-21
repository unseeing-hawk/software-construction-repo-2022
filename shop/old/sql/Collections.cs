using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_scientificLibrary.sql
{
    static class Collections
    {
        public static void addCollection(int idAuthor, string name, string date, string description, int idEdition)
        {
            SqlCommand cmd = new SqlCommand("AddCollection", Program.cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@idAuthor", SqlDbType.Int).Value = idAuthor;
            cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = name;
            cmd.Parameters.Add("@date", SqlDbType.Date).Value = date;
            cmd.Parameters.Add("@descripsion", SqlDbType.VarChar).Value = description;
            cmd.Parameters.Add("@idEdition", SqlDbType.Int).Value = idEdition;

            cmd.ExecuteNonQuery();
        }

        public static string getAuthorCollectionsSelect(string id)
        {
            return "SELECT [IDCollection], [Name] AS CollectionName, [Date], [Description], " +
                           "(SELECT " +
                           "STUFF((SELECT ', ' + CAST(Editions.Name AS VARCHAR(150)) " +
                                  "FROM CollectionEdition ce2 INNER JOIN Editions ON ce2.IDEdition = Editions.IDEdition " +
                                  "WHERE ce1.IDCollection = ce2.IDCollection FOR XML PATH('')), 1, 1, '') " +
                           "FROM CollectionEdition ce1 " +
                           "WHERE IDCollection = Collections.IDCollection " +
                           "GROUP BY IDCollection ) AS collectionsEdition " +
                   "FROM Collections " +
                   "WHERE IDAuthor = " + id + " " +
                   "ORDER BY[Name] ASC";
        }

        public static string getAllCollectionsSelect()
        {
            return "SELECT * FROM ShowCollections";
        }

        public static string getEditionsByCollectionIDSelect(string idAuthor, string idCollection)
        {
            return "SELECT Editions.IDEdition, Editions.Name, Editions.Year, Editions.TypeOfEdition, Editions.Publisher  " +
                   "FROM Editions " +
                   "INNER JOIN CollectionEdition ON CollectionEdition.IDEdition = Editions.IDEdition " +
                   "INNER JOIN Collections ON CollectionEdition.IDCollection = Collections.IDCollection " +
                   "WHERE Collections.IDAuthor = " + idAuthor + " AND " +
                         "Collections.IDCollection = " + idCollection;
        }

        public static void insertEditionIntoCollection(string idCollection, string idEdition)
        {
            if (idCollection == "") idCollection = "IDENT_CURRENT('Collections')";

            string insert = "IF EXISTS(SELECT* FROM CollectionEdition " +
                                      "WHERE IDCollection= " + idCollection + " AND " +
                                            "IDEdition = " + idEdition + ")" +
                            "BEGIN " +
                                "raiserror('Издание уже добавлено в этот сборник!!!', 16, 1) " +
                                "RETURN " +
                            "END " +
                            "INSERT INTO CollectionEdition VALUES(" + idCollection + ", " + idEdition + ")";

            SqlCommand cmd = new SqlCommand(insert, Program.cn);
            cmd.ExecuteNonQuery();
        }

        public static void deleteEditionFromCollection(string idEdition, string idCollection)
        {
            string deleteStr = "DELETE FROM CollectionEdition WHERE IDCollection=" + idCollection + " AND " +
                                                                   "IDEdition=" + idEdition;
            SqlCommand cmd = new SqlCommand(deleteStr, Program.cn);
            cmd.ExecuteNonQuery();
        }

        public static void deleteCollection(string idCollection)
        {
            string deleteStr = "DELETE FROM CollectionS WHERE IDCollection=" + idCollection;
            SqlCommand cmd = new SqlCommand(deleteStr, Program.cn);

            cmd.ExecuteNonQuery();
        }

    }
}
