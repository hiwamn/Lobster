#pragma checksum "C:\Users\Developer151\source\repos\Mountain\Site\Views\Account\SignedOut.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f2a5ff5c9b72cda52d13bb9b16e5ad629744769"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_SignedOut), @"mvc.1.0.view", @"/Views/Account/SignedOut.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/SignedOut.cshtml", typeof(AspNetCore.Views_Account_SignedOut))]
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
#line 1 "C:\Users\Developer151\source\repos\Mountain\Site\Views\_ViewImports.cshtml"
using IdentityModel;

#line default
#line hidden
#line 2 "C:\Users\Developer151\source\repos\Mountain\Site\Views\_ViewImports.cshtml"
using Utility.SiteConstants;

#line default
#line hidden
#line 3 "C:\Users\Developer151\source\repos\Mountain\Site\Views\_ViewImports.cshtml"
using Models;

#line default
#line hidden
#line 4 "C:\Users\Developer151\source\repos\Mountain\Site\Views\_ViewImports.cshtml"
using Domain.Entities;

#line default
#line hidden
#line 5 "C:\Users\Developer151\source\repos\Mountain\Site\Views\_ViewImports.cshtml"
using Dto.ReturnDto;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f2a5ff5c9b72cda52d13bb9b16e5ad629744769", @"/Views/Account/SignedOut.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"126a16d88fe6f54d5a4883b7ccf28e7067314ff6", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_SignedOut : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Developer151\source\repos\Mountain\Site\Views\Account\SignedOut.cshtml"
  
    ViewData["Title"] = "Signed out";
    Layout = null;


#line default
#line hidden
            BeginContext(68, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(75, 17, false);
#line 7 "C:\Users\Developer151\source\repos\Mountain\Site\Views\Account\SignedOut.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(92, 57, true);
            WriteLiteral("</h2>\r\n<p>\r\n    You have successfully signed out.\r\n</p>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591