using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AuthenticationService.Data
{
    public class User
    {
        [Key]
        public long Id { get; set; }
        [Required]
        public string UserName{ get; set; }
        [Required]
        public string Password{ get; set; }
    }
}
