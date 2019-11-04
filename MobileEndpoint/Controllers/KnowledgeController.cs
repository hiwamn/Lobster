using ApplicationServices;
using Domain.Contract;
using Domain.Entities;
using Dto.DeviceDto;
using Dto.DeviceDto;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Utility;
using Utility.SiteConstants;

namespace MobileEndpoint.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class KnowledgeController : ControllerBase
    {
        private readonly IUnitOfWork unit;
        private readonly IGetTopKnowledge getTopKnowledge;

        public KnowledgeController(IUnitOfWork unit,IGetTopKnowledge getTopKnowledge)
        {
            this.unit = unit;
            this.getTopKnowledge = getTopKnowledge;
        }

      

        [HttpGet]
        public ActionResult<string> GetTopProductByScroll([FromQuery] GetKnowledgeDto dto)
        {
            return getTopKnowledge.Execute(dto.BlockNumber, MobileData.NumberOfAd.ToInt(), dto);
        }

       
    }
}
