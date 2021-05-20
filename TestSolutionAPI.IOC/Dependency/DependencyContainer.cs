using Microsoft.Extensions.DependencyInjection;
using TestSolutionAPI.SERVICES.Interfaces;
using TestSolutionAPI.SERVICES.Services;

namespace TestSolutionAPI.IOC.Dependency
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            #region Dependency
            services.AddScoped<IAddUsserService, AddUsserService>();
            #endregion

            #region Services
            #endregion
        }
    }
}
