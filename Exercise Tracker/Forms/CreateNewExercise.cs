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
    public partial class CreateNewExercise : Form
    {
        public static Logger logger = LogManager.GetCurrentClassLogger();

        public CreateNewExercise()
        {
            InitializeComponent();


            //ClientDataForm.GetAllMuscleGroups();

            PopulateMuscleGroupDropdown();
            
        }

        private void PopulateMuscleGroupDropdown()
        {

            comboBoxMuscleGroups.DataSource = new BindingSource(MuscleGroup.muscleGroupDictionary, null);
            comboBoxMuscleGroups.DisplayMember = "Value";
            comboBoxMuscleGroups.ValueMember = "Key";
        }

        /// <summary>
        /// When the user clicks the "save" button, data will be saved and checked before being sent off to the API
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSave_Click(object sender, EventArgs e)
        {
            // TODO: Validate all input to make sure it is valid
            string name = textBoxName.Text;
            string muscleGroupId = comboBoxMuscleGroups.SelectedValue.ToString();
            string instructions = textBoxInstructionInput.Text;
            string active = checkBoxActive.Checked.ToString() ;

            Exercise newExercise = new Exercise(name, muscleGroupId, instructions, active);

            string exerciseAsJSON = JsonConvert.SerializeObject(newExercise);
            
            //logger.Info(exerciseAsJSON);

            AddExerciseToDatabase(exerciseAsJSON);
            
        }

        /// <summary>
        /// Method for creating the request and sending it off to the server to add a new exercise
        /// </summary>
        /// <param name="exercise">Exercise object as a JSON string</param>
        private static void AddExerciseToDatabase(string exercise)
        {
            APIRequests request = new APIRequests();

            string url = $"{request.allExercisesEndpoint}";

            string response = request.SendPOSTRequestDataInBody(url, exercise);

            if (response.Contains("Successfully added new exercise"))
            {
                MessageBox.Show("Successfully added exercise to the system");
            }
            else
            {
                MessageBox.Show("Something went wrong");
            }
        }

        /// <summary>
        /// Closing the form without saving changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
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
