using Domain.Contract;
using Domain.Entities;
using Dto.DeviceDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility;
using Utility.SiteConstants;

namespace ApplicationServices
{
    public class GetMyProduct : IGetMyProduct
    {
        private readonly IUnitOfWork unit;

        public GetMyProduct(IUnitOfWork unit)
        {
            this.unit = unit;
        }

        public string Execute(int BlockNumber,int Count, GetMyProductDto dto)
        {
            string result = Api.ToJson(unit.Product.GetMyProduct(BlockNumber, Count, dto.UserId));
            return result;
        }
    }
}
