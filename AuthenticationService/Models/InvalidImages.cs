using IdentityServer4.Models;
using NikoCore.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AuthenticationService.Models
{
    public class InvalidImages
    {
        [Required]
        public int PersonID { get; set; }

        public List<int> NeededId { get; set; }
        
        [Required]
        public string returnUrl{ get; set; }

    }
    
}
