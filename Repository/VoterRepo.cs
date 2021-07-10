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
    }
}
