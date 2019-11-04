using Domain.Contract;
using Domain.Entities;
using Dto.DeviceDto;
using System;
using System.Collections.Generic;
using System.Text;
using Utility;

namespace ApplicationServices
{
    public class UpdateProfile : IUpdateProfile
    {
        private readonly IUnitOfWork unit;

        public UpdateProfile(IUnitOfWork unit)
        {
            this.unit = unit;
        }

        public string Execute(UpdateProfileDto dto )
        {
            string result = Messages.ErenOK;

            User user = unit.User.Get(dto.Id);
            user.Name = dto.Name;
            user.FamilyName = dto.FamilyName;
            user.CityId = dto.CityId;
            unit.Complete();
            return result;
        }
    }
}
