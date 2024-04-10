
using Contracts;  
using Microsoft.EntityFrameworkCore;
using Repository;
using Service;
using Service.Contracts;
using LoggerService;
using Microsoft.OpenApi.Models;




namespace SkillstormTelecom.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureCors(this IServiceCollection services)=>
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy", builder =>
                    builder.AllowAnyOrigin()
                        .AllowAnyMethod()
                        .AllowAnyHeader());
                });

        public static void ConfigureIISIntegration(this IServiceCollection services) =>  
            services.Configure<IISOptions>(options =>
            {
              //  options.AutomaticAuthentication = false;
              //  options.AuthenticationDisplayName = "Windows";
              //  options.ForwardClientCertificate = false;
              //  options.ForwardWindowsAuthentication = false;
            });

        public static void ConfigureLoggerService(this IServiceCollection services) =>
            services.AddSingleton<ILoggerManager, LoggerManager>();

        public static void ConfigureRepositoryManager(this IServiceCollection services) =>
            services.AddScoped<IRepositoryManager, RepositoryManager>();

        public static void ConfigureServiceManager(this IServiceCollection services) =>
            services.AddScoped<IServiceManager, ServiceManager>();

        public static void ConfigureSqlContext(this IServiceCollection services, IConfiguration configuration) =>
            services.AddDbContext<RepositoryContext>(options =>
                           options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

        public static void ConfigureSwagger(this IServiceCollection services) =>
        services.AddSwaggerGen(s =>
        {
            s.SwaggerDoc("v1", new OpenApiInfo { Title = "SkillstormTelecom", Version = "v1" });
        });

    }
}
