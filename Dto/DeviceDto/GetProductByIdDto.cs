using System;
using System.Collections.Generic;
using System.Text;

namespace Dto.DeviceDto
{
    public class GetProductByIdDto
    {
        public Guid ProductId { get; set; }
        public Guid UserId{ get; set; }
    }
}
