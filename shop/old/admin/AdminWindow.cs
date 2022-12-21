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

namespace DB_scientificLibrary.author
{
    public partial class AdminWindow : Form
    {
        private int idAdmin;

        public AdminWindow(int id)
        {
            InitializeComponent();
            idAdmin = id;
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            switch (e.Node.Name)
            {
                case "newRentalNode":
                    tabControl.SelectedIndex = 1;
                    break;
                case "returnRentalNode":
                    tabControl.SelectedIndex = 2;
                    break;
                case "readersNode":
                    tabControl.SelectedIndex = 3;
                    break;
                case "authorsNode":
                    tabControl.SelectedIndex = 4;
                    break;
                case "authorRegisterNode":
                    tabControl.SelectedIndex = 5;
                    break;
                case "addEditionNode":
                    fillCheckListWithAuthors();
                    tabControl.SelectedIndex = 6;
                    break;
                case "editEditionNode":
                    tabControl.SelectedIndex = 7;
                    break;
                case "showEditionsNode":
                    tabControl.SelectedIndex = 8;
                    showAllEditionsDataGridView();
                    break;
                case "authorCollectionsNode":
                    tabControl.SelectedIndex = 9;
                    showAllCollectionsDataGridView();
                    break;
                case "showEditionsTopNode":
                    tabControl.SelectedIndex = 10;
                    showEditionsTopDataGridView();
                    break;
                case "readersTopNode":
                    tabControl.SelectedIndex = 11;
                    showReadersTopDataGridView();
                    break;
                case "authorsTopNode":
                    tabControl.SelectedIndex = 12;
                    showAuthorsTopDataGridView();
                    break;
                case "noReturnEditionsNode":
                    tabControl.SelectedIndex = 13;
                    showNoReturnedEditionsDataGridView();
                    break;
            }
        }

        private void fillCheckListWithAuthors()
        {
            ((ListBox)this.authorEditions_checkedListBox).DataSource = authorsBindingSource;
            ((ListBox)this.authorEditions_checkedListBox).DisplayMember = "FIO";
            ((ListBox)this.authorEditions_checkedListBox).ValueMember = "IDUser";
        }

        public static void exitOnWelcomWindow(System.Windows.Forms.Form form)
        {
            if (MessageBox.Show("Вы уверены, что хотите выйти?", "Предупреждение", MessageBoxButtons.YesNo) ==
                DialogResult.Yes)
            {
                login.WelcomeWindow welcome = new login.WelcomeWindow();
                form.Hide();
                welcome.ShowDialog();
                form.Close();
            }
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            exitOnWelcomWindow(this);
        }

        private void profileButton_Click(object sender, EventArgs e)
        {
            fillProfile();
            tabControl.SelectedIndex = 0;
        }

        private void AdminWindow_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet2.DistincPublisher". При необходимости она может быть перемещена или удалена.
            this.distincPublisherTableAdapter.Fill(this.dataSet2.DistincPublisher);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet2.DistincType". При необходимости она может быть перемещена или удалена.
            this.distincTypeTableAdapter.Fill(this.dataSet2.DistincType);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet2.DistinctYear". При необходимости она может быть перемещена или удалена.
            this.distinctYearTableAdapter.Fill(this.dataSet2.DistinctYear);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Rentals". При необходимости она может быть перемещена или удалена.
            this.rentalsTableAdapter.Fill(this.dataSet1.Rentals);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet11.Editions". При необходимости она может быть перемещена или удалена.
            this.editionsTableAdapter.Fill(this.dataSet1.Editions);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.dataSet1.Users);

            treeView1.ExpandAll();

            //profile
            fillProfile();

            //1
            dateTimePicker1.Value = DateTime.Now;

