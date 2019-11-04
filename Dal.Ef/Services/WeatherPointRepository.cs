using Domain.Contract;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dal.Ef.Services
{
    public class WeatherPointRepository : Repository<WeatherPoint>, IWeatherPointRepository
    {
        private readonly IContext ctx;

        public WeatherPointRepository(IContext ctx) : base(ctx as DbContext)
        {
            this.ctx = ctx;
        }
    }
}
