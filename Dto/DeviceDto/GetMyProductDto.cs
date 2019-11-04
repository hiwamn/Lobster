using System;
using System.Collections.Generic;
using System.Text;

namespace Dto.DeviceDto
{
    public class GetMyProductDto
    {
        public int BlockNumber{ get; set; }
        public Guid UserId{ get; set; }
    }
}
