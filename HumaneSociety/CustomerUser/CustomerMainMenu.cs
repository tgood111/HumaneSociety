using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HumaneSociety.CustomerUser
{
    public partial class CustomerMainMenu : Form
    {
        public CustomerMainMenu()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
        }

        private void Register_Click(object sender, EventArgs e)
        {
            new RegistrationForm().Show();
        }
    }
}
