#pragma checksum "C:\Users\Developer151\source\repos\Mountain\Site\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0c0a8770d6fea8135632d12d7d18e4e09a5a7b53"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_Layout.cshtml", typeof(AspNetCore.Views_Shared__Layout))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c0a8770d6fea8135632d12d7d18e4e09a5a7b53", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"126a16d88fe6f54d5a4883b7ccf28e7067314ff6", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 37, true);
            WriteLiteral("<!DOCTYPE HTML>\r\n\r\n<html dir=\"rtl\">\r\n");
            EndContext();
            BeginContext(37, 127, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a0a84d6ca9a04619864de0e0e938c25f", async() => {
                BeginContext(43, 13, true);
                WriteLiteral("\r\n    <title>");
                EndContext();
                BeginContext(57, 14, false);
#line 5 "C:\Users\Developer151\source\repos\Mountain\Site\Views\Shared\_Layout.cshtml"
      Write(SiteData.Title);

#line default
#line hidden
                EndContext();
                BeginContext(71, 44, true);
                WriteLiteral("</title>\r\n    <meta charset=\"utf-8\" />\r\n    ");
                EndContext();
                BeginContext(116, 33, false);
#line 7 "C:\Users\Developer151\source\repos\Mountain\Site\Views\Shared\_Layout.cshtml"
Write(Html.Partial("IncludeCSS.cshtml"));

#line default
#line hidden
                EndContext();
                BeginContext(149, 8, true);
                WriteLiteral("\r\n    \r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(164, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(166, 256, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "55ecba4e7e0c486d92fe7ce8f206f554", async() => {
                BeginContext(181, 8, true);
                WriteLiteral("\r\n\r\n    ");
                EndContext();
                BeginContext(190, 29, false);
#line 12 "C:\Users\Developer151\source\repos\Mountain\Site\Views\Shared\_Layout.cshtml"
Write(Html.Partial("Header.cshtml"));

#line default
#line hidden
                EndContext();
                BeginContext(219, 8, true);
                WriteLiteral("\r\n\r\n    ");
                EndContext();
                BeginContext(228, 29, false);
#line 14 "C:\Users\Developer151\source\repos\Mountain\Site\Views\Shared\_Layout.cshtml"
Write(Html.Partial("Banner.cshtml"));

#line default
#line hidden
                EndContext();
                BeginContext(257, 8, true);
                WriteLiteral("\r\n\r\n    ");
                EndContext();
                BeginContext(266, 32, false);
#line 16 "C:\Users\Developer151\source\repos\Mountain\Site\Views\Shared\_Layout.cshtml"
Write(Html.Partial("IncludeJS.cshtml"));

#line default
#line hidden
                EndContext();
                BeginContext(298, 8, true);
                WriteLiteral("\r\n\r\n    ");
                EndContext();
                BeginContext(307, 12, false);
#line 18 "C:\Users\Developer151\source\repos\Mountain\Site\Views\Shared\_Layout.cshtml"
Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(319, 8, true);
                WriteLiteral("\r\n\r\n    ");
                EndContext();
                BeginContext(328, 29, false);
#line 20 "C:\Users\Developer151\source\repos\Mountain\Site\Views\Shared\_Layout.cshtml"
Write(Html.Partial("Footer.cshtml"));

#line default
#line hidden
                EndContext();
                BeginContext(357, 8, true);
                WriteLiteral("\r\n\r\n    ");
                EndContext();
                BeginContext(366, 41, false);
#line 22 "C:\Users\Developer151\source\repos\Mountain\Site\Views\Shared\_Layout.cshtml"
Write(RenderSection("Scripts", required: false));

#line default
#line hidden
                EndContext();
                BeginContext(407, 8, true);
                WriteLiteral("\r\n\r\n\r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(422, 9, true);
            WriteLiteral("\r\n</html>");
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
