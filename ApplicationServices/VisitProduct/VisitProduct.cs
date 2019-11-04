using Domain.Contract;
using Domain.Entities;
using Dto.DeviceDto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Utility;

namespace ApplicationServices
{
    public class VisitProduct : IVisitProduct
    {
        private readonly IUnitOfWork unit;

        public VisitProduct(IUnitOfWork unit)
        {
            this.unit = unit;
        }

        public string Execute(VisitProductDto dto)
        {
            LastVisitedProduct last = unit.LastVisitedProduct.GetByUserAndProduct(dto.UserId,dto.ProductId);
            if (last == null)
            {
                unit.LastVisitedProduct.Add(new LastVisitedProduct { ProductId = dto.ProductId, UserId = dto.UserId, RegisterDate = DateTime.Now.ToUnix() });
            }
            else
                last.RegisterDate = DateTime.Now.ToUnix();
            unit.Complete();
            return Messages.ErenOK;
        }
    }
}
