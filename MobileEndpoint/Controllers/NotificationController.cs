using Domain.Contract;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Utility;

namespace MobileEndpoint.Controllers
{
    public class NotificationController : ControllerBase
    {
        private readonly IUnitOfWork unit;

        public NotificationController(IUnitOfWork unit)
        {
            this.unit = unit;
        }

        [Route("[controller]/[action]")]
        [HttpPost]
        public IActionResult GetList()
        {
            List<string> lst = null;
            var JSON = Request.Form["JSON"].ToString();
            if (JSON != null)
            {
                //List<string> list = Api.ToObject<List<string>>(JSON);
                //List<User> users = unit.User.GetByActiveVisaCode(list);
                //List<string> Push = new List<string>();
                //users.ForEach(p => p.Device.ForEach(q => Push.Add(q.PushId)));
                //lst = Push;

            }
                return Ok(Api.ToJson(lst));

            //return Ok("eqweqwe");
        }
    }
}
