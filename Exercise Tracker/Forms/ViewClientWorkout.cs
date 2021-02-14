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
using NLog;
using Newtonsoft.Json;

namespace Exercise_Tracker.Forms
{
    public partial class ViewClientWorkout : Form
    {

        public static Logger logger = LogManager.GetCurrentClassLogger();

        public ViewClientWorkout(int clientId, int workoutId)
        {
            InitializeComponent();

            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;

            GetWorkoutInformation(workoutId);

            dataGridViewExercises.DataSource = WorkoutHistoryExercises.exercises;

        }

        public void GetWorkoutInformation(int id)
        {
            APIRequests request = new APIRequests();

            string url = $"{request.getSpecificWorkoutHistoryItem}{id}";

            var response = request.GetRequests(url);

            //logger.Info(response);

            ParseWebResponse(response);
        }

        /// <summary>
        /// Parses the data received from the API endpoints
        /// </summary>
        /// <param name="response">JSON data from the website</param>
        public void ParseWebResponse(string response)
        {
            dynamic workoutDetails = JsonConvert.DeserializeObject(response);
            var data = "";

            try
            {
                data = workoutDetails["data"].ToString();
            } catch { 
                
            }
          
            if(workoutDetails is null || data == "No workout history found for client")
            {
                MessageBox.Show("No information found for workout history");
                return;
            } else
            {
                foreach(var item in workoutDetails)
                {
                    string workoutId = item["id"].ToString();
                    string workoutName = item["sessionname"].ToString();
                    string workoutDescription = item["sessiondescription"].ToString();
                    string workoutDate = item["sessiondate"].ToString();

                    WorkoutHistory workout = new WorkoutHistory(workoutId, workoutName, workoutDescription, workoutDate);
                    
                    foreach(var exercise in item["workout_details"])
                    {
                        string exerciseName = exercise["exercise_name"].ToString();
                        string exerciseSets = exercise["exercise_sets"].ToString();
                        string exerciseReps = exercise["exercise_reps"].ToString();
                        string exerciseWeight = exercise["exercise_weight"].ToString();
                        string exerciseSeconds = exercise["exercise_seconds"].ToString();

                        WorkoutHistoryExercises exerciseDone = new WorkoutHistoryExercises(exerciseName, exerciseSets, exerciseReps, exerciseWeight, exerciseSeconds);

                        WorkoutHistoryExercises.exercises.Add(exerciseDone);
                    }

                    SetWorkoutInfo(workoutId, workoutName, workoutDescription, workoutDate);
                }
            }
        }

        private void SetWorkoutInfo(string id, string name, string description, string date)
        {
            textBoxId.Text = id;
            textBoxName.Text = name;
            textBoxDescription.Text = description;
            textBoxDate.Text = date;

        }

        /// <summary>
        /// Close the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void closeFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
