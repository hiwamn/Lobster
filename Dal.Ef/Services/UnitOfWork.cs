using Dal.Ef;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Contract
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IContext context;

        public UnitOfWork(IContext context, IActiveCodeRepository activeCode,IDeviceRepository device
            ,INotificationRepository notification,IUpdateRepository update,IUserRepository user
            ,IProductCategoryRepository productCategory,IProductImageRepository productImage        
            ,IProductRepository product
            ,IImageRepository image , IProvinceRepository province,ICityRepository city,IMarkedProductRepository markedProduct,
            ILastVisitedProductRepository lastVisitedProduct,ISettingRepository settingRepository,IWeatherPointRepository weatherPoint,IKnowledgeRepository knowledge,IKnowledgeImageRepository knowledgeImage)
        {
            this.context = context;
            ActiveCode = activeCode;
            Device = device;
            Notification = notification;
            Update = update;
            User = user;
            ProductCategory = productCategory;
            ProductImage = productImage;
            Product = product;
            Image = image;
            Province = province;
            City = city;
            MarkedProduct = markedProduct;
            LastVisitedProduct = lastVisitedProduct;
            Setting = settingRepository;
            WeatherPoint = weatherPoint;
            Knowledge = knowledge;
            KnowledgeImage = knowledgeImage;
        }

        #region Advertisement

        public IProductCategoryRepository ProductCategory { get; set; }
        public IProductImageRepository ProductImage { get; set; }
        public IProductRepository Product { get; set; }
        public IMarkedProductRepository MarkedProduct { get; set; }
        public ILastVisitedProductRepository LastVisitedProduct { get; set; }
        public ISettingRepository Setting { get; set; }
        public IWeatherPointRepository WeatherPoint { get; set; }
        public IKnowledgeRepository Knowledge { get; set; }
        public IKnowledgeImageRepository KnowledgeImage { get; set; }
        public IImageRepository Image { get; set; }
        public IProvinceRepository Province { get; set; }
        public ICityRepository City { get; set; }
        #endregion

        public IActiveCodeRepository ActiveCode { get; set; }
        public IDeviceRepository Device { get; set; }
        public INotificationRepository Notification { get; set; }
        public IUpdateRepository Update { get; set; }
        public IUserRepository User { get; set; }


        public void Complete()
        {
            context.SaveChanges();
        }
    }
}
