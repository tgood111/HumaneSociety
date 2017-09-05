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
    public partial class NewAnimalMenu : Form
    {
        public NewAnimalMenu()
        {
            InitializeComponent();
            Room.Maximum = 20;
            Room.Minimum = 1;
        }

        private void AddAnimal_Click(object sender, EventArgs e)
        {
            Animal a = new Animal();
            a.Name = name.Text;
            a.Type = Type.Text;
            a.Room = (byte) Room.Value;
            a.Has_Shot = Shot.Checked;
            a.Color = Color.Text;
            Double f;
            if (Double.TryParse(FoodIntake.Text, out f))
            {
                a.Food_Intake = f;
            }
            else
            {
                MessageBox.Show("Invalid Food Intake!");
                return;
            }
            a.Adoption_Status = false;

            AnimalDbHelper.AddAnimal(a);
            this.Close();
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