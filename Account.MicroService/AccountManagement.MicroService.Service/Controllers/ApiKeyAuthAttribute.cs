//using System;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Mvc.Filters;
//using Microsoft.Extensions.Configuration;
//using Microsoft.Extensions.DependencyInjection;

//namespace AccountManagement.MicroService.Controllers
//{
//    [AttributeUsage( AttributeTargets.Method)]
//    public class ApiKeyAuthAttribute:Attribute,IAsyncActionFilter
//    {
//        private const string ApiHeaderKey = "ApiKey";
//        public ApiKeyAuthAttribute()
//        {
//        }
//        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
//        {
//            if(!context.HttpContext.Request.Headers.TryGetValue(ApiHeaderKey, out var passKey))
//            {
//                  context.Result = new UnauthorizedResult();
//                  return;
//            }
//            var config = context.HttpContext.RequestServices.GetRequiredService<IConfiguration>();
//            var apiKey = config.GetValue<string>("ApiKey");

//            if ( !apiKey.Equals(passKey))
//            {
//                context.Result = new UnauthorizedResult();
//                return;
//            }
//            await  next();
//        }
//    }
//}
