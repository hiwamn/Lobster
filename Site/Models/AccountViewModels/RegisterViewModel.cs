using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityModel
{
    public class RegisterViewModel
    {
        [Required]
        [EmailAddress(ErrorMessage = "فرمت پست الکترونیکی  را  صحیح وارد نمایید")]
        [Display(Name = "ایمیل")]
        [Remote("CheckUserName", "Account", ErrorMessage = "این کلمه کاربری قبلا استفاده شده است", HttpMethod = "Post")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "{0} باید حداقل {2} و حداکثر {1} حرفی باشد", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "رمز")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "تکرار رمز")]
        [Compare("Password", ErrorMessage = "تکرار رمز عبور با رمز وارد شده برابر نیست")]
        public string ConfirmPassword { get; set; }

        public string returnUrl { get; set; }
    }

    public class CustomerRegisterModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "نام را وارد نمایید")]
        [Display(Name = "نام")]
        public string FirstName { get; set; }

        [Display(Name = "نام خانوادگی")]
        [Required(ErrorMessage = "نام خانوادگی را وارد نمایید")]
        public string LastName { get; set; }

        [Display(Name = "کلمه کاربری")]
        [Remote("CheckUserName", "Account", "Admin", ErrorMessage = "این کلمه کاربری قبلا استفاده شده است", HttpMethod = "Post")]
        [Required(ErrorMessage = "کلمه کاربری خانوادگی را وارد نمایید")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "رمز عبور را وارد نمایید")]
        [Display(Name = "رمز عبور")]
        public string Password { get; set; }

        [Display(Name = "تایید رمز عبور")]
        [Required(ErrorMessage = "رمز عبور مجدد را وارد نمایید")]
        [Compare("Password", ErrorMessage = "رمز عبور ها یکسان نیست")]
        public string ConfirmPassword { get; set; }

        [EmailAddress(ErrorMessage = "فرمت پست الکترونیکی  را  صحیح وارد نمایید")]
        [Required(ErrorMessage = "پست الکترونیکی مجدد را وارد نمایید")]
        [Display(Name = "پست الکترونیکی")]
        public string Email { get; set; }
    }

    public class CustomerLoginModel
    {

        public string returnUrl { get; set; }

        [Display(Name = "کلمه کاربری")]
        [Required(ErrorMessage = "کلمه کاربری خانوادگی را وارد نمایید")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "رمز عبور را وارد نمایید")]
        [Display(Name = "رمز عبور")]
        public string Password { get; set; }

        [Display(Name = "مرا به خاطر بیاور")]
        public bool RememberMe { get; set; }
    }
}
