using Microsoft.EntityFrameworkCore;
using RestAPI.Domain.Entities;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace RestAPI.Infrastructure.Configuration
{
    public class SqlContext : DbContext
    {
        public SqlContext(DbContextOptions<SqlContext> options): base(options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Client> Clients { get; set; }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("SignupDate") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("SignupDate").CurrentValue = DateTime.Now;
                }
                if (entry.State == EntityState.Modified)
                {
                    entry.Property("SignupDate").IsModified = false;
                }

            }

            return base.SaveChanges();
        }
    }
}
