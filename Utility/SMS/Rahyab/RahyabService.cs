using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Utility.SMS.Rahyab
{
    public class RahyabService : INotification
    {
        public async Task SendAsync(params string[] Params)
        {
            Cls_SMS.ClsSend sms_Single = new Cls_SMS.ClsSend();
            string[] ret1 = new string[2];
            ret1 =  sms_Single.SendSMS_Single(Params[0], Params[1]);
            //if (ret1[1] == "0")            
            //    ret1 = sms_Single.SendSMS_Single(Params[0], Params[1]);
        }
    }   
}
