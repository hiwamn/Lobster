using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationServices
{
    public interface IGetCities
    {
        string Execute(int ProvinceId);
    }
}
