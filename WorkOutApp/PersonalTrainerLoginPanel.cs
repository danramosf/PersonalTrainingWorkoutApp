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

namespace WorkOutApp
{
    public partial class PersonalTrainerLoginPanel : Form
    {

        DataSet1 ds;
        PersonalTrainerTableAdapter ptta;

        public PersonalTrainerLoginPanel()
        {
            InitializeComponent();
        }

        private void PersonalTrainerLoginPanel_Load(object sender, EventArgs e)
        {
            ds = new DataSet1();
            ptta = new PersonalTrainerTableAdapter();
            ptta.Fill(ds.PersonalTrainer);

            GetPersonalTrainerAccounts();
        }

        private void GetPersonalTrainerAccounts()
        {
            //Selecting all Personal Trainers from the dataset
            DataRow[] d = ds.PersonalTrainer.Select();
            String strPTrainer;
            foreach(DataRow dr in d)
            {
                strPTrainer = dr["trainer_id"].ToString() + ":  " +  dr["name"].ToString();
                cmbPersonalTrainerAccount.Items.Add(strPTrainer);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(cmbPersonalTrainerAccount.SelectedItem == null || (string)cmbPersonalTrainerAccount.SelectedItem == "")
            {
                errorProvider1.SetError(cmbPersonalTrainerAccount, "Please, select a Personal Trainer account.");
            }
            else
            {
                Properties.Settings.Default.p_trainer_loggedIn = GetIdFromPTrainerString((string)cmbPersonalTrainerAccount.SelectedItem);
                PersonalTrainerPanel ptrainerPanel = new PersonalTrainerPanel();
                ptrainerPanel.Show();
                this.Close();
            }
        }

        // Gets a string in the format "{id}:  {name}" (ex: "1:  john d") and returns the id part (1).
        private int GetIdFromPTrainerString(String str)
        {
            try
            {
                string[] parts = str.Split(':');
                return int.Parse(parts[0]);

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return -1;
            }
        }
    }
}
