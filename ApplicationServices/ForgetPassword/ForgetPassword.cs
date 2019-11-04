using Domain.Contract;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Utility;

namespace ApplicationServices
{
    public class ForgetPassword:IForgetPassword
    {
        private readonly IUnitOfWork unit;
        private readonly INotification notification;

        public ForgetPassword(IUnitOfWork unit,INotification notification)
        {
            this.unit = unit;
            this.notification = notification;
        }
       

        public string Execute(string Mobile)
        {
            string result = Messages.UserNotExist;
            var user = unit.User.GetByMobile(Mobile);
            if (user != null)
            {
                Task myTask = Task.Run(() => notification.SendAsync(Api.DecryptPassword(user.PasswordHash), Mobile));
                myTask.Wait();                
                result = Messages.PasswordSentBySms;
            }

            return result;
        }
    }
}
