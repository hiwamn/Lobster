using Domain.Contract;
using Domain.Entities;
using Dto.DeviceDto;
using Dto.ReturnDto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Utility;

namespace ApplicationServices
{
    public class Register : IRegister
    {
        private readonly IUnitOfWork unit;

        public Register(IUnitOfWork unit)
        {
            this.unit = unit;
        }
        public string Execute(RegisterDto dto)
        {
            var now = Utility.Utility.UnixTimeNow();
            User user = new User() { AccessFailedCount = 0, ConcurrencyStamp = "", Email = " ", EmailConfirmed = true, FamilyName = dto.FamilyName, LockoutEnabled = true, LockoutEnd = null, Name = dto.Name, NormalizedEmail = "", NormalizedUserName = dto.Mobile, PasswordHash = Api.EncryptPassword(dto.Password), PhoneNumber = dto.Mobile, PhoneNumberConfirmed = true, RegisterDate = now, SecurityStamp = "", TwoFactorEnabled = false, UserName = dto.Mobile, Device = new List<Device> { new Device { PushId = dto.PushId, RegisterDate = now } },CityId = dto.CityId };
            unit.User.Add(user);
            unit.Complete();
            City city = unit.City.GetByDetail(dto.CityId);
            user.City = city;
            return Api.ToJson(CreateUserDto(user));
        }

        private static Dto.ReturnDto.LoginDto CreateUserDto(User user)
        {
            return new Dto.ReturnDto.LoginDto
            {
                Id = user.Id,
                Name = user.Name,
                FamilyName = user.FamilyName,
                PhoneNumber = user.PhoneNumber,
                RegisterDate = user.RegisterDate,
                CityId = user.CityId,
                CityName = user.City.Name,
                ProvinceId = user.City.ProvinceId,
                ProvinceName = user.City.Province.Name,
                MarkedCount = 0,
                ProductCount = 0
            };
        }
    }
}
