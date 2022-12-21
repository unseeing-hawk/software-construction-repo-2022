using DB_scientificLibrary.login;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_scientificLibrary
{
    internal static class Program
    {

        public static SqlConnection cn = null;

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            cn = new SqlConnection("Data Source =  desktop-fsjq9s9; " +
                                   "Initial Catalog = Scientific_Library; " +
                                   "Integrated Security = True;");
            try
            {
                cn.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Connection failed!!", "Connection", MessageBoxButtons.OK);
            }

            //Application.Run(new author.AdminWindow(1));
            //Application.Run(new reader.ReaderWindow(1014));
            //Application.Run(new author.AuthorWindow(4));
            Application.Run(new WelcomeWindow());
        }
    }
}
