using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Newtonsoft.Json;
using NikoCore;
using System;
using System.Diagnostics;
using System.Net;
using System.Net.Http;

namespace ZigoratApp.Classes
{
    public class CustomExceptionFilter : Attribute, IExceptionFilter
    {
        private readonly IModelMetadataProvider _modelMetadataProvider;
        public CustomExceptionFilter(IModelMetadataProvider modelMetadataProvider)
        {
            _modelMetadataProvider = modelMetadataProvider;
        }
        public void OnException(ExceptionContext context)
        {
            Console.Write(context.Exception);
            context.ExceptionHandled = true;
            context.Result = new StatusCodeResult(504);
            context.Result = new RedirectResult(@"/ProcessResult/Error?description=" + context.Exception);/*new OkObjectResult(Api.GetError(context.Exception));*/

            //if (context.HttpContext.Request.IsAjaxRequest())
            //{
            //    context.Result = new StatusCodeResult(ErrorHandler.StatusCode);
            //}
            //else
            //{
            //    ViewResult view = new ViewResult();
            //    view.ViewName = "Error";
            //    view.ViewData = new ViewDataDictionary(_modelMetadataProvider, context.ModelState);
            //    view.ViewData.Model = ErrorHandler.ErrorMessage;
            //    context.Result = view;
            //}
        }


    }


    public class CustomValidationFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            //if (!context.HttpContext.Request.IsAjaxRequest())
            //    return;

            //if (context.ModelState.IsValid)
            //    return;

            //var ListError = (from state in context.ModelState.Values
            //                 from error in state.Errors
            //                 select error.ErrorMessage).ToList();

            //string str = "خطا";
            //foreach (var item in ListError)
            //{
            //    str += "\n - " + item;
            //}

            context.Result = new OkObjectResult(new { isNotValid = true, errorMessage = "Hiwa" });
        }
    }
}
