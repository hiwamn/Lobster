using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Models
{
    public class CreateUserModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "لطفا نام را وارد کنید")]
        public string Name { get; set; }

        [Required(ErrorMessage = "لطفا نام خانوادگی را وارد کنید")]
        public string FamilyName { get; set; }


        [Required,StringLength(11, ErrorMessage = "شماره باید 11 رقمی باشد")]
        [Remote(action: "IsMobileExist", controller: "Users")]
        public string Mobile { get; set; }

        [Required(ErrorMessage = "رمز را وارد کنید")]
        public string Password { get; set; }

        [Required(ErrorMessage = "تکرار رمز را وارد کنید")]                
        [Compare("Password",ErrorMessage ="تکرار رمز باید با رمز برابر باشد")]
        public string ConfirmPassword { get; set; }

        public int StationId { get; set; }


        //public List<Core.Domains.Station> Stations { get; set; }



        public bool Active { get; set; }
    }
}
