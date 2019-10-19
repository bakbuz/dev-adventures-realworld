using Conduit.Core;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Hosting;
using System.Net;

namespace Conduit.Api.Filters
{
    public class ExceptionFilter : IExceptionFilter
    {
        private readonly IWebHostEnvironment _hostingEnvironment;

        public ExceptionFilter(IWebHostEnvironment environment)
        {
            _hostingEnvironment = environment;
        }

        public void OnException(ExceptionContext context)
        {
            var status = (int)HttpStatusCode.InternalServerError;

            var result = _hostingEnvironment.IsDevelopment() ?
                new JsonResult(context.Exception) :
                new JsonResult(new Error("An unexpected internal server error has occurred."));

            context.HttpContext.Response.StatusCode = status;
            context.Result = result;
        }
    }
}
