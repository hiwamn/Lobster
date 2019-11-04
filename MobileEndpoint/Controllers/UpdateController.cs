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
    public class UpdateController : ControllerBase
    {
        private readonly IUnitOfWork unit;
        private readonly ICheckUpdate check;

        public UpdateController(IUnitOfWork unit , ICheckUpdate check)
        {
            this.unit = unit;
            this.check = check;
        }

        [HttpGet]
        public ActionResult<string> CheckUpdate([FromQuery]CheckUpdateDto dto)
        {
            return check.Execute(dto.Version);
        }
    }
}
