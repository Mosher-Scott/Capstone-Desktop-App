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
    public partial class ExerciseManagement : Form
    {
        public ExerciseManagement()
        {
            InitializeComponent();
        }

        private void buttonAddNewExercise_Click(object sender, EventArgs e)
        {
            CreateNewExercise form = new CreateNewExercise();
            form.Show();
        }
    }
}
