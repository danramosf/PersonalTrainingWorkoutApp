using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkOutApp.Model;
using WorkOutApp.Repo;

namespace WorkOutApp
{
    public partial class PersonalTrainerPanel : Form
    {
        public PersonalTrainerPanel()
        {
            InitializeComponent();
        }

        private void PersonalTrainerPanel_Load(object sender, EventArgs e)
        {
            PersonalTrainerRepository repo = new PersonalTrainerRepository();
            PersonalTrainer ptrainer = repo.GetPersonalTrainerData(Properties.Settings.Default.p_trainer_loggedIn);
            
            lblWelcome.Text = "Welcome, " + ptrainer.Name;
            MessageBox.Show(ptrainer.ToString());
        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }
    }
}
