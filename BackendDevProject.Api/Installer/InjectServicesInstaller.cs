using BackendDevProject.Respository;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BackendDevProject.Api.Installer
{
    public class InjectServicesInstaller : IInstaller
    {
        public void InstallServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddControllersWithViews().AddXmlDataContractSerializerFormatters();



            // services.AddSingleton(new DatabaseConfiguration { Name = configuration["DatabaseName"]});

            var databaseConfiguration = new DatabaseConfiguration();

            configuration.GetSection("DatabaseConfig").Bind(databaseConfiguration);




            services.AddSingleton(databaseConfiguration);

            services.AddTransient<IDatabaseSetup, DatabaseSetup>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddTransient<IPostRepository, PostRepositoy>();

        }
    }
}
