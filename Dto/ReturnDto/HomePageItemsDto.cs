using System;
using System.Collections.Generic;
using System.Text;

namespace Dto.ReturnDto
{
    public class HomePageItemsDto
    {
        public List<ProductDto> Immediate { get; set; }
        public List<ProductDto> Special { get; set; }
        public List<ProductDto> Ad { get; set; }
    }
}
