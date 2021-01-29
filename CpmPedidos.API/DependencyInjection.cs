using Microsoft.Extensions.DependencyInjection;


namespace CpmPedidos.API
{
    public class DependencyInjection
    {
        public static void Register(IServiceCollection serviceProvider)
        {
            RepositorDependence(serviceProvider);
        }

        private static void RepositorDependence(IServiceCollection serviceProvider)
        {
        }
    }
}
