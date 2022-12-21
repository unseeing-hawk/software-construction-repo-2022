using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_scientificLibrary.login
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
    }
}
