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
    public partial class AdopterMainMenu : Form
    {
        public AdopterMainMenu()
        {
            InitializeComponent();
        }
        private void SearchByName_Click(object sender, EventArgs e)
        {
            List<Animal> animals = AnimalDbHelper.GetTable().Where(x => x.Name == name.Text).ToList();
            string text = animals.Aggregate("", (current, animal) => current + string.Format("Name: {0} Type: {1} Food Intake: {2}\n", animal.Name, animal.Type, animal.Food_Intake));
            Animals.Text = text;
        }

        private void SearchByType_Click(object sender, EventArgs e)
        {
            List<Animal> animals = AnimalDbHelper.GetTable().Where(x => x.Type == Type.Text).ToList();
            string text = animals.Aggregate("", (current, animal) => current + string.Format("Name: {0} Type: {1} Food Intake: {2}\n", animal.Name, animal.Type, animal.Food_Intake));
            Animals.Text = text;
        }

        private void GetAll_Click(object sender, EventArgs e)
        {
            List<Animal> animals = AnimalDbHelper.GetTable();
            string text = animals.Aggregate("", (current, animal) => current + string.Format("Name: {0} Type: {1} Food Intake: {2}\n", animal.Name, animal.Type, animal.Food_Intake));
            Animals.Text = text;
        }
    }
}
