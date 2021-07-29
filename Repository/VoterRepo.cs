using ElectionSys.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElectionSys.Repository
{
    public class VoterRepo : DatabaseRepo
    {
        public bool Add(Voter voter)
        {
            
            if (DatabaseContext.Voters.SingleOrDefault(e => e.email == voter.email) == null)
            {
                DatabaseContext.Voters.Add(voter);
                DatabaseContext.SaveChanges();
                return true;
            }
            else return false;
        }

        public bool Edit(Voter voter)
        {
            DatabaseContext.Voters.Update(voter);
            DatabaseContext.SaveChanges();
            return true;
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


        public List<Voter> getAll()
        {
            return DatabaseContext.Voters.ToList();
        }
        public Voter CheckInfo(Voter voter)
        {
            Voter searchResult = DatabaseContext.Voters.Where(e=>e.email == voter.email).FirstOrDefault();
            if (searchResult != null)
            {
                if (searchResult.password == voter.password)
                {
                    return searchResult;
                }
                else return null;
            }
            else return null;
        }

        public Voter GetByID(int id)
        {
            return DatabaseContext.Voters.Find(id);
        }
    }
}
