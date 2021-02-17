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
    public partial class AddNewTrainingSession : Form
    {
        public AddNewTrainingSession()
        {
            InitializeComponent();
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;

            PopulateDropdownMenu(); 
        }

        private void PopulateDropdownMenu()
        {
            comboBoxExercises.DataSource = new BindingSource(Exercise.exerciseListForDropdown, null);
            comboBoxExercises.DisplayMember = "Value";
            comboBoxExercises.ValueMember = "Key";
        }

        /// <summary>
        /// Gets the exercise ID from the drop down
        /// </summary>
        /// <returns></returns>
        private int GetExerciseIdFromDropdown()
        {
            int exerciseId;
            try
            {
                exerciseId = Convert.ToInt32(comboBoxExercises.SelectedValue);
            }
            catch
            {
                exerciseId = 0;
            }

            return exerciseId;
        }

        /// <summary>
        /// When the user picks a new exercise from the dropdown menu, update the data in the grid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExerciseDropdown_Changed(object sender, EventArgs e)
        {
            int exerciseId = GetExerciseIdFromDropdown();

            Exercise.GetSingleExercise(exerciseId);

            var count = Exercise.singleExerciseList.Count;

            if (count == 0)
            {

            }
            else
            {
                dataGridViewExerciseList.DataSource = "";
                dataGridViewExerciseList.DataSource = Exercise.singleExerciseList;
            }
        }



        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void closeFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            // TODO: This
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
