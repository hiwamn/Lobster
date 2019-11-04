using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Utility.FireBase;

namespace Utility.Firebase
{
    public class FireBase
    {
        

        public static void SendNotification(string Message, List<string> PushIds)
        {
            List<object> list = new List<object>();
            list.Add(Message);
            list.Add(PushIds);
            Task myTask = Task.Run(() =>  Run(list));
            myTask.Wait();

            //BackgroundWorker bw = new BackgroundWorker();
            //bw.DoWork += SendToAll_DoWork;
            //bw.RunWorkerAsync(list);

            
        }

        private static void Run(List<object> arg)
        {
           
            string Message = arg[0] as string;
            List<string> DeviceID = arg[1] as List<string>;

            foreach (var item in DeviceID)
            {
                WebRequest tRequest = WebRequest.Create(FireBaseSetting.FireBaseApiAddress);
                tRequest.Method = "post";
                tRequest.Headers.Add(FireBaseSetting.FireBaseAuthorization);
                tRequest.Headers.Add(FireBaseSetting.FireBaseSender);
                tRequest.ContentType = "application/json";

                var payload = new
                {
                    to = item,
                    priority = "high",
                    isBackground = "",
                    content_available = true,
                    notification = new
                    {
                        body = Message,
                        title = FireBaseSetting.FireBaseTitle,
                        badge = 1
                    },
                };
                string postbody = JsonConvert.SerializeObject(payload).ToString();
                Byte[] byteArray = Encoding.UTF8.GetBytes(postbody);
                tRequest.ContentLength = byteArray.Length;
                using (Stream dataStream = tRequest.GetRequestStream())
                {
                    dataStream.Write(byteArray, 0, byteArray.Length);
                    using (WebResponse tResponse = tRequest.GetResponse())
                    {
                        using (Stream dataStreamResponse = tResponse.GetResponseStream())
                        {
                            if (dataStreamResponse != null)
                                using (StreamReader tReader = new StreamReader(dataStreamResponse))
                                {
                                    String sResponseFromServer = tReader.ReadToEnd();
                                }
                        }
                    }

                }
            }
        }

        private static void SendToAll_DoWork(object sender, DoWorkEventArgs e)
        {
            List<object> arg = e.Argument as List<object>;
            string Message = arg[0] as string;
            List<string> DeviceID = arg[1] as List<string>;

            foreach (var item in DeviceID)
            {
                WebRequest tRequest = WebRequest.Create(FireBaseSetting.FireBaseApiAddress);
                tRequest.Method = "post";
                tRequest.Headers.Add(FireBaseSetting.FireBaseAuthorization);
                tRequest.Headers.Add(FireBaseSetting.FireBaseSender);
                tRequest.ContentType = "application/json";

                var payload = new
                {
                    to = item,
                    priority = "high",
                    isBackground = "",
                    content_available = true,
                    notification = new
                    {
                        body = Message,
                        title = FireBaseSetting.FireBaseTitle,
                        badge = 1
                    },
                };
                string postbody = JsonConvert.SerializeObject(payload).ToString();
                Byte[] byteArray = Encoding.UTF8.GetBytes(postbody);
                tRequest.ContentLength = byteArray.Length;
                using (Stream dataStream = tRequest.GetRequestStream())
                {
                    dataStream.Write(byteArray, 0, byteArray.Length);
                    using (WebResponse tResponse = tRequest.GetResponse())
                    {
                        using (Stream dataStreamResponse = tResponse.GetResponseStream())
                        {
                            if (dataStreamResponse != null)
                                using (StreamReader tReader = new StreamReader(dataStreamResponse))
                                {
                                    String sResponseFromServer = tReader.ReadToEnd();
                                }
                        }
                    }

                }
            }
        }
    }
}
