﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class ActiveCode : BaseEntity
    {
        public string Code { get; set; }
        public string Mobile { get; set; }
    }
    
}


