using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class ProductImage : BaseEntity
    {
        public Guid ImageId { get; set; }               
        public Image Image { get; set; }               
        public Guid ProductId { get; set; }               
        public Product Product { get; set; }               
    }


}


