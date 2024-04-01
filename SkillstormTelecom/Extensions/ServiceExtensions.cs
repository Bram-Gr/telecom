using Repository;
using Microsoft.EntityFrameworkCore;



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

        public static void ConfigureSqlContent(this IServiceCollection services, IConfiguration configuration) =>
            services.AddDbContext<RepositoryContext>(options =>
                           options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
                                           
    }
}
