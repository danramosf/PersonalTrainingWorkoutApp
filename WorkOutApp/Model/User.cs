using System;

namespace WorkOutApp.Model
{
    class User
    {

        private String username;
        private String firstName;
        private String lastName;
        private String email;
        private int phone;
        private int p_trainerId;
        private int objective;

        public User(string username)
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

     

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
