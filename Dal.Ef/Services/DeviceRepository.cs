using Domain.Contract;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dal.Ef.Services
{
    public class DeviceRepository : Repository<Device>, IDeviceRepository
    {
        private readonly IContext ctx;

        public DeviceRepository(IContext ctx) : base(ctx as DbContext)
        {
            this.ctx = ctx;
        }

        public List<Device> GetByUserId(Guid guid)
        {
            return ctx.Device.Where(p=>p.UserId == guid).ToList();
        }

        public void Insert(Device device)
        {
            ctx.Device.Add(device);
        }

        public bool IsExist(Guid userId,string deviceId)
        {
            return ctx.Device.Any(p=>p.UserId == userId && p.PushId == deviceId);
        }
    }
}
