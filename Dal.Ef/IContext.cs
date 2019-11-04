using Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dal.Ef
{
    public interface IContext
    {
        #region Advertisement
        DbSet<Product> Product { get; set; }
        DbSet<ProductCategory> ProductCategory { get; set; }
        DbSet<ProductImage> ProductImage { get; set; }
        DbSet<MarkedProduct> MarkedProduct { get; set; }
        DbSet<LastVisitedProduct> LastVisitedProduct { get; set; }

        DbSet<Province> Province { get; set; }
        DbSet<City> City { get; set; }


        DbSet<Image> Image { get; set; }
        #endregion
        DbSet<ActiveCode> ActiveCode { get; set; }
        DbSet<Device> Device { get; set; }
        DbSet<Notification> Notification { get; set; }
        DbSet<Update> Update { get; set; }
        DbSet<User> User { get; set; }
        DbSet<Setting> Setting { get; set; }
        DbSet<WeatherPoint> WeatherPoint { get; set; }
        DbSet<Knowledge> Knowledge { get; set; }
        DbSet<KnowledgeImage> KnowledgeImage { get; set; }

        void SaveChanges();
    }
}
