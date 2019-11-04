using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Contract
{
    public interface IActiveCodeRepository : IRepository<ActiveCode>
    {
        ActiveCode GetByMobile(string Mobile);
        bool CheckExeed(string mobile);
    }
}
