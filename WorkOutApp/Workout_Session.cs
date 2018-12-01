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


namespace WorkOutApp
{
    public partial class Workout_Session : Form
    {
        DataSet1 data;
        preformanceTableAdapter pT;
        
        public Workout_Session()
        {
            InitializeComponent();
        }
     
        
        

        
        
      

     

     

        private void buttonStyle1_Click(object sender, EventArgs e)
        {
            data = new DataSet1();
            pT = new preformanceTableAdapter();
            pT.Fill(data.preformance);
            DataSet1.preformanceRow pr = data.preformance.NewpreformanceRow();
          DateTime today = DateTime.Today ;
            
            pr.user_name = "rest";
            pr.sets = int.Parse(textBox1.Text);
            pr.reps = int.Parse(textBox2.Text);
            pr.weigth = int.Parse(textBox3.Text);
            pr.rutine_name = "super gain";
            pr.date = DateTime.Parse(today.ToString("d"));
            pr.complete = true;
                
                

            data.preformance.AddpreformanceRow(pr);
            
            pT.Update(data.preformance);
            

        }
    }
}
