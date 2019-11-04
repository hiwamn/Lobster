using Dto.DeviceDto;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationServices
{
    public interface IGetProductById
    {
        string Execute(Guid UserId, Guid ProductId);
    }
}
