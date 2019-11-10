using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.IdentityModel.Protocols;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Identity;
using System.Reflection;

namespace AuthenticationService.Data
{
    public class SqlContext : DbContext,ISqlContext
    {
        public IConfiguration Configuration { get; }
        public SqlContext(DbContextOptions<SqlContext> options, IConfiguration Configuration)
            : base(options)
        {
            this.Configuration = Configuration;
            //this.Database.EnsureCreated();
            //ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"), b => b.MigrationsAssembly("AuthenticationService"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            

        }

        public void SaveChange()
        {
           SaveChanges();
        }

        public DbSet<User> User{ get; set; }

    }
}
