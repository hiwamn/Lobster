using Domain.Contract;
using Domain.Entities;
using Dto.ReturnDto;
using System;
using System.Collections.Generic;
using System.Text;
using Utility;

namespace ApplicationServices
{
    public class Login:ILogin
    {
        private readonly IUnitOfWork unit;

        public Login(IUnitOfWork unit)
        {
            this.unit = unit;
        }
        public string Execute(string Mobile, string Password,string DeviceId)
        {
            string ret;
            User user = unit.User.GetUserByUserPass(Mobile, Password);
            if (user == null)
                ret = Messages.UserNotExist;
            else if (!user.PhoneNumberConfirmed)
                ret = Messages.UserNotActivated;
            else if (user.PasswordHash != Api.EncryptPassword(Password))
                ret = Messages.InvalidUserNameOrPassword;
            else
            {
                if (user.PhoneNumberConfirmed)
                {
                    ret = Api.ToJson(CreateUserDto(user));
                    if (!unit.Device.IsExist(user.Id, DeviceId))
                    {
                        unit.Device.Add(new Device { PushId = DeviceId, UserId = user.Id, RegisterDate = DateTime.Now.ToUnix() });
                        unit.Complete();
                    }
                }
                else
                    ret = Messages.UserNotActivated;
            }
            return ret;
        }

        private static LoginDto CreateUserDto(User user)
        {
            return new LoginDto
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
                MarkedCount = user.MarkedProduct.Count,
                ProductCount = user.Product.Count
            };
        }
    }
}
