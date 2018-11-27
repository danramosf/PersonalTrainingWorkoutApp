using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkOutApp
{
    public partial class StartingForm : Form
    {
        public StartingForm()
        {
            InitializeComponent();
        }

        private void btnUserPanel_Click(object sender, EventArgs e)
        {
            Workout_Session workoutSessionForm = new Workout_Session();
            workoutSessionForm.Show();
        }
    }
}
