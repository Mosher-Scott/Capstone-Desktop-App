using Exercise_Tracker.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_Tracker.Forms
{
    public partial class CreateNewExercise : Form
    {
        public CreateNewExercise()
        {
            InitializeComponent();

            ClientData.GetAllMuslceGroups();

            PopulateMuscleGroupDropdown();
        }

        private void PopulateMuscleGroupDropdown()
        {
            comboBoxMuscleGroups.DataSource = new BindingSource(ClientData.muscleGroups, null);
            comboBoxMuscleGroups.DisplayMember = "Value";
            comboBoxMuscleGroups.ValueMember = "Key";
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            int id = Convert.ToInt32(comboBoxMuscleGroups.SelectedValue);
            string instructions = textBoxInstructionInput.Text;

            Exercise newExercise = new Exercise(name, id, instructions);

            int result = newExercise.InsertIntoDatabase();

            if (result < 0)
            {
                MessageBox.Show("");
            } else
            {
                MessageBox.Show($"Successfully inserted {name} into the system");
            }
            
        }
    }
}
