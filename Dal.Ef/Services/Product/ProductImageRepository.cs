using Domain.Contract;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dal.Ef.Services
{
    public class ProductImageRepository : Repository<ProductImage>, IProductImageRepository
    {
        private readonly IContext ctx;

        public ProductImageRepository(IContext ctx):base(ctx as DbContext)
        {
            this.ctx = ctx;
        }
    }
}
