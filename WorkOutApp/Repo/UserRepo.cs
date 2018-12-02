using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkOutApp.DataSet1TableAdapters;
using WorkOutApp.Model;


namespace WorkOutApp.Repo
{
    class UserRepo
    {
        public UserRepo()
        {

        }

        public User GetUserName(String name)
        {
            DataSet1 ds = new DataSet1();
            UserTableAdapter uT = new UserTableAdapter();
            uT.Fill(ds.User);

            User user = new User(name);

            DataRow[] d = ds.User.Select("username = '" + user.Username + "'");

            foreach (DataRow dr in d)
            {
                user.Username = dr["username"].ToString();
                user.FirstName = dr["firstName"].ToString();
                user.LastName = dr["lastName"].ToString();
                user.Email = dr["email"].ToString();
                user.Phone = int.Parse(dr["telephone"].ToString());
                user.P_trainerId = int.Parse(dr["p_trainerId"].ToString());
                user.Objective = int.Parse(dr["objective"].ToString());

            }

            return user;
        }

    }
}

