using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
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

            //Load Personal Trainer data
            lblWelcome.Text = "Welcome, " + ptrainer.Name;
            pbPersonalTrainerProfilePic.SizeMode = PictureBoxSizeMode.StretchImage;
            pbPersonalTrainerProfilePic.Image = new Bitmap(ptrainer.ProfilePic, true);

            //Load menu icons
            //Getting the img path
            string[] s = { "\\bin" };
            string path = Application.StartupPath.Split(s, StringSplitOptions.None)[0];
            picMngUsers.SizeMode = PictureBoxSizeMode.StretchImage;
            picMngUsers.Image = new Bitmap(path + "\\img\\users-icon.png");
            picMngExercises.SizeMode = PictureBoxSizeMode.StretchImage;
            picMngExercises.Image = new Bitmap(path + "\\img\\exercises-icon.png");
            picMngDefault.SizeMode = PictureBoxSizeMode.StretchImage;
            picMngDefault.Image = new Bitmap(path + "\\img\\workouts-icon.png");
            picLogout.SizeMode = PictureBoxSizeMode.StretchImage;
            picLogout.Image = new Bitmap(path + "\\img\\logout-icon.png");

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pbPersonalTrainerProfilePic_Click(object sender, EventArgs e)
        {
            //Edit Personal Trainer Profile
            PersonalTrainerEditProfile ptEditProfilePanel = new PersonalTrainerEditProfile();
            ptEditProfilePanel.Show();
            this.Close();
        }

        private void picMngUsers_Click(object sender, EventArgs e)
        {
            //Manage Users
        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {
           
        }

        private void picMngExercises_Click(object sender, EventArgs e)
        {
            //Manage Exercises Panel
            PersonalTrainerManageExercises ptManageExercises = new PersonalTrainerManageExercises();
            ptManageExercises.Show();
            this.Close();
        }

        private void picLogout_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.p_trainer_loggedIn = 0;
            this.Close();
        }
    }
}
