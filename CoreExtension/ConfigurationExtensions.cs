using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreExtension
{
    public static class ConfigurationExtensions
    {
        public static void GetSection<T>(this IConfiguration config,string SectionName)
        {
            var data = config.GetSection(SectionName).Get<Dictionary<string, string>>();
            Type type = typeof(T);
            foreach (var p in type.GetProperties())
            {
                string Value = "";
                data.TryGetValue(p.Name, out Value);
                p.SetValue(null, Value);
            }
        }
    }
}
