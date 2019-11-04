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
    public class GetMarkedProduct : IGetMarkedProduct
    {
        private readonly IUnitOfWork unit;

        public GetMarkedProduct(IUnitOfWork unit)
        {
            this.unit = unit;
        }

        public string Execute(int BlockNumber, int Count, Guid UserId)
        {
            List<ProductDto> mark = unit.MarkedProduct.GetByUserId(BlockNumber,Count, UserId);
            
            string result = Api.ToJson(mark);
            return result;
        }
    }
}
