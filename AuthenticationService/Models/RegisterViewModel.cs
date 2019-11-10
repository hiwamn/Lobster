using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AuthenticationService.Models
{
    public class RegisterViewModel
    {
        //[Required(ErrorMessage = "فرمت پست الکترونیکی  را  صحیح وارد نمایید")]
        //[EmailAddress(ErrorMessage = "فرمت پست الکترونیکی  را  صحیح وارد نمایید")]
        //[Display(Name = "ایمیل")]
        //[Remote("CheckUserName", "Account", ErrorMessage = "این کلمه کاربری قبلا استفاده شده است", HttpMethod = "Post")]
        //public string Email { get; set; }

        [Required(ErrorMessage = "نام را  صحیح وارد نمایید")]
        [MinLength(3)]
        [Display(Name = "نام")]
        public string Name { get; set; }

        [Required(ErrorMessage = "نام خانوادگی را  صحیح وارد نمایید")]
        [MinLength(3)]
        [Display(Name = "نام خانوادگی")]
        public string FamilyName { get; set; }

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
        public string ImgCartMelli { get; set; }
        public string ImgPersonally { get; set; }
        public string ImgSafheAvvaleDaftarche { get; set; }

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
