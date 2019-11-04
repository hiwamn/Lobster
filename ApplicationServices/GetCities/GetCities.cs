using Domain.Contract;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility;

namespace ApplicationServices
{
    public class GetCities : IGetCities
    {
        private readonly IUnitOfWork unit;

        public GetCities(IUnitOfWork unit)
        {
            this.unit = unit;
        }

        public string Execute(int ProvinceId)
        {
            string result = Api.ToJson(unit.City.GetByProvinceId(ProvinceId));
            
            return result;
        }
    }
}
