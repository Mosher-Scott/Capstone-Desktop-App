﻿using Exercise_Tracker.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_Tracker.Forms
{
    public partial class FormStartingMenu : Form
    {
        public FormStartingMenu()
        {
            InitializeComponent();
            //ClientDataForm.GetAllClients();

            Thread muscleGroups = new Thread(() => MuscleGroup.GetMusclegroups());
            Thread exercises = new Thread(() => Exercise.GetExercises());
            // Get clients

            exercises.Start();

            muscleGroups.Start();


            exercises.Join();
            muscleGroups.Join();

        }

        private void buttonViewClients_Click(object sender, EventArgs e)
        {
            FormViewClient form = new FormViewClient();
            form.Show();
        }

        private void buttonSessionManagement_Click(object sender, EventArgs e)
        {
            TrainingSessionManagement form = new TrainingSessionManagement();
            form.Show();
        }

        private void buttonClientManagement_Click(object sender, EventArgs e)
        {
            ClientManagement form = new ClientManagement();
            form.Show();
        }

        private void buttonExerciseManagement_Click(object sender, EventArgs e)
        {
            ExerciseManagement form = new ExerciseManagement();

            form.Show();
        }
    }
}
