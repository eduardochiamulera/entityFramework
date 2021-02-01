using CpmPedidos.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace CpmPedidos.Repository.Maps
{
    public class PedidoMap : BaseDomainMap<Pedido>
    {
        PedidoMap() : base("tb_pedido") { }
        public override void Configure(EntityTypeBuilder<Pedido> builder)
        {
            base.Configure(builder);
        }
    }
}
