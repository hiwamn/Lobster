using Domain.Contract;
using Domain.Entities;
using Dto.DeviceDto;
using Dto.ReturnDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility;
using Utility.SiteConstants;

namespace ApplicationServices
{
    public class GetHomePageItems : IGetHomePageItems
    {
        private readonly IUnitOfWork unit;

        public GetHomePageItems(IUnitOfWork unit)
        {
            this.unit = unit;
        }

        public string Execute(int Num)
        {
            var Immediate = unit.Product.GetByDetail(1,Num,new GetTopProductDto { IsImmediate = true,IsSpecial=null, IsAdvertisement = null, ProductCategoryId = null});
            var Special = unit.Product.GetByDetail(1,Num,new GetTopProductDto { IsImmediate = null, IsSpecial = true, IsAdvertisement = null, ProductCategoryId = null });
            var Ad = unit.Product.GetByDetail(1,Num, new GetTopProductDto { IsImmediate = null, IsSpecial = null, IsAdvertisement = true, ProductCategoryId = null });
            return Api.ToJson(new HomePageItemsDto { Immediate = Immediate, Special = Special, Ad = Ad });
        }
    }
}
