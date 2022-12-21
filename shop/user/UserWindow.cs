using shop.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Imaging;

namespace shop.user
{
    public partial class UserWindow : Form
    {
        private int idUser;

        public UserWindow(int id)
        {
            InitializeComponent();
            idUser = id;
        }

        private void UserWindow_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shopDataSet1.Games". При необходимости она может быть перемещена или удалена.
            this.gamesTableAdapter1.Fill(this.shopDataSet1.Games);

            Bitmap bitmap = FileStreamController.ReadImageStream(idUser.ToString());
            if (bitmap != null) pictureBox.Image = bitmap;

            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Size = new System.Drawing.Size(119, 119);
            pictureBox.Location = new System.Drawing.Point(70, 15);

            SqlDataReader reader = null;
            try
            {
                reader = sql.Users.selectUser(idUser);
                if (reader.Read())
                {
                    fio_textBox.Text = reader.GetString(1);
                    email_textBox.Text = reader.GetString(2);
                    dateTimePicker.Text = DateTime.Parse(reader.GetValue(4).ToString()).ToString("d");
                }
                else
                {
                    reader.Close();
                    MessageBox.Show("Ошибка в чтении данных пользователя", "Error", MessageBoxButtons.OK);
                    login.WelcomeWindow.exitOnWelcomWindow(this);
                }
            }
            finally
            {
                reader.Close();
            }
        }

        private void fillLibraryDataGridView()
        {
            var select = sql.Games.selectUserGames(idUser.ToString());
            sql.sqlControls.fillDataGridView(select, library_dataGridView);
        }

        private void profile_button_Click(object sender, EventArgs e)
        {
            profileTabControl.SelectedIndex = 0;
        }

