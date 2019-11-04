using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Contract
{
    public interface IUpdateRepository : IRepository<Update>
    {
        List<Update> GetUpdate(string Version);
    }
}
