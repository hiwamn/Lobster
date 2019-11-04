using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Contract
{
    public interface INotificationRepository : IRepository<Notification>
    {
        List<Notification> GetByUserId(Guid UserId);
    }
}
