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
using RestSharp;
using System.Text.Json;
using Newtonsoft.Json.Linq;

namespace Exercise_Tracker.Forms
{
    public partial class ModifyTrainingSession : Form
    {

        public static Logger logger = LogManager.GetCurrentClassLogger();

        public static List<TrainingSessionExercise> originalExercises = new List<TrainingSessionExercise>();

        int trainingSessionid;

        /// <summary>
        /// exerciseId, sessionId
        /// </summary>
        public Dictionary<int, int> exercisesToAdd = new Dictionary<int, int>();

        /// <summary>
        /// exerciseId, sessionId
        /// </summary>
        public Dictionary<int, int> exercisesToremove = new Dictionary<int, int>();

        public ModifyTrainingSession(string sessionId, string name, string description, string sets, string reps, bool active)
        {
            InitializeComponent();
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;

            PopulateDropdownMenu();

            trainingSessionid = Convert.ToInt32(sessionId);

            textBoxSessionId.Text = sessionId;
            textBoxName.Text = name;
            textBoxDescription.Text = description;
            textBoxTrainingSessionSets.Text = sets;
            textBoxTrainingSessionReps.Text = reps;
            checkBoxActive.Checked = active;

            SetOriginalExercisesList();

            dataGridViewAssignedExercises.DataSource = TrainingSessionExercise.trainingSessionExerciseList;
        }

        /// <summary>
        /// Sets values for the original exercise list.  Will be used to compare the current list of exercises, and the original list before it was modified
        /// </summary>
        private void SetOriginalExercisesList()
        {
            foreach(var exercise in TrainingSessionExercise.trainingSessionExerciseList)
            {
                originalExercises.Add(exercise);
            }
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

        /// <summary>
        /// Deleting a specific row in the datatable the user has selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDeleteRow_Click(object sender, EventArgs e)
        {
            bool found = false;
            foreach (DataGridViewRow item in this.dataGridViewAssignedExercises.SelectedRows)
            {
                // TODO: Be able to select the session to remove it
                string exerciseId = Convert.ToString(item.Cells[0].Value);
                //MessageBox.Show(exerciseId);

                foreach (var exercise in TrainingSessionExercise.trainingSessionExerciseList.ToList())
                {
                    if (exerciseId == exercise.id)
                    {
                        TrainingSessionExercise.trainingSessionExerciseList.Remove(exercise);
                        found = true;
                        break;
                    }
                }
                if (found == true)
                {
                    dataGridViewAssignedExercises.DataSource = null;
                    dataGridViewAssignedExercises.DataSource = TrainingSessionExercise.trainingSessionExerciseList;
                    break;
                }

                

            }
        }

        /// <summary>
        /// This is called when the user wants to save their changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSave_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string description = textBoxDescription.Text;
            string sets = textBoxTrainingSessionSets.Text;
            string reps = textBoxTrainingSessionReps.Text;
            string active = checkBoxActive.Checked.ToString();

            TrainingSession newSession = new TrainingSession(name, description, sets, reps, active);

            // Convert the object to JSON
            string jsonSession = JsonConvert.SerializeObject(newSession);

            //TODO: Finish up modifying the training session.  Make sure the methods are created first
            // Run patch method on the training session
            //var response = (jsonSession);

            // Check for new exercises

            // Foreach, send patch request

            // Check for removed exericses

            // Foreach, send delete request

            

        }

        /// <summary>
        /// Checks if a training session in originalTrainingSessions exists in the TrainingSessionExercise.trainingSessionExerciseList.  If it doesn't then it needs to be removed
        /// </summary>
        private void CheckForDeletedSessions()
        {

            // Check each item in the original training session list
            for (int i = 0; i < originalExercises.Count; i++)
            {
                var originalId = originalExercises[i].id;

                bool needsToBeDeleted = true;

                for (int j = 0; j < TrainingSessionExercise.trainingSessionExerciseList.Count; j++)
                {
                    //var currentList = TrainingSessionExercise.trainingSessionExerciseList[j].id;

                    // If there is a match, break out of this for loop
                    if (originalExercises[i].id == TrainingSessionExercise.trainingSessionExerciseList[j].id)
                    {
                        needsToBeDeleted = false;
                        break;
                    }
                }

                // If a session isn't in the original list, then add it to the list of exercises to remove
                if (needsToBeDeleted)
                {
                    // exerciseId, sessionId
                    exercisesToremove.Add(Convert.ToInt32(originalId), trainingSessionid);
                }
            } // End of for loop
        }

        /// <summary>
        /// Checks if a given training session exists in the originalTrainingSessions list.  If not, add it to trainingSessionsToAdd
        /// </summary>
        private void CheckForNewSessions()
        {
            // Loop through the current list of assigned training sessions to see if we need to add or remove any
            for (int i = 0; i < TrainingSessionExercise.trainingSessionExerciseList.Count; i++)
            {
                // a flag for whether the session needs to be added or not.  By default, no
                bool newSessionAdded = true;

                string listExerciseId = TrainingSessionExercise.trainingSessionExerciseList[i].id;

                // For each session in listOfTrainingSessions, see if exists in the original one
                for (int j = 0; j < originalExercises.Count; j++)
                {
                    string originalExerciseId = originalExercises[j].id;

                    // If it exists in current list and the new list, don't do anything
                    if (TrainingSession.listOfTrainingSessions[i].sessionId == originalExercises[j].id)
                    {
                        newSessionAdded = false;
                        continue;
                    }
                    // If the session isn't found in the original array, then it is new and newSessionAdd stays as true
                }

                // Now add the new session to the list
                if (newSessionAdded)
                {
                    exercisesToAdd.Add(Convert.ToInt32(listExerciseId), trainingSessionid);
                }
            } // End of main for loop for adding sessions

        }

        private string AddTrainingSessionTodatabase(string session)
        {
            APIRequests request = new APIRequests();

            string url = request.allTrainingSessionsEndpoint;

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
            // TODO: Need to convert from Exercise to TrainingSessionExercise
            // Get exercise id from the dropdown
            int exerciseId = GetExerciseIdFromDropdown();

            for (int i = 0; i < Exercise.exerciseList.Count; i++)
            {
                if (Exercise.exerciseList[i].exercise_id == exerciseId.ToString())
                {
                    var idToAdd = Exercise.exerciseList[i].exercise_id;
                    var name = Exercise.exerciseList[i].name;
                    var description = Exercise.exerciseList[i].instruction;
                    var muscleGroupName = Exercise.exerciseList[i].muscle_group_name;

                    TrainingSessionExercise exercise = new TrainingSessionExercise(idToAdd, name, description, muscleGroupName);
                    // ADd to the list

                    TrainingSessionExercise.trainingSessionExerciseList.Add(exercise);
                }

            }

            dataGridViewAssignedExercises.DataSource = "";
            dataGridViewAssignedExercises.DataSource = TrainingSessionExercise.trainingSessionExerciseList;


            // Search the exercise list for those exercises

            // Create a new TrainingSessionExercise

            // Add new exercise to TrainingSessionExercises.trainingSessionExerciseList 

            // Refresh the datagridview each time an exercise is added
        }

        private void closeFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
