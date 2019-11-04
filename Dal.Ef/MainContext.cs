using Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Dal.Ef
{
    public class MainContext : IdentityDbContext<User, Role, Guid>, IContext
    {
        public IConfiguration Configuration { get; }

        #region Advertisement
        public DbSet<Product> Product { get; set; }
        public DbSet<ProductCategory> ProductCategory { get; set; }
        public DbSet<ProductImage> ProductImage { get; set; }
        public DbSet<MarkedProduct> MarkedProduct { get; set; }
        public DbSet<LastVisitedProduct> LastVisitedProduct { get; set; }

        public DbSet<Province> Province { get; set; }
        public DbSet<City> City { get; set; }

        public DbSet<Image> Image { get; set; }
        #endregion
        public DbSet<ActiveCode> ActiveCode { get; set; }
        public DbSet<Device> Device { get; set; }
        public DbSet<Notification> Notification { get; set; }
        public new DbSet<Update> Update { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Setting> Setting { get; set; }
        public DbSet<WeatherPoint> WeatherPoint { get; set; }
        public DbSet<Knowledge> Knowledge { get; set; }
        public DbSet<KnowledgeImage> KnowledgeImage { get; set; }

        public MainContext(DbContextOptions<MainContext> options) : base(options)
        {

        }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    //optionsBuilder.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"), b => b.MigrationsAssembly("MobileEndpoint")/*, sqlServerOptions => sqlServerOptions.CommandTimeout(600)*/);

        //}

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            var typesToRegister = Assembly.GetExecutingAssembly().GetTypes()
                         .Where(t => t.GetInterfaces().Any(gi => gi.IsGenericType && gi.GetGenericTypeDefinition() == typeof(IEntityTypeConfiguration<>))).ToList();

            foreach (var type in typesToRegister)
            {
                dynamic configurationInstance = Activator.CreateInstance(type);
                builder.ApplyConfiguration(configurationInstance);
            }

            builder.Entity<User>().ToTable("xUser");
            builder.Entity<Role>().ToTable("xRole");
            builder.Entity<IdentityRoleClaim<Guid>>().ToTable("xRoleClaim");
            builder.Entity<IdentityUserClaim<Guid>>().ToTable("xUserClaim");
            builder.Entity<IdentityUserLogin<Guid>>().ToTable("xUserLogin");
            builder.Entity<IdentityUserRole< Guid>>().ToTable("xUserRole");
            builder.Entity<IdentityUserToken<Guid>>().ToTable("xUserToken");
            builder.Entity<IdentityUserLogin<Guid>>().HasKey(p => p.UserId);
            builder.Entity<IdentityUserRole< Guid>>().HasKey(p => new { p.UserId, p.RoleId });
            builder.Entity<IdentityUserToken<Guid>>().HasKey(p => new { p.UserId });

            builder.Entity<ProductCategory>()
                .HasData(
                new ProductCategory { Id = 1, Name = "همه" },
                new ProductCategory { Id = 2, Name = "کوهنوردی" },
                new ProductCategory { Id = 3, Name = "طبیعت گردی" },
                new ProductCategory { Id = 4, Name = "سنگنوردی" },
                new ProductCategory { Id = 5, Name = "غار نوردی" },
                new ProductCategory { Id = 6, Name = "یخ نوردی" },
                new ProductCategory { Id = 7, Name = "دیواره نوردی" }
                        );
            builder.Entity<Role>().HasData(new Role {Id =Guid.NewGuid() , ConcurrencyStamp = " ", Name = "Mobile", No = 1, NormalizedName = "Mobile User" });
            builder.Entity<Role>().HasData(new Role { Id = Guid.NewGuid(), ConcurrencyStamp = " ", Name = "Admin", No = 2, NormalizedName = "General Manager" });
            builder.Entity<Role>().HasData(new Role { Id = Guid.NewGuid(), ConcurrencyStamp = " ", Name = "Panel", No = 3, NormalizedName = "Panel User" });


            builder.Entity<Setting>().HasData(
                new Setting { Id = 1 , Name = "AdNo", Value = "10",Description = "تعداد آگهی های تبلیغاتی"},
                new Setting { Id = 2 , Name = "AdDelay", Value = "2",Description = "تاخیر اسلاید به ثانیه"},
                new Setting { Id = 3 , Name = "SpecialNo", Value = "30",Description = "تعداد آگهی های ویژه"},
                new Setting { Id = 4 , Name = "SpecialNumberOfDays", Value = "10",Description = "تعداد روز آگهی های ویژه"},
                new Setting { Id = 5 , Name = "ImmediateNo", Value = "1000000",Description = "تعداد آگهی های فوری"},
                new Setting { Id = 6 , Name = "ImmediateNumberOfDays", Value = "30",Description = "تعداد روز آگهی های فوری" },
                new Setting { Id = 7 , Name = "SimplePrice", Value = "0",Description = "قیمت آگهی معمولی"},
                new Setting { Id = 8 , Name = "ImmediatePrice", Value = "5",Description = "قیمت آگهی فوری"},
                new Setting { Id = 9 , Name = "SpecialPrice", Value = "10",Description = "قیمت آگهی ویژه"},
                new Setting { Id = 10 , Name = "AdPrice", Value = "50",Description = "قیمت آگهی تبلیغاتی"}
                );


        }

        void IContext.SaveChanges()
        {
            SaveChanges();
        }
    }
}