            //2
            changeRentalComboBoxFilter();

        }

        private void fillProfile()
        {
            SqlDataReader reader = null;
            try
            {
                reader = sql.Users.selectUser(idAdmin);
                if (reader.Read())
                {
                    fio_textBox.Text = reader.GetString(1);
                    email_textBox.Text = reader.GetString(3);
                    dateTimePicker.Text = DateTime.Parse(reader.GetValue(5).ToString()).ToString("d");
                    //reader.Close();
                }
                else
                {
                    MessageBox.Show("Ошибка в чтении данных пользователя", "Error", MessageBoxButtons.OK);
                    exitOnWelcomWindow(this);
                    //reader.Close();
                }
            }
            finally
            {
                reader.Close();
            }
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
                    sql.Users.updateUser(idAdmin, fio_textBox.Text, email_textBox.Text, date);
                    MessageBox.Show("Данные успешно изменены.", "Success", MessageBoxButtons.OK);
                } catch (Exception)
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
            SqlDataReader reader = sql.Users.selectUser(idAdmin);
            if (reader.Read())
            {
                string password = reader.GetString(4);
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
                    sql.Users.updateUser(idAdmin, newPassword);
                    oldPassword_textBox.Clear();
                    newPassword_textBox.Clear();
                    newPasswordReply_textBox.Clear();
                    MessageBox.Show("Данные успешно изменены.", "Success", MessageBoxButtons.OK);
                } catch (Exception)
                {
                    MessageBox.Show("Ошибка в записи данных пользователя", "Ошибка", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Ошибка в чтении данных пользователя", "Ошибка", MessageBoxButtons.OK);
                reader.Close();
                exitOnWelcomWindow(this);
            }
            if (!reader.IsClosed) reader.Close();
        }

        private void rental_button_Click(object sender, EventArgs e)
        {
            if (readerFio_comboBox.Text.Length == 0 ||
                readerEmail_comboBox.Text.Length == 0 ||
                edition_comboBox.Text.Length == 0 ||
                numericUpDown1.Value == 0)
            {
                MessageBox.Show("Выберите корректные данные для аренды!", "Ошибка", MessageBoxButtons.OK);
                return;
            }

            string returnDate = "";
            if (dateTimePicker2.Checked)
            {
                returnDate = DateTime.Parse(dateTimePicker2.Text).ToString();
            }
            try
            {
                sql.Rentals.createRental(int.Parse(readerFio_comboBox.SelectedValue.ToString()),
                                         int.Parse(edition_comboBox.SelectedValue.ToString()),
                                         decimal.ToInt32(numericUpDown1.Value),
                                         DateTime.Parse(dateTimePicker1.Text).ToString(),
                                         returnDate);

                editionsTableAdapter.Fill(dataSet1.Editions);
                editionsBindingSource.ResetBindings(true); 
                rentalsTableAdapter.Fill(dataSet1.Rentals);
                rentalsBindingSource.ResetBindings(true);

                MessageBox.Show("Аренда успешно оформлена.", "Success", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK);
            }
        }

        private void returnEdition_button_Click(object sender, EventArgs e)
        {
            try
            {
                sql.Rentals.returnRental(int.Parse(idRental_comboBox.SelectedValue.ToString()));

                rentalsTableAdapter.Fill(dataSet1.Rentals);
                rentalsBindingSource.ResetBindings(true);
                editionsTableAdapter.Fill(dataSet1.Editions);
                editionsBindingSource.ResetBindings(true);

                MessageBox.Show("Возврат успешно оформлен.", "Success", MessageBoxButtons.OK);
            } catch (Exception)
            {
                MessageBox.Show("Не получилось оформить возврат(", "Ошибка", MessageBoxButtons.OK);
            }
        }

        private void fioReturn_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            changeRentalComboBoxFilter();
        }

        private void emailReturn_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            changeRentalComboBoxFilter();
        }

        private void editionReturn_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            changeRentalComboBoxFilter();
        }

        private void changeRentalComboBoxFilter()
        {
            if (readersBindingSource.IsBindingSuspended == true) return;

            rentalsBindingSource.Filter = "IDReader=" + int.Parse(fioReturn_comboBox.SelectedValue.ToString()) +
                                          " AND IDEdition=" + int.Parse(editionReturn_comboBox.SelectedValue.ToString()) +
                                          " AND STATUS=0";

        }

        private void fioReaderInfo_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillReaderInfoDataGridView();
        }

        private void emailReaderInfo_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillReaderInfoDataGridView();
        }

        private void fillReaderInfoDataGridView()
        {
            if (readersBindingSource.IsBindingSuspended == true) return;
           
            var select = sql.Users.getUserRentalsSelect(fioReaderInfo_comboBox.SelectedValue.ToString());
            sql.sqlControls.fillDataGridView(select, readerInfo_dataGridView);
        }

        private void AdminWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            readersBindingSource.SuspendBinding();
            editionsBindingSource.SuspendBinding();
            rentalsBindingSource.SuspendBinding();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            readerNewPassword_textBox.UseSystemPasswordChar = !checkBox1.Checked;
            readerNewPasswordReply_textBox.UseSystemPasswordChar = !checkBox1.Checked;
        }

        private void changeReaderData_button_Click(object sender, EventArgs e)
        {
            readerData_panel.Visible = true;
            readerData_panel.Enabled = true;
            backToReaderInfo_button.Visible = true;
            backToReaderInfo_button.Enabled = true;
            changeReaderData_button.Visible = false; ;
            changeReaderData_button.Enabled = false;

            SqlDataReader reader = sql.Users.selectUser(int.Parse(fioReaderInfo_comboBox.SelectedValue.ToString()));
            if (reader.Read())
            {
                readerFio_textBox.Text = reader.GetString(1);
                readerEmail_textBox.Text = reader.GetString(3);
                readerBirth_dateTimePicker.Text = DateTime.Parse(reader.GetValue(5).ToString()).ToString("d");
                reader.Close();
            }
            else
            {
                MessageBox.Show("Ошибка в чтении данных пользователя", "Ошибка", MessageBoxButtons.OK);
                backToReaderInfo_button_Click(new object(), new EventArgs());
                reader.Close();
            }
            if (!reader.IsClosed) reader.Close();
        }

        private void updateReader_button_Click(object sender, EventArgs e)
        {
            if (!utils.Parser.checkFIO(readerFio_textBox.Text))
            {
                MessageBox.Show("Введены некорректные инициалы.", "Ошибка", MessageBoxButtons.OK);
                return;
            }
            if (!utils.Parser.checkEmail(readerEmail_textBox.Text))
            {
                MessageBox.Show("Введен некорректный email.", "Ошибка", MessageBoxButtons.OK);
                return;
            }

            if (MessageBox.Show("Вы уверены, что хотите изменить данные пользователя?",
                                "Предупреждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string date = DateTime.Parse(readerBirth_dateTimePicker.Text).ToString();

                try
                {
                    sql.Users.updateUser(int.Parse(fioReaderInfo_comboBox.SelectedValue.ToString()), 
                                         readerFio_textBox.Text, 
                                         readerEmail_textBox.Text, 
                                         date);

                    usersTableAdapter.Fill(dataSet1.Users);
                    readersBindingSource.ResetBindings(true);
                    MessageBox.Show("Данные успешно изменены.", "Success", MessageBoxButtons.OK);
                }
                catch (Exception)
                {
                    MessageBox.Show("Ошибка в добавлении пользователя", "Ошибка", MessageBoxButtons.OK);
                }
            }
        }

        private void updateReaderPassword_button_Click(object sender, EventArgs e)
        {
            if ((readerNewPassword_textBox.Text != readerNewPasswordReply_textBox.Text) ||
                (readerNewPassword_textBox.Text.Length == 0))
            {
                MessageBox.Show("Введите новый пароль корректно!", "Ошибка", MessageBoxButtons.OK);
                return;
            }

            string newPassword = utils.Parser.CreatePasswordHash(readerNewPassword_textBox.Text);
            try
            {
                sql.Users.updateUser(int.Parse(fioReaderInfo_comboBox.SelectedValue.ToString()), 
                                     newPassword);
                readerNewPassword_textBox.Clear();
                readerNewPasswordReply_textBox.Clear();

                usersTableAdapter.Fill(dataSet1.Users);
                readersBindingSource.ResetBindings(true);

                MessageBox.Show("Данные успешно изменены.", "Success", MessageBoxButtons.OK);
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка в записи данных пользователя", "Ошибка", MessageBoxButtons.OK);
            }
        }

        private void backToReaderInfo_button_Click(object sender, EventArgs e)
        {
            readerData_panel.Visible = false;
            readerData_panel.Enabled = false;
            backToReaderInfo_button.Visible = false;
            backToReaderInfo_button.Enabled = false;
            changeReaderData_button.Visible = true; ;
            changeReaderData_button.Enabled = true;
        }

        private void authorFio_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            setAuthorData();
        }

        private void authorEmail_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            setAuthorData();
        }

        private void setAuthorData()
        {
            if (readersBindingSource.IsBindingSuspended == true) return;
            SqlDataReader reader = sql.Users.selectUser(int.Parse(authorFio_comboBox.SelectedValue.ToString()));
            if (reader.Read())
            {
                authorFio_textBox.Text = reader.GetString(1);
                authorEmail_textBox.Text = reader.GetString(3);
                author_dateTimePicker.Text = DateTime.Parse(reader.GetValue(5).ToString()).ToString("d");
                reader.Close();
            }
            else
            {
                reader.Close();
                MessageBox.Show("Ошибка в чтении данных пользователя", "Ошибка", MessageBoxButtons.OK);
            }
            if (!reader.IsClosed) reader.Close();
        }

        private void updateAuthorData_button_Click(object sender, EventArgs e)
        {
            if (!utils.Parser.checkFIO(authorFio_textBox.Text))
            {
                MessageBox.Show("Введены некорректные инициалы.", "Ошибка", MessageBoxButtons.OK);
                return;
            }
            if (!utils.Parser.checkEmail(authorEmail_textBox.Text))
            {
                MessageBox.Show("Введен некорректный email.", "Ошибка", MessageBoxButtons.OK);
                return;
            }

            if (MessageBox.Show("Вы уверены, что хотите изменить данные пользователя?",
                               "Предупреждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string date = DateTime.Parse(author_dateTimePicker.Text).ToString();

                try
                {
                    sql.Users.updateUser(int.Parse(authorFio_comboBox.SelectedValue.ToString()),
                                         authorFio_textBox.Text,
                                         authorEmail_textBox.Text,
                                         date);

                    usersTableAdapter.Fill(dataSet1.Users);
                    readersBindingSource.ResetBindings(true);
                    MessageBox.Show("Данные успешно изменены.", "Success", MessageBoxButtons.OK);
                }
                catch (Exception)
                {
                    MessageBox.Show("Ошибка в добавлении пользователя", "Ошибка", MessageBoxButtons.OK);
                }
            }
        }

        private void updateAuthorPassword_button_Click(object sender, EventArgs e)
        {
            if ((authorNewPassword_textBox.Text != authorNewPasswordReply_textBox.Text) ||
               (authorNewPassword_textBox.Text.Length == 0))
            {
                MessageBox.Show("Введите новый пароль корректно!", "Ошибка", MessageBoxButtons.OK);
                return;
            }

            string newPassword = utils.Parser.CreatePasswordHash(newPassword_textBox.Text);
            try
            {
                sql.Users.updateUser(int.Parse(authorFio_comboBox.SelectedValue.ToString()),
                                     newPassword);
                authorNewPassword_textBox.Clear();
                authorNewPasswordReply_textBox.Clear();

                usersTableAdapter.Fill(dataSet1.Users);
                readersBindingSource.ResetBindings(true);

                MessageBox.Show("Данные успешно изменены.", "Success", MessageBoxButtons.OK);
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка в записи данных пользователя", "Ошибка", MessageBoxButtons.OK);
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

            authorNewPassword_textBox.UseSystemPasswordChar = !checkBox2.Checked;
            authorNewPasswordReply_textBox.UseSystemPasswordChar = !checkBox2.Checked;
        }

        private void registrationButton_Click(object sender, EventArgs e)
        {
            if (!utils.Parser.checkFIO(newAuthorFio_textBox.Text))
            {
                MessageBox.Show("Введены некорректные инициалы!", "Ошибка", MessageBoxButtons.OK);
                return;
            }
            if (!utils.Parser.checkEmail(newAuthorEmail_textBox.Text))
            {
                MessageBox.Show("Введен некорректный email.", "Ошибка", MessageBoxButtons.OK);
                return;
            }
            if (newAuthorPassword_textBox.Text.Length == 0)
            {
                MessageBox.Show("Введите ваш пароль!", "Ошибка", MessageBoxButtons.OK);
                return;
            }

            try
            {
                string newPassword = utils.Parser.CreatePasswordHash(newAuthorPassword_textBox.Text);

                sql.Users.authorRegister(newAuthorFio_textBox.Text,
                                         newAuthorEmail_textBox.Text,
                                         DateTime.Parse(newAuthor_dateTimePicker.Text).ToString(),
                                         newPassword);

                newAuthorFio_textBox.Clear();
                newAuthorEmail_textBox.Clear();
                newAuthorPassword_textBox.Clear();

                usersTableAdapter.Fill(dataSet1.Users);
                readersBindingSource.ResetBindings(true);

                MessageBox.Show("Автор успешно добавлен в базу", "Success", MessageBoxButtons.OK);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK);
                return;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            newAuthorPassword_textBox.UseSystemPasswordChar = !checkBox3.Checked;
        }

        private void addEdition_button_Click(object sender, EventArgs e)
        {
            if (editionName_textBox.Text.Length == 0 ||
                editionYear_textBox.Text.Length == 0 ||
                editionType_textBox.Text.Length == 0 ||
                editionPublisher_textBox.Text.Length == 0)
            {
                MessageBox.Show("Какие-то поля остались незаполненными!", "Ошибка", MessageBoxButtons.OK);
                return;
            }
            int authorsCount = authorEditions_checkedListBox.CheckedItems.Count;
            if (authorsCount == 0)
            {
                MessageBox.Show("Нельзя создать издание без авторов!", "Ошибка", MessageBoxButtons.OK);
                return;
            }

            try
            {
                var row = (System.Data.DataRowView)authorEditions_checkedListBox.CheckedItems[0];
                sql.Editions.addEdition(editionName_textBox.Text,
                                        int.Parse(editionYear_textBox.Text.ToString()),
                                        editionType_textBox.Text,
                                        editionPublisher_textBox.Text,
                                        decimal.ToInt32(editionsCount_numericUpDown.Value),
                                        int.Parse(row[0].ToString()));

                if (authorsCount > 1)
                {
                    for (int i = 1; i < authorsCount; i++)
                    {
                        var nextRow = (System.Data.DataRowView)authorEditions_checkedListBox.CheckedItems[i];
                        sql.Editions.insertAuthorIntoEdition(nextRow[0].ToString(), "");
                    }
                }

                editionName_textBox.Clear();
                editionYear_textBox.Clear();
                editionType_textBox.Clear();
                editionPublisher_textBox.Clear();
                editionsCount_numericUpDown.Value = 1;

                editionsTableAdapter.Fill(dataSet1.Editions);
                editionsBindingSource.ResetBindings(true);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK); }
        }

        private void editEdition_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (editionsBindingSource.IsBindingSuspended == true) return;
            SqlDataReader reader = sql.Editions.selectEdition(int.Parse(editEdition_comboBox.SelectedValue.ToString()));
            if (reader.Read())
            {
                newEditionName_textBox.Text = reader.GetString(1);
                newEditionYear_textBox.Text = reader.GetInt32(2).ToString();
                newEditionType_textBox.Text = reader.GetString(3);
                newEditionPublisher_textBox.Text = reader.GetString(4);
                newEditionCount_numericUpDown.Value = reader.GetInt32(5);
            }
            else
            {
                MessageBox.Show("Ошибка в чтении данных издания", "Ошибка", MessageBoxButtons.OK);
            }
            reader.Close();
        }

        private void updateEdition_button_Click(object sender, EventArgs e)
        {
            if (newEditionName_textBox.Text.Length == 0 ||
                newEditionYear_textBox.Text.Length != 4 ||
                newEditionType_textBox.Text.Length == 0 ||
                newEditionPublisher_textBox.Text.Length == 0)
            {
                MessageBox.Show("Какие-то поля остались незаполненными!", "Ошибка", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Вы уверены, что хотите изменить данные издания?",
                              "Предупреждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    sql.Editions.updateEdition(int.Parse(editEdition_comboBox.SelectedValue.ToString()),
                                         newEditionName_textBox.Text,
                                         int.Parse(newEditionYear_textBox.Text),
                                         newEditionType_textBox.Text,
                                         newEditionPublisher_textBox.Text,
                                         decimal.ToInt32(newEditionCount_numericUpDown.Value));

                    editionsTableAdapter.Fill(dataSet1.Editions);
                    editionsBindingSource.ResetBindings(true);

                    newEditionName_textBox.Clear();
                    newEditionYear_textBox.Clear();
                    newEditionType_textBox.Clear();
                    newEditionPublisher_textBox.Clear();
                    newEditionCount_numericUpDown.Value = 1;

                    MessageBox.Show("Данные успешно изменены.", "Success", MessageBoxButtons.OK);
                }
                catch (Exception)
                {
                    MessageBox.Show("Ошибка в изменении издания", "Ошибка", MessageBoxButtons.OK);
                }
            }
        }

        private void showAllEditionsDataGridView()
        {
            var select = sql.Editions.getAllEditionsSelect();
            sql.sqlControls.fillDataGridView(select, editionsCatalog_dataGridView);
        }

        private void showEditionsTopDataGridView()
        {
            var select = sql.Editions.getEditionsTopSelect();
            sql.sqlControls.fillDataGridView(select, editionsTop_dataGridView);
        }

        private void showReadersTopDataGridView()
        {
            var select = sql.Editions.getReadersTopSelect();
            sql.sqlControls.fillDataGridView(select, readersTop_dataGridView);
        }

        private void showAuthorsTopDataGridView()
        {
            var select = sql.Editions.getAuthorsTopSelect();
            sql.sqlControls.fillDataGridView(select, authorsTop_DataGridView);
        }

        private void allEditionDebts_button_Click(object sender, EventArgs e)
        {
            showNoReturnedEditionsDataGridView();
        }

        private void showNoReturnedEditionsDataGridView()
        {
            var select = sql.Editions.getNoReturnedEditionsSelect();
            sql.sqlControls.fillDataGridView(select, noReturnedEditions_dataGridView);

            noReturnedEditions_dataGridView.Columns["FIO"].DisplayIndex = 0;
            noReturnedEditions_dataGridView.Columns["Email"].DisplayIndex = 1;
        }

        private void readerEditionDebts_button_Click(object sender, EventArgs e)
        {
            if (readersBindingSource.IsBindingSuspended == true) return;

            var select = sql.Editions.getReaderNoReturnedEditionsSelect(readerDebtorFio_comboBox.SelectedValue.ToString());
            sql.sqlControls.fillDataGridView(select, noReturnedEditions_dataGridView);
        }

        private void allCollections_button_Click(object sender, EventArgs e)
        {
            showAllCollectionsDataGridView();
        }

        private void showAllCollectionsDataGridView()
        {
            var select = sql.Collections.getAllCollectionsSelect();
            sql.sqlControls.fillDataGridView(select, collections_dataGridView);

            collections_dataGridView.Columns["FIO"].DisplayIndex = 0;
        }

        private void authorCollection_button_Click(object sender, EventArgs e)
        {
            if (authorsBindingSource.IsBindingSuspended == true) return;

            var select = sql.Collections.getAuthorCollectionsSelect(authorFioCollection_comboBox.SelectedValue.ToString());
            sql.sqlControls.fillDataGridView(select, collections_dataGridView);
            collections_dataGridView.Columns["IDCollection"].Visible = false;
        }

        private void disableEditionsFilter_button_Click(object sender, EventArgs e)
        {
            showAllEditionsDataGridView();
        }

        private void findEdition_button_Click(object sender, EventArgs e)
        {
            string name = "";
            if (edition_checkBox.Checked) name = editionsFilter_comboBox.AccessibilityObject.Value;

            int year = -1;
            if (year_checkBox.Checked) year = int.Parse(yearFilter_comboBox.AccessibilityObject.Value);

            string type = "";
            if (type_checkBox.Checked) type = typeFilter_comboBox.AccessibilityObject.Value;

            string publisher = "";
            if (publisher_checkBox.Checked) publisher = publishersFilter_comboBox.AccessibilityObject.Value;

            int idAuthor = -1;
            if (authorFio_checkBox.Checked) idAuthor = int.Parse(authorFilter_comboBox.SelectedValue.ToString());

            SqlDataReader reader = null;
            try
            {
                reader = sql.Editions.searchEdition(name, year, type, publisher, idAuthor);

                DataTable dt = new DataTable();
                dt.Load(reader);
                editionsCatalog_dataGridView.DataSource = dt;
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK);
            }
            finally
            {
                reader.Close();
            }
        }

        bool isFilter = false;
        private void filters_button_Click(object sender, EventArgs e)
        {
            filter_panel.Visible = !isFilter;
            filter_panel.Enabled = !isFilter;
            isFilter = !isFilter;
        }

        private void edition_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            editionsFilter_comboBox.Enabled = edition_checkBox.Checked;
        }

        private void authorFio_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            authorFilter_comboBox.Enabled = authorFio_checkBox.Checked;
        }

        private void year_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            yearFilter_comboBox.Enabled = year_checkBox.Checked;
        }

        private void type_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            typeFilter_comboBox.Enabled = type_checkBox.Checked;
        }

        private void publisher_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            publishersFilter_comboBox.Enabled = publisher_checkBox.Checked;
        }

    }
}
