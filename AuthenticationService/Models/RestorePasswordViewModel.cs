using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AuthenticationService.Models
{
    public class RestorePasswordViewModel
    {
        

        [Required(ErrorMessage = "کد ملی را وارد کنید")]
        [MinLength(10)]
        [MaxLength(10)]
        [Display(Name = "کد ملی")]
        public string NationalCode { get; set; }

        
        [Required(ErrorMessage = "شماره موبایل را وارد کنید")]
        [MinLength(11)]
        [MaxLength(11)]
        [Display(Name = "شماره موبایل")]
        public string PhoneNumber { get; set; }


        [Required(ErrorMessage = "رمز را وارد کنید")]
        [StringLength(100, ErrorMessage = "{0} باید حداقل {2} و حداکثر {1} حرفی باشد", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "رمز")]
        public string Password { get; set; }

        [Required(ErrorMessage = "تکرار رمز را وارد کنید")]
        [DataType(DataType.Password)]
        [Display(Name = "تکرار رمز")]
        [Compare("Password", ErrorMessage = "تکرار رمز عبور با رمز وارد شده برابر نیست")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "کد اهراز حویت را وارد کنید")]
        [MaxLength(4,ErrorMessage ="کد احراز هویت 4 رقمی است")]
        [MinLength(4,ErrorMessage ="کد احراز هویت 4 رقمی است")]
        [Display(Name = "کد اهراز حویت")]
        public string Code { get; set; }

        public string returnUrl { get; set; }
    }
    
}
