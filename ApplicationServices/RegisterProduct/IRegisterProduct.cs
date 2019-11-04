using Dto.DeviceDto;
using Dto.DeviceDto;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationServices
{
    public interface IRegisterProduct
    {
        string Execute(RegisterProductDto dto);
    }
}
