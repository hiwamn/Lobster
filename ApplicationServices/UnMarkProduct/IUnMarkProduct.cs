using Dto.DeviceDto;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationServices
{
    public interface IUnMarkProduct
    {
        string Execute(UnMarkProductDto dto);
    }
}
