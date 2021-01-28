using Exercise_Tracker.Classes;
using NLog;
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
    public partial class RecordWorkout : Form
    {
        private int sessionId;
        private string sessionName;
        private int clientId;

        public static Logger logger = LogManager.GetCurrentClassLogger();

        // TODO: Create a "misc" training session, containing all the available exercises.  Use than then pick what they want
        public RecordWorkout(int id, string name, int clientIdSent)
        {
            InitializeComponent();
            //this.WindowState = FormWindowState.Maximized;
            //this.FormBorderStyle = FormBorderStyle.None;

            sessionId = id;
            sessionName = name;
            clientId = clientIdSent;

            labelSessionName.Text = sessionName;

            ClientData.GetDataFromDatabase("RecordWorkout", id);
            // ClientData.recordingExercisesTable = ClientData.sessionExercisesTable;
            dataGridViewExercises.DataSource = ClientData.recordingExercisesTable;

        }

        public RecordWorkout()
        {
            InitializeComponent();
            
        }
 

        private void RecordWorkout_Load(object sender, EventArgs e)
        {
            InitializeComponent();

        }

        private void buttonTest_Click(object sender, EventArgs e)
        {

        }

        private void closeWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSaveWorkout_Click(object sender, EventArgs e)
        {

            bool everythingIsGreat = CheckInputValues();

            if (!everythingIsGreat)
            {
                MessageBox.Show("You done messed up");
                return;
            }

            // Run query to insert new training sesion into the database (needs a new table). Requires user id/session id
            int workoutSessionId = WorkoutData.InsertSessionIntoDatabase(clientId, sessionId);

            // Check the value of the session ID to see it was inserted correctly
            if (workoutSessionId == -99)
            {
                MessageBox.Show("Sorry, there was an error saving your workout.  Please check the log");
                return;
            }

            // TODO: Need to handle errors
            foreach (DataRow row in ClientData.recordingExercisesTable.Rows)
            {
                int exerciseId = 0;
                int sets = 0;
                int reps = 0;
                int weight = 0;
                int time = 0;

                try
                {
                    exerciseId = Convert.ToInt32(row["ID"]);
                    sets = Convert.ToInt32(row["Sets"]);
                    reps = Convert.ToInt32(row["Reps"]);
                    weight = Convert.ToInt32(row["Weight"]);
                    time = Convert.ToInt32(row["Time"]);
                } catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                // Get the result of inserting the data into the client_workout_history_exercises table
                int insertValue = WorkoutData.InsertExerciseIntoHistory(workoutSessionId, exerciseId, sets, reps, weight, time);
                
                if (insertValue == -99)
                {
                    MessageBox.Show("Something went wrong inserting your exercises.  Please check the log");
                } else
                {
                    MessageBox.Show("Successfully saved workout information");
                    this.Close();
                }
            }
        }

        /// <summary>
        /// Checks the values the user inputted into the datatable, before the tool saves them
        /// </summary>
        /// <returns>True if all values are valid, false if values are invalid</returns>
        private bool CheckInputValues()
        {
            bool everythingGood = true;

            // TODO: Use that training session id, and insert the data below
            foreach (DataRow row in ClientData.recordingExercisesTable.Rows)
            {
                int exerciseId;
                int sets;
                int reps;
                int weight;
                int time;

                try
                {
                    exerciseId = Convert.ToInt32(row["ID"]);
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"ID Must be a number");
                    logger.Error(ex.Message);
                    everythingGood = false;
                }

                try
                {
                    sets = Convert.ToInt32(row["Sets"]);

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Sets Must be a number, and not empty");
                    everythingGood = false;
                    logger.Error(ex.Message);
                }

                try
                {
                    reps = Convert.ToInt32(row["Reps"]);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Reps Must be a number, and not empty");
                    everythingGood = false;
                    logger.Error(ex.Message);
                }

                try
                {
                    weight = Convert.ToInt32(row["Weight"]);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Weight Must be a number, and not empty");
                    everythingGood = false;
                    logger.Error(ex.Message);
                }

                try
                {
                    time = Convert.ToInt32(row["time"]);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Time Must be a number, and not empty");
                    everythingGood = false;
                    logger.Error(ex.Message);
                }
            } // End of foreach

            return everythingGood;

        }


    } // End of class
}
