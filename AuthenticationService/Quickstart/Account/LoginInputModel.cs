// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


using System.ComponentModel.DataAnnotations;

namespace IdentityServer4.Quickstart.UI
{
    public class LoginInputModel
    {
        [Required(ErrorMessage = "لطفا نام کاربری را وارد کنید")]
        [Display(Name ="نام کاربری")]
        public string Username { get; set; }
        [Required(ErrorMessage ="لطفا رمز عبور را وارد کنید")]
        [Display(Name = "رمز عبور")]
        public string Password { get; set; }
        [Display(Name = "مرا به خاطر بسپار")]
        public bool RememberLogin { get; set; }
        public string ReturnUrl { get; set; }

        public bool pleaseWait { get; set; } = false;
    }
}