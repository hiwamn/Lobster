using Dto.DeviceDto;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationServices
{
    public interface IGetTopProduct
    {
        string Execute(int BlockNumber, int Count, GetTopProductDto dto);
    }
}
