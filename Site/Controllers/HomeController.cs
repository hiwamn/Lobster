using Domain.Contract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Utility.SiteConstants;
using CoreExtension;
using ApplicationServices;
using Utility;
using Dto.ReturnDto;

namespace Site.Controllers
{
    public class HomeController : BaseController
    {
        private readonly IUnitOfWork unit;
        private readonly IGetHomePageItems getHomePageItems;

        public HomeController(IUnitOfWork unit,ICompositeViewEngine viewEngine,IGetHomePageItems getHomePageItems):base(viewEngine)
        {
            this.unit = unit;
            this.getHomePageItems = getHomePageItems;
        }

        public IActionResult Index()
        {                       
            var ad = Api.ToObject<HomePageItemsDto>(getHomePageItems.Execute(SiteData.BlockSize.ToInt()));
            return View(ad);
        }


        public IActionResult Profile()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Scroll(int BlockNumber)
        {
            //var ad = unit.Advertisement.GetByDetails(BlockNumber,PanelData.AdCount);
            //string HTMLString = "";
            //ad.ForEach(p =>
            //    {
            //        HTMLString += RenderPartialViewToString("Advert", new BoxModel
            //        {
            //            Description = p.Description,
            //            ImageUrl = p.AdvertisementImage.Count > 0 ? p.AdvertisementImage.FirstOrDefault().Image.Location : "/assets/img/NF.jpg",
            //            Title = p.Title
            //        });
            //    }
            //    );
            //dynamic a = new { NoMoreData = ad.Count < SiteData.BlockSize.ToInt(), HTMLString };
            //return Json(a);

            return null;

        }      
    }
}
