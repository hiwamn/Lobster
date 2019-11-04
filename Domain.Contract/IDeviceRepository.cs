using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Contract
{
    public interface IDeviceRepository : IRepository<Device>
    {
        bool IsExist(Guid userId, string DeviceId);
        List<Device> GetByUserId(Guid guid);
    }
}
