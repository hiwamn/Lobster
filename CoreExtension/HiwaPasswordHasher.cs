﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Utility;

namespace CoreExtension
{
    public class HiwaPasswordHasher<TUser> : PasswordHasher<TUser> where TUser : class
    {
        //readonly BCryptPasswordSettings _settings;
        public HiwaPasswordHasher(/*BCryptPasswordSettings settings*/)
        {
            //_settings = settings;
        }

        public override PasswordVerificationResult VerifyHashedPassword(TUser user, string hashedPassword, string providedPassword)
        {
            //if (hashedPassword == null) { throw new ArgumentNullException(nameof(hashedPassword)); }
            //if (providedPassword == null) { throw new ArgumentNullException(nameof(providedPassword)); }

            //byte[] decodedHashedPassword = Convert.FromBase64String(hashedPassword);

            //// read the format marker from the hashed password
            //if (decodedHashedPassword.Length == 0)
            //{
            //    return PasswordVerificationResult.Failed;
            //}

            //// ASP.NET Core uses 0x00 and 0x01, so we start at the other end
            //if (decodedHashedPassword[0] == 0xFF)
            //{
            //    if (VerifyHashedPasswordBcrypt(decodedHashedPassword, providedPassword))
            //    {
            //        // This is an old password hash format - the caller needs to rehash if we're not running in an older compat mode.
            //        return _settings.RehashPasswords
            //            ? PasswordVerificationResult.SuccessRehashNeeded
            //            : PasswordVerificationResult.Success;
            //    }
            //    else
            //    {
            //        return PasswordVerificationResult.Failed;
            //    }
            //}
            var a = Api.DecryptPassword(hashedPassword);
            //return base.VerifyHashedPassword(user, hashedPassword, providedPassword);
            return Api.DecryptPassword(hashedPassword).Equals(providedPassword)? PasswordVerificationResult.Success: PasswordVerificationResult.Failed;
        }

        //private static bool VerifyHashedPasswordBcrypt(byte[] hashedPassword, string password)
        //{
        //    if (hashedPassword.Length < 2)
        //    {
        //        return false; // bad size
        //    }

        //    //convert back to string for BCrypt, ignoring first byte
        //    var storedHash = Encoding.UTF8.GetString(hashedPassword, 1, hashedPassword.Length - 1);

        //    return BCrypt.Verify(password, storedHash);
        //}
    }

    public class BCryptPasswordSettings
    {
        public bool RehashPasswords { get; set; }
    }

}
