using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dto.DeviceDto
{
    public class RegisterAdDto
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public Guid UserId { get; set; }
        public string Link { get; set; }
    }
}
