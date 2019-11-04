using Domain.Contract;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility;

namespace ApplicationServices
{
    public class GetNotification : IGetNotification
    {
        private readonly IUnitOfWork unit;

        public GetNotification(IUnitOfWork unit)
        {
            this.unit = unit;
        }

        public string Execute(Guid UserId)
        {
            string result = Api.ToJson(unit.Notification.GetByUserId(UserId).Select(p=>new { p.RegisterDate,p.Text}).ToList());
            return result;
        }
    }
}
