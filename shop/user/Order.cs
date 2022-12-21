using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shop.user
{
    public partial class Order : Form
    {
        int idUser;
        int[] gamesId;
        Form parentForm;

        public Order(Form parentForm, int orderSum, int[] gamesId, int idUser)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            this.gamesId = gamesId;
            this.idUser = idUser;

            gamesSum_textBox.Text = orderSum.ToString();
        }

        private void Order_FormClosing(object sender, FormClosingEventArgs e)
        {
            parentForm.Enabled = true;
        }

        private void order_buton_Click(object sender, EventArgs e)
        {
            try
            {
                string trimmedCardNumber = String.Concat(cardNumber_textBox.Text.Where(c => !Char.IsWhiteSpace(c)));
                sql.Bank.buyGame(phone_textBox.Text,
                                 trimmedCardNumber,
                                 DateTime.Parse(card_dateTimePicker.Text).ToString(),
                                 int.Parse(cvv_textBox.Text),
                                 int.Parse(gamesSum_textBox.Text));
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK);
                return;
            }

            try
            {
                foreach (int i in gamesId)
                {
                    sql.Games.addUserGame(idUser, i);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK);
            }

            MessageBox.Show("Оплата прошла успешно, игры добавлены в библиотеку", 
                            "", MessageBoxButtons.OK);
            Close();
        }
    }
}
