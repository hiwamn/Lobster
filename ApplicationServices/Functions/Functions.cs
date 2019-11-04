using Domain.Entities;
using Dto.Models;
using Dto.ReturnDto;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace ApplicationServices.Functions
{
    public class Functions
    {
        public static SettingModel GetSettingModel(List<Setting> setting)
        {
            SettingModel model = new SettingModel { };
            setting.ForEach(p =>
            {
                PropertyInfo propertyInfo = model.GetType().GetProperty(p.Name);
                propertyInfo.SetValue(model, Convert.ChangeType(p.Value, propertyInfo.PropertyType), null);
            });
            return model;
        }

        public static List<KnowledgeDto> GetKnowledgeModel(List<KnowledgeDto> know)
        {
            throw new NotImplementedException();
        }
    }
}
