using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class KnowledgeImage : BaseEntity
    {
        public Guid ImageId { get; set; }               
        public Image Image { get; set; }               
        public Guid KnowledgeId { get; set; }               
        public Knowledge Knowledge { get; set; }               
    }


}


