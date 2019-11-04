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
    public class GetLastVisitedProduct : IGetLastVisitedProduct
    {
        private readonly IUnitOfWork unit;

        public GetLastVisitedProduct(IUnitOfWork unit)
        {
            this.unit = unit;
        }

        public string Execute(int BlockNumber, int Count, Guid UserId)
        {
            List<ProductDto> visited = unit.LastVisitedProduct.GetByUserId(BlockNumber,Count, UserId);
            string result = Api.ToJson(visited);
            return result;
        }
    }
}
