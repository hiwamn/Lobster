using FreeControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;

namespace System
{
    public static class ExtensionMethods
    {
        public static int ToInt(this Enum Code)
        {
            return (int)Convert.ChangeType(Code, Code.GetTypeCode());
        }

        public static string ToEnglish(this string num)
        {
            string numresult = "";
            for (int i = 0; i < num.Length; i++)
            {
                string numt = num.Substring(i, 1);
                switch (numt)
                {
                    case "١":
                    case "1":
                        numresult += "1";
                        break;
                    case "٢":
                    case "2":
                        numresult += "2";
                        break;
                    case "٣":
                    case "3":
                        numresult += "3";
                        break;
                    case "٤":
                    case "4":
                        numresult += "4";
                        break;
                    case "٥":
                    case "5":
                        numresult += "5";
                        break;
                    case "٦":
                    case "6":
                        numresult += "6";
                        break;
                    case "٧":
                    case "7":
                        numresult += "7";
                        break;
                    case "٨":
                    case "8":
                        numresult += "8";
                        break;
                    case "٩":
                    case "9":
                        numresult += "9";
                        break;
                    case "٠":
                    case "0":
                        numresult += "0";
                        break;
                    default:
                        numresult += numt;
                        break;
                }

            }
            return numresult;
        }
        public static int ToInt(this string num)
        {
            return int.Parse(num);
        }
        public static DateTime ToDateTime(this string persianDate)
        {
            try
            {
                DateTime dt = new DateTime();
                persianDate = persianDate.Trim();
                if (persianDate.Length > 10)
                {
                    string[] Date = persianDate.Split(' ')[0].Split('/');
                    string[] Time = persianDate.Split(' ')[1].Split(':');
                    int y = int.Parse(Date[0]);
                    int m = int.Parse(Date[1]);
                    int d = int.Parse(Date[2]);

                    int h = int.Parse(Time[0]);
                    int mi = int.Parse(Time[1]);
                    int se = int.Parse(Time[2]);

                    if (m > 12) m = 1;
                    if (d > 31) d = 1;
                    dt = new DateTime(y, m, d, h, mi, se, new System.Globalization.PersianCalendar());
                }
                else
                {

                    string[] Date = persianDate.Split('/');
                    int y = int.Parse(Date[0]);
                    int m = int.Parse(Date[1]);
                    int d = int.Parse(Date[2]);
                    if (m > 12) m = 1;
                    if (d > 31) d = 1;
                    int h = 0;
                    int mi = 0;
                    int se = 0;
                    dt = new DateTime(y, m, d, h, mi, se, new System.Globalization.PersianCalendar());
                }
                return dt;
            }
            catch
            {
                return DateTime.Now;
            }
        }

        public static DateTime ToPersianDateTime(this string persianDate)
        {
            string[] Date = persianDate.Split(' ')[0].Split('/');
            string[] Time = persianDate.Split(' ')[1].Split(':');
            int y = int.Parse(Date[0]);
            int m = int.Parse(Date[1]);
            int d = int.Parse(Date[2]);

            int h = int.Parse(Time[0]);
            int mi = int.Parse(Time[1]);
            int se = int.Parse(Time[2]);
            return new DateTime(y, m, d, h, mi, se, new System.Globalization.PersianCalendar()).ToUnix().ToPersianDate();
        }
        public static long ToUnix(this DateTime date)
        {
            var timeSpan = (date.ToUniversalTime() - new DateTime(1970, 1, 1, 0, 0, 0));
            return (long)timeSpan.TotalSeconds;
        }

        public static long ToUnix(this PersianDate date)
        {
            PersianCalendar persian = new PersianCalendar();
            DateTime eday = persian.ToDateTime(date.Year, date.Month, date.Day, date.Hour, date.Minute, date.Second,0).ToUniversalTime();
            return eday.ToUnix();
        }

        public static PersianDate ToPersianDate(this int date)
        {
            DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
            return PersianDate.Parse(dtDateTime.AddSeconds(date).ToLocalTime());
        }

