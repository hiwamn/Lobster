#pragma checksum "C:\Users\Developer151\source\repos\Mountain\Admin\Views\Shared\YesNoModal.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3cd445df0bd7c655384ceef7617338973ed92cab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_YesNoModal), @"mvc.1.0.view", @"/Views/Shared/YesNoModal.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/YesNoModal.cshtml", typeof(AspNetCore.Views_Shared_YesNoModal))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3cd445df0bd7c655384ceef7617338973ed92cab", @"/Views/Shared/YesNoModal.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f05761aaccd2c113541316c1be637da3d1e10885", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_YesNoModal : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 999, true);
            WriteLiteral(@"

<!--Modal: modalConfirmDelete-->
<div class=""modal fade"" id=""modalConfirmDelete"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel""
     aria-hidden=""true"">
    <div class=""modal-dialog modal-sm modal-notify modal-danger"" role=""document"">
        <!--Content-->
        <div class=""modal-content text-center"">
            <!--Header-->
            <div class=""modal-header d-flex justify-content-center"">
                <p class=""heading"">مطمئنی?</p>
            </div>

            <!--Body-->
            <div class=""modal-body"">

                <i class=""fas fa-times fa-4x animated rotateIn""></i>

            </div>

            <!--Footer-->
            <div class=""modal-footer flex-center"">
                <a data-dismiss=""modal"" class=""btn  btn-outline-danger"">بله</a>
                <a type=""button"" class=""btn  btn-danger waves-effect"" data-dismiss=""modal"">خیر</a>
            </div>
        </div>
        <!--/.Content-->
    </div>
</div>");
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
