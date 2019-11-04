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
    public class LastVisitedProductRepository : Repository<LastVisitedProduct>, ILastVisitedProductRepository
    {
        private readonly IContext ctx;

        public LastVisitedProductRepository(IContext ctx):base(ctx as DbContext)
        {
            this.ctx = ctx;
        }

        public List<ProductDto> GetByUserId(int Skip, int Count, Guid userId)
        {
            var result = QueryDb(Skip, Count, userId);
            return result.Select(p => Functions.CreateProductDto(p.Product,userId)).ToList();
        }


        private List<LastVisitedProduct> QueryDb(int Skip, int Count, Guid userId)
        {
            return ctx.LastVisitedProduct.Where(p => p.UserId == userId).
                     OrderBy(p => p.RegisterDate).
                     Skip((Skip - 1) * Count).
                     Take(Count).
                     Include(p => p.Product).ThenInclude(q => q.ProductImage).ThenInclude(t => t.Image).
                     Include(p => p.Product).ThenInclude(q => q.City).ThenInclude(t => t.Province).
                     Include(p => p.Product).ThenInclude(q => q.MarkedProducts).
                     Include(p => p.Product).ThenInclude(p=>p.User).ToList();           
        }

        

        public LastVisitedProduct GetByUserAndProduct(Guid userId, Guid productId)
        {
            return ctx.LastVisitedProduct.FirstOrDefault(p=>p.UserId == userId && p.ProductId == productId);
        }

        public List<LastVisitedProduct> GetLastEntry(long From)
        {
            return ctx.LastVisitedProduct.Where(p=>p.RegisterDate > From).ToList();
        }

        public int GetYearCount()
        {
            int year = DateTime.Now.ToUnix().ToPersianDate().Year;
            return ctx.LastVisitedProduct.Where(p => p.RegisterDate.PersianYear() == year).Count();
        }
    }
}
