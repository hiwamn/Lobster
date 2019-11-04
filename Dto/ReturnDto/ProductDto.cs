using System;
using System.Collections.Generic;
using System.Text;

namespace Dto.ReturnDto
{
    public class ProductDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int ProductCategoryId { get; set; }
        public long RegisterDate { get; set; }

        public List<string> Images { get; set; }
        public double Price { get; set; }
        public bool? IsSpecial { get; set; }
        public bool? IsImmediate { get; set; }
        public bool? IsAdvertisement { get; set; }
        public bool IsForSale { get; set; }
        public int ProvinceId { get; set; }
        public string ProvinceName { get; set; }
        public int CityId { get; set; }
        public string CityName { get; set; }
        public string Link { get; set; }
        public string Mobile { get; set; }
        public bool IsMarked { get; set; }
        public bool IsForExchange { get; set; }


    }
}
