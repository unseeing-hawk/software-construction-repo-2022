namespace DB_scientificLibrary.login
{
    partial class RegistrationWindow
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
            this.fio_TextBox = new System.Windows.Forms.TextBox();
            this.backButton = new System.Windows.Forms.Button();
            this.email_textBox = new System.Windows.Forms.TextBox();
            this.password_textBox = new System.Windows.Forms.TextBox();
            this.fio_Label = new System.Windows.Forms.Label();
            this.email_label = new System.Windows.Forms.Label();
            this.birth_Label = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.registrationButton = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // fio_TextBox
            // 
            this.fio_TextBox.BackColor = System.Drawing.SystemColors.Window;
            this.fio_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fio_TextBox.Location = new System.Drawing.Point(100, 104);
            this.fio_TextBox.Name = "fio_TextBox";
            this.fio_TextBox.Size = new System.Drawing.Size(276, 26);
            this.fio_TextBox.TabIndex = 9;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(12, 12);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 14;
            this.backButton.Text = "Назад";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // email_textBox
            // 
            this.email_textBox.BackColor = System.Drawing.SystemColors.Window;
            this.email_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.email_textBox.Location = new System.Drawing.Point(100, 177);
            this.email_textBox.Name = "email_textBox";
            this.email_textBox.Size = new System.Drawing.Size(276, 26);
            this.email_textBox.TabIndex = 9;
            // 
            // password_textBox
            // 
            this.password_textBox.BackColor = System.Drawing.SystemColors.Window;
            this.password_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password_textBox.Location = new System.Drawing.Point(100, 328);
            this.password_textBox.Name = "password_textBox";
            this.password_textBox.Size = new System.Drawing.Size(276, 26);
            this.password_textBox.TabIndex = 9;
            // 
            // fio_Label
            // 
            this.fio_Label.AutoSize = true;
            this.fio_Label.Location = new System.Drawing.Point(100, 82);
            this.fio_Label.Name = "fio_Label";
            this.fio_Label.Size = new System.Drawing.Size(38, 16);
            this.fio_Label.TabIndex = 15;
            this.fio_Label.Text = "ФИО";
            // 
            // email_label
            // 
            this.email_label.AutoSize = true;
            this.email_label.Location = new System.Drawing.Point(100, 158);
            this.email_label.Name = "email_label";
            this.email_label.Size = new System.Drawing.Size(41, 16);
            this.email_label.TabIndex = 15;
            this.email_label.Text = "Email";
            // 
            // birth_Label
            // 
            this.birth_Label.AutoSize = true;
            this.birth_Label.Location = new System.Drawing.Point(100, 233);
            this.birth_Label.Name = "birth_Label";
            this.birth_Label.Size = new System.Drawing.Size(106, 16);
            this.birth_Label.TabIndex = 15;
            this.birth_Label.Text = "Дата рождения";
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Location = new System.Drawing.Point(100, 309);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(56, 16);
            this.password_label.TabIndex = 15;
            this.password_label.Text = "Пароль";
            // 
            // registrationButton
            // 
            this.registrationButton.Location = new System.Drawing.Point(147, 406);
            this.registrationButton.Name = "registrationButton";
            this.registrationButton.Size = new System.Drawing.Size(182, 42);
            this.registrationButton.TabIndex = 16;
            this.registrationButton.Text = "Зарегистрироваться";
            this.registrationButton.UseVisualStyleBackColor = true;
            this.registrationButton.Click += new System.EventHandler(this.registrationButton_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(100, 252);
            this.dateTimePicker.MaxDate = new System.DateTime(2022, 12, 4, 0, 0, 0, 0);
            this.dateTimePicker.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(276, 22);
            this.dateTimePicker.TabIndex = 17;
            this.dateTimePicker.Value = new System.DateTime(2022, 12, 4, 0, 0, 0, 0);
            // 
            // RegistrationWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(480, 524);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.registrationButton);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.birth_Label);
            this.Controls.Add(this.email_label);
            this.Controls.Add(this.fio_Label);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.password_textBox);
            this.Controls.Add(this.email_textBox);
            this.Controls.Add(this.fio_TextBox);
            this.Name = "RegistrationWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistrationWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fio_TextBox;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.TextBox email_textBox;
        private System.Windows.Forms.TextBox password_textBox;
        private System.Windows.Forms.Label fio_Label;
        private System.Windows.Forms.Label email_label;
        private System.Windows.Forms.Label birth_Label;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.Button registrationButton;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
    }
}