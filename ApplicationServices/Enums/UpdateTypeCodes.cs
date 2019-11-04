using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ApplicationServices
{
    public enum UpdateTypeCodes
    {
        [Display(Description = "بدون آپدیت")]
        NoUpdate = 0,
        [Display(Description = "آپدیت اجباری")]
        Restricted = 1,
        [Display(Description = "آپدیت اختیاری")]
        Optional = 2
    }
}
