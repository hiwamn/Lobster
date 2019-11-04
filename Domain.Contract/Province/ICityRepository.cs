using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Contract
{
    public interface ICityRepository : IRepository<City>
    {
        List<City> GetByProvinceId(int provinceId);
        City GetByDetail(int cityId);
    }
}
