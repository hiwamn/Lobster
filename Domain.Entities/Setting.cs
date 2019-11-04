using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Setting 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Value { get; set; }
    }    
}


