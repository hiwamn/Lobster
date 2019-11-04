using Dto.DeviceDto;
using Dto.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationServices
{
    public interface IUpdateSetting
    {
        string Execute(SettingModel dto);
    }
}
