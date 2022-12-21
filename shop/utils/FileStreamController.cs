using System;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data;
using System.IO;
using System.Drawing;
using System.Windows.Media.Imaging;
using System.Windows.Media;
using System.Drawing.Imaging;
using System.Windows;
using System.Windows.Forms;

namespace shop.utils
{
    public partial class FileStreamController : Form
    {
        public FileStreamController()
        {
            InitializeComponent();
        }

        public static Bitmap ReadImageStream(string idUser)
        {
            SqlCommand command = new SqlCommand("SELECT PhotoData.PathName(), " +
                                                       "GET_FILESTREAM_TRANSACTION_CONTEXT() " +
                                                       "FROM Users " +
                                                       "WHERE IDUser=" + idUser,
                                               Program.cn);

            SqlTransaction tran = Program.cn.BeginTransaction(IsolationLevel.ReadCommitted);
            command.Transaction = tran;

            Bitmap bitmap = null;
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    // Get the pointer for the file
                    string path = string.Empty;
                    try
                    {
                        path = reader.GetString(0);
                    }
                    catch (SqlNullValueException)
                    {
                        return null;
                    }
                    byte[] transactionContext = reader.GetSqlBytes(1).Buffer;

                    // Create the SqlFileStream
                    using (Stream fileStream = new SqlFileStream(path,
                                                                 transactionContext,
                                                                 FileAccess.Read,
                                                                 FileOptions.SequentialScan,
                                                                 allocationSize: 0))
                    {
                        try
                        {
                            PngBitmapDecoder decoder = new PngBitmapDecoder(fileStream,
                                                                            BitmapCreateOptions.PreservePixelFormat,
                                                                            BitmapCacheOption.Default);
                            bitmap = BitmapController.GetBitmap(decoder.Frames[0]);
                        } catch (Exception)
                        {
                            bitmap = null;
                        }
                    }
                }
            }

            tran.Commit();
            return bitmap;
        }

        public static void OverwriteFileStream(string idUser, Bitmap file)
        {
            SqlCommand command = new SqlCommand("SELECT PhotoData.PathName(), " +
                                                       "GET_FILESTREAM_TRANSACTION_CONTEXT() " +
                                                       "FROM Users " +
                                                       "WHERE IDUser=" + idUser,
                                                Program.cn);

            SqlTransaction tran = Program.cn.BeginTransaction(IsolationLevel.ReadCommitted);
            command.Transaction = tran;

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    // Get the pointer for file
                    string path = reader.GetString(0);
                    byte[] transactionContext = reader.GetSqlBytes(1).Buffer;

                    // Create the SqlFileStream
                    using (Stream fileStream = new SqlFileStream(path,
                                                                 transactionContext,
                                                                 FileAccess.Write,
                                                                 FileOptions.SequentialScan,
                                                                 allocationSize: 0))
                    {
                        PngBitmapEncoder encoder = new PngBitmapEncoder();
                        encoder.Interlace = PngInterlaceOption.On;
                        encoder.Frames.Add(BitmapFrame.Create(BitmapController.Convert(file)));
                        encoder.Save(fileStream);
                    }
                }
            }
            tran.Commit();
        }
        
    }
}
