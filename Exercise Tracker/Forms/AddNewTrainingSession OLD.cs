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
    public partial class AddNewTrainingSession : Form
    {

        public static Logger logger = LogManager.GetCurrentClassLogger();

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

        // For each exericise add it to the database
        private void buttonSave_Click(object sender, EventArgs e)
        {
            // TODO: This

            // Save user entered values as a new trainingSession
            string name = textBoxName.Text;
            string description = textBoxDescription.Text;
            string sets = textBoxTrainingSessionSets.Text;
            string reps = textBoxTrainingSessionReps.Text;
            string active = checkBoxActive.Checked.ToString();

            TrainingSession newSession = new TrainingSession(name, description, sets, reps, active);

            // Convert the object to JSON
            string jsonSession = JsonConvert.SerializeObject(newSession);

            logger.Info(jsonSession);
            // Insert it into the database
            string sessionId = AddTrainingSessionTodatabase(jsonSession);

            MessageBox.Show(sessionId);

            // Get the ID back from the tool
            // Returning JSON should contain trainingSessionId: VALUE

            // For each exercise in trainingsesisonexercise
            // Get exercise id and trainingsession ID
            // Sent POST request to api endpoint
            // Handle response for each request 
        }

        private string AddTrainingSessionTodatabase(string session)
        {
            APIRequests request = new APIRequests();

            string url = request.singleClientDetailEndpoint;

            string response = request.SendPOSTRequestDataInBody(url, session);

            return response;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Adds a new exercise to the training session list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddExercise_Click(object sender, EventArgs e)
        {
            // Clear TrainingSessionExercises.trainingSessionExerciseList

            // Get exercise id from the dropdown

            // Search the exercise list for those exercises

            // Create a new TrainingSessionExercise

            // Add new exercise to TrainingSessionExercises.trainingSessionExerciseList 

            // Refresh the datagridview each time an exercise is added
        }
    }
}
