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

        private void buttonSaveChanges_Click(object sender, EventArgs e)
        {
            // Compare lists to find any added training sessions
            CheckForNewSessions();

            // Now see what was removed
            CheckForDeletedSessions();

            // If new, send POST request to update client training sessions with userid and session id
            string sessionsToAdd = JsonConvert.SerializeObject(trainingSessionsToAdd);

            logger.Info("Training sessions to be added");
            logger.Info(sessionsToAdd);

            // If session did exist, and was removed, set DELETE request
            logger.Info("Training Sessions To Remove");
            string sessionsToRemove = JsonConvert.SerializeObject(trainingSessionsToAdd);
            logger.Info(sessionsToRemove);
            
        }

        /// <summary>
        /// Checks if a training session in originalTrainingSessions exists in the listOfTainingSessions.  If it doesn't then it needs to be removed
        /// </summary>
        private void CheckForDeletedSessions()
        {
            // Check each item in the original training session list
            for(int i = 0; i < originalTrainingSessions.Count; i++)
            {
                bool needsToBeDeleted = true;

                for(int j = 0; j < TrainingSession.listOfTrainingSessions.Count; j++)
                {
                    // If there is a match, break out of this for loop
                    if (originalTrainingSessions[i].sessionId == TrainingSession.listOfTrainingSessions[j].sessionId)
                    {
                        needsToBeDeleted = false;
                        continue;
                    }
                }

                // If a session needs to be removed, add it to the list
                if(needsToBeDeleted)
                {
                    trainingSessionsToremove.Add(Convert.ToInt32(originalTrainingSessions[i].sessionId), clientId);
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
                        break;
                    }
                    // If the session isn't found in the original array, then it is new and newSessionAddd stays as true
                }

                if (newSessionAdded)
                {
                    trainingSessionsToAdd.Add(Convert.ToInt32(TrainingSession.listOfTrainingSessions[i].sessionId), clientId);
                }
            } // End of main for loop for adding sessions

        }

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
    } // End of class

}
