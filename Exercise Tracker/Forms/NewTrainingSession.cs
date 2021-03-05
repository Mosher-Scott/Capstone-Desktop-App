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
    public partial class NewTrainingSession : Form
    {

        public static Logger logger = LogManager.GetCurrentClassLogger();

        public NewTrainingSession()
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

            // Save user entered values as a new trainingSession
            string name = textBoxName.Text;
            string description = textBoxDescription.Text;
            string sets = textBoxTrainingSessionSets.Text;
            string reps = textBoxTrainingSessionReps.Text;
            string active = checkBoxActive.Checked.ToString();

            TrainingSession newSession = new TrainingSession(name, description, sets, reps, active);

            // Convert the object to JSON
            string jsonSession = JsonConvert.SerializeObject(newSession);

            // Insert it into the database. Get the ID back from the tool
            var response = AddTrainingSessionTodatabase(jsonSession);

            if(response.Contains("Successfully added new training session"))
            {
                dynamic trainingSessionResponse = JObject.Parse(response);

                logger.Info("Response: " + trainingSessionResponse);

                var newSessionId = trainingSessionResponse.trainingSessionId;

                logger.Info(newSessionId);

                //// Convert the training sessions

                string exercisesInTrainingSession = JsonConvert.SerializeObject(Exercise.exercisesForTrainingSession);

                logger.Info("New exercises");
                logger.Info(exercisesInTrainingSession);

                APIRequests request = new APIRequests();

                bool exerciseErrors = false;

                foreach (var exercise in Exercise.exercisesForTrainingSession)
                {
                    string exerciseId = exercise.exercise_id;

                    string url = $"{request.singleTrainingSessionEndpoint}{newSessionId}/exercise/{exerciseId}";
                    logger.Info("Exercise ID: " + exerciseId);

                   string exerciseResponse = request.SendPostRequestData(url);

                    if (!exerciseResponse.Contains("Successfully"))
                    {
                        exerciseErrors = true;
                        logger.Error(exerciseResponse);
                    }
                }

                if(exerciseErrors)
                {
                    MessageBox.Show("There were errors inserting the exercises.  Please check the log files");
                } else
                {
                    TrainingSession.GetAllTrainingSessions();

                    MessageBox.Show("Successfully created the new training session");
                    this.Close();
                }
            }


        }

        private void SaveExercisesToList()
        {
            //foreach (DataGridViewRow item in this.dataGridViewAssignedExercises.SelectedRows)
            //{
            ////TODO: Be able to select the session to remove it
            //    string workoutIdFromGrid = Convert.ToString(item.Cells[0].Value);

            //    workoutId = Convert.ToInt32(workoutIdFromGrid);
            //}
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
            // Get exercise id from the dropdown
            int exerciseId = GetExerciseIdFromDropdown();

            for (int i = 0; i < Exercise.exerciseList.Count; i++)
            {
                if (Exercise.exerciseList[i].exercise_id == exerciseId.ToString())
                {
                    Exercise.exercisesForTrainingSession.Add(Exercise.exerciseList[i]);
                }

            }

            dataGridViewAssignedExercises.DataSource = "";
            dataGridViewAssignedExercises.DataSource = Exercise.exercisesForTrainingSession;


            // Search the exercise list for those exercises

            // Create a new TrainingSessionExercise

            // Add new exercise to TrainingSessionExercises.trainingSessionExerciseList 

            // Refresh the datagridview each time an exercise is added
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
    }
}
