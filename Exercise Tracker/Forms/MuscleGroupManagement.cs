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

namespace Exercise_Tracker.Forms
{
    public partial class MuscleGroupManagement : Form
    {
        public MuscleGroupManagement()
        {
            InitializeComponent();

            dataGridViewMuscleGroups.DataSource = MuscleGroup.muscleGroupList;

            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void closeFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAddNew_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            bool nameAlreadyExists = false;

            if (name == "")
            {
                MessageBox.Show("Please fill out the name textbox");
                return;
            }

            // Check if the name exists
            foreach(var muscleGroup in MuscleGroup.muscleGroupList)
            {
                if(name == muscleGroup.muscle_group_details)
                {
                    MessageBox.Show("Muscle Groups already exists.  Please pick a new name");
                    nameAlreadyExists = false;
                    break;
                }
            }

            // If the name is new, send it to the API
            if (!nameAlreadyExists)
            {
                APIRequests request = new APIRequests();

                string url = $"{request.allMuscleGroupsEndpoint}/{name}";

                var response = request.SendPostRequestData(url);

                if(response.Contains("Successfully"))
                {
                    MessageBox.Show("Sucessfully added a new muscle group");

                    textBoxName.Text = "";

                    ResetMuscleGroupView();

                }

            }
        }

        /// <summary>
        /// When the user clicks the edit button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            int muscleGroupId = GetMuscleGroupIdFromTable();

            if(muscleGroupId == 0)
            {
                MessageBox.Show("Please select a row from the table to edit a muscle group");
                return;
            }

            // Check if the name exists
            foreach (var muscleGroup in MuscleGroup.muscleGroupList)
            {
                if (muscleGroupId == muscleGroup.id)
                {
                    textBoxId.Text = muscleGroupId.ToString();

                    textBoxEditName.Text = muscleGroup.muscle_group_details;
                }
            }

        }

        private int GetMuscleGroupIdFromTable()
        {
            int muscleGroupId = 0;
            foreach (DataGridViewRow item in this.dataGridViewMuscleGroups.SelectedRows)
            {
                // TODO: Be able to select the session to remove it
                string groupIdFromGrid = Convert.ToString(item.Cells[0].Value);

                muscleGroupId = Convert.ToInt32(groupIdFromGrid);
            }

            return muscleGroupId;
        }

        private void buttonSaveChanges_Click(object sender, EventArgs e)
        {
            // 1. Get details
            int muscleGroupId = Convert.ToInt32(textBoxId.Text);
            string muscleGroupName = textBoxEditName.Text;

            // 2. Create object
            MuscleGroup muscleGroup = new MuscleGroup(muscleGroupId, muscleGroupName);

            // 3. Convert to JSON
            var jsonData = JsonConvert.SerializeObject(muscleGroup);

            // 4. Create request, send it, and get response
            APIRequests request = new APIRequests();

            string url = request.allMuscleGroupsEndpoint;

            var response = request.SendPOSTRequestDataInBody(url, jsonData);

            // 5. Handle response
            if(response.Contains("Successfully"))
            {
                MessageBox.Show("Successfully modified the muscle group");

                textBoxEditName.Text = "";

                ResetMuscleGroupView();
            } else
            {
                MessageBox.Show("Something went wrong, and we couldn't edit the muscle group");
            }

        }

        /// <summary>
        /// Checks the API to get a new list of muscle groups
        /// </summary>
        private void ResetMuscleGroupView()
        {
           
            MuscleGroup.GetMusclegroups();

            dataGridViewMuscleGroups.DataSource = "";
            dataGridViewMuscleGroups.DataSource = MuscleGroup.muscleGroupList;
        }
    } // End of class
}
