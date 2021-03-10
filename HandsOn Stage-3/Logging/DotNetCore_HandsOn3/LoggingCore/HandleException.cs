using LoggingCore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoggingCore
{
    public class HandleException : ExceptionFilterAttribute
    {
        public readonly ILoggerManager _logger;

        public HandleException()
        {
            _logger = new LoggerManager();
        }

        public override void OnException(ExceptionContext context)
        {
            var result = new ViewResult { ViewName = "CustomError" };
            var modelMetadata = new EmptyModelMetadataProvider();
            result.ViewData = new ViewDataDictionary(modelMetadata, context.ModelState);
            result.ViewData.Add("HandleException", context.Exception);
            context.Result = result;
            _logger.LogInformation(context.Exception.ToString());
            context.ExceptionHandled = true;
        }
    }
}