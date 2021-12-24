using ApiClone.Domain;
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

        public DbSet<OvirPassports> passports { get; set; }

    }
}
