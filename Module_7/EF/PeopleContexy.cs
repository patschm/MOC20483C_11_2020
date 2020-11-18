using EF.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EF
{
    public class PeopleContext : DbContext
    {
        public PeopleContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Person> People { get; set; }
        public DbSet<Address> Addresses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var paMeta = modelBuilder.Entity<PersonAddress>();
            paMeta.HasKey(pa => new { pa.AddressID, pa.PersonID });
        }
    }
}
