using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkOutApp
{
    public partial class StartingForm : Form
    {
        public StartingForm()
        {
            InitializeComponent();
        }

        private void btnUserPanel_Click(object sender, EventArgs e)
        {
            UserLogin logUser = new UserLogin();
            logUser.Show();
        }

        private void btnPersonalTrainer_Click(object sender, EventArgs e)
        {
            PersonalTrainerLoginPanel ptLoginPanel = new PersonalTrainerLoginPanel();
            ptLoginPanel.Show();
        }
    }
}
