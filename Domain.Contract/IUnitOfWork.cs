using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Contract
{
    public interface IUnitOfWork
    {
        #region Advertisement

        IProductCategoryRepository ProductCategory { get; set; }
        IProductImageRepository ProductImage { get; set; }
        IProductRepository Product { get; set; }
        IMarkedProductRepository MarkedProduct { get; set; } 
        ILastVisitedProductRepository LastVisitedProduct { get; set; } 
        ISettingRepository Setting { get; set; } 
        IWeatherPointRepository WeatherPoint { get; set; } 

        IProvinceRepository Province { get; set; }
        ICityRepository City { get; set; }
        IKnowledgeRepository Knowledge { get; set; }
        IKnowledgeImageRepository KnowledgeImage { get; set; }



        IImageRepository Image { get; set; }
        #endregion

        IActiveCodeRepository ActiveCode { get; set; }
        IDeviceRepository Device{ get; set; }
        INotificationRepository Notification{ get; set; }
        IUpdateRepository Update{ get; set; }
        IUserRepository User{ get; set; }

        void Complete();
    }
}
