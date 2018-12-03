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
    public partial class PersonalTrainerEditProfile : Form
    {
        public PersonalTrainerEditProfile()
        {
            InitializeComponent();
        }

        private void PersonalTrainerEditProfile_Load(object sender, EventArgs e)
        {
            PersonalTrainerRepository repo = new PersonalTrainerRepository();
            PersonalTrainer ptrainer = repo.GetPersonalTrainerData(Properties.Settings.Default.p_trainer_loggedIn);

            //Load Personal Trainer data
            lblProfile.Text = "Edit Profile - " + ptrainer.Name;
            pbPersonalTrainerProfilePic.SizeMode = PictureBoxSizeMode.StretchImage;
            pbPersonalTrainerProfilePic.Image = new Bitmap(ptrainer.ProfilePic, true);
            picProfileImg.SizeMode = PictureBoxSizeMode.StretchImage;
            picProfileImg.Image = new Bitmap(ptrainer.ProfilePic, true);
            //Form Data
            txtProfileName.Text = ptrainer.Name;
            txtProfileAddress.Text = ptrainer.Address;
            txtProfileEmail.Text = ptrainer.Email;
        }

        private void lblMainMenu_Click(object sender, EventArgs e)
        {
            PersonalTrainerPanel ptPanel = new PersonalTrainerPanel();
            ptPanel.Show();
            this.Close();
        }

        private void pbPersonalTrainerProfilePic_Click(object sender, EventArgs e)
        {
            //Edit Personal Trainer Profile
            PersonalTrainerEditProfile ptEditProfilePanel = new PersonalTrainerEditProfile();
            ptEditProfilePanel.Show();
            this.Close();
        }
    }
}
