using Exercise_Tracker.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_Tracker.Forms
{
    public partial class FormStartingMenu : Form
    {
        public FormStartingMenu()
        {
            InitializeComponent();

            // For testing
            //Workout.GetWorkoutHistoryForClient(1);

            Thread muscleGroups = new Thread(() => MuscleGroup.GetMusclegroups());
            Thread exercises = new Thread(() => Exercise.GetExercises());
            Thread clients = new Thread(() => Client.GetClients());
            Thread trainingSessions = new Thread(() => TrainingSession.GetAllTrainingSessions());

            exercises.Start();
            muscleGroups.Start();
            clients.Start();
            trainingSessions.Start();

            exercises.Join();
            muscleGroups.Join();
            clients.Join();
            trainingSessions.Join();

            buttonClientManagement.Enabled = true;
            buttonClientManagement.BackColor = Color.Bisque;
            buttonClientManagement.Enabled = true;
            buttonExerciseManagement.BackColor = Color.Bisque;
            buttonExerciseManagement.Enabled = true;
            buttonSessionManagement.Enabled = true;
            buttonSessionManagement.BackColor = Color.Bisque;

        }

        private void buttonViewClients_Click(object sender, EventArgs e)
        {
            test form = new test();
            form.Show();
        }

        private void buttonSessionManagement_Click(object sender, EventArgs e)
        {
            TrainingSessionManagement form = new TrainingSessionManagement();
            form.Show();
        }

        private void buttonClientManagement_Click(object sender, EventArgs e)
        {
            ClientManagement form = new ClientManagement();
            form.Show();
        }

        private void buttonExerciseManagement_Click(object sender, EventArgs e)
        {
            ExerciseManagement form = new ExerciseManagement();

            form.Show();
        }
    }
}
