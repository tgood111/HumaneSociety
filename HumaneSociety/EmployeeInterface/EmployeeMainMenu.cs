using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            new EditAnimal().Show();
        }

        int parse(string number)
        {
            int a;
            Int32.TryParse(number, out a);
            return a;
        }

        private void ImportAnimal_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            string path = "";
            if (file.ShowDialog() == DialogResult.OK)
            {
                path = file.FileName;
                var data = File.ReadAllLines(path)
                        .Skip(1)
                        .Select(columns => columns.Split(','))
                        .Select(columns => new 
                        {
                            Name = columns[0],
                            Type = columns[1],
                            Room = (byte)parse(columns[2]),
                            Color = columns[3],
                            Has_Shot = (columns[4] == "T"),
                            Food_Intake = parse(columns[5]),
                            Adoption_Status = false
                        });

                List<Animal> animals = new List<Animal>();
                foreach (var line in data)
                {
                    Animal animal = new Animal();
                    animal.Name = line.Name;
                    animal.Type = line.Type;
                    animal.Food_Intake = line.Food_Intake;
                    animal.Room = line.Room;
                    animal.Color = line.Color;
                    animal.Has_Shot = line.Has_Shot;
                    animal.Adoption_Status = line.Adoption_Status;
                    animals.Add(animal);
                }
                if(AnimalDbHelper.AddAnimals(animals)) MessageBox.Show("Success!");
                return;
            }
            MessageBox.Show("Not a good file");
            return;
        }

        private void EditAnimal_Click(object sender, EventArgs e)
        {
            new SearchForAnimal().Show();
        }

        private void AdoptAnimal_Click(object sender, EventArgs e)
        {

        }
    }
}
