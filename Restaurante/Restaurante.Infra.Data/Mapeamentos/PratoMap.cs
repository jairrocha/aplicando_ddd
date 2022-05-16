using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Restaurante.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante.Infra.Data.Mapeamentos
{
    public class PratoMap : MapBase<Prato>
    {
        public override void Configure(EntityTypeBuilder<Prato> builder)
        {
            base.Configure(builder);
            builder.ToTable("Tb_Prato");

            builder.Property(c => c.Nome).IsRequired().HasColumnName("Nome").HasMaxLength(100);
            builder.Property(c => c.Preco).IsRequired().HasColumnName("Preco");
        }
    }
}
