﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Province
    {
        public int Id { get; set; }
        public string Name{ get; set; }
        

        public List<City> City { get; set; }

    }


}


