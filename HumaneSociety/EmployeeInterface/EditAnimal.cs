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
    public partial class EditAnimalMenu : Form
    {
        private Animal animal;
        public EditAnimalMenu()
        {
            InitializeComponent();
            Room.Maximum = 20;
            Room.Minimum = 1;
            animal = new Animal();

        }

        public EditAnimalMenu(Animal animal)
        {
            InitializeComponent();
            Room.Maximum = 20;
            Room.Minimum = 1;
            this.animal = animal;
            PopulateFields();
        }

        private void PopulateFields()
        {
            name.Text = animal.Name;
            if (animal.Room != null) Room.Value = (int) animal.Room;
            if (animal.Has_Shot != null) Shot.Checked = (bool) animal.Has_Shot;
            Type.Text = animal.Type;
            Color.Text = animal.Color;
            FoodIntake.Text = animal.Food_Intake.ToString();
            if (animal.Adoption_Status != null) Adopted.Checked = (bool) animal.Adoption_Status;
        }

        private void AddAnimal_Click(object sender, EventArgs e)
        {
            animal.Name = name.Text;
            animal.Type = Type.Text;
            animal.Room = (byte) Room.Value;
            animal.Has_Shot = Shot.Checked;
            animal.Color = Color.Text;
            Double f;
            if (Double.TryParse(FoodIntake.Text, out f))
            {
                animal.Food_Intake = f;
            }
            else
            {
                MessageBox.Show("Invalid Food Intake!");
                return;
            }
            animal.Adoption_Status = Adopted.Checked;

            if(AnimalDbHelper.UpdateAnimal(animal)) this.Close();
            else MessageBox.Show("There was a failure adding the animal, possibly due to an invalid animal id.");
        }

        private void NewAnimalMenu_Load(object sender, EventArgs e)
        {

        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void Age_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}