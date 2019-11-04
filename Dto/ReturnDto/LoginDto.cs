using System;
using System.Collections.Generic;
using System.Text;

namespace Dto.ReturnDto
{
    public class LoginDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string FamilyName { get; set; }
        public string PhoneNumber { get; set; }
        public long RegisterDate { get; set; }
        public int ProvinceId { get; set; }
        public string ProvinceName { get; set; }
        public int CityId { get; set; }
        public string CityName { get; set; }
        public int ProductCount { get; set; }
        public int MarkedCount { get; set; }

    }
}
