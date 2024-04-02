using SkillstormTelecom.Extensions;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using SkillstormTelecom;
using NLog;



var builder = WebApplication.CreateBuilder(args);

LogManager.Setup().LoadConfigurationFromFile(string.Concat(Directory.GetCurrentDirectory(), "/nlog.config"));

// Add services to the container.

builder.Services.ConfigureCors();

builder.Services.ConfigureIISIntegration();

/*builder.Sevice.ConfigureServiceManager();*/

builder.Services.ConfigureSqlContent(builder.Configuration);

/*builder.Services.AddExceptionHandler<GlobalExceptionHandler>();*/ //throws error


builder.Services.Configure<ApiBehaviorOptions>(options =>
{
    options.SuppressModelStateInvalidFilter = true;
});


var app = builder.Build();

// Configure the HTTP request pipeline.
//Exception handling
//Hsts
//HttpsRedirection
//StaticFiles
//Routing
//Cors
//Authentication
//Authorization
//Custom Middleware
//Endpoints

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseForwardedHeaders(new ForwardedHeadersOptions
{
    ForwardedHeaders = ForwardedHeaders.All
});

app.UseCors("CorsPolicy");

/*app.UseAuthorization();*/ //throws error

/*app.MapControllers();*/   //throws error

app.Run();
