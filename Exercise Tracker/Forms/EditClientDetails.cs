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

namespace Exercise_Tracker.Forms
{
    public partial class EditClientDetails : Form
    {
        
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
            // TODO: Create This
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

            Client client = new Client(clientId, firstName, lastName, active, address, city, state, zipCode, phone, email);

            string clientAsJson = JsonConvert.SerializeObject(client);

            MessageBox.Show(clientAsJson);
        }
    }
}
