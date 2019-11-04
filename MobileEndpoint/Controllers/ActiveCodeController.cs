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
    public class ActiveCodeController : ControllerBase
    {
        private readonly IUnitOfWork unit;
        private readonly ISendActiveCode sendActive;

        public ActiveCodeController(IUnitOfWork unit , ISendActiveCode sendActive)
        {
            this.unit = unit;
            this.sendActive = sendActive;
        }

        

        [HttpPost]
        public ActionResult<string> SendActiveCode([FromBody] SendActiveCodeDto dto)
        {
            return sendActive.Execute(dto.Mobile);
        }
    }
}
