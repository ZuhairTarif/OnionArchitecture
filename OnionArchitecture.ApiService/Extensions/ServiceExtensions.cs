using OnionArchitecture.Contracts;
using OnionArchitecture.LoggerService;

namespace OnionArchitecture.ApiService.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureCors(this IServiceCollection services) =>
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy", builder =>
                    builder.AllowAnyOrigin()
                        .WithMethods("POST", "GET", "PUT")
                        .AllowAnyHeader());
            });
        public static void ConfigureLoggerService(this IServiceCollection services) => 
            services.AddSingleton<ILoggerManager, LoggerManager>();
    }
}
