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
    public partial class PersonalTrainerManageExercises : Form
    {

        DataSet1 ds;
        exerciseTableAdapter et;

        public PersonalTrainerManageExercises()
        {
            InitializeComponent();
        }

        private void PersonalTrainerManageExercises_Load(object sender, EventArgs e)
        {

            GetData();

            btnDeleteExercise.Enabled = false;

            PersonalTrainerRepository repo = new PersonalTrainerRepository();
            PersonalTrainer ptrainer = repo.GetPersonalTrainerData(Properties.Settings.Default.p_trainer_loggedIn);

            //Load Personal Trainer data
            lblTitle.Text = ptrainer.Name + " - Manage Exercises";
            pbPersonalTrainerProfilePic.SizeMode = PictureBoxSizeMode.StretchImage;
            pbPersonalTrainerProfilePic.Image = new Bitmap(ptrainer.ProfilePic, true);

            //Load Exercises Data
        }

        private void GetData()
        {
            ds = new DataSet1();
            et = new exerciseTableAdapter();
            et.Fill(ds.exercise);

            dataGridView1.DataSource = ds.exercise;

            //Find the row
            DataRow[] d = ds.exercise.Select();

            dataGridView1.Columns.Remove(dataGridView1.Columns[3]);
            DataGridViewImageColumn imageCol = new DataGridViewImageColumn();
            dataGridView1.Columns.Add(imageCol);
            ((DataGridViewImageColumn)dataGridView1.Columns[4]).ImageLayout = DataGridViewImageCellLayout.Stretch;

            string[] s = { "\\bin" };
            string path = Application.StartupPath.Split(s, StringSplitOptions.None)[0];

            int count = 0;
            //Change the dataGridView to display the exercises images.
            foreach (DataRow dr in d)
            {
                dataGridView1.Rows[count].Height = 75;
                Bitmap img = new Bitmap(path + "\\img\\" + dr["icon"].ToString(), true);
                dataGridView1.Rows[count].Cells[4].Value = img;
                
                count++;
            }

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

        private void btnAddExercise_Click(object sender, EventArgs e)
        {
            PersonalTrainerAddExercise ptAddExercise = new PersonalTrainerAddExercise();
            ptAddExercise.Show();
            this.Close();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            btnDeleteExercise.Enabled = true;
        }

        private void btnDeleteExercise_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                DataRow[] d = ds.exercise.Select("Id = '" + row.Cells[0].Value.ToString() + "'");

                foreach (DataRow dr in d)
                {
                    dr.Delete();
                }
            }

            MessageBox.Show("Exercise deleted.");

            //Update the Database
            et.Update(ds.exercise);
        }
    }
}
