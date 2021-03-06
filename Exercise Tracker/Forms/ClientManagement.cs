﻿using Exercise_Tracker.Classes;
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
    public partial class ClientManagement : Form
    {
        public static Logger logger = LogManager.GetCurrentClassLogger();

        public string firstName;
        public string lastName;
        public string address;
        public string city;
        public string zipCode;
        public string email;
        public string state;
        public string registrationDate;
        public string active;
        public string phone;


        public ClientManagement()
        {
            InitializeComponent();
            // this.AutoScaleMode = AutoScaleMode.None;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;

            PopulateClientDropdown();
          
        }

        /// <summary>
        /// Populates the client dropdown list
        /// </summary>
        public void PopulateClientDropdown()
        {
            // comboBoxClientNames.DataSource = new BindingSource(ClientDataForm.clients, null);
            comboBoxClientNames.DataSource = new BindingSource(Client.clientDictionaryForDropdown, null);
            comboBoxClientNames.DisplayMember = "Value";
            comboBoxClientNames.ValueMember = "Key";
        }

        /// <summary>
        ///  Gets data for the client by clientID when the user picks a client from the dropdown list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonGetClientInfo_Click(object sender, EventArgs e)
        {
            GetClientInformation();
        }

        /// <summary>
        /// Finds the information on the client from the client list
        /// </summary>
        private void GetClientInformation()
        {
            // Clear the lists
            TrainingSession.listOfTrainingSessions.Clear();
            Workout.listOfWorkouts.Clear();

            dataGridViewTrainingSessions.DataSource = null;
            dataGridViewWorkoutHistory.DataSource = null;
            

            int id;
            try
            {
                id = Convert.ToInt32(comboBoxClientNames.SelectedValue);
            }
            catch
            {
                id = 0;
            }

            if (id != 0)
            {
                // Loop through the array of objects and see which one matches
                for (int i = 0; i < Client.listOfClients.Count; i++)
                {
                    if (Client.listOfClients[i].client_id == id.ToString())
                    {
                        labelFirstNameText.Text = Client.listOfClients[i].firstName;
                        labelLastNameText.Text = Client.listOfClients[i].lastName;
                        labelAddressText.Text = Client.listOfClients[i].address;
                        labelCityText.Text = Client.listOfClients[i].city;
                        labelZipCodeText.Text = Client.listOfClients[i].zipcode;
                        labelEmailText.Text = Client.listOfClients[i].email;
                        labelStateText.Text = Client.listOfClients[i].state;
                        labelPhoneText.Text = Client.listOfClients[i].phone;
                        labelRegistrationDateText.Text = Client.listOfClients[i].registration_date;
                        labelActiveText.Text = Client.listOfClients[i].active;

                        firstName = Client.listOfClients[i].firstName;
                        lastName = Client.listOfClients[i].lastName;
                        address = Client.listOfClients[i].address;
                        city = Client.listOfClients[i].city;
                        zipCode = Client.listOfClients[i].zipcode;
                        email = Client.listOfClients[i].email;
                        state = Client.listOfClients[i].state;
                        phone = Client.listOfClients[i].phone;
                        registrationDate = Client.listOfClients[i].registration_date;
                        active = Client.listOfClients[i].active;

                    }
                }


                // Get a list of training sessions assigned to the client
                GetClientTrainingSessions(id);

                dataGridViewTrainingSessions.DataSource = TrainingSession.listOfTrainingSessions;

                // Get the workout history for the client as well
                Client.GetWorkoutHistory(id);

                dataGridViewWorkoutHistory.DataSource = Workout.listOfWorkouts;

            }
        }

        /// <summary>
        /// Gets the int from the dropdown for the given client
        /// </summary>
        /// <returns>An int that is the client ID</returns>
        private int GetClientIdFromDropdown()
        {
            int id = Convert.ToInt32(comboBoxClientNames.SelectedValue);

            return id;
        }

        /// <summary>
        /// Called when the user clicks the "Edit" button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEditClient_Click(object sender, EventArgs e)
        {

            int clientId = GetClientIdFromDropdown();

            if (clientId != 0)
            {
                // Send the client details to be edited
                EditClientDetails form = new EditClientDetails(clientId, firstName, lastName, address, city, state, zipCode, phone, email, active);

                form.Show();
            } else
            {
                MessageBox.Show("Please pick a client");
            }

        }

        /// <summary>
        /// What happens when the user clicks the "delete" button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDeleteClient_Click(object sender, EventArgs e)
        {
            MarkClientAsInactive();
        }

        /// <summary>
        /// Gets all training sessions for a specific client
        /// </summary>
        /// <param name="id">ID of the client you are gettign training sessions for</param>
        private void GetClientTrainingSessions(int id)
        {
            Client.GetClientTrainingSessions(id);

        }

        /// <summary>
        /// Marks a given client as inactive in the system
        /// </summary>
        private void MarkClientAsInactive()
        {
            int clientId = GetClientIdFromDropdown();

            if (clientId == 0)
            {
                MessageBox.Show("Please pick a client");
            }
            else
            {
                Client client = new Client();
                client.active = "false";

                string clientAsJson = JsonConvert.SerializeObject(client);

                APIRequests request = new APIRequests();

                string url = $"{request.singleClientDetailEndpoint}{clientId}";

                string response = request.SendPatchRequestDataInBody(url, clientAsJson);

                MessageBox.Show(response);
            }
        }

        private void buttonRefreshClient_Click(object sender, EventArgs e)
        {
            Client.GetClients();
            PopulateClientDropdown();
            GetClientInformation();
        }

        private void buttonEditWorkout_Click(object sender, EventArgs e)
        {
            int workoutId = 0;

            foreach (DataGridViewRow item in this.dataGridViewWorkoutHistory.SelectedRows)
            {
                // TODO: Be able to select the session to remove it
                string workoutIdFromGrid = Convert.ToString(item.Cells[0].Value);

                workoutId = Convert.ToInt32(workoutIdFromGrid);
            }

            //ViewClientWorkout form = new ViewClientWorkout(workoutId);
            //form.Show();

            if (workoutId == 0)
            {
                MessageBox.Show("Please select an entire row to view the workout");
            } else
            {
                ViewWorkoutDetails form2 = new ViewWorkoutDetails(workoutId);
                form2.Show();
            }

        }

        private void buttonModifyAssignedSessions_Click(object sender, EventArgs e)
        {
            int clientId = GetClientIdFromDropdown();
            ModifyAssignedTrainingSessions form = new ModifyAssignedTrainingSessions(clientId);

            form.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonAddClient_Click(object sender, EventArgs e)
        {
            AddClient form = new AddClient();
            form.Show();
        }

        private void closeFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonDeleteWorkout_Click(object sender, EventArgs e)
        {

            DialogResult result1 = MessageBox.Show("This will remove the workout from your history, and it cannot be recovered.  Do you wish to continue?",
                                       "This will delete a workout",
                                       MessageBoxButtons.YesNo);

            if(result1.ToString() == "No")
            {
                return;
            }

            int workoutId = 0;

            foreach (DataGridViewRow item in this.dataGridViewWorkoutHistory.SelectedRows)
            {
                // TODO: Be able to select the session to remove it
                string workoutIdFromGrid = Convert.ToString(item.Cells[0].Value);

                workoutId = Convert.ToInt32(workoutIdFromGrid);
            }

            if(workoutId == 0)
            {
                MessageBox.Show("Please select an entire row");
            } else
            {
                APIRequests request = new APIRequests();

                string url = $"{request.getSpecificWorkoutHistoryItem}{workoutId}";

                logger.Info(url);

                string response = request.SendDeleteRequestData(url);

                if (response.Contains("Successfully removed workout from client"))
                {
                    MessageBox.Show("Successfully removed workout from client");

                    GetClientInformation();
                } else
                {
                    logger.Error(response);
                    MessageBox.Show("Something went wrong and workout not removed");
                }

            }

        }
    }
}
