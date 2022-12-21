namespace shop.login
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
            this.registrationButton = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.registrationLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.xuiBanner1 = new XanderUI.XUIBanner();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // registrationButton
            // 
            this.registrationButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.registrationButton.Location = new System.Drawing.Point(115, 277);
            this.registrationButton.Name = "registrationButton";
            this.registrationButton.Size = new System.Drawing.Size(257, 52);
            this.registrationButton.TabIndex = 1;
            this.registrationButton.Text = "Зарегистрироваться";
            this.registrationButton.UseVisualStyleBackColor = false;
            this.registrationButton.Click += new System.EventHandler(this.registrationButton_Click);
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.loginButton.Location = new System.Drawing.Point(115, 410);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(257, 52);
            this.loginButton.TabIndex = 1;
            this.loginButton.Text = "Войти";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // registrationLabel
            // 
            this.registrationLabel.Location = new System.Drawing.Point(113, 234);
            this.registrationLabel.Name = "registrationLabel";
            this.registrationLabel.Size = new System.Drawing.Size(260, 40);
            this.registrationLabel.TabIndex = 2;
            this.registrationLabel.Text = "Если у вас еще нет профиля, то зарегистрируйтесь.";
            this.registrationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(113, 366);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 41);
            this.label1.TabIndex = 2;
            this.label1.Text = "Иначе войдите, чтобы начать пользоваться системой.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // xuiBanner1
            // 
            this.xuiBanner1.BackColor = System.Drawing.Color.DodgerBlue;
            this.xuiBanner1.BannerColor = System.Drawing.Color.RoyalBlue;
            this.xuiBanner1.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.xuiBanner1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xuiBanner1.ForeColor = System.Drawing.Color.Black;
            this.xuiBanner1.Location = new System.Drawing.Point(60, 52);
            this.xuiBanner1.Name = "xuiBanner1";
            this.xuiBanner1.Size = new System.Drawing.Size(366, 96);
            this.xuiBanner1.TabIndex = 3;
            this.xuiBanner1.TabStop = false;
            this.xuiBanner1.Text = "ИГРОМАНИЯ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.xuiBanner1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(480, 192);
            this.panel1.TabIndex = 4;
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
            this.Controls.Add(this.panel1);
            this.Name = "WelcomeWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WelcomeWindow";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button registrationButton;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label registrationLabel;
        private System.Windows.Forms.Label label1;
        private XanderUI.XUIBanner xuiBanner1;
        private System.Windows.Forms.Panel panel1;
    }
}