using Domain.Contract;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dal.Ef.Services
{
    public class CityRepository : Repository<City>, ICityRepository
    {
        private readonly IContext ctx;

        public CityRepository(IContext ctx) : base(ctx as DbContext)
        {
            this.ctx = ctx;
        }

        public City GetByDetail(int cityId)
        {
            return ctx.City.Include(p => p.Province).FirstOrDefault(p=>p.Id == cityId);
        }

        public List<City> GetByProvinceId(int provinceId)
        {
            return ctx.City.Where(p=>p.ProvinceId == provinceId).ToList();
        }
    }
}
