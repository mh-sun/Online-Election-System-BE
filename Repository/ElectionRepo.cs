using ElectionSys.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElectionSys.Repository
{
    public class ElectionRepo : DatabaseRepo
    {

        public Election Add(Election election)
        {
            DatabaseContext.Elections.Add(election);
            DatabaseContext.SaveChanges();
            return election;
        }
        public Election Edit(Election election)
        {
            DatabaseContext.Elections.Update(election);
            DatabaseContext.SaveChanges();
            return election;
        }

        public Election Delete(int id)
        {
            var election = DatabaseContext.Elections.Find(id);
            if (election != null)
            {
                DatabaseContext.Elections.Remove(election);
                DatabaseContext.SaveChanges();
                return election;
            }
            else
                return election;
        }



    }
}
