using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace Utility
{
    public class Utility
    {
        public static string JSONSerialize(object obj)
        {
            string result = JsonConvert.SerializeObject(obj);
            result = result.TrimStart('\"');
            result = result.TrimEnd('\"');
            result = result.Replace("\\", "");
            return result;
        }
        public static string GetTdButton(string Text,string Controller,string Action,string Id,string Class)
        {
           
            string result = $"<td><input type=\"button\" class=\"{ Class}\" value=\"{Text}\" onclick=getAddress('{Controller}','{Action}','{Id}')></td>";
            return result;
        }
        public static void InsertLog(string message)
        {
            try
            {
                string path = AppDomain.CurrentDomain.BaseDirectory + @"Logs\NikoService.txt";
                string pd = FreeControls.PersianDate.Now.ToString();
                string msg = pd + '\t' + message;
                if (!File.Exists(path))
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        sw.WriteLine(msg);
                    }
                else
                    using (StreamWriter sw = File.AppendText(path))
                    {
                        sw.WriteLine(msg);
                    }
            }
            catch (Exception)
            {
            }
        }
        public static long UnixTimeNow()
        {
            var timeSpan = (DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0));
            return (long)timeSpan.TotalSeconds;
        }


        public static void SaveFile(byte[] file, string address)
        {
            FileStream sw = new FileStream(address, FileMode.Create);
            byte[] Bytes = file;
            sw.Write(Bytes, 0, Bytes.Length);
            sw.Close();
        }

        public static List<T> CastObjToList<T>(T Obj)
        {
            if (Obj != null)
            {
                List<T> temp = new List<T>();
                temp.Add(Obj);
                return temp;
            }
            return new List<T>();
        }

        public static void MapAllFields(object source, object dst,string FieldName)
        {
            var ps = source.GetType().GetProperties();
            foreach (var item in ps)
            {
                if (item.Name != FieldName)
                {
                    var o = item.GetValue(source);
                    var p = dst.GetType().GetProperty(item.Name);
                    if (p != null)
                    {
                        if (o != null)
                        {
                            try
                            {
                                Type t = Nullable.GetUnderlyingType(p.PropertyType) ?? p.PropertyType;
                                object safeValue = (o == null) ? null : o;// Convert.ChangeType(o, t);
                                p.SetValue(dst, safeValue);
                            }
                            catch { }
                        }
                    }
                }
            }
        }

            

        public static long UnixOfTime(DateTime dateTime)
        {
            var timeSpan = (dateTime - new DateTime(1970, 1, 1, 0, 0, 0));
            return (long)timeSpan.TotalSeconds;
        }

        public static Type GetTables(string Name)
        {
            return Assembly.GetExecutingAssembly().GetTypes().FirstOrDefault(t=> t.IsClass & t.Name == Name);                           
        }

        public static void FileLogger(string text)
        {
            using (StreamWriter outputFile = new StreamWriter( "Log.txt",true))
            {               
                    outputFile.WriteLine(DateTime.Now.ToString() + " : " +  text);
            }
        }

        public static T FromJson<T>(string str)
        {
            return JsonConvert.DeserializeObject<T>(str);
        }
    }
}
