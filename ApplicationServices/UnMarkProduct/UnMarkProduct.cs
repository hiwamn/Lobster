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
    public class UnMarkProduct : IUnMarkProduct
    {
        private readonly IUnitOfWork unit;

        public UnMarkProduct(IUnitOfWork unit)
        {
            this.unit = unit;
        }

        public string Execute(UnMarkProductDto dto)
        {
            string result = Messages.ProductNotExist;
            MarkedProduct mark = unit.MarkedProduct.GetByUserAndProduct(dto.UserId,dto.ProductId);
            if (mark != null)
            {
                unit.MarkedProduct.Remove(mark);
                unit.Complete();
                result = Messages.ErenOK;
            }
            return result;
        }
    }
}
