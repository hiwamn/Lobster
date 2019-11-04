using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplicationServices;
using Domain.Contract;
using Domain.Entities;
using Dto.DeviceDto;
using Microsoft.AspNetCore.Mvc;
using Utility;

namespace MobileEndpoint.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class ProvinceController : ControllerBase
    {
        private readonly IUnitOfWork unit;
        private readonly IGetProvinces getProvinces;
        private readonly IGetCities getCities;

        public ProvinceController(IUnitOfWork unit , IGetProvinces getProvinces,IGetCities getCities)
        {
            this.unit = unit;
            this.getProvinces = getProvinces;
            this.getCities = getCities;
        }

        

    
        
        [HttpGet]
        public ActionResult<string> GetProvinces()
        {
            return getProvinces.Execute();
        }
        [HttpGet]
        public ActionResult<string> GetCities([FromQuery]int ProvinceId)
        {
            return getCities.Execute(ProvinceId);
        }
       
    }
}
