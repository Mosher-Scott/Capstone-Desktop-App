using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Exercise_Tracker.Classes;
using Exercise_Tracker.Forms;
using Microsoft.Data.Sqlite;
using MyClasses;
using NLog;

namespace Exercise_Tracker
{
    public partial class FormViewClient : Form
    {

        public static string dataDbName = $"{Application.StartupPath}\\db_exercise.db3";
        public static Logger logger = LogManager.GetCurrentClassLogger();

        public FormViewClient()
        {

            //this.WindowState = FormWindowState.Maximized;
            //this.FormBorderStyle = FormBorderStyle.None;
            

            InitializeComponent();

            //ClientData.GetAllClients();

            PopulateClientDropdown();
        }

        private void FormViewClient_Load(object sender, EventArgs e)
        {

        }

        private void Dropdown_Changed(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Populates the client dropdown list
        /// </summary>
        public void PopulateClientDropdown()
        {
            comboBoxClientNames.DataSource = new BindingSource(ClientDataForm.clients, null);
            comboBoxClientNames.DisplayMember = "Value";
            comboBoxClientNames.ValueMember = "Key";
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(comboBoxClientNames.SelectedValue);

            // Get the client info & display it on the form
            //ClientData.GetClientInfo(id);

            // Testing new method
            ClientDataForm.GetDataFromDatabase("ClientInfo", id);

            dataGridViewClientDetails.DataSource = ClientDataForm.clientDataResultsTable;

            // Get a list of training sessions assigned to the client
            ClientDataForm.GetDataFromDatabase("ClientTrainingSessions", id);

            dataGridViewTrainingSessions.DataSource = ClientDataForm.clientTrainingSessionsTable;

            // Populate the dropdown list with the sessions & the IDs
            comboBoxAssignedTrainingSessions.DataSource = ClientDataForm.clientTrainingSessionsTable;
            comboBoxAssignedTrainingSessions.DisplayMember = "Name";
            comboBoxAssignedTrainingSessions.ValueMember = "id";
        }

        private void DisplaySessionExercieses(object sender, EventArgs e)
        {
            // When user picks a client, the form value will be blank, causing the catch block to be used. Else it'll use the try block
            try
            {
                int id = Convert.ToInt32(comboBoxAssignedTrainingSessions.SelectedValue);

                if(id == 0)
                {
                    id = GetFirstIdFromDataTable();
                }

                //ClientData.GetTrainingSessionExercises(id);
                ClientDataForm.GetDataFromDatabase("GetTrainingSessionExercises", id);

                dataGridViewSessionExercises.DataSource = ClientDataForm.sessionExercisesTable;

            } catch
            {

            }

        }


        private int GetFirstIdFromDataTable()
        {
            int id;

            id = Convert.ToInt32(ClientDataForm.clientTrainingSessionsTable.Rows[0][0]);

            return id;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonDoWorkout_Click(object sender, EventArgs e)
        {
            try
            {
                int clientId = Convert.ToInt32(comboBoxClientNames.SelectedValue);

                int sessionId = Convert.ToInt32(comboBoxAssignedTrainingSessions.SelectedValue);

                string sessionName = comboBoxAssignedTrainingSessions.Text;

                RecordWorkout newWindow = new RecordWorkout(sessionId, sessionName, clientId);

                newWindow.Show();

            } catch (Exception ex)
            {
                logger.Error(ex.Message);
            }
        }

    } // end of class
}
