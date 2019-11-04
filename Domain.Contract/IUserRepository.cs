using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Contract
{
    public interface IUserRepository : IRepository<User>
    {
        User GetUserByUserPass(string Mobile,string Password);
        User GetByMobile(string Mobile);
        User Activate(string Mobile);
        User GetByUserId(Guid userId);
        bool IsExist(string mobile);
        List<User> GetTop(int v);
        List<User> GetLast(long From);
    }
}
