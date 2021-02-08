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
            // comboBoxClientNames.DataSource = new BindingSource(ClientDataForm.clients, null);
            comboBoxClientNames.DataSource = new BindingSource(Client.clientDictionaryForDropdown, null);
            comboBoxClientNames.DisplayMember = "Value";
            comboBoxClientNames.ValueMember = "Key";
        }

        /// <summary>
        ///  Gets data when the user picks a value from the dropdown list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonGetClientInfo_Click(object sender, EventArgs e)
        {

            int id;
            try
            {
                id = Convert.ToInt32(comboBoxClientNames.SelectedValue);
            }
            catch
            {
                id = 0;
            }


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
                    labelRegistrationDateText.Text = Client.listOfClients[i].registration_date;
                    labelActiveText.Text = Client.listOfClients[i].client_active_flag;

                }
            }


            // Get a list of training sessions assigned to the client
            
            // Get the workout history for the client as well
        }

        // Gets the int from the dropdown for the given client
        private int GetClientIdFromDropdown()
        {
            int id = Convert.ToInt32(comboBoxClientNames.SelectedValue);

            return id;
        }

        private int GetFirstIdFromClientDataTable()
        {
            int id;

            id = Convert.ToInt32(ClientDataForm.clients.Keys.First());

            return id;
        }

        private void buttonEditClient_Click(object sender, EventArgs e)
        {

            int clientId = GetClientIdFromDropdown();
            EditClient form = new EditClient(clientId);

            form.Show();
        }

        private void buttonDeleteClient_Click(object sender, EventArgs e)
        {

        }

    }
}
