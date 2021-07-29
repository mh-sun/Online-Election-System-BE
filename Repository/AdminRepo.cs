using ElectionSys.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElectionSys.Repository
{
    public class AdminRepo : DatabaseRepo
    {
        public bool Add(Admin admin)
        {
            if (DatabaseContext.Admins.SingleOrDefault(e => e.username == admin.username) == null)
            {
                DatabaseContext.Admins.Add(admin);
                DatabaseContext.SaveChanges();
                return true;
            }
            else return false;
        }

        public bool Edit(Admin admin)
        {
            DatabaseContext.Admins.Update(admin);
            DatabaseContext.SaveChanges();
            return true;
        }

        public bool Delete(String username)
        {
            Admin admin = GetByName(username);
            if (admin != null)
            {
                DatabaseContext.Admins.Remove(admin);
                DatabaseContext.SaveChanges();
                return true;
            }
            else
                return false;
        }

        public Admin GetByName(string username)
        {
            return DatabaseContext.Admins.SingleOrDefault(admin => admin.username == username);
        }

        public Admin GetByID(int id)
        {
            return DatabaseContext.Admins.Find(id);
        }

        public List<Admin> GetAll()
        {
            return DatabaseContext.Admins.ToList();
        }
        public bool CheckInfo(Admin admin)
        {
            Admin searchResult = GetByName(admin.username);
            if (searchResult != null)
            {
                if (searchResult.password == admin.password)
                {
                    return true;
                }
                else return false;
            }
            else return false;
        }

    }
}
