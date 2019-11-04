using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ApplicationServices
{
    public enum DocumentType
    {
        [Display(Description = "قولنامه")]
        Gholname = 1,
        [Display(Description = "شش دانگ")]
        SheshDang = 2,
        [Display(Description = "مشاع")]
        Mosha= 3
    }
}
