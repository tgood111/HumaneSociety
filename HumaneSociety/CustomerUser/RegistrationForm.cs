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
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void Register_Click(object sender, EventArgs e)
        {
            Adopter adopter = new Adopter();
            adopter.Adopter_Name = name.Text;
            adopter.Adopter_Address = Address.Text;
            adopter.Adopter_Phone_Number = Number.Text;
            adopter.Adopter_Age = (byte) Age.Value;
            adopter.Adopter_Description = Description.Text;
            AdopterDbHelper.AddAdopter(adopter);
            //Spawn the new main menu?
            Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
