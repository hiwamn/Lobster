using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.IdentityModel.Protocols;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Identity;
using System.Reflection;

namespace AuthenticationService.Data
{
    public interface ISqlContext 
    {
      

         DbSet<User> User{ get; set; }
        void SaveChange();

    }
}
