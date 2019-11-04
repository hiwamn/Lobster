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
using Models;
using Dto.Models;
using System.Reflection;
using ApplicationServices.Functions;
using ApplicationServices;
using Utility.SiteConstants;
using Dto.ReturnDto;
using Dto.DeviceDto;

namespace Admin.Contollers
{
    public class SettingController : Controller
    {
        private IUnitOfWork unit;
        private UserManager<User> userManager;
        private readonly IUpdateSetting updateSetting;

        public SettingController(IUnitOfWork _unit,UserManager<User> _userManager,IUpdateSetting updateSetting)
        {
            unit = _unit;
            this.userManager = _userManager;
            this.updateSetting = updateSetting;
        }
        //[Authorize]
        public async Task<IActionResult> Index()
        {
            var setting = unit.Setting.GetAll();
            SettingModel model = Functions.GetSettingModel(setting);
            return View(model);
        }
        
       //[Authorize]
        [HttpPost]
        public async Task<IActionResult> Index(SettingModel model)
        {
            updateSetting.Execute(model);
            return View(model);
        }


        //[Authorize]
        public async Task<IActionResult> Knowledge()
        {
            var model = unit.Knowledge.GetByDetail(1,PanelData.KnowledgeBlockCount.ToInt(),new GetKnowledgeDto { });
            
            return View(model);
        }

        //[Authorize]
        [HttpPost]
        public async Task<IActionResult> Knowledge(SettingModel model)
        {
            updateSetting.Execute(model);
            return View(model);
        }
        public async Task<IActionResult> Weather()
        {
            var setting = unit.WeatherPoint.GetAll();
            //SettingModel model = Functions.GetSettingModel(setting);
            return View(setting);
        }

        //[Authorize]
        [HttpPost]
        public async Task<IActionResult> Weather(SettingModel model)
        {
            updateSetting.Execute(model);
            return View(model);
        }

    }
}
