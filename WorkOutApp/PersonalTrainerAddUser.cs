using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkOutApp.DataSet1TableAdapters;
using WorkOutApp.Model;
using WorkOutApp.Repo;

namespace WorkOutApp
{
    public partial class PersonalTrainerAddUser : Form
    {

        DataSet1 ds;
        UserTableAdapter ut;

        public PersonalTrainerAddUser()
        {
            InitializeComponent();
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

        private void PersonalTrainerAddUser_Load(object sender, EventArgs e)
        {
            PersonalTrainerRepository repo = new PersonalTrainerRepository();
            PersonalTrainer ptrainer = repo.GetPersonalTrainerData(Properties.Settings.Default.p_trainer_loggedIn);

            //Load Personal Trainer data
            lblTitle.Text = ptrainer.Name + " - Add User";
            pbPersonalTrainerProfilePic.SizeMode = PictureBoxSizeMode.StretchImage;
            pbPersonalTrainerProfilePic.Image = new Bitmap(ptrainer.ProfilePic, true);

            ds = new DataSet1();
            ut = new UserTableAdapter();
            ut.Fill(ds.User);
        }
    }
}
