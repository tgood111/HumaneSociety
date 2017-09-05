using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HumaneSociety.EmployeeInterface
{
    public partial class EmployeeMainMenu : Form
    {
        public EmployeeMainMenu()
        {
            InitializeComponent();
        }

        private void NewAnimal_Click_1(object sender, EventArgs e)
        {
            new NewAnimalMenu().Show();
        }

        private void ImportAnimal_Click(object sender, EventArgs e)
        {

        }

        private void EditAnimal_Click(object sender, EventArgs e)
        {

        }

        private void AdoptAnimal_Click(object sender, EventArgs e)
        {

        }
    }
}
