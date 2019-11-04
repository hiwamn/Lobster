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
    public class SettingController : ControllerBase
    {
        private readonly IUnitOfWork unit;
        private readonly IGetSetting getSetting;

        public SettingController(IUnitOfWork unit , IGetSetting getSetting)
        {
            this.unit = unit;
            this.getSetting = getSetting;
        }

        

    
        
        [HttpGet]
        public ActionResult<string> GetSetting()
        {
            return getSetting.Execute();
        }
        
       
    }
}
