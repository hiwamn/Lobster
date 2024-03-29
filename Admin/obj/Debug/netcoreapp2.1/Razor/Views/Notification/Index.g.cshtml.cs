#pragma checksum "C:\Users\Developer151\source\repos\Mountain\Admin\Views\Notification\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "610a2e27615f10fe93f9655c369263964ecef3d7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Notification_Index), @"mvc.1.0.view", @"/Views/Notification/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Notification/Index.cshtml", typeof(AspNetCore.Views_Notification_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"610a2e27615f10fe93f9655c369263964ecef3d7", @"/Views/Notification/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f05761aaccd2c113541316c1be637da3d1e10885", @"/Views/_ViewImports.cshtml")]
    public class Views_Notification_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<User>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/loading.gif"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("30"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("30"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Developer151\source\repos\Mountain\Admin\Views\Notification\Index.cshtml"
  
    bool ForSave = true;

#line default
#line hidden
            BeginContext(52, 1778, true);
            WriteLiteral(@"<div class=""row"">

    <div class=""col-md-12"">
        <div class=""row m-4"">
            <textarea placeholder=""متن مورد نظر را وارد کنید"" rows=""5"" style=""width:100%;"" id=""not""></textarea>
        </div>
        <div class=""row m-4"">

            <div class=""col-m-1"">
                <button class=""btn btn-danger"" onclick=""Send()"">ارسال</button>
                <div class=""row"">
                    <div class=""col-md-12"">
                        <div class=""progress-outer"">
                            <div class=""progress"" id=""progDiv"" style=""visibility:hidden"">
                                <div id=""prog"" class=""progress-bar progress-bar-striped progress-bar-danger"" style=""width:0%;""></div>
                                <div class=""progress-value""><span id=""percent"">0</span>%</div>
                            </div>
                        </div>

                    </div>
                </div>
            </div>
        </div>
        <div class=""row m-4"">
            <div clas");
            WriteLiteral(@"s=""card"">
                <div class=""card-header card-header-primary m-4"">
                    <h4 class=""card-title "">وضعیت ارسال</h4>
                    <p class=""card-category""> اینجا وضعیت ارسال به کاربران را مشاهده می کنید</p>
                </div>
                <div class=""card-body table-responsive"">
                    <table class=""table table-hover"">
                        <thead class=""text-warning"">
                        <th>ردیف</th>
                        <th>وضعیت</th>
                        <th>نام</th>
                        <th>نام خانوادگی</th>
                        <th>شماره همراه</th>
                        <th>تاریخ ثبت نام</th>
                        </thead>
                        <tbody>
");
            EndContext();
#line 45 "C:\Users\Developer151\source\repos\Mountain\Admin\Views\Notification\Index.cshtml"
                             for (int i = 0; i < Model.Count; i++)
                            {
                                var item = Model[i];

#line default
#line hidden
            BeginContext(1983, 120, true);
            WriteLiteral("                                <tr>\r\n                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(2105, 5, false);
#line 50 "C:\Users\Developer151\source\repos\Mountain\Admin\Views\Notification\Index.cshtml"
                                    Write(i + 1);

#line default
#line hidden
            EndContext();
            BeginContext(2111, 85, true);
            WriteLiteral("\r\n                                    </td>\r\n                                    <th>");
            EndContext();
            BeginContext(2196, 75, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "59485403f1c14fbcaffe12db6298dedf", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 52 "C:\Users\Developer151\source\repos\Mountain\Admin\Views\Notification\Index.cshtml"
AddHtmlAttributeValue("", 2205, Model[i].Id, 2205, 12, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2271, 89, true);
            WriteLiteral("</th>\r\n                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(2361, 9, false);
#line 54 "C:\Users\Developer151\source\repos\Mountain\Admin\Views\Notification\Index.cshtml"
                                   Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2370, 127, true);
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(2498, 15, false);
#line 57 "C:\Users\Developer151\source\repos\Mountain\Admin\Views\Notification\Index.cshtml"
                                   Write(item.FamilyName);

#line default
#line hidden
            EndContext();
            BeginContext(2513, 127, true);
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(2641, 16, false);
#line 60 "C:\Users\Developer151\source\repos\Mountain\Admin\Views\Notification\Index.cshtml"
                                   Write(item.PhoneNumber);

#line default
#line hidden
            EndContext();
            BeginContext(2657, 150, true);
            WriteLiteral("\r\n                                    </td>\r\n\r\n                                    <td class=\"text-primary\">\r\n                                        ");
            EndContext();
            BeginContext(2808, 43, false);
#line 64 "C:\Users\Developer151\source\repos\Mountain\Admin\Views\Notification\Index.cshtml"
                                   Write(item.RegisterDate.ToPersianDateLongString());

#line default
#line hidden
            EndContext();
            BeginContext(2851, 84, true);
            WriteLiteral("\r\n                                    </td>\r\n                                </tr>\r\n");
            EndContext();
#line 67 "C:\Users\Developer151\source\repos\Mountain\Admin\Views\Notification\Index.cshtml"
                            }

#line default
#line hidden
            BeginContext(2966, 387, true);
            WriteLiteral(@"

                        </tbody>
                    </table>
                </div>
            </div>
        </div>
    </div>


</div>

<script>
        function Send() {
            var text = document.getElementById('not').value;
            if (text == '') {
                alert('متن را وارد کنید');
                return;
            }

            if ('");
            EndContext();
            BeginContext(3354, 11, false);
#line 88 "C:\Users\Developer151\source\repos\Mountain\Admin\Views\Notification\Index.cshtml"
            Write(Model.Count);

#line default
#line hidden
            EndContext();
            BeginContext(3365, 411, true);
            WriteLiteral(@"' == 0) {
                alert('یوزری وجود ندارد');
                return;
            }
            var progDiv = document.getElementById('progDiv');
            var prog = document.getElementById('prog');
            var percent = document.getElementById('percent');
            prog.style.width = 0;
            percent.innerHTML = 0 + 'px';
            progDiv.style.visibility = 'visible';


");
            EndContext();
#line 100 "C:\Users\Developer151\source\repos\Mountain\Admin\Views\Notification\Index.cshtml"
         foreach (var d in Model.ToList())
        {

#line default
#line hidden
            BeginContext(3831, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(3845, 25, true);
            WriteLiteral("document.getElementById(\'");
            EndContext();
            BeginContext(3871, 4, false);
#line 102 "C:\Users\Developer151\source\repos\Mountain\Admin\Views\Notification\Index.cshtml"
                                  Write(d.Id);

#line default
#line hidden
            EndContext();
            BeginContext(3875, 33, true);
            WriteLiteral("\').src = \"/images/loading.gif\";\r\n");
            EndContext();
#line 103 "C:\Users\Developer151\source\repos\Mountain\Admin\Views\Notification\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(3919, 51, true);
            WriteLiteral("\r\n            var i = 0;\r\n            var count = \'");
            EndContext();
            BeginContext(3971, 11, false);
#line 106 "C:\Users\Developer151\source\repos\Mountain\Admin\Views\Notification\Index.cshtml"
                    Write(Model.Count);

#line default
#line hidden
            EndContext();
            BeginContext(3982, 32, true);
            WriteLiteral("\';\r\n        //var save = true;\r\n");
            EndContext();
#line 108 "C:\Users\Developer151\source\repos\Mountain\Admin\Views\Notification\Index.cshtml"
     foreach (var d in Model)
    {

#line default
#line hidden
            BeginContext(4052, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(4062, 18, true);
            WriteLiteral("i++;\r\n            ");
            EndContext();
            BeginContext(4082, 22, true);
            WriteLiteral("var sendData = { Id: \'");
            EndContext();
            BeginContext(4105, 4, false);
#line 111 "C:\Users\Developer151\source\repos\Mountain\Admin\Views\Notification\Index.cshtml"
                               Write(d.Id);

#line default
#line hidden
            EndContext();
            BeginContext(4109, 21, true);
            WriteLiteral("\', text: text, save: ");
            EndContext();
            BeginContext(4131, 28, false);
#line 111 "C:\Users\Developer151\source\repos\Mountain\Admin\Views\Notification\Index.cshtml"
                                                         Write(ForSave.ToString().ToLower());

#line default
#line hidden
            EndContext();
            BeginContext(4159, 17, true);
            WriteLiteral(" };\r\n            ");
            EndContext();
            BeginContext(4178, 58, true);
            WriteLiteral("AJX.post(\"/Notification/Send\", sendData, function (ok) {\r\n");
            EndContext();
            BeginContext(4238, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(4256, 25, true);
            WriteLiteral("document.getElementById(\'");
            EndContext();
            BeginContext(4282, 4, false);
#line 114 "C:\Users\Developer151\source\repos\Mountain\Admin\Views\Notification\Index.cshtml"
                                      Write(d.Id);

#line default
#line hidden
            EndContext();
            BeginContext(4286, 42, true);
            WriteLiteral("\').src = \"/images/tick.png\";\r\n            ");
            EndContext();
            BeginContext(4330, 5, true);
            WriteLiteral("});\r\n");
            EndContext();
            BeginContext(4341, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(4351, 106, true);
            WriteLiteral("prog.style.width = (i / count * 100).toFixed(0) + \'%\'; percent.innerHTML = (i / count * 100).toFixed(0);\r\n");
            EndContext();
#line 120 "C:\Users\Developer151\source\repos\Mountain\Admin\Views\Notification\Index.cshtml"


    }

#line default
#line hidden
            BeginContext(4468, 180, true);
            WriteLiteral("\r\n        progDiv.style.visibility = \'hidden\';\r\n        prog.style.width = 0;\r\n        percent.innerHTML = 0 + \'px\';\r\n        alert(\'ارسال با موفقیت انجام شد\');\r\n\r\n}\r\n</script>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<User>> Html { get; private set; }
    }
}
#pragma warning restore 1591
