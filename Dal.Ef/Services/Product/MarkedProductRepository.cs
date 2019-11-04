using Domain.Contract;
using Domain.Entities;
using Dto;
using Dto.ReturnDto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dal.Ef.Services
{
    public class MarkedProductRepository : Repository<MarkedProduct>, IMarkedProductRepository
    {
        private readonly IContext ctx;

        public MarkedProductRepository(IContext ctx):base(ctx as DbContext)
        {
            this.ctx = ctx;
        }

        public List<ProductDto> GetByUserId(int Skip, int Count, Guid userId)
        {
            var result = QueryDb(Skip, Count, userId);
            return result.Select(p => Functions.CreateProductDto(p.Product,userId)).ToList();
        }       
        private List<MarkedProduct> QueryDb(int Skip, int Count, Guid userId)
        {
            return ctx.MarkedProduct.Where(p => p.UserId == userId).
                     OrderBy(p => p.RegisterDate).
                     Skip((Skip - 1) * Count).
                     Take(Count).
                     Include(p => p.Product).ThenInclude(q => q.ProductImage).ThenInclude(t => t.Image).                    
                     Include(p => p.Product).ThenInclude(q => q.City).ThenInclude(t => t.Province).
                     Include(p => p.Product).ThenInclude(p => p.User).ToList();
        }       
        public MarkedProduct GetByUserAndProduct(Guid userId, Guid productId)
        {
            return ctx.MarkedProduct.FirstOrDefault(p=>p.UserId == userId && p.ProductId == productId);
        }
        public List<MarkedProduct> GetById(Guid guid)
        {
            return ctx.MarkedProduct.Where(p=>true).OrderBy(p => p.RegisterDate).
                     Skip((1 - 1) * 5).
                     Take(5).
                     Include(p => p.Product).ThenInclude(q => q.City).ThenInclude(t=>t.Province)
                .Include(p => p.Product).ThenInclude(q => q.ProductImage).ThenInclude(t => t.Image).ToList();
        }
    }
}
