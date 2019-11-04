using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class User : IdentityUser<Guid>
    {
        public string Name { get; set; }
        public string FamilyName { get; set; }
        public long RegisterDate { get; set; }
        public int CityId { get; set; }
        public City City { get; set; }

        public List<Device> Device { get; set; }
        public List<Notification> Notification { get; set; }
        public List<Product> Product { get; set; }
        public List<MarkedProduct> MarkedProduct { get; set; }
        public List<LastVisitedProduct> LastVisitedProduct { get; set; }

    }
    public class Role :IdentityRole<Guid>
    {
        public int No { get; set; }
        public Role(string roleName) : base(roleName)
        {
        }
        public Role() : base()
        {
        }
    }
}


