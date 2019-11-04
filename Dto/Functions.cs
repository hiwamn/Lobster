using Domain.Entities;
using Dto.ReturnDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dto
{
    public class Functions
    {
        public static ProductDto CreateProductDto(Product p, Guid userId)
        {
            List<string> pro = new List<string>();
            if (p.ProductImage != null)
                pro = p.ProductImage.Select(q => q.Image.Location).ToList();
            return new ProductDto
            {
                Id = p.Id,
                Description = p.Description,
                Title = p.Title,
                Images = pro,
                IsImmediate = p.IsImmediate.Value,
                IsSpecial = p.IsSpecial,
                Price = p.Price,
                ProductCategoryId = p.ProductCategoryId,
                Link = p.Link,
                IsAdvertisement = p.IsAdvertisement,
                CityId = p.CityId,
                CityName = p.City.Name,
                IsForSale = p.IsForSale,
                ProvinceId = p.City.Province.Id,
                ProvinceName = p.City.Province.Name,
                IsMarked = p.MarkedProducts.Any(q => q.UserId == userId),
                RegisterDate = p.RegisterDate,
                Mobile = p.User.PhoneNumber,
                IsForExchange = p.IsForExchange
            };
        }
        public static KnowledgeDto CreateKnowledgeDto(Knowledge p)
        {
            List<string> pro = new List<string>();
            if (p.KnowledgeImage != null)
                pro = p.KnowledgeImage.Select(q => q.Image.Location).ToList();
            return new KnowledgeDto
            {
                Id = p.Id,
                Description = p.Description,
                Title = p.Title,
                Images = pro,
                RegisterDate = p.RegisterDate
            };
        }
    }
}
