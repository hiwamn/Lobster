using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ApplicationServices
{
    public enum AdvertisementCategoryCode
    {
        [Display(Description = "اجاره")]
        Rent = 1,
        [Display(Description = "فروش")]
        Product = 2
    }
}
