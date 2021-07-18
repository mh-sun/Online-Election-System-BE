using ElectionSys.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElectionSys.Repository
{
    public class VoterRepo : DatabaseRepo
    {
        public Voter Add(Voter voter)
        {
            DatabaseContext.Voters.Add(voter);
            DatabaseContext.SaveChanges();
            return voter;
        }

        public Voter Edit(Voter voter)
        {
            DatabaseContext.Voters.Update(voter);
            DatabaseContext.SaveChanges();
            return voter;
        }

        public Voter Delete(int id)
        {
            var voter = DatabaseContext.Voters.Find(id);
            if (voter != null)
            {
                DatabaseContext.Voters.Remove(voter);
                DatabaseContext.SaveChanges();
                return voter;
            }
            else
                return voter;
        }


        public bool DeleteAll(String name)
        {
            var voters = from test in DatabaseContext.Voters
                         where test.Name == name
                         select test;
            if (voters != null)
            {
                DatabaseContext.Voters.RemoveRange(voters);
                DatabaseContext.SaveChanges();
                return true;
            }
            else
                return false;
        }

        public Voter[] getAll()
        {
            return DatabaseContext.Voters.ToArray();
        }

    }
}
