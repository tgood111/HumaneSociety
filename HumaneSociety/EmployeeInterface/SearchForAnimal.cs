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
    public partial class SearchForAnimal : Form
    {
        public SearchForAnimal()
        {
            InitializeComponent();
            Room.Maximum = 20;
            Room.Minimum = 1;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            List<Animal> animals = AnimalDbHelper.GetTable();
            Animal animal = animals.First(x => x.Room == (byte) Room.Value && x.Name == name.Text &&
                                                   x.Type == Type.Text);
            if (animal != null)
            {
                new EditAnimalMenu(animal).Show();
                Close();
            }
            else
            {
                MessageBox.Show("No animal found!");
                return;
            }
        }
    }
}