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
    public partial class ModifyAssignedTrainingSessions : Form
    {
        public int clientId;

        public ModifyAssignedTrainingSessions(int clientIdToModify)
        {

            InitializeComponent();

            clientId = clientIdToModify;
            labelClientId.Text = $"Client ID: {clientId}";

            PopulateTrainingSessionDropdown();
            dataGridViewTrainingSessions.DataSource = TrainingSession.listOfTrainingSessions;

        }

        /// <summary>
        /// Populates the client dropdown list
        /// </summary>
        public void PopulateTrainingSessionDropdown()
        {
            // comboBoxClientNames.DataSource = new BindingSource(ClientDataForm.clients, null);
            TrainingSession.trainingSessionDictionaryForDropdown.Add("0", "Pick a Session");

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
                MessageBox.Show("Please pick a training session from the list");
            } else
            {
                for(int i = 0; i < TrainingSession.listOfAllTrainingSessions.Count; i++)
                {
                    // TODO: Loop through this to find the training session that matches the ID from the dropdown list

                    // TODO: Populate the textbox values
                }
            }

        }


    } // End of class

}
