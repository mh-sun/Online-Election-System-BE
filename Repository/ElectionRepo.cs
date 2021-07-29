using ElectionSys.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElectionSys.Repository
{
    public class ElectionRepo : DatabaseRepo
    {

        public bool Add(Election election)
        {
            DatabaseContext.Elections.Add(election);
            DatabaseContext.SaveChanges();
            return true;
        }
        public bool Edit(Election election)
        {
            DatabaseContext.Elections.Update(election);
            DatabaseContext.SaveChanges();
            return true;
        }

        public bool Delete(int id)
        {
            var election = DatabaseContext.Elections.Find(id);
            if (election != null)
            {
                DatabaseContext.Elections.Remove(election);
                DatabaseContext.SaveChanges();
                return true;
            }
            else
                return false;
        }

        public List<Election> GetAll()
        {
            return DatabaseContext.Elections.ToList();
        }

        public Election Get(int id)
        {
            return DatabaseContext.Elections.Find(id);
        }

        public bool changeFreezeState(int eid)
        {
            var elect = DatabaseContext.Elections.Find(eid);
            if (elect == null) return false;
            else
            {
                if (elect.freeze_status == "freezed")
                {
                    elect.freeze_status = "unfreezed";
                }
                else elect.freeze_status = "freezed";
                DatabaseContext.SaveChanges();
                return true;
            }
        }

        public Election changePublishState(int eid)
        {
            var elect = DatabaseContext.Elections.Find(eid);
            List<Candidate> cand = DatabaseContext.Candidates.Where(e => e.e_id == eid).ToList();
            if (elect == null || cand.Count == 0) return elect;
            else
            {
                if (elect.publish_status == "unpublished")
                {
                    elect.publish_status = "published";
                }

                Candidate winner = cand[0];
                for (int i = 1; i < cand.Count; i++)
                {
                    Candidate temp = cand[i];
                    if(winner.vote_count < temp.vote_count)
                    {
                        winner = temp;
                    }
                }
                elect.winner = winner.name;
                elect.c_id = winner.id;

                DatabaseContext.Candidates.RemoveRange(cand);

                var voters = DatabaseContext.Voters.ToList();
                for (int i = 0; i < voters.Count; i++)
                {
                    Voter v = voters[i];
                    v.voted = "false";
                }
                
                DatabaseContext.SaveChanges();
                return elect;
            }
            
        }

    }
}
