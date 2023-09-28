using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;
using System.Net;
using System.Text;

namespace IntuitChallenge.Filters
{
    public class ExceptionFilter : ExceptionFilterAttribute
    {
       private readonly ILogger<ExceptionFilter> _logger;
        public ExceptionFilter(ILogger<ExceptionFilter> logger)
        {
            _logger = logger;
        }
        public override async Task OnExceptionAsync(ExceptionContext context)
        {
           

            var statusCode = HttpStatusCode.InternalServerError;
            string RequestId = System.Diagnostics.Activity.Current?.Id;
            string TraceIdentifier = context.HttpContext.TraceIdentifier;

            _logger.LogError(context.Exception, $"TraceId: {RequestId} - HttpTraceId: {TraceIdentifier}");

            context.HttpContext.Response.ContentType = "application/json";
            context.HttpContext.Response.StatusCode = (int)statusCode;
            await Task.Delay(1);

            switch (context.Exception)
            {
                case DbUpdateException e:
                    var sb = new StringBuilder();
                    sb.AppendLine($"DbUpdateException error - {e?.InnerException?.InnerException?.Message}");

                    foreach (var eve in e.Entries)
                    {
                        sb.AppendLine($"Entidad de tipo {eve.Entity.GetType().Name} en estado {eve.State} no se pudo actualizar");
                    }

                    _logger.LogError(e, $"TraceId: {RequestId} - HttpTraceId: {TraceIdentifier} - Msg: {sb}");
                    context.Result = new JsonResult(new
                    {
                        Title = "Ha ocurrido un error al intentar actualizar la base de datos ",
                        Error = sb.ToString(),
                        RequestId,
                        TraceIdentifier,

                    }); ;
                    break;

                default:
                    _logger.LogError(context.Exception, $"TraceId: {RequestId} - HttpTraceId: {TraceIdentifier}");
                    context.Result = new JsonResult(new
                    {
                        Title = "Ha ocurrido un error procesando su solicitud.",
                        Error = context.Exception.Message,
                        RequestId,
                        TraceIdentifier,

                    });
                    break;
            }



        }

    }
}
