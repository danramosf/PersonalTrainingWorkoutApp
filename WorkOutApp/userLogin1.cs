﻿using System;
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
    public partial class userLogin1 : Form
    {



        DataSet1 ds;
        UserTableAdapter uT;

        public userLogin1()
        {
            InitializeComponent();
        }

        private void PersonalTrainerLoginPanel_Load(object sender, EventArgs e)
        {
            ds = new DataSet1();
            uT = new UserTableAdapter();

            uT.Fill(ds.User);


            GetUserAccounts();
        }
        private void GetUserAccounts()
        {
            //Selecting all Personal Trainers from the dataset
            DataRow[] d = ds.User.Select();
            String strUser;
            foreach (DataRow dr in d)
            {
                strUser = dr["username"].ToString();
                cmbPersonalTrainerAccount.Items.Add(strUser);
            }
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (cmbPersonalTrainerAccount.SelectedItem == null || (string)cmbPersonalTrainerAccount.SelectedItem == "")
            {
                errorProvider1.SetError(cmbPersonalTrainerAccount, "Please, select a Personal Trainer account.");
            }
            else
            {
                Properties.Settings.Default.User = (string)cmbPersonalTrainerAccount.SelectedItem;
                Workout_Session workout = new Workout_Session();
                workout.Show();
                this.Close();
            }
        }

        
    }
}