﻿using ApiClone.Domain;
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
        

        public DbSet<OvirPassports> OvirPassports { get; set; }

        public DbSet<TaxCommiteeInn> TaxCommiteeInns { get; set; }

        public DbSet<CreditorInfo> CreditorInfo { get; set; }
        
        public DbSet<GetPersonCapitalMarketsForApiClone> PersonCapitalMarkets { get; set; }

        public DbSet<Dataa> PersonHigherEducation { get; set; }

        public DbSet<GetPersonIdWithPinFLForApiClone> getPersonIdWithPinFL { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GetPersonIdWithPinFLForApiClone>(
                eb =>
                {
                    eb.HasNoKey();
                });
            modelBuilder.Entity<Dataa>(
                eb =>
                {
                    eb.HasNoKey();
                });
        }
    }
}
