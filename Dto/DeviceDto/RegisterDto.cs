using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dto.DeviceDto
{
    public class RegisterDto
    {
        public string Mobile { get; set; }
        public string Password { get; set; }
        public string PushId { get; set; }
        public string Name { get; set; }
        public string FamilyName { get; set; }
        public int CityId { get; set; }
    }
}
