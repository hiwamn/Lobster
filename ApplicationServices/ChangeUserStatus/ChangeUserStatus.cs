using Domain.Contract;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Utility;

namespace ApplicationServices
{
    public class ChangeUserStatus : IChangeUserStatus
    {
        private readonly IUnitOfWork unit;

        public ChangeUserStatus(IUnitOfWork unit)
        {
            this.unit = unit;
        }

        public string Execute(Guid Id)
        {
            var user = unit.User.Get(Id);
            user.PhoneNumberConfirmed = !user.PhoneNumberConfirmed;
            unit.Complete();
            return Messages.ErenOK;
        }
    }
}
