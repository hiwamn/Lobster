#pragma checksum "C:\Users\Developer151\source\repos\Mountain\Admin\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c24aa008af3bd7bfe97611383330b3253f2296be"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c24aa008af3bd7bfe97611383330b3253f2296be", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f05761aaccd2c113541316c1be637da3d1e10885", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("navbar-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 33, true);
            WriteLiteral("\r\n\r\n<html  lang=\"fa\" dir=\"rtl\">\r\n");
            EndContext();
            BeginContext(33, 263, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b2b20596a3d44f298d582c895de0eab5", async() => {
                BeginContext(39, 113, true);
                WriteLiteral("\r\n    <meta charset=\"utf-8\" />\r\n    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge,chrome=1\" />\r\n    <title>");
                EndContext();
                BeginContext(153, 15, false);
#line 7 "C:\Users\Developer151\source\repos\Mountain\Admin\Views\Shared\_Layout.cshtml"
      Write(PanelData.Title);

#line default
#line hidden
                EndContext();
                BeginContext(168, 44, true);
                WriteLiteral("</title>\r\n    <meta charset=\"utf-8\" />\r\n    ");
                EndContext();
                BeginContext(213, 33, false);
#line 9 "C:\Users\Developer151\source\repos\Mountain\Admin\Views\Shared\_Layout.cshtml"
Write(Html.Partial("IncludeCSS.cshtml"));

#line default
#line hidden
                EndContext();
                BeginContext(246, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(253, 32, false);
#line 10 "C:\Users\Developer151\source\repos\Mountain\Admin\Views\Shared\_Layout.cshtml"
Write(Html.Partial("IncludeJS.cshtml"));

#line default
#line hidden
                EndContext();
                BeginContext(285, 4, true);
                WriteLiteral("\r\n\r\n");
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
            BeginContext(296, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(298, 11112, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "74f233abb91448458295233f55cd0dac", async() => {
                BeginContext(313, 10, true);
                WriteLiteral("\r\n\r\n\r\n    ");
                EndContext();
                BeginContext(324, 33, false);
#line 16 "C:\Users\Developer151\source\repos\Mountain\Admin\Views\Shared\_Layout.cshtml"
Write(Html.Partial("YesNoModal.cshtml"));

#line default
#line hidden
                EndContext();
                BeginContext(357, 268, true);
                WriteLiteral(@"

    <div class=""wrapper "">
        <div class=""sidebar"" data-color=""purple"" data-background-color=""white"" data-image=""/assets/img/sidebar-1.jpg"">

            <div class=""logo"">
                <a href=""/"" class=""simple-text logo-normal"">
                    ");
                EndContext();
                BeginContext(626, 15, false);
#line 23 "C:\Users\Developer151\source\repos\Mountain\Admin\Views\Shared\_Layout.cshtml"
               Write(PanelData.Title);

#line default
#line hidden
                EndContext();
                BeginContext(641, 334, true);
                WriteLiteral(@"
                </a>
            </div>
            <div class=""sidebar-wrapper"">
                <ul class=""nav"">
                    <li class=""nav-item "">
                        <a class=""nav-link"" href=""/Home/Dashboard"">
                            <i class=""material-icons"">dashboard</i>
                            <p>");
                EndContext();
                BeginContext(976, 19, false);
#line 31 "C:\Users\Developer151\source\repos\Mountain\Admin\Views\Shared\_Layout.cshtml"
                          Write(PanelData.Dashboard);

#line default
#line hidden
                EndContext();
                BeginContext(995, 265, true);
                WriteLiteral(@"</p>
                        </a>
                    </li>
                    <li class=""nav-item "">
                        <a class=""nav-link"" href=""/Users/"">
                            <i class=""material-icons"">person</i>
                            <p>");
                EndContext();
                BeginContext(1261, 15, false);
#line 37 "C:\Users\Developer151\source\repos\Mountain\Admin\Views\Shared\_Layout.cshtml"
                          Write(PanelData.Users);

#line default
#line hidden
                EndContext();
                BeginContext(1276, 279, true);
                WriteLiteral(@"</p>
                        </a>
                    </li>
                    <li class=""nav-item "">
                        <a class=""nav-link"" href=""/Notification/"">
                            <i class=""material-icons"">content_paste</i>
                            <p>");
                EndContext();
                BeginContext(1556, 22, false);
#line 43 "C:\Users\Developer151\source\repos\Mountain\Admin\Views\Shared\_Layout.cshtml"
                          Write(PanelData.Notification);

#line default
#line hidden
                EndContext();
                BeginContext(1578, 63, true);
                WriteLiteral("</p>\r\n                        </a>\r\n                    </li>\r\n");
                EndContext();
                BeginContext(2087, 280, true);
                WriteLiteral(@"                    <li class=""nav-item "">
                        <a class=""nav-link"" href=""/Product/"">
                            <i class=""material-icons"">bubble_chart</i>
                            <p>آگهی ها</p>
                        </a>
                    </li>
");
                EndContext();
                BeginContext(3256, 215, true);
                WriteLiteral("                    <li class=\"nav-item \">\r\n                        <a class=\"nav-link\" href=\"/Setting/Index\">\r\n                            <i class=\"material-icons\">bubble_chart</i>\r\n                            <p>");
                EndContext();
                BeginContext(3472, 17, false);
#line 82 "C:\Users\Developer151\source\repos\Mountain\Admin\Views\Shared\_Layout.cshtml"
                          Write(PanelData.Weather);

#line default
#line hidden
                EndContext();
                BeginContext(3489, 278, true);
                WriteLiteral(@"</p>
                        </a>
                    </li>
                    <li class=""nav-item "">
                        <a class=""nav-link"" href=""/Setting/Index"">
                            <i class=""material-icons"">bubble_chart</i>
                            <p>");
                EndContext();
                BeginContext(3768, 19, false);
#line 88 "C:\Users\Developer151\source\repos\Mountain\Admin\Views\Shared\_Layout.cshtml"
                          Write(PanelData.Knowledge);

#line default
#line hidden
                EndContext();
                BeginContext(3787, 278, true);
                WriteLiteral(@"</p>
                        </a>
                    </li>
                    <li class=""nav-item "">
                        <a class=""nav-link"" href=""/Setting/Index"">
                            <i class=""material-icons"">bubble_chart</i>
                            <p>");
                EndContext();
                BeginContext(4066, 17, false);
#line 94 "C:\Users\Developer151\source\repos\Mountain\Admin\Views\Shared\_Layout.cshtml"
                          Write(PanelData.Setting);

#line default
#line hidden
                EndContext();
                BeginContext(4083, 279, true);
                WriteLiteral(@"</p>
                        </a>
                    </li>
                    <li class=""nav-item "">
                        <a class=""nav-link"" href=""/Account/Logout"">
                            <i class=""material-icons"">bubble_chart</i>
                            <p>");
                EndContext();
                BeginContext(4363, 14, false);
#line 100 "C:\Users\Developer151\source\repos\Mountain\Admin\Views\Shared\_Layout.cshtml"
                          Write(PanelData.Exit);

#line default
#line hidden
                EndContext();
                BeginContext(4377, 63, true);
                WriteLiteral("</p>\r\n                        </a>\r\n                    </li>\r\n");
                EndContext();
                BeginContext(5054, 175, true);
                WriteLiteral("                    <li class=\"nav-item active  \">\r\n                        <a class=\"nav-link\" href=\"/\">\r\n                            <i class=\"material-icons\">language</i>\r\n");
                EndContext();
#line 118 "C:\Users\Developer151\source\repos\Mountain\Admin\Views\Shared\_Layout.cshtml"
                              
                                var s = (350 / PanelData.PanelManagementText.Length).ToString() + "px;";
                            

#line default
#line hidden
                BeginContext(5398, 30, true);
                WriteLiteral("                            <p");
                EndContext();
                BeginWriteAttribute("style", " style=\"", 5428, "\"", 5448, 2);
                WriteAttributeValue("", 5436, "font-size:", 5436, 10, true);
#line 121 "C:\Users\Developer151\source\repos\Mountain\Admin\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 5446, s, 5446, 2, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(5449, 1, true);
                WriteLiteral(">");
                EndContext();
                BeginContext(5451, 29, false);
#line 121 "C:\Users\Developer151\source\repos\Mountain\Admin\Views\Shared\_Layout.cshtml"
                                               Write(PanelData.PanelManagementText);

#line default
#line hidden
                EndContext();
                BeginContext(5480, 285, true);
                WriteLiteral(@"</p>
                        </a>
                    </li>
                    <li class=""nav-item active-pro "">
                        <a class=""nav-link"" href=""www.erenco.ir"">
                            <i class=""material-icons"">unarchive</i>
                            <p>");
                EndContext();
                BeginContext(5766, 18, false);
#line 127 "C:\Users\Developer151\source\repos\Mountain\Admin\Views\Shared\_Layout.cshtml"
                          Write(PanelData.DesignBy);

#line default
#line hidden
                EndContext();
                BeginContext(5784, 436, true);
                WriteLiteral(@"</p>
                        </a>
                    </li>
                </ul>
            </div>
        </div>
        <div class=""main-panel"">
            <!-- Navbar -->
            <nav class=""navbar navbar-expand-lg navbar-transparent navbar-absolute fixed-top "">
                <div class=""container-fluid"">
                    <div class=""navbar-wrapper"">
                        <a class=""navbar-brand"" href=""/"">");
                EndContext();
                BeginContext(6221, 29, false);
#line 138 "C:\Users\Developer151\source\repos\Mountain\Admin\Views\Shared\_Layout.cshtml"
                                                    Write(PanelData.PanelManagementText);

#line default
#line hidden
                EndContext();
                BeginContext(6250, 674, true);
                WriteLiteral(@"</a>
                    </div>
                    <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" aria-controls=""navigation-index"" aria-expanded=""false""
                            aria-label=""Toggle navigation"">
                        <span class=""sr-only"">Toggle navigation</span>
                        <span class=""navbar-toggler-icon icon-bar""></span>
                        <span class=""navbar-toggler-icon icon-bar""></span>
                        <span class=""navbar-toggler-icon icon-bar""></span>
                    </button>
                    <div class=""collapse navbar-collapse justify-content-end"">
                        ");
                EndContext();
                BeginContext(6924, 559, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ed7614d47da04a8fa373236a7d2aa8cd", async() => {
                    BeginContext(6950, 526, true);
                    WriteLiteral(@"
                            <div class=""input-group no-border"">
                                <input type=""text"" value="""" class=""form-control"" placeholder=""جستجو..."">
                                <button type=""submit"" class=""btn btn-white btn-round btn-just-icon"">
                                    <i class=""material-icons"">search</i>
                                    <div class=""ripple-container""></div>
                                </button>
                            </div>
                        ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(7483, 586, true);
                WriteLiteral(@"
                        <ul class=""navbar-nav"">
                            <li class=""nav-item"">
                                <a class=""nav-link"" href=""/"">
                                    <i class=""material-icons"">dashboard</i>
                                    <p class=""d-lg-none d-md-block"">
                                        آمارها
                                    </p>
                                </a>
                            </li>
                            <li class=""nav-item dropdown"">
                                <a class=""nav-link""");
                EndContext();
                BeginWriteAttribute("href", " href=", 8069, "", 8094, 1);
#line 167 "C:\Users\Developer151\source\repos\Mountain\Admin\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 8075, PanelData.HostName, 8075, 19, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(8094, 1746, true);
                WriteLiteral(@" + id=""navbarDropdownMenuLink"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                                    <i class=""material-icons"">notifications</i>
                                    <span class=""notification"">۵</span>
                                    <p class=""d-lg-none d-md-block"">
                                        اعلان‌ها
                                    </p>
                                </a>
                                <div class=""dropdown-menu dropdown-menu-right"" aria-labelledby=""navbarDropdownMenuLink"">
                                    <a class=""dropdown-item"" href=""#"">محمدرضا به ایمیل شما پاسخ داد</a>
                                    <a class=""dropdown-item"" href=""#"">شما ۵ وظیفه جدید دارید</a>
                                    <a class=""dropdown-item"" href=""#"">از حالا شما با علیرضا دوست هستید</a>
                                    <a class=""dropdown-item"" href=""#"">اعلان دیگر</a>
                                    <a class=""dropdo");
                WriteLiteral(@"wn-item"" href=""#"">اعلان دیگر</a>
                                </div>
                            </li>
                            <li class=""nav-item"">
                                <a class=""nav-link"" href=""/"">
                                    <i class=""material-icons"">person</i>
                                    <p class=""d-lg-none d-md-block"">
                                        حساب کاربری
                                    </p>
                                </a>
                            </li>
                        </ul>
                    </div>
                </div>
            </nav>
            <!-- End Navbar -->
            <div class=""content"">
                ");
                EndContext();
                BeginContext(9841, 12, false);
#line 196 "C:\Users\Developer151\source\repos\Mountain\Admin\Views\Shared\_Layout.cshtml"
           Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(9853, 306, true);
                WriteLiteral(@"
                <footer class=""footer"">
                    <div class=""container-fluid"">
                        <nav class=""float-left"">
                            <ul>
                                <li>
                                    <a href=""/"">
                                        ");
                EndContext();
                BeginContext(10160, 15, false);
#line 203 "C:\Users\Developer151\source\repos\Mountain\Admin\Views\Shared\_Layout.cshtml"
                                   Write(PanelData.Title);

#line default
#line hidden
                EndContext();
                BeginContext(10175, 693, true);
                WriteLiteral(@"
                                    </a>
                                </li>
                                <li>
                                    <a href=""/"">
                                        درباره ما
                                    </a>
                                </li>

                            </ul>
                        </nav>
                        <div class=""copyright float-right"">
                            &copy;
                            <script>
                                document.write(new Date().getFullYear())
                            </script>ساخته شده
                            توسط
                            <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 10868, "\"", 10901, 1);
#line 220 "C:\Users\Developer151\source\repos\Mountain\Admin\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 10875, PanelData.DesignerWebsite, 10875, 26, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(10902, 17, true);
                WriteLiteral(" target=\"_blank\">");
                EndContext();
                BeginContext(10920, 14, false);
#line 220 "C:\Users\Developer151\source\repos\Mountain\Admin\Views\Shared\_Layout.cshtml"
                                                                            Write(PanelData.Team);

#line default
#line hidden
                EndContext();
                BeginContext(10934, 419, true);
                WriteLiteral(@"</a>
                        </div>
                    </div>
                </footer>
            </div>
        </div>

        <script src=""https://cdnjs.cloudflare.com/ajax/libs/jquery-validate/1.17.0/jquery.validate.min.js""></script>
        <script src=""https://cdnjs.cloudflare.com/ajax/libs/jquery-validation-unobtrusive/3.2.11/jquery.validate.unobtrusive.min.js""></script>
    </div>





    ");
                EndContext();
                BeginContext(11354, 41, false);
#line 235 "C:\Users\Developer151\source\repos\Mountain\Admin\Views\Shared\_Layout.cshtml"
Write(RenderSection("Scripts", required: false));

#line default
#line hidden
                EndContext();
                BeginContext(11395, 8, true);
                WriteLiteral("\r\n\r\n\r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(11410, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
