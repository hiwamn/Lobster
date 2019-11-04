using ApplicationServices;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Utility.SiteConstants;

namespace MobileEndpoint.Controllers
{
    public class HomeController:ControllerBase
    {
        private readonly IGetHomePageItems getHomeItems;

        public HomeController(IGetHomePageItems getHomeItems)
        {
            this.getHomeItems = getHomeItems;
        }

        [Route("[controller]/[action]")]
        [HttpGet]
        public IActionResult Index()
        {
            return Ok("salam");
        }
        [Route("[controller]/[action]")]
        [HttpGet]
        public ActionResult<string> GetHomePageItems()
        {
            return getHomeItems.Execute(MobileData.NumberOfAd.ToInt());
        }
    }
}
