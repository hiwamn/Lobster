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
    public class MarkProduct : IMarkProduct
    {
        private readonly IUnitOfWork unit;

        public MarkProduct(IUnitOfWork unit)
        {
            this.unit = unit;
        }

        public string Execute(MarkProductDto dto)
        {
            unit.MarkedProduct.Add(new MarkedProduct { ProductId = dto.ProductId,UserId = dto.UserId,RegisterDate = DateTime.Now.ToUnix()});
            unit.Complete();
            return Messages.ErenOK;
        }
    }
}
