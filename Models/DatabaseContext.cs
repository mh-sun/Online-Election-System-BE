using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ElectionSys.Models
{
    public class DatabaseContext : DbContext
    {
        public const string ConnectionString = @"Server=ASUS; Database=ElectionDB; Trusted_Connection=true";

        public DbSet<Voter> Voters { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Candidate> Candidates { get; set; }
        public DbSet<Election> Elections { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }
    }
}
