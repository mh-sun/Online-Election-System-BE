using ElectionSys.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElectionSys.Repository
{
    public class AdminRepo : DatabaseRepo
    {
        public Admin Add(Admin admin)
        {
            DatabaseContext.Admins.Add(admin);
            DatabaseContext.SaveChanges();
            return admin;
        }

        public Admin Edit(Admin admin)
        {
            DatabaseContext.Admins.Update(admin);
            DatabaseContext.SaveChanges();
            return admin;
        }

        public bool Delete(int id)
        {
            var admin = DatabaseContext.Admins.Find(id);
            if (admin != null)
            {
                DatabaseContext.Admins.Remove(admin);
                DatabaseContext.SaveChanges();
                return true;
            }
            else
                return false;
        }


        public bool DeleteAll(String name)
        {
            var admins = from test in DatabaseContext.Admins
                         where test.Name == name
                         select test;
            if (admins != null)
            {
                DatabaseContext.Admins.RemoveRange(admins);
                DatabaseContext.SaveChanges();
                return true;
            }
            else
                return false;
        }
    }
}
