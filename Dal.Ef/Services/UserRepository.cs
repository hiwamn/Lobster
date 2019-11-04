using Domain.Contract;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utility;

namespace Dal.Ef.Services
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        private readonly IContext ctx;

        public UserRepository(IContext ctx):base (ctx as DbContext)
        {
            this.ctx = ctx;
        }
        public User Activate(string Mobile)
        {
            var user = ctx.User.FirstOrDefault(p=>p.PhoneNumber == Mobile);
            user.PhoneNumberConfirmed = true;
            return user;
        }
        public User GetByMobile(string Mobile)
        {
            var user = ctx.User.FirstOrDefault(p => p.PhoneNumber == Mobile);
            return user;
        }

        public User GetByUserId(Guid userId)
        {
            return ctx.User.FirstOrDefault(p=>p.Id == userId);
        }

        public List<User> GetLast(long From)
        {
            return ctx.User.Where(p=>p.RegisterDate>From).ToList();
        }

        public List<User> GetTop(int No)
        {
            return ctx.User.OrderByDescending(p => p.RegisterDate).Take(No).ToList();
        }

        public User GetUserByUserPass(string Mobile, string Password)
        {
            var pass = Api.EncryptPassword(Password);
            var user = ctx.User.Include(p=>p.Product).Include(p => p.MarkedProduct).Include(p=>p.City).ThenInclude(q=>q.Province).FirstOrDefault(p => p.PhoneNumber == Mobile && p.PasswordHash == pass);
            return user;
        }
        public bool IsExist(string mobile)
        {
            return ctx.User.Any(p=>p.PhoneNumber == mobile); 
        }

        
    }
}
