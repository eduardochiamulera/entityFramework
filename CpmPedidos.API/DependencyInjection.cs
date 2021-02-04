using CpmPedidos.Interface;
using CpmPedidos.Repository;
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
            //serviceProvider.AddScoped<Interface, ClasseConcreta>();
            serviceProvider.AddScoped<IProdutoRepository, ProdutoRepository>();
            serviceProvider.AddScoped<IPedidoRepository, PedidoRepository>();
            serviceProvider.AddScoped<ICidadeRepository, CidadeRepository>();

        }
    }
}
