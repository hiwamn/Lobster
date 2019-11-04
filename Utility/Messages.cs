using System;
using System.Collections.Generic;
using System.Text;

namespace Utility
{
    public class Messages
    {
        public static string LimitExceed { get; set; } = "شما تا 15 دقیقه دیگر قادر به ارسال نیستید";
        public static string VisaReady { get; set; } = "تبریک! کد پیگیری شما در فایل سفارت وجود دارد";
        public static string VisaNotReady { get; set; } = "متاسفانه کد پیگیری شما در فایل سفارت وجود ندارد";

        public static string CodeNotExist { get; set; } = "این کد وجود ندارد";

        public static string UserIsExist { get; set; } = "این کاربر وجود دارد";

        public static string UserNotExist { get; set; } = "کاربر وجود ندارد";
        public static string WrongCode { get; set; } = "کد نادرست است";
        public static string NoUpdateRaw { get; set; } = "آپدیتی وجود ندارد";
        public static string VisaCodeExist { get; set; } = "شما از این نوع کد ذخیره کرده اید";
        public static string PasswordSentBySms { get; set; } = "رمز شما با پیامک ارسال شد";
        public static string UserNotActivated { get; set; } = "کاربر  فعال نشده است";
        public static string ErenOK { get; set; } = "ErenOK";
        public static string InvalidUserNameOrPassword { get; set; } = "نام کاربری یا کلمه عبور نادرست است";
        public static string CanNotRegisterAnotherTest { get; set; } = "شما از کد تست خود استفاده کرده اید";
        public static string ProductNotExist { get; set; } = "محصول وجود ندارد";
    }
}
