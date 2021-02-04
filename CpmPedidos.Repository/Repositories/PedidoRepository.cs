using CpmPedidos.Domain;
using CpmPedidos.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CpmPedidos.Repository
{
    public class PedidoRepository : BaseRepository, IPedidoRepository
    {
        public PedidoRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }


        public decimal TicketMaximo()
        {
            var hoje = DateTime.Now;

            return DbContext.Pedidos
                .Where(x => x.CriadoEm.Date == hoje)
                .Max(x => (decimal?)x.ValorTotal) ?? 0;
        }

        public dynamic PedidosClientes()
        {
            var hoje = DateTime.Now;
            var inicioMes = new DateTime(hoje.Year, hoje.Month, 1);
            var finalMes = new DateTime(hoje.Year, hoje.Month, DateTime.DaysInMonth(hoje.Year, hoje.Month));
            return DbContext.Pedidos
                .Where(x => x.CriadoEm.Date >= inicioMes && x.CriadoEm <= finalMes)
                .GroupBy(
                    pedido => new { pedido.IdCliente, pedido.Cliente.Nome },
                    (chave, pedidos) => new
                    {
                        Cliente = chave.Nome,
                        Pedidos = pedidos.Count(),
                        Total = pedidos.Sum(pedido => pedido.ValorTotal)
                    }
                    )
                //.Select(x => new
                //{
                //    //cliente é a chave do agrupador
                //    Cliente = x.Key.Nome,
                //    Pedidos = x.Count(),
                //    Total = x.Sum(p => p.ValorTotal)
                //})
                //.GroupBy(pedido => new { pedido.IdCliente, pedido.Cliente.Nome})
                //.Select(x => new
                //{
                //    //cliente é a chave do agrupador
                //    Cliente = x.Key.Nome,
                //    Pedidos = x.Count(),
                //    Total = x.Sum(p => p.ValorTotal)
                //})
                .ToList();
        }
    }
}
