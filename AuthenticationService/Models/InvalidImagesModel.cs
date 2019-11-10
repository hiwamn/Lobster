using IdentityServer4.Models;
using NikoCore.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AuthenticationService.Models
{
    public class InvalidImagesModel
    {
        [Required]
        public int PersonID { get; set; }

        public PersonImagesDTO NationalCard { get; set; }
        public string NationalCardImageID { get; set; }
        public PersonImagesDTO Person { get; set; }
        public string PersonCardImageID { get; set; }
        public PersonImagesDTO Booklet { get; set; }
        public string BookletImageID { get; set; }

        [Required]
        public string returnUrl{ get; set; }

    }
    
}
