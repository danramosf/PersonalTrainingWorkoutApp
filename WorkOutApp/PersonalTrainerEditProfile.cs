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
    public partial class PersonalTrainerEditProfile : Form
    {
        DataSet1 ds;
        PersonalTrainerTableAdapter pt;

        public PersonalTrainerEditProfile()
        {
            InitializeComponent();
        }

        private void PersonalTrainerEditProfile_Load(object sender, EventArgs e)
        {
            ds = new DataSet1();
            pt = new PersonalTrainerTableAdapter();

            pt.Fill(ds.PersonalTrainer);

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

        private void btnSaveProfile_Click(object sender, EventArgs e)
        {
            if (CheckAllRequiredFields() == 0)
            {
                //Create a new movie row
                DataSet1.PersonalTrainerRow ptr = ds.PersonalTrainer.NewPersonalTrainerRow();

                //Find the row
                DataRow[] d = ds.PersonalTrainer.Select("trainer_id ='" + Properties.Settings.Default.p_trainer_loggedIn.ToString() + "'");

                //Update the data row values
                foreach (DataRow dr in d)
                {
                    dr["name"] = txtProfileName.Text;
                    dr["address"] = txtProfileAddress.Text;
                    dr["email"] = txtProfileEmail.Text;
                }

                //Save into DB
                pt.Update(ds.PersonalTrainer);
                
                MessageBox.Show("Profile Saved!");
                PersonalTrainerPanel ptPanel = new PersonalTrainerPanel();
                ptPanel.Show();
                this.Close();
            }
        }

        private int CheckAllRequiredFields()
        {
            if(txtProfileName.Text == "")
            {
                errorProvider1.SetError(txtProfileName, "This field is required.");
                return -1;
            }

            if(txtProfileEmail.Text == "")
            {
                errorProvider1.SetError(txtProfileEmail, "This field is required.");
                return -1;
            }

            return 0;

        }
    }
}
