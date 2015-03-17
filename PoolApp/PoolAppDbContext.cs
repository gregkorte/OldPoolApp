using PoolApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PoolApp
{
    public class PoolAppDbContext : DbContext
    {
        public PoolAppDbContext(string connection="PoolApp.PoolAppDbContext") : base(connection)
        {

        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Service> Services { get; set; }
    }
}