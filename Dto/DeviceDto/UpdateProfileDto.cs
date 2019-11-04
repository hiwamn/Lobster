using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dto.DeviceDto
{
    public class UpdateProfileDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string FamilyName { get; set; }
        public int CityId { get; set; }
    }
}
