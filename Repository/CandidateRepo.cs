using ElectionSys.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElectionSys.Repository
{
    public class CandidateRepo : DatabaseRepo
    {
        public bool Add(Candidate candidate)
        {
            DatabaseContext.Candidates.Add(candidate);
            DatabaseContext.SaveChanges();
            return true;
        }
        public bool Edit(Candidate candidate)
        {
            DatabaseContext.Candidates.Update(candidate);
            DatabaseContext.SaveChanges();
            return true;
        }

        public bool Delete(int id)
        {
            var candidate = DatabaseContext.Candidates.Find(id);
            if (candidate != null)
            {
                DatabaseContext.Candidates.Remove(candidate);
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

        public List<Candidate> GetByEId(int id)
        {
            return DatabaseContext.Candidates.Where(e => e.e_id == id).ToList();
        }
        public bool DeleteByEId(int eid)
        {
            var cand = DatabaseContext.Candidates.Where(c => c.e_id == eid).ToList();
            if (cand != null)
            {
                DatabaseContext.Candidates.RemoveRange(cand);
                DatabaseContext.SaveChanges();
                return true;
            }
            else return false;
        }
        public bool Vote(int[] ids)
        {
            Candidate cand = DatabaseContext.Candidates.SingleOrDefault(e => e.id == ids[1]);
            Election elect = DatabaseContext.Elections.Find(cand.e_id);

            if (cand != null && elect.freeze_status == "unfreezed" && elect.publish_status == "unpublished")
            {
                Voter voter = DatabaseContext.Voters.Find(ids[0]);
                if (voter != null && voter.voted == "false")
                {
                    cand.vote_count += 1;
                    voter.voted = "true";
                    DatabaseContext.SaveChanges();
                    return true;
                }
                else return false;
            }
            else return false;
        }

    }
}
