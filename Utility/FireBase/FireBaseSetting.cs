using System;
using System.Collections.Generic;
using System.Text;

namespace Utility.FireBase
{
    public class FireBaseSetting
    {
        public static string FireBaseApiAddress = "https://fcm.googleapis.com/fcm/send";
        public static string AuthorizationKey = "AAAAY8iSYTI:APA91bHhm8ENzkXX2geaXoEeHaKL8Yf0crP-VwxMtdAYuQT2KFoVgt8vhu3yQ85vCIVfERJHGeY7WaYCxobpwTGFay6ojC1qZVr6-mLTADZXi9aucc1vJGA66Scph94sjztdgXPKcB_X";
        public static string Sender = "428566798642";
        public static string FireBaseTitle = "خدمات مهاجرت آلمان";

        public static string FireBaseAuthorization = string.Format("Authorization: key={0}", AuthorizationKey);
        public static string FireBaseSender = string.Format("Sender: id={0}",Sender);
    }
}
