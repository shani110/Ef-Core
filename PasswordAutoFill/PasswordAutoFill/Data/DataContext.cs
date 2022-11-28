using Microsoft.EntityFrameworkCore;
using PasswordAutoFill.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordAutoFill.Data
{
    public class DataContext : DbContext
    {
        public DbSet<User> users { get; set; }
        public DbSet<Website> websites { get; set; }
        public DbSet<Credential> credentials { get; set; }

        public DbSet<History> histories { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=SPLHRLAP-1084;Database=autoFillDb;Trusted_Connection=True; ");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // dataseeding

            //modelBuilder.Entity<Credential>().HasData(
                       //new Credential
                       //{
                       //    credentialid=1,
                       //    username = "isa",
                       //    NewPassword = "12345",
                       //    userid = 1,
                       //    websiteid = 2
                       //});
            // shadow property 
            modelBuilder.Entity<Credential>().Property<DateTime>("UpdatedDate");


       }
    }
}

