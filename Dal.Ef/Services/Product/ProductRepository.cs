using Domain.Contract;
using Domain.Entities;
using Dto;
using Dto.DeviceDto;
using Dto.ReturnDto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utility;
using Utility.SiteConstants;

namespace Dal.Ef.Services
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private readonly IContext ctx;

        public ProductRepository(IContext ctx) : base(ctx as DbContext)
        {
            this.ctx = ctx;
        }
        public List<ProductDto> GetByDetail(int Skip, int Count, GetTopProductDto dto)
        {
            var result = QueryDb(Skip, Count, dto);
            return result.Select(p => Functions.CreateProductDto(p, dto.UserId)).ToList();
        }

        private List<Product> QueryDb(int Skip, int Count, GetTopProductDto dto)
        {
            bool condition = dto.IsImmediate == null && dto.IsSpecial == null && dto.ProductCategoryId == null && dto.IsAdvertisement == null;
            return ctx.Product.Where(p =>
                    (!dto.IsSpecial.HasValue || p.IsSpecial.Value == dto.IsSpecial.Value)
                     &&
                     (!dto.IsImmediate.HasValue || p.IsImmediate.Value == dto.IsImmediate.Value)
                     &&
                     (!dto.ProductCategoryId.HasValue || dto.ProductCategoryId.Value == 1 || p.ProductCategoryId == dto.ProductCategoryId.Value)
                     &&
                     (!dto.IsAdvertisement.HasValue || p.IsAdvertisement.Value == dto.IsAdvertisement.Value)).
                     OrderBy(p => p.RegisterDate).
                     Skip((Skip - 1) * Count).
                     Take(Count).
                     Include(p => p.ProductImage).ThenInclude(q => q.Image).
                     Include(p=>p.City).ThenInclude(q=>q.Province).Include(p=>p.MarkedProducts).
                     Include(p=>p.User).ToList();
        }        
        public ProductDto GetById(Guid productId,Guid UserId)
        {
            var pro = ctx.Product.Include(p => p.ProductImage).ThenInclude(q => q.Image).
                     Include(p => p.City).ThenInclude(q => q.Province).Include(p => p.MarkedProducts).
                     Include(p => p.User).FirstOrDefault(p=>p.Id == productId);
            return Functions.CreateProductDto(pro, UserId);
        }

        public List<ProductDto> GetMyProduct(int blockNumber, int Count, Guid userId)
        {
            return ctx.Product.Include(p => p.ProductImage).ThenInclude(q => q.Image).
                     Include(p => p.City).ThenInclude(q => q.Province).Include(p => p.MarkedProducts).
                     Include(p => p.User).Where(p => p.UserId== userId).
                     Skip((blockNumber - 1) * Count).
                     Take(Count).ToList().Select(q=> Functions.CreateProductDto(q, userId)).ToList();
            
        }
    }
}
