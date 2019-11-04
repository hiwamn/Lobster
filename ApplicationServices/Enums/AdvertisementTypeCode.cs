using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ApplicationServices
{
    public enum AdvertisementTypeCode
    {
        [Display(Description = "خواهان")]
        Seeker = 1,
        [Display(Description = "مالک")]
        Owner= 2
    }
}
