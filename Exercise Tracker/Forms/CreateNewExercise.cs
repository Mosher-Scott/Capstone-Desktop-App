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


            //ClientDataForm.GetAllMuscleGroups();

            PopulateMuscleGroupDropdown();
            
        }

        private void PopulateMuscleGroupDropdown()
        {

            comboBoxMuscleGroups.DataSource = new BindingSource(MuscleGroup.muscleGroupDictionary, null);
            comboBoxMuscleGroups.DisplayMember = "Value";
            comboBoxMuscleGroups.ValueMember = "Key";
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string muscleGroupId = comboBoxMuscleGroups.SelectedValue.ToString();
            string instructions = textBoxInstructionInput.Text;
            string active = checkBoxActive.Checked.ToString() ;

            Exercise newExercise = new Exercise(name, muscleGroupId, instructions, active);

            int result = newExercise.InsertIntoDatabase();

            if (result < 0)
            {
                MessageBox.Show("");
            } else
            {
                MessageBox.Show($"Successfully inserted {name} into the system");
            }
            
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
