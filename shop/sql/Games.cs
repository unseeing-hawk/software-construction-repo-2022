using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop.sql
{
    static class Games
    {
        public static void addUserGame(int idUser, int idGame)
        {
            SqlCommand cmd = new SqlCommand("AddUserGame", Program.cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@idUser", SqlDbType.Int).Value = idUser;
            cmd.Parameters.Add("@idGame", SqlDbType.Int).Value = idGame;

            cmd.ExecuteNonQuery();
        }

        public static string selectUserGames(string id)
        {
            return "SELECT Games.IDGame, " +
                          "Games.GameName, " +
                          "Games.Description " +
                   "FROM Games " +
                   "INNER JOIN Payments ON Payments.IDGame = Games.IDGame AND " +
                                          "Payments.IDUser = " + id;
        }

        public static void downloadGame(string idGame, string userpath)
        {
            SqlCommand command = new SqlCommand("SELECT GameName, " +
                                                  "GameData.PathName(), " +
                                                  "GET_FILESTREAM_TRANSACTION_CONTEXT() " +
                                                  "FROM Games " +
                                                  "WHERE IDGame=" + idGame,
                                          Program.cn);

            SqlTransaction tran = Program.cn.BeginTransaction(IsolationLevel.ReadCommitted);
            command.Transaction = tran;

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    // Get the pointer for the file
                    string path = string.Empty;
                    try
                    {
                        path = reader.GetString(1);
                    }
                    catch (SqlNullValueException)
                    {
                        return;
                    }
                    byte[] transactionContext = reader.GetSqlBytes(2).Buffer;

                    // Create the SqlFileStream
                    using (Stream fileStream = new SqlFileStream(path,
                                                                 transactionContext,
                                                                 FileAccess.Read,
                                                                 FileOptions.SequentialScan,
                                                                 allocationSize: 0))
                    {
                        string gameName = reader.GetString(0) + ".zip";
                        using (var userfileStream = new System.IO.FileStream(userpath + "\\" + gameName, FileMode.Create))
                        {
                            fileStream.CopyTo(userfileStream);
                        }
                    }
                }
            }

            tran.Commit();
        }
    }
}
