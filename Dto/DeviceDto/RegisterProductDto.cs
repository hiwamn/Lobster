using System;
using System.Collections.Generic;
using System.Text;

namespace Dto.DeviceDto
{
    public class RegisterProductDto
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public Guid UserId { get; set; }
        public List<Guid> Images{ get; set; }
        public bool IsImmediate { get; set; }
        public bool IsSpecial { get; set; }
        public int Price { get; set; }
        public int CityId { get; set; }
        public int ProductCategoryId { get; set; }
        public string Link { get; set; }
        public bool IsAdvertisement { get; set; }
        public bool IsForSale { get; set; }
        public bool IsForExchange { get; set; }
    }
}
