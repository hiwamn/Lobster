using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using ApplicationServices;
using Domain.Contract;
using Domain.Entities;
using Dto.DeviceDto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Admin.Controllers
{
    public class UsersController : Controller
    {
        private IHostingEnvironment hosting;
        private IUnitOfWork unit;
        UserManager<User> userManager;
        RoleManager<Role> roleManager;
        private readonly IChangeUserStatus changeUserStatus;
        private readonly IUpdateProfile updateProfile;

        public UsersController(IHostingEnvironment _hosting, IUnitOfWork _unit,
            UserManager<User> _userManager, RoleManager<Role> _roleManager,IChangeUserStatus changeUserStatus,
            IUpdateProfile updateProfile)
        {
            hosting = _hosting;
            this.unit = _unit;
            this.userManager = _userManager;
            this.roleManager = _roleManager;
            this.changeUserStatus = changeUserStatus;
            this.updateProfile = updateProfile;
        }
        [Authorize]
        public async Task<IActionResult> Index()
        {
            //int StationId = 0;
            //if (!User.HasClaim(ClaimTypes.Role, "مدیر کل"))
            //{
            //    var user = await userManager.GetUserAsync(HttpContext.User);
            //    StationId = user.StationId.Value;
            //}
            //var users = unit.User.GetWithEntry(StationId);
            //var level = unit.Level.GetAll().ToList();

            //foreach (var item in users)
            //{
            //    int i = 0;
            //    for (i = 0; i < level.Count; i++)
            //        if (item.UserEntry.Count < level[i].No)
            //            break;
            //    item.Address = level[i].IconAddress;
            //    item.LevelName = level[i].Name;
            //    item.No = item.UserEntry.Count;
            //}

            List<User> users = unit.User.GetAll();

            
            return View(users);
        }

        [Authorize]
        public async Task<IActionResult> Panel()
        {
            //var users = unit.User.GetPanel();
            //return View(users); 
            return null;
        }
        [Authorize]
        [HttpPost]
        public IActionResult ChangeStatus(Guid Id)
        {
            return new JsonResult(changeUserStatus.Execute(Id));
        }

        [Authorize]
        public IActionResult Create()
        {
            //CreateUserModel model = new CreateUserModel();
            //model.Stations = unit.Station.GetAll();
            //return View(model);
            return null;
        }
        //[Authorize]
        //[HttpPost]
        //public async Task<IActionResult> Create(CreateUserModel model)
        //{
        //    User user = new Core.Domains.User {AccessFailedCount=0,Address="",ConcurrencyStamp="",Email="hiwa_mn@yahoo.com" ,EmailConfirmed=true,FamilyName=model.FamilyName,LockoutEnabled=false,Name=model.Name,NormalizedEmail="hiwa_mn@yahoo.com",NormalizedUserName=model.Mobile,PasswordHash = Api.EncryptPassword(model.Password),PhoneNumber=model.Mobile,PhoneNumberConfirmed=true,RegisterDate=Utility.UnixTimeNow(),StationId=model.StationId,TwoFactorEnabled=false,UserName=model.Mobile,SecurityStamp =""};
        //    unit.User.Add(user);
        //    unit.Complete();
        //    var roleCheck1 = await roleManager.RoleExistsAsync("کاربر پنل");
        //    if (!roleCheck1)
        //    {
        //        var roleResult = await roleManager.CreateAsync(new Role("کاربر پنل"));
        //    }
        //[Authorize]
        public IActionResult Edit(Guid UserId)
        {
            var user = unit.User.GetByUserId(UserId);
            UpdateProfileDto up = new UpdateProfileDto
            {
                Name = user.Name,
                FamilyName = user.FamilyName,
                CityId = user.CityId,
                Id = UserId
            };
            return View(up);
            
        }
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Edit(UpdateProfileDto model)
        {
            if (ModelState.IsValid)
            {
                updateProfile.Execute(model);
                return RedirectToAction("Index");
            }
            else
                return View(model);
        }

        [AcceptVerbs("Get", "Post")]
        public IActionResult IsMobileExist(string Mobile)
        {
            if (unit.User.GetByMobile(Mobile) != null)
            {
                return Json($"این شماره قبلا انتخاب شده است");
            }

            return Json(true);
        }
    }
}