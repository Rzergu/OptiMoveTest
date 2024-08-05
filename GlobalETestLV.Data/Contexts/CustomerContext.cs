using System;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using System.Diagnostics;
using GlobalETestLV.Core.Entities;
using Microsoft.Extensions.DependencyInjection;

namespace GlobalETestLV.Data.Contexts
{
    public class CustomerContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<TimerItem> TimersItems { get; set; }
        public DbSet<TimerFilter> TimersFilters { get; set; }
        public DbSet<Template> Templates { get; set; }
        public DbSet<SendedRow> SendedRows { get; set; }


        public CustomerContext(DbContextOptions<CustomerContext> options) : base(options)
        {
        }

        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}

