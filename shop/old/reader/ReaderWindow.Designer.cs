namespace DB_scientificLibrary.reader
{
    partial class ReaderWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Просмотр читательского билета");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Просмотр каталога библиотеки");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Просмотр каталога сборников");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Каталоги", new System.Windows.Forms.TreeNode[] {
            treeNode18,
            treeNode19});
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Популярные издания");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Рейтинг авторов");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Рейтинг читателей");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Статистика", new System.Windows.Forms.TreeNode[] {
            treeNode21,
            treeNode22,
            treeNode23});
            this.menuPanel = new System.Windows.Forms.Panel();
            this.logOutButton = new System.Windows.Forms.Button();
            this.profileButton = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.authorsTop_tabPage = new System.Windows.Forms.TabPage();
            this.authorsTop_DataGridView = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.topEditions_tabPage = new System.Windows.Forms.TabPage();
            this.editionsTop_dataGridView = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.collections_tabPage = new System.Windows.Forms.TabPage();
            this.label66 = new System.Windows.Forms.Label();
            this.label67 = new System.Windows.Forms.Label();
            this.label68 = new System.Windows.Forms.Label();
            this.authorEmailCollection_comboBox = new System.Windows.Forms.ComboBox();
            this.authorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new DB_scientificLibrary.DataSet1();
            this.authorFioCollection_comboBox = new System.Windows.Forms.ComboBox();
            this.authorCollection_button = new System.Windows.Forms.Button();
            this.allCollections_button = new System.Windows.Forms.Button();
            this.collections_dataGridView = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.catalog_tabPage = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.filter_panel = new System.Windows.Forms.Panel();
            this.publishersFilter_comboBox = new System.Windows.Forms.ComboBox();
            this.distincPublisherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet2 = new DB_scientificLibrary.DataSet2();
            this.typeFilter_comboBox = new System.Windows.Forms.ComboBox();
            this.distincTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.publisher_checkBox = new System.Windows.Forms.CheckBox();
            this.yearFilter_comboBox = new System.Windows.Forms.ComboBox();
            this.distinctYearBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.type_checkBox = new System.Windows.Forms.CheckBox();
            this.editionsFilter_comboBox = new System.Windows.Forms.ComboBox();
            this.editionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.year_checkBox = new System.Windows.Forms.CheckBox();
            this.authorFio_checkBox = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label69 = new System.Windows.Forms.Label();
            this.label70 = new System.Windows.Forms.Label();
            this.edition_checkBox = new System.Windows.Forms.CheckBox();
            this.authorFilter_comboBox = new System.Windows.Forms.ComboBox();
            this.findEdition_button = new System.Windows.Forms.Button();
            this.disableEditionsFilter_button = new System.Windows.Forms.Button();
            this.editionsCatalog_dataGridView = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.readers_tabPage = new System.Windows.Forms.TabPage();
            this.review_panel = new System.Windows.Forms.Panel();
            this.review_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.createReview_button = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.review_button = new System.Windows.Forms.Button();
            this.increaseRentalReturnDate_button = new System.Windows.Forms.Button();
            this.findReaderRental_button = new System.Windows.Forms.Button();
            this.showReaderRentals_button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.editionRentalComboBox = new System.Windows.Forms.ComboBox();
            this.readerRentals_dataGridView = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.rentalsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.profile_tabPage = new System.Windows.Forms.TabPage();
            this.new_checkBox = new System.Windows.Forms.CheckBox();
            this.old_checkBox = new System.Windows.Forms.CheckBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.changePassword_button = new System.Windows.Forms.Button();
            this.update_button = new System.Windows.Forms.Button();
            this.birth_Label = new System.Windows.Forms.Label();
            this.newPassword2_label = new System.Windows.Forms.Label();
            this.newPassword_label = new System.Windows.Forms.Label();
            this.email_label = new System.Windows.Forms.Label();
            this.oldPassword_label = new System.Windows.Forms.Label();
            this.fio_Label = new System.Windows.Forms.Label();
            this.newPasswordReply_textBox = new System.Windows.Forms.TextBox();
            this.newPassword_textBox = new System.Windows.Forms.TextBox();
            this.oldPassword_textBox = new System.Windows.Forms.TextBox();
            this.email_textBox = new System.Windows.Forms.TextBox();
            this.fio_textBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.readersTop_tabPage = new System.Windows.Forms.TabPage();
            this.readersTop_dataGridView = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.editionsTableAdapter = new DB_scientificLibrary.DataSet1TableAdapters.EditionsTableAdapter();
            this.rentalsTableAdapter = new DB_scientificLibrary.DataSet1TableAdapters.RentalsTableAdapter();
            this.usersTableAdapter = new DB_scientificLibrary.DataSet1TableAdapters.UsersTableAdapter();
            this.distinctYearTableAdapter = new DB_scientificLibrary.DataSet2TableAdapters.DistinctYearTableAdapter();
            this.distincTypeTableAdapter = new DB_scientificLibrary.DataSet2TableAdapters.DistincTypeTableAdapter();
            this.distincPublisherTableAdapter = new DB_scientificLibrary.DataSet2TableAdapters.DistincPublisherTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.menuPanel.SuspendLayout();
            this.authorsTop_tabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.authorsTop_DataGridView)).BeginInit();
            this.topEditions_tabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editionsTop_dataGridView)).BeginInit();
            this.collections_tabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collections_dataGridView)).BeginInit();
            this.catalog_tabPage.SuspendLayout();
            this.filter_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.distincPublisherBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.distincTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.distinctYearBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editionsCatalog_dataGridView)).BeginInit();
            this.readers_tabPage.SuspendLayout();
            this.review_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.review_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.readerRentals_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentalsBindingSource)).BeginInit();
            this.profile_tabPage.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.readersTop_tabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.readersTop_dataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.Controls.Add(this.logOutButton);
            this.menuPanel.Controls.Add(this.profileButton);
            this.menuPanel.Controls.Add(this.treeView1);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(305, 609);
            this.menuPanel.TabIndex = 1;
            // 
            // logOutButton
            // 
            this.logOutButton.Location = new System.Drawing.Point(163, 563);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(128, 34);
            this.logOutButton.TabIndex = 1;
            this.logOutButton.Text = "Выйти";
            this.logOutButton.UseVisualStyleBackColor = true;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // profileButton
            // 
            this.profileButton.Location = new System.Drawing.Point(12, 563);
            this.profileButton.Name = "profileButton";
            this.profileButton.Size = new System.Drawing.Size(128, 34);
            this.profileButton.TabIndex = 1;
            this.profileButton.Text = "Profile";
            this.profileButton.UseVisualStyleBackColor = true;
            this.profileButton.Click += new System.EventHandler(this.profileButton_Click);
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.Color.White;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode17.Name = "libraryBiletNode";
            treeNode17.Text = "Просмотр читательского билета";
            treeNode18.Name = "showEditionsNode";
            treeNode18.Text = "Просмотр каталога библиотеки";
            treeNode19.Name = "authorCollectionsNode";
            treeNode19.Text = "Просмотр каталога сборников";
            treeNode20.Name = "catalogsNode";
            treeNode20.Text = "Каталоги";
            treeNode21.Name = "showEditionsTopNode";
            treeNode21.Text = "Популярные издания";
            treeNode22.Name = "authorsTopNode";
            treeNode22.Text = "Рейтинг авторов";
            treeNode23.Name = "readersTopNode";
            treeNode23.Text = "Рейтинг читателей";
            treeNode24.Name = "statisticNode";
            treeNode24.Text = "Статистика";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode17,
            treeNode20,
            treeNode24});
            this.treeView1.Scrollable = false;
            this.treeView1.Size = new System.Drawing.Size(305, 609);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // authorsTop_tabPage
            // 
            this.authorsTop_tabPage.Controls.Add(this.authorsTop_DataGridView);
            this.authorsTop_tabPage.Controls.Add(this.label12);
            this.authorsTop_tabPage.Location = new System.Drawing.Point(4, 4);
            this.authorsTop_tabPage.Name = "authorsTop_tabPage";
            this.authorsTop_tabPage.Size = new System.Drawing.Size(934, 601);
            this.authorsTop_tabPage.TabIndex = 11;
            this.authorsTop_tabPage.Text = "5";
            this.authorsTop_tabPage.UseVisualStyleBackColor = true;
            // 
            // authorsTop_DataGridView
            // 
            this.authorsTop_DataGridView.AllowUserToAddRows = false;
            this.authorsTop_DataGridView.AllowUserToDeleteRows = false;
            this.authorsTop_DataGridView.AllowUserToOrderColumns = true;
            this.authorsTop_DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.authorsTop_DataGridView.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.authorsTop_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.authorsTop_DataGridView.Location = new System.Drawing.Point(63, 97);
            this.authorsTop_DataGridView.Name = "authorsTop_DataGridView";
            this.authorsTop_DataGridView.ReadOnly = true;
            this.authorsTop_DataGridView.RowHeadersWidth = 51;
            this.authorsTop_DataGridView.RowTemplate.Height = 24;
            this.authorsTop_DataGridView.Size = new System.Drawing.Size(827, 462);
            this.authorsTop_DataGridView.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(57, 31);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(833, 63);
            this.label12.TabIndex = 5;
            this.label12.Text = "Рейтинг авторов";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // topEditions_tabPage
            // 
            this.topEditions_tabPage.Controls.Add(this.editionsTop_dataGridView);
            this.topEditions_tabPage.Controls.Add(this.label10);
            this.topEditions_tabPage.Location = new System.Drawing.Point(4, 4);
            this.topEditions_tabPage.Name = "topEditions_tabPage";
            this.topEditions_tabPage.Size = new System.Drawing.Size(934, 601);
            this.topEditions_tabPage.TabIndex = 9;
            this.topEditions_tabPage.Text = "4";
            this.topEditions_tabPage.UseVisualStyleBackColor = true;
            // 
            // editionsTop_dataGridView
            // 
            this.editionsTop_dataGridView.AllowUserToAddRows = false;
            this.editionsTop_dataGridView.AllowUserToDeleteRows = false;
            this.editionsTop_dataGridView.AllowUserToOrderColumns = true;
            this.editionsTop_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.editionsTop_dataGridView.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.editionsTop_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.editionsTop_dataGridView.Location = new System.Drawing.Point(63, 97);
            this.editionsTop_dataGridView.Name = "editionsTop_dataGridView";
            this.editionsTop_dataGridView.ReadOnly = true;
            this.editionsTop_dataGridView.RowHeadersWidth = 51;
            this.editionsTop_dataGridView.RowTemplate.Height = 24;
            this.editionsTop_dataGridView.Size = new System.Drawing.Size(827, 462);
            this.editionsTop_dataGridView.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(57, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(833, 63);
            this.label10.TabIndex = 5;
            this.label10.Text = "Популярные издания по отзывам";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // collections_tabPage
            // 
            this.collections_tabPage.Controls.Add(this.label66);
            this.collections_tabPage.Controls.Add(this.label67);
            this.collections_tabPage.Controls.Add(this.label68);
            this.collections_tabPage.Controls.Add(this.authorEmailCollection_comboBox);
            this.collections_tabPage.Controls.Add(this.authorFioCollection_comboBox);
            this.collections_tabPage.Controls.Add(this.authorCollection_button);
            this.collections_tabPage.Controls.Add(this.allCollections_button);
            this.collections_tabPage.Controls.Add(this.collections_dataGridView);
            this.collections_tabPage.Controls.Add(this.label9);
            this.collections_tabPage.Location = new System.Drawing.Point(4, 4);
            this.collections_tabPage.Name = "collections_tabPage";
            this.collections_tabPage.Size = new System.Drawing.Size(934, 601);
            this.collections_tabPage.TabIndex = 8;
            this.collections_tabPage.Text = "3";
            this.collections_tabPage.UseVisualStyleBackColor = true;
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.Location = new System.Drawing.Point(455, 121);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(36, 16);
            this.label66.TabIndex = 55;
            this.label66.Text = "ИЛИ";
            // 
            // label67
            // 
            this.label67.AutoSize = true;
            this.label67.Location = new System.Drawing.Point(527, 99);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(91, 16);
            this.label67.TabIndex = 53;
            this.label67.Text = "Email автора";
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.Location = new System.Drawing.Point(60, 99);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(88, 16);
            this.label68.TabIndex = 54;
            this.label68.Text = "ФИО автора";
            // 
            // authorEmailCollection_comboBox
            // 
            this.authorEmailCollection_comboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.authorEmailCollection_comboBox.DataSource = this.authorsBindingSource;
            this.authorEmailCollection_comboBox.DisplayMember = "Email";
            this.authorEmailCollection_comboBox.FormattingEnabled = true;
            this.authorEmailCollection_comboBox.Location = new System.Drawing.Point(530, 118);
            this.authorEmailCollection_comboBox.Name = "authorEmailCollection_comboBox";
            this.authorEmailCollection_comboBox.Size = new System.Drawing.Size(360, 24);
            this.authorEmailCollection_comboBox.TabIndex = 51;
            this.authorEmailCollection_comboBox.ValueMember = "IDUser";
            // 
            // authorsBindingSource
            // 
            this.authorsBindingSource.DataMember = "Users";
            this.authorsBindingSource.DataSource = this.dataSet1;
            this.authorsBindingSource.Filter = "IDPosition=2";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // authorFioCollection_comboBox
            // 
            this.authorFioCollection_comboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.authorFioCollection_comboBox.DataSource = this.authorsBindingSource;
            this.authorFioCollection_comboBox.DisplayMember = "FIO";
            this.authorFioCollection_comboBox.FormattingEnabled = true;
            this.authorFioCollection_comboBox.Location = new System.Drawing.Point(63, 118);
            this.authorFioCollection_comboBox.Name = "authorFioCollection_comboBox";
            this.authorFioCollection_comboBox.Size = new System.Drawing.Size(357, 24);
            this.authorFioCollection_comboBox.TabIndex = 52;
            this.authorFioCollection_comboBox.ValueMember = "IDUser";
            // 
            // authorCollection_button
            // 
            this.authorCollection_button.Location = new System.Drawing.Point(63, 559);
            this.authorCollection_button.Name = "authorCollection_button";
            this.authorCollection_button.Size = new System.Drawing.Size(282, 34);
            this.authorCollection_button.TabIndex = 37;
            this.authorCollection_button.Text = "Сборники выбранного автора";
            this.authorCollection_button.UseVisualStyleBackColor = true;
            this.authorCollection_button.Click += new System.EventHandler(this.authorCollection_button_Click);
            // 
            // allCollections_button
            // 
            this.allCollections_button.Location = new System.Drawing.Point(651, 559);
            this.allCollections_button.Name = "allCollections_button";
            this.allCollections_button.Size = new System.Drawing.Size(239, 34);
            this.allCollections_button.TabIndex = 38;
            this.allCollections_button.Text = "Все сборники";
            this.allCollections_button.UseVisualStyleBackColor = true;
            this.allCollections_button.Click += new System.EventHandler(this.allCollections_button_Click);
            // 
            // collections_dataGridView
            // 
            this.collections_dataGridView.AllowUserToAddRows = false;
            this.collections_dataGridView.AllowUserToDeleteRows = false;
            this.collections_dataGridView.AllowUserToOrderColumns = true;
            this.collections_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.collections_dataGridView.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.collections_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.collections_dataGridView.Location = new System.Drawing.Point(63, 145);
            this.collections_dataGridView.Name = "collections_dataGridView";
            this.collections_dataGridView.ReadOnly = true;
            this.collections_dataGridView.RowHeadersWidth = 51;
            this.collections_dataGridView.RowTemplate.Height = 24;
            this.collections_dataGridView.Size = new System.Drawing.Size(827, 392);
            this.collections_dataGridView.TabIndex = 36;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(57, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(833, 63);
            this.label9.TabIndex = 5;
            this.label9.Text = "Просмотр сборников от автора";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // catalog_tabPage
            // 
            this.catalog_tabPage.Controls.Add(this.button1);
            this.catalog_tabPage.Controls.Add(this.filter_panel);
            this.catalog_tabPage.Controls.Add(this.findEdition_button);
            this.catalog_tabPage.Controls.Add(this.disableEditionsFilter_button);
            this.catalog_tabPage.Controls.Add(this.editionsCatalog_dataGridView);
            this.catalog_tabPage.Controls.Add(this.label8);
            this.catalog_tabPage.Location = new System.Drawing.Point(4, 4);
            this.catalog_tabPage.Name = "catalog_tabPage";
            this.catalog_tabPage.Size = new System.Drawing.Size(934, 601);
            this.catalog_tabPage.TabIndex = 7;
            this.catalog_tabPage.Text = "2";
            this.catalog_tabPage.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(804, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 23);
            this.button1.TabIndex = 51;
            this.button1.Text = "Фильтры";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // filter_panel
            // 
            this.filter_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.filter_panel.Controls.Add(this.publishersFilter_comboBox);
            this.filter_panel.Controls.Add(this.typeFilter_comboBox);
            this.filter_panel.Controls.Add(this.publisher_checkBox);
            this.filter_panel.Controls.Add(this.yearFilter_comboBox);
            this.filter_panel.Controls.Add(this.type_checkBox);
            this.filter_panel.Controls.Add(this.editionsFilter_comboBox);
            this.filter_panel.Controls.Add(this.year_checkBox);
            this.filter_panel.Controls.Add(this.authorFio_checkBox);
            this.filter_panel.Controls.Add(this.label5);
            this.filter_panel.Controls.Add(this.label2);
            this.filter_panel.Controls.Add(this.label1);
            this.filter_panel.Controls.Add(this.label69);
            this.filter_panel.Controls.Add(this.label70);
            this.filter_panel.Controls.Add(this.edition_checkBox);
            this.filter_panel.Controls.Add(this.authorFilter_comboBox);
            this.filter_panel.Enabled = false;
            this.filter_panel.Location = new System.Drawing.Point(463, 145);
            this.filter_panel.Name = "filter_panel";
            this.filter_panel.Size = new System.Drawing.Size(427, 392);
            this.filter_panel.TabIndex = 49;
            this.filter_panel.Visible = false;
            // 
            // publishersFilter_comboBox
            // 
            this.publishersFilter_comboBox.DataSource = this.distincPublisherBindingSource;
            this.publishersFilter_comboBox.DisplayMember = "Publisher";
            this.publishersFilter_comboBox.Enabled = false;
            this.publishersFilter_comboBox.FormattingEnabled = true;
            this.publishersFilter_comboBox.Location = new System.Drawing.Point(8, 337);
            this.publishersFilter_comboBox.Name = "publishersFilter_comboBox";
            this.publishersFilter_comboBox.Size = new System.Drawing.Size(369, 24);
            this.publishersFilter_comboBox.TabIndex = 49;
            // 
            // distincPublisherBindingSource
            // 
            this.distincPublisherBindingSource.DataMember = "DistincPublisher";
            this.distincPublisherBindingSource.DataSource = this.dataSet2;
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // typeFilter_comboBox
            // 
            this.typeFilter_comboBox.DataSource = this.distincTypeBindingSource;
            this.typeFilter_comboBox.DisplayMember = "TypeOfEdition";
            this.typeFilter_comboBox.Enabled = false;
            this.typeFilter_comboBox.FormattingEnabled = true;
            this.typeFilter_comboBox.Location = new System.Drawing.Point(8, 254);
            this.typeFilter_comboBox.Name = "typeFilter_comboBox";
            this.typeFilter_comboBox.Size = new System.Drawing.Size(369, 24);
            this.typeFilter_comboBox.TabIndex = 49;
            // 
            // distincTypeBindingSource
            // 
            this.distincTypeBindingSource.DataMember = "DistincType";
            this.distincTypeBindingSource.DataSource = this.dataSet2;
            // 
            // publisher_checkBox
            // 
            this.publisher_checkBox.AutoSize = true;
            this.publisher_checkBox.Location = new System.Drawing.Point(384, 341);
            this.publisher_checkBox.Name = "publisher_checkBox";
            this.publisher_checkBox.Size = new System.Drawing.Size(18, 17);
            this.publisher_checkBox.TabIndex = 48;
            this.publisher_checkBox.UseVisualStyleBackColor = true;
            this.publisher_checkBox.CheckedChanged += new System.EventHandler(this.publisher_checkBox_CheckedChanged);
            // 
            // yearFilter_comboBox
            // 
            this.yearFilter_comboBox.DataSource = this.distinctYearBindingSource;
            this.yearFilter_comboBox.DisplayMember = "Year";
            this.yearFilter_comboBox.Enabled = false;
            this.yearFilter_comboBox.FormattingEnabled = true;
            this.yearFilter_comboBox.Location = new System.Drawing.Point(8, 185);
            this.yearFilter_comboBox.Name = "yearFilter_comboBox";
            this.yearFilter_comboBox.Size = new System.Drawing.Size(369, 24);
            this.yearFilter_comboBox.TabIndex = 49;
            // 
            // distinctYearBindingSource
            // 
            this.distinctYearBindingSource.DataMember = "DistinctYear";
            this.distinctYearBindingSource.DataSource = this.dataSet2;
            // 
            // type_checkBox
            // 
            this.type_checkBox.AutoSize = true;
            this.type_checkBox.Location = new System.Drawing.Point(384, 258);
            this.type_checkBox.Name = "type_checkBox";
            this.type_checkBox.Size = new System.Drawing.Size(18, 17);
            this.type_checkBox.TabIndex = 48;
            this.type_checkBox.UseVisualStyleBackColor = true;
            this.type_checkBox.CheckedChanged += new System.EventHandler(this.type_checkBox_CheckedChanged);
            // 
            // editionsFilter_comboBox
            // 
            this.editionsFilter_comboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.editionsFilter_comboBox.DataSource = this.editionsBindingSource;
            this.editionsFilter_comboBox.DisplayMember = "Name";
            this.editionsFilter_comboBox.Enabled = false;
            this.editionsFilter_comboBox.FormattingEnabled = true;
            this.editionsFilter_comboBox.Location = new System.Drawing.Point(8, 40);
            this.editionsFilter_comboBox.Name = "editionsFilter_comboBox";
            this.editionsFilter_comboBox.Size = new System.Drawing.Size(369, 24);
            this.editionsFilter_comboBox.TabIndex = 28;
            this.editionsFilter_comboBox.ValueMember = "IDEdition";
            // 
            // editionsBindingSource
            // 
            this.editionsBindingSource.DataMember = "Editions";
            this.editionsBindingSource.DataSource = this.dataSet1;
            // 
            // year_checkBox
            // 
            this.year_checkBox.AutoSize = true;
            this.year_checkBox.Location = new System.Drawing.Point(384, 189);
            this.year_checkBox.Name = "year_checkBox";
            this.year_checkBox.Size = new System.Drawing.Size(18, 17);
            this.year_checkBox.TabIndex = 48;
            this.year_checkBox.UseVisualStyleBackColor = true;
            this.year_checkBox.CheckedChanged += new System.EventHandler(this.year_checkBox_CheckedChanged);
            // 
            // authorFio_checkBox
            // 
            this.authorFio_checkBox.AutoSize = true;
            this.authorFio_checkBox.Location = new System.Drawing.Point(384, 114);
            this.authorFio_checkBox.Name = "authorFio_checkBox";
            this.authorFio_checkBox.Size = new System.Drawing.Size(18, 17);
            this.authorFio_checkBox.TabIndex = 48;
            this.authorFio_checkBox.UseVisualStyleBackColor = true;
            this.authorFio_checkBox.CheckedChanged += new System.EventHandler(this.authorFio_checkBox_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 16);
            this.label5.TabIndex = 29;
            this.label5.Text = "Издатель";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 29;
            this.label2.Text = "Тип издания";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 16);
            this.label1.TabIndex = 29;
            this.label1.Text = "Год";
            // 
            // label69
            // 
            this.label69.AutoSize = true;
            this.label69.Location = new System.Drawing.Point(5, 21);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(65, 16);
            this.label69.TabIndex = 29;
            this.label69.Text = "Издание";
            // 
            // label70
            // 
            this.label70.AutoSize = true;
            this.label70.Location = new System.Drawing.Point(5, 91);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(88, 16);
            this.label70.TabIndex = 46;
            this.label70.Text = "ФИО автора";
            // 
            // edition_checkBox
            // 
            this.edition_checkBox.AutoSize = true;
            this.edition_checkBox.Location = new System.Drawing.Point(384, 43);
            this.edition_checkBox.Name = "edition_checkBox";
            this.edition_checkBox.Size = new System.Drawing.Size(18, 17);
            this.edition_checkBox.TabIndex = 47;
            this.edition_checkBox.UseVisualStyleBackColor = true;
            this.edition_checkBox.CheckedChanged += new System.EventHandler(this.edition_checkBox_CheckedChanged);
            // 
            // authorFilter_comboBox
            // 
            this.authorFilter_comboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.authorFilter_comboBox.DataSource = this.authorsBindingSource;
            this.authorFilter_comboBox.DisplayMember = "FIO";
            this.authorFilter_comboBox.Enabled = false;
            this.authorFilter_comboBox.FormattingEnabled = true;
            this.authorFilter_comboBox.Location = new System.Drawing.Point(8, 110);
            this.authorFilter_comboBox.Name = "authorFilter_comboBox";
            this.authorFilter_comboBox.Size = new System.Drawing.Size(369, 24);
            this.authorFilter_comboBox.TabIndex = 45;
            this.authorFilter_comboBox.ValueMember = "IDUser";
            // 
            // findEdition_button
            // 
            this.findEdition_button.Location = new System.Drawing.Point(63, 558);
            this.findEdition_button.Name = "findEdition_button";
            this.findEdition_button.Size = new System.Drawing.Size(128, 34);
            this.findEdition_button.TabIndex = 30;
            this.findEdition_button.Text = "Поиск";
            this.findEdition_button.UseVisualStyleBackColor = true;
            this.findEdition_button.Click += new System.EventHandler(this.findEdition_button_Click);
            // 
            // disableEditionsFilter_button
            // 
            this.disableEditionsFilter_button.Location = new System.Drawing.Point(722, 558);
            this.disableEditionsFilter_button.Name = "disableEditionsFilter_button";
            this.disableEditionsFilter_button.Size = new System.Drawing.Size(168, 34);
            this.disableEditionsFilter_button.TabIndex = 30;
            this.disableEditionsFilter_button.Text = "Сбросить фильтр";
            this.disableEditionsFilter_button.UseVisualStyleBackColor = true;
            this.disableEditionsFilter_button.Click += new System.EventHandler(this.disableEditionsFilter_button_Click);
            // 
            // editionsCatalog_dataGridView
            // 
            this.editionsCatalog_dataGridView.AllowUserToAddRows = false;
            this.editionsCatalog_dataGridView.AllowUserToDeleteRows = false;
            this.editionsCatalog_dataGridView.AllowUserToOrderColumns = true;
            this.editionsCatalog_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.editionsCatalog_dataGridView.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.editionsCatalog_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.editionsCatalog_dataGridView.Location = new System.Drawing.Point(63, 145);
            this.editionsCatalog_dataGridView.Name = "editionsCatalog_dataGridView";
            this.editionsCatalog_dataGridView.ReadOnly = true;
            this.editionsCatalog_dataGridView.RowHeadersWidth = 51;
            this.editionsCatalog_dataGridView.RowTemplate.Height = 24;
            this.editionsCatalog_dataGridView.Size = new System.Drawing.Size(827, 392);
            this.editionsCatalog_dataGridView.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(57, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(833, 63);
            this.label8.TabIndex = 5;
            this.label8.Text = "Просмотр каталога библиотеки";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // readers_tabPage
            // 
            this.readers_tabPage.Controls.Add(this.review_panel);
            this.readers_tabPage.Controls.Add(this.panel2);
            this.readers_tabPage.Controls.Add(this.panel1);
            this.readers_tabPage.Controls.Add(this.review_button);
            this.readers_tabPage.Controls.Add(this.increaseRentalReturnDate_button);
            this.readers_tabPage.Controls.Add(this.findReaderRental_button);
            this.readers_tabPage.Controls.Add(this.showReaderRentals_button);
            this.readers_tabPage.Controls.Add(this.label4);
            this.readers_tabPage.Controls.Add(this.editionRentalComboBox);
            this.readers_tabPage.Controls.Add(this.readerRentals_dataGridView);
            this.readers_tabPage.Controls.Add(this.label3);
            this.readers_tabPage.Location = new System.Drawing.Point(4, 4);
            this.readers_tabPage.Name = "readers_tabPage";
            this.readers_tabPage.Size = new System.Drawing.Size(934, 601);
            this.readers_tabPage.TabIndex = 2;
            this.readers_tabPage.Text = "1";
            this.readers_tabPage.UseVisualStyleBackColor = true;
            // 
            // review_panel
            // 
            this.review_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.review_panel.Controls.Add(this.review_numericUpDown);
            this.review_panel.Controls.Add(this.createReview_button);
            this.review_panel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.review_panel.Enabled = false;
            this.review_panel.Location = new System.Drawing.Point(273, 226);
            this.review_panel.Name = "review_panel";
            this.review_panel.Size = new System.Drawing.Size(339, 170);
            this.review_panel.TabIndex = 55;
            this.review_panel.Visible = false;
            // 
            // review_numericUpDown
            // 
            this.review_numericUpDown.Location = new System.Drawing.Point(67, 43);
            this.review_numericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.review_numericUpDown.Name = "review_numericUpDown";
            this.review_numericUpDown.Size = new System.Drawing.Size(205, 22);
            this.review_numericUpDown.TabIndex = 1;
            // 
            // createReview_button
            // 
            this.createReview_button.Location = new System.Drawing.Point(67, 105);
            this.createReview_button.Name = "createReview_button";
            this.createReview_button.Size = new System.Drawing.Size(205, 35);
            this.createReview_button.TabIndex = 0;
            this.createReview_button.Text = "Оставить отзыв";
            this.createReview_button.UseVisualStyleBackColor = true;
            this.createReview_button.Click += new System.EventHandler(this.createReview_button_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.panel2.Enabled = false;
            this.panel2.Location = new System.Drawing.Point(296, 206);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(339, 170);
            this.panel2.TabIndex = 55;
            this.panel2.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(246, 254);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(339, 170);
            this.panel1.TabIndex = 55;
            this.panel1.Visible = false;
            // 
            // review_button
            // 
            this.review_button.Location = new System.Drawing.Point(476, 558);
            this.review_button.Name = "review_button";
            this.review_button.Size = new System.Drawing.Size(203, 34);
            this.review_button.TabIndex = 54;
            this.review_button.Text = "Оставить отзыв";
            this.review_button.UseVisualStyleBackColor = true;
            this.review_button.Click += new System.EventHandler(this.review_button_Click);
            // 
            // increaseRentalReturnDate_button
            // 
            this.increaseRentalReturnDate_button.Location = new System.Drawing.Point(229, 558);
            this.increaseRentalReturnDate_button.Name = "increaseRentalReturnDate_button";
            this.increaseRentalReturnDate_button.Size = new System.Drawing.Size(203, 34);
            this.increaseRentalReturnDate_button.TabIndex = 54;
            this.increaseRentalReturnDate_button.Text = "Продлить аренду";
            this.increaseRentalReturnDate_button.UseVisualStyleBackColor = true;
            this.increaseRentalReturnDate_button.Click += new System.EventHandler(this.increaseRentalReturnDate_button_Click);
            // 
            // findReaderRental_button
            // 
            this.findReaderRental_button.Location = new System.Drawing.Point(63, 558);
            this.findReaderRental_button.Name = "findReaderRental_button";
            this.findReaderRental_button.Size = new System.Drawing.Size(128, 34);
            this.findReaderRental_button.TabIndex = 52;
            this.findReaderRental_button.Text = "Поиск";
            this.findReaderRental_button.UseVisualStyleBackColor = true;
            this.findReaderRental_button.Click += new System.EventHandler(this.findReaderRental_button_Click);
            // 
            // showReaderRentals_button
            // 
            this.showReaderRentals_button.Location = new System.Drawing.Point(722, 558);
            this.showReaderRentals_button.Name = "showReaderRentals_button";
            this.showReaderRentals_button.Size = new System.Drawing.Size(168, 34);
            this.showReaderRentals_button.TabIndex = 53;
            this.showReaderRentals_button.Text = "Сбросить фильтр";
            this.showReaderRentals_button.UseVisualStyleBackColor = true;
            this.showReaderRentals_button.Click += new System.EventHandler(this.showReaderRentals_button_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 51;
            this.label4.Text = "Издание";
            // 
            // editionRentalComboBox
            // 
            this.editionRentalComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.editionRentalComboBox.DataSource = this.editionsBindingSource;
            this.editionRentalComboBox.DisplayMember = "Name";
            this.editionRentalComboBox.FormattingEnabled = true;
            this.editionRentalComboBox.Location = new System.Drawing.Point(63, 121);
            this.editionRentalComboBox.Name = "editionRentalComboBox";
            this.editionRentalComboBox.Size = new System.Drawing.Size(369, 24);
            this.editionRentalComboBox.TabIndex = 50;
            this.editionRentalComboBox.ValueMember = "IDEdition";
            // 
            // readerRentals_dataGridView
            // 
            this.readerRentals_dataGridView.AllowUserToAddRows = false;
            this.readerRentals_dataGridView.AllowUserToDeleteRows = false;
            this.readerRentals_dataGridView.AllowUserToOrderColumns = true;
            this.readerRentals_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.readerRentals_dataGridView.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.readerRentals_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.readerRentals_dataGridView.Location = new System.Drawing.Point(63, 145);
            this.readerRentals_dataGridView.Name = "readerRentals_dataGridView";
            this.readerRentals_dataGridView.ReadOnly = true;
            this.readerRentals_dataGridView.RowHeadersWidth = 51;
            this.readerRentals_dataGridView.RowTemplate.Height = 24;
            this.readerRentals_dataGridView.Size = new System.Drawing.Size(827, 392);
            this.readerRentals_dataGridView.TabIndex = 49;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(57, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(833, 63);
            this.label3.TabIndex = 2;
            this.label3.Text = "Читательский билет";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rentalsBindingSource
            // 
            this.rentalsBindingSource.DataMember = "Rentals";
            this.rentalsBindingSource.DataSource = this.dataSet1;
            this.rentalsBindingSource.Filter = "Status=0";
            // 
            // profile_tabPage
            // 
            this.profile_tabPage.Controls.Add(this.groupBox2);
            this.profile_tabPage.Controls.Add(this.groupBox1);
            this.profile_tabPage.Controls.Add(this.label14);
            this.profile_tabPage.Location = new System.Drawing.Point(4, 4);
            this.profile_tabPage.Name = "profile_tabPage";
            this.profile_tabPage.Size = new System.Drawing.Size(934, 601);
            this.profile_tabPage.TabIndex = 13;
            this.profile_tabPage.Text = "profile";
            this.profile_tabPage.UseVisualStyleBackColor = true;
            // 
            // new_checkBox
            // 
            this.new_checkBox.AutoSize = true;
            this.new_checkBox.Location = new System.Drawing.Point(321, 144);
            this.new_checkBox.Name = "new_checkBox";
            this.new_checkBox.Size = new System.Drawing.Size(18, 17);
            this.new_checkBox.TabIndex = 21;
            this.new_checkBox.UseVisualStyleBackColor = true;
            this.new_checkBox.CheckedChanged += new System.EventHandler(this.new_checkBox_CheckedChanged);
            // 
            // old_checkBox
            // 
            this.old_checkBox.AutoSize = true;
            this.old_checkBox.Location = new System.Drawing.Point(321, 68);
            this.old_checkBox.Name = "old_checkBox";
            this.old_checkBox.Size = new System.Drawing.Size(18, 17);
            this.old_checkBox.TabIndex = 21;
            this.old_checkBox.UseVisualStyleBackColor = true;
            this.old_checkBox.CheckedChanged += new System.EventHandler(this.old_checkBox_CheckedChanged);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(25, 217);
            this.dateTimePicker.MaxDate = new System.DateTime(2022, 12, 4, 0, 0, 0, 0);
            this.dateTimePicker.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(276, 22);
            this.dateTimePicker.TabIndex = 20;
            this.dateTimePicker.Value = new System.DateTime(2022, 12, 4, 0, 0, 0, 0);
            // 
            // changePassword_button
            // 
            this.changePassword_button.Location = new System.Drawing.Point(76, 269);
            this.changePassword_button.Name = "changePassword_button";
            this.changePassword_button.Size = new System.Drawing.Size(182, 42);
            this.changePassword_button.TabIndex = 19;
            this.changePassword_button.Text = "Изменить пароль";
            this.changePassword_button.UseVisualStyleBackColor = true;
            this.changePassword_button.Click += new System.EventHandler(this.changePassword_button_Click);
            // 
            // update_button
            // 
            this.update_button.Location = new System.Drawing.Point(72, 269);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(182, 42);
            this.update_button.TabIndex = 19;
            this.update_button.Text = "Обновить данные";
            this.update_button.UseVisualStyleBackColor = true;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // birth_Label
            // 
            this.birth_Label.AutoSize = true;
            this.birth_Label.Location = new System.Drawing.Point(22, 193);
            this.birth_Label.Name = "birth_Label";
            this.birth_Label.Size = new System.Drawing.Size(106, 16);
            this.birth_Label.TabIndex = 16;
            this.birth_Label.Text = "Дата рождения";
            // 
            // newPassword2_label
            // 
            this.newPassword2_label.AutoSize = true;
            this.newPassword2_label.Location = new System.Drawing.Point(26, 193);
            this.newPassword2_label.Name = "newPassword2_label";
            this.newPassword2_label.Size = new System.Drawing.Size(173, 16);
            this.newPassword2_label.TabIndex = 17;
            this.newPassword2_label.Text = "Повторите новый пароль";
            // 
            // newPassword_label
            // 
            this.newPassword_label.AutoSize = true;
            this.newPassword_label.Location = new System.Drawing.Point(26, 118);
            this.newPassword_label.Name = "newPassword_label";
            this.newPassword_label.Size = new System.Drawing.Size(100, 16);
            this.newPassword_label.TabIndex = 17;
            this.newPassword_label.Text = "Новый пароль";
            // 
            // email_label
            // 
            this.email_label.AutoSize = true;
            this.email_label.Location = new System.Drawing.Point(22, 118);
            this.email_label.Name = "email_label";
            this.email_label.Size = new System.Drawing.Size(41, 16);
            this.email_label.TabIndex = 17;
            this.email_label.Text = "Email";
            // 
            // oldPassword_label
            // 
            this.oldPassword_label.AutoSize = true;
            this.oldPassword_label.Location = new System.Drawing.Point(26, 42);
            this.oldPassword_label.Name = "oldPassword_label";
            this.oldPassword_label.Size = new System.Drawing.Size(106, 16);
            this.oldPassword_label.TabIndex = 18;
            this.oldPassword_label.Text = "Старый пароль";
            // 
            // fio_Label
            // 
            this.fio_Label.AutoSize = true;
            this.fio_Label.Location = new System.Drawing.Point(22, 42);
            this.fio_Label.Name = "fio_Label";
            this.fio_Label.Size = new System.Drawing.Size(38, 16);
            this.fio_Label.TabIndex = 18;
            this.fio_Label.Text = "ФИО";
            // 
            // newPasswordReply_textBox
            // 
            this.newPasswordReply_textBox.BackColor = System.Drawing.SystemColors.Window;
            this.newPasswordReply_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newPasswordReply_textBox.Location = new System.Drawing.Point(29, 212);
            this.newPasswordReply_textBox.Name = "newPasswordReply_textBox";
            this.newPasswordReply_textBox.Size = new System.Drawing.Size(276, 30);
            this.newPasswordReply_textBox.TabIndex = 9;
            this.newPasswordReply_textBox.UseSystemPasswordChar = true;
            // 
            // newPassword_textBox
            // 
            this.newPassword_textBox.BackColor = System.Drawing.SystemColors.Window;
            this.newPassword_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newPassword_textBox.Location = new System.Drawing.Point(29, 137);
            this.newPassword_textBox.Name = "newPassword_textBox";
            this.newPassword_textBox.Size = new System.Drawing.Size(276, 30);
            this.newPassword_textBox.TabIndex = 9;
            this.newPassword_textBox.UseSystemPasswordChar = true;
            // 
            // oldPassword_textBox
            // 
            this.oldPassword_textBox.BackColor = System.Drawing.SystemColors.Window;
            this.oldPassword_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.oldPassword_textBox.Location = new System.Drawing.Point(29, 61);
            this.oldPassword_textBox.Name = "oldPassword_textBox";
            this.oldPassword_textBox.Size = new System.Drawing.Size(276, 30);
            this.oldPassword_textBox.TabIndex = 9;
            this.oldPassword_textBox.UseSystemPasswordChar = true;
            // 
            // email_textBox
            // 
            this.email_textBox.BackColor = System.Drawing.SystemColors.Window;
            this.email_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.email_textBox.Location = new System.Drawing.Point(25, 137);
            this.email_textBox.Name = "email_textBox";
            this.email_textBox.Size = new System.Drawing.Size(276, 30);
            this.email_textBox.TabIndex = 9;
            // 
            // fio_textBox
            // 
            this.fio_textBox.BackColor = System.Drawing.SystemColors.Window;
            this.fio_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fio_textBox.Location = new System.Drawing.Point(25, 61);
            this.fio_textBox.Name = "fio_textBox";
            this.fio_textBox.Size = new System.Drawing.Size(276, 30);
            this.fio_textBox.TabIndex = 9;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(57, 31);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(833, 63);
            this.label14.TabIndex = 6;
            this.label14.Text = "Профиль";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControl
            // 
            this.tabControl.Alignment = System.Windows.Forms.TabAlignment.Right;
            this.tabControl.Controls.Add(this.profile_tabPage);
            this.tabControl.Controls.Add(this.readers_tabPage);
            this.tabControl.Controls.Add(this.catalog_tabPage);
            this.tabControl.Controls.Add(this.collections_tabPage);
            this.tabControl.Controls.Add(this.topEditions_tabPage);
            this.tabControl.Controls.Add(this.authorsTop_tabPage);
            this.tabControl.Controls.Add(this.readersTop_tabPage);
            this.tabControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabControl.Location = new System.Drawing.Point(288, 0);
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(990, 609);
            this.tabControl.TabIndex = 2;
            // 
            // readersTop_tabPage
            // 
            this.readersTop_tabPage.Controls.Add(this.readersTop_dataGridView);
            this.readersTop_tabPage.Controls.Add(this.label11);
            this.readersTop_tabPage.Location = new System.Drawing.Point(4, 4);
            this.readersTop_tabPage.Name = "readersTop_tabPage";
            this.readersTop_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.readersTop_tabPage.Size = new System.Drawing.Size(961, 601);
            this.readersTop_tabPage.TabIndex = 14;
            this.readersTop_tabPage.Text = "6";
            this.readersTop_tabPage.UseVisualStyleBackColor = true;
            // 
            // readersTop_dataGridView
            // 
            this.readersTop_dataGridView.AllowUserToAddRows = false;
            this.readersTop_dataGridView.AllowUserToDeleteRows = false;
            this.readersTop_dataGridView.AllowUserToOrderColumns = true;
            this.readersTop_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.readersTop_dataGridView.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.readersTop_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.readersTop_dataGridView.Location = new System.Drawing.Point(63, 97);
            this.readersTop_dataGridView.Name = "readersTop_dataGridView";
            this.readersTop_dataGridView.ReadOnly = true;
            this.readersTop_dataGridView.RowHeadersWidth = 51;
            this.readersTop_dataGridView.RowTemplate.Height = 24;
            this.readersTop_dataGridView.Size = new System.Drawing.Size(827, 462);
            this.readersTop_dataGridView.TabIndex = 56;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(57, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(833, 63);
            this.label11.TabIndex = 55;
            this.label11.Text = "Рейтинг читателей";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // editionsTableAdapter
            // 
            this.editionsTableAdapter.ClearBeforeFill = true;
            // 
            // rentalsTableAdapter
            // 
            this.rentalsTableAdapter.ClearBeforeFill = true;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // distinctYearTableAdapter
            // 
            this.distinctYearTableAdapter.ClearBeforeFill = true;
            // 
            // distincTypeTableAdapter
            // 
            this.distincTypeTableAdapter.ClearBeforeFill = true;
            // 
            // distincPublisherTableAdapter
            // 
            this.distincPublisherTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker);
            this.groupBox1.Controls.Add(this.update_button);
            this.groupBox1.Controls.Add(this.birth_Label);
            this.groupBox1.Controls.Add(this.email_label);
            this.groupBox1.Controls.Add(this.fio_Label);
            this.groupBox1.Controls.Add(this.email_textBox);
            this.groupBox1.Controls.Add(this.fio_textBox);
            this.groupBox1.Location = new System.Drawing.Point(116, 154);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 331);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Личные данные";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.new_checkBox);
            this.groupBox2.Controls.Add(this.old_checkBox);
            this.groupBox2.Controls.Add(this.changePassword_button);
            this.groupBox2.Controls.Add(this.newPassword2_label);
            this.groupBox2.Controls.Add(this.newPassword_label);
            this.groupBox2.Controls.Add(this.oldPassword_label);
            this.groupBox2.Controls.Add(this.newPasswordReply_textBox);
            this.groupBox2.Controls.Add(this.newPassword_textBox);
            this.groupBox2.Controls.Add(this.oldPassword_textBox);
            this.groupBox2.Location = new System.Drawing.Point(507, 154);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(359, 331);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Пароль";
            // 
            // ReaderWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 609);
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.tabControl);
            this.Name = "ReaderWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reader";
            this.Load += new System.EventHandler(this.ReaderWindow_Load);
            this.menuPanel.ResumeLayout(false);
            this.authorsTop_tabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.authorsTop_DataGridView)).EndInit();
            this.topEditions_tabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.editionsTop_dataGridView)).EndInit();
            this.collections_tabPage.ResumeLayout(false);
            this.collections_tabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collections_dataGridView)).EndInit();
            this.catalog_tabPage.ResumeLayout(false);
            this.filter_panel.ResumeLayout(false);
            this.filter_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.distincPublisherBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.distincTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.distinctYearBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editionsCatalog_dataGridView)).EndInit();
            this.readers_tabPage.ResumeLayout(false);
            this.readers_tabPage.PerformLayout();
            this.review_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.review_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.readerRentals_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentalsBindingSource)).EndInit();
            this.profile_tabPage.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.readersTop_tabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.readersTop_dataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.Button profileButton;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TabPage authorsTop_tabPage;
        private System.Windows.Forms.DataGridView authorsTop_DataGridView;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TabPage topEditions_tabPage;
        private System.Windows.Forms.DataGridView editionsTop_dataGridView;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TabPage collections_tabPage;
        private System.Windows.Forms.Label label66;
        private System.Windows.Forms.Label label67;
        private System.Windows.Forms.Label label68;
        private System.Windows.Forms.ComboBox authorEmailCollection_comboBox;
        private System.Windows.Forms.ComboBox authorFioCollection_comboBox;
        private System.Windows.Forms.Button authorCollection_button;
        private System.Windows.Forms.Button allCollections_button;
        private System.Windows.Forms.DataGridView collections_dataGridView;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabPage catalog_tabPage;
        private System.Windows.Forms.CheckBox authorFio_checkBox;
        private System.Windows.Forms.CheckBox edition_checkBox;
        private System.Windows.Forms.Label label70;
        private System.Windows.Forms.ComboBox authorFilter_comboBox;
        private System.Windows.Forms.Button findEdition_button;
        private System.Windows.Forms.Button disableEditionsFilter_button;
        private System.Windows.Forms.Label label69;
        private System.Windows.Forms.ComboBox editionsFilter_comboBox;
        private System.Windows.Forms.DataGridView editionsCatalog_dataGridView;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage readers_tabPage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage profile_tabPage;
        private System.Windows.Forms.CheckBox new_checkBox;
        private System.Windows.Forms.CheckBox old_checkBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button changePassword_button;
        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.Label birth_Label;
        private System.Windows.Forms.Label newPassword2_label;
        private System.Windows.Forms.Label newPassword_label;
        private System.Windows.Forms.Label email_label;
        private System.Windows.Forms.Label oldPassword_label;
        private System.Windows.Forms.Label fio_Label;
        private System.Windows.Forms.TextBox newPasswordReply_textBox;
        private System.Windows.Forms.TextBox newPassword_textBox;
        private System.Windows.Forms.TextBox oldPassword_textBox;
        private System.Windows.Forms.TextBox email_textBox;
        private System.Windows.Forms.TextBox fio_textBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TabControl tabControl;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource editionsBindingSource;
        private DataSet1TableAdapters.EditionsTableAdapter editionsTableAdapter;
        private System.Windows.Forms.BindingSource rentalsBindingSource;
        private DataSet1TableAdapters.RentalsTableAdapter rentalsTableAdapter;
        private System.Windows.Forms.Button findReaderRental_button;
        private System.Windows.Forms.Button showReaderRentals_button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox editionRentalComboBox;
        private System.Windows.Forms.DataGridView readerRentals_dataGridView;
        private System.Windows.Forms.BindingSource authorsBindingSource;
        private DataSet1TableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.Button increaseRentalReturnDate_button;
        private System.Windows.Forms.TabPage readersTop_tabPage;
        private System.Windows.Forms.DataGridView readersTop_dataGridView;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button review_button;
        private System.Windows.Forms.Panel review_panel;
        private System.Windows.Forms.NumericUpDown review_numericUpDown;
        private System.Windows.Forms.Button createReview_button;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel filter_panel;
        private System.Windows.Forms.ComboBox publishersFilter_comboBox;
        private System.Windows.Forms.ComboBox typeFilter_comboBox;
        private System.Windows.Forms.CheckBox publisher_checkBox;
        private System.Windows.Forms.ComboBox yearFilter_comboBox;
        private System.Windows.Forms.CheckBox type_checkBox;
        private System.Windows.Forms.CheckBox year_checkBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private DataSet2 dataSet2;
        private System.Windows.Forms.BindingSource distinctYearBindingSource;
        private DataSet2TableAdapters.DistinctYearTableAdapter distinctYearTableAdapter;
        private System.Windows.Forms.BindingSource distincTypeBindingSource;
        private DataSet2TableAdapters.DistincTypeTableAdapter distincTypeTableAdapter;
        private System.Windows.Forms.BindingSource distincPublisherBindingSource;
        private DataSet2TableAdapters.DistincPublisherTableAdapter distincPublisherTableAdapter;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}