using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DB_scientificLibrary.author
{
    public partial class AuthorWindow : Form
    {
        private int idAuthor;
        public AuthorWindow(int id)
        {
            InitializeComponent();
            idAuthor = id;
        }
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            switch (e.Node.Name)
            {
                case "showEditionsNode":
                    showAllEditionsDataGridView();
                    tabControl.SelectedIndex = 1;
                    break;
                case "createCollectionNode":
                    fillCheckListWithEditions();
                    newCollection_dateTimePicker.Value = DateTime.Now;
                    tabControl.SelectedIndex = 2;
                    break;
                case "authorCollectionsNode":
                    showAllCollectionsDataGridView();
                    tabControl.SelectedIndex = 3;
                    break;
                case "EditCollectionNode":
                    initAuthorCollectionComboBox();
                    tabControl.SelectedIndex = 4;
                    break;
                case "showEditionsTopNode":
                    showEditionsTopDataGridView();
                    tabControl.SelectedIndex = 5;
                    break;
                case "readersTopNode":
                    showReadersTopDataGridView();
                    tabControl.SelectedIndex = 6;
                    break;
                case "authorsTopNode":
                    showAuthorsTopDataGridView();
                    tabControl.SelectedIndex = 7;
                    break;
            }
        }

        private void initAuthorCollectionComboBox()
        {
            string select = sql.Collections.getAuthorCollectionsSelect(idAuthor.ToString());
            SqlDataAdapter dataAdapter = new SqlDataAdapter(select, Program.cn);

            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);
            authorCollections_comboBox.DataSource = ds.Tables[0];
            authorCollections_comboBox.DisplayMember = "CollectionName";
            authorCollections_comboBox.ValueMember = "IDCollection";
        }

        private void fillCheckListWithEditions()
        {
            ((ListBox)this.authorEditions_checkedListBox).DataSource = 
                sql.Editions.getAuthorEditionsDataTable(idAuthor.ToString());
            ((ListBox)this.authorEditions_checkedListBox).DisplayMember = "Name";
            ((ListBox)this.authorEditions_checkedListBox).ValueMember = "IDEdition";
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            author.AdminWindow.exitOnWelcomWindow(this);
        }

        private void profileButton_Click(object sender, EventArgs e)
        {
            fillProfile();
            tabControl.SelectedIndex = 0;
        }

        private void AuthorWindow_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Collections". При необходимости она может быть перемещена или удалена.
            this.collectionsTableAdapter.Fill(this.dataSet1.Collections);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet2.DistincPublisher". При необходимости она может быть перемещена или удалена.
            this.distincPublisherTableAdapter.Fill(this.dataSet2.DistincPublisher);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet2.DistincType". При необходимости она может быть перемещена или удалена.
            this.distincTypeTableAdapter.Fill(this.dataSet2.DistincType);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet2.DistinctYear". При необходимости она может быть перемещена или удалена.
            this.distinctYearTableAdapter.Fill(this.dataSet2.DistinctYear);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.AuthorEdition". При необходимости она может быть перемещена или удалена.
            this.editionsTableAdapter.Fill(this.dataSet1.Editions);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.AuthorEdition". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.dataSet1.Users);
            
            treeView1.ExpandAll();

            //profile
            fillProfile();
        }

        private void fillProfile()
        {
            SqlDataReader reader = null;
            try
            {
                reader = sql.Users.selectUser(idAuthor);
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
            if(!utils.Parser.checkEmail(email_textBox.Text))
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
                    sql.Users.updateUser(idAuthor, fio_textBox.Text, email_textBox.Text, date);
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
            SqlDataReader reader = sql.Users.selectUser(idAuthor);
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
                    sql.Users.updateUser(idAuthor, newPassword);
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

        private void showAllEditionsDataGridView()
        {
            var select = sql.Editions.getAllEditionsSelect();
            sql.sqlControls.fillDataGridView(select, editionsCatalog_dataGridView);
        }

        private void disableEditionsFilter_button_Click(object sender, EventArgs e)
        {
            showAllEditionsDataGridView();
        }

        private void authorEditions_button_Click(object sender, EventArgs e)
        {
            var select = sql.Editions.getFindEditionByEditionNameOrAndAuthorSelect("", idAuthor.ToString());
            sql.sqlControls.fillDataGridView(select, editionsCatalog_dataGridView);
        }

        private void createCollection_button_Click(object sender, EventArgs e)
        {
            if (newCollectionName_textBox.Text == "")
            {
                MessageBox.Show("Вы должны ввести название для сборника.", "Ошибка", MessageBoxButtons.OK);
                return;
            }
            try
            {
                int edCount = authorEditions_checkedListBox.CheckedItems.Count;
                if (edCount == 0)
                {
                    MessageBox.Show("Нельзя создать пустой сборник!", "Ошибка", MessageBoxButtons.OK);
                    return;
                }

                var row = (System.Data.DataRowView)authorEditions_checkedListBox.CheckedItems[0];
                
                sql.Collections.addCollection(idAuthor,
                                           newCollectionName_textBox.Text,
                                           DateTime.Parse(newCollection_dateTimePicker.Text).ToString(),
                                           newCollectionDescription_textBox.Text,
                                           int.Parse(row[0].ToString()));

                if (edCount > 1)
                {
                    for(int i = 1; i < edCount; i++)
                    {
                        var nextRow = (System.Data.DataRowView)authorEditions_checkedListBox.CheckedItems[i];
                        sql.Collections.insertEditionIntoCollection("", nextRow[0].ToString());
                    }
                }
                
                newCollectionName_textBox.Clear();
                newCollectionDescription_textBox.Clear();
                

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK);
                return;
            }
        }

        private void authorCollection_button_Click(object sender, EventArgs e)
        {
            if (authorsBindingSource.IsBindingSuspended == true) return;

            var select = sql.Collections.getAuthorCollectionsSelect(authorFioCollection_comboBox.SelectedValue.ToString());
            sql.sqlControls.fillDataGridView(select, collections_dataGridView);
            collections_dataGridView.Columns["IDCollection"].Visible = false;
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

        private void mine_button_Click(object sender, EventArgs e)
        {
            if (authorsBindingSource.IsBindingSuspended == true) return;

            var select = sql.Collections.getAuthorCollectionsSelect(idAuthor.ToString());
            sql.sqlControls.fillDataGridView(select, collections_dataGridView);
            collections_dataGridView.Columns["IDCollection"].Visible = false;
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

        private void allEditionsTop_button_Click(object sender, EventArgs e)
        {
            showEditionsTopDataGridView();
        }

        private void mineEditionsTop_button_Click(object sender, EventArgs e)
        {
            var select = sql.Editions.getAuthorEditionsTopSelect(idAuthor.ToString());
            sql.sqlControls.fillDataGridView(select, editionsTop_dataGridView);
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

        bool isFilter = false;
        private void filters_button_Click(object sender, EventArgs e)
        {
            filter_panel.Visible = !isFilter;
            filter_panel.Enabled = !isFilter;
            isFilter = !isFilter;
        }

        private void authorCollections_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillEditionsInAuthorCollection();
        }

        private void fillEditionsInAuthorCollection()
        {
            if (authorCollections_comboBox.SelectedValue == null) return;

            string select = sql.Collections.getEditionsByCollectionIDSelect(
                                            idAuthor.ToString(),
                                            authorCollections_comboBox.SelectedValue.ToString());
            sql.sqlControls.fillDataGridView(select, editionsInAuthorCollection_dataGridView);
            editionsInAuthorCollection_dataGridView.Columns["IDEdition"].Visible = false;
        }

        private void deleteEditionFromCollection_button_Click(object sender, EventArgs e)
        {
            int cellsCount = editionsInAuthorCollection_dataGridView.SelectedRows.Count;
            if (cellsCount == 0)
            {
                MessageBox.Show("Выберите издание, которое хотите удалить.", "Предупреждение", MessageBoxButtons.OK);
                return;
            }
            else if (cellsCount > 1)
            {
                if (MessageBox.Show("Вы уверены, что хотите удалить из сборника все выбранные издания?\n" +
                                    "Таблица будет обновлена. Отменить выбор будет невозможно.",
                                    "Предупреждение", MessageBoxButtons.YesNo) == DialogResult.No) return;
            }
            else if (MessageBox.Show("Вы уверены, что хотите удалить из сборника выбранное издание?\n" +
                                     "Таблица будет обновлена. Отменить выбор будет невозможно.",
                                     "Предупреждение", MessageBoxButtons.YesNo) == DialogResult.No) return;

            string idCollection = authorCollections_comboBox.SelectedValue.ToString();
            foreach (DataGridViewRow i in editionsInAuthorCollection_dataGridView.SelectedRows)
            {
                sql.Collections.deleteEditionFromCollection(i.Cells[0].EditedFormattedValue.ToString(), idCollection);
            }

            fillEditionsInAuthorCollection();
            initAuthorCollectionComboBox();
        }

        private void deleteCollection_button_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите удалить сборник?\n" +
                               "Таблица будет обновлена. Отменить выбор будет невозможно.",
                               "Предупреждение", MessageBoxButtons.YesNo) == DialogResult.No) return;

            sql.Collections.deleteCollection(authorCollections_comboBox.SelectedValue.ToString());

            initAuthorCollectionComboBox();
            editionsInAuthorCollection_dataGridView.DataSource = null;
        }

        private void addEditionToCollection_button_Click(object sender, EventArgs e)
        {
            if (authorCollections_comboBox == null || authorCollections_comboBox.Items == null) return;

            review_panel.Visible = true;
            review_panel.Enabled = true;
            panel1.Visible = true;
            panel2.Visible = true;

            menuPanel.Enabled = false;
            authorCollections_comboBox.Enabled = false;
            editionsInAuthorCollection_dataGridView.Enabled = false;
            deleteCollection_button.Enabled = false;
            addEditionToCollection_button.Enabled = false;
            deleteEditionFromCollection_button.Enabled = false;

            newEditionToCollection_comboBox.DataSource = sql.Editions.getAuthorEditionsDataTable(idAuthor.ToString());
            newEditionToCollection_comboBox.DisplayMember = "Name";
            newEditionToCollection_comboBox.ValueMember = "IDEdition";
        }

        private void createReview_button_Click(object sender, EventArgs e)
        {
            try
            {
                sql.Collections.insertEditionIntoCollection(authorCollections_comboBox.SelectedValue.ToString(),
                                                            newEditionToCollection_comboBox.SelectedValue.ToString());
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);  
            }
            fillEditionsInAuthorCollection();

            panel1.Visible = false;
            panel2.Visible = false;
            review_panel.Visible = false;
            review_panel.Enabled = false;

            menuPanel.Enabled = true;
            authorCollections_comboBox.Enabled = true;
            editionsInAuthorCollection_dataGridView.Enabled = true;
            deleteCollection_button.Enabled = true;
            addEditionToCollection_button.Enabled = true;
            deleteEditionFromCollection_button.Enabled = true;
        }
    }
}
