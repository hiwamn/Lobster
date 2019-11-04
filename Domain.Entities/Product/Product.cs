using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Product : BaseEntity
    {
        public string Title { get; set; }
        public string Description{ get; set; }
        public string Link{ get; set; }
        public int ProductCategoryId { get; set; }
        public ProductCategory ProductCategory { get; set; }

        public Guid UserId { get; set; }
        public User User{ get; set; }
        public int CityId { get; set; }
        public City City{ get; set; }

        public int Price { get; set; }
        public bool? IsSpecial { get; set; }
        public bool? IsImmediate { get; set; }
        public bool? IsAdvertisement { get; set; }
        public bool IsForSale { get; set; }
        public bool IsForExchange { get; set; }

        public List<ProductImage> ProductImage { get; set; }
        public List<MarkedProduct> MarkedProducts{ get; set; }

    }


}


