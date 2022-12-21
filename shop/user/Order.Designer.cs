namespace shop.user
{
    partial class Order
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
            this.xuiCard1 = new XanderUI.XUICard();
            this.xuiCard2 = new XanderUI.XUICard();
            this.gamesSum_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cardNumber_textBox = new System.Windows.Forms.MaskedTextBox();
            this.cvv_textBox = new System.Windows.Forms.MaskedTextBox();
            this.order_buton = new XanderUI.XUIButton();
            this.phone_textBox = new System.Windows.Forms.MaskedTextBox();
            this.card_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // xuiCard1
            // 
            this.xuiCard1.BackColor = System.Drawing.Color.Transparent;
            this.xuiCard1.Color1 = System.Drawing.Color.DodgerBlue;
            this.xuiCard1.Color2 = System.Drawing.Color.DarkOliveGreen;
            this.xuiCard1.ForeColor = System.Drawing.Color.White;
            this.xuiCard1.Location = new System.Drawing.Point(56, 34);
            this.xuiCard1.Name = "xuiCard1";
            this.xuiCard1.Size = new System.Drawing.Size(320, 170);
            this.xuiCard1.TabIndex = 0;
            this.xuiCard1.Text = "xuiCard1";
            this.xuiCard1.Text1 = "Bank Card";
            this.xuiCard1.Text2 = "1234 5678 9101 1121";
            this.xuiCard1.Text3 = "Due to: ";
            // 
            // xuiCard2
            // 
            this.xuiCard2.BackColor = System.Drawing.Color.Transparent;
            this.xuiCard2.Color1 = System.Drawing.Color.DodgerBlue;
            this.xuiCard2.Color2 = System.Drawing.Color.DarkOliveGreen;
            this.xuiCard2.ForeColor = System.Drawing.Color.White;
            this.xuiCard2.Location = new System.Drawing.Point(119, 98);
            this.xuiCard2.Name = "xuiCard2";
            this.xuiCard2.Size = new System.Drawing.Size(320, 170);
            this.xuiCard2.TabIndex = 0;
            this.xuiCard2.Text = "xuiCard1";
            this.xuiCard2.Text1 = "";
            this.xuiCard2.Text2 = "";
            this.xuiCard2.Text3 = "                                  CVV:  ";
            // 
            // gamesSum_textBox
            // 
            this.gamesSum_textBox.BackColor = System.Drawing.SystemColors.Window;
            this.gamesSum_textBox.Enabled = false;
            this.gamesSum_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gamesSum_textBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.gamesSum_textBox.Location = new System.Drawing.Point(282, 361);
            this.gamesSum_textBox.Name = "gamesSum_textBox";
            this.gamesSum_textBox.Size = new System.Drawing.Size(100, 24);
            this.gamesSum_textBox.TabIndex = 6;
            this.gamesSum_textBox.Text = "0";
            this.gamesSum_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 365);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Сумма заказа:";
            // 
            // cardNumber_textBox
            // 
            this.cardNumber_textBox.BackColor = System.Drawing.Color.DarkSlateGray;
            this.cardNumber_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cardNumber_textBox.ForeColor = System.Drawing.SystemColors.Window;
            this.cardNumber_textBox.Location = new System.Drawing.Point(65, 120);
            this.cardNumber_textBox.Mask = "0000 0000 0000 0000";
            this.cardNumber_textBox.Name = "cardNumber_textBox";
            this.cardNumber_textBox.Size = new System.Drawing.Size(287, 32);
            this.cardNumber_textBox.TabIndex = 1;
            this.cardNumber_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cvv_textBox
            // 
            this.cvv_textBox.BackColor = System.Drawing.Color.DarkSlateGray;
            this.cvv_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cvv_textBox.ForeColor = System.Drawing.SystemColors.Window;
            this.cvv_textBox.Location = new System.Drawing.Point(351, 234);
            this.cvv_textBox.Mask = "000";
            this.cvv_textBox.Name = "cvv_textBox";
            this.cvv_textBox.Size = new System.Drawing.Size(61, 23);
            this.cvv_textBox.TabIndex = 3;
            this.cvv_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cvv_textBox.ValidatingType = typeof(System.DateTime);
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
            this.order_buton.Location = new System.Drawing.Point(104, 407);
            this.order_buton.Name = "order_buton";
            this.order_buton.Size = new System.Drawing.Size(278, 50);
            this.order_buton.TabIndex = 5;
            this.order_buton.TextColor = System.Drawing.Color.DodgerBlue;
            this.order_buton.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.order_buton.Click += new System.EventHandler(this.order_buton_Click);
            // 
            // phone_textBox
            // 
            this.phone_textBox.BackColor = System.Drawing.Color.DarkSlateGray;
            this.phone_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phone_textBox.ForeColor = System.Drawing.SystemColors.Window;
            this.phone_textBox.Location = new System.Drawing.Point(104, 305);
            this.phone_textBox.Mask = "+70000000000";
            this.phone_textBox.Name = "phone_textBox";
            this.phone_textBox.Size = new System.Drawing.Size(278, 26);
            this.phone_textBox.TabIndex = 4;
            this.phone_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // card_dateTimePicker
            // 
            this.card_dateTimePicker.CalendarForeColor = System.Drawing.SystemColors.Window;
            this.card_dateTimePicker.CalendarMonthBackground = System.Drawing.Color.DarkSlateGray;
            this.card_dateTimePicker.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.card_dateTimePicker.CalendarTitleForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.card_dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.card_dateTimePicker.Location = new System.Drawing.Point(128, 170);
            this.card_dateTimePicker.Name = "card_dateTimePicker";
            this.card_dateTimePicker.Size = new System.Drawing.Size(200, 23);
            this.card_dateTimePicker.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Номер телефона";
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(483, 489);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.card_dateTimePicker);
            this.Controls.Add(this.order_buton);
            this.Controls.Add(this.cvv_textBox);
            this.Controls.Add(this.phone_textBox);
            this.Controls.Add(this.cardNumber_textBox);
            this.Controls.Add(this.gamesSum_textBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.xuiCard1);
            this.Controls.Add(this.xuiCard2);
            this.Name = "Order";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Order";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Order_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private XanderUI.XUICard xuiCard1;
        private XanderUI.XUICard xuiCard2;
        private System.Windows.Forms.TextBox gamesSum_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox cardNumber_textBox;
        private System.Windows.Forms.MaskedTextBox cvv_textBox;
        private XanderUI.XUIButton order_buton;
        private System.Windows.Forms.MaskedTextBox phone_textBox;
        private System.Windows.Forms.DateTimePicker card_dateTimePicker;
        private System.Windows.Forms.Label label2;
    }
}