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

namespace DB_scientificLibrary.reader
{
    public partial class ReaderWindow : Form
    {
        private int idReader;

        public ReaderWindow(int id)
        {
            InitializeComponent();
            idReader = id;
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            switch (e.Node.Name)
            {
                case "libraryBiletNode":
                    fillReaderRentalsDataGridView();
                    tabControl.SelectedIndex = 1;
                    break;
                case "showEditionsNode":
                    showAllEditionsDataGridView();
                    tabControl.SelectedIndex = 2;
                    break;
                case "authorCollectionsNode":
                    showAllCollectionsDataGridView();
                    tabControl.SelectedIndex = 3;
                    break;
                case "showEditionsTopNode":
                    showEditionsTopDataGridView();
                    tabControl.SelectedIndex = 4;
                    break;
                case "authorsTopNode":
                    showAuthorsTopDataGridView();
                    tabControl.SelectedIndex = 5;
                    break;
                case "readersTopNode":
                    showReadersTopDataGridView();
                    tabControl.SelectedIndex = 6;
                    break;
            }
        }

        private void profileButton_Click(object sender, EventArgs e)
        {
            fillProfile();
            tabControl.SelectedIndex = 0;
        }

        private void ReaderWindow_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet2.DistincPublisher". При необходимости она может быть перемещена или удалена.
            this.distincPublisherTableAdapter.Fill(this.dataSet2.DistincPublisher);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet2.DistincType". При необходимости она может быть перемещена или удалена.
            this.distincTypeTableAdapter.Fill(this.dataSet2.DistincType);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet2.DistinctYear". При необходимости она может быть перемещена или удалена.
            this.distinctYearTableAdapter.Fill(this.dataSet2.DistinctYear);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.dataSet1.Users);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Rentals". При необходимости она может быть перемещена или удалена.
            this.rentalsTableAdapter.Fill(this.dataSet1.Rentals);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Editions". При необходимости она может быть перемещена или удалена.
            this.editionsTableAdapter.Fill(this.dataSet1.Editions);
            
            treeView1.ExpandAll();

