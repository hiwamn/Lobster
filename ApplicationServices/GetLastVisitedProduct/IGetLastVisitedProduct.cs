using Dto.DeviceDto;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationServices
{
    public interface IGetLastVisitedProduct
    {
        string Execute(int BlockNumber, int Count, Guid UserId);
    }
}
