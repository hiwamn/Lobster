using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CoreExtension
{
    public class BaseController : Controller
    {
        public ICompositeViewEngine viewEngine { get; set; }
        public BaseController(ICompositeViewEngine viewEngine)
        {
            this.viewEngine = viewEngine;
        }

        //Put in BaseController
        public string RenderPartialViewToString(string viewName, object model)
        {
            viewName = viewName ?? ControllerContext.ActionDescriptor.ActionName;
            ViewData.Model = model;
            using (StringWriter sw = new StringWriter())
            {
                IView view = viewEngine.FindView(ControllerContext, viewName, false).View;
                ViewContext viewContext = new ViewContext(ControllerContext, view, ViewData, TempData, sw, new HtmlHelperOptions());
                view.RenderAsync(viewContext).Wait();
                return sw.GetStringBuilder().ToString();
            }
        }
    }
}
