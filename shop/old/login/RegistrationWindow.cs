using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_scientificLibrary.login
{
    public partial class RegistrationWindow : Form
    {
        public RegistrationWindow()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            WelcomeWindow welcome = new WelcomeWindow();
            Hide();
            welcome.ShowDialog();
            Close();
        }

        private void registrationButton_Click(object sender, EventArgs e)
        {
            if (!utils.Parser.checkFIO(fio_TextBox.Text))
            {
                MessageBox.Show("Введены некорректные инициалы.", "Ошибка", MessageBoxButtons.OK);
                return;
            }
            if (!utils.Parser.checkEmail(email_textBox.Text))
            {
                MessageBox.Show("Введите корректный email!", "Ошибка", MessageBoxButtons.OK);
                return;
            }
            if (password_textBox.Text.Length == 0)
            {
                MessageBox.Show("Введите ваш пароль!", "Ошибка", MessageBoxButtons.OK);
                return;
            }

            try
            {
                string password = utils.Parser.CreatePasswordHash(password_textBox.Text);
                sql.Users.readerRegister(fio_TextBox.Text,
                                         email_textBox.Text,
                                         DateTime.Parse(dateTimePicker.Text).ToString(),
                                         password);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK);
                return;
            }

            SqlDataReader res = sql.Users.selectUser(email_textBox.Text);
            if (res.Read())
            {
                reader.ReaderWindow reader = new reader.ReaderWindow(res.GetInt32(0));
                res.Close();
                Hide();
                reader.ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show("Ошибка регистрации, повторите вход.", "Ошибка", MessageBoxButtons.OK);
            }
            res.Close();
        }
    }
}
