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
    public partial class EditAnimal : Form
    {
        public EditAnimal()
        {
            InitializeComponent();
            Room.Maximum = 20;
            Room.Minimum = 1;
        }
    }
}
