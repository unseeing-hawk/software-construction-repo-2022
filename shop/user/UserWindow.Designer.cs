namespace shop.user
{
    partial class UserWindow
    {
        private const string V = "UserWindow";

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
            this.xuiFlatTab1 = new XanderUI.XUIFlatTab();
            this.shop = new System.Windows.Forms.TabPage();
            this.shop_dataGridView = new System.Windows.Forms.DataGridView();
            this.label17 = new System.Windows.Forms.Label();
            this.description_textBox = new System.Windows.Forms.TextBox();
            this.gamesCount_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.xuiBanner1 = new XanderUI.XUIBanner();
            this.cart_button = new XanderUI.XUIButton();
            this.readDescription_button = new XanderUI.XUIButton();
            this.putInCart_button = new XanderUI.XUIButton();
            this.library = new System.Windows.Forms.TabPage();
            this.download_button = new XanderUI.XUIButton();
            this.xuiBanner3 = new XanderUI.XUIBanner();
            this.library_dataGridView = new System.Windows.Forms.DataGridView();
            this.profile = new System.Windows.Forms.TabPage();
            this.exit_button = new XanderUI.XUIButton();
            this.password_button = new XanderUI.XUIButton();
            this.photo_button = new XanderUI.XUIButton();
            this.profile_button = new XanderUI.XUIButton();
            this.profileTabControl = new System.Windows.Forms.TabControl();
            this.editProfile = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.update_button = new System.Windows.Forms.Button();
            this.birth_Label = new System.Windows.Forms.Label();
            this.email_label = new System.Windows.Forms.Label();
            this.fio_Label = new System.Windows.Forms.Label();
            this.email_textBox = new System.Windows.Forms.TextBox();
            this.fio_textBox = new System.Windows.Forms.TextBox();
            this.editPassword = new System.Windows.Forms.TabPage();
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cart = new System.Windows.Forms.TabPage();
            this.order_buton = new XanderUI.XUIButton();
            this.delete_button = new XanderUI.XUIButton();
            this.xuiBanner2 = new XanderUI.XUIBanner();
            this.cart_dataGridView = new System.Windows.Forms.DataGridView();
            this.IDGame = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GameName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shopDataSet1 = new shop.shopDataSet();
            this.gamesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gamesTableAdapter1 = new shop.shopDataSetTableAdapters.GamesTableAdapter();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xuiFlatTab1.SuspendLayout();
            this.shop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shop_dataGridView)).BeginInit();
            this.library.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.library_dataGridView)).BeginInit();
            this.profile.SuspendLayout();
            this.profileTabControl.SuspendLayout();
            this.editProfile.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.editPassword.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.cart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cart_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // xuiFlatTab1
            // 
            this.xuiFlatTab1.ActiveHeaderColor = System.Drawing.Color.DodgerBlue;
            this.xuiFlatTab1.ActiveTextColor = System.Drawing.Color.White;
            this.xuiFlatTab1.BorderColor = System.Drawing.Color.DodgerBlue;
            this.xuiFlatTab1.Controls.Add(this.shop);
            this.xuiFlatTab1.Controls.Add(this.library);
            this.xuiFlatTab1.Controls.Add(this.profile);
            this.xuiFlatTab1.Controls.Add(this.cart);
            this.xuiFlatTab1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xuiFlatTab1.HeaderBackgroundColor = System.Drawing.Color.White;
            this.xuiFlatTab1.InActiveHeaderColor = System.Drawing.Color.RoyalBlue;
            this.xuiFlatTab1.InActiveTextColor = System.Drawing.Color.White;
            this.xuiFlatTab1.ItemSize = new System.Drawing.Size(240, 16);
            this.xuiFlatTab1.Location = new System.Drawing.Point(0, 0);
            this.xuiFlatTab1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.xuiFlatTab1.Name = "xuiFlatTab1";
            this.xuiFlatTab1.PageColor = System.Drawing.Color.White;
            this.xuiFlatTab1.SelectedIndex = 0;
            this.xuiFlatTab1.ShowBorder = true;
            this.xuiFlatTab1.Size = new System.Drawing.Size(1109, 649);
            this.xuiFlatTab1.TabIndex = 0;
            this.xuiFlatTab1.SelectedIndexChanged += new System.EventHandler(this.xuiFlatTab1_SelectedIndexChanged);
            // 
            // shop
            // 
            this.shop.BackColor = System.Drawing.Color.White;
            this.shop.Controls.Add(this.shop_dataGridView);
            this.shop.Controls.Add(this.label17);
            this.shop.Controls.Add(this.description_textBox);
            this.shop.Controls.Add(this.gamesCount_textBox);
            this.shop.Controls.Add(this.label1);
            this.shop.Controls.Add(this.xuiBanner1);
            this.shop.Controls.Add(this.cart_button);
            this.shop.Controls.Add(this.readDescription_button);
            this.shop.Controls.Add(this.putInCart_button);
            this.shop.Location = new System.Drawing.Point(4, 20);
            this.shop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.shop.Name = "shop";
            this.shop.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.shop.Size = new System.Drawing.Size(1101, 625);
            this.shop.TabIndex = 0;
            this.shop.Text = "Магазин";
            // 
            // shop_dataGridView
            // 
            this.shop_dataGridView.AllowUserToAddRows = false;
            this.shop_dataGridView.AllowUserToDeleteRows = false;
            this.shop_dataGridView.AllowUserToOrderColumns = true;
            this.shop_dataGridView.AutoGenerateColumns = false;
            this.shop_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.shop_dataGridView.BackgroundColor = System.Drawing.Color.Honeydew;
            this.shop_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.shop_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.shop_dataGridView.DataSource = this.gamesBindingSource;
            this.shop_dataGridView.Location = new System.Drawing.Point(21, 91);
            this.shop_dataGridView.Name = "shop_dataGridView";
            this.shop_dataGridView.ReadOnly = true;
            this.shop_dataGridView.RowHeadersWidth = 51;
            this.shop_dataGridView.RowTemplate.Height = 24;
            this.shop_dataGridView.Size = new System.Drawing.Size(716, 475);
            this.shop_dataGridView.TabIndex = 60;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(778, 246);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(72, 16);
            this.label17.TabIndex = 59;
            this.label17.Text = "Описание";
            // 
            // description_textBox
            // 
            this.description_textBox.BackColor = System.Drawing.SystemColors.Window;
            this.description_textBox.Enabled = false;
            this.description_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.description_textBox.Location = new System.Drawing.Point(781, 265);
            this.description_textBox.Multiline = true;
            this.description_textBox.Name = "description_textBox";
            this.description_textBox.Size = new System.Drawing.Size(278, 226);
            this.description_textBox.TabIndex = 55;
            // 
            // gamesCount_textBox
            // 
            this.gamesCount_textBox.Enabled = false;
            this.gamesCount_textBox.Location = new System.Drawing.Point(959, 41);
            this.gamesCount_textBox.Name = "gamesCount_textBox";
            this.gamesCount_textBox.Size = new System.Drawing.Size(100, 22);
            this.gamesCount_textBox.TabIndex = 4;
            this.gamesCount_textBox.Text = "0";
            this.gamesCount_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(778, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Игр в корзине:";
            // 
            // xuiBanner1
            // 
            this.xuiBanner1.BackColor = System.Drawing.Color.Transparent;
            this.xuiBanner1.BannerColor = System.Drawing.Color.DodgerBlue;
            this.xuiBanner1.BorderColor = System.Drawing.Color.White;
            this.xuiBanner1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xuiBanner1.ForeColor = System.Drawing.Color.White;
            this.xuiBanner1.Location = new System.Drawing.Point(21, 20);
            this.xuiBanner1.Name = "xuiBanner1";
            this.xuiBanner1.Size = new System.Drawing.Size(716, 65);
            this.xuiBanner1.TabIndex = 2;
            this.xuiBanner1.Text = "Каталог игр";
            // 
            // cart_button
            // 
            this.cart_button.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cart_button.ButtonImage = null;
            this.cart_button.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.cart_button.ButtonText = "Перейти в корзину";
            this.cart_button.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.cart_button.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.cart_button.CornerRadius = 5;
            this.cart_button.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.cart_button.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.cart_button.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.cart_button.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.cart_button.Location = new System.Drawing.Point(781, 516);
            this.cart_button.Name = "cart_button";
            this.cart_button.Size = new System.Drawing.Size(278, 50);
            this.cart_button.TabIndex = 1;
            this.cart_button.TextColor = System.Drawing.Color.DodgerBlue;
            this.cart_button.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.cart_button.Click += new System.EventHandler(this.cart_button_Click);
            // 
            // readDescription_button
            // 
            this.readDescription_button.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.readDescription_button.ButtonImage = null;
            this.readDescription_button.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.readDescription_button.ButtonText = "Прочитать описание";
            this.readDescription_button.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.readDescription_button.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.readDescription_button.CornerRadius = 5;
            this.readDescription_button.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.readDescription_button.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.readDescription_button.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.readDescription_button.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.readDescription_button.Location = new System.Drawing.Point(781, 173);
            this.readDescription_button.Name = "readDescription_button";
            this.readDescription_button.Size = new System.Drawing.Size(278, 50);
            this.readDescription_button.TabIndex = 1;
            this.readDescription_button.TextColor = System.Drawing.Color.DodgerBlue;
            this.readDescription_button.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.readDescription_button.Click += new System.EventHandler(this.readDescription_button_Click);
            // 
            // putInCart_button
            // 
            this.putInCart_button.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.putInCart_button.ButtonImage = null;
            this.putInCart_button.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.putInCart_button.ButtonText = "Положить в корзину";
            this.putInCart_button.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.putInCart_button.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.putInCart_button.CornerRadius = 5;
            this.putInCart_button.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.putInCart_button.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.putInCart_button.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.putInCart_button.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.putInCart_button.Location = new System.Drawing.Point(781, 91);
            this.putInCart_button.Name = "putInCart_button";
            this.putInCart_button.Size = new System.Drawing.Size(278, 50);
            this.putInCart_button.TabIndex = 1;
            this.putInCart_button.TextColor = System.Drawing.Color.DodgerBlue;
            this.putInCart_button.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.putInCart_button.Click += new System.EventHandler(this.putInCart_button_Click);
            // 
            // library
            // 
            this.library.BackColor = System.Drawing.Color.White;
            this.library.Controls.Add(this.download_button);
            this.library.Controls.Add(this.xuiBanner3);
            this.library.Controls.Add(this.library_dataGridView);
            this.library.Location = new System.Drawing.Point(4, 20);
            this.library.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.library.Name = "library";
            this.library.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.library.Size = new System.Drawing.Size(1101, 625);
            this.library.TabIndex = 1;
            this.library.Text = "Библиотека";
            // 
            // download_button
            // 
            this.download_button.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.download_button.ButtonImage = null;
            this.download_button.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.download_button.ButtonText = "Скачать";
            this.download_button.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.download_button.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.download_button.CornerRadius = 5;
            this.download_button.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.download_button.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.download_button.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.download_button.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.download_button.Location = new System.Drawing.Point(783, 91);
            this.download_button.Name = "download_button";
            this.download_button.Size = new System.Drawing.Size(278, 50);
            this.download_button.TabIndex = 4;
            this.download_button.TextColor = System.Drawing.Color.DodgerBlue;
            this.download_button.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.download_button.Click += new System.EventHandler(this.download_button_Click);
            // 
            // xuiBanner3
            // 
            this.xuiBanner3.BackColor = System.Drawing.Color.Transparent;
            this.xuiBanner3.BannerColor = System.Drawing.Color.DodgerBlue;
            this.xuiBanner3.BorderColor = System.Drawing.Color.White;
            this.xuiBanner3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xuiBanner3.ForeColor = System.Drawing.Color.White;
            this.xuiBanner3.Location = new System.Drawing.Point(21, 20);
            this.xuiBanner3.Name = "xuiBanner3";
            this.xuiBanner3.Size = new System.Drawing.Size(716, 65);
            this.xuiBanner3.TabIndex = 3;
            this.xuiBanner3.Text = "Библиотека игр";
            // 
            // library_dataGridView
            // 
            this.library_dataGridView.AllowUserToAddRows = false;
            this.library_dataGridView.AllowUserToDeleteRows = false;
            this.library_dataGridView.AllowUserToOrderColumns = true;
            this.library_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.library_dataGridView.BackgroundColor = System.Drawing.Color.Honeydew;
            this.library_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.library_dataGridView.Location = new System.Drawing.Point(21, 91);
            this.library_dataGridView.Name = "library_dataGridView";
            this.library_dataGridView.ReadOnly = true;
            this.library_dataGridView.RowHeadersWidth = 51;
            this.library_dataGridView.RowTemplate.Height = 24;
            this.library_dataGridView.Size = new System.Drawing.Size(716, 475);
            this.library_dataGridView.TabIndex = 1;
            // 
            // profile
            // 
            this.profile.BackColor = System.Drawing.Color.White;
            this.profile.Controls.Add(this.panel1);
            this.profile.Controls.Add(this.exit_button);
            this.profile.Controls.Add(this.password_button);
            this.profile.Controls.Add(this.photo_button);
            this.profile.Controls.Add(this.profile_button);
            this.profile.Controls.Add(this.profileTabControl);
            this.profile.Controls.Add(this.pictureBox);
            this.profile.Location = new System.Drawing.Point(4, 20);
            this.profile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.profile.Name = "profile";
            this.profile.Size = new System.Drawing.Size(1101, 625);
            this.profile.TabIndex = 2;
            this.profile.Text = "Профиль";
            // 
            // exit_button
            // 
            this.exit_button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.exit_button.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.exit_button.ButtonImage = null;
            this.exit_button.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.exit_button.ButtonText = "Выход";
            this.exit_button.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.exit_button.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.exit_button.CornerRadius = 5;
            this.exit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exit_button.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.exit_button.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.exit_button.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.exit_button.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.exit_button.Location = new System.Drawing.Point(17, 542);
            this.exit_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(319, 62);
            this.exit_button.TabIndex = 27;
            this.exit_button.TextColor = System.Drawing.Color.DodgerBlue;
            this.exit_button.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // password_button
            // 
            this.password_button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.password_button.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.password_button.ButtonImage = null;
            this.password_button.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.password_button.ButtonText = "Изменить пароль";
            this.password_button.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.password_button.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.password_button.CornerRadius = 5;
            this.password_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password_button.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.password_button.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.password_button.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.password_button.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.password_button.Location = new System.Drawing.Point(17, 370);
            this.password_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.password_button.Name = "password_button";
            this.password_button.Size = new System.Drawing.Size(319, 62);
            this.password_button.TabIndex = 27;
            this.password_button.TextColor = System.Drawing.Color.DodgerBlue;
            this.password_button.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.password_button.Click += new System.EventHandler(this.password_button_Click);
            // 
            // photo_button
            // 
            this.photo_button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.photo_button.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.photo_button.ButtonImage = null;
            this.photo_button.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.photo_button.ButtonText = "Изменить фото";
            this.photo_button.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.photo_button.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.photo_button.CornerRadius = 5;
            this.photo_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.photo_button.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.photo_button.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.photo_button.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.photo_button.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.photo_button.Location = new System.Drawing.Point(17, 263);
            this.photo_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.photo_button.Name = "photo_button";
            this.photo_button.Size = new System.Drawing.Size(319, 62);
            this.photo_button.TabIndex = 27;
            this.photo_button.TextColor = System.Drawing.Color.DodgerBlue;
            this.photo_button.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.photo_button.Click += new System.EventHandler(this.photo_button_Click);
            // 
            // profile_button
            // 
            this.profile_button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.profile_button.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.profile_button.ButtonImage = null;
            this.profile_button.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.profile_button.ButtonText = "Профиль";
            this.profile_button.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.profile_button.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.profile_button.CornerRadius = 5;
            this.profile_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.profile_button.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.profile_button.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.profile_button.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.profile_button.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.profile_button.Location = new System.Drawing.Point(17, 178);
            this.profile_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.profile_button.MinimumSize = new System.Drawing.Size(275, 50);
            this.profile_button.Name = "profile_button";
            this.profile_button.Size = new System.Drawing.Size(319, 50);
            this.profile_button.TabIndex = 27;
            this.profile_button.TextColor = System.Drawing.Color.DodgerBlue;
            this.profile_button.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.profile_button.Click += new System.EventHandler(this.profile_button_Click);
            // 
            // profileTabControl
            // 
            this.profileTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.profileTabControl.Controls.Add(this.editProfile);
            this.profileTabControl.Controls.Add(this.editPassword);
            this.profileTabControl.Location = new System.Drawing.Point(373, 46);
            this.profileTabControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.profileTabControl.MinimumSize = new System.Drawing.Size(619, 458);
            this.profileTabControl.Name = "profileTabControl";
            this.profileTabControl.SelectedIndex = 0;
            this.profileTabControl.Size = new System.Drawing.Size(700, 558);
            this.profileTabControl.TabIndex = 26;
            // 
            // editProfile
            // 
            this.editProfile.Controls.Add(this.groupBox1);
            this.editProfile.Location = new System.Drawing.Point(4, 25);
            this.editProfile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.editProfile.Name = "editProfile";
            this.editProfile.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.editProfile.Size = new System.Drawing.Size(692, 529);
            this.editProfile.TabIndex = 0;
            this.editProfile.Text = "профиль";
            this.editProfile.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dateTimePicker);
            this.groupBox1.Controls.Add(this.update_button);
            this.groupBox1.Controls.Add(this.birth_Label);
            this.groupBox1.Controls.Add(this.email_label);
            this.groupBox1.Controls.Add(this.fio_Label);
            this.groupBox1.Controls.Add(this.email_textBox);
            this.groupBox1.Controls.Add(this.fio_textBox);
            this.groupBox1.Location = new System.Drawing.Point(124, 39);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(473, 442);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Личные данные";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker.Location = new System.Drawing.Point(44, 226);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker.MaxDate = new System.DateTime(2022, 12, 4, 0, 0, 0, 0);
            this.dateTimePicker.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(393, 30);
            this.dateTimePicker.TabIndex = 20;
            this.dateTimePicker.Value = new System.DateTime(2022, 12, 4, 0, 0, 0, 0);
            // 
            // update_button
            // 
            this.update_button.BackColor = System.Drawing.Color.DodgerBlue;
            this.update_button.Location = new System.Drawing.Point(100, 340);
            this.update_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(283, 55);
            this.update_button.TabIndex = 19;
            this.update_button.Text = "Обновить данные";
            this.update_button.UseVisualStyleBackColor = false;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // birth_Label
            // 
            this.birth_Label.AutoSize = true;
            this.birth_Label.Location = new System.Drawing.Point(41, 203);
            this.birth_Label.Name = "birth_Label";
            this.birth_Label.Size = new System.Drawing.Size(106, 16);
            this.birth_Label.TabIndex = 16;
            this.birth_Label.Text = "Дата рождения";
            // 
            // email_label
            // 
            this.email_label.AutoSize = true;
            this.email_label.Location = new System.Drawing.Point(41, 128);
            this.email_label.Name = "email_label";
            this.email_label.Size = new System.Drawing.Size(41, 16);
            this.email_label.TabIndex = 17;
            this.email_label.Text = "Email";
            // 
            // fio_Label
            // 
            this.fio_Label.AutoSize = true;
            this.fio_Label.Location = new System.Drawing.Point(41, 52);
            this.fio_Label.Name = "fio_Label";
            this.fio_Label.Size = new System.Drawing.Size(38, 16);
            this.fio_Label.TabIndex = 18;
            this.fio_Label.Text = "ФИО";
            // 
            // email_textBox
            // 
            this.email_textBox.BackColor = System.Drawing.SystemColors.Window;
            this.email_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.email_textBox.Location = new System.Drawing.Point(44, 146);
            this.email_textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.email_textBox.Name = "email_textBox";
            this.email_textBox.Size = new System.Drawing.Size(393, 30);
            this.email_textBox.TabIndex = 9;
            // 
            // fio_textBox
            // 
            this.fio_textBox.BackColor = System.Drawing.SystemColors.Window;
            this.fio_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fio_textBox.Location = new System.Drawing.Point(44, 71);
            this.fio_textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fio_textBox.Name = "fio_textBox";
            this.fio_textBox.Size = new System.Drawing.Size(393, 30);
            this.fio_textBox.TabIndex = 9;
            // 
            // editPassword
            // 
            this.editPassword.Controls.Add(this.groupBox2);
            this.editPassword.Location = new System.Drawing.Point(4, 25);
            this.editPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.editPassword.Name = "editPassword";
            this.editPassword.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.editPassword.Size = new System.Drawing.Size(692, 529);
            this.editPassword.TabIndex = 1;
            this.editPassword.Text = "пароль";
            this.editPassword.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.new_checkBox);
            this.groupBox2.Controls.Add(this.old_checkBox);
            this.groupBox2.Controls.Add(this.changePassword_button);
            this.groupBox2.Controls.Add(this.newPassword2_label);
            this.groupBox2.Controls.Add(this.newPassword_label);
            this.groupBox2.Controls.Add(this.oldPassword_label);
            this.groupBox2.Controls.Add(this.newPasswordReply_textBox);
            this.groupBox2.Controls.Add(this.newPassword_textBox);
            this.groupBox2.Controls.Add(this.oldPassword_textBox);
            this.groupBox2.Location = new System.Drawing.Point(124, 39);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(473, 442);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Пароль";
            // 
            // new_checkBox
            // 
            this.new_checkBox.AutoSize = true;
            this.new_checkBox.Location = new System.Drawing.Point(419, 153);
            this.new_checkBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.new_checkBox.Name = "new_checkBox";
            this.new_checkBox.Size = new System.Drawing.Size(18, 17);
            this.new_checkBox.TabIndex = 21;
            this.new_checkBox.UseVisualStyleBackColor = true;
            this.new_checkBox.CheckedChanged += new System.EventHandler(this.new_checkBox_CheckedChanged);
            // 
            // old_checkBox
            // 
            this.old_checkBox.AutoSize = true;
            this.old_checkBox.Location = new System.Drawing.Point(419, 78);
            this.old_checkBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.old_checkBox.Name = "old_checkBox";
            this.old_checkBox.Size = new System.Drawing.Size(18, 17);
            this.old_checkBox.TabIndex = 21;
            this.old_checkBox.UseVisualStyleBackColor = true;
            this.old_checkBox.CheckedChanged += new System.EventHandler(this.old_checkBox_CheckedChanged);
            // 
            // changePassword_button
            // 
            this.changePassword_button.BackColor = System.Drawing.Color.DodgerBlue;
            this.changePassword_button.Location = new System.Drawing.Point(100, 340);
            this.changePassword_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.changePassword_button.Name = "changePassword_button";
            this.changePassword_button.Size = new System.Drawing.Size(283, 55);
            this.changePassword_button.TabIndex = 19;
            this.changePassword_button.Text = "Изменить пароль";
            this.changePassword_button.UseVisualStyleBackColor = false;
            this.changePassword_button.Click += new System.EventHandler(this.changePassword_button_Click);
            // 
            // newPassword2_label
            // 
            this.newPassword2_label.AutoSize = true;
            this.newPassword2_label.Location = new System.Drawing.Point(41, 208);
            this.newPassword2_label.Name = "newPassword2_label";
            this.newPassword2_label.Size = new System.Drawing.Size(173, 16);
            this.newPassword2_label.TabIndex = 17;
            this.newPassword2_label.Text = "Повторите новый пароль";
            // 
            // newPassword_label
            // 
            this.newPassword_label.AutoSize = true;
            this.newPassword_label.Location = new System.Drawing.Point(41, 128);
            this.newPassword_label.Name = "newPassword_label";
            this.newPassword_label.Size = new System.Drawing.Size(100, 16);
            this.newPassword_label.TabIndex = 17;
            this.newPassword_label.Text = "Новый пароль";
            // 
            // oldPassword_label
            // 
            this.oldPassword_label.AutoSize = true;
            this.oldPassword_label.Location = new System.Drawing.Point(41, 53);
            this.oldPassword_label.Name = "oldPassword_label";
            this.oldPassword_label.Size = new System.Drawing.Size(106, 16);
            this.oldPassword_label.TabIndex = 18;
            this.oldPassword_label.Text = "Старый пароль";
            // 
            // newPasswordReply_textBox
            // 
            this.newPasswordReply_textBox.BackColor = System.Drawing.SystemColors.Window;
            this.newPasswordReply_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newPasswordReply_textBox.Location = new System.Drawing.Point(44, 226);
            this.newPasswordReply_textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.newPasswordReply_textBox.Name = "newPasswordReply_textBox";
            this.newPasswordReply_textBox.Size = new System.Drawing.Size(393, 30);
            this.newPasswordReply_textBox.TabIndex = 9;
            this.newPasswordReply_textBox.UseSystemPasswordChar = true;
            // 
            // newPassword_textBox
            // 
            this.newPassword_textBox.BackColor = System.Drawing.SystemColors.Window;
            this.newPassword_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newPassword_textBox.Location = new System.Drawing.Point(44, 146);
            this.newPassword_textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.newPassword_textBox.Name = "newPassword_textBox";
            this.newPassword_textBox.Size = new System.Drawing.Size(365, 30);
            this.newPassword_textBox.TabIndex = 9;
            this.newPassword_textBox.UseSystemPasswordChar = true;
            // 
            // oldPassword_textBox
            // 
            this.oldPassword_textBox.BackColor = System.Drawing.SystemColors.Window;
            this.oldPassword_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.oldPassword_textBox.Location = new System.Drawing.Point(44, 71);
            this.oldPassword_textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.oldPassword_textBox.Name = "oldPassword_textBox";
            this.oldPassword_textBox.Size = new System.Drawing.Size(365, 30);
            this.oldPassword_textBox.TabIndex = 9;
            this.oldPassword_textBox.UseSystemPasswordChar = true;
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox.Image = global::shop.Properties.Resources.Profile;
            this.pictureBox.InitialImage = global::shop.Properties.Resources.Profile;
            this.pictureBox.Location = new System.Drawing.Point(116, 23);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(121, 121);
            this.pictureBox.TabIndex = 29;
            this.pictureBox.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Location = new System.Drawing.Point(373, 23);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 57);
            this.panel1.TabIndex = 28;
            // 
            // cart
            // 
            this.cart.BackColor = System.Drawing.Color.White;
            this.cart.Controls.Add(this.order_buton);
            this.cart.Controls.Add(this.delete_button);
            this.cart.Controls.Add(this.xuiBanner2);
            this.cart.Controls.Add(this.cart_dataGridView);
            this.cart.Location = new System.Drawing.Point(4, 20);
            this.cart.Name = "cart";
            this.cart.Padding = new System.Windows.Forms.Padding(3);
            this.cart.Size = new System.Drawing.Size(1101, 625);
            this.cart.TabIndex = 3;
            this.cart.Text = "Корзина";
            // 
            // order_buton
            // 
            this.order_buton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.order_buton.ButtonImage = null;
            this.order_buton.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.order_buton.ButtonText = "Оформить заказ";
            this.order_buton.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.order_buton.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.order_buton.CornerRadius = 5;
            this.order_buton.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.order_buton.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.order_buton.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.order_buton.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.order_buton.Location = new System.Drawing.Point(781, 516);
            this.order_buton.Name = "order_buton";
            this.order_buton.Size = new System.Drawing.Size(278, 50);
            this.order_buton.TabIndex = 4;
            this.order_buton.TextColor = System.Drawing.Color.DodgerBlue;
            this.order_buton.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.order_buton.Click += new System.EventHandler(this.order_buton_Click);
            // 
            // delete_button
            // 
            this.delete_button.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.delete_button.ButtonImage = null;
            this.delete_button.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.delete_button.ButtonText = "Удалить";
            this.delete_button.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.delete_button.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.delete_button.CornerRadius = 5;
            this.delete_button.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.delete_button.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.delete_button.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.delete_button.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.delete_button.Location = new System.Drawing.Point(781, 91);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(278, 50);
            this.delete_button.TabIndex = 4;
            this.delete_button.TextColor = System.Drawing.Color.DodgerBlue;
            this.delete_button.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // xuiBanner2
            // 
            this.xuiBanner2.BackColor = System.Drawing.Color.Transparent;
            this.xuiBanner2.BannerColor = System.Drawing.Color.DodgerBlue;
            this.xuiBanner2.BorderColor = System.Drawing.Color.White;
            this.xuiBanner2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xuiBanner2.ForeColor = System.Drawing.Color.White;
            this.xuiBanner2.Location = new System.Drawing.Point(21, 20);
            this.xuiBanner2.Name = "xuiBanner2";
            this.xuiBanner2.Size = new System.Drawing.Size(716, 65);
            this.xuiBanner2.TabIndex = 3;
            this.xuiBanner2.Text = "Корзина";
            // 
            // cart_dataGridView
            // 
            this.cart_dataGridView.AllowUserToAddRows = false;
            this.cart_dataGridView.AllowUserToDeleteRows = false;
            this.cart_dataGridView.AllowUserToOrderColumns = true;
            this.cart_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.cart_dataGridView.BackgroundColor = System.Drawing.Color.Honeydew;
            this.cart_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cart_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDGame,
            this.GameName,
            this.Price,
            this.Descr});
            this.cart_dataGridView.Location = new System.Drawing.Point(21, 91);
            this.cart_dataGridView.Name = "cart_dataGridView";
            this.cart_dataGridView.ReadOnly = true;
            this.cart_dataGridView.RowHeadersWidth = 51;
            this.cart_dataGridView.RowTemplate.Height = 24;
            this.cart_dataGridView.Size = new System.Drawing.Size(716, 475);
            this.cart_dataGridView.TabIndex = 1;
            // 
            // IDGame
            // 
            this.IDGame.HeaderText = "IDGame";
            this.IDGame.MinimumWidth = 6;
            this.IDGame.Name = "IDGame";
            this.IDGame.ReadOnly = true;
            this.IDGame.Visible = false;
            // 
            // GameName
            // 
            this.GameName.HeaderText = "GameName";
            this.GameName.MinimumWidth = 6;
            this.GameName.Name = "GameName";
            this.GameName.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Descr
            // 
            this.Descr.HeaderText = "Descr";
            this.Descr.MinimumWidth = 6;
            this.Descr.Name = "Descr";
            this.Descr.ReadOnly = true;
            this.Descr.Visible = false;
            // 
            // shopDataSet1
            // 
            this.shopDataSet1.DataSetName = "shopDataSet";
            this.shopDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gamesBindingSource
            // 
            this.gamesBindingSource.DataMember = "Games";
            this.gamesBindingSource.DataSource = this.shopDataSet1;
            // 
            // gamesTableAdapter1
            // 
            this.gamesTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Price";
            this.dataGridViewTextBoxColumn4.HeaderText = "Price";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn3.HeaderText = "Description";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "GameName";
            this.dataGridViewTextBoxColumn2.HeaderText = "GameName";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IDGame";
            this.dataGridViewTextBoxColumn1.HeaderText = "IDGame";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // UserWindow
            // 
            this.AccessibleName = "UserWindow";
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 649);
            this.Controls.Add(this.xuiFlatTab1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UserWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserWindow";
            this.Load += new System.EventHandler(this.UserWindow_Load);
            this.xuiFlatTab1.ResumeLayout(false);
            this.shop.ResumeLayout(false);
            this.shop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shop_dataGridView)).EndInit();
            this.library.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.library_dataGridView)).EndInit();
            this.profile.ResumeLayout(false);
            this.profileTabControl.ResumeLayout(false);
            this.editProfile.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.editPassword.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.cart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cart_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private XanderUI.XUIFlatTab xuiFlatTab1;
        private System.Windows.Forms.TabPage shop;
        private System.Windows.Forms.TabPage library;
        private System.Windows.Forms.TabPage profile;
        private System.Windows.Forms.TabControl profileTabControl;
        private System.Windows.Forms.TabPage editProfile;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.Label birth_Label;
        private System.Windows.Forms.Label email_label;
        private System.Windows.Forms.Label fio_Label;
        private System.Windows.Forms.TextBox email_textBox;
        private System.Windows.Forms.TextBox fio_textBox;
        private System.Windows.Forms.TabPage editPassword;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox new_checkBox;
        private System.Windows.Forms.CheckBox old_checkBox;
        private System.Windows.Forms.Button changePassword_button;
        private System.Windows.Forms.Label newPassword2_label;
        private System.Windows.Forms.Label newPassword_label;
        private System.Windows.Forms.Label oldPassword_label;
        private System.Windows.Forms.TextBox newPasswordReply_textBox;
        private System.Windows.Forms.TextBox newPassword_textBox;
        private System.Windows.Forms.TextBox oldPassword_textBox;
        private XanderUI.XUIButton profile_button;
        private XanderUI.XUIButton exit_button;
        private XanderUI.XUIButton password_button;
        private XanderUI.XUIButton photo_button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox;
        private XanderUI.XUIButton readDescription_button;
        private XanderUI.XUIButton putInCart_button;
        private XanderUI.XUIButton cart_button;
        private XanderUI.XUIBanner xuiBanner1;
        private System.Windows.Forms.TextBox gamesCount_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage cart;
        private XanderUI.XUIButton order_buton;
        private XanderUI.XUIButton delete_button;
        private XanderUI.XUIBanner xuiBanner2;
        private System.Windows.Forms.DataGridView cart_dataGridView;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox description_textBox;
        private XanderUI.XUIBanner xuiBanner3;
        private System.Windows.Forms.DataGridView library_dataGridView;
        private XanderUI.XUIButton download_button;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDGame;
        private System.Windows.Forms.DataGridViewTextBoxColumn GameName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descr;
        private System.Windows.Forms.DataGridView shop_dataGridView;
        private shopDataSet shopDataSet;
        private shopDataSetTableAdapters.GamesTableAdapter gamesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDGameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gameNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private shopDataSet shopDataSet1;
        private System.Windows.Forms.BindingSource gamesBindingSource;
        private shopDataSetTableAdapters.GamesTableAdapter gamesTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}