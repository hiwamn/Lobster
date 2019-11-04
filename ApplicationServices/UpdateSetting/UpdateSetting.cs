using Domain.Contract;
using Domain.Entities;
using Dto.DeviceDto;
using Dto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utility;

namespace ApplicationServices
{
    public class UpdateSetting : IUpdateSetting
    {
        private readonly IUnitOfWork unit;

        public UpdateSetting(IUnitOfWork unit)
        {
            this.unit = unit;
        }

        public string Execute(SettingModel dto )
        {
            var setting = unit.Setting.GetAll();
            for (int i = 0; i < setting.Count; i++)
            {
                var field = dto.GetType().GetProperties().FirstOrDefault(p=>p.Name == setting[i].Name);               
                setting[i].Value = field.GetValue(dto).ToString();
            }
            
            unit.Complete();
            return Messages.ErenOK;
        }
    }
}
