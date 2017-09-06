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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            List<Adopter> adopters = AdopterDbHelper.GetTable();

            try
            {
                Adopter adopter = adopters.First(x => x.Adopter_Phone_Number == Number.Text);
                new AdopterMainMenu().Show();
                Close();
            }
            catch
            {
                MessageBox.Show("Invalid Credentials!");
                return;
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
