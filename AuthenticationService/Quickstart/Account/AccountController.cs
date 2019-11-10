// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


using IdentityModel;
using IdentityServer4.Services;
using IdentityServer4.Stores;
using IdentityServer4.Test;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Principal;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using IdentityServer4.Events;
using IdentityServer4.Extensions;
using IdentityServer4.Models;
using AuthenticationService.Data;
using AuthenticationService;
using AuthenticationService.Models;
using Microsoft.AspNetCore.Authorization;
using NikoCore;
using NikoCore.Objects;
using NikoCore.Domains.NikoDb.Tables;
using NikoCore.DTO;

namespace IdentityServer4.Quickstart.UI
{
    /// <summary>
    /// This sample controller implements a typical login/logout/provision workflow for local and external accounts.
    /// The login service encapsulates the interactions with the user data store. This data store is in-memory only and cannot be used for production!
    /// The interaction service provides a way for the UI to communicate with identityserver for validation and context retrieval
    /// </summary>
    //[SecurityHeaders]
    public class AccountController : Controller
    {
        private readonly TestUserStore _users;
        private readonly IIdentityServerInteractionService _interaction;
        private readonly IEventService _events;
        private readonly AccountService _account;
        private readonly ISqlContext Sql;

        public ISqlContext SqlContext { get; }

        public AccountController(
            IIdentityServerInteractionService interaction,
            IClientStore clientStore,
            IHttpContextAccessor httpContextAccessor,
            IAuthenticationSchemeProvider schemeProvider,
            IEventService events,
            ISqlContext _Sql, ISqlContext sqlContext,
            TestUserStore users = null)
        {
            // if the TestUserStore is not in DI, then we'll just use the global users collection
            _users = users ?? new TestUserStore(TestUsers.Users);
            SqlContext = sqlContext;
            _interaction = interaction;
            _events = events;
            _account = new AccountService(interaction, httpContextAccessor, schemeProvider, clientStore);
            Sql = _Sql;
        }

        /// <summary>
        /// Show login page
        /// </summary>
        [HttpGet]
        public async Task<IActionResult> Login(string returnUrl)
        {
            // build a model so we know what to show on the login page
            var vm = await _account.BuildLoginViewModelAsync(returnUrl);

            vm.ReturnUrl = returnUrl;


            if (vm.IsExternalLoginOnly)
            {
                // we only have one option for logging in and it's an external provider
                return await ExternalLogin(vm.ExternalLoginScheme, returnUrl);
            }

            return View(vm);
        }

        [HttpGet]
        public async Task<IActionResult> Register(string ReturnUrl)
        {
            //var l = await _account.BuildLoginViewModelAsync(returnUrl);

            RegisterViewModel model = new RegisterViewModel();
            model.returnUrl = ReturnUrl;

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);
            return RedirectToAction("Login");
        }

        [HttpGet]
        public async Task<IActionResult> RestorePassword(string ReturnUrl)
        {
            //var l = await _account.BuildLoginViewModelAsync(returnUrl);

            RestorePasswordViewModel model = new RestorePasswordViewModel();
            model.returnUrl = ReturnUrl;

            return View(model);
        }

        [HttpPost]
        public IActionResult RestorePasswordLevelOne(string nationalCode, string phoneNumber)
        {
            if (nationalCode == null || nationalCode.Length != 10
                )
                return new OkObjectResult(new { status = "Nok", message = "کد ملی خالی است" });

            if (phoneNumber == null || phoneNumber.Length != 11)
                return new OkObjectResult(new { status = "Nok", message = "شماره موبایل خالی است" });

            var res = "";
            try
            {
                res = Api.Execute(new Inputs { NationalCode = nationalCode, Mobile = phoneNumber }, "ChangePassword");
                if (res.Equals(Inputs.NikoOK))
                    return new OkObjectResult(new { status = "ok", message = "" });
                return new OkObjectResult(new { status = "Nok", message = res });
            }
            catch (Exception e)
            {
                return new OkObjectResult(new { status = "Nok", message = res + e });
                throw;
            }
        }

