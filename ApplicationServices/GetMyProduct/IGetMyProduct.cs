using Dto.DeviceDto;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationServices
{
    public interface IGetMyProduct
    {
        string Execute(int BlockNumber, int Count, GetMyProductDto dto);
    }
}
