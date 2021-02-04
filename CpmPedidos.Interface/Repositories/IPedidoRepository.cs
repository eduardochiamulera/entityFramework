using CpmPedidos.Domain;
using System.Collections.Generic;

namespace CpmPedidos.Interface
{
    public interface IPedidoRepository
    {
        decimal TicketMaximo();
        dynamic PedidosClientes();
    }
}