            //profile
            fillProfile();
        }

        private void fillProfile()
        {
            SqlDataReader reader = null;
            try
            {
                reader = sql.Users.selectUser(idReader);
                if (reader.Read())
                {
                    fio_textBox.Text = reader.GetString(1);
                    email_textBox.Text = reader.GetString(3);
                    dateTimePicker.Text = DateTime.Parse(reader.GetValue(5).ToString()).ToString("d");
                }
                else
                {
                    reader.Close();
                    MessageBox.Show("Ошибка в чтении данных пользователя", "Error", MessageBoxButtons.OK);
                    author.AdminWindow.exitOnWelcomWindow(this);
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
                    sql.Users.updateUser(idReader, fio_textBox.Text, email_textBox.Text, date);
                    MessageBox.Show("Данные успешно изменены.", "Success", MessageBoxButtons.OK);
                }
                catch (Exception)
                {
                    MessageBox.Show("Ошибка в добавлении пользователя", "Ошибка", MessageBoxButtons.OK);
                }
            }
        }

        private void changePassword_button_Click(object sender, EventArgs e)
        {
            SqlDataReader reader = sql.Users.selectUser(idReader);
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
                    sql.Users.updateUser(idReader, newPassword);
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
                author.AdminWindow.exitOnWelcomWindow(this);
            }
            reader.Close();
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            author.AdminWindow.exitOnWelcomWindow(this);
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
     
        private void findReaderRental_button_Click(object sender, EventArgs e)
        {
            if (editionsBindingSource.IsBindingSuspended == true) return;

            string select = sql.Rentals.
                getFindRentalsByEditionNameSelect(idReader.ToString(), editionRentalComboBox.AccessibilityObject.Value);
            
            sql.sqlControls.fillDataGridView(select, readerRentals_dataGridView);
        }

        private void fillReaderRentalsDataGridView()
        {
            var select = sql.Users.getUserRentalsSelect(idReader.ToString());
            sql.sqlControls.fillDataGridView(select, readerRentals_dataGridView);
            readerRentals_dataGridView.Columns["IDRental"].Visible = false;
            readerRentals_dataGridView.Columns["IDEdition"].Visible = false;
        }
        
        private void showAllEditionsDataGridView()
        {
            var select = sql.Editions.getAllEditionsSelect();
            sql.sqlControls.fillDataGridView(select, editionsCatalog_dataGridView);
        }

        private void disableEditionsFilter_button_Click(object sender, EventArgs e)
        {
            showAllEditionsDataGridView();
        }

        private void edition_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            editionsFilter_comboBox.Enabled = edition_checkBox.Checked;
        }

        private void authorFio_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            authorFilter_comboBox.Enabled = authorFio_checkBox.Checked;
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
            } finally
            {
                reader.Close();
            }
        }

        private void showReaderRentals_button_Click(object sender, EventArgs e)
        {
            fillReaderRentalsDataGridView();
        }

        private void review_button_Click(object sender, EventArgs e)
        {
            int cellsCount = readerRentals_dataGridView.SelectedRows.Count;
            if (cellsCount == 0)
            {
                MessageBox.Show("Выберите издание, на которое хотите оставить отзыв.", "Предупреждение", MessageBoxButtons.OK);
                return;
            }
            else if (cellsCount > 1)
            {
                if (MessageBox.Show("Выберите только одно издание, на которое хотите оставить отзыв.",
                                    "Предупреждение", MessageBoxButtons.YesNo) == DialogResult.No) return;
            }

            review_panel.Visible = true;
            review_panel.Enabled = true;
            panel1.Visible = true;
            panel2.Visible = true;
            
            menuPanel.Enabled = false;
            editionRentalComboBox.Enabled = false;
            readerRentals_dataGridView.Enabled = false;
            findReaderRental_button.Enabled = false;
            increaseRentalReturnDate_button.Enabled = false;
            review_button.Enabled = false;
            showReaderRentals_button.Enabled = false;
        }
        
        private void createReview_button_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = (DataGridViewRow)readerRentals_dataGridView.SelectedRows[0];
                sql.Rentals.createReview(idReader,
                                         int.Parse(row.Cells["IDEdition"].EditedFormattedValue.ToString()),
                                         decimal.ToInt32(review_numericUpDown.Value));
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK);
            }

            panel1.Visible = false;
            panel2.Visible = false;
            review_panel.Visible = false;
            review_panel.Enabled = false;

            menuPanel.Enabled = true;
            editionRentalComboBox.Enabled = true;
            readerRentals_dataGridView.Enabled = true;
            findReaderRental_button.Enabled = true;
            increaseRentalReturnDate_button.Enabled = true;
            review_button.Enabled = true;
            showReaderRentals_button.Enabled = true;
        }

        private void increaseRentalReturnDate_button_Click(object sender, EventArgs e)
        {
            int cellsCount = readerRentals_dataGridView.SelectedRows.Count;
            if (cellsCount == 0)
            {
                MessageBox.Show("Выберите издание, аренду которого хотите продлить.", "Предупреждение", MessageBoxButtons.OK);
                return;
            } else if(cellsCount > 1)
            {
                if (MessageBox.Show("Вы уверены, что хотите продлить аренду всех выбранных изданий?\n" +
                                    "Таблица будет обновлена. Продлить аренду уже возвращенных изданий не получится.", 
                                    "Предупреждение", MessageBoxButtons.YesNo) == DialogResult.No) return;
            } else if (MessageBox.Show("Вы уверены, что хотите продлить аренду выбранного издания?\n" +
                                    "Таблица будет обновлена. Продлить аренду уже возвращенных изданий не получится.", 
                                    "Предупреждение", MessageBoxButtons.YesNo) == DialogResult.No) return;

            foreach (DataGridViewRow i in readerRentals_dataGridView.SelectedRows)
            {
                if (i.Cells[3].EditedFormattedValue.ToString() == "Возвращено") continue;
                sql.Rentals.updateRentalReturnDate(i.Cells[0].EditedFormattedValue.ToString());
            }
            fillReaderRentalsDataGridView();

            rentalsTableAdapter.Fill(dataSet1.Rentals);
            rentalsBindingSource.ResetBindings(true);
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

        private void showEditionsTopDataGridView()
        {
            var select = sql.Editions.getEditionsTopSelect();
            sql.sqlControls.fillDataGridView(select, editionsTop_dataGridView);
        }

        private void showAuthorsTopDataGridView()
        {
            var select = sql.Editions.getAuthorsTopSelect();
            sql.sqlControls.fillDataGridView(select, authorsTop_DataGridView);
        }

        private void showReadersTopDataGridView()
        {
            var select = sql.Editions.getReadersTopSelect();
            sql.sqlControls.fillDataGridView(select, readersTop_dataGridView);
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

        bool isFilter = false;
        private void button1_Click(object sender, EventArgs e)
        {
            filter_panel.Visible = !isFilter;
            filter_panel.Enabled = !isFilter;
            isFilter = !isFilter;
        }
    }
}
