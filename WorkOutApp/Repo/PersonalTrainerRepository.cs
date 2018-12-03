using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkOutApp.DataSet1TableAdapters;
using WorkOutApp.Model;

namespace WorkOutApp.Repo
{
    class PersonalTrainerRepository
    {
        //Default constructor
        public PersonalTrainerRepository()
        {

        }

        public PersonalTrainer GetPersonalTrainerData(int id)
        {
            DataSet1 ds = new DataSet1();
            PersonalTrainerTableAdapter ta = new PersonalTrainerTableAdapter();
            ta.Fill(ds.PersonalTrainer);

            PersonalTrainer ptrainer = new PersonalTrainer(id);

            DataRow[] d = ds.PersonalTrainer.Select("trainer_id = '" + ptrainer.Id + "'");

            foreach (DataRow dr in d)
            {
                ptrainer.Name = dr["name"].ToString();
                ptrainer.Address = dr["address"].ToString();
                if (dr["profilePic"].ToString() != null && dr["profilePic"].ToString() != "")
                {
                    //Getting the img path
                    string[] s = { "\\bin" };
                    string path = Application.StartupPath.Split(s, StringSplitOptions.None)[0];
                    //MessageBox.Show(path);

                    ptrainer.ProfilePic = path + "\\img\\" + dr["profilePic"].ToString();
                }

                
                ptrainer.Email = dr["email"].ToString();
            }

            return ptrainer;
        }

    }
}
