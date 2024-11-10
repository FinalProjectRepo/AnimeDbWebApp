using Microsoft.Extensions.DependencyInjection;

using System;
using System.Linq;
using System.Reflection;

using static AnimeDbWebApp.Common.GeneralConstants;

namespace AnimeDbWebApp.Extensions
{
    public static class BuilderServicesExtensions
    {
        public static void RegisterServices(this IServiceCollection serviceProvider, Assembly assembly, string baseInterfaceName)
        {
            var services = assembly.GetTypes().Where(t => !t.IsAbstract && t.IsVisible);
            var interfaces = assembly.GetTypes().Where(t => t.IsAbstract);

            var baseInterface = interfaces.First(t => t.Name.Equals(baseInterfaceName));

            foreach (var service in services)
            {
                var currInterface = interfaces
                    .FirstOrDefault(t => t.Name.Equals(InterfacesPrefix + service.Name, 
                        StringComparison.InvariantCultureIgnoreCase));
                
                if (currInterface != null) serviceProvider.AddScoped(currInterface, service);
                else serviceProvider.AddScoped(baseInterface, service);
            }
        }
    }
}