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
    public class GetProvinces : IGetProvinces
    {
        private readonly IUnitOfWork unit;

        public GetProvinces(IUnitOfWork unit)
        {
            this.unit = unit;
        }

        public string Execute()
        {
            string result = Api.ToJson(unit.Province.GetAll());
            return result;
        }
    }
}
