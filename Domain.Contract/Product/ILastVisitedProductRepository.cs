using Domain.Entities;
using Dto.ReturnDto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Contract
{
    public interface ILastVisitedProductRepository : IRepository<LastVisitedProduct>
    {
        List<ProductDto> GetByUserId(int blockNumber, int count, Guid userId);
        LastVisitedProduct GetByUserAndProduct(Guid userId, Guid productId);
        List<LastVisitedProduct> GetLastEntry(long From);
        int GetYearCount();
    }
}
