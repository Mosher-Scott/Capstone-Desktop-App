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
    public partial class AddClient : Form
    {

        public static Logger logger = LogManager.GetCurrentClassLogger();

        public AddClient()
        {
            InitializeComponent();
        }

        private void buttonSaveEdits_Click(object sender, EventArgs e)
        {
            // Registration date & ID will be set by the server

            string firstName = textBoxFirstName.Text;
            string lastName = textBoxLastName.Text;
            string address = textBoxAddress.Text;
            string city = textBoxCity.Text;
            string zipCode = textBoxZipCode.Text;
            string email = textBoxEmail.Text;
            string state = textBoxState.Text;
            string phone = textBoxPhone.Text;
            string password = textBoxPassword.Text;

            if (firstName == "" || lastName == "" || address == "" || city == "" || zipCode == "" || email == "" || state == "" || phone == "" || password == "")
            {
                MessageBox.Show("Please fill out all fields");
                return;
            } else
            {
                Client newClient = new Client();

                newClient.firstName = firstName;
                newClient.lastName = lastName;
                newClient.address = address;
                newClient.city = city;
                newClient.zipcode = zipCode;
                newClient.email = email;
                newClient.state = state;
                newClient.phone = phone;
                newClient.password = password;

                string clientAsJson = JsonConvert.SerializeObject(newClient);

                //logger.Info(clientAsJson);

                AddClientToDatabase(clientAsJson);
            }
        }

        /// <summary>
        /// Creates the API request to add a new client to the database, and handles the response
        /// </summary>
        /// <param name="client">Client as a JSON string to be added to the system</param>
        private void AddClientToDatabase(string client)
        {
            APIRequests request = new APIRequests();

            string url = $"{request.allClientDetailsEndpoint}";

            string response = request.SendPOSTRequestDataInBody(url, client);

            logger.Info(response);

            if (response.Contains("Successfully added new client"))
            {
                MessageBox.Show("Successfully added client to the system");
            } else
            {
                MessageBox.Show("Something went wrong");
            }
        }

        private void closeFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
