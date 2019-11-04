using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Knowledge : BaseEntity
    {
        public string Title { get; set; }
        public string Description{ get; set; }

        public List<KnowledgeImage> KnowledgeImage { get; set; }

    }


}


