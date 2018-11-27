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
    public partial class Workout_Session : Form
    {
        public Workout_Session()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
                List<Button> buttons = new List<Button>();
                for (int i = 0; i < 10; i++)
                {
                    Button newButton = new Button();
                    buttons.Add(newButton);
                    this.Controls.Add(newButton);
                }
            
        }
    }
}
