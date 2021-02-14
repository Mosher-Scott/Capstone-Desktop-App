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
    public partial class ModifyAssignedTrainingSessions : Form
    {
        public int clientId;
        public static List<TrainingSession> originalTrainingSessions = new List<TrainingSession>();
        //public static List<TrainingSession> originalTrainingSessions = new List<TrainingSession>();

        /// <summary>
        /// sessionId, clientID
        /// </summary>
        public Dictionary<int, int> trainingSessionsToAdd = new Dictionary<int, int>();

        /// <summary>
        /// sessionId, clientID
        /// </summary>
        public Dictionary<int, int> trainingSessionsToremove = new Dictionary<int, int>();
        public static Logger logger = LogManager.GetCurrentClassLogger();

        /// <summary>
        /// Opening the form
        /// </summary>
        /// <param name="clientIdToModify">ID of the client you are modifing training sessions for</param>
        public ModifyAssignedTrainingSessions(int clientIdToModify)
        {

            InitializeComponent();
           

            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            clientId = clientIdToModify;
            labelClientId.Text = $"Client ID: {clientId}";

            PopulateTrainingSessionDropdown();
            dataGridViewTrainingSessions.DataSource = TrainingSession.listOfTrainingSessions;

            SetOriginalTrainingSessionList();

        }

        /// <summary>
        /// Adds the values within TrianingSession.listOfTrainingSessions to a differnt list. This new list will be used to look for any changes
        /// </summary>
        private void SetOriginalTrainingSessionList()
        {
            foreach(var item in TrainingSession.listOfTrainingSessions)
            {
                originalTrainingSessions.Add(item);
            }
            
        }

        /// <summary>
        /// Populates the client dropdown list
        /// </summary>
        public void PopulateTrainingSessionDropdown()
        {
            comboBoxAllTrainingSessions.DataSource = new BindingSource(TrainingSession.trainingSessionDictionaryForDropdown, null);
            comboBoxAllTrainingSessions.DisplayMember = "Value";
            comboBoxAllTrainingSessions.ValueMember = "Key";
        }

        /// <summary>
        /// When the user selects a training session from the dropdown, this will populate the table with specific information
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ViewTrainingSessionDetails(object sender, EventArgs e)
        {

            int trainingSessionId;
            try
            {
                trainingSessionId = Convert.ToInt32(comboBoxAllTrainingSessions.SelectedValue);
            } catch {
                trainingSessionId = 0;
            }
            

            if (trainingSessionId == 0)
            {
               // MessageBox.Show("Please pick a training session from the list");
            } else
            {
                // Loop through each training session
                for(int i = 0; i < TrainingSession.listOfAllTrainingSessions.Count; i++)
                {
                    if (TrainingSession.listOfAllTrainingSessions[i].sessionId == trainingSessionId.ToString())
                    {

                        groupBoxSessionInfo.Text = $"Training Session {TrainingSession.listOfAllTrainingSessions[i].sessionId} Info";
                        textBoxSessionName.Text = TrainingSession.listOfAllTrainingSessions[i].sessionName;
                        textBoxDescription.Text = TrainingSession.listOfAllTrainingSessions[i].sessionDescription;
                        textBoxReps.Text = TrainingSession.listOfAllTrainingSessions[i].sessionReps;
                        textBoxSets.Text = TrainingSession.listOfAllTrainingSessions[i].sessionSets;
                        break;

                    }

                }
            }

        }

        /// <summary>
        /// Adds the current selected training session to the array
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddSession_Click(object sender, EventArgs e)
        {
            
            int sessionId = Convert.ToInt32(comboBoxAllTrainingSessions.SelectedValue);

            // TODO: Check if the sessionId already exists in the list.  If it does, display a message.  Else add it

            for (int i = 0; i < TrainingSession.listOfAllTrainingSessions.Count; i++)
            {
                if (TrainingSession.listOfAllTrainingSessions[i].sessionId == sessionId.ToString())
                {
                    TrainingSession.listOfTrainingSessions.Add(TrainingSession.listOfAllTrainingSessions[i]);
                }
                    
            }


            dataGridViewTrainingSessions.DataSource = null;

            //TrainingSession.listOfAllTrainingSessions.Sort();

            dataGridViewTrainingSessions.DataSource = TrainingSession.listOfTrainingSessions;

        }

        /// <summary>
        /// When the user wants to save their changes to the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSaveChanges_Click(object sender, EventArgs e)
        {
            var removedCount = AssignedTrainingSessions.newTrainingSessionList.Count;
            logger.Info(removedCount);
            var newCount = AssignedTrainingSessions.newTrainingSessionList.Count;
            logger.Info(newCount);

            // Compare lists to find any added training sessions
            CheckForNewSessions();

            removedCount = AssignedTrainingSessions.newTrainingSessionList.Count;
            logger.Info(removedCount);
            newCount = AssignedTrainingSessions.newTrainingSessionList.Count;
            logger.Info(newCount);

            // Now see what was removed
            CheckForDeletedSessions();

            logger.Info($"New Training Sessions: {AssignedTrainingSessions.newTrainingSessionList.Count}");

            logger.Info($"Removed Training Sessions: {AssignedTrainingSessions.removedTrainingSessionList.Count}");

            
            // If session did exist, and was removed, set DELETE request
            AssignedTrainingSessions.RemoveTrainingSessionsFromDatabase();

            // If new, send POST request to update client training sessions with userid and session id
            AssignedTrainingSessions.AddNewTrainingSessionsToDatabase();

            // TODO: Check if all changes were made successfully.  If they were, close the form
            MessageBox.Show("Successfully saved your changes");

            this.Close();

        }

        /// <summary>
        /// Checks if a training session in originalTrainingSessions exists in the listOfTainingSessions.  If it doesn't then it needs to be removed
        /// </summary>
        private void CheckForDeletedSessions()
        {
            // Check each item in the original training session list
            for(int i = 0; i < originalTrainingSessions.Count; i++)
            {
                var originalId = originalTrainingSessions[i].sessionId;
                bool needsToBeDeleted = true;

                for(int j = 0; j < TrainingSession.listOfTrainingSessions.Count; j++)
                {
                    var currentList = TrainingSession.listOfTrainingSessions[j].sessionId;
                    // If there is a match, break out of this for loop
                    if (originalTrainingSessions[i].sessionId == TrainingSession.listOfTrainingSessions[j].sessionId)
                    {
                        needsToBeDeleted = false;
                        break;
                    }
                }

                // If a session isn't in the original list, then it needs to be removed
                if(needsToBeDeleted)
                {    
                    AssignedTrainingSessions session = new AssignedTrainingSessions(clientId, Convert.ToInt32(TrainingSession.listOfTrainingSessions[i].sessionId));

                    AssignedTrainingSessions.removedTrainingSessionList.Add(session);

                    var removedCount = AssignedTrainingSessions.newTrainingSessionList.Count;
                    logger.Info(removedCount);
                    var newCount = AssignedTrainingSessions.newTrainingSessionList.Count;
                    logger.Info(newCount);
                }
            } // End of for loop
        }

        /// <summary>
        /// Checks if a given training session exists in the originalTrainingSessions list.  If not, add it to trainingSessionsToAdd
        /// </summary>
        private void CheckForNewSessions()
        {
            // Loop through the current list of assigned training sessions to see if we need to add or remove any
            for (int i = 0; i < TrainingSession.listOfTrainingSessions.Count; i++)
            {
                // a flag for whether the session needs to be added or not.  By default, no
                bool newSessionAdded = true;

                string listSessionId = TrainingSession.listOfTrainingSessions[i].sessionId;
                // For each session in listOfTrainingSessions, see if exists in the original one
                for (int j = 0; j < originalTrainingSessions.Count; j++)
                {
                    string originalTrainingSessionId = originalTrainingSessions[j].sessionId;
                    // If it exists in current list and the new list, don't do anything
                    if (TrainingSession.listOfTrainingSessions[i].sessionId == originalTrainingSessions[j].sessionId)
                    {
                        newSessionAdded = false;
                        continue;
                    }
                    // If the session isn't found in the original array, then it is new and newSessionAddd stays as true
                }

                // Now add the new session to the list
                if (newSessionAdded)
                {
                    AssignedTrainingSessions session = new AssignedTrainingSessions(clientId, Convert.ToInt32(TrainingSession.listOfTrainingSessions[i].sessionId));

                    AssignedTrainingSessions.newTrainingSessionList.Add(session);
                    var count = AssignedTrainingSessions.newTrainingSessionList.Count;
                    logger.Info(count);

                }
            } // End of main for loop for adding sessions

        }

        /// <summary>
        /// Deleting a specific row in the datatable the user has selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDeleteRow_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridViewTrainingSessions.SelectedRows)
            {
                // TODO: Be able to select the session to remove it
                string sessionId = Convert.ToString(item.Cells[0].Value);

                trainingSessionsToremove.Add(Convert.ToInt32(sessionId), clientId);

                foreach (var session in TrainingSession.listOfTrainingSessions.ToList())
                {
                    if (sessionId == session.sessionId)
                    {
                        TrainingSession.listOfTrainingSessions.Remove(session);
                    }
                }

;                dataGridViewTrainingSessions.DataSource = null;
                dataGridViewTrainingSessions.DataSource = TrainingSession.listOfTrainingSessions;
                
            }
        }

        private void buttonCloseForm_Click(object sender, EventArgs e)
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
    } // End of class

}