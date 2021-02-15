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
    public partial class ExerciseManagement : Form
    {
        public ExerciseManagement()
        {
            InitializeComponent();
            PopulateDropdownMenu();
        }

        private void PopulateDropdownMenu()
        {
            comboBoxExercises.DataSource = new BindingSource(Exercise.exerciseListForDropdown, null);
            comboBoxExercises.DisplayMember = "Value";
            comboBoxExercises.ValueMember = "Key";
        }

        private void buttonAddNewExercise_Click(object sender, EventArgs e)
        {
            CreateNewExercise form = new CreateNewExercise();
            form.Show();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAddNew_Click(object sender, EventArgs e)
        {
            CreateNewExercise form = new CreateNewExercise();

            form.Show();
        }

        private void buttonEditExercise_Click(object sender, EventArgs e)
        {
            int exerciseId = 1;
            EditExercise form = new EditExercise(exerciseId);
        }

        private void ExerciseDropdown_Changed(object sender, EventArgs e)
        {
            int exerciseId;
            try
            {
                exerciseId = Convert.ToInt32(comboBoxExercises.SelectedValue);
            } catch 
            {
                exerciseId = 0;
            }

            Exercise.GetSingleExercise(exerciseId);

            // TODO: Debug why the exercise isn't showing up
            dataGridViewExercises.DataSource = Exercise.singleExerciseList;

        }



    } // End of class
}
