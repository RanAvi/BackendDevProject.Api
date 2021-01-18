using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace BackendDevProject.Api.Installer
{
    public class SwaggerConfiguration : IInstaller
    {
        public void InstallServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddSwaggerGen(x =>
           {
               x.SwaggerDoc("v1", new OpenApiInfo() { Title = "BackendDev", Version = "V1" });


           });
        }
    }
}
