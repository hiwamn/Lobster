using Domain.Contract;
using Domain.Entities;
using Dto.DeviceDto;
using System;
using System.Collections.Generic;
using System.Text;
using Utility;

namespace ApplicationServices
{
    public class RegisterProduct : IRegisterProduct
    {
        private readonly IUnitOfWork unit;

        public RegisterProduct(IUnitOfWork unit)
        {
            this.unit = unit;
        }

        public string Execute(RegisterProductDto dto)
        {
            List<ProductImage> images = new List<ProductImage>();
            dto.Images.ForEach(p=> {
                images.Add(new ProductImage { ImageId = p,RegisterDate = DateTime.Now.ToUnix()});
            });
            Product pr = new Product
            {
                Description = dto.Description,
                RegisterDate = DateTime.Now.ToUnix(),
                Title = dto.Title,
                UserId = dto.UserId,
                IsImmediate = dto.IsImmediate,
                IsSpecial = dto.IsSpecial,
                Price = dto.Price,
                ProductCategoryId = dto.ProductCategoryId,
                IsAdvertisement = dto.IsAdvertisement,
                Link = dto.Link,
                CityId = dto.CityId,
                IsForSale = dto.IsForSale,
                IsForExchange = dto.IsForExchange,
                ProductImage = images
            };
            unit.Product.Add(pr);
            unit.Complete();
            string result = Api.ToJson(new { pr.Id});
            return result;
        }
    }
}
