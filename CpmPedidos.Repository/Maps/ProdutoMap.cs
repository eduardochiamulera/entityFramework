using CpmPedidos.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace CpmPedidos.Repository.Maps
{
    public class ProdutoMap : BaseDomainMap<Produto>
    {
        ProdutoMap() : base("tb_produto") { }
        public override void Configure(EntityTypeBuilder<Produto> builder)
        {
            base.Configure(builder);
        }
    }
}
