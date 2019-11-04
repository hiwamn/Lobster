using Domain.Contract;
using Domain.Entities;
using FreeControls;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Utility;

namespace Admin.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHostingEnvironment hosting;
        private IUnitOfWork unit;

        string FuncName = "";
        string Json = "";
        private UserManager<User> userManager;

        public HomeController(IHostingEnvironment _hosting, IUnitOfWork _unit, UserManager<User> _userManager)
        {
            hosting = _hosting;
            this.unit = _unit;
            this.userManager = _userManager;
        }


        //[Authorize(Roles = "Admin" + ","+"Panel")]
        public IActionResult Index()
        {
            return RedirectToAction("Dashboard");

        }


        //[Authorize(Roles = "Admin" + "," + "Panel")]

        public async Task<IActionResult> Dashboard()
        {
            //int StationId = 0;
            //if (HttpContext.User.IsInRole("کاربر پنل"))
            //{
            //    var user = await userManager.GetUserAsync(HttpContext.User);
            //    //StationId = user.StationId.Value;
            //}
            IndexModel model = FillModel();
            //var mr = new List<MonthRegister>
            //{
            //    new MonthRegister {Month="12",No = "3" },
            //    new MonthRegister {Month="12",No = "3" },
            //    new MonthRegister {Month="12",No = "3" },
            //    new MonthRegister {Month="12",No = "3" },
            //    new MonthRegister {Month="12",No = "3" },
            //    new MonthRegister {Month="12",No = "3" }
            //};
            //var ms = new List<MonthSales>
            //{
            //    new MonthSales{ Income = 12,Month = "12"},
            //    new MonthSales{ Income = 12,Month = "12"},
            //    new MonthSales{ Income = 12,Month = "12"},
            //    new MonthSales{ Income = 12,Month = "12"},
            //    new MonthSales{ Income = 12,Month = "12"},
            //    new MonthSales{ Income = 12,Month = "12"}
            //};
            //var tc = new List<TopCategory>
            //{
            //    new TopCategory{ Id =3,Name = "sasd",Sale = "sdfsdf"}
            //};
            //var u = new List<User>
            //{
            //    new User{ },
            //    new User{ }
            //};
            //var wu = new List<WeekSales>
            //{
            //    new WeekSales{ Day = "dasd",Income = 123},
            //    new WeekSales{ Day = "dasd",Income = 123},
            //    new WeekSales{ Day = "dasd",Income = 123},
            //    new WeekSales{ Day = "dasd",Income = 123},
            //    new WeekSales{ Day = "dasd",Income = 123},
            //    new WeekSales{ Day = "dasd",Income = 123},
            //    new WeekSales{ Day = "dasd",Income = 123},
            //};
            //IndexModel model = new IndexModel
            //{
            //    MonthRegister = mr,
            //    MonthSales = ms,
            //    SurveyCount = 0,
            //    TopCategory = tc,
            //    UserCount = 2,
            //    Users = u,
            //    VoteYearCount = 0,
            //    WeekUserEntry = wu,
            //    YearUserEntryCount = 0
            //};
            return View(model);
        }


        [NonAction]
        private IndexModel FillModel()
        {

            IndexModel model = new IndexModel();
            model.WeekUserEntry = new List<WeekSales>();
            model.MonthSales = new List<MonthSales>();
            model.TopCategory = new List<TopCategory>();
            model.MonthRegister = new List<MonthRegister>();

            model.Users = unit.User.GetTop(5);


            model.UserCount = unit.User.GetCount();
            model.YearUserEntryCount = unit.LastVisitedProduct.GetYearCount();
            model.SurveyCount = 23;
            model.VoteYearCount = 12;

            SetWeek(model);
            SetMonth(model);
            SetUser(model);
            return model;
        }
        [NonAction]
        private void SetCategory(IndexModel model)
        {
            //List<Category> cat = unit.Category.GetTop(4);
            //for (int i = 0; i < cat.Count; i++)
            //{

            //    TopCategory ws = new TopCategory();
            //    ws.Name = cat[i].Title;
            //    ws.Sale = Utility.GetPrice(cat[i]).ToString();
            //    ws.Id = cat[i].Id;
            //    model.TopCategory.Add(ws);
            //}
        }

        [NonAction]
        private void SetWeek(IndexModel model)
        {
            DateTime now = DateTime.Now;
            DateTime currentDate = new DateTime(now.Year, now.Month, now.Day, 23, 59, 59);

            var WeekIncome = unit.LastVisitedProduct.GetLastEntry(currentDate.AddDays(-7).ToUnix()).GroupBy(p => p.RegisterDate.PersianDay()).Select(p => new { p.Key, Orders = p.ToList() }).ToList();

            for (int i = 0; i < 7; i++)
            {
                WeekSales ws = new WeekSales();
                ws.Day = PersianDate.Parse(DateTime.Now.AddDays(-i)).Day.ToString();
                ws.Income = 0;
                model.WeekUserEntry.Add(ws);
            }
            foreach (var item in WeekIncome)
            {

                for (int i = 0; i < model.WeekUserEntry.Count; i++)
                {
                    if (model.WeekUserEntry[i].Day == item.Key)
                        model.WeekUserEntry[i].Income += item.Orders.Count;
                }
            }
        }

        [NonAction]
        private void SetMonth(IndexModel model)
        {
            DateTime now = DateTime.Now;
            DateTime currentDate = new DateTime(now.AddMonths(1).Year, now.AddMonths(1).Month, 1, 0, 0, 0);

            var WeekIncome = unit.LastVisitedProduct.GetLastEntry(currentDate.AddMonths(-6).ToUnix()).GroupBy(p => p.RegisterDate.PersianMonth()).Select(p => new { p.Key, Orders = p.ToList() }).ToList();

            for (int i = 0; i < 6; i++)
            {
                MonthSales ws = new MonthSales();
                ws.Month = PersianDate.Parse(DateTime.Now.AddMonths(-i)).Month.ToString();
                ws.Income = 0;
                model.MonthSales.Add(ws);
            }
            foreach (var item in WeekIncome)
            {
                for (int i = 0; i < model.MonthSales.Count; i++)
                {
                    if (model.MonthSales[i].Month == item.Key)
                        model.MonthSales[i].Income += item.Orders.Count;
                }
            }
        }

        [NonAction]
        private void SetUser(IndexModel model)
        {
            DateTime now = DateTime.Now;
            DateTime currentDate = new DateTime(now.AddMonths(1).Year, now.AddMonths(1).Month, 1, 0, 0, 0);

            var WeekIncome = unit.User.GetLast(currentDate.AddMonths(-6).ToUnix()).GroupBy(p => p.RegisterDate.PersianMonth()).Select(p => new { p.Key, Users = p.ToList() }).ToList();

            for (int i = 0; i < 6; i++)
            {
                MonthRegister ws = new MonthRegister();
                ws.Month = PersianDate.Parse(DateTime.Now.AddMonths(-i)).Month.ToString();
                ws.No = "0";
                model.MonthRegister.Add(ws);
            }
            foreach (var item in WeekIncome)
            {
                int income = item.Users.Count;
                for (int i = 0; i < model.MonthSales.Count; i++)
                {
                    if (model.MonthRegister[i].Month == item.Key)
                        model.MonthRegister[i].No = income.ToString();
                }
            }
        }






    }
}
