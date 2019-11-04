using ApplicationServices;
using Domain.Contract;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using Utility;
using Utility.SMS.Rahyab;
using Microsoft.Extensions.Configuration;
using CoreExtension;
using Dal.Ef;
using Microsoft.EntityFrameworkCore;

namespace ConsoleCore
{
    class Program
    {
        static int counter = 1;
        static string url = @"http://www.tsetmc.com/Loader.aspx?ParTree=151311&i=44891482026867833";
        public static Task[] TaskList = new Task[500];
        public static List<string> list = new List<string>();

        public static IUnitOfWork Iunit { get; private set; }
        public static IConfiguration Configuration { get; set; }

        

        static async System.Threading.Tasks.Task Main(string[] args)
        {
            Config();
            GetMarkedProduct getMarked = new GetMarkedProduct(Iunit);
            getMarked.Execute(1, 5, Guid.Parse("dfa0256e-075a-47be-3ae5-08d756b503b3"));

            
            

            Console.ReadKey();

        }



        public static void Config()
        {
            ServiceCollection service = new ServiceCollection();
            var builder = new ConfigurationBuilder().SetBasePath(@"C:\Users\Developer151\source\repos\Mountain\MobileEndpoint\").AddJsonFile("appsettings.json", optional: true, reloadOnChange: true).AddEnvironmentVariables();
            Configuration = builder.Build();

            //service.Configure<AppSettings>(Configuration.GetSection("AppSettings"));
            service.AddSingleton<IConfiguration>(builder.Build());

            //service.ConfigureMySqlContext(Configuration);

            service.AddDbContext<MainContext>(o => o.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            service.ConfigureAll();

            

            var provider = service.BuildServiceProvider();
            Iunit = provider.GetService<IUnitOfWork>();
        }


        private static void ReadKey()
        {
            var key = Console.ReadKey();
            if (key.KeyChar != 13)
                ReadKey();
            Console.Write(key.KeyChar);
        }

        public static void Call()
        {
            Thread.Sleep(1);
            var request = (HttpWebRequest)WebRequest.Create(url);

            request.Method = "GET";
            request.AutomaticDecompression = DecompressionMethods.Deflate | DecompressionMethods.GZip;

            var content = string.Empty;

            using (var response = (HttpWebResponse)request.GetResponse())
            {
                using (var stream = response.GetResponseStream())
                {
                    using (var sr = new StreamReader(stream))
                    {
                        content = sr.ReadToEnd();
                    }
                }
            }

            //return content;




            //string html = string.Empty;

            //HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            //request.AutomaticDecompression = DecompressionMethods.GZip;

            //using (HttpWebResponse response = (HttpWebResponse)await request.GetResponseAsync())
            //using (Stream stream = response.GetResponseStream())
            //using (StreamReader reader = new StreamReader(stream))
            //{
            //    html = reader.ReadToEnd();
            //    list.Add(html);
            //}

            Console.WriteLine(counter++);
        }
    }

    public class a
    {
        public int b { get; set; }
        public string c { get; set; }

        public List<Person> per { get; set; }
    }

    public class Person
    {
        public int b { get; set; }
        public string v { get; set; }
    }

    public static class ExtensionMethods
    {
        public static string GetQueryString(this object obj, string prefix = "")
        {
            var list = obj.GetType().GetProperties().ToList();

            Dictionary<string, string> prop = new Dictionary<string, string>();

            list.ForEach(p =>
            {
                if (!p.PropertyType.IsGenericType)
                    prop.Add(p.Name, p.GetValue(obj).ToString());
                else
                {
                    var lst = p.GetValue(list) as List<Person>;

                    lst.ForEach(q =>
                    {
                        var l = q.GetType().GetProperties().ToList();
                        l.ForEach(t =>
                        {
                            prop.Add(t.Name, t.GetValue(q).ToString());
                        });
                    });

                }
            });

            var query = "";
            try
            {
                var vQueryString = (JsonConvert.SerializeObject(prop));

                var jObj = (JObject)JsonConvert.DeserializeObject(vQueryString);
                query = String.Join("&",
                   jObj.Children().Cast<JProperty>()
                   .Select(jp =>
                   {
                       if (jp.Value.Type == JTokenType.Array)
                       {
                           var count = 0;
                           var arrValue = String.Join("&", jp.Value.ToList().Select<JToken, string>(p =>
                           {
                               var tmp = JsonConvert.DeserializeObject(p.ToString()).GetQueryString(jp.Name + HttpUtility.UrlEncode("[") + count++ + HttpUtility.UrlEncode("]"));
                               return tmp;
                           }));
                           return arrValue;
                       }
                       else
                           return (prefix.Length > 0 ? prefix + HttpUtility.UrlEncode("[") + jp.Name + HttpUtility.UrlEncode("]") : jp.Name) + "=" + HttpUtility.UrlEncode(jp.Value.ToString());
                   }
                   )) ?? "";
            }
            catch (Exception ex)
            {

            }
            return query;
        }
    }
}
