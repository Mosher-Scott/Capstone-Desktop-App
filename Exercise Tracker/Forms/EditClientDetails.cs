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
using Newtonsoft;
using Newtonsoft.Json;
using NLog;

namespace Exercise_Tracker.Forms
{
    public partial class EditClientDetails : Form
    {

        public static Logger logger = LogManager.GetCurrentClassLogger();

        public string origclientId;
        public string origfirstName;
        public string origlastName;
        public string origaddress;
        public string origcity;
        public string origzipCode;
        public string origemail;
        public string origstate;
        public string origactive;
        public string origphone;

        public EditClientDetails()
        {
            InitializeComponent();
        }
     
        public EditClientDetails(int id, string firstName, string lastname, string address, string city, string state, string zipCode, string phone, string email, string active)
        {
            InitializeComponent();

            labelClientIdText.Text = id.ToString();
            textBoxFirstName.Text = firstName;
            textBoxLastName.Text = lastname;
            textBoxAddress.Text = address;
            textBoxCity.Text = city;
            textBoxState.Text = state;
            textBoxZipCode.Text = zipCode;
            textBoxPhone.Text = phone;
            textBoxEmail.Text = email;

            // Save the original values
            origfirstName = firstName;
            origlastName = lastname;
            origaddress = address;
            origcity = city;
            origstate = state;
            origzipCode = zipCode;
            origphone = phone;
            origemail = email;

            if (active == "True")
            {
                checkBoxActive.Checked = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSaveEdits_Click(object sender, EventArgs e)
        {

            string clientId = labelClientIdText.Text;
            string firstName = textBoxFirstName.Text;
            string lastName = textBoxLastName.Text;
            string address = textBoxAddress.Text;
            string city = textBoxCity.Text;
            string zipCode = textBoxZipCode.Text;
            string email = textBoxEmail.Text;
            string state = textBoxState.Text;
            string active = checkBoxActive.Checked.ToString();
            string phone = textBoxPhone.Text;

            // TODO:  Compare old values and new values.  If changed, add to an array and convert it to json to send
            Client client = new Client(clientId, firstName, lastName, active, address, city, state, zipCode, phone, email);

            string clientAsJson = JsonConvert.SerializeObject(client);

            //logger.Info(clientAsJson);

            APIRequests request = new APIRequests();

            string url = $"{request.singleClientDetailEndpoint}{clientId}";

            string response = request.SendPatchRequestDataInBody(url, clientAsJson);

            if(response.Contains("Successfully modified the client"))
            {
                MessageBox.Show("Successfully modified the client");
                this.Close();
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
