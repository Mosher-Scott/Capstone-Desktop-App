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
    public partial class EditClient : Form
    {

        public EditClient()
        {
            InitializeComponent();
        }

        public EditClient(int id)
        {
            InitializeComponent();
            ClientData.GetDataFromDatabase("ClientInfo", id);
            dataGridViewClientData.DataSource = ClientData.clientDataResultsTable;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSaveEdits_Click(object sender, EventArgs e)
        {
            // TODO: Create This
        }
    }
}
