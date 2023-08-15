//using APIRestLab01.Extensions;
//using Microsoft.AspNetCore.Diagnostics;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Mvc.Filters;
//using System.Net;
//using System.Runtime.CompilerServices;

//namespace APIRestLab01
//{
//    public class StartUp
//    {
//        public static class ServicesExtensions
//        {
//            public static void ConfigureServices(IServiceCollection services)
//            {
//                services.AddCors(options =>
//                {
//                    options.AddPolicy("CorsPolicy",
//                        builder => builder.AllowAnyOrigin()
//                        .AllowAnyMethod()
//                        .AllowAnyHeader());
//                });
//            }
//        }
//        public void ConfigureServices(IServiceCollection services)
//        {
//            services.ConfigureCors();
//            services.AddScoped<ModelValidationAttribute>();
//        }

//        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
//        {
//            app.UseExceptionHandler(config =>
//            {
//                config.Run(async context =>
//                {
//                    context.Response.StatusCode =
//                    (int)HttpStatusCode.InternalServerError;
//                    context.Response.ContentType = "application/json";

//                    var error =
//                    context.Features.Get<IExceptionHandlerFeature>();
//                    if (error != null)
//                    {
//                        var ex = error.Error;
//                        await context.Response.WriteAsync(new ErrorModel()
//                        {
//                            StatusCode = context.Response.StatusCode,
//                            ErrorMessage = ex.Message

//                        }.ToString();
//                    };
//                });
//            });
//        }

//        public class CustomExceptionMiddleware
//        {
//            public async Task Invoke (HttpContext httpContext)
//            {
//                try
//                {
//                    await _next(httpContext);
//                }
//                catch (Exception ex)
//                {
//                    _logger.LogError("Unhandled exception...", ex);
//                    await HandleExceptionAsync(httpContext, ex);
//                }
//            }

//            public static IApplicationBuilder UseCustomExceptionMiddleware(CallConvThiscall
//                IApplicationBuilder builder)
//            {
//                return builder.UseMiddleware<CustomExceptionMiddleware>();
//            }
//            app.UseCustomExceptionMiddleware();

//        }

//        public class ModelValidationAttribute : ActionFilterAttribute
//        {
//            public override void OnActionExecuted(ActionExecutedContext context)
//            {
//                if(!context.ModelState.IsValid)
//                {
//                    context.Result = new
//                        BadRequestObjectResult(context.ModelState);
//                }
//            }
//        }


//    }   
//}
