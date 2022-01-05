using ApiClone.Domain;
using ApiClone.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiClone.Data
{
    public class ApiCloneDBContext : DbContext
    {
        public ApiCloneDBContext(DbContextOptions context) : base(context)
        {

        }

        /*protected override void OnModelCreating(ModelBuilder modelBuilder)
       {
           modelBuilder.Entity<Vehicle>(eb => {
               eb.HasNoKey();
           });
       }*/

        public DbSet<OvirPassports> OvirPassports { get; set; }

        public DbSet<TaxCommiteeInn> TaxCommiteeInns { get; set; }

        public DbSet<CreditorInfo> CreditorInfo { get; set; }
        
        public DbSet<GetPersonCapitalMarketsForApiClone> PersonCapitalMarkets { get; set; }

        public DbSet<Vehicle> Vehicles { get; set; }

        public DbSet<Vladeniya> Vladeniyas { get; set; }

    }
}
