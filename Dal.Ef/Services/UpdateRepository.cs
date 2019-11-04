using Domain.Contract;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dal.Ef.Services
{
    public class UpdateRepository : Repository<Update>, IUpdateRepository
    {
        private readonly IContext ctx;

        public UpdateRepository(IContext ctx):base(ctx as DbContext)
        {
            this.ctx = ctx;
        }
        public List<Update> GetUpdate(string Version)
        {
            return ctx.Update.Where(p=>int.Parse(p.Version) > int.Parse(Version)).ToList();
        }
    }
}
