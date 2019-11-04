﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreExtension
{
    public class CustomIdentityErrorDescriber : IdentityErrorDescriber
    {
        public override IdentityError DefaultError() { return new IdentityError { Code = nameof(DefaultError), Description = $"An unknown failure has occurred." }; }
        public override IdentityError ConcurrencyFailure() { return new IdentityError { Code = nameof(ConcurrencyFailure), Description = "Optimistic concurrency failure, object has been modified." }; }
        public override IdentityError PasswordMismatch() { return new IdentityError { Code = nameof(PasswordMismatch), Description = "Incorrect password." }; }
        public override IdentityError InvalidToken() { return new IdentityError { Code = nameof(InvalidToken), Description = "Invalid token." }; }
        public override IdentityError LoginAlreadyAssociated() { return new IdentityError { Code = nameof(LoginAlreadyAssociated), Description = "A user with this login already exists." }; }
        public override IdentityError InvalidUserName(string userName) { return new IdentityError { Code = nameof(InvalidUserName), Description = $"User name '{userName}' is invalid, can only contain letters or digits." }; }
        public override IdentityError InvalidEmail(string email) { return new IdentityError { Code = nameof(InvalidEmail), Description = $"ایمیل '{email}' صحیح نیست" }; }
        public override IdentityError DuplicateUserName(string userName) { return new IdentityError { Code = nameof(DuplicateUserName), Description = $"User Name '{userName}' is already taken." }; }
        public override IdentityError DuplicateEmail(string email) { return new IdentityError { Code = nameof(DuplicateEmail), Description = $"Email '{email}' is already taken." }; }
        public override IdentityError InvalidRoleName(string role) { return new IdentityError { Code = nameof(InvalidRoleName), Description = $"Role name '{role}' is invalid." }; }
        public override IdentityError DuplicateRoleName(string role) { return new IdentityError { Code = nameof(DuplicateRoleName), Description = $"Role name '{role}' is already taken." }; }
        public override IdentityError UserAlreadyHasPassword() { return new IdentityError { Code = nameof(UserAlreadyHasPassword), Description = "User already has a password set." }; }
        public override IdentityError UserLockoutNotEnabled() { return new IdentityError { Code = nameof(UserLockoutNotEnabled), Description = "Lockout is not enabled for this user." }; }
        public override IdentityError UserAlreadyInRole(string role) { return new IdentityError { Code = nameof(UserAlreadyInRole), Description = $"کار در نقش  '{role}'. وجود دارد" }; }
        public override IdentityError UserNotInRole(string role) { return new IdentityError { Code = nameof(UserNotInRole), Description = $"کاربر در نقش '{role}' نیست." }; }
        public override IdentityError PasswordTooShort(int length) { return new IdentityError { Code = nameof(PasswordTooShort), Description = $"رمز عبور باید حداقل طول {length} را داشته باشد." }; }
        public override IdentityError PasswordRequiresNonAlphanumeric() { return new IdentityError { Code = nameof(PasswordRequiresNonAlphanumeric), Description = "رمز عبور باید حداقل شامل یک کاراکتر غیر حرف و عدد باشد" }; }
        public override IdentityError PasswordRequiresDigit() { return new IdentityError { Code = nameof(PasswordRequiresDigit), Description = "رمز عبور باید اعداد بین 0 تا 9 را داشته باشد ')." }; }
        public override IdentityError PasswordRequiresLower() { return new IdentityError { Code = nameof(PasswordRequiresLower), Description = "رمز عبور باید حروف کوچک بین a تا z را داشته باشد" }; }
        public override IdentityError PasswordRequiresUpper() { return new IdentityError { Code = nameof(PasswordRequiresUpper), Description = "رمز عبور باید حروف بزرگ بین A تا Z را داشته باشد" }; }
    }
}