using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplicationServices;
using Domain.Contract;
using Domain.Entities;
using Dto.DeviceDto;
using Microsoft.AspNetCore.Mvc;
using Utility;

namespace MobileEndpoint.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUnitOfWork unit;
        private readonly IRegister register;
        private readonly IForgetPassword forget;
        private readonly IGetNotification notification;
        private readonly ILogin login;
        private readonly IUpdateProfile updateProfile;

        public UserController(IUnitOfWork unit , IRegister register,IForgetPassword forget,IGetNotification notification,ILogin login,IUpdateProfile updateProfile)
        {
            this.unit = unit;
            this.register = register;
            this.forget = forget;
            this.notification = notification;
            this.login = login;
            this.updateProfile = updateProfile;
        }

        

        [HttpPost]
        public ActionResult<string> Register([FromBody] RegisterDto dto)
        {
            
            return register.Execute(dto);
        }

        [HttpPost]
        public ActionResult<string> UpdateProfile([FromBody] UpdateProfileDto dto)
        {
            return updateProfile.Execute(dto);
        }
        
        [HttpGet]
        public ActionResult<string> ForgetPassword([FromQuery] ForgetPasswordDto dto)
        {
            return forget.Execute(dto.Mobile);
        }
        [HttpGet]
        public ActionResult<string> GetNotification([FromQuery]GetNotificationDto dto)
        {
            return notification.Execute(dto.UserId);
        }
        [HttpGet]
        public ActionResult<string> Login([FromQuery]LoginDto dto)
        {
            return login.Execute(dto.Mobile, dto.Password,dto.PushId);
        }
    }
}
