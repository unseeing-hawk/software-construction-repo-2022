using DB_scientificLibrary.author;
using DB_scientificLibrary.reader;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_scientificLibrary.login
{
    public partial class LoginWindow : Form
    {
        public LoginWindow()
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

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (!utils.Parser.checkEmail(login_textBox.Text))
            {
                MessageBox.Show("Введите корректный email!", "Ошибка", MessageBoxButtons.OK);
                return;
            }
            if (password_textBox.Text.Length == 0)
            {
                MessageBox.Show("Введите ваш пароль!", "Ошибка", MessageBoxButtons.OK);
                return;
            }


            SqlDataReader res = null;
            try
            {
                res = sql.Users.selectUser(login_textBox.Text);
                if (res.Read())
                {
                    if (!utils.Parser.VerifyPassword(password_textBox.Text, res.GetString(4)))
                    {
                        MessageBox.Show("Пароль неверный, повторите попытку", "Ошибка", MessageBoxButtons.OK);
                        return;
                    }

                    int id = res.GetInt32(0);
                    switch (res.GetInt32(2))
                    {
                        case 1:
                            res.Close();
                            openWindow(new AdminWindow(id));
                            break;
                        case 2:
                            res.Close();
                            openWindow(new AuthorWindow(id));
                            break;
                        case 3:
                            res.Close();
                            openWindow(new ReaderWindow(id));
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Email неверный, повторите попытку", "Ошибка", MessageBoxButtons.OK);
                }
            } finally { res.Close(); }
        }

        private void openWindow(Form newWindow)
        {
            Hide();
            newWindow.ShowDialog();
            Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            password_textBox.UseSystemPasswordChar = !checkBox1.Checked;
        }
    }
}
