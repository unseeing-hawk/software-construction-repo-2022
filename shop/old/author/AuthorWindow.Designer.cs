namespace DB_scientificLibrary.author
{
    partial class AuthorWindow
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Просмотр каталога библиотеки");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Создание нового сборника");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Просмотр каталога сборников");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Редактирование сборников");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Сборники", new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode3,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Популярные издания");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Рейтинг читателей");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Рейтинг авторов");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Статистика", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7,
            treeNode8});
            this.menuPanel = new System.Windows.Forms.Panel();
            this.logOutButton = new System.Windows.Forms.Button();
            this.profileButton = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.authorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new DB_scientificLibrary.DataSet1();
            this.usersTableAdapter = new DB_scientificLibrary.DataSet1TableAdapters.UsersTableAdapter();
            this.editEdition_tabPage = new System.Windows.Forms.TabPage();
            this.authorsTop_DataGridView = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.newEditionCount_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.newEditionYear_textBox = new System.Windows.Forms.MaskedTextBox();
            this.label58 = new System.Windows.Forms.Label();
            this.label59 = new System.Windows.Forms.Label();
            this.label60 = new System.Windows.Forms.Label();
            this.label61 = new System.Windows.Forms.Label();
            this.label62 = new System.Windows.Forms.Label();
            this.newEditionPublisher_textBox = new System.Windows.Forms.TextBox();
            this.newEditionType_textBox = new System.Windows.Forms.TextBox();
            this.newEditionName_textBox = new System.Windows.Forms.TextBox();
            this.label57 = new System.Windows.Forms.Label();
            this.editEdition_comboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.addEdition_tabPage = new System.Windows.Forms.TabPage();
            this.readersTop_dataGridView = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.registration_tabPage = new System.Windows.Forms.TabPage();
            this.mineEditionsTop_button = new System.Windows.Forms.Button();
            this.allEditionsTop_button = new System.Windows.Forms.Button();
            this.editionsTop_dataGridView = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.newAuthor_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.registrationButton = new System.Windows.Forms.Button();
            this.password_label = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.newAuthorPassword_textBox = new System.Windows.Forms.TextBox();
            this.newAuthorEmail_textBox = new System.Windows.Forms.TextBox();
            this.newAuthorFio_textBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.authors_tabPage = new System.Windows.Forms.TabPage();
            this.mineCollections_button = new System.Windows.Forms.Button();
            this.label66 = new System.Windows.Forms.Label();
            this.label67 = new System.Windows.Forms.Label();
            this.label68 = new System.Windows.Forms.Label();
            this.authorEmailCollection_comboBox = new System.Windows.Forms.ComboBox();
            this.authorFioCollection_comboBox = new System.Windows.Forms.ComboBox();
            this.authorCollection_button = new System.Windows.Forms.Button();
            this.allCollections_button = new System.Windows.Forms.Button();
            this.collections_dataGridView = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.returnRental_tabPage = new System.Windows.Forms.TabPage();
            this.authorEditions_checkedListBox = new System.Windows.Forms.CheckedListBox();
            this.createCollection_button = new System.Windows.Forms.Button();
            this.newCollection_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label20 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.newCollectionDescription_textBox = new System.Windows.Forms.TextBox();
            this.newCollectionName_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addRental_tabPage = new System.Windows.Forms.TabPage();
            this.filters_button = new System.Windows.Forms.Button();
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
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label69 = new System.Windows.Forms.Label();
            this.label70 = new System.Windows.Forms.Label();
            this.edition_checkBox = new System.Windows.Forms.CheckBox();
            this.authorFilter_comboBox = new System.Windows.Forms.ComboBox();
            this.findEdition_button = new System.Windows.Forms.Button();
            this.authorEditions_button = new System.Windows.Forms.Button();
            this.disableEditionsFilter_button = new System.Windows.Forms.Button();
            this.editionsCatalog_dataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.profile_tabPage = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.new_checkBox = new System.Windows.Forms.CheckBox();
            this.old_checkBox = new System.Windows.Forms.CheckBox();
            this.changePassword_button = new System.Windows.Forms.Button();
            this.newPassword2_label = new System.Windows.Forms.Label();
            this.newPassword_label = new System.Windows.Forms.Label();
            this.oldPassword_label = new System.Windows.Forms.Label();
            this.newPasswordReply_textBox = new System.Windows.Forms.TextBox();
            this.newPassword_textBox = new System.Windows.Forms.TextBox();
            this.oldPassword_textBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.update_button = new System.Windows.Forms.Button();
            this.birth_Label = new System.Windows.Forms.Label();
            this.email_label = new System.Windows.Forms.Label();
            this.fio_Label = new System.Windows.Forms.Label();
            this.email_textBox = new System.Windows.Forms.TextBox();
            this.fio_textBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.review_panel = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.newEditionToCollection_comboBox = new System.Windows.Forms.ComboBox();
            this.createReview_button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.addEditionToCollection_button = new System.Windows.Forms.Button();
            this.deleteCollection_button = new System.Windows.Forms.Button();
            this.deleteEditionFromCollection_button = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.authorCollections_comboBox = new System.Windows.Forms.ComboBox();
            this.collectionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.editionsInAuthorCollection_dataGridView = new System.Windows.Forms.DataGridView();
            this.editionsTableAdapter = new DB_scientificLibrary.DataSet1TableAdapters.EditionsTableAdapter();
            this.distinctYearTableAdapter = new DB_scientificLibrary.DataSet2TableAdapters.DistinctYearTableAdapter();
            this.distincTypeTableAdapter = new DB_scientificLibrary.DataSet2TableAdapters.DistincTypeTableAdapter();
            this.distincPublisherTableAdapter = new DB_scientificLibrary.DataSet2TableAdapters.DistincPublisherTableAdapter();
            this.collectionsTableAdapter = new DB_scientificLibrary.DataSet1TableAdapters.CollectionsTableAdapter();
            this.menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.editEdition_tabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.authorsTop_DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newEditionCount_numericUpDown)).BeginInit();
            this.addEdition_tabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.readersTop_dataGridView)).BeginInit();
            this.registration_tabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editionsTop_dataGridView)).BeginInit();
            this.authors_tabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.collections_dataGridView)).BeginInit();
            this.returnRental_tabPage.SuspendLayout();
            this.addRental_tabPage.SuspendLayout();
            this.filter_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.distincPublisherBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.distincTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.distinctYearBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editionsCatalog_dataGridView)).BeginInit();
            this.profile_tabPage.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.review_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.collectionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editionsInAuthorCollection_dataGridView)).BeginInit();
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
            treeNode1.Name = "showEditionsNode";
            treeNode1.Text = "Просмотр каталога библиотеки";
            treeNode2.Name = "createCollectionNode";
            treeNode2.Text = "Создание нового сборника";
            treeNode3.Name = "authorCollectionsNode";
            treeNode3.Text = "Просмотр каталога сборников";
            treeNode4.Name = "EditCollectionNode";
            treeNode4.Text = "Редактирование сборников";
            treeNode5.Name = "collectionsNode";
            treeNode5.Text = "Сборники";
            treeNode6.Name = "showEditionsTopNode";
            treeNode6.Text = "Популярные издания";
            treeNode7.Name = "readersTopNode";
            treeNode7.Text = "Рейтинг читателей";
            treeNode8.Name = "authorsTopNode";
            treeNode8.Text = "Рейтинг авторов";
            treeNode9.Name = "statisticNode";
            treeNode9.Text = "Статистика";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode5,
            treeNode9});
            this.treeView1.Scrollable = false;
            this.treeView1.Size = new System.Drawing.Size(305, 609);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
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
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // editEdition_tabPage
            // 
            this.editEdition_tabPage.Controls.Add(this.authorsTop_DataGridView);
            this.editEdition_tabPage.Controls.Add(this.label12);
            this.editEdition_tabPage.Controls.Add(this.newEditionCount_numericUpDown);
            this.editEdition_tabPage.Controls.Add(this.newEditionYear_textBox);
            this.editEdition_tabPage.Controls.Add(this.label58);
            this.editEdition_tabPage.Controls.Add(this.label59);
            this.editEdition_tabPage.Controls.Add(this.label60);
            this.editEdition_tabPage.Controls.Add(this.label61);
            this.editEdition_tabPage.Controls.Add(this.label62);
            this.editEdition_tabPage.Controls.Add(this.newEditionPublisher_textBox);
            this.editEdition_tabPage.Controls.Add(this.newEditionType_textBox);
            this.editEdition_tabPage.Controls.Add(this.newEditionName_textBox);
            this.editEdition_tabPage.Controls.Add(this.label57);
            this.editEdition_tabPage.Controls.Add(this.editEdition_comboBox);
            this.editEdition_tabPage.Controls.Add(this.label7);
            this.editEdition_tabPage.Location = new System.Drawing.Point(4, 4);
            this.editEdition_tabPage.Name = "editEdition_tabPage";
            this.editEdition_tabPage.Size = new System.Drawing.Size(961, 601);
            this.editEdition_tabPage.TabIndex = 6;
            this.editEdition_tabPage.Text = "7";
            this.editEdition_tabPage.UseVisualStyleBackColor = true;
            // 
            // authorsTop_DataGridView
            // 
            this.authorsTop_DataGridView.AllowUserToAddRows = false;
            this.authorsTop_DataGridView.AllowUserToDeleteRows = false;
            this.authorsTop_DataGridView.AllowUserToOrderColumns = true;
            this.authorsTop_DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.authorsTop_DataGridView.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.authorsTop_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.authorsTop_DataGridView.Location = new System.Drawing.Point(59, 100);
            this.authorsTop_DataGridView.Name = "authorsTop_DataGridView";
            this.authorsTop_DataGridView.ReadOnly = true;
            this.authorsTop_DataGridView.RowHeadersWidth = 51;
            this.authorsTop_DataGridView.RowTemplate.Height = 24;
            this.authorsTop_DataGridView.Size = new System.Drawing.Size(827, 442);
            this.authorsTop_DataGridView.TabIndex = 65;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(53, 34);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(833, 63);
            this.label12.TabIndex = 64;
            this.label12.Text = "Рейтинг авторов";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // newEditionCount_numericUpDown
            // 
            this.newEditionCount_numericUpDown.Location = new System.Drawing.Point(316, 494);
            this.newEditionCount_numericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.newEditionCount_numericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.newEditionCount_numericUpDown.Name = "newEditionCount_numericUpDown";
            this.newEditionCount_numericUpDown.Size = new System.Drawing.Size(273, 22);
            this.newEditionCount_numericUpDown.TabIndex = 62;
            this.newEditionCount_numericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // newEditionYear_textBox
            // 
            this.newEditionYear_textBox.Location = new System.Drawing.Point(316, 288);
            this.newEditionYear_textBox.Mask = "0000";
            this.newEditionYear_textBox.Name = "newEditionYear_textBox";
            this.newEditionYear_textBox.PromptChar = '*';
            this.newEditionYear_textBox.Size = new System.Drawing.Size(273, 22);
            this.newEditionYear_textBox.TabIndex = 61;
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Location = new System.Drawing.Point(313, 475);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(175, 16);
            this.label58.TabIndex = 56;
            this.label58.Text = "Количество экземпляров";
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Location = new System.Drawing.Point(313, 403);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(71, 16);
            this.label59.TabIndex = 57;
            this.label59.Text = "Издатель";
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Location = new System.Drawing.Point(313, 334);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(90, 16);
            this.label60.TabIndex = 58;
            this.label60.Text = "Тип издания";
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Location = new System.Drawing.Point(313, 269);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(30, 16);
            this.label61.TabIndex = 59;
            this.label61.Text = "Год";
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Location = new System.Drawing.Point(313, 202);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(131, 16);
            this.label62.TabIndex = 60;
            this.label62.Text = "Название издания";
            // 
            // newEditionPublisher_textBox
            // 
            this.newEditionPublisher_textBox.BackColor = System.Drawing.SystemColors.Window;
            this.newEditionPublisher_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newEditionPublisher_textBox.Location = new System.Drawing.Point(314, 422);
            this.newEditionPublisher_textBox.Name = "newEditionPublisher_textBox";
            this.newEditionPublisher_textBox.Size = new System.Drawing.Size(276, 30);
            this.newEditionPublisher_textBox.TabIndex = 53;
            // 
            // newEditionType_textBox
            // 
            this.newEditionType_textBox.BackColor = System.Drawing.SystemColors.Window;
            this.newEditionType_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newEditionType_textBox.Location = new System.Drawing.Point(314, 353);
            this.newEditionType_textBox.Name = "newEditionType_textBox";
            this.newEditionType_textBox.Size = new System.Drawing.Size(276, 30);
            this.newEditionType_textBox.TabIndex = 54;
            // 
            // newEditionName_textBox
            // 
            this.newEditionName_textBox.BackColor = System.Drawing.SystemColors.Window;
            this.newEditionName_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newEditionName_textBox.Location = new System.Drawing.Point(314, 221);
            this.newEditionName_textBox.Name = "newEditionName_textBox";
            this.newEditionName_textBox.Size = new System.Drawing.Size(276, 30);
            this.newEditionName_textBox.TabIndex = 55;
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Location = new System.Drawing.Point(265, 125);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(65, 16);
            this.label57.TabIndex = 29;
            this.label57.Text = "Издание";
            // 
            // editEdition_comboBox
            // 
            this.editEdition_comboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.editEdition_comboBox.DisplayMember = "Name";
            this.editEdition_comboBox.FormattingEnabled = true;
            this.editEdition_comboBox.Location = new System.Drawing.Point(268, 144);
            this.editEdition_comboBox.Name = "editEdition_comboBox";
            this.editEdition_comboBox.Size = new System.Drawing.Size(369, 24);
            this.editEdition_comboBox.TabIndex = 28;
            this.editEdition_comboBox.ValueMember = "IDEdition";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(36, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(833, 63);
            this.label7.TabIndex = 4;
            this.label7.Text = "Редактирование издания";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addEdition_tabPage
            // 
            this.addEdition_tabPage.Controls.Add(this.readersTop_dataGridView);
            this.addEdition_tabPage.Controls.Add(this.label11);
            this.addEdition_tabPage.Location = new System.Drawing.Point(4, 4);
            this.addEdition_tabPage.Name = "addEdition_tabPage";
            this.addEdition_tabPage.Size = new System.Drawing.Size(961, 601);
            this.addEdition_tabPage.TabIndex = 5;
            this.addEdition_tabPage.Text = "6";
            this.addEdition_tabPage.UseVisualStyleBackColor = true;
            // 
            // readersTop_dataGridView
            // 
            this.readersTop_dataGridView.AllowUserToAddRows = false;
            this.readersTop_dataGridView.AllowUserToDeleteRows = false;
            this.readersTop_dataGridView.AllowUserToOrderColumns = true;
            this.readersTop_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.readersTop_dataGridView.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.readersTop_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.readersTop_dataGridView.Location = new System.Drawing.Point(59, 100);
            this.readersTop_dataGridView.Name = "readersTop_dataGridView";
            this.readersTop_dataGridView.ReadOnly = true;
            this.readersTop_dataGridView.RowHeadersWidth = 51;
            this.readersTop_dataGridView.RowTemplate.Height = 24;
            this.readersTop_dataGridView.Size = new System.Drawing.Size(827, 442);
            this.readersTop_dataGridView.TabIndex = 54;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(53, 34);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(833, 63);
            this.label11.TabIndex = 53;
            this.label11.Text = "Рейтинг читателей";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // registration_tabPage
            // 
            this.registration_tabPage.Controls.Add(this.mineEditionsTop_button);
            this.registration_tabPage.Controls.Add(this.allEditionsTop_button);
            this.registration_tabPage.Controls.Add(this.editionsTop_dataGridView);
            this.registration_tabPage.Controls.Add(this.label3);
            this.registration_tabPage.Controls.Add(this.checkBox3);
            this.registration_tabPage.Controls.Add(this.newAuthor_dateTimePicker);
            this.registration_tabPage.Controls.Add(this.registrationButton);
            this.registration_tabPage.Controls.Add(this.password_label);
            this.registration_tabPage.Controls.Add(this.label46);
            this.registration_tabPage.Controls.Add(this.label47);
            this.registration_tabPage.Controls.Add(this.label48);
            this.registration_tabPage.Controls.Add(this.newAuthorPassword_textBox);
            this.registration_tabPage.Controls.Add(this.newAuthorEmail_textBox);
            this.registration_tabPage.Controls.Add(this.newAuthorFio_textBox);
            this.registration_tabPage.Controls.Add(this.label5);
            this.registration_tabPage.Location = new System.Drawing.Point(4, 4);
            this.registration_tabPage.Name = "registration_tabPage";
            this.registration_tabPage.Size = new System.Drawing.Size(961, 601);
            this.registration_tabPage.TabIndex = 4;
            this.registration_tabPage.Text = "5";
            this.registration_tabPage.UseVisualStyleBackColor = true;
            // 
            // mineEditionsTop_button
            // 
            this.mineEditionsTop_button.Location = new System.Drawing.Point(59, 559);
            this.mineEditionsTop_button.Name = "mineEditionsTop_button";
            this.mineEditionsTop_button.Size = new System.Drawing.Size(236, 34);
            this.mineEditionsTop_button.TabIndex = 60;
            this.mineEditionsTop_button.Text = "Мои издания";
            this.mineEditionsTop_button.UseVisualStyleBackColor = true;
            this.mineEditionsTop_button.Click += new System.EventHandler(this.mineEditionsTop_button_Click);
            // 
            // allEditionsTop_button
            // 
            this.allEditionsTop_button.Location = new System.Drawing.Point(636, 559);
            this.allEditionsTop_button.Name = "allEditionsTop_button";
            this.allEditionsTop_button.Size = new System.Drawing.Size(250, 34);
            this.allEditionsTop_button.TabIndex = 61;
            this.allEditionsTop_button.Text = "Все издания";
            this.allEditionsTop_button.UseVisualStyleBackColor = true;
            this.allEditionsTop_button.Click += new System.EventHandler(this.allEditionsTop_button_Click);
            // 
            // editionsTop_dataGridView
            // 
            this.editionsTop_dataGridView.AllowUserToAddRows = false;
            this.editionsTop_dataGridView.AllowUserToDeleteRows = false;
            this.editionsTop_dataGridView.AllowUserToOrderColumns = true;
            this.editionsTop_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.editionsTop_dataGridView.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.editionsTop_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.editionsTop_dataGridView.Location = new System.Drawing.Point(59, 100);
            this.editionsTop_dataGridView.Name = "editionsTop_dataGridView";
            this.editionsTop_dataGridView.ReadOnly = true;
            this.editionsTop_dataGridView.RowHeadersWidth = 51;
            this.editionsTop_dataGridView.RowTemplate.Height = 24;
            this.editionsTop_dataGridView.Size = new System.Drawing.Size(827, 442);
            this.editionsTop_dataGridView.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(53, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(833, 63);
            this.label3.TabIndex = 28;
            this.label3.Text = "Популярные издания по отзывам";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(617, 405);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(18, 17);
            this.checkBox3.TabIndex = 27;
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // newAuthor_dateTimePicker
            // 
            this.newAuthor_dateTimePicker.Location = new System.Drawing.Point(318, 320);
            this.newAuthor_dateTimePicker.MaxDate = new System.DateTime(2022, 12, 4, 0, 0, 0, 0);
            this.newAuthor_dateTimePicker.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.newAuthor_dateTimePicker.Name = "newAuthor_dateTimePicker";
            this.newAuthor_dateTimePicker.Size = new System.Drawing.Size(276, 22);
            this.newAuthor_dateTimePicker.TabIndex = 26;
            this.newAuthor_dateTimePicker.Value = new System.DateTime(2022, 12, 4, 0, 0, 0, 0);
            // 
            // registrationButton
            // 
            this.registrationButton.Location = new System.Drawing.Point(365, 474);
            this.registrationButton.Name = "registrationButton";
            this.registrationButton.Size = new System.Drawing.Size(182, 42);
            this.registrationButton.TabIndex = 25;
            this.registrationButton.Text = "Зарегистрировать";
            this.registrationButton.UseVisualStyleBackColor = true;
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Location = new System.Drawing.Point(318, 377);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(56, 16);
            this.password_label.TabIndex = 21;
            this.password_label.Text = "Пароль";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(318, 301);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(106, 16);
            this.label46.TabIndex = 22;
            this.label46.Text = "Дата рождения";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(318, 226);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(41, 16);
            this.label47.TabIndex = 23;
            this.label47.Text = "Email";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(318, 150);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(38, 16);
            this.label48.TabIndex = 24;
            this.label48.Text = "ФИО";
            // 
            // newAuthorPassword_textBox
            // 
            this.newAuthorPassword_textBox.BackColor = System.Drawing.SystemColors.Window;
            this.newAuthorPassword_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newAuthorPassword_textBox.Location = new System.Drawing.Point(318, 396);
            this.newAuthorPassword_textBox.Name = "newAuthorPassword_textBox";
            this.newAuthorPassword_textBox.Size = new System.Drawing.Size(276, 30);
            this.newAuthorPassword_textBox.TabIndex = 18;
            this.newAuthorPassword_textBox.UseSystemPasswordChar = true;
            // 
            // newAuthorEmail_textBox
            // 
            this.newAuthorEmail_textBox.BackColor = System.Drawing.SystemColors.Window;
            this.newAuthorEmail_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newAuthorEmail_textBox.Location = new System.Drawing.Point(318, 245);
            this.newAuthorEmail_textBox.Name = "newAuthorEmail_textBox";
            this.newAuthorEmail_textBox.Size = new System.Drawing.Size(276, 30);
            this.newAuthorEmail_textBox.TabIndex = 19;
            // 
            // newAuthorFio_textBox
            // 
            this.newAuthorFio_textBox.BackColor = System.Drawing.SystemColors.Window;
            this.newAuthorFio_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newAuthorFio_textBox.Location = new System.Drawing.Point(318, 172);
            this.newAuthorFio_textBox.Name = "newAuthorFio_textBox";
            this.newAuthorFio_textBox.Size = new System.Drawing.Size(276, 30);
            this.newAuthorFio_textBox.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(36, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(833, 63);
            this.label5.TabIndex = 4;
            this.label5.Text = "Регистрация автора";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // authors_tabPage
            // 
            this.authors_tabPage.Controls.Add(this.mineCollections_button);
            this.authors_tabPage.Controls.Add(this.label66);
            this.authors_tabPage.Controls.Add(this.label67);
            this.authors_tabPage.Controls.Add(this.label68);
            this.authors_tabPage.Controls.Add(this.authorEmailCollection_comboBox);
            this.authors_tabPage.Controls.Add(this.authorFioCollection_comboBox);
            this.authors_tabPage.Controls.Add(this.authorCollection_button);
            this.authors_tabPage.Controls.Add(this.allCollections_button);
            this.authors_tabPage.Controls.Add(this.collections_dataGridView);
            this.authors_tabPage.Controls.Add(this.label9);
            this.authors_tabPage.Location = new System.Drawing.Point(4, 4);
            this.authors_tabPage.Name = "authors_tabPage";
            this.authors_tabPage.Size = new System.Drawing.Size(961, 601);
            this.authors_tabPage.TabIndex = 3;
            this.authors_tabPage.Text = "3";
            this.authors_tabPage.UseVisualStyleBackColor = true;
            // 
            // mineCollections_button
            // 
            this.mineCollections_button.Location = new System.Drawing.Point(385, 559);
            this.mineCollections_button.Name = "mineCollections_button";
            this.mineCollections_button.Size = new System.Drawing.Size(168, 34);
            this.mineCollections_button.TabIndex = 65;
            this.mineCollections_button.Text = "Мои сборники";
            this.mineCollections_button.UseVisualStyleBackColor = true;
            this.mineCollections_button.Click += new System.EventHandler(this.mine_button_Click);
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.Location = new System.Drawing.Point(451, 115);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(36, 16);
            this.label66.TabIndex = 64;
            this.label66.Text = "ИЛИ";
            // 
            // label67
            // 
            this.label67.AutoSize = true;
            this.label67.Location = new System.Drawing.Point(523, 93);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(91, 16);
            this.label67.TabIndex = 62;
            this.label67.Text = "Email автора";
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.Location = new System.Drawing.Point(56, 93);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(88, 16);
            this.label68.TabIndex = 63;
            this.label68.Text = "ФИО автора";
            // 
            // authorEmailCollection_comboBox
            // 
            this.authorEmailCollection_comboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.authorEmailCollection_comboBox.DataSource = this.authorsBindingSource;
            this.authorEmailCollection_comboBox.DisplayMember = "Email";
            this.authorEmailCollection_comboBox.FormattingEnabled = true;
            this.authorEmailCollection_comboBox.Location = new System.Drawing.Point(526, 112);
            this.authorEmailCollection_comboBox.Name = "authorEmailCollection_comboBox";
            this.authorEmailCollection_comboBox.Size = new System.Drawing.Size(360, 24);
            this.authorEmailCollection_comboBox.TabIndex = 60;
            this.authorEmailCollection_comboBox.ValueMember = "IDUser";
            // 
            // authorFioCollection_comboBox
            // 
            this.authorFioCollection_comboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.authorFioCollection_comboBox.DataSource = this.authorsBindingSource;
            this.authorFioCollection_comboBox.DisplayMember = "FIO";
            this.authorFioCollection_comboBox.FormattingEnabled = true;
            this.authorFioCollection_comboBox.Location = new System.Drawing.Point(59, 112);
            this.authorFioCollection_comboBox.Name = "authorFioCollection_comboBox";
            this.authorFioCollection_comboBox.Size = new System.Drawing.Size(357, 24);
            this.authorFioCollection_comboBox.TabIndex = 61;
            this.authorFioCollection_comboBox.ValueMember = "IDUser";
            // 
            // authorCollection_button
            // 
            this.authorCollection_button.Location = new System.Drawing.Point(59, 559);
            this.authorCollection_button.Name = "authorCollection_button";
            this.authorCollection_button.Size = new System.Drawing.Size(236, 34);
            this.authorCollection_button.TabIndex = 58;
            this.authorCollection_button.Text = "Сборники выбранного автора";
            this.authorCollection_button.UseVisualStyleBackColor = true;
            this.authorCollection_button.Click += new System.EventHandler(this.authorCollection_button_Click);
            // 
            // allCollections_button
            // 
            this.allCollections_button.Location = new System.Drawing.Point(636, 559);
            this.allCollections_button.Name = "allCollections_button";
            this.allCollections_button.Size = new System.Drawing.Size(250, 34);
            this.allCollections_button.TabIndex = 59;
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
            this.collections_dataGridView.Location = new System.Drawing.Point(59, 138);
            this.collections_dataGridView.Name = "collections_dataGridView";
            this.collections_dataGridView.ReadOnly = true;
            this.collections_dataGridView.RowHeadersWidth = 51;
            this.collections_dataGridView.RowTemplate.Height = 24;
            this.collections_dataGridView.Size = new System.Drawing.Size(827, 407);
            this.collections_dataGridView.TabIndex = 57;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(53, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(833, 63);
            this.label9.TabIndex = 56;
            this.label9.Text = "Каталог сборников";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // returnRental_tabPage
            // 
            this.returnRental_tabPage.Controls.Add(this.authorEditions_checkedListBox);
            this.returnRental_tabPage.Controls.Add(this.createCollection_button);
            this.returnRental_tabPage.Controls.Add(this.newCollection_dateTimePicker);
            this.returnRental_tabPage.Controls.Add(this.label20);
            this.returnRental_tabPage.Controls.Add(this.label17);
            this.returnRental_tabPage.Controls.Add(this.label18);
            this.returnRental_tabPage.Controls.Add(this.label19);
            this.returnRental_tabPage.Controls.Add(this.newCollectionDescription_textBox);
            this.returnRental_tabPage.Controls.Add(this.newCollectionName_textBox);
            this.returnRental_tabPage.Controls.Add(this.label2);
            this.returnRental_tabPage.Location = new System.Drawing.Point(4, 4);
            this.returnRental_tabPage.Name = "returnRental_tabPage";
            this.returnRental_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.returnRental_tabPage.Size = new System.Drawing.Size(961, 601);
            this.returnRental_tabPage.TabIndex = 1;
            this.returnRental_tabPage.Text = "2";
            this.returnRental_tabPage.UseVisualStyleBackColor = true;
            // 
            // authorEditions_checkedListBox
            // 
            this.authorEditions_checkedListBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.authorEditions_checkedListBox.FormattingEnabled = true;
            this.authorEditions_checkedListBox.HorizontalScrollbar = true;
            this.authorEditions_checkedListBox.Location = new System.Drawing.Point(59, 126);
            this.authorEditions_checkedListBox.Name = "authorEditions_checkedListBox";
            this.authorEditions_checkedListBox.Size = new System.Drawing.Size(396, 412);
            this.authorEditions_checkedListBox.TabIndex = 71;
            // 
            // createCollection_button
            // 
            this.createCollection_button.Location = new System.Drawing.Point(382, 559);
            this.createCollection_button.Name = "createCollection_button";
            this.createCollection_button.Size = new System.Drawing.Size(175, 34);
            this.createCollection_button.TabIndex = 67;
            this.createCollection_button.Text = "Создать";
            this.createCollection_button.UseVisualStyleBackColor = true;
            this.createCollection_button.Click += new System.EventHandler(this.createCollection_button_Click);
            // 
            // newCollection_dateTimePicker
            // 
            this.newCollection_dateTimePicker.Enabled = false;
            this.newCollection_dateTimePicker.Location = new System.Drawing.Point(510, 193);
            this.newCollection_dateTimePicker.MaxDate = new System.DateTime(2030, 12, 28, 0, 0, 0, 0);
            this.newCollection_dateTimePicker.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.newCollection_dateTimePicker.Name = "newCollection_dateTimePicker";
            this.newCollection_dateTimePicker.Size = new System.Drawing.Size(376, 22);
            this.newCollection_dateTimePicker.TabIndex = 65;
            this.newCollection_dateTimePicker.Value = new System.DateTime(2022, 12, 8, 0, 0, 0, 0);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(56, 107);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(65, 16);
            this.label20.TabIndex = 64;
            this.label20.Text = "Издание";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(507, 233);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(72, 16);
            this.label17.TabIndex = 58;
            this.label17.Text = "Описание";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(507, 174);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(39, 16);
            this.label18.TabIndex = 59;
            this.label18.Text = "Дата";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(507, 107);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(138, 16);
            this.label19.TabIndex = 60;
            this.label19.Text = "Название сборника";
            // 
            // newCollectionDescription_textBox
            // 
            this.newCollectionDescription_textBox.BackColor = System.Drawing.SystemColors.Window;
            this.newCollectionDescription_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newCollectionDescription_textBox.Location = new System.Drawing.Point(510, 252);
            this.newCollectionDescription_textBox.Multiline = true;
            this.newCollectionDescription_textBox.Name = "newCollectionDescription_textBox";
            this.newCollectionDescription_textBox.Size = new System.Drawing.Size(376, 286);
            this.newCollectionDescription_textBox.TabIndex = 54;
            // 
            // newCollectionName_textBox
            // 
            this.newCollectionName_textBox.BackColor = System.Drawing.SystemColors.Window;
            this.newCollectionName_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newCollectionName_textBox.Location = new System.Drawing.Point(510, 126);
            this.newCollectionName_textBox.Name = "newCollectionName_textBox";
            this.newCollectionName_textBox.Size = new System.Drawing.Size(376, 30);
            this.newCollectionName_textBox.TabIndex = 55;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(53, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(833, 63);
            this.label2.TabIndex = 1;
            this.label2.Text = "Создание нового сборника";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addRental_tabPage
            // 
            this.addRental_tabPage.BackColor = System.Drawing.Color.White;
            this.addRental_tabPage.Controls.Add(this.filters_button);
            this.addRental_tabPage.Controls.Add(this.filter_panel);
            this.addRental_tabPage.Controls.Add(this.findEdition_button);
            this.addRental_tabPage.Controls.Add(this.authorEditions_button);
            this.addRental_tabPage.Controls.Add(this.disableEditionsFilter_button);
            this.addRental_tabPage.Controls.Add(this.editionsCatalog_dataGridView);
            this.addRental_tabPage.Controls.Add(this.label1);
            this.addRental_tabPage.Location = new System.Drawing.Point(4, 4);
            this.addRental_tabPage.Name = "addRental_tabPage";
            this.addRental_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.addRental_tabPage.Size = new System.Drawing.Size(961, 601);
            this.addRental_tabPage.TabIndex = 0;
            this.addRental_tabPage.Text = "1";
            // 
            // filters_button
            // 
            this.filters_button.BackColor = System.Drawing.Color.White;
            this.filters_button.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.filters_button.FlatAppearance.BorderSize = 3;
            this.filters_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.filters_button.Location = new System.Drawing.Point(800, 111);
            this.filters_button.Name = "filters_button";
            this.filters_button.Size = new System.Drawing.Size(86, 23);
            this.filters_button.TabIndex = 55;
            this.filters_button.Text = "Фильтры";
            this.filters_button.UseVisualStyleBackColor = false;
            this.filters_button.Click += new System.EventHandler(this.filters_button_Click);
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
            this.filter_panel.Controls.Add(this.label4);
            this.filter_panel.Controls.Add(this.label6);
            this.filter_panel.Controls.Add(this.label8);
            this.filter_panel.Controls.Add(this.label69);
            this.filter_panel.Controls.Add(this.label70);
            this.filter_panel.Controls.Add(this.edition_checkBox);
            this.filter_panel.Controls.Add(this.authorFilter_comboBox);
            this.filter_panel.Enabled = false;
            this.filter_panel.Location = new System.Drawing.Point(459, 140);
            this.filter_panel.Name = "filter_panel";
            this.filter_panel.Size = new System.Drawing.Size(427, 392);
            this.filter_panel.TabIndex = 54;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 318);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 29;
            this.label4.Text = "Издатель";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 16);
            this.label6.TabIndex = 29;
            this.label6.Text = "Тип издания";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 166);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 16);
            this.label8.TabIndex = 29;
            this.label8.Text = "Год";
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
            this.findEdition_button.Location = new System.Drawing.Point(59, 557);
            this.findEdition_button.Name = "findEdition_button";
            this.findEdition_button.Size = new System.Drawing.Size(128, 34);
            this.findEdition_button.TabIndex = 52;
            this.findEdition_button.Text = "Поиск";
            this.findEdition_button.UseVisualStyleBackColor = true;
            this.findEdition_button.Click += new System.EventHandler(this.findEdition_button_Click);
            // 
            // authorEditions_button
            // 
            this.authorEditions_button.Location = new System.Drawing.Point(385, 557);
            this.authorEditions_button.Name = "authorEditions_button";
            this.authorEditions_button.Size = new System.Drawing.Size(168, 34);
            this.authorEditions_button.TabIndex = 53;
            this.authorEditions_button.Text = "Мои издания";
            this.authorEditions_button.UseVisualStyleBackColor = true;
            this.authorEditions_button.Click += new System.EventHandler(this.authorEditions_button_Click);
            // 
            // disableEditionsFilter_button
            // 
            this.disableEditionsFilter_button.Location = new System.Drawing.Point(718, 557);
            this.disableEditionsFilter_button.Name = "disableEditionsFilter_button";
            this.disableEditionsFilter_button.Size = new System.Drawing.Size(168, 34);
            this.disableEditionsFilter_button.TabIndex = 53;
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
            this.editionsCatalog_dataGridView.Location = new System.Drawing.Point(59, 140);
            this.editionsCatalog_dataGridView.Name = "editionsCatalog_dataGridView";
            this.editionsCatalog_dataGridView.ReadOnly = true;
            this.editionsCatalog_dataGridView.RowHeadersWidth = 51;
            this.editionsCatalog_dataGridView.RowTemplate.Height = 24;
            this.editionsCatalog_dataGridView.Size = new System.Drawing.Size(827, 392);
            this.editionsCatalog_dataGridView.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(53, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(833, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "Каталог библиотеки";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // profile_tabPage
            // 
            this.profile_tabPage.Controls.Add(this.groupBox2);
            this.profile_tabPage.Controls.Add(this.groupBox1);
            this.profile_tabPage.Controls.Add(this.label14);
            this.profile_tabPage.Location = new System.Drawing.Point(4, 4);
            this.profile_tabPage.Name = "profile_tabPage";
            this.profile_tabPage.Size = new System.Drawing.Size(961, 601);
            this.profile_tabPage.TabIndex = 13;
            this.profile_tabPage.Text = "profile";
            this.profile_tabPage.UseVisualStyleBackColor = true;
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
            this.groupBox2.Location = new System.Drawing.Point(497, 161);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(346, 321);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Пароль";
            // 
            // new_checkBox
            // 
            this.new_checkBox.AutoSize = true;
            this.new_checkBox.Location = new System.Drawing.Point(316, 135);
            this.new_checkBox.Name = "new_checkBox";
            this.new_checkBox.Size = new System.Drawing.Size(18, 17);
            this.new_checkBox.TabIndex = 21;
            this.new_checkBox.UseVisualStyleBackColor = true;
            this.new_checkBox.CheckedChanged += new System.EventHandler(this.new_checkBox_CheckedChanged);
            // 
            // old_checkBox
            // 
            this.old_checkBox.AutoSize = true;
            this.old_checkBox.Location = new System.Drawing.Point(316, 59);
            this.old_checkBox.Name = "old_checkBox";
            this.old_checkBox.Size = new System.Drawing.Size(18, 17);
            this.old_checkBox.TabIndex = 21;
            this.old_checkBox.UseVisualStyleBackColor = true;
            this.old_checkBox.CheckedChanged += new System.EventHandler(this.old_checkBox_CheckedChanged);
            // 
            // changePassword_button
            // 
            this.changePassword_button.Location = new System.Drawing.Point(71, 260);
            this.changePassword_button.Name = "changePassword_button";
            this.changePassword_button.Size = new System.Drawing.Size(182, 42);
            this.changePassword_button.TabIndex = 19;
            this.changePassword_button.Text = "Изменить пароль";
            this.changePassword_button.UseVisualStyleBackColor = true;
            this.changePassword_button.Click += new System.EventHandler(this.changePassword_button_Click);
            // 
            // newPassword2_label
            // 
            this.newPassword2_label.AutoSize = true;
            this.newPassword2_label.Location = new System.Drawing.Point(21, 184);
            this.newPassword2_label.Name = "newPassword2_label";
            this.newPassword2_label.Size = new System.Drawing.Size(173, 16);
            this.newPassword2_label.TabIndex = 17;
            this.newPassword2_label.Text = "Повторите новый пароль";
            // 
            // newPassword_label
            // 
            this.newPassword_label.AutoSize = true;
            this.newPassword_label.Location = new System.Drawing.Point(21, 109);
            this.newPassword_label.Name = "newPassword_label";
            this.newPassword_label.Size = new System.Drawing.Size(100, 16);
            this.newPassword_label.TabIndex = 17;
            this.newPassword_label.Text = "Новый пароль";
            // 
            // oldPassword_label
            // 
            this.oldPassword_label.AutoSize = true;
            this.oldPassword_label.Location = new System.Drawing.Point(21, 33);
            this.oldPassword_label.Name = "oldPassword_label";
            this.oldPassword_label.Size = new System.Drawing.Size(106, 16);
            this.oldPassword_label.TabIndex = 18;
            this.oldPassword_label.Text = "Старый пароль";
            // 
            // newPasswordReply_textBox
            // 
            this.newPasswordReply_textBox.BackColor = System.Drawing.SystemColors.Window;
            this.newPasswordReply_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newPasswordReply_textBox.Location = new System.Drawing.Point(24, 203);
            this.newPasswordReply_textBox.Name = "newPasswordReply_textBox";
            this.newPasswordReply_textBox.Size = new System.Drawing.Size(276, 26);
            this.newPasswordReply_textBox.TabIndex = 9;
            this.newPasswordReply_textBox.UseSystemPasswordChar = true;
            // 
            // newPassword_textBox
            // 
            this.newPassword_textBox.BackColor = System.Drawing.SystemColors.Window;
            this.newPassword_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newPassword_textBox.Location = new System.Drawing.Point(24, 128);
            this.newPassword_textBox.Name = "newPassword_textBox";
            this.newPassword_textBox.Size = new System.Drawing.Size(276, 26);
            this.newPassword_textBox.TabIndex = 9;
            this.newPassword_textBox.UseSystemPasswordChar = true;
            // 
            // oldPassword_textBox
            // 
            this.oldPassword_textBox.BackColor = System.Drawing.SystemColors.Window;
            this.oldPassword_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.oldPassword_textBox.Location = new System.Drawing.Point(24, 52);
            this.oldPassword_textBox.Name = "oldPassword_textBox";
            this.oldPassword_textBox.Size = new System.Drawing.Size(276, 26);
            this.oldPassword_textBox.TabIndex = 9;
            this.oldPassword_textBox.UseSystemPasswordChar = true;
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
            this.groupBox1.Location = new System.Drawing.Point(84, 166);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(348, 316);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Личные данные";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(36, 206);
            this.dateTimePicker.MaxDate = new System.DateTime(2022, 12, 4, 0, 0, 0, 0);
            this.dateTimePicker.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(276, 22);
            this.dateTimePicker.TabIndex = 20;
            this.dateTimePicker.Value = new System.DateTime(2022, 12, 4, 0, 0, 0, 0);
            // 
            // update_button
            // 
            this.update_button.Location = new System.Drawing.Point(83, 258);
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
            this.birth_Label.Location = new System.Drawing.Point(33, 182);
            this.birth_Label.Name = "birth_Label";
            this.birth_Label.Size = new System.Drawing.Size(106, 16);
            this.birth_Label.TabIndex = 16;
            this.birth_Label.Text = "Дата рождения";
            // 
            // email_label
            // 
            this.email_label.AutoSize = true;
            this.email_label.Location = new System.Drawing.Point(33, 107);
            this.email_label.Name = "email_label";
            this.email_label.Size = new System.Drawing.Size(41, 16);
            this.email_label.TabIndex = 17;
            this.email_label.Text = "Email";
            // 
            // fio_Label
            // 
            this.fio_Label.AutoSize = true;
            this.fio_Label.Location = new System.Drawing.Point(33, 31);
            this.fio_Label.Name = "fio_Label";
            this.fio_Label.Size = new System.Drawing.Size(38, 16);
            this.fio_Label.TabIndex = 18;
            this.fio_Label.Text = "ФИО";
            // 
            // email_textBox
            // 
            this.email_textBox.BackColor = System.Drawing.SystemColors.Window;
            this.email_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.email_textBox.Location = new System.Drawing.Point(36, 126);
            this.email_textBox.Name = "email_textBox";
            this.email_textBox.Size = new System.Drawing.Size(276, 26);
            this.email_textBox.TabIndex = 9;
            // 
            // fio_textBox
            // 
            this.fio_textBox.BackColor = System.Drawing.SystemColors.Window;
            this.fio_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fio_textBox.Location = new System.Drawing.Point(36, 50);
            this.fio_textBox.Name = "fio_textBox";
            this.fio_textBox.Size = new System.Drawing.Size(276, 26);
            this.fio_textBox.TabIndex = 9;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(53, 34);
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
            this.tabControl.Controls.Add(this.addRental_tabPage);
            this.tabControl.Controls.Add(this.returnRental_tabPage);
            this.tabControl.Controls.Add(this.authors_tabPage);
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.registration_tabPage);
            this.tabControl.Controls.Add(this.addEdition_tabPage);
            this.tabControl.Controls.Add(this.editEdition_tabPage);
            this.tabControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabControl.Location = new System.Drawing.Point(288, 0);
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(990, 609);
            this.tabControl.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.review_panel);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.addEditionToCollection_button);
            this.tabPage1.Controls.Add(this.deleteCollection_button);
            this.tabPage1.Controls.Add(this.deleteEditionFromCollection_button);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.authorCollections_comboBox);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.editionsInAuthorCollection_dataGridView);
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(961, 601);
            this.tabPage1.TabIndex = 14;
            this.tabPage1.Text = "4";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // review_panel
            // 
            this.review_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.review_panel.Controls.Add(this.label15);
            this.review_panel.Controls.Add(this.newEditionToCollection_comboBox);
            this.review_panel.Controls.Add(this.createReview_button);
            this.review_panel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.review_panel.Enabled = false;
            this.review_panel.Location = new System.Drawing.Point(271, 230);
            this.review_panel.Name = "review_panel";
            this.review_panel.Size = new System.Drawing.Size(339, 170);
            this.review_panel.TabIndex = 66;
            this.review_panel.Visible = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(27, 27);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(131, 16);
            this.label15.TabIndex = 2;
            this.label15.Text = "Название издания";
            // 
            // newEditionToCollection_comboBox
            // 
            this.newEditionToCollection_comboBox.FormattingEnabled = true;
            this.newEditionToCollection_comboBox.Location = new System.Drawing.Point(27, 51);
            this.newEditionToCollection_comboBox.Name = "newEditionToCollection_comboBox";
            this.newEditionToCollection_comboBox.Size = new System.Drawing.Size(284, 24);
            this.newEditionToCollection_comboBox.TabIndex = 1;
            // 
            // createReview_button
            // 
            this.createReview_button.Location = new System.Drawing.Point(67, 105);
            this.createReview_button.Name = "createReview_button";
            this.createReview_button.Size = new System.Drawing.Size(205, 35);
            this.createReview_button.TabIndex = 0;
            this.createReview_button.Text = "Добавить издание";
            this.createReview_button.UseVisualStyleBackColor = true;
            this.createReview_button.Click += new System.EventHandler(this.createReview_button_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(244, 258);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(339, 170);
            this.panel1.TabIndex = 65;
            this.panel1.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.panel2.Enabled = false;
            this.panel2.Location = new System.Drawing.Point(294, 210);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(339, 170);
            this.panel2.TabIndex = 67;
            this.panel2.Visible = false;
            // 
            // addEditionToCollection_button
            // 
            this.addEditionToCollection_button.Location = new System.Drawing.Point(298, 559);
            this.addEditionToCollection_button.Name = "addEditionToCollection_button";
            this.addEditionToCollection_button.Size = new System.Drawing.Size(270, 34);
            this.addEditionToCollection_button.TabIndex = 64;
            this.addEditionToCollection_button.Text = "Добавить издание в сборник";
            this.addEditionToCollection_button.UseVisualStyleBackColor = true;
            this.addEditionToCollection_button.Click += new System.EventHandler(this.addEditionToCollection_button_Click);
            // 
            // deleteCollection_button
            // 
            this.deleteCollection_button.Location = new System.Drawing.Point(59, 559);
            this.deleteCollection_button.Name = "deleteCollection_button";
            this.deleteCollection_button.Size = new System.Drawing.Size(201, 34);
            this.deleteCollection_button.TabIndex = 63;
            this.deleteCollection_button.Text = "Удалить сборник";
            this.deleteCollection_button.UseVisualStyleBackColor = true;
            this.deleteCollection_button.Click += new System.EventHandler(this.deleteCollection_button_Click);
            // 
            // deleteEditionFromCollection_button
            // 
            this.deleteEditionFromCollection_button.Location = new System.Drawing.Point(621, 559);
            this.deleteEditionFromCollection_button.Name = "deleteEditionFromCollection_button";
            this.deleteEditionFromCollection_button.Size = new System.Drawing.Size(264, 34);
            this.deleteEditionFromCollection_button.TabIndex = 62;
            this.deleteEditionFromCollection_button.Text = "Удалить издания из сборника";
            this.deleteEditionFromCollection_button.UseVisualStyleBackColor = true;
            this.deleteEditionFromCollection_button.Click += new System.EventHandler(this.deleteEditionFromCollection_button_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(59, 89);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(138, 16);
            this.label13.TabIndex = 61;
            this.label13.Text = "Название сборника";
            // 
            // authorCollections_comboBox
            // 
            this.authorCollections_comboBox.DataSource = this.collectionsBindingSource;
            this.authorCollections_comboBox.DisplayMember = "Name";
            this.authorCollections_comboBox.FormattingEnabled = true;
            this.authorCollections_comboBox.Location = new System.Drawing.Point(59, 111);
            this.authorCollections_comboBox.Name = "authorCollections_comboBox";
            this.authorCollections_comboBox.Size = new System.Drawing.Size(400, 24);
            this.authorCollections_comboBox.TabIndex = 60;
            this.authorCollections_comboBox.ValueMember = "IDCollection";
            this.authorCollections_comboBox.SelectedIndexChanged += new System.EventHandler(this.authorCollections_comboBox_SelectedIndexChanged);
            // 
            // collectionsBindingSource
            // 
            this.collectionsBindingSource.DataMember = "Collections";
            this.collectionsBindingSource.DataSource = this.dataSet1;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(53, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(833, 63);
            this.label10.TabIndex = 59;
            this.label10.Text = "Каталог сборников";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // editionsInAuthorCollection_dataGridView
            // 
            this.editionsInAuthorCollection_dataGridView.AllowUserToAddRows = false;
            this.editionsInAuthorCollection_dataGridView.AllowUserToDeleteRows = false;
            this.editionsInAuthorCollection_dataGridView.AllowUserToOrderColumns = true;
            this.editionsInAuthorCollection_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.editionsInAuthorCollection_dataGridView.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.editionsInAuthorCollection_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.editionsInAuthorCollection_dataGridView.Location = new System.Drawing.Point(59, 141);
            this.editionsInAuthorCollection_dataGridView.Name = "editionsInAuthorCollection_dataGridView";
            this.editionsInAuthorCollection_dataGridView.ReadOnly = true;
            this.editionsInAuthorCollection_dataGridView.RowHeadersWidth = 51;
            this.editionsInAuthorCollection_dataGridView.RowTemplate.Height = 24;
            this.editionsInAuthorCollection_dataGridView.Size = new System.Drawing.Size(827, 407);
            this.editionsInAuthorCollection_dataGridView.TabIndex = 58;
            // 
            // editionsTableAdapter
            // 
            this.editionsTableAdapter.ClearBeforeFill = true;
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
            // collectionsTableAdapter
            // 
            this.collectionsTableAdapter.ClearBeforeFill = true;
            // 
            // AuthorWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 609);
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.tabControl);
            this.Name = "AuthorWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AuthorWindow";
            this.Load += new System.EventHandler(this.AuthorWindow_Load);
            this.menuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.editEdition_tabPage.ResumeLayout(false);
            this.editEdition_tabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.authorsTop_DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newEditionCount_numericUpDown)).EndInit();
            this.addEdition_tabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.readersTop_dataGridView)).EndInit();
            this.registration_tabPage.ResumeLayout(false);
            this.registration_tabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editionsTop_dataGridView)).EndInit();
            this.authors_tabPage.ResumeLayout(false);
            this.authors_tabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.collections_dataGridView)).EndInit();
            this.returnRental_tabPage.ResumeLayout(false);
            this.returnRental_tabPage.PerformLayout();
            this.addRental_tabPage.ResumeLayout(false);
            this.filter_panel.ResumeLayout(false);
            this.filter_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.distincPublisherBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.distincTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.distinctYearBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editionsCatalog_dataGridView)).EndInit();
            this.profile_tabPage.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.review_panel.ResumeLayout(false);
            this.review_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.collectionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editionsInAuthorCollection_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.Button profileButton;
        private System.Windows.Forms.TreeView treeView1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource authorsBindingSource;
        private DataSet1TableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.TabPage editEdition_tabPage;
        private System.Windows.Forms.NumericUpDown newEditionCount_numericUpDown;
        private System.Windows.Forms.MaskedTextBox newEditionYear_textBox;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.Label label62;
        private System.Windows.Forms.TextBox newEditionPublisher_textBox;
        private System.Windows.Forms.TextBox newEditionType_textBox;
        private System.Windows.Forms.TextBox newEditionName_textBox;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.ComboBox editEdition_comboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage addEdition_tabPage;
        private System.Windows.Forms.TabPage registration_tabPage;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.DateTimePicker newAuthor_dateTimePicker;
        private System.Windows.Forms.Button registrationButton;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.TextBox newAuthorPassword_textBox;
        private System.Windows.Forms.TextBox newAuthorEmail_textBox;
        private System.Windows.Forms.TextBox newAuthorFio_textBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage authors_tabPage;
        private System.Windows.Forms.TabPage returnRental_tabPage;
        private System.Windows.Forms.Button createCollection_button;
        private System.Windows.Forms.DateTimePicker newCollection_dateTimePicker;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox newCollectionDescription_textBox;
        private System.Windows.Forms.TextBox newCollectionName_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage addRental_tabPage;
        private System.Windows.Forms.Button findEdition_button;
        private System.Windows.Forms.Button authorEditions_button;
        private System.Windows.Forms.Button disableEditionsFilter_button;
        private System.Windows.Forms.DataGridView editionsCatalog_dataGridView;
        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.BindingSource editionsBindingSource;
        private DataSet1TableAdapters.EditionsTableAdapter editionsTableAdapter;
        private System.Windows.Forms.CheckedListBox authorEditions_checkedListBox;
        private System.Windows.Forms.Button mineCollections_button;
        private System.Windows.Forms.Label label66;
        private System.Windows.Forms.Label label67;
        private System.Windows.Forms.Label label68;
        private System.Windows.Forms.ComboBox authorEmailCollection_comboBox;
        private System.Windows.Forms.ComboBox authorFioCollection_comboBox;
        private System.Windows.Forms.Button authorCollection_button;
        private System.Windows.Forms.Button allCollections_button;
        private System.Windows.Forms.DataGridView collections_dataGridView;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView authorsTop_DataGridView;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView readersTop_dataGridView;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView editionsTop_dataGridView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button mineEditionsTop_button;
        private System.Windows.Forms.Button allEditionsTop_button;
        private System.Windows.Forms.Button filters_button;
        private System.Windows.Forms.Panel filter_panel;
        private System.Windows.Forms.ComboBox publishersFilter_comboBox;
        private System.Windows.Forms.ComboBox typeFilter_comboBox;
        private System.Windows.Forms.CheckBox publisher_checkBox;
        private System.Windows.Forms.ComboBox yearFilter_comboBox;
        private System.Windows.Forms.CheckBox type_checkBox;
        private System.Windows.Forms.ComboBox editionsFilter_comboBox;
        private System.Windows.Forms.CheckBox year_checkBox;
        private System.Windows.Forms.CheckBox authorFio_checkBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label69;
        private System.Windows.Forms.Label label70;
        private System.Windows.Forms.CheckBox edition_checkBox;
        private System.Windows.Forms.ComboBox authorFilter_comboBox;
        private DataSet2 dataSet2;
        private System.Windows.Forms.BindingSource distinctYearBindingSource;
        private DataSet2TableAdapters.DistinctYearTableAdapter distinctYearTableAdapter;
        private System.Windows.Forms.BindingSource distincTypeBindingSource;
        private DataSet2TableAdapters.DistincTypeTableAdapter distincTypeTableAdapter;
        private System.Windows.Forms.BindingSource distincPublisherBindingSource;
        private DataSet2TableAdapters.DistincPublisherTableAdapter distincPublisherTableAdapter;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView editionsInAuthorCollection_dataGridView;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox authorCollections_comboBox;
        private System.Windows.Forms.BindingSource collectionsBindingSource;
        private DataSet1TableAdapters.CollectionsTableAdapter collectionsTableAdapter;
        private System.Windows.Forms.Button deleteEditionFromCollection_button;
        private System.Windows.Forms.Button deleteCollection_button;
        private System.Windows.Forms.Button addEditionToCollection_button;
        private System.Windows.Forms.Panel review_panel;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox newEditionToCollection_comboBox;
        private System.Windows.Forms.Button createReview_button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}