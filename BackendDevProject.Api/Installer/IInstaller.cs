using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BackendDevProject.Api
{
    public interface IInstaller
    {

        void InstallServices(IServiceCollection services, IConfiguration configuration);

    }
}
