using System;
using System.Collections.Generic;
using System.Text;

namespace Dto.DeviceDto
{
    public class GetMarkedProductDto
    {
        public Guid UserId{ get; set; }
        public int BlockNumber{ get; set; }
    }
}
