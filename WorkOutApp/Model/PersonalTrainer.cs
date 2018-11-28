using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkOutApp.Model
{
    class PersonalTrainer
    {
        private int id;
        private String name;
        private String address;
        private String profilePic;
        private String email;

        public PersonalTrainer(int id)
        {
            this.Id = id;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public string ProfilePic { get => profilePic; set => profilePic = value; }
        public string Email { get => email; set => email = value; }

        public override string ToString()
        {
            String output = "";

            output += base.ToString();
            output += " >> Id: " + this.Id;
            output += " >> Name: " + this.Name;
            output += " >> Address: " + this.Address;
            output += " >> Email: " + this.Email;

            return output;
        }
    }
}
