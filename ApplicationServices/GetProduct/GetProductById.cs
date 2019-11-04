using Domain.Contract;
using Domain.Entities;
using Dto.DeviceDto;
using Dto.ReturnDto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Utility;

namespace ApplicationServices
{
    public class GetProductById : IGetProductById
    {
        private readonly IUnitOfWork unit;

        public GetProductById(IUnitOfWork unit)
        {
            this.unit = unit;
        }

        public string Execute(Guid UserId, Guid ProductId)
        {
            ProductDto pro = unit.Product.GetById(ProductId,UserId);
            unit.LastVisitedProduct.Add(new LastVisitedProduct {ProductId = ProductId,UserId = UserId,RegisterDate = DateTime.Now.ToUnix() });
            unit.Complete();
            string result = Api.ToJson(pro);
            return result;
        }
    }
}
