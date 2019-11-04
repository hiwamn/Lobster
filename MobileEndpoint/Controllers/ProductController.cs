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
    public class ProductController : ControllerBase
    {
        private readonly IUnitOfWork unit;
        private readonly IGetTopProduct getTopProduct;
        private readonly IRegisterProduct registerProduct;
        private readonly IVisitProduct visitProduct;
        private readonly IMarkProduct markProduct;
        private readonly IGetMarkedProduct getMarkedProduct;
        private readonly IGetLastVisitedProduct getLastVisitedProduct;
        private readonly IUnMarkProduct unMarkProduct;
        private readonly IGetProductById getProductById;
        private readonly IGetMyProduct getMyProduct;

        public ProductController(IUnitOfWork unit,IGetTopProduct getTopProduct,IRegisterProduct registerProduct,
            IVisitProduct visitProduct,IMarkProduct markProduct,
            IGetMarkedProduct getMarkedProduct,IGetLastVisitedProduct getLastVisitedProduct,
            IUnMarkProduct unMarkProduct,IGetProductById getProductById,IGetMyProduct getMyProduct)
        {
            this.unit = unit;
            this.getTopProduct = getTopProduct;
            this.registerProduct = registerProduct;
            this.visitProduct = visitProduct;
            this.markProduct = markProduct;
            this.getMarkedProduct = getMarkedProduct;
            this.getLastVisitedProduct = getLastVisitedProduct;
            this.unMarkProduct = unMarkProduct;
            this.getProductById = getProductById;
            this.getMyProduct = getMyProduct;
        }

        [HttpPost]
        public ActionResult<string> RegisterProduct([FromBody] RegisterProductDto dto)
        {
            return registerProduct.Execute(dto);
        }
        [HttpPost]
        public ActionResult<string> VisitProduct([FromBody] VisitProductDto dto)
        {
            return visitProduct.Execute(dto);
        }
        [HttpPost]
        public ActionResult<string> MarkProduct([FromBody] MarkProductDto dto)
        {
            return markProduct.Execute(dto);
        }
        [HttpPost]
        public ActionResult<string> UnMarkProduct([FromBody] UnMarkProductDto dto)
        {
            return unMarkProduct.Execute(dto);
        }

        [HttpGet]
        public ActionResult<string> GetTopProduct([FromQuery] GetTopProductDto dto)
        {
            return getTopProduct.Execute(1,MobileData.NumberOfAd.ToInt(),dto);
        }
        [HttpGet]
        public ActionResult<string> GetMyProduct([FromQuery] GetMyProductDto dto)
        {
            return getMyProduct.Execute(dto.BlockNumber,MobileData.NumberOfAd.ToInt(),dto);
        }
        [HttpGet]
        public ActionResult<string> GetProductById([FromQuery] GetProductByIdDto dto)
        {
            return getProductById.Execute(dto.UserId,dto.ProductId);
        }

        [HttpGet]
        public ActionResult<string> GetTopProductByScroll([FromQuery] GetTopProductDto dto)
        {
            return getTopProduct.Execute(dto.BlockNumber, MobileData.NumberOfAd.ToInt(), dto);
        }

        [HttpGet]
        public ActionResult<string> GetMarkedProductByScroll([FromQuery] GetMarkedProductDto dto)
        {
            return getMarkedProduct.Execute(dto.BlockNumber, MobileData.NumberOfAd.ToInt(), dto.UserId);
        }

        [HttpGet]
        public ActionResult<string> GetLastVisitedProductByScroll([FromQuery] GetLastVisitedProductDto dto)
        {
            return getLastVisitedProduct.Execute(dto.BlockNumber, MobileData.NumberOfAd.ToInt(), dto.UserId);
        }

        [HttpGet]
        public ActionResult<string> GetPro()
        {
            List<MarkedProduct> res = unit.MarkedProduct.GetById(Guid.Parse("dfa0256e-075a-47be-3ae5-08d756b503b3"));
            return Api.ToJson(res);
        }
    }
}
