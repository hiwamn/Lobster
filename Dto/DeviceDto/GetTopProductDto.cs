using System;
using System.Collections.Generic;
using System.Text;

namespace Dto.DeviceDto
{
    public class GetTopProductDto
    {
        public int? ProductCategoryId { get; set; }
        public bool? IsSpecial { get; set; }
        public bool? IsImmediate { get; set; }
        public bool? IsAdvertisement { get; set; }
        public int BlockNumber{ get; set; }
        public Guid UserId{ get; set; }
    }
}
