using CidadeSemLimites.Communication.Responses;
using CidadeSemLimites.Exception;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace CidadeSemLimites.Api.Filters
{
    public class ExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            HandleProjectException(context);
        }
        private void HandleProjectException(ExceptionContext context)
        {
            var Exception = context.Exception as CidadeSemLimitesException;
            var errorResponse = new ResponseErrorJson(Exception!.GetErrors());
            context.HttpContext.Response.StatusCode = Exception.StatusCode;
            context.Result = new BadRequestObjectResult(errorResponse);
        }
    }
}
