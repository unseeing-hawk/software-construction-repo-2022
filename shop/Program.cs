using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shop
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
                                   "Initial Catalog = shop; " +
                                   "Integrated Security = True;");
            try
            {
                cn.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Connection failed!!", "Connection", MessageBoxButtons.OK);
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new login.WelcomeWindow());
            //Application.Run(new user.UserWindow(1));
        }
    }
}
