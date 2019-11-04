using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using Domain.Contract;
using Domain.Entities;
using Utility;
using Utility.Firebase;

namespace Admin.Contollers
{
    public class NotificationController:Controller
    {
        private IUnitOfWork unit;
        private UserManager<User> userManager;

        public NotificationController(IUnitOfWork _unit,UserManager<User> _userManager)
        {
            unit = _unit;
            this.userManager = _userManager;
        }
        //[Authorize]
        public async Task<IActionResult> Index()
        {
            //int StationId = 0;
            //if (!HttpContext.User.IsInRole("مدیر کل"))
            //{
            //    var user = await userManager.GetUserAsync(HttpContext.User);
            //    StationId = user.StationId.Value;
            //}
            //var users = unit.User.GetWithDevice(StationId);           
            var users = unit.User.GetAll();
            return View(users);
        }

        [HttpPost]
        public async Task<IActionResult> Send(string Id, string text, bool save)
        {

            List<string> Ids = new List<string>();
            List<Device> device = unit.Device.GetByUserId(Guid.Parse(Id));
            device.ForEach(p=> Ids.Add(p.PushId));
            
            FireBase.SendNotification(text, Ids);
            //if (save)
            //{
            //    unit.Notification.Add(new Notification { RegisterDate = Utility.Utility.UnixTimeNow(), Text = text });
            //    unit.Complete();
            //}
            dynamic temp = new { ok = "Ok" };
            return new OkObjectResult(temp);
        }

        //public IActionResult Send1()
        //{
        //    var users = unit.User.GetWithDevice(0);

        //    List<string> Ids = new List<string>();
        //    foreach (var item in users)
        //    {
        //        foreach (var item1 in item.Devices.ToList())
        //        {
        //            Ids.Add(item1.DeviceID);
        //        }
        //    }

        //    FireBase.SendNotification("salam", Ids);
        //    dynamic temp = new { ok = "Ok" };
        //    return new OkObjectResult(temp);
        //}
    }
}