        [HttpPost]
        public IActionResult RestorePasswordLevelTwo(string nationalCode, string phoneNumber, string Code, string Password, string ConfirmPassword)
        {
            if (nationalCode == null || nationalCode.Length != 10)
                return new OkObjectResult(new { status = "Nok", message = "کد ملی خالی است" });

            if (phoneNumber == null || phoneNumber.Length != 11)
                return new OkObjectResult(new { status = "Nok", message = "شماره موبایل خالی است" });

            var res = "";
            try
            {
                res = Api.Execute(new Inputs { NationalCode = nationalCode, Mobile = phoneNumber, Code = Code , Password = Password }, "SendChangePasswordActiveCode");
                if (res.Equals(Inputs.NikoOK))
                    return new OkObjectResult(new { status = "ok", message = "" });
                return new OkObjectResult(new { status = "Nok", message = res });
            }
            catch (Exception e)
            {
                return new OkObjectResult(new { status = "Nok", message = res + e });
                throw;
            }
        }

        /// <summary>
        /// Handle postback from username/password login
        /// </summary>

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginInputModel model, string button)
        {
            if (button != "login")
            {
                // the user clicked the "cancel" button
                var context = await _interaction.GetAuthorizationContextAsync(model.ReturnUrl);
                if (context != null)
                {
                    // if the user cancels, send a result back into IdentityServer as if they 
                    // denied the consent (even if this client does not require consent).
                    // this will send back an access denied OIDC error response to the client.
                    await _interaction.GrantConsentAsync(context, ConsentResponse.Denied);

                    // we can trust model.ReturnUrl since GetAuthorizationContextAsync returned non-null
                    return Redirect(model.ReturnUrl);
                }
                else
                {
                    // since we don't have a valid context, then we just go back to the home page
                    return Redirect("~/");
                }
            }

            if (ModelState.IsValid)
            {

                var User = Sql.User.FirstOrDefault(p => p.UserName == model.Username && p.Password == Api.EncryptPassword(model.Password));
                // validate username/password against in-memory store
                if (User != null/* || _users.ValidateCredentials(model.Username, model.Password)*/ )
                {
                    Console.WriteLine(User.Password);
                    LoginDTO login = Api.ToObject<LoginDTO>(Api.Execute(new Inputs { Password = User.Password, NationalCode = User.UserName }, "DeviceLogin"));
                    PersonDTO person = login.Person;
                    if (person == null)
                    {
                        await _events.RaiseAsync(new UserLoginFailureEvent(model.Username, "invalid credentials"));

                        ModelState.AddModelError("", AccountOptions.InvalidCredentialsErrorMessage);
                    }
                    else
                    {

                        if (person.PersonImages == null || person.PersonImages.Count == 0)
                        {
                        }
                        else
                        {
                            var notAccepted = person.PersonImages.Where(p => p.ImageStatusID != ImageStatusCodes.Accepted.ToInt()).ToList();
                            if (notAccepted.Count > 0)
                            {
                                var pending = person.PersonImages.Where(p => p.ImageStatusID == ImageStatusCodes.Pending.ToInt()).ToList();
                                var invalid = person.PersonImages.Where(p => p.ImageStatusID != ImageStatusCodes.Accepted.ToInt() && p.ImageStatusID != ImageStatusCodes.Pending.ToInt()).ToList();
                                if (pending.Count == login.NeedImages.Count || (pending.Count > 0 && invalid.Count == 0))
                                {
                                    // something went wrong, show form with error
                                    var m = await _account.BuildLoginViewModelAsync(model);
                                    m.pleaseWait = true;
                                    return View(m);
                                }
                                else
                                {
                                    InvalidImages invalidModel = new InvalidImages();
                                    invalidModel.PersonID = person.PersonID;
                                    invalidModel.NeededId = invalid.Select(p => p.ImageTypeID).ToList();
                                    invalidModel.returnUrl = model.ReturnUrl;

                                    return RedirectToAction("SendInvalidImages", invalidModel);

                                }
                            }
                        }

                        Console.WriteLine(User.UserName);
                        Dictionary<string, string> dic = new Dictionary<string, string>();
                        dic.Add("UserName", User.UserName);
                        Console.WriteLine(User.UserName);
                        TestUser user = new TestUser
                        {
                            Username = User.UserName,
                            SubjectId = User.Id.ToString(),
                            IsActive = true,
                            ProviderSubjectId = User.UserName,
                            Password = User.Password,
                            ProviderName = User.UserName,
                            Claims = new List<Claim>
                    {

                        new Claim("UserName",User.UserName){ }
                    }
                        };
                        //var user = _users.FindByUsername(model.Username);
                        await _events.RaiseAsync(new UserLoginSuccessEvent(user.Username, user.SubjectId, user.Username));

                        // only set explicit expiration here if user chooses "remember me". 
                        // otherwise we rely upon expiration configured in cookie middleware.
                        AuthenticationProperties props = null;
                        if (AccountOptions.AllowRememberLogin && model.RememberLogin)
                        {
                            props = new AuthenticationProperties
                            {
                                IsPersistent = true,
                                ExpiresUtc = DateTimeOffset.UtcNow.Add(AccountOptions.RememberMeLoginDuration),
                                RedirectUri = "/"
                            };
                        };
                        //user.Claims.Add();
                        // issue authentication cookie with subject ID and username
                        await HttpContext.SignInAsync(new IdentityServerUser(User.UserName), props);

                        Console.WriteLine(model.ReturnUrl);
                        // make sure the returnUrl is still valid, and if so redirect back to authorize endpoint or a local page
                        if (_interaction.IsValidReturnUrl(model.ReturnUrl) || Url.IsLocalUrl(model.ReturnUrl))
                        {
                            return Redirect(model.ReturnUrl);
                        }

                        return Redirect("~/");
                    }


                }

                await _events.RaiseAsync(new UserLoginFailureEvent(model.Username, "invalid credentials"));

                ModelState.AddModelError("", AccountOptions.InvalidCredentialsErrorMessage);
            }

            // something went wrong, show form with error
            var vm = await _account.BuildLoginViewModelAsync(model);
            return View(vm);
        }

        /// <summary>
        /// initiate roundtrip to external authentication provider
        /// </summary>
        [HttpGet]
        public async Task<IActionResult> ExternalLogin(string provider, string returnUrl)
        {
            returnUrl = Url.Action("ExternalLoginCallback", new { returnUrl = returnUrl });

            // windows authentication needs special handling
            // since they don't support the redirect uri, 
            // so this URL is re-triggered when we call challenge
            if (AccountOptions.WindowsAuthenticationSchemeName == provider)
            {
                // see if windows auth has already been requested and succeeded
                var result = await HttpContext.AuthenticateAsync(AccountOptions.WindowsAuthenticationSchemeName);
                if (result?.Principal is WindowsPrincipal wp)
                {
                    var props = new AuthenticationProperties();
                    props.Items.Add("scheme", AccountOptions.WindowsAuthenticationSchemeName);

                    var id = new ClaimsIdentity(provider);
                    id.AddClaim(new Claim(JwtClaimTypes.Subject, wp.Identity.Name));
                    id.AddClaim(new Claim(JwtClaimTypes.Name, wp.Identity.Name));

                    // add the groups as claims -- be careful if the number of groups is too large
                    if (AccountOptions.IncludeWindowsGroups)
                    {
                        var wi = wp.Identity as WindowsIdentity;
                        var groups = wi.Groups.Translate(typeof(NTAccount));
                        var roles = groups.Select(x => new Claim(JwtClaimTypes.Role, x.Value));
                        id.AddClaims(roles);
                    }

                    await HttpContext.SignInAsync(IdentityServer4.IdentityServerConstants.ExternalCookieAuthenticationScheme, new ClaimsPrincipal(id), props);
                    return Redirect(returnUrl);
                }
                else
                {
                    // challenge/trigger windows auth
                    return new ChallengeResult(AccountOptions.WindowsAuthenticationSchemeName);
                }
            }
            else
            {
                // start challenge and roundtrip the return URL
                var props = new AuthenticationProperties
                {
                    RedirectUri = returnUrl,
                    Items = { { "scheme", provider } }
                };
                return new ChallengeResult(provider, props);
            }
        }

        /// <summary>
        /// Post processing of external authentication
        /// </summary>
        [HttpGet]
        public async Task<IActionResult> ExternalLoginCallback(string returnUrl)
        {
            // read external identity from the temporary cookie
            var result = await HttpContext.AuthenticateAsync(IdentityServer4.IdentityServerConstants.ExternalCookieAuthenticationScheme);
            if (result?.Succeeded != true)
            {
                throw new Exception("External authentication error");
            }

            // retrieve claims of the external user
            var externalUser = result.Principal;
            var claims = externalUser.Claims.ToList();

            // try to determine the unique id of the external user (issued by the provider)
            // the most common claim type for that are the sub claim and the NameIdentifier
            // depending on the external provider, some other claim type might be used
            var userIdClaim = claims.FirstOrDefault(x => x.Type == JwtClaimTypes.Subject);
            if (userIdClaim == null)
            {
                userIdClaim = claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier);
            }
            if (userIdClaim == null)
            {
                throw new Exception("Unknown userid");
            }

            // remove the user id claim from the claims collection and move to the userId property
            // also set the name of the external authentication provider
            claims.Remove(userIdClaim);
            var provider = result.Properties.Items["scheme"];
            var userId = userIdClaim.Value;

            // this is where custom logic would most likely be needed to match your users from the
            // external provider's authentication result, and provision the user as you see fit.
            // 
            // check if the external user is already provisioned
            var user = _users.FindByExternalProvider(provider, userId);
            if (user == null)
            {
                // this sample simply auto-provisions new external user
                // another common approach is to start a registrations workflow first
                user = _users.AutoProvisionUser(provider, userId, claims);
            }

            var additionalClaims = new List<Claim>();

            // if the external system sent a session id claim, copy it over
            // so we can use it for single sign-out
            var sid = claims.FirstOrDefault(x => x.Type == JwtClaimTypes.SessionId);
            if (sid != null)
            {
                additionalClaims.Add(new Claim(JwtClaimTypes.SessionId, sid.Value));
            }

            // if the external provider issued an id_token, we'll keep it for signout
            AuthenticationProperties props = null;
            var id_token = result.Properties.GetTokenValue("id_token");
            if (id_token != null)
            {
                props = new AuthenticationProperties();
                props.StoreTokens(new[] { new AuthenticationToken { Name = "id_token", Value = id_token } });
            }

            // issue authentication cookie for user
            await _events.RaiseAsync(new UserLoginSuccessEvent(provider, userId, user.SubjectId, user.Username));
            await HttpContext.SignInAsync(user.SubjectId, user.Username, provider, props, additionalClaims.ToArray());

            // delete temporary cookie used during external authentication
            await HttpContext.SignOutAsync(IdentityServer4.IdentityServerConstants.ExternalCookieAuthenticationScheme);

            // validate return URL and redirect back to authorization endpoint or a local page
            if (_interaction.IsValidReturnUrl(returnUrl) || Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }

            return Redirect("~/");
        }

        /// <summary>
        /// Show logout page
        /// </summary>
        [HttpGet]
        public async Task<IActionResult> Logout(string logoutId)
        {
            // build a model so the logout page knows what to display
            var vm = await _account.BuildLogoutViewModelAsync(logoutId);
            if (vm.ShowLogoutPrompt == false)
            {
                // if the request for logout was properly authenticated from IdentityServer, then
                // we don't need to show the prompt and can just log the user out directly.
                return await Logout(vm);
            }

            return View(vm);
        }

        /// <summary>
        /// Handle logout page postback
        /// </summary>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Logout(LogoutInputModel model)
        {
            // build a model so the logged out page knows what to display
            var vm = await _account.BuildLoggedOutViewModelAsync(model.LogoutId);


            var user = HttpContext.User;
            if (user?.Identity.IsAuthenticated == true)
            {
                // delete local authentication cookie
                await HttpContext.SignOutAsync();

                // raise the logout event
                //await _events.RaiseAsync(new UserLogoutSuccessEvent(user.GetSubjectId(), user.GetName()));
            }

            // check if we need to trigger sign-out at an upstream identity provider
            if (vm.TriggerExternalSignout)
            {
                // build a return URL so the upstream provider will redirect back
                // to us after the user has logged out. this allows us to then
                // complete our single sign-out processing.
                string url = Url.Action("Logout", new { logoutId = vm.LogoutId });

                // this triggers a redirect to the external provider for sign-out
                // hack: try/catch to handle social providers that throw
                return SignOut(new AuthenticationProperties { RedirectUri = url }, vm.ExternalAuthenticationScheme);
            }
            return Redirect(vm.PostLogoutRedirectUri);
            return View("LoggedOut", vm);
        }

        public async Task<IActionResult> RegisterListLevelOne(string NationalCode, string PhoneNumber)
        {

            if (NationalCode == null || NationalCode.Length != 10)
            {
                return new OkObjectResult(new { status = "Nok", message = "کد ملی صحیح نیست" });
            }
            else if (PhoneNumber == null || PhoneNumber.Length != 11)
            {
                return new OkObjectResult(new { status = "Nok", message = "موبایل صحیح نیست" });
            }
            string text = "";
            try
            {
                text = Api.Execute(new Inputs { NationalCode = NationalCode, Mobile = PhoneNumber }, "RegisterValidation");
                if (text.Equals(Inputs.NikoOK))
                    return new OkObjectResult(new { status = "ok" });

                var response = Api.ToObject<Inputs>(text);
                if (response.NikoError != null && response.NikoError != "")
                {
                    var nikoError = Api.ToObject<Inputs>(response.NikoError);
                    return new OkObjectResult(new { status = "Nok", message = nikoError.NikoErrorText });
                }
                return new OkObjectResult(new { status = "Nok", message = "خطایی پیش آمده است" });
            }
            catch (Exception e)
            {

                return new OkObjectResult(new { status = "Nok", message = e.ToString() });
            }

        }

        public async Task<IActionResult> RegisterListLevelTwo(string Name, string FamilyName, string NationalCode, string PhoneNumber, string Password, string Code)
        {


            string text = "";
            try
            {
                text = Api.Execute(new Inputs { Name = Name, FamilyName = FamilyName, NationalCode = NationalCode, Mobile = PhoneNumber, Password = Password, Code = Code }, "SendActiveCode");
                var response = Api.ToObject<Inputs>(text);
                if (response.NikoError != null && response.NikoError != "")
                {
                    var nikoError = Api.ToObject<Inputs>(response.NikoError);
                    return new OkObjectResult(new { status = "Nok", message = nikoError.NikoErrorText });
                }
                else if (response.PersonID != null && response.PersonID > 0)
                {
                    Console.WriteLine(response.PersonID);
                    var user = new AuthenticationService.Data.User { Password = Api.EncryptPassword(Password), UserName = NationalCode };
                    SqlContext.User.Add(user);
                    SqlContext.SaveChange();
                    return new OkObjectResult(new { status = "ok", message = response.PersonID });
                }
                return new OkObjectResult(new { status = "Nok", message = "خطایی پیش آمده است" });
            }
            catch (Exception e)
            {

                return new OkObjectResult(new { status = "Nok", message = Password + "\n" + text });
            }
        }

        public async Task<IActionResult> RegisterListLevelThree(string ImgCartMelli, string ImgPersonally, string ImgSafheAvvaleDaftarche, int PersonId)
        {


            string text = "";
            try
            {
                List<ProfileImage> images = new List<ProfileImage>();
                images.Add(new ProfileImage { Name = ImgCartMelli, Type = ImageTypeCodes.NationalCard.ToInt() });
                images.Add(new ProfileImage { Name = ImgPersonally, Type = ImageTypeCodes.Person.ToInt() });
                images.Add(new ProfileImage { Name = ImgSafheAvvaleDaftarche, Type = ImageTypeCodes.Booklet.ToInt() });

                text = Api.Execute(new Inputs { PersonID = PersonId, ProfileImage = images }, "SendProfileImages");

                if (text.Equals(Inputs.NikoOK))
                    return new OkObjectResult(new { status = "ok" });

                var response = Api.ToObject<Inputs>(text);
                if (response.NikoError != null && response.NikoError != "")
                {
                    var nikoError = Api.ToObject<Inputs>(response.NikoError);
                    return new OkObjectResult(new { status = "Nok", message = nikoError.NikoErrorText });
                }
                return new OkObjectResult(new { status = "Nok", message = "خطایی پیش آمده است" });
            }
            catch (Exception e)
            {

                return new OkObjectResult(new { status = "Nok", message = "\n text : " + text });
            }
        }

        [HttpGet]
        public async Task<IActionResult> ReturnUrl(string url)
        {
            Console.WriteLine(url);
            return Redirect(url);
        }

        [HttpGet]
        public async Task<IActionResult> SendInvalidImages(InvalidImages invalidImages)
        {

            InvalidImagesModel model = new InvalidImagesModel() { returnUrl = invalidImages.returnUrl, PersonID = invalidImages.PersonID };
            foreach (var item in invalidImages.NeededId)
            {

                if (item == ImageTypeCodes.NationalCard.ToInt())
                {
                    model.NationalCard = new PersonImagesDTO() { ImageTypeID = item, ImageTypeName = ExtensionMethods.Description<ImageTypeCodes>((ImageTypeCodes)item) };
                }
                else if (item == ImageTypeCodes.Person.ToInt())
                {
                    model.Person = new PersonImagesDTO() { ImageTypeID = item, ImageTypeName = ExtensionMethods.Description<ImageTypeCodes>((ImageTypeCodes)item) };
                }
                else if (item == ImageTypeCodes.Booklet.ToInt())
                {
                    model.Booklet = new PersonImagesDTO() { ImageTypeID = item, ImageTypeName = ExtensionMethods.Description<ImageTypeCodes>((ImageTypeCodes)item) };
                }

                Console.WriteLine(ExtensionMethods.Description<ImageTypeCodes>((ImageTypeCodes)item));
            }
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> SendInvalidImages(InvalidImagesModel model)
        {
            if (ModelState.IsValid)
            {
                List<ProfileImage> images = new List<ProfileImage>();
                if (model.NationalCardImageID != null)
                    images.Add(new ProfileImage { Name = model.NationalCardImageID, Type = ImageTypeCodes.NationalCard.ToInt() });
                if (model.PersonCardImageID != null)
                    images.Add(new ProfileImage { Name = model.PersonCardImageID, Type = ImageTypeCodes.Person.ToInt() });
                if (model.BookletImageID != null)
                    images.Add(new ProfileImage { Name = model.BookletImageID, Type = ImageTypeCodes.Booklet.ToInt() });

                var text = Api.Execute(new Inputs { PersonID = model.PersonID, ProfileImage = images }, "SendProfileImages");


                if (text.Equals(Inputs.NikoOK))
                    return RedirectToAction("Login", "Account", new { model.returnUrl });

            }
            return View(new InvalidImages());
        }
    }
}