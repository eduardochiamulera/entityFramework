using CpmPedidos.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace CpmPedidos.Repository.Maps
{
    public class PromocaoProdutoMap : BaseDomainMap<PromocaoProduto>
    {
        PromocaoProdutoMap() : base("tb_promocaoProduto") { }
        public override void Configure(EntityTypeBuilder<PromocaoProduto> builder)
        {
            base.Configure(builder);
        }
    }
}
