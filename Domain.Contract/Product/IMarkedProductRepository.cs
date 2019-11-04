using Domain.Entities;
using Dto.DeviceDto;
using Dto.ReturnDto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Contract
{
    public interface IMarkedProductRepository : IRepository<MarkedProduct>
    {
        List<ProductDto> GetByUserId(int BlockNumber, int Count, Guid userId);
        MarkedProduct GetByUserAndProduct(Guid userId, Guid productId);
        List<MarkedProduct> GetById(Guid guid);
    }
}
