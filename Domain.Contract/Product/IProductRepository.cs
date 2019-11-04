using Domain.Entities;
using Dto.DeviceDto;
using Dto.ReturnDto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Contract
{
    public interface IProductRepository : IRepository<Product>
    {
        List<ProductDto> GetByDetail(int Skip, int Count, GetTopProductDto dto);
        ProductDto GetById(Guid productId,Guid UserId);
        List<ProductDto> GetMyProduct(int blockNumber, int count, Guid userId);
    }
}
