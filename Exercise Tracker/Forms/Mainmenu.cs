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

            // Run a test to see if the server is responsive

            GetInformation();
            

            // TODO: Add text to the form so if no clients, sessions, or anything was retrieved from the API you'd know

        }

        private void GetInformation()
        {
            APIRequests request = new APIRequests();

            var url = request.allMuscleGroupsEndpoint;

            var response = request.GetRequests(url);

            if (response == "")
            {
                MessageBox.Show("Sorry, can't connect to server");
            } else
            {
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
                buttonClientManagement.BackColor = Color.LightGreen;
                buttonClientManagement.Enabled = true;
                buttonExerciseManagement.BackColor = Color.LightGreen;
                buttonExerciseManagement.Enabled = true;
                buttonSessionManagement.Enabled = true;
                buttonSessionManagement.BackColor = Color.LightGreen;
                buttonMuscleGroup.Enabled = true;
                buttonMuscleGroup.BackColor = Color.LightGreen;
            }


           
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

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonMuscleGroup_Click(object sender, EventArgs e)
        {
            MuscleGroupManagement form = new MuscleGroupManagement();

            form.Show();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            GetInformation();
        }
    }
}
