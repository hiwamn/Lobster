using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using Newtonsoft.Json.Serialization;

namespace Utility
{
    public class Api
    {
        private static string DesKey = "AArIFHhOAi2fqmA/FCr6TtQKYgFO5je+";

        public static string Execute(string JSON, string Func, byte[] File)
        {
            string result = "";
            Task myTask = Task.Run(() => result = GetAsync(JSON, Func, File).Result);
            myTask.Wait();
            return result;
        }

        public static void WriteTime(string txt)
        {
            var now = DateTime.Now;
            Console.WriteLine($"{txt} : {now.Hour}:{now.Minute}:{now.Second}:{now.Millisecond}");
        }



        public static T ToObject<T>(string text)
        {
            return JsonConvert.DeserializeObject<T>(text);
        }

        public static void ChangeToPersian(object obj)
        {
            var stringProperties = obj.GetType().GetProperties()
                                      .Where(p => p.PropertyType == typeof(string)).ToList();

            foreach (var stringProperty in stringProperties)
            {
                string currentValue = (string)stringProperty.GetValue(obj, null);
                if (currentValue != null)
                    stringProperty.SetValue(obj, currentValue.SafeFarsiStr(), null);
            }


        }



        private static async Task<string> GetAsync(string JSON, string function, byte[] File)
        {
            try
            {


                using (var httpClient = new HttpClient())
                {
                    httpClient.Timeout = new TimeSpan(0, 0, 10);
                    httpClient.DefaultRequestHeaders.ExpectContinue = false;

                    var uri = new Uri(function);

                    using (var formData = new MultipartFormDataContent())
                    {
                        formData.Add(new StringContent(JSON), "JSON");
                        if (File != null)
                            formData.Add(new StringContent(Convert.ToBase64String(File)), "File");
                        HttpResponseMessage response = await httpClient.PostAsync(uri, formData);

                        if (response.IsSuccessStatusCode)
                        {
                            return await response.Content.ReadAsStringAsync();
                        }
                        else
                            return response.StatusCode.ToString();
                    }
                }

            }
            catch (Exception e2)
            {

                return Encrypt(ToJson(new { NikoErrorText = "اتصال اینترنت خود را بررسی کنید" }));
            }

        }






        public static string GenerateCode()
        {
            int _min = 1000;
            int _max = 9999;
            Random _rdm = new Random();
            return _rdm.Next(_min, _max).ToString();
        }

        public static string GenerateRandomNo()
        {
            int _min = 10000;
            int _max = 99999;
            Random _rdm = new Random();
            return _rdm.Next(_min, _max).ToString().PadLeft(5, '0');
        }

        public static async Task SendSmsAsync(string Text, string Number)
        {

            Trez.TrezSmsServiceSoapClient sms = new Trez.TrezSmsServiceSoapClient(Trez.TrezSmsServiceSoapClient.EndpointConfiguration.TrezSmsServiceSoap12);
            Trez.ArrayOfString mobs = new Trez.ArrayOfString();
            Trez.ArrayOfLong ids = new Trez.ArrayOfLong();
            mobs.Add(Number);

             await sms.SendMessageAsync("iranpetrol", "bonnie2019", "50002210004082", Text, mobs, 0, ids);

        }

        public static string GetError(Exception exception)
        {
            if (exception.Message.Contains("NikoErrorText"))
                return Api.MakeError(exception.Message);
            try
            {
                StackTrace trace = new StackTrace(exception, true);
                var frame = trace.GetFrame(2);


                string text = exception.StackTrace;
                string Line = text.Substring(text.IndexOf("ApplicationServices"));
                Line = Line.Substring(0, Line.IndexOf(" at"));
                string fileName = Line.Split(':')[0];
                Line = Line.Split(':')[1].Replace("line", "").Replace("\r\n", "").Trim();

                Line = frame.GetFileLineNumber().ToString();
                fileName = frame.GetFileName();

                var result = CreateException(exception);

                return MakeError(result);
            }
            catch
            {
                return MakeError(ToJson(new { NikoError = exception.Message, NikoErrorText = "خطا", NikoErrorCode = "2" }));
            }
        }

        public static string CreateException(Exception ex)

        {

            System.Diagnostics.StackTrace trace = new System.Diagnostics.StackTrace(ex, true);

            string diagnoseResults = "";

            for (int i = 0; i < trace.FrameCount; i++)

            {

                diagnoseResults += i.ToString() + ":" + trace.GetFrame(i).GetMethod().Name + ":" + trace.GetFrame(i).GetFileLineNumber() + ":" + trace.GetFrame(0).GetFileColumnNumber() + "-";

            }

            string[] diagnoseBlocks = diagnoseResults.Split(new char[] { '-' });

            string processesException = "";

            processesException += "Exception Code = " + "12" + "\r\n";

            processesException += "Exception Message = " + "dddd" + "\r\n";

            processesException += "Exception Class = " + ex.TargetSite.ReflectedType.Name + "\r\n\r\n";

            processesException += "Exception Path:\r\n";

            processesException += "===============\r\n";

            for (int i = 0; i < diagnoseBlocks.Length - 1; i++)

            {

                string[] diagnoseCell = diagnoseBlocks[i].Split(new char[] { ':' });

                processesException += "Exception Level = " + i.ToString() + "\r\n";

                processesException += "Exception Method = " + diagnoseCell[1].ToString() + "\r\n";

                processesException += "Exception Line number = " + diagnoseCell[2].ToString() + "\r\n";

                processesException += "Exception Column number = " + diagnoseCell[3].ToString() + "\r\n\r\n";

            }

            return "$" + processesException + "$";

        }



        public static string MakeResponse(string Response)
        {
            return ToJson(new { Response });
        }

        public static string MakeError(string Response)
        {
            return ToJson(new { Error = Response });
        }

        public static string ToJson(object Obj)
        {
            return JsonConvert.SerializeObject(Obj, Formatting.None,
                        new JsonSerializerSettings()
                        {
                            ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                            NullValueHandling = NullValueHandling.Ignore
                            //,Error = Han
                        });
        }


        public static string Encrypt(string text)
        {
            return DES.Encrypt(text, "AArIFHhOAi2fqmA/FCr6TtQKYgFO5je+");
        }
        public static string Decrypt(string text)
        {
            return DES.Decrypt(text, "AArIFHhOAi2fqmA/FCr6TtQKYgFO5je+");
        }

        public static string EncryptRsa(string text, string PublicKey)
        {
            Utility.FileLogger("Encrypt: " + PublicKey);
            return Hashing.GetPacket(text, PublicKey);
        }
        public static string DecryptRsa(string text, string Key)
        {
            return Hashing.GetFields(text, Key);
        }


        public static string EncryptPassword(string text)
        {
            return DES.Encrypt(text, DesKey);
        }
        public static string DecryptPassword(string text)
        {
            return DES.Decrypt(text, DesKey);
        }

    }


}


