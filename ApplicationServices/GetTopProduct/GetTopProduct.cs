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
    public class GetTopProduct : IGetTopProduct
    {
        private readonly IUnitOfWork unit;

        public GetTopProduct(IUnitOfWork unit)
        {
            this.unit = unit;
        }

        public string Execute(int BlockNumber,int Count,GetTopProductDto dto)
        {
            string result = Api.ToJson(unit.Product.GetByDetail(BlockNumber, Count, dto));
            return result;
        }
    }
}
