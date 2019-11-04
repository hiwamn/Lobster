using Domain.Contract;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Utility;

namespace ApplicationServices
{
    public class SendActiveCode : ISendActiveCode
    {
        private readonly IUnitOfWork unit;
        private readonly INotification notification;

        public SendActiveCode(IUnitOfWork unit,INotification notification)
        {
            this.unit = unit;
            this.notification = notification;
        }

        public string Execute(string Mobile)
        {
            string result = Messages.LimitExceed;
            var now = Utility.Utility.UnixTimeNow();
            var u = unit.User.IsExist(Mobile);
            if (u)
                result = Messages.UserIsExist;
            else if( !unit.ActiveCode.CheckExeed(Mobile))
            {
                string Code = Api.GenerateRandomNo();
                unit.ActiveCode.Add(new ActiveCode() { Mobile = Mobile, Code = Code, RegisterDate = now });
                unit.Complete();
                Task myTask = Task.Run(() => notification.SendAsync(Code, Mobile));
                myTask.Wait();
                result = Api.ToJson(new { Code });
            }

            return result;
        }
    }
}
