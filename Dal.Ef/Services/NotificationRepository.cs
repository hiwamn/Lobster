using Domain.Contract;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dal.Ef.Services
{
    public class NotificationRepository : Repository<Notification>, INotificationRepository
    {
        private readonly IContext ctx;

        public NotificationRepository(IContext ctx) : base(ctx as DbContext)
        {
            this.ctx = ctx;
        }
        public List<Notification> GetByUserId(Guid UserId)
        {
            return ctx.Notification.Where(p=>p.UserId == UserId).ToList();
        }
    }
}
