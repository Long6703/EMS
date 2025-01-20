using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EMS.Domain.Entities;

namespace EMS.Persistence.EMSDbContext
{
    public class EMSDBContextSQLServer : DbContext
    {
        public EMSDBContextSQLServer(DbContextOptions<EMSDBContextSQLServer> options) : base(options)
        {
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(EMSDBContextSQLServer).Assembly);
            base.OnModelCreating(modelBuilder);
        }

    }
}
