#pragma checksum "C:\Users\Developer151\source\repos\Mountain\Admin\Views\Account\AccessDenied.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e4a7f3fc78796d706385443de20adc566fde8567"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_AccessDenied), @"mvc.1.0.view", @"/Views/Account/AccessDenied.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/AccessDenied.cshtml", typeof(AspNetCore.Views_Account_AccessDenied))]
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
#line 1 "C:\Users\Developer151\source\repos\Mountain\Admin\Views\_ViewImports.cshtml"
using IdentityModel;

#line default
#line hidden
#line 2 "C:\Users\Developer151\source\repos\Mountain\Admin\Views\_ViewImports.cshtml"
using Models;

#line default
#line hidden
#line 3 "C:\Users\Developer151\source\repos\Mountain\Admin\Views\_ViewImports.cshtml"
using Utility.SiteConstants;

#line default
#line hidden
#line 4 "C:\Users\Developer151\source\repos\Mountain\Admin\Views\_ViewImports.cshtml"
using Utility;

#line default
#line hidden
#line 5 "C:\Users\Developer151\source\repos\Mountain\Admin\Views\_ViewImports.cshtml"
using Admin;

#line default
#line hidden
#line 6 "C:\Users\Developer151\source\repos\Mountain\Admin\Views\_ViewImports.cshtml"
using Dto.DeviceDto;

#line default
#line hidden
#line 7 "C:\Users\Developer151\source\repos\Mountain\Admin\Views\_ViewImports.cshtml"
using Dto.Models;

#line default
#line hidden
#line 8 "C:\Users\Developer151\source\repos\Mountain\Admin\Views\_ViewImports.cshtml"
using Domain.Entities;

#line default
#line hidden
#line 12 "C:\Users\Developer151\source\repos\Mountain\Admin\Views\_ViewImports.cshtml"
using Dto.ReturnDto;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4a7f3fc78796d706385443de20adc566fde8567", @"/Views/Account/AccessDenied.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f05761aaccd2c113541316c1be637da3d1e10885", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_AccessDenied : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Developer151\source\repos\Mountain\Admin\Views\Account\AccessDenied.cshtml"
  
    ViewData["Title"] = "غیرمجاز";
    Layout = null;

#line default
#line hidden
            BeginContext(63, 152, true);
            WriteLiteral("    <li class=\"nav-item \">\r\n        <a class=\"nav-link\" href=\"/Account/Logout\">\r\n            <i class=\"material-icons\">bubble_chart</i>\r\n            <p>");
            EndContext();
            BeginContext(216, 14, false);
#line 8 "C:\Users\Developer151\source\repos\Mountain\Admin\Views\Account\AccessDenied.cshtml"
          Write(PanelData.Exit);

#line default
#line hidden
            EndContext();
            BeginContext(230, 113, true);
            WriteLiteral("</p>\r\n        </a>\r\n    </li>\r\n<div style=\"margin:100px auto;\" class=\"text-center\">\r\n    <h2 class=\"text-danger\">");
            EndContext();
            BeginContext(344, 17, false);
#line 12 "C:\Users\Developer151\source\repos\Mountain\Admin\Views\Account\AccessDenied.cshtml"
                       Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(361, 85, true);
            WriteLiteral("</h2>\r\n    <p class=\"text-danger\">شما مجوز استفاده از این بخش را ندارید</p>\r\n</div>\r\n");
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
