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
    public partial class ClientManagement : Form
    {
        public ClientManagement()
        {
            InitializeComponent();
           // ClientData.GetAllClients();
            PopulateClientDropdown();
        }

        /// <summary>
        /// Populates the client dropdown list
        /// </summary>
        public void PopulateClientDropdown()
        {
            comboBoxClientNames.DataSource = new BindingSource(ClientData.clients, null);
            comboBoxClientNames.DisplayMember = "Value";
            comboBoxClientNames.ValueMember = "Key";
        }

        private void buttonGetClientInfo_Click(object sender, EventArgs e)
        {

            int id;
            try
            {
                id = Convert.ToInt32(comboBoxClientNames.SelectedValue);
            }
            

            catch
            {
                id = GetFirstIdFromClientDataTable();
            }

            // Get the client info & display it on the form
            //ClientData.GetClientInfo(id);

            // Testing new method
            ClientData.GetDataFromDatabase("ClientInfo", id);

            dataGridViewClientDetails.DataSource = ClientData.clientDataResultsTable;

            // Get a list of training sessions assigned to the client
            ClientData.GetDataFromDatabase("ClientTrainingSessions", id);

            dataGridViewTrainingSessions.DataSource = ClientData.clientTrainingSessionsTable;
        }

        private int GetClientIdFromDropdown()
        {
            int id = Convert.ToInt32(comboBoxClientNames.SelectedValue);

            return id;

        }

        private int GetFirstIdFromClientDataTable()
        {
            int id;

            id = Convert.ToInt32(ClientData.clients.Keys.First());

            return id;
        }

        private void buttonEditClient_Click(object sender, EventArgs e)
        {

            int clientId = GetClientIdFromDropdown();
            EditClient form = new EditClient(clientId);

            form.Show();
        }
    }
}
