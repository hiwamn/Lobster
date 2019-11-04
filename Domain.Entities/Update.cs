using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Update:BaseEntity
    {
        public string Version{ get; set; }
        public string Description{ get; set; }
        public bool Restricted { get; set; }
        public string Link { get; set; }

    }
}
