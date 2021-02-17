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
    public partial class TrainingSessionManagement : Form
    {
        public TrainingSessionManagement()
        {
            InitializeComponent();

            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;

            TrainingSession.GetAllTrainingSessions();

            PopulateDropdownMenu();

        }

        private void PopulateDropdownMenu()
        {
            comboBoxTrainingSessions.DataSource = new BindingSource(TrainingSession.trainingSessionDictionaryForDropdown, null);
            comboBoxTrainingSessions.DisplayMember = "Value";
            comboBoxTrainingSessions.ValueMember = "Key";
        }

        private void SessionSelected_changed(object sender, EventArgs e)
        {
            GetSessionInformation();
        }

        private void GetSessionInformation()
        {
            int sessionId;

            try
            {
                sessionId = Convert.ToInt32(comboBoxTrainingSessions.SelectedValue);
            } catch
            {
                sessionId = 0;
            }

            if (sessionId != 0)
            {
                // Loop through all sessions and find the details that match
                for(int i = 0; i < TrainingSession.listOfAllTrainingSessions.Count; i++)
                {
                    if(TrainingSession.listOfAllTrainingSessions[i].sessionId == sessionId.ToString())
                    {
                        textBoxSessionId.Text = TrainingSession.listOfAllTrainingSessions[i].sessionId;
                        textBoxSessionName.Text = TrainingSession.listOfAllTrainingSessions[i].sessionName;
                        textBoxSessionDescription.Text = TrainingSession.listOfAllTrainingSessions[i].sessionDescription;
                        textBoxSets.Text = TrainingSession.listOfAllTrainingSessions[i].sessionSets;
                        textBoxReps.Text = TrainingSession.listOfAllTrainingSessions[i].sessionReps;

                        if (TrainingSession.listOfAllTrainingSessions[i].active == "True")
                        {
                            checkBoxSessionActive.Checked = true;
                        }
                    }
                }

                // Now get a list of all exercises for the training session
                TrainingSession.GetTrainingSessionExercises(sessionId);

                dataGridViewTrainingSessionData.DataSource = "";

                dataGridViewTrainingSessionData.DataSource = TrainingSessionExercise.trainingSessionExerciseList;
            }

        }

        private void buttonAddNewSession_Click(object sender, EventArgs e)
        {
            AddNewTrainingSession form = new AddNewTrainingSession();

            form.Show();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void closeFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    } // End of class
}