        public static PersianDate ToPersianDate(this long date)
        {
            DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
            return PersianDate.Parse(dtDateTime.AddSeconds(date).ToLocalTime());
        }
        public static string PersianDay(this int date)
        {
            // Unix timestamp is seconds past epoch
            System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
            dtDateTime = dtDateTime.AddSeconds(date).ToLocalTime();
            return PersianDate.Parse(dtDateTime).Day.ToString();
        }
        public static string PersianMonth(this int unixTimeStamp)
        {
            // Unix timestamp is seconds past epoch
            System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
            dtDateTime = dtDateTime.AddSeconds(unixTimeStamp).ToLocalTime();
            return PersianDate.Parse(dtDateTime).Month.ToString();

        }
        public static string PersianYear(this int unixTimeStamp)
        {
            // Unix timestamp is seconds past epoch
            System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
            dtDateTime = dtDateTime.AddSeconds(unixTimeStamp).ToLocalTime();
            return PersianDate.Parse(dtDateTime).Year.ToString();

        }
        public static string PersianDay(this long date)
        {
            // Unix timestamp is seconds past epoch
            System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
            dtDateTime = dtDateTime.AddSeconds(date).ToLocalTime();
            return PersianDate.Parse(dtDateTime).Day.ToString();
        }
        public static string PersianMonth(this long unixTimeStamp)
        {
            // Unix timestamp is seconds past epoch
            System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
            dtDateTime = dtDateTime.AddSeconds(unixTimeStamp).ToLocalTime();
            return PersianDate.Parse(dtDateTime).Month.ToString();

        }

        public static int PersianYear(this long unixTimeStamp)
        {
            // Unix timestamp is seconds past epoch
            System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
            dtDateTime = dtDateTime.AddSeconds(unixTimeStamp).ToLocalTime();
            return PersianDate.Parse(dtDateTime).Year;

        }
        



        public static string Description<T>(this T enumValue)
        {
            return enumValue.GetType()
                            .GetMember(enumValue.ToString())
                            .First()
                            .GetCustomAttribute<DisplayAttribute>()
                            .GetDescription();
        }

        public static string Name<T>(this T enumValue)
        {
            return enumValue.GetType()
                            .GetMember(enumValue.ToString())
                            .First()
                            .GetCustomAttribute<DisplayAttribute>()
                            .GetName();
        }

        public static string SafeFarsiStr(this string input)
        {
            return input.Replace("ي", "ی").Replace("ك","ک"); 
        }


        
        public static string ToPersianDateLongString(this int date)
        {
            return date.ToPersianDate().ToString();
        }

        public static string ToPersianDateShortString(this int date)
        {
            return date.ToPersianDate().ToString().Substring(0,10) ;
        }

        public static DateTime ToDate(this int date)
        {
            DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
            return dtDateTime.AddSeconds(date).ToLocalTime();
        }

        public static string ToDateLongString(this int date)
        {
            return date.ToDate().ToString();
        }

        public static string ToDateShortString(this int date)
        {
            return date.ToPersianDate().ToString().Substring(0, 10);
        }

        public static DataTable ToDataTable<T>(this List<T> iList)
        {
            DataTable dataTable = new DataTable();
            PropertyDescriptorCollection propertyDescriptorCollection =
                TypeDescriptor.GetProperties(typeof(T));
            for (int i = 0; i < propertyDescriptorCollection.Count; i++)
            {
                PropertyDescriptor propertyDescriptor = propertyDescriptorCollection[i];
                Type type = propertyDescriptor.PropertyType;

                if (type.IsGenericType && type.GetGenericTypeDefinition() == typeof(Nullable<>))
                    type = Nullable.GetUnderlyingType(type);


                dataTable.Columns.Add(propertyDescriptor.Name, type);
            }
            object[] values = new object[propertyDescriptorCollection.Count];
            foreach (T iListItem in iList)
            {
                for (int i = 0; i < values.Length; i++)
                {
                    values[i] = propertyDescriptorCollection[i].GetValue(iListItem);
                }
                dataTable.Rows.Add(values);
            }
            return dataTable;
        }
        public static DataTable ClassToDataTable(this object ClassObj)
        {
            var dataTable = new DataTable("OutputData");

            DataRow dataRow = dataTable.NewRow();
            dataTable.Rows.Add(dataRow);

            ClassObj.GetType().GetProperties().ToList().ForEach(f =>
            {
                try
                {
                    f.GetValue(ClassObj, null);
                    dataTable.Columns.Add(f.Name, f.PropertyType);
                    dataTable.Rows[0][f.Name] = f.GetValue(ClassObj, null);
                }
                catch { }
            });
            return dataTable;
        }

        public static string ToPersianDateLongString(this long date)
        {
            return date.ToPersianDate().ToString();
        }

        public static string ToPersianDateShortString(this long date)
        {
            return date.ToPersianDate().ToString().Substring(0, 10);
        }

        public static DateTime ToDate(this long date)
        {
            DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
            return dtDateTime.AddSeconds(date).ToLocalTime();
        }

        public static string ToDateLongString(this long date)
        {
            return date.ToDate().ToString();
        }

        public static string ToDateShortString(this long date)
        {
            return date.ToPersianDate().ToString().Substring(0, 10);
        }
    }
}

