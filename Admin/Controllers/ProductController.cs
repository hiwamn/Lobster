using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using Domain.Contract;
using Domain.Entities;
using Utility;
using Utility.Firebase;
using ApplicationServices;
using Dto.ReturnDto;
using Utility.SiteConstants;
using CoreExtension;
using Models;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using Dto.DeviceDto;

namespace Admin.Contollers
{
    public class ProductController:BaseController
    {
        private IUnitOfWork unit;
        private readonly IGetTopProduct getTopProduct;

        public ProductController(IUnitOfWork _unit,IGetTopProduct getTopProduct,ICompositeViewEngine viewEngine):base(viewEngine)
        {
            unit = _unit;
            this.getTopProduct = getTopProduct;
        }
        //[Authorize(Roles ="Admin" + "," + "Panel")]
        public async Task<IActionResult> Index()
        {

            var result = Api.ToObject<List<ProductDto>>(getTopProduct.Execute(1, PanelData.NumberOfAd.ToInt(), new GetTopProductDto { IsImmediate = null,IsSpecial = null,ProductCategoryId = null}));
            return View(result);
        }

        [HttpPost]
       
        public ActionResult Scroll(int BlockNumber, bool? IsAdvertisement, bool? IsImmediate, bool? IsSpecial, int? ProductCategoryId)
        {
            var result = getTopProduct.Execute(BlockNumber, SiteData.BlockSize.ToInt(), new GetTopProductDto { BlockNumber = BlockNumber, IsAdvertisement = IsAdvertisement, IsImmediate = IsImmediate, IsSpecial = IsSpecial, ProductCategoryId = ProductCategoryId });
            List<ProductDto> product = Api.ToObject<List<ProductDto>>(result);
            string HTMLString = "";
            product.ForEach(p =>
            {
                HTMLString += RenderPartialViewToString("Advert", new BoxModel
                {
                    Description = p.Description,
                    ImageUrl = p.Images.Count > 0 ? p.Images.FirstOrDefault() : "/assets/img/NF.jpg",
                    Title = p.Title
                });
            }
                );
            dynamic a = new { NoMoreData = product.Count < SiteData.BlockSize.ToInt(), HTMLString };
            return Json(a);
        }
    }
}
