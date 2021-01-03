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
    public partial class RecordWorkout : Form
    {
        private int sessionId;
        private string sessionName;

        // TODO: Create a table to hold exercise information. Table needs the following:
        /*
         * WorkoutSession Table: Date, workoutsession ID, trainingsessionId
         * -- Workoutsession ID pulled from database, but not saved until user actually saves the workout
         * WorkoutSessionDetails Table: workoutsession ID (FK), exerciseID, sets, reps, weight, time
         * -- Displys on this form.  User is able to change the info
         * -- Use clicks "Save" button.  Table data is checked for integrity, a transaction created, and data is written to the tables
         * 
         */

        // TODO: Create a "misc" training session, containing all the available exercises.  Use than then pick what they want
        public RecordWorkout(int id, string name)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;

            sessionId = id;
            sessionName = name;

            labelSessionName.Text = sessionName;

            ClientData.GetDataFromDatabase("RecordWorkout", id);
            dataGridViewExercises.DataSource = ClientData.recordingExercisesTable;

        }

        public RecordWorkout()
        {
            InitializeComponent();
            
        }
 

        private void RecordWorkout_Load(object sender, EventArgs e)
        {
            InitializeComponent();

        }

        private void buttonTest_Click(object sender, EventArgs e)
        {

        }

        private void closeWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