        private void photo_button_Click(object sender, EventArgs e)
        {
            Bitmap fileContent = null;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "e:\\изображения";
                openFileDialog.Filter = "png files (*.png)|*.png";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    fileContent = new Bitmap(openFileDialog.OpenFile());
                    fileContent.SetResolution(150, 150);

                    //using (StreamReader reader = new StreamReader(fileStream))
                    //{
                    //    fileContent = reader.ReadToEnd();
                    //}
                }
            }
            pictureBox.Image = fileContent;
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Size = new System.Drawing.Size(121, 121);
            pictureBox.Location = new System.Drawing.Point(66, 15);

            FileStreamController.OverwriteFileStream(idUser.ToString(), fileContent);
        }

        private void password_button_Click(object sender, EventArgs e)
        {
            profileTabControl.SelectedIndex = 1;
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            login.WelcomeWindow.exitOnWelcomWindow(this);
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            if (!utils.Parser.checkFIO(fio_textBox.Text))
            {
                MessageBox.Show("Введены некорректные инициалы.", "Ошибка", MessageBoxButtons.OK);
                return;
            }
            if (!utils.Parser.checkEmail(email_textBox.Text))
            {
                MessageBox.Show("Введен некорректный email.", "Ошибка", MessageBoxButtons.OK);
                return;
            }

            if (MessageBox.Show("Вы уверены, что хотите изменить свои данные?",
                               "Предупреждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string date = DateTime.Parse(dateTimePicker.Text).ToString();

                try
                {
                    sql.Users.updateUser(idUser, fio_textBox.Text, email_textBox.Text, date);
                    MessageBox.Show("Данные успешно изменены.", "Success", MessageBoxButtons.OK);
                }
                catch (Exception)
                {
                    MessageBox.Show("Ошибка в добавлении пользователя", "Ошибка", MessageBoxButtons.OK);
                }
            }
        }

        private void old_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            oldPassword_textBox.UseSystemPasswordChar = !old_checkBox.Checked;
        }

        private void new_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            newPassword_textBox.UseSystemPasswordChar = !new_checkBox.Checked;
            newPasswordReply_textBox.UseSystemPasswordChar = !new_checkBox.Checked;

        }

        private void changePassword_button_Click(object sender, EventArgs e)
        {
            SqlDataReader reader = sql.Users.selectUser(idUser);
            if (reader.Read())
            {
                string password = reader.GetString(3);
                reader.Close();

                if (!utils.Parser.VerifyPassword(oldPassword_textBox.Text, password))
                {
                    MessageBox.Show("Вы ввели неправильный старый пароль!", "Ошибка", MessageBoxButtons.OK);
                    return;
                }

                if ((newPassword_textBox.Text != newPasswordReply_textBox.Text) ||
                    (newPassword_textBox.Text.Length == 0))
                {
                    MessageBox.Show("Введите новый пароль корректно!", "Ошибка", MessageBoxButtons.OK);
                    return;
                }

                string newPassword = utils.Parser.CreatePasswordHash(newPassword_textBox.Text);
                try
                {
                    sql.Users.updateUser(idUser, newPassword);
                    oldPassword_textBox.Clear();
                    newPassword_textBox.Clear();
                    newPasswordReply_textBox.Clear();
                    MessageBox.Show("Данные успешно изменены.", "Success", MessageBoxButtons.OK);
                }
                catch (Exception)
                {
                    MessageBox.Show("Ошибка в записи данных пользователя", "Ошибка", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Ошибка в чтении данных пользователя", "Ошибка", MessageBoxButtons.OK);
                reader.Close();
                login.WelcomeWindow.exitOnWelcomWindow(this);
            }
            reader.Close();
        }

        private void readDescription_button_Click(object sender, EventArgs e)
        {
            int cellsCount = shop_dataGridView.SelectedRows.Count;
            if (cellsCount == 0)
            {
                MessageBox.Show("Выберите хотя бы одну игру.", "Предупреждение", MessageBoxButtons.OK);
                return;
            }
            else if (cellsCount > 1)
            {
                MessageBox.Show("Выберите только одну игру.", "Предупреждение", MessageBoxButtons.OK);
                return;
            }

            description_textBox.Text = shop_dataGridView.SelectedRows[0]
                                                        .Cells[2]
                                                        .FormattedValue
                                                        .ToString();
        }

        private void putInCart_button_Click(object sender, EventArgs e)
        {
            int cellsCount = shop_dataGridView.SelectedRows.Count;
            if (cellsCount == 0)
            {
                MessageBox.Show("Выберите хотя бы одну игру.", "Предупреждение", MessageBoxButtons.OK);
                return;
            }

            fillLibraryDataGridView();

            foreach (DataGridViewRow i in shop_dataGridView.SelectedRows)
            {
                DataGridViewRow clonedRow = (DataGridViewRow)i.Clone();
                for (Int32 index = 0; index < i.Cells.Count; index++)
                {
                    clonedRow.Cells[index].Value = i.Cells[index].Value;

                }
                bool isDuplicate = false;
                foreach (DataGridViewRow j in library_dataGridView.Rows)
                {
                    //check on IDGame
                    if (clonedRow.Cells[0].Value.Equals(j.Cells[0].Value))
                    {
                        isDuplicate = true;
                        break;
                    }
                }
                if (isDuplicate) continue;

                foreach (DataGridViewRow j in cart_dataGridView.Rows)
                {
                    //check on IDGame
                    if(clonedRow.Cells[0].Value.Equals(j.Cells[0].Value)) 
                    {
                        isDuplicate = true;
                        break;
                    }
                }
                if (!isDuplicate)
                {
                    cart_dataGridView.Rows.Insert(cart_dataGridView.Rows.Count, clonedRow);
                    int count = int.Parse(gamesCount_textBox.Text) + 1;
                    gamesCount_textBox.Text = count.ToString();
                }
            }
        }

        private void cart_button_Click(object sender, EventArgs e)
        {
            xuiFlatTab1.SelectTab(3);
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in this.cart_dataGridView.SelectedRows)
            {
                cart_dataGridView.Rows.RemoveAt(row.Index);
                int count = int.Parse(gamesCount_textBox.Text) - 1;
                gamesCount_textBox.Text = count.ToString();
            }
        }

        private void order_buton_Click(object sender, EventArgs e)
        {
            if (cart_dataGridView.RowCount == 0)
            {
                MessageBox.Show("Добавьте в корзину по крайней мере одну игру!", "Ошибка", MessageBoxButtons.OK);
                return;
            }
            int sum = 0;
            int i = 0;
            int[] gamesId = new int[cart_dataGridView.RowCount];
            foreach (DataGridViewRow row in cart_dataGridView.Rows)
            {
                sum += int.Parse(row.Cells[3].Value.ToString());
                gamesId[i++] = int.Parse(row.Cells[0].Value.ToString());
            }
            this.Enabled = false;
            Order order = new Order(this, sum, gamesId, idUser);
            order.ShowDialog();
            cart_dataGridView.Rows.Clear();
            gamesCount_textBox.Text = "0";
        }

        private void xuiFlatTab1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (xuiFlatTab1.SelectedIndex == 1)
            {
                fillLibraryDataGridView();
                library_dataGridView.Columns["IDGame"].Visible = false;
            }
        }

        private void download_button_Click(object sender, EventArgs e)
        {
            int cellsCount = library_dataGridView.SelectedRows.Count;
            if (cellsCount == 0)
            {
                MessageBox.Show("Выберите хотя бы одну игру.", "Предупреждение", MessageBoxButtons.OK);
                return;
            }
            else if (cellsCount > 1)
            {
                MessageBox.Show("Выберите только одну игру.", "Предупреждение", MessageBoxButtons.OK);
                return;
            }

            string dummyFileName = "Save Here";
            string userpath = null;
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.FileName = dummyFileName;
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    userpath = Path.GetDirectoryName(saveFileDialog.FileName);
                }
            }

            try
            {
                sql.Games.downloadGame(library_dataGridView.SelectedRows[0]
                                                             .Cells["IDGame"]
                                                             .EditedFormattedValue
                                                             .ToString(), userpath);
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK);
                return;
            }

            MessageBox.Show("Архив с игрой успешно скачан на ваш компьютер!", "", MessageBoxButtons.OK);
        }

    }
}
