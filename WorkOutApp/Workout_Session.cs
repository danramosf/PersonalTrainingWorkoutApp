using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using WorkOutApp.DataSet1TableAdapters;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkOutApp.Repo;
using WorkOutApp.Model;

namespace WorkOutApp
{
    public partial class Workout_Session : Form
    {
        DataSet1 data;
        performanceTableAdapter pT;
        
        public Workout_Session()
        {
            InitializeComponent();
        }
     
        
        

        
        
      

     

     

        private void buttonStyle1_Click(object sender, EventArgs e)
        {

            userRepo1 repo = new userRepo1();
            user1 userName = repo.GetUserName(Properties.Settings.Default.User);
            data = new DataSet1();
            pT = new performanceTableAdapter();
            pT.Fill(data.performance);
            DataSet1.performanceRow pr = data.performance.NewperformanceRow();
          DateTime today = DateTime.Today ;
            
            pr.user_name = userName.FirstName;
            pr.sets = int.Parse(textBox1.Text);
            pr.reps = int.Parse(textBox2.Text);
            pr.weight = int.Parse(textBox3.Text);
            pr.routine_name = "super gain";
            pr.date = DateTime.Parse(today.ToString("d"));
            pr.complete = true;
                
                

            data.performance.AddperformanceRow(pr);
            
            pT.Update(data.performance);
            

        }

        private void Workout_Session_Load(object sender, EventArgs e)
        {

        }
    }
}
