using Domain.Contract;
using Domain.Entities;
using Dto.DeviceDto;
using Dto.Models;
using Dto.ReturnDto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Utility;

using ApplicationServices.Functions;


namespace ApplicationServices
{
    public class GetSetting : IGetSetting
    {
        private readonly IUnitOfWork unit;

        public GetSetting(IUnitOfWork unit)
        {
            this.unit = unit;
        }

        public string Execute()
        {
            var setting = unit.Setting.GetAll();
            SettingModel model = Functions.Functions.GetSettingModel(setting);
            string result = Api.ToJson(model);
            return result;
        }
    }
}
