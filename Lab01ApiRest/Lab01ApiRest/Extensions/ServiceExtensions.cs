using System.IO.Pipes;

namespace Lab01ApiRest.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureCors(this IServiceCollection services) => services.AddCors(options =>
        {
            options.AddPolicy("CorsPolicy", builder => builder
            .AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader());

        });

        public static void ConfigureIISIntegration(this IServiceCollection services) => services 
            .Configure<IISOptions>(OptionsBuilderConfigurationExtensions=>{});
    }
}
