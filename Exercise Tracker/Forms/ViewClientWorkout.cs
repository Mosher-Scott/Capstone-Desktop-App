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
    public partial class ViewClientWorkout : Form
    {
        public ViewClientWorkout(int clientId, int workoutId)
        {
            InitializeComponent();

            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;


        }

        private void ViewClientWorkout_Load(object sender, EventArgs e)
        {

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
