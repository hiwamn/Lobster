using Domain.Contract;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dal.Ef.Services
{
    public class ActiveCodeRepository :Repository<ActiveCode>, IActiveCodeRepository
    {
        private readonly IContext ctx;

        public ActiveCodeRepository(IContext ctx):base(ctx as DbContext)
        {
            this.ctx = ctx;
        }

        public bool CheckExeed(string mobile)
        {
            var date = DateTime.Now.AddMinutes(-15);
            return ctx.ActiveCode.Count(p => p.Mobile == mobile && p.RegisterDate.ToDate() > date) >= 2 ;
        }

        public List<ActiveCode> GetAll()
        {
            return ctx.ActiveCode.ToList();
        }

        public ActiveCode GetByMobile(string Mobile)
        {
            return ctx.ActiveCode.LastOrDefault(p=>p.Mobile == Mobile && p.RegisterDate.ToDate().AddMinutes(+20) > DateTime.Now);
        }

        public void Insert(ActiveCode code)
        {
            ctx.ActiveCode.Add(code);
        }
    }
}
