using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Models
{
    public class BoxModel
    {
        public string ImageUrl { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string OldPrice { get; set; }
        public string ShowLink { get; set; }
        public string RegisterLink { get; set; }
    }
}
