using GymSystemManagement.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System.Net;

namespace GymSystemManagement.Context
{
    public class GymDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;Database=GymSystemManagement;Trusted_Connection=true;TrustServerCertificate=true");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder) //Fluent API
        {

        }

            #region DbSets

            public DbSet<Trainer> Trainer { get; set; }
            public DbSet<Member> Member { get; set; }
            public DbSet<Session> Session { get; set; }
            public DbSet<Plan> Plan { get; set; }
            public DbSet<MemberShip> MemberShip { get; set; }
            #endregion
        }
}

