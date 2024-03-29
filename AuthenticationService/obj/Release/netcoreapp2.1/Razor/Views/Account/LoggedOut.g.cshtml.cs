#pragma checksum "E:\192.168.30.19\NikoProject\NikoApi\AuthenticationService\Views\Account\LoggedOut.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4bab88c0b5077e2d5f7f4c2cdf41a0405feaa30a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_LoggedOut), @"mvc.1.0.view", @"/Views/Account/LoggedOut.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/LoggedOut.cshtml", typeof(AspNetCore.Views_Account_LoggedOut))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "E:\192.168.30.19\NikoProject\NikoApi\AuthenticationService\Views\_ViewImports.cshtml"
using IdentityServer4.Quickstart.UI;

#line default
#line hidden
#line 3 "E:\192.168.30.19\NikoProject\NikoApi\AuthenticationService\Views\_ViewImports.cshtml"
using AuthenticationService.Models;

#line default
#line hidden
#line 4 "E:\192.168.30.19\NikoProject\NikoApi\AuthenticationService\Views\_ViewImports.cshtml"
using AuthenticationService.Classes;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4bab88c0b5077e2d5f7f4c2cdf41a0405feaa30a", @"/Views/Account/LoggedOut.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6873e5cb29ea8744398a8647b37f56eb0b2efc0", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_LoggedOut : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LoggedOutViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/signout-redirect.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "E:\192.168.30.19\NikoProject\NikoApi\AuthenticationService\Views\Account\LoggedOut.cshtml"
  
    // set this so the layout rendering sees an anonymous user
    ViewData["signed-out"] = true;

#line default
#line hidden
            BeginContext(134, 111, true);
            WriteLiteral("\r\n<div class=\"jumbotron\">\r\n    <h1>\r\n        Logout\r\n        <small>You are now logged out</small>\r\n    </h1>\r\n");
            EndContext();
#line 12 "E:\192.168.30.19\NikoProject\NikoApi\AuthenticationService\Views\Account\LoggedOut.cshtml"
     if (Model.PostLogoutRedirectUri != null)
    {

#line default
#line hidden
            BeginContext(299, 65, true);
            WriteLiteral("        <div>\r\n            Click <a class=\"PostLogoutRedirectUri\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 364, "\"", 399, 1);
#line 15 "E:\192.168.30.19\NikoProject\NikoApi\AuthenticationService\Views\Account\LoggedOut.cshtml"
WriteAttributeValue("", 371, Model.PostLogoutRedirectUri, 371, 28, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(400, 46, true);
            WriteLiteral(">here</a> to return to the\r\n            <span>");
            EndContext();
            BeginContext(447, 16, false);
#line 16 "E:\192.168.30.19\NikoProject\NikoApi\AuthenticationService\Views\Account\LoggedOut.cshtml"
             Write(Model.ClientName);

#line default
#line hidden
            EndContext();
            BeginContext(463, 38, true);
            WriteLiteral("</span> application.\r\n        </div>\r\n");
            EndContext();
#line 18 "E:\192.168.30.19\NikoProject\NikoApi\AuthenticationService\Views\Account\LoggedOut.cshtml"
    }

#line default
#line hidden
            BeginContext(508, 4, true);
            WriteLiteral("    ");
            EndContext();
#line 19 "E:\192.168.30.19\NikoProject\NikoApi\AuthenticationService\Views\Account\LoggedOut.cshtml"
     if (Model.SignOutIframeUrl != null)
    {

#line default
#line hidden
            BeginContext(557, 52, true);
            WriteLiteral("        <iframe width=\"0\" height=\"0\" class=\"signout\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 609, "\"", 638, 1);
#line 21 "E:\192.168.30.19\NikoProject\NikoApi\AuthenticationService\Views\Account\LoggedOut.cshtml"
WriteAttributeValue("", 615, Model.SignOutIframeUrl, 615, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(639, 12, true);
            WriteLiteral("></iframe>\r\n");
            EndContext();
#line 22 "E:\192.168.30.19\NikoProject\NikoApi\AuthenticationService\Views\Account\LoggedOut.cshtml"
    }

#line default
#line hidden
            BeginContext(658, 8, true);
            WriteLiteral("</div>\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(689, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 26 "E:\192.168.30.19\NikoProject\NikoApi\AuthenticationService\Views\Account\LoggedOut.cshtml"
     if (Model.AutomaticRedirectAfterSignOut)
    {

#line default
#line hidden
                BeginContext(745, 8, true);
                WriteLiteral("        ");
                EndContext();
                BeginContext(753, 48, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "af50aefca2994ea29bbd6e7bd14116a9", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(801, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 29 "E:\192.168.30.19\NikoProject\NikoApi\AuthenticationService\Views\Account\LoggedOut.cshtml"
    }

#line default
#line hidden
            }
            );
            BeginContext(813, 97, true);
            WriteLiteral("<script>\r\n    $(document).ready(function () {\r\n        alert();\r\n        window.location.href = \'");
            EndContext();
            BeginContext(911, 27, false);
#line 34 "E:\192.168.30.19\NikoProject\NikoApi\AuthenticationService\Views\Account\LoggedOut.cshtml"
                           Write(Model.PostLogoutRedirectUri);

#line default
#line hidden
            EndContext();
            BeginContext(938, 30, true);
            WriteLiteral("\';\r\n    });\r\n    \r\n</script>\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LoggedOutViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
