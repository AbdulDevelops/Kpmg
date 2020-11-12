using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyDemoApp.Models;
using Microsoft.EntityFrameworkCore;

namespace MyDemoApp.Data
{
    public class TestContext: DbContext
    {
        // public TestContext (string connectionString) : base(connectionString) { }
        public TestContext(DbContextOptions<TestContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("User");  
        }

    }
}
