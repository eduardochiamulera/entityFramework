using CpmPedidos.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace CpmPedidos.Repository.Maps
{
    public class ImagemMap : BaseDomainMap<Imagem>
    {
        ImagemMap() : base("tb_imagem") { }
        public override void Configure(EntityTypeBuilder<Imagem> builder)
        {
            base.Configure(builder);
        }
    }
}
