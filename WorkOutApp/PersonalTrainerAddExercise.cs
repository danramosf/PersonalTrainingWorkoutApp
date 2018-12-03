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
    public partial class PersonalTrainerAddExercise : Form
    {
        DataSet1 ds;
        exerciseTableAdapter et;

        public PersonalTrainerAddExercise()
        {
            InitializeComponent();
        }

        private void PersonalTrainerAddExercise_Load(object sender, EventArgs e)
        {
            ds = new DataSet1();
            et = new exerciseTableAdapter();
            et.Fill(ds.exercise);

            PersonalTrainerRepository repo = new PersonalTrainerRepository();
            PersonalTrainer ptrainer = repo.GetPersonalTrainerData(Properties.Settings.Default.p_trainer_loggedIn);

            //Load Personal Trainer data
            lblTitle.Text = ptrainer.Name + " - Add Exercise";
            pbPersonalTrainerProfilePic.SizeMode = PictureBoxSizeMode.StretchImage;
            pbPersonalTrainerProfilePic.Image = new Bitmap(ptrainer.ProfilePic, true);
        }

        private void lblMainMenu_Click_1(object sender, EventArgs e)
        {
            PersonalTrainerPanel ptPanel = new PersonalTrainerPanel();
            ptPanel.Show();
            this.Close();
        }

        private void pbPersonalTrainerProfilePic_Click_1(object sender, EventArgs e)
        {
            //Edit Personal Trainer Profile
            PersonalTrainerEditProfile ptEditProfilePanel = new PersonalTrainerEditProfile();
            ptEditProfilePanel.Show();
            this.Close();
        }

        private void btnSaveExercise_Click(object sender, EventArgs e)
        {
            //Insert Exercise
            if (CheckAllRequiredFields() == 0)
            {
                //Create a new movie row
                DataSet1.exerciseRow er = ds.exercise.NewexerciseRow();

                //Insert data into this row in the dataset
                er.name = txtExerciseName.Text;
                er.muscle = txtMuscle.Text;
                er.icon = txtIcon.Text;
                er.description = richTextDescription.Text;

                //Add this row to the DataSet
                ds.exercise.AddexerciseRow(er);

                //Save into DB
                et.Update(ds.exercise);

                MessageBox.Show("Exercise Saved!");
                PersonalTrainerManageExercises ptManageEx = new PersonalTrainerManageExercises();
                ptManageEx.Show();
                this.Close();
            }
        }

        private int CheckAllRequiredFields()
        {
            if(txtExerciseName.Text == "")
            {
                errorProvider1.SetError(txtExerciseName, "This field is required.");
                return -1;
            }

            if(txtMuscle.Text == "")
            {
                errorProvider1.SetError(txtMuscle, "This field is required.");
                return -1;
            }

            return 0;
        }
    }
}
