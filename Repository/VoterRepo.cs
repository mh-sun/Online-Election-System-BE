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

        public Voter Update(Voter voter)
        {
            DatabaseContext.Voters.Update(voter);
            DatabaseContext.SaveChanges();
            return voter;
        }

        public void Delete(int id)
        {
            DatabaseContext.Voters.Remove(GetById(id));
            DatabaseContext.SaveChanges();

        }

        public Voter GetById(int id)
        {
            return DatabaseContext.Voters.SingleOrDefault(voter => voter.Id == id);
        }

    }
}
