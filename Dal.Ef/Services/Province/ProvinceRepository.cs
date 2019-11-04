﻿using Domain.Contract;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dal.Ef.Services
{
    public class ProvinceRepository : Repository<Province>, IProvinceRepository
    {
        private readonly IContext ctx;

        public ProvinceRepository(IContext ctx):base(ctx as DbContext)
        {
            this.ctx = ctx;
        }

      
    }
}