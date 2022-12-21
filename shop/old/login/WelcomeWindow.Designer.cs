namespace DB_scientificLibrary.login
{
    partial class WelcomeWindow
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
            this.WelcomeLabel1 = new System.Windows.Forms.Label();
            this.registrationButton = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.registrationLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // WelcomeLabel1
            // 
            this.WelcomeLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WelcomeLabel1.Location = new System.Drawing.Point(70, 73);
            this.WelcomeLabel1.Name = "WelcomeLabel1";
            this.WelcomeLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.WelcomeLabel1.Size = new System.Drawing.Size(338, 91);
            this.WelcomeLabel1.TabIndex = 0;
            this.WelcomeLabel1.Text = "Научная библиотека \"ЗНАНИЯ\"";
            this.WelcomeLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // registrationButton
            // 
            this.registrationButton.Location = new System.Drawing.Point(112, 260);
            this.registrationButton.Name = "registrationButton";
            this.registrationButton.Size = new System.Drawing.Size(257, 52);
            this.registrationButton.TabIndex = 1;
            this.registrationButton.Text = "Зарегистрироваться";
            this.registrationButton.UseVisualStyleBackColor = true;
            this.registrationButton.Click += new System.EventHandler(this.registrationButton_Click);
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(112, 393);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(257, 52);
            this.loginButton.TabIndex = 1;
            this.loginButton.Text = "Войти";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // registrationLabel
            // 
            this.registrationLabel.Location = new System.Drawing.Point(109, 195);
            this.registrationLabel.Name = "registrationLabel";
            this.registrationLabel.Size = new System.Drawing.Size(260, 62);
            this.registrationLabel.TabIndex = 2;
            this.registrationLabel.Text = "Если вы читатель и еще не имеете своего профиля в нашей библиотеке, то, пожалуйст" +
    "а, зарегистрируйтесь.";
            this.registrationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(109, 349);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 41);
            this.label1.TabIndex = 2;
            this.label1.Text = "Иначе войдите, чтобы начать пользоваться системой.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WelcomeWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(480, 524);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.registrationLabel);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.registrationButton);
            this.Controls.Add(this.WelcomeLabel1);
            this.Name = "WelcomeWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WelcomeWindow";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label WelcomeLabel1;
        private System.Windows.Forms.Button registrationButton;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label registrationLabel;
        private System.Windows.Forms.Label label1;
    }
}