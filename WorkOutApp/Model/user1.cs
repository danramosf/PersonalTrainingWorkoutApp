using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkOutApp.DataSet1TableAdapters;
using WorkOutApp.Model;



namespace WorkOutApp.Model
{
    class user1
    {

        private String username;
        private String firstName;
        private String lastName;
        private String email;
        private int phone;
        private int p_trainerId;
        private int objective;

        public user1(string username)
        {
            this.username = username;
        }

        public string Username { get => username; set => username = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Email { get => email; set => email = value; }
        public int Phone { get => phone; set => phone = value; }
        public int P_trainerId { get => p_trainerId; set => p_trainerId = value; }
        public int Objective { get => objective; set => objective = value; }


        /*
        public override string ToString()
        {
            String output = "";

            output += base.ToString();
            output += " >> username: " + this.Username;
            output += " >> firstname: " + this.FirstName;
            output += " >> lastname: " + this.LastName;
            output += " >> Email: " + this.Email;
            output += " >> Phone: " + this.Phone;
            output += " >> trainer id: " + this.P_trainerId;
            output += " >> Objective: " + this.Objective;


            return output;
          
        }
        */
    }
}
