using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shop.login
{
    public partial class WelcomeWindow : Form
    {
        public WelcomeWindow()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            LoginWindow login = new LoginWindow();
            Hide();
            login.ShowDialog();
            Close();
        }

        private void registrationButton_Click(object sender, EventArgs e)
        {
            RegistrationWindow login = new RegistrationWindow();
            Hide();
            login.ShowDialog();
            Close();
        }

        public static void exitOnWelcomWindow(System.Windows.Forms.Form form)
        {
            if (MessageBox.Show("Вы уверены, что хотите выйти?", "Предупреждение", MessageBoxButtons.YesNo) ==
                DialogResult.Yes)
            {
                login.WelcomeWindow welcome = new login.WelcomeWindow();
                form.Hide();
                welcome.ShowDialog();
                form.Close();
            }
        }
    }
}
