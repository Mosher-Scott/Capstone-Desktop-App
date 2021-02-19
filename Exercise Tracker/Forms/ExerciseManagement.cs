using Exercise_Tracker.Classes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NLog;

namespace Exercise_Tracker.Forms
{
    public partial class ExerciseManagement : Form
    {
        public static Logger logger = LogManager.GetCurrentClassLogger();

        public ExerciseManagement()
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

        private int GetExericseIdFromDropdown()
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
        /// When the user wants to edit an exercise fill out the details in the form below it
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEditExercise_Click(object sender, EventArgs e)
        {
            int exerciseId = GetExericseIdFromDropdown();

            comboBoxMuscleGroups.DataSource = new BindingSource(MuscleGroup.muscleGroupDictionary, null);
            comboBoxMuscleGroups.DisplayMember = "Value";
            comboBoxMuscleGroups.ValueMember = "Key";
            comboBoxMuscleGroups.SelectedValue = Exercise.singleExerciseList[0].muscle_group_name;
            comboBoxMuscleGroups.SelectedIndex = Convert.ToInt32(Exercise.singleExerciseList[0].musclegroup);

            if (Exercise.singleExerciseList[0].active == "True")
            {
                checkBoxActive.Checked = true;
            }

            textBoxName.Text = Exercise.singleExerciseList[0].name;
            textBoxInstructionInput.Text = Exercise.singleExerciseList[0].instruction;
            
        }

        /// <summary>
        /// When the user picks a new exercise from the dropdown menu, update the data in the grid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExerciseDropdown_Changed(object sender, EventArgs e)
        {
            int exerciseId = GetExericseIdFromDropdown();

            Exercise.GetSingleExercise(exerciseId);

            var count = Exercise.singleExerciseList.Count;

            if (count == 0)
            {

            } else
            {
                dataGridViewExercises.DataSource = "";
                dataGridViewExercises.DataSource = Exercise.singleExerciseList;
            }
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void buttonSaveEdits_Click(object sender, EventArgs e)
        {
            string exerciseId = Exercise.singleExerciseList[0].exercise_id;
            string exerciseName = textBoxName.Text;
            string muscleGroupId = (string)comboBoxMuscleGroups.SelectedValue;
            string exerciseInstructions = textBoxInstructionInput.Text;
            string active = checkBoxActive.Checked.ToString();

            Exercise exercise = new Exercise(exerciseId, exerciseName, muscleGroupId, exerciseInstructions, active);

            string editedExercise = JsonConvert.SerializeObject(exercise);

            logger.Info(editedExercise);

            SendPatchExerciseRequest(editedExercise, exerciseId);

            // TODO: Clear text boxes and other variables once the request is completed successfully
        }

        /// <summary>
        /// Sending the patch request to the server for editing an exercise
        /// </summary>
        /// <param name="exercise"></param>
        /// <param name="exerciseId"></param>
        private void SendPatchExerciseRequest(string exercise, string exerciseId) {

            APIRequests request = new APIRequests();

            string url = $"{request.singleExercisesEndpoint}{exerciseId}";

            string response = request.SendPatchRequestDataInBody(url, exercise);

            // TODO: Change this to show either a generic success or error message
            MessageBox.Show(response);
        }

        private void buttonDeleteExercise_Click(object sender, EventArgs e)
        {
            MarkExericiseAsInactive();
        }

        private void MarkExericiseAsInactive()
        {
            int exerciseId = GetExericseIdFromDropdown();

            if (exerciseId == 0)
            {
                MessageBox.Show("Please pick an exercise from the dropdown");
            } else
            {
                APIRequests request = new APIRequests();

                string url = $"{request.singleExercisesEndpoint}{exerciseId}";

                string response = request.SendDeleteRequestData(url);

                if(response.Contains("Successfully marked the exercise inactive"))
                {
                    MessageBox.Show("Successfully marked the exercise inactive");

                    // Now clear the table
                    dataGridViewExercises.DataSource = "";

                    // Refresh the dropdown
                    Exercise.GetExercises();

                    PopulateDropdownMenu();

                } else
                {
                    MessageBox.Show("Sorry, couldn't mark the exercise as inactive");
                }
            }
        }

        private void closeFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    } // End of class
}
