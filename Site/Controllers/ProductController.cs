using ApplicationServices;
using CoreExtension;
using Domain.Contract;
using Dto.DeviceDto;
using Dto.ReturnDto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Utility;
using Utility.SiteConstants;

namespace Site.Controllers
{
    public class ProductController : BaseController
    {
        private readonly IUnitOfWork unit;
        private readonly IGetTopProduct getTopProduct;

        public ProductController(IUnitOfWork unit, ICompositeViewEngine viewEngine, IGetTopProduct getTopProduct) : base(viewEngine)
        {
            this.unit = unit;
            this.getTopProduct = getTopProduct;
        }
        [Authorize]
        public IActionResult Index()
        {
            var result = getTopProduct.Execute(1, SiteData.BlockSize.ToInt(), new GetTopProductDto { BlockNumber = 1, IsAdvertisement = null, IsImmediate = null, IsSpecial = null, ProductCategoryId = null });
            List<ProductDto> product = Api.ToObject<List<ProductDto>>(result);
            return View(product);
        }
       // [Authorize]
        public IActionResult Register()
        {
            return View();
        }


        [Authorize]
        public IActionResult Special()
        {
            var result = getTopProduct.Execute(1, SiteData.BlockSize.ToInt(), new GetTopProductDto { BlockNumber = 1, IsAdvertisement = null, IsImmediate = null, IsSpecial = true, ProductCategoryId = null });
            List<ProductDto> product = Api.ToObject<List<ProductDto>>(result);
            return View(product);
        }

        [Authorize]
        public IActionResult Immediate()
        {
            var result = getTopProduct.Execute(1, SiteData.BlockSize.ToInt(), new GetTopProductDto { BlockNumber = 1, IsAdvertisement = null, IsImmediate = true, IsSpecial = null, ProductCategoryId = null });
            List<ProductDto> product = Api.ToObject<List<ProductDto>>(result);
            return View(product);
        }
        [Authorize]
        public IActionResult Advertisement()
        {
            var result = getTopProduct.Execute(1, SiteData.BlockSize.ToInt(), new GetTopProductDto { BlockNumber = 1, IsAdvertisement = true, IsImmediate = null, IsSpecial = null, ProductCategoryId = null });
            List<ProductDto> product = Api.ToObject<List<ProductDto>>(result);
            return View(product);
        }

        [HttpPost]
        public ActionResult Scroll(int BlockNumber,bool? IsAdvertisement, bool? IsImmediate, bool? IsSpecial, int? ProductCategoryId)
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
