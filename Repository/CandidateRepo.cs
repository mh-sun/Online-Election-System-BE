using ElectionSys.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElectionSys.Repository
{
    public class CandidateRepo : DatabaseRepo
    {
        public Candidate Add(Candidate candidate)
        {
            DatabaseContext.Candidates.Add(candidate);
            DatabaseContext.SaveChanges();
            return candidate;
        }
        public Candidate Edit(Candidate candidate)
        {
            DatabaseContext.Candidates.Update(candidate);
            DatabaseContext.SaveChanges();
            return candidate;
        }

        public Candidate Delete(int id)
        {
            var candidate = DatabaseContext.Candidates.Find(id);
            if (candidate != null)
            {
                DatabaseContext.Candidates.Remove(candidate);
                DatabaseContext.SaveChanges();
                return candidate;
            }
            else
                return candidate;
        }


        public bool DeleteAll(String name)
        {
            var candidate = from test in DatabaseContext.Candidates
                         where test.Name == name
                         select test;
            if (candidate != null)
            {
                DatabaseContext.Candidates.RemoveRange(candidate);
                DatabaseContext.SaveChanges();
                return true;
            }
            else
                return false;
        }

        public List<Candidate> GetAll()
        {
            return DatabaseContext.Candidates.ToList();
        }

    }
}
